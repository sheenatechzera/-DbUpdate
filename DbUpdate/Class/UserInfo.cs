using System;    
using System.Collections.Generic;    
using System.Text;
//<summary>    
//Summary description for UserInfo    
//</summary>    
namespace DbUpdate
{
    class UserInfo
    {
        private string _userId;
        private string _branchId;
        private string _userName;
        private string _password;
        private string _userGroupId;
        private bool _active;
        private DateTime _extraDate;
        private string _extra1;
        private string _extra2;

        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public string BranchId
        {
            get { return _branchId; }
            set { _branchId = value; }
        }
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string UserGroupId
        {
            get { return _userGroupId; }
            set { _userGroupId = value; }
        }
        public bool Active
        {
            get { return _active; }
            set { _active = value; }
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
