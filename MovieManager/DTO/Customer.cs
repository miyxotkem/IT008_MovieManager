using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DTO
{
    public class Customer
    {
        private int id;
        private string name;
        private string email;
        private string phonenumber;
        private int membership;
        private float moneyspent;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public int Membership { get => membership; set => membership = value; }
        public float Moneyspent { get => moneyspent; set => moneyspent = value; }

        public Customer(int id, string name, string email, string phonenumber, int membership, float moneyspent)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.phonenumber = phonenumber;
            this.membership = membership;
            this.moneyspent = moneyspent;
        }

        public Customer(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = (string)row["name"];
            this.email = (string)row["email"];
            this.phonenumber = (string)row["phone_number"];
            this.membership = (int)row["membership"];
            this.moneyspent = (float)(double)row["money_spent"];
        }
    }
}
