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
            int data = -1;
            string querry = "insert into Bill (idCustomer) values ( @id )";
            if (idCustomer == -1) // --> Khách vãng lai
            {
                querry = "insert into Bill (idCustomer) values ( null )";
                data = DataProvider.Instance.ExecuteNonQuery(querry);
                return;
            }    
            data = DataProvider.Instance.ExecuteNonQuery(querry, new object[] { idCustomer });
        }

        public Bill GetIDBillFromIDCustomer(int idCustomer)
        {
            Bill bill = null;
            string querry = "select * from Bill where idCustomer = @id and bill_status = 0"; // tìm những bill chưa được pay
            DataTable table = new DataTable();  
            if (idCustomer == -1)
            {
                querry = "select * from Bill where idCustomer is null and bill_status = 0";
                table = DataProvider.Instance.ExecuteQuery(querry); 
            }
            else
            {
                table = DataProvider.Instance.ExecuteQuery(querry, new object[] { idCustomer });
            } 
            if (table.Rows.Count > 0)
            {
                bill = new Bill(table.Rows[0]);
            }
            return bill;
        }

        public bool ExistUncheckedBill()
        {
            string querry = "select * from Bill where bill_status = 0";
            DataTable table = DataProvider.Instance.ExecuteQuery(querry);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
                
        }

        public void PayBill(int idBill, string method)
        {
            string querry = "update Bill set bill_status = 1, payment_method = @method where idBill = @id and bill_status = 0";
            int data = DataProvider.Instance.ExecuteNonQuery(querry, new object[] { method, idBill });
        }
    }
}
