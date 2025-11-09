using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DTO
{
    public class ShowTime
    {
        private int idmovie;
        private int idscreen;
        private int idseat;
        private DateTime start_time;
        private bool available;
        public int IDMovie
        {
            get { return idmovie; }
            set { idmovie = value; }
        }
        public int IDScreen
        {
            get { return idscreen; }
            set { idscreen = value; }
        }
        public int IDSeat
        {
            get { return idseat; }
            set { idseat = value; }
        }
        public DateTime Start_time
        {
            get { return start_time; }
            set { start_time = value; }
        }
        public bool Available
        {
            get { return available; }
            set { available = value; }
        }
        public ShowTime(int idmovie, int idscreen, int idseat, DateTime start_time, bool available)
        {
            this.IDMovie = idmovie;
            this.IDScreen = idscreen;
            this.IDSeat = idseat;
            this.Start_time = start_time;
            this.Available = available;
        }
        public ShowTime(DataRow row)
        {
            this.IDMovie = (int)row["idmovie"];
            this.IDScreen = (int)row["idscreen"];
            this.IDSeat = (int)row["idseat"];
            this.Start_time = (DateTime)row["start_time"];
            this.Available = (bool)row["available"];
        }
    }
}
