using Guna.UI2.WinForms;
using MiniExcelLibs;
using MovieManager.DAO;
using MovieManager.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace MovieManager
{
    public partial class VoucherManage : UserControl
    {
        private List<Voucher> vouchers;
        private Dictionary<int, bool> checkingStatus;
        public VoucherManage()
        {
            InitializeComponent();
            vouchers = VoucherDAO.Instance.LoadVoucherList();
            checkingStatus = new Dictionary<int, bool>();
            FilterComboBox.SelectedIndex = 0;
            foreach (Voucher voucher in vouchers)
                checkingStatus.Add(voucher.Id, false);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (FilterComboBox.SelectedIndex == 0)
                SearchAndFilter();
            else
                FilterComboBox.SelectedIndex = 0;
        }

        public void LoadVoucher(List<Voucher> voucherList)
        {
            Panel p = new Panel()
            {
                Height = 30,
                Width = 830
            };
            Label t = new Label()
            {
                Location = new Point(125, 10),
                Width = 150,
                Text = "Type",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label c = new Label()
            {
                Location = new Point(275, 10),
                Width = 150,
                Text = "Discount",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label d = new Label()
            {
                Location = new Point(425, 10),
                Width = 150,
                Text = "Discount",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label ma = new Label()
            {
                Location = new Point(575, 10),
                Width = 150,
                Text = "Money Capped",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label mi = new Label()
            {
                Location = new Point(725, 10),
                Width = 150,
                Text = "Minimum Spend",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label but = new Label()
            {
                Location = new Point(25, 10),
                Width = 100,
                Text = "Delete",
                Font = new Font(Font, FontStyle.Bold)
            };
            p.Controls.Add(t);
            p.Controls.Add(c);
            p.Controls.Add(d);
            p.Controls.Add(ma);
            p.Controls.Add(mi);
            p.Controls.Add(but);
            flowLayoutPanel2.Controls.Add(p);
            foreach (Voucher voucher in voucherList)
            {
                bool isChecked = false;
                checkingStatus.TryGetValue(voucher.Id, out isChecked);
                Guna2GradientPanel pnl = new Guna2GradientPanel()
                {
                    Height = 50,
                    Width = 800
                };
                Label type = new Label()
                {
                    Location = new Point(125, 20),
                    Width = 100,
                    Text = voucher.Type == 0 ? "Overall Bill" : "Ticket Only"
                };
                Label code = new Label()
                {
                    Location = new Point(275, 20),
                    Width = 100,
                    Text = voucher.Code
                };
                Label discount = new Label()
                {
                    Location = new Point(425, 20),
                    Width = 100,
                    Text = voucher.Discount.ToString()
                };
                Label max = new Label()
                {
                    Location = new Point(575, 20),
                    Width = 100,
                    Text = voucher.Max_money_discount.ToString()
                };
                Label min = new Label()
                {
                    Location = new Point(725, 20),
                    Width = 100,
                    Text = voucher.Min_total_bill.ToString()
                };
                CheckBox cb = new CheckBox()
                {
                    Location = new Point(28, 18),
                    AutoSize = true,
                    Tag = voucher.Id,
                    Checked = isChecked
                };
                cb.CheckedChanged += Check;
                pnl.Controls.Add(type);
                pnl.Controls.Add(code);
                pnl.Controls.Add(discount);
                pnl.Controls.Add(max);
                pnl.Controls.Add(min);
                pnl.Controls.Add(cb);
                flowLayoutPanel1.Controls.Add(pnl);
            }
        }

        void Check(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb != null && cb.Tag is int Id)
            {
                checkingStatus[Id] = cb.Checked;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xlsx;*.xls";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<Voucher> data = ReadExcelToDTO(ofd.FileName);
                    if (data.Count == 0)
                    {
                        MessageBox.Show("The given file does not match with the app.", "Notification");
                        return;
                    }
                    int addedCount = VoucherDAO.Instance.ImportVoucherList(data);
                    if (addedCount > 0)
                    {
                        int ignoredCount = data.Count - addedCount;
                        MessageBox.Show($"Completed importing {addedCount} vouchers.\n(Ignored {ignoredCount} duplicates)", "Notification");
                        sync();
                    }
                    else
                        MessageBox.Show("No new vouchers were added.", "Notification");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Import Error: " + ex.Message, "Notification");
                }
            }
        }

        private List<Voucher> ReadExcelToDTO(string filePath)
        {
            var list = new List<Voucher>();
            var rows = MiniExcel.Query(filePath);

            int rowIndex = 0;
            foreach (var row in rows)
            {
                rowIndex++;
                string colA = row.A?.ToString();
                if (rowIndex == 1 && !int.TryParse(colA, out _)) continue;

                try
                {
                    var dto = new Voucher();
                    dto.Type = Convert.ToInt32(row.A);

                    string codeRaw = row.B?.ToString();
                    if (string.IsNullOrWhiteSpace(codeRaw)) continue;
                    dto.Code = codeRaw.Trim();
                    dto.Discount = Convert.ToInt32(row.C);
                    dto.Max_money_discount = Convert.ToSingle(row.D);
                    dto.Min_total_bill = Convert.ToSingle(row.E);

                    list.Add(dto);
                }
                catch
                {
                }
            }
            return list;
        }

        void SearchAndFilter()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            if (SearchTextBox.Text.Length == 0 && FilterComboBox.Text == "All")
            {
                LoadVoucher(VoucherDAO.Instance.LoadVoucherList());
                return;
            }
            List<Voucher> filter = new List<Voucher>();
            foreach (Voucher voucher in vouchers)
            {
                if (SearchTextBox.Text.Length == 0 && (voucher.Type == 0 ? "Overall Bill" : "Ticket Only") == FilterComboBox.Text)
                    filter.Add(voucher);
                else if (FilterComboBox.Text == "All" && voucher.Code.ToLower().Contains(SearchTextBox.Text.ToLower()))
                    filter.Add(voucher);
                else if (voucher.Code.ToLower().Contains(SearchTextBox.Text.ToLower()) && (voucher.Type == 0 ? "Overall Bill" : "Ticket Only") == FilterComboBox.Text)
                    filter.Add(voucher);
            }
            if (filter.Count > 0)
                
                LoadVoucher(filter);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchAndFilter();
        }

        private void DeleteSearchButton_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = "";
            SearchAndFilter();
        }

        private void DeleteFilter_Click(object sender, EventArgs e)
        {
            FilterComboBox.SelectedIndex = 0;
            SearchAndFilter();
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAndFilter();
        }

        void sync()
        {
            vouchers = VoucherDAO.Instance.LoadVoucherList();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            SearchAndFilter();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            sync();
        }
        DataProvider dp = new DataProvider();
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int count = checkingStatus.Count(kvp => kvp.Value);
            if (count == 0)
            {
                MessageBox.Show("No vouchers selected");
                return;
            }
            if (MessageBox.Show($"Delete {count} voucher(s)?", "Confirm", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;
            foreach (var item in checkingStatus.ToList())
            {
                int id = item.Key;
                bool isChecked = item.Value;
                if (!isChecked)
                    continue;
                string query = @"DELETE FROM Voucher WHERE id = @id";
                object[] values = new object[] { id };
                dp.ExecuteNonQuery(query, values);
                checkingStatus[id] = false;
            }
            sync();
        }
    }
}