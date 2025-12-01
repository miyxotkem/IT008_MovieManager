using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DTO
{
    public class Shift
    {
        private int id;
        private TimeSpan start;
        private TimeSpan end;

        public int Id { get => id; set => id = value; }
        public TimeSpan Start { get => start; set => start = value; }
        public TimeSpan End { get => end; set => end = value; }
        
        public Shift(int id, TimeSpan start, TimeSpan end)
        {
            this.id = id;
            this.start = start;
            this.end = end;
        }

        public Shift(DataRow row)
        {
            this.id = (int)row["id"];
            this.start = (TimeSpan)row["start_schedule"];
            this.end = (TimeSpan)row["end_schedule"];
        }
    }
}
