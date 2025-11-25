using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DTO
{
    public class AccountInfo
    {
        private int iD;
        private string userName;
        private string email;
        private string fullName;
        private string role;

        public AccountInfo(int _iD, string _userName, string _email, string _fullName, string _role)
        {
            iD = _iD;
            userName = _userName;
            email = _email;
            fullName = _fullName;
            role = _role;
        }

        public AccountInfo() { }

        public AccountInfo(DataRow row)
        {
            this.iD =(int)row["ID"];
            this.email = (string)row["email"];
            this.userName = (string)row["username"];
            this.fullName = (string)row["name"];
            this.role = (string)row["Role"];
        }




        #region Property
        public int ID { get => iD; set => iD = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Email { get => email; set => email = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Role { get => role; set => role = value; }

        #endregion
    }
}
