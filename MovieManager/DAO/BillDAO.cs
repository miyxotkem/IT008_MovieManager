using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManager.DTO;
namespace MovieManager.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillDAO();
                }
                return BillDAO.instance;
            }
            private set
            {
                BillDAO.instance = value;   
            }
        }

        private BillDAO() { }

        public void CreateBill(int idCustomer)
        {
            string querry = "insert into Bill (idCustomer) values ( @id )";
            int data = DataProvider.Instance.ExecuteNonQuery(querry, new object[] { idCustomer });
        }

        public Bill GetIDBillFromIDCustomer(int idCustomer)
        {
            Bill bill = null;
            string querry = "select * from Bill where idCustomer = @id and bill_status = 0"; // tìm những bill chưa được pay
            DataTable table = DataProvider.Instance.ExecuteQuery(querry, new object[] { idCustomer });  
            if (table.Rows.Count > 0)
            {
                bill = new Bill(table.Rows[0]);
            }
            return bill;
        }
    }
}
