using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbUpdate
{
    class clsCreateSP
    {
        clsCommonDb C_Common = new clsCommonDb();
        public void CreateStrdProcedure()
        {
			

			string strTableQuery = @"
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'AccountLedgerGetByGroup')
			                   BEGIN
			                        DROP PROCEDURE AccountLedgerGetByGroup;
			                        END
			                       GO
CREATE PROCEDURE [dbo].[AccountLedgerGetByGroup]

	@groupId varchar(50),
	@branchId varchar(50),
	@startText varchar(max)
AS
BEGIN
WITH GroupInMainGroup (groupId,HierarchyLevel) AS
(
select groupId,
1 as HierarchyLevel
from tbl_AccountGroup --where groupId = @groupId
where groupId=(CASE WHEN @groupId<>'0' THEN @groupId END) OR
	(
		(groupId=(CASE WHEN @groupId='0' THEN '1' END )) OR 
		(groupId=(CASE WHEN @groupId='0' THEN '2' END ))OR
		(groupId=(CASE WHEN @groupId='0' THEN '3' END ))OR
		(groupId=(CASE WHEN @groupId='0' THEN '4' END ))
	)
UNION ALL
select e.groupId,
G.HierarchyLevel + 1 AS HierarchyLevel
from tbl_AccountGroup as e,GroupInMainGroup G
where e.groupUnder=G.groupId
)

	SELECT 
		A.ledgerId, 
		A.ledgerName
	--FROM tbl_AccountLedger AS A where groupId IN (select groupId from GroupInMainGroup) and (branchId=@branchId)
	--ORDER BY ledgerName
	
	FROM tbl_AccountLedger AS A where 
	ledgerName LIKE @startText+'%'
	AND groupId IN (select groupId from GroupInMainGroup) and branchId=@branchId and ledgerName not in(SELECT  taxName FROM   tbl_TaxMaster where branchId=@branchId)
	order by ledgerName 
END
GO

--------------------------------------------------------------------
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'AccountLedgerGetByGroupWithBalance')
			                   BEGIN
			                        DROP PROCEDURE AccountLedgerGetByGroupWithBalance;
			                   END
			                       GO
CREATE PROCEDURE [dbo].[AccountLedgerGetByGroupWithBalance]

	@groupId varchar(50),
	@branchId varchar(50)
AS
BEGIN
WITH GroupInMainGroup (groupId,HierarchyLevel) AS
(
select groupId,
1 as HierarchyLevel
from tbl_AccountGroup where groupId = @groupId
UNION ALL
select e.groupId,
G.HierarchyLevel + 1 AS HierarchyLevel
from tbl_AccountGroup as e,GroupInMainGroup G
where e.groupUnder=G.groupId
)
SELECT 

	TEMP.ledgerId,
	TEMP.ledgerName,
	CASE WHEN TEMP.balance=0 THEN 
	       CAST (CAST( ROUND(TEMP.balance ,tbl_Currency.noOfDecimalPlace)AS DECIMAL(24,2))AS VARCHAR)
	WHEN TEMP.balance>0 THEN
	CAST (CAST( ROUND(TEMP.balance ,tbl_Currency.noOfDecimalPlace)AS DECIMAL(24,2))AS VARCHAR)+ 'Dr'
			--CAST (ROUND(TEMP.balance,tbl_Currency.noOfDecimalPlace)AS VARCHAR)+ 'Dr'
	ELSE 
	CAST (CAST( ROUND(-TEMP.balance ,tbl_Currency.noOfDecimalPlace)AS DECIMAL(24,2))AS VARCHAR)+ 'Cr'
			
			--CAST (ROUND((-TEMP.balance),tbl_Currency.noOfDecimalPlace) AS VARCHAR)+'Cr'
			
	END as balance
	--,TEMP.currencyId
	
FROM (
	SELECT 
		A.ledgerId, 
		A.ledgerName,
		CASE WHEN (SELECT COUNT(*)
			FROM tbl_LedgerPosting AS L1 WHERE L1.ledgerId = A.ledgerId AND L1.optional='False' AND L1.branchId=@branchId)>0 THEN
		   
			(SELECT SUM(ISNULL(L.debit, 0)) - SUM(ISNULL(L.credit, 0)) 
			FROM tbl_LedgerPosting AS L WHERE L.ledgerId = A.ledgerId AND L.optional='False' AND L.branchId=@branchId)
		    
		    ELSE 
		    
		     0 
		    		    
		    END  AS balance
		   ,A.currencyId
		    
			FROM tbl_AccountLedger AS A where groupId IN (select groupId from GroupInMainGroup) and branchId=@branchId) AS TEMP INNER JOIN tbl_Currency ON TEMP.currencyId=tbl_Currency.currencyId
END
GO

";
            C_Common.dbExecuteTrigger(strTableQuery);

        }
    }
}
