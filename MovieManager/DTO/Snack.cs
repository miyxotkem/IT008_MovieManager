using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DTO
{
    public class Snack
    {
        private int id;
        private string name;
        private float price;
        private int stock;
        private int category;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public int Category
        {
            get { return category; }
            set { category = value; }
        }

        public Snack()
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
            this.Category = category;
        }

        public Snack(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Price = (float)Convert.ToSingle(row["price"]);
            this.Stock = (int)row["stock"];
            this.Category = (int)row["category"];
        }
    }
}
