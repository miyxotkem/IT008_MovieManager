using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DTO
{
    public class Voucher
    {
        private int id;
        private int type;
        private string code;
        private int discount;
        private float max_money_discount;
        private float min_total_bill;

        public int Id { get => id; set => id = value; }
        public int Type { get => type; set => type = value; }
        public string Code { get => code; set => code = value; }
        public int Discount { get => discount; set => discount = value; }
        public float Max_money_discount { get => max_money_discount; set => max_money_discount = value; }
        public float Min_total_bill { get => min_total_bill; set => min_total_bill = value; }

        public Voucher(DataRow row)
        {
            this.id = (int)row["id"];
            this.type = (int)row["type"];
            this.code = (string)row["code"];
            this.discount = (int)row["discount"];
            this.max_money_discount = (float)Convert.ToDouble(row["max_money_discount"]);
            this.min_total_bill = (float)Convert.ToDouble(row["min_total_bill"]);
        }
    }
}
