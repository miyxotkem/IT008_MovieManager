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
    }
}
