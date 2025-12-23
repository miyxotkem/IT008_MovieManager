using MovieManager.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace MovieManager.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillInfoDAO();
                }
                return BillInfoDAO.instance;

            }
            private set
            {
                BillInfoDAO.instance = value;
            }
        }

        private BillInfoDAO() { }

        public void AddBillInfoIntoBillID(int idBill, string category, int iddetail, int quantity, int discount, float price)
        {
            string querry = "insert into BillInfo (idBill, Category, idDetail, Quantity, Discount, Price) values ( @idBill , @Cate , @idDetail , @Quantity , @Dis , @Price )";
            int data = DataProvider.Instance.ExecuteNonQuery(querry, new object[] { idBill, category, iddetail, quantity, discount, price });
        }

        public List<BillInfo> GetListBillInfoFromBillID(int idBill)
        {
            List<BillInfo> list = new List<BillInfo>();
            string querry = "select * from BillInfo where idBill = @id";
            DataTable table = DataProvider.Instance.ExecuteQuery(querry, new object[] { idBill });

            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    BillInfo billInfo = new BillInfo(row);
                    list.Add(billInfo);
                }
            }
            return list;
        }

        public BillInfo GetBillInfoTicket(int idBill)
        {
            BillInfo billinfo = null;
            string query = "select * from BillInfo where idBill = @id and Category = 'Ticket' ";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { idBill });
            if (table.Rows.Count>0)
            {
                billinfo = new BillInfo(table.Rows[0]);
            }
            return billinfo;
        }
        public bool CheckExistingFilmInBill(int idBill)
        {
            string querry = "Select * from BillInfo where Category = 'Ticket' and idBill = @id ";
            DataTable table = DataProvider.Instance.ExecuteQuery(querry, new object[] { idBill });
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public int StackItemInBillInfo(int quan, int idBill, int idDetail)
        {
            string querry = "update BillInfo set Quantity = Quantity + @quan where idBill = @id and Category = 'Food and Drink' and idDetail = @detail ";
            int data = DataProvider.Instance.ExecuteNonQuery(querry, new object[] {quan,  idBill, idDetail });
            return data;
        }

        public void DeleteFromBillInfo(int idBill)
        {
            string query = "Delete from BillInfo where idBill = @id ";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] {idBill}); 
        }

        public void ApplyDiscountForTicket(int idBill, int dis)
        {
            string query = "Update BillInfo set Discount = @dis where idBill = @id and Category = 'Ticket'";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] {dis, idBill});
        }

        public void ResetTicketDiscount(int idBill)
        {
            string query = "Update BillInfo set Discount = 0 where idBill = @id and Category = 'Ticket'";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] {  idBill });
        }
    }
}
