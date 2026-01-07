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

        private void Overall()
        {
            RelationChart.Series["Series1"].Points.Clear();
            RelationChart.Series["Series2"].Points.Clear();
            RelationChart.Series["Series1"].LegendText = "Movie";
            RelationChart.Series["Series2"].LegendText = "Snack";
            RelationChart.Series["Series1"].Color = Color.Red;
            RelationChart.Series["Series2"].Color = Color.Blue;
            RelationChart.ChartAreas[0].AxisX.Interval = 1;
            RelationChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            int year = Convert.ToInt32(cbbValue.Items[cbbValue.SelectedIndex]);
            float MoneyForTicket = 0;
            float MoneyForSnack = 0;
            if (cbbType.Items[cbbType.SelectedIndex].ToString() == "None")
            {
                List<Bill> list = BillDAO.Instance.GetListBillInYear(year);
                if (list != null)
                {
                    foreach (Bill bill in list)
                    {
                        MoneyForTicket += bill.Money_spent_on_movie;
                        MoneyForSnack += bill.Money_spent_on_snack;
                    }
                }
              
                for (int i = 1; i <= 12; i++) // lấy theo từng tháng 
                {
                    List<Bill> billList = BillDAO.Instance.GetListBillInMonth(i, year);
                    float Movie = 0f;
                    float Snack = 0f;
                    foreach (Bill bill in billList)
                    {
                        Movie += bill.Money_spent_on_movie;
                        Snack += bill.Money_spent_on_snack;
                    }

                    // hiển thị dữ liệu lên chart 
                    int Index = RelationChart.Series["Series1"].Points.AddXY(i, Convert.ToDouble(Movie));
                    int Index2 = RelationChart.Series["Series2"].Points.AddXY(i, Convert.ToDouble(Snack));
                }
            }
            else
            {
                int month = Convert.ToInt32(cbbType.Items[cbbType.SelectedIndex]);
                List<Bill> list = BillDAO.Instance.GetListBillInMonth(month, year);
                if (list != null)
                {
                    foreach (Bill bill in list)
                    {
                        MoneyForTicket += bill.Money_spent_on_movie;
                        MoneyForSnack += bill.Money_spent_on_snack;
                    }
                }

                int NumberDate = GetDate(month, year);
                for (int i=1;i<=NumberDate;i++)
                {
                    List<Bill> billList = BillDAO.Instance.GetListBillInDay(i, month, year);
                    float Movie = 0f;
                    float Snack = 0f;
                    foreach (Bill bill in billList)
                    {
                        Movie += bill.Money_spent_on_movie;
                        Snack += bill.Money_spent_on_snack;
                    }

                    // hiển thị dữ liệu lên chart 
                    int Index = RelationChart.Series["Series1"].Points.AddXY(i, Convert.ToDouble(Movie));
                    int Index2 = RelationChart.Series["Series2"].Points.AddXY(i, Convert.ToDouble(Snack));
                }    

            }
            IncomeChart.Series["Series1"].Points.Clear(); // Xóa dữ liệu cũ sạch sẽ

            // 1. Thêm điểm dữ liệu mới vào biểu đồ
            int index = IncomeChart.Series["Series1"].Points.AddY(Convert.ToDouble(MoneyForTicket));

            // 2. Tùy chỉnh điểm dữ liệu vừa thêm thông qua index
            IncomeChart.Series["Series1"].Points[index].Color = Color.FromArgb(218, 108, 108);
            IncomeChart.Series["Series1"].Points[index].LegendText = "Movie";
            IncomeChart.Series["Series1"].Points[index].Label = "#PERCENT";

            index = IncomeChart.Series["Series1"].Points.AddY(Convert.ToDouble(MoneyForSnack));
            IncomeChart.Series["Series1"].Points[index].Color = Color.FromArgb(234, 235, 208);
            IncomeChart.Series["Series1"].Points[index].LegendText = "Snack";
            IncomeChart.Series["Series1"].Points[index].Label = "#PERCENT";

            // cập nhật label 
            MovieLabel.Text = MoneyForTicket.ToString("c");
            SnackLabel.Text = MoneyForSnack.ToString("c");
            TotalLabel.Text = (MoneyForTicket + MoneyForSnack).ToString("c");

            RelationChart.Update();
            IncomeChart.Update();
        }

        private int GetDate(int month, int year)
        {
            return DateTime.DaysInMonth(year, month);
        }
        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbType.SelectedIndex != -1 && cbbValue.SelectedIndex != -1)
            {
                Overall();
            }

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

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbType.SelectedIndex != -1 && cbbValue.SelectedIndex != -1)
            {
                Overall();
            }
        }
    }
}
