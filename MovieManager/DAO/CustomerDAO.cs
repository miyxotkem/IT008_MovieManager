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

        private Customer currentCustomer = null;
        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return CustomerDAO.instance; }
            private set { CustomerDAO.instance = value; }
        }

        public Customer CurrentCustomer { get => currentCustomer; set => currentCustomer = value; }

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

        public Customer CheckExistCustomer(string phonenumber)
        {
            Customer customer = null;
            string querry = "Select * from Customer where phone_number is not null and phone_number = @phone";
            DataTable table = DataProvider.Instance.ExecuteQuery(querry, new object[] { phonenumber });
            if (table.Rows.Count > 0)
            {
                customer = new Customer(table.Rows[0]);
            }
            return customer;
        }

        public void AddCustomer(string phonenumber)
        {
            string querry = "insert into Customer (phone_number, money_spent) values ( @phone , 0)";
            int data = DataProvider.Instance.ExecuteNonQuery(querry, new object[] { phonenumber });
        }

        public void IncreaseCustomerSpend(int idCustomer, float amount)
        {
            string querry = "update Customer set money_spent = money_spent + @amount where id = @id ";
            int data = DataProvider.Instance.ExecuteNonQuery(querry, new object[] {amount,  idCustomer});
        }
    }
}
