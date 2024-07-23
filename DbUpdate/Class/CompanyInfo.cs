using System;    
using System.Collections.Generic;    
using System.Text;
//<summary>    
//Summary description for CompanyInfo    
//</summary>    
namespace DbUpdate
{
    class CompanyInfo
    {
        string _companyId;
        private string _companyName;
        private DateTime _startDate;
        private DateTime _extraDate;
        private string _extra1;
        private string _extra2;

        public string CompanyId
        {
            get { return _companyId; }
            set { _companyId = value; }
        }
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }
        public DateTime ExtraDate
        {
            get { return _extraDate; }
            set { _extraDate = value; }
        }
        public string Extra1
        {
            get { return _extra1; }
            set { _extra1 = value; }
        }
        public string Extra2
        {
            get { return _extra2; }
            set { _extra2 = value; }
        }

    }
}
