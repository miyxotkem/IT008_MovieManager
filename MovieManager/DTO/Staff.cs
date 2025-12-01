using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DTO
{
    public class Staff
    {
        private int id;
        private string name;
        private string role;
        private string contact_info;
        private int idshift;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Role { get => role; set => role = value; }
        public string Contact_info { get => contact_info; set => contact_info = value; }
        public int Idshift { get => idshift; set => idshift = value; }

        public Staff(int id, string name, string role, string contact_info, int idshift)
        {
            this.id = id;
            this.name = name;
            this.role = role;
            this.contact_info = contact_info;
            this.idshift = idshift;
        }

        public Staff(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = (string)row["name"];
            this.role = (string)row["role"];
            this.contact_info = (string)row["contact_info"];
            this.idshift = (int)row["idshiftschedule"];
        }
    }
}
