using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DAO
{
    public class AdminDAO
    {
        private static AdminDAO instance;

        public static AdminDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AdminDAO();  
                }
                return AdminDAO.instance;
            }
            private set
            {
                AdminDAO.instance  = value; 
            }
        }

        private AdminDAO() { }

        public void UpdateAccount(int IDStaff, string FullName, string Email, string username)
        {
            string querry1 = "update Staff set name = N'" + FullName + "', contact_info = '" + Email +"' where id = " + IDStaff;
            int data = DataProvider.Instance.ExecuteNonQuery(querry1);
            string querry2 = "update Account set username = '" + username + "' where idStaff = " + IDStaff;
            data = DataProvider.Instance.ExecuteNonQuery(querry2);
        }



    }
}
