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
        DateTime purchase_date;
        int idMovie;
        DateTime start_time;
        int idStaff;
        int idSeat;

        public int IdTicket { get => idTicket; set => idTicket = value; }
        public float Price { get => price; set => price = value; }
        public DateTime Purchase_date { get => purchase_date; set => purchase_date = value; }
        public int IdMovie { get => idMovie; set => idMovie = value; }
        public DateTime Start_time { get => start_time; set => start_time = value; }
        public int IdStaff { get => idStaff; set => idStaff = value; }
        public int IdSeat { get => idSeat; set => idSeat = value; }
        public int IdBill { get => idBill; set => idBill = value; }

        public Ticket(DataRow row)
        {
            this.idTicket = Convert.ToInt32(row["id"]);
            this.idBill = Convert.ToInt32(row["idBill"]);
            this.price = (float)Convert.ToDouble(row["price"]);
            this.purchase_date = (DateTime)row["purchase_date"];
            this.idMovie = Convert.ToInt32(row["idmovie"]);
            this.start_time = (DateTime)row["Start_time"];
            this.idStaff = Convert.ToInt32(row["idstaff"]);
            this.idSeat = Convert.ToInt32(row["idSeat"]);
        }
    }
}
