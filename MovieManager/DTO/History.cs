using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DTO
{
    public class History
    {
        private int id;
        private int idsnack;
        private int quantity;
        private DateTime date;

        public int Id { get => id; set => id = value; }
        public int Idsnack { get => idsnack; set => idsnack = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public DateTime Date { get => date; set => date = value; }
        public History(int id, int idsnack, int quantity, DateTime date)
        {
            this.Id = id;
            this.Idsnack = idsnack;
            this.Quantity = quantity;
            this.Date = date;
        }
        public History(DataRow row)
        {
            this.id = (int)row["id"];
            this.idsnack = (int)row["idSnack"];
            this.quantity = (int)row["quantity"];
            this.date = (DateTime)row["date"];
        }
    }
}
