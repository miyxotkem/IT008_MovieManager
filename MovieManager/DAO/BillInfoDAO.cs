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
            int data = DataProvider.Instance.ExecuteNonQuery(querry, new object[] { idBill, category, iddetail, quantity, discount, price }) ;
        }

        public List<BillInfo> GetListBillInfoFromBillID(int idBill)
        {
            List<BillInfo> list = new List<BillInfo>();
            string querry = "select * from BillInfo where idBill = @id";
            DataTable table = DataProvider.Instance.ExecuteQuery(querry, new object[] {idBill}) ;   
            
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

        public bool CheckExistingFilmInBill(int idBill)
        {
            string querry = "Select * from BillInfo where Category = 'Ticket' and idBill = @id ";
            DataTable table = DataProvider.Instance.ExecuteQuery(querry, new object[] {idBill });
            if (table.Rows.Count > 0)
            {
                return true;
            }    
            return false;
        }
    }
}
