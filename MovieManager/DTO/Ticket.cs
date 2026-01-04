using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DTO
{
    public class Ticket
    {
        int idTicket;
        int idBill;
        float price;
        int idMovie;
        DateTime start_time;
        int idSeat;

        public int IdTicket { get => idTicket; set => idTicket = value; }
        public float Price { get => price; set => price = value; }
        public int IdMovie { get => idMovie; set => idMovie = value; }
        public DateTime Start_time { get => start_time; set => start_time = value; }
        public int IdSeat { get => idSeat; set => idSeat = value; }
        public int IdBill { get => idBill; set => idBill = value; }

        public Ticket(DataRow row)
        {
            this.idTicket = Convert.ToInt32(row["id"]);
            this.idBill = Convert.ToInt32(row["idBill"]);
            this.price = (float)Convert.ToDouble(row["price"]);
            this.idMovie = Convert.ToInt32(row["idmovie"]);
            this.start_time = (DateTime)row["Start_time"];
            this.idSeat = Convert.ToInt32(row["idSeat"]);
        }
    }
}
