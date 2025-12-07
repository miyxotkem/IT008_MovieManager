using MovieManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return CustomerDAO.instance; }
            private set { CustomerDAO.instance = value; }
        }

        private CustomerDAO() { }

        public List<Customer> LoadCustomerList()
        {
            List<Customer> CustomerList = new List<Customer>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetCustomerList");
            foreach (DataRow row in data.Rows)
            {
                Customer Customer = new Customer(row);
                CustomerList.Add(Customer);
            }
            return CustomerList;
        }
    }
}
