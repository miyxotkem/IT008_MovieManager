using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManager.DTO;
using System.Data;
namespace MovieManager.DAO
{
    public class SeatDAO
    {
        private static SeatDAO instance;
        
        public static SeatDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SeatDAO();   
                }
                return SeatDAO.instance;
                    
            }
            private set
            {
                SeatDAO.instance = value;
            }
        }

        private SeatDAO() { }

        public Seat GetSeatInfoFromSeatID(int IDSeat)
        {
            Seat seatInfo = null;
            string querry = "Select * from Seat where id = " + IDSeat;

            DataTable table = DataProvider.Instance.ExecuteQuery(querry);

            if (table.Rows.Count > 0)
            {
                Seat seat = new Seat(table.Rows[0]);
                seatInfo = seat;
            }    
            return seatInfo;
        }
    }
}
