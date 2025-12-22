using MovieManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DAO
{
    public class VoucherDAO
    {
        private static VoucherDAO instance;

        public static VoucherDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new VoucherDAO();
                }
                return VoucherDAO.instance;
            }
            private set
            {
                VoucherDAO.instance = value;
            }
        }

        private VoucherDAO() { }

        public Voucher GetVoucher(string code)
        {
            Voucher voucher = null;
            string query = "select * from Voucher where code = @code ";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { code });
            if (table.Rows.Count > 0)
            {
                voucher = new Voucher(table.Rows[0]);
            }    
            return voucher;
        }

        public Voucher GetVoucherFromID(int idV)
        {
            Voucher voucher = null;
            string query = "select * from Voucher where id = @id ";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { idV });
            if (table.Rows.Count > 0)
            {
                voucher = new Voucher(table.Rows[0]);
            }
            return voucher;
        }
        public void DeleteVoucher(int id)
        {
            string query = "Delete from Voucher where id = @id ";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }
    }
}
