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

 IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'SP_MyTableSave')
                    BEGIN
                        DROP PROCEDURE SP_MyTableSave;
                        EXEC('
                            CREATE PROCEDURE SP_MyTableSave
                                @Id int,
                                @Name NVARCHAR(50),
                                @Age varchar(100),
                                @Gender varchar(50)
                            AS
                            BEGIN
                                INSERT INTO MyTable (Id, Name, Age, Gender)
                                VALUES (@Id, '''', '''', @Gender);
                            END;
                        ');
                       -- PRINT 'Stored procedure SP_MyTableSave updated.';
                    END
                    ELSE
                    BEGIN
                        EXEC('
                            CREATE PROCEDURE SP_MyTableSave
                                @Id int,
                                @Name NVARCHAR(50),
                                @Age varchar(100),
                                @Gender varchar(50)
                            AS
                            BEGIN
                                INSERT INTO MyTable (Id, Name, Age, Gender)
                                VALUES (@Id, @Name, @Age, @Gender);
                            END;
                        ');
                       -- PRINT 'Stored procedure SP_MyTableSave created.';
                    END
";
            C_Common.dbExecuteTrigger(strTableQuery);

        }
    }
}
