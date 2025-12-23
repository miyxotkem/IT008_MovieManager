using OpenTK.Graphics.ES20;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DTO
{
    public class Screen
    {
        private int id;
        private int number;
        private int capacity;
        private int available_seat;
        private string type;
        private int idHall;

        public int Id { get => id; set => id = value; }
        public int Number { get => number; set => number = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int Available_seat { get => available_seat; set => available_seat = value; }
        public string Type { get => type; set => type = value; }
        public int IdHall { get => idHall; set => idHall = value; }

        public Screen(DataRow row)
        {
            this.id = (int)row["id"];
            this.number = (int)row["number"];
            this.capacity = (int)row["capacity"];
            this.available_seat = (int)row["available_seat"];
            this.type = (string)row["type"];
            this.idHall = (int)row["idhall"];
        }
    }
}
