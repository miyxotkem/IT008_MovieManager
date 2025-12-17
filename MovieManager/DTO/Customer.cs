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

        public Customer()
        {
            this.id = -1;
            this.name = null;
            this.email = null;
            this.phonenumber = null;
            this.membership = 0;
            this.moneyspent = 0;
        }
        public Customer(DataRow row)
        {
            this.id = (int)row["id"];
            object Name = row["name"];
            if (row.IsNull("name"))
            {
                this.name = "Guest";
            }
            else
            {
                this.name = (string)Name;
            } 
            object emailValue = row["email"];
            if (row.IsNull("email"))
            {
                this.email = "None";
            }
            else
            {
                this.email = emailValue.ToString();
            }
            object phoneValue = row["phone_number"];
            if (row.IsNull("phone_number"))
            {
                this.phonenumber = "None";
            }
            else
            {
                this.phonenumber = phoneValue.ToString();
            } 
            this.membership = (int)row["membership"];
            this.moneyspent = (float)(double)row["money_spent"];
        }
    }
}
