using MovieManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string username, string password)
        {
            string query = "USP_Login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {username, password});
            return (result.Rows.Count > 0 && Convert.ToBoolean(result.Rows[0]["Accept"]));
        }

        public void AddAccountFromSignUp(string user, string pass, string fullname, string email)
        {
            string querryAddStaff = "Exec USP_AddStaff @name , @email";
            int data1 = DataProvider.Instance.ExecuteNonQuery(querryAddStaff, new object[] { fullname, email });
            string querryGetID = "Select id from Staff where name = N'" + fullname + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(querryGetID);
            if (data.Rows.Count > 0)
            {
                int idStaff = Convert.ToInt32(data.Rows[0]["id"]);
                string querryAddAccount = "Exec USP_AddAccount @user , @pass , @idStaff";
                int data2 = DataProvider.Instance.ExecuteNonQuery(querryAddAccount, new object[] { user, pass, idStaff });
            }    
        }

        public Account GetAccountFromUser(string user)
        {
            Account account = null;
            string querry = "select * from Account where username = '" + user + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(querry);
            if (data.Rows.Count > 0 )
            {
                account = new Account(data.Rows[0]);
            }    
            return account; 
        }
        public List<Account> LoadAccountList()
        {
            List<Account> AccountList = new List<Account>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetAccountList");
            foreach (DataRow row in data.Rows)
            {
                Account Account = new Account(row);
                AccountList.Add(Account);
            }
            return AccountList;
        }

        public bool CheckAccountExist(string user)
        {
            string query = "Select * from Account where username = @user";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] {user});
            return table.Rows.Count > 0;
        }
    }
}
