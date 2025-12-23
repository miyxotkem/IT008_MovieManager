using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DTO
{
    public class Hall
    {
        private int id;
        private string name;
        private string location;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }

        public Hall(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = (string)row["name"];    
            this.location = (string)row["location"];
        }
    }
}
