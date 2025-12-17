using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DTO
{
    public class BillInfo
    {
        private int idBillInfo;
        private int idBill;
        private string category;
        private int idDetail;
        private int quantity;
        private int discount;
        private float price;

        public int IdBillInfo { get => idBillInfo; set => idBillInfo = value; }
        public int IdBill { get => idBill; set => idBill = value; }
        public string Category { get => category; set => category = value; }
        
        public int Quantity { get => quantity; set => quantity = value; }
        public int Discount { get => discount; set => discount = value; }
        public float Price { get => price; set => price = value; }
        public int IdDetail { get => idDetail; set => idDetail = value; }

        public BillInfo(DataRow row)
        {
            this.idBill = Convert.ToInt32(row["idBillInfo"]);
            this.idBill = Convert.ToInt32(row["idBill"]);
            this.category = Convert.ToString(row["Category"]);
            this.idDetail = Convert.ToInt32(row["idDetail"]);
            this.quantity = Convert.ToInt32(row["Quantity"]);
            this.discount = Convert.ToInt32(row["Discount"]);
            this.price = (float)Convert.ToDouble(row["Price"]);
        }
    }
}
