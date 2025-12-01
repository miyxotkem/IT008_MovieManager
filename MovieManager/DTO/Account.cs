using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DTO
{
    public class Account
    {
        private int id;
        private string username;
        private string password;
        private bool admin;
        private int idstaff;
        private bool accept;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Idstaff { get => idstaff; set => idstaff = value; }
        public bool Admin { get => admin; set => admin = value; }
        public bool Accept { get => accept; set => accept = value; }

        public Account(int id, string username, string password, bool admin, int idstaff, bool accept)
        {
            Id = id;
            Username = username;
            Password = password;
            Admin = admin;
            Idstaff = idstaff;
            Accept = accept;
        }

        public Account(DataRow row)
        {
            this.id = (int)row["id"];
            this.username = (string)row["username"];
            this.password = (string)row["password"];
            this.Admin = (bool)row["admin"];
            this.idstaff = (int)row["idstaff"];
            this.Accept = (bool)row["accept"];
        }
    }
}
