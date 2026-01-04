using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeKit.Tnef;
using MovieManager.DTO;
using OpenTK.Graphics.ES11;
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

        public void CreateBill(int idStaff)
        {
            int data = -1;
            string querry = "insert into Bill (idCustomer, idStaff) values ( null , @id )";
            data = DataProvider.Instance.ExecuteNonQuery(querry, new object[] {idStaff});
        }

        public Bill GetUncheckedBill()
        {
            Bill bill = null;
            string querry = "select * from Bill where bill_status = 0";
            DataTable table = DataProvider.Instance.ExecuteQuery(querry);
            if (table.Rows.Count > 0)
            {
                bill = new Bill(table.Rows[0]);
            }
            return bill;
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

        public void UpdateCustomerID(int idBill, int idCus)
        {
            string query = "update Bill set idCustomer = @idCus where idBill = @id ";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] {idCus, idBill});
        }

        public bool CheckValidCustomer(int idBill)
        {
            string query = "select * from Bill where idBill = @id and idCustomer is not null";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { idBill });
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public void ApplyVoucherForBill(int idBill, int idVoucher)
        {
            string query = "Update Bill set idVoucher = @idv where idBill = @idb ";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idVoucher, idBill });
        }

        public Bill GetBill(int idBill)
        {
            Bill bill = null;
            string query = "Select * from Bill where idBill = @id ";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { idBill });
            if (table.Rows.Count > 0)
            {
                bill = new Bill(table.Rows[0]);
            }
            return bill;
        }
        public void DeleteBill(int idBill)
        {
            string query = "Delete from Bill where idBill = @id ";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBill });
        }
    }
}
