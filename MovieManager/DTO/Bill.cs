using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DTO
{
    public class Bill
    {
        private int idBill;
        private int idCustomer;
        private int idStaff;
        private DateTime purchase_date;
        private string payment_method;
        private int bill_statius;
        private int idVoucher;

        public int IdBill { get => idBill; set => idBill = value; }
        public int IdCustomer { get => idCustomer; set => idCustomer = value; }
        public string Payment_method { get => payment_method; set => payment_method = value; }
        public int Bill_statius { get => bill_statius; set => bill_statius = value; }
        public int IdVoucher { get => idVoucher; set => idVoucher = value; }
        public int IdStaff { get => idStaff; set => idStaff = value; }
        public DateTime Purchase_date { get => purchase_date; set => purchase_date = value; }

        public Bill(DataRow row)
        {
            this.idBill = Convert.ToInt32(row["idBill"]);
            object idCus = row["idCustomer"];
            if (row.IsNull("idCustomer"))
            {
                this.IdCustomer = -1;
            }
            else
            {
                this.idCustomer = Convert.ToInt32(idCus);
            }
            this.idStaff = Convert.ToInt32(row["idStaff"]);
            this.purchase_date = (DateTime)row["purchase_date"];
            this.payment_method = (string)row["payment_method"];
            this.bill_statius = Convert.ToInt32(row["bill_status"]);
            this.idVoucher = (int)row["idVoucher"];
        }

        
    }
}
