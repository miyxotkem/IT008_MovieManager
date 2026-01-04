using MimeKit.Tnef;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieManager.DTO;
using MovieManager.DAO;

namespace MovieManager
{
    public partial class Statistics : UserControl
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel1_Resize(object sender, EventArgs e)
        {
            ContainPanel.Left = (this.ClientSize.Width - ContainPanel.Width) / 2;
            ContainPanel.Top = (this.ClientSize.Height - ContainPanel.Height) / 2;
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbbType.SelectedIndex != -1 && cbbValue.SelectedIndex != -1)
            //{
            //    float TotalMoneyOnMovie = 0f;
            //    float TotalMoneyOnSnack = 0f;
            //    float TotalMoneyOnBill = 0f;
            //    if (cbbType.Items[cbbType.SelectedIndex].ToString() == "None") // chỉ xét theo năm 
            //    {
            //        int year = Convert.ToInt32(cbbValue.Items[cbbValue.SelectedIndex]);
            //        List<Bill> list = BillDAO.Instance.GetListBillInYear(year);
            //        foreach (Bill bill in list) // duyệt qua từng Bill 
            //        {
            //            // Lấy voucher áp cho Bill này 
            //            Voucher voucher = VoucherDAO.Instance.GetVoucherFromID(bill.IdVoucher);
            //            // lấy BillInfo của từng Bill
            //            List<BillInfo> billInfos = BillInfoDAO.Instance.GetListBillInfoFromBillID(bill.IdBill);
            //            foreach(BillInfo info in billInfos) // duyệt qua từng BillInfo 
            //            {

            //            }    
            //        }    
            //    }
            //    else
            //    {

            //    } 
                    
            //}    
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            if (cbbType.SelectedIndex == -1 || cbbValue.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose appropriate time to summarize.","Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (cbbType.SelectedIndex != -1)
                {
                    cbbType.Focus();
                }
                else
                {
                    cbbValue.Focus();
                } 
                    
                return;
            }   
            

        }

        private void cbbTypeDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ReloadButtonDetail_Click(object sender, EventArgs e)
        {
            if (cbbTypeDetail.SelectedIndex == -1 || cbbValueDetail.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose appropriate time to summarize.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (cbbTypeDetail.SelectedIndex != -1)
                {
                    cbbTypeDetail.Focus();
                }
                else
                {
                    cbbValueDetail.Focus();
                }

                return;
            }
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            for (int i=1;i<=12;i++)
            {
                cbbType.Items.Add(i.ToString());    
                cbbTypeDetail.Items.Add(i.ToString());  
                cbbTypeRank.Items.Add(i.ToString());    
            }
            cbbType.Items.Add("None");
            cbbTypeDetail.Items.Add("None");
            cbbTypeRank.Items.Add("None");
            DateTime now = DateTime.Now;
            int cur = now.Year;
            for (int i=0;i<=10;i++)
            {
                cbbValue.Items.Add((cur-i).ToString());
                cbbValueDetail.Items.Add((cur-i).ToString());
                cbbValueRank.Items.Add((cur - i).ToString());
            }
            cbbType.SelectedIndex = 0;
            cbbTypeDetail.SelectedIndex = 0;
            cbbTypeRank.SelectedIndex = 0;
            cbbValue.SelectedIndex = 0;
            cbbValueDetail.SelectedIndex = 0;
            cbbValueRank.SelectedIndex = 0;
        }
    }
}
