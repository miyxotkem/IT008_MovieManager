using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManager.DTO;
namespace MovieManager.DAO
{
    public class TicketDAO
    {
        private static TicketDAO instance;

        public static TicketDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TicketDAO(); 
                }
                return TicketDAO.instance;
            }
            private set
            {
                TicketDAO.instance = value;
            }
        }

        private TicketDAO() { }

        public void CreateTicket(float price, int idMovie, DateTime Start_time, int idStaff, int idSeat, int idBill)
        {
            string querry = "insert into Ticket (price, idmovie, Start_time, idstaff, idSeat, idBill) values ( @price , @idmovie , @start , @idStaff , @idSeat , @idBill )";
            int data = DataProvider.Instance.ExecuteNonQuery(querry, new object[] { price, idMovie, Start_time, idStaff, idSeat, idBill });
        }

        public List<Ticket> GetTicketsFromBill(int idBill)
        {
            List<Ticket> list = new List<Ticket> ();    
            string query = "Select * from Ticket where idBill = @id ";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { idBill });
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    Ticket tic = new Ticket(row);
                    list.Add(tic);
                }    
            }    
            return list;
        }

        public void DeleteTicket(int idBill)
        {
            string query = "Delete from Ticket where idBill = @id ";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBill });
        }
    }
}
