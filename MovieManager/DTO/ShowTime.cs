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
        private DateTime start_time;
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
        public DateTime Start_time
        {
            get { return start_time; }
            set { start_time = value; }
        }
        public ShowTime(int idmovie, int idscreen, DateTime start_time)
        {
            this.IDMovie = idmovie;
            this.IDScreen = idscreen;
            this.Start_time = start_time;
        }
        public ShowTime(DataRow row)
        {
            this.IDMovie = (int)row["idmovie"];
            this.IDScreen = (int)row["idscreen"];
            this.Start_time = (DateTime)row["start_time"];
        }
    }
}
