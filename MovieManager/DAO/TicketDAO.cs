using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
