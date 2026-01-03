using MovieManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public List<Voucher> LoadVoucherList()
        {
            List<Voucher> VoucherList = new List<Voucher>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetVoucherList");
            foreach (DataRow row in data.Rows)
            {
                Voucher Voucher = new Voucher(row);
                VoucherList.Add(Voucher);
            }
            return VoucherList;
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
        public int ImportVoucherList(List<Voucher> listVouchers)
        {
            string connStr = DataProvider.Instance.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        int successCount = 0;

                        string query = @"
                IF NOT EXISTS (SELECT 1 FROM Voucher WHERE code = @code)
                BEGIN
                    INSERT INTO Voucher (type, code, discount, max_money_discount, min_total_bill)
                    VALUES (@type, @code, @discount, @max_money, @min_bill)
                END";

                        foreach (var item in listVouchers)
                        {
                            string safeCode = item.Code.Length > 8 ? item.Code.Substring(0, 8) : item.Code;

                            using (SqlCommand cmd = new SqlCommand(query, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@type", item.Type);
                                cmd.Parameters.AddWithValue("@code", safeCode);
                                cmd.Parameters.AddWithValue("@discount", item.Discount);
                                cmd.Parameters.AddWithValue("@max_money", item.Max_money_discount);
                                cmd.Parameters.AddWithValue("@min_bill", item.Min_total_bill);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    successCount++;
                                }
                            }
                        }
                        trans.Commit();
                        return successCount;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw ex;
                    }
                }
            }
        }
    }
}
