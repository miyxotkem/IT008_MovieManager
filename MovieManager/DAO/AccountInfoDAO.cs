using MovieManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DAO
{
    public class AccountInfoDAO
    {
        private static AccountInfoDAO instance;

        public static AccountInfoDAO Instance 
        { 
            get
            {
                if (instance == null)
                {
                    instance = new AccountInfoDAO();
                }
                return AccountInfoDAO.instance;
            }
            private set
            {
                AccountInfoDAO.instance = value;
            }
        }

       

        public AccountInfoDAO() { }

        public AccountInfo GetAccountInfoFromUser(string username)
        {
            string querry = "Exec USP_GetAccountInfoFromUser @username";
            DataTable table = DataProvider.Instance.ExecuteQuery(querry, new object[] { username });
            if (table.Rows.Count > 0)
            {
                AccountInfo act = new AccountInfo(table.Rows[0]);
                return act;
            }
            return null;
        }
    }
}
