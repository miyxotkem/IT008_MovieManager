using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DTO
{
    public class Seat
    {
        private int idSeat;
        private int idScreen;
        private string seatRow;
        private int seatNumber;
        private string seatType;

        public int IdSeat { get => idSeat; set => idSeat = value; }
        public string SeatRow { get => seatRow; set => seatRow = value; }
        public int SeatNumber { get => seatNumber; set => seatNumber = value; }
        public string SeatType { get => seatType; set => seatType = value; }
        public int IdScreen { get => idScreen; set => idScreen = value; }

        public Seat(DataRow row)
        {
            idSeat = Convert.ToInt32(row["id"]);
            idScreen = Convert.ToInt32(row["idScreen"]);
            seatRow = (string)row["row"];
            seatNumber = Convert.ToInt32(row["number"]);
            seatType = (string)row["type"];
        }

        public Seat() { }
    }
}
