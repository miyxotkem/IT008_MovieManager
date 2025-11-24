using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DAO
{
    public class ForgetPassUsernameDAO
    {
        private static ForgetPassUsernameDAO instance;
        
        public static ForgetPassUsernameDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ForgetPassUsernameDAO();
                }
                return ForgetPassUsernameDAO.instance;
            }
            private set
            {
                ForgetPassUsernameDAO.instance = value;
            }
        }

        private ForgetPassUsernameDAO() { }

        public bool CheckValidUsername(string username)
        {
            string querry = "Exec USP_ForgetPassUsername @username";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(querry, new object[] { username });
            return dataTable.Rows.Count > 0;
        }

        public int GetIDStaffFromAccount(string username)
        {
            string querry = "Exec USP_ForgetPassGetIDStaff @username";
            DataTable data = DataProvider.Instance.ExecuteQuery(querry, new object[] { username });
            if (data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0]["idStaff"]);
            }
            return -1;
        }

        public void InsertValueIntoForgetTable(int id, string verify)
        {
            string querry = "Exec USP_InsertIntoForgetTable @id , @username";
            int data = DataProvider.Instance.ExecuteNonQuery(querry, new object[] { id, verify });
        }

        public string GetEmailFromUser(string username)
        {
            string querry = "Exec USP_GetEmailFromUser @username";
            DataTable data = DataProvider.Instance.ExecuteQuery(querry, new object[] { username });
            string email = "";
            if (data.Rows.Count > 0)
            {
                email = Convert.ToString(data.Rows[0]["email"]);
            }
            return email;
        }

        public void EraseVerificationCode(int id, string verify)
        {
            string querry = "Exec USP_EraseVerification @id , @verify";
            int data = DataProvider.Instance.ExecuteNonQuery(querry, new object[] { id, verify });
        }

        public bool CheckVerificationCode(int id, string verify)
        {
            string querry = "Exec USP_CheckVerify @id , @verify";
            DataTable data = DataProvider.Instance.ExecuteQuery(querry, new object[] {id, verify});
            return data.Rows.Count > 0;
        }

        public void UpdatePassword(string username, string password)
        {
            string querry = "Exec USP_UpdateNewPassword @username , @pass";
            int data = DataProvider.Instance.ExecuteNonQuery(querry, new object[] { username, password });
        }
    }
}
