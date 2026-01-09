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

        private void Detail(int month, int year)
        {
            MovieContainPanel.Controls.Clear();
            SnackContainPanel.Controls.Clear();
            // xóa dữ liệu của Chart
            MovieChart.Series["Series1"].Points.Clear();
            SnackChart.Series["Series1"].Points.Clear();
            MovieChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            MovieChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            MovieChart.ChartAreas[0].AxisX.Interval = 1;
            SnackChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            SnackChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            SnackChart.ChartAreas[0].AxisX.Interval = 1;
            MovieChart.Series["Series1"].LabelFormat = "#,##0 'đ'";
            SnackChart.Series["Series1"].LabelFormat = "#,##0 'đ'";
            MovieChart.Series["Series1"]["BarLabelStyle"] = "Top";
            SnackChart.Series["Series1"]["BarLabelStyle"] = "Top";
            List <KeyValuePair<int, float>> list = BillDAO.Instance.GetTop5Movie(month, year);
            List<KeyValuePair<int, float>> listSnack = BillDAO.Instance.GetTop5Snack(month, year);
            if (list != null && list.Count > 0)
            {
                int index = 0;
                foreach (KeyValuePair<int, float> item in list)
                {
                    index++;
                    int id = item.Key;
                    float value = item.Value;
                    Movie movie = MovieDAO.Instance.GetMovieFromIDMovie(id);
                    if (movie != null)
                    {
                        int Index = MovieChart.Series["Series1"].Points.AddXY(index, Convert.ToDouble(value));
                        MovieChart.Series["Series1"].Points[Index].Color = Color.FromArgb(218, 108, 108);
                        MovieChart.Series["Series1"].Points[Index].IsValueShownAsLabel = true;
                        FlowLayoutPanel panel = new FlowLayoutPanel()
                        {
                            Height = 35,
                            Width = 750
                        };
                        Label stt = new Label()
                        {
                            Height = 30,
                            Width = 80,
                            Text = index.ToString(),
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        Label title = new Label()
                        {
                            Height = 30,
                            Width = 300,
                            Text = movie.Title,
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        Label genre = new Label()
                        {
                            Height = 30,
                            Width = 100,
                            Text = movie.Genre,
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        Label rated = new Label()
                        {
                            Height = 30,
                            Width = 100,
                            Text = movie.Rated,
                            Font = new Font(Font, FontStyle.Bold),
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        Label Total = new Label()
                        {
                            Height = 30,
                            Width = 100,
                            Text = value.ToString("c"),
                            Font = new Font(Font, FontStyle.Bold),
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        panel.Controls.Add(stt);
                        panel.Controls.Add(title);
                        panel.Controls.Add(genre);
                        panel.Controls.Add(rated);
                        panel.Controls.Add(Total);
                        MovieContainPanel.Controls.Add(panel);
                    }    
                }    
            }    
            if (listSnack != null && listSnack.Count > 0)
            {
                int index = 0;
                foreach (KeyValuePair<int, float> item in listSnack)
                {
                    index++;
                    int id = item.Key;
                    float value = item.Value;
                    Snack snack = SnackDAO.Instance.GetSnackFromIDSnack(id);
                    if (snack != null)
                    {
                        int Index = SnackChart.Series["Series1"].Points.AddXY(index, Convert.ToDouble(value));
                        SnackChart.Series["Series1"].Points[Index].Color = Color.FromArgb(218, 108, 108);
                        SnackChart.Series["Series1"].Points[Index].IsValueShownAsLabel = true;
                        SnackChart.Series["Series1"].Points[Index].LabelFormat = "#,##0 'đ'";
                        FlowLayoutPanel panel = new FlowLayoutPanel()
                        {
                            Height = 35,
                            Width = 550
                        };
                        Label stt = new Label()
                        {
                            Height = 30,
                            Width = 80,
                            Text = index.ToString(),
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        Label title = new Label()
                        {
                            Height = 30,
                            Width = 200,
                            Text = snack.Name,
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        Label genre = new Label()
                        {
                            Height = 30,
                            Width = 100,
                            Text = (snack.Category == 0 ? "Food": "Beverage"),
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        Label Total = new Label()
                        {
                            Height = 30,
                            Width = 100,
                            Text = value.ToString("c"),
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        panel.Controls.Add(stt);
                        panel.Controls.Add(title);
                        panel.Controls.Add(genre);
                        panel.Controls.Add(Total);
                        SnackContainPanel.Controls.Add(panel);
                    }
                }    
            }
            MovieChart.ChartAreas[0].RecalculateAxesScale(); // Ép chart tính toán lại quy mô
            double mMax = MovieChart.ChartAreas[0].AxisY.Maximum;
            MovieChart.ChartAreas[0].AxisY.Maximum = mMax * 1.2; // Tăng thêm 20% khoảng trống

            SnackChart.ChartAreas[0].RecalculateAxesScale();
            double sMax = SnackChart.ChartAreas[0].AxisY.Maximum;
            SnackChart.ChartAreas[0].AxisY.Maximum = sMax * 1.2;
            MovieChart.Update();
            SnackChart.Update();
        }

        private void Ranking(int month, int year)
        {
            CustomerContain.Controls.Clear();
            StaffContain.Controls.Clear();
            // xóa dữ liệu của chart 
            CustomerChart.Series["Series1"].Points.Clear();
            StaffChart.Series["Series1"].Points.Clear();
            CustomerChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            CustomerChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            CustomerChart.ChartAreas[0].AxisX.Interval = 1;
            StaffChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            StaffChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            StaffChart.ChartAreas[0].AxisX.Interval = 1;
            CustomerChart.Series["Series1"].LabelFormat = "#,##0 'đ'";
            StaffChart.Series["Series1"].LabelFormat = "#,##0 'đ'";
            CustomerChart.Series["Series1"]["BarLabelStyle"] = "Top";
            StaffChart.Series["Series1"]["BarLabelStyle"] = "Top";
            List<KeyValuePair<int , float>> listCustomer = BillDAO.Instance.GetTop5Customer(month, year);
            List<KeyValuePair<int, float>> listStaff = BillDAO.Instance.GetTop5Staff(month, year);
            if (listCustomer != null && listCustomer.Count > 0)
            {
                int index = 0;
                foreach (KeyValuePair<int, float> item in listCustomer)
                {
                    index++;
                    FlowLayoutPanel panel = new FlowLayoutPanel()
                    {
                        Height = 35,
                        Width = 850
                    };
                    int id = item.Key;
                    float value = item.Value;
                    Customer customer = CustomerDAO.Instance.GetCustomer(id);
                    if (customer != null)
                    {
                        int Index = CustomerChart.Series["Series1"].Points.AddXY(index, Convert.ToDouble(value));
                        CustomerChart.Series["Series1"].Points[Index].Color = Color.FromArgb(218, 108, 108);
                        CustomerChart.Series["Series1"].Points[Index].IsValueShownAsLabel = true;
                        CustomerChart.Series["Series1"].Points[Index].LabelFormat = "#,##0 'đ'";
                        Label stt = new Label()
                        {
                            Height = 30,
                            Width = 80,
                            Text = index.ToString(),
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        Label title = new Label()
                        {
                            Height = 30,
                            Width = 200,
                            Text = customer.Name,
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        Label email = new Label()
                        {
                            Height = 30,
                            Width = 200,
                            Text = customer.Email,
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        Label phone = new Label()
                        {
                            Height = 30,
                            Width = 100,
                            Text = customer.Phonenumber,
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        string member = "New";
                        int mem = customer.Membership;
                        if (mem == 1)
                        {
                            member = "Bronze";
                        }    else if (mem == 2)
                        {
                            member = "Silver";
                        } else if (mem == 3)
                        {
                            member = "Gold";
                        } else if (mem == 4)
                        {
                            member = "Platinum";
                        } else if (mem == 5)
                        {
                            member = "VIP PRO";
                        }    
                        Label membership = new Label()
                        {
                            Height = 30,
                            Width = 100,
                            Text = member,
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        Label Total = new Label()
                        {
                            Height = 30,
                            Width = 100,
                            Text = value.ToString("c"),
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        panel.Controls.Add(stt);
                        panel.Controls.Add(title);
                        panel.Controls.Add(email);
                        panel.Controls.Add(phone);
                        panel.Controls.Add(membership);
                        panel.Controls.Add(Total);
                        CustomerContain.Controls.Add(panel);
                    }   
                }    
            } 
            if (listStaff != null && listStaff.Count > 0)
            {
                int index = 0;
                foreach (KeyValuePair<int, float> item in listStaff)
                {
                    index++;
                    int id = item.Key;
                    float value = item.Value;
                    FlowLayoutPanel panel = new FlowLayoutPanel()
                    {
                        Height = 35,
                        Width = 850
                    };
                    Staff staff = StaffDAO.Instance.GetStaff(id);
                    if (staff != null)
                    {
                        int Index = StaffChart.Series["Series1"].Points.AddXY(index, Convert.ToDouble(value));
                        StaffChart.Series["Series1"].Points[Index].Color = Color.FromArgb(218, 108, 108);
                        StaffChart.Series["Series1"].Points[Index].IsValueShownAsLabel = true;
                        StaffChart.Series["Series1"].Points[Index].LabelFormat = "#,##0 'đ'";
                        Label stt = new Label()
                        {
                            Height = 30,
                            Width = 80,
                            Text = index.ToString(),
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        Label title = new Label()
                        {
                            Height = 30,
                            Width = 200,
                            Text = staff.Name,
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        Label email = new Label()
                        {
                            Height = 30,
                            Width = 200,
                            Text = staff.Contact_info,
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        Label role = new Label()
                        {
                            Height = 30,
                            Width = 200,
                            Text = staff.Role,
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        Label Total = new Label()
                        {
                            Height = 30,
                            Width = 100,
                            Text = value.ToString("c"),
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        panel.Controls.Add(stt);
                        panel.Controls.Add(title);
                        panel.Controls.Add(email);
                        panel.Controls.Add(role);
                        panel.Controls.Add(Total);
                        StaffContain.Controls.Add(panel);
                    }    
                }    
            }
            CustomerChart.ChartAreas[0].RecalculateAxesScale(); // Ép chart tính toán lại quy mô
            double mMax = CustomerChart.ChartAreas[0].AxisY.Maximum;
            CustomerChart.ChartAreas[0].AxisY.Maximum = mMax * 1.2; // Tăng thêm 20% khoảng trống

            StaffChart.ChartAreas[0].RecalculateAxesScale();
            double sMax = StaffChart.ChartAreas[0].AxisY.Maximum;
            StaffChart.ChartAreas[0].AxisY.Maximum = sMax * 1.2;
            CustomerChart.Update();
            StaffChart.Update();
                
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
            if (cbbTypeDetail.SelectedIndex != -1 && cbbValueDetail.SelectedIndex != -1)
            {
                int year = Convert.ToInt32(cbbValueDetail.Items[cbbValueDetail.SelectedIndex]);
                int month = 0;
                if (cbbTypeDetail.Items[cbbTypeDetail.SelectedIndex].ToString() != "None")
                {
                    month = Convert.ToInt32(cbbTypeDetail.Items[cbbTypeDetail.SelectedIndex]);
                }
                Detail(month, year);
            }    
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
            LoadTitleMovie();
            LoadTitleSnack();
            LoadTitleCustomer();
            LoadTitleStaff();
            cbbType.SelectedIndex = 0;
            cbbTypeDetail.SelectedIndex = 0;
            cbbTypeRank.SelectedIndex = 0;
            cbbValue.SelectedIndex = 0;
            cbbValueDetail.SelectedIndex = 0;
            cbbValueRank.SelectedIndex = 0;
            
        }

        private void LoadTitleMovie()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel()
            {
                Height = 35,
                Width = 750
            };
            Label stt = new Label()
            {
                Height = 30,
                Width = 80,
                Text = "No.",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label title = new Label()
            {
                Height = 30,
                Width = 300,
                Text = "Title",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label genre = new Label()
            {
                Height = 30,
                Width = 100,
                Text = "Genre",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label rated = new Label()
            {
                Height = 30,
                Width = 100,
                Text = "Rated",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label Total = new Label()
            {
                Height = 30,
                Width = 100,
                Text = "Total Revenue",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            panel.Controls.Add(stt);
            panel.Controls.Add(title);
            panel.Controls.Add(genre);
            panel.Controls.Add(rated);
            panel.Controls.Add(Total);
            MovieTitlePanel.Controls.Add(panel);
        }

        private void LoadTitleSnack()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel()
            {
                Height = 35,
                Width = 550
            };
            Label stt = new Label()
            {
                Height = 30,
                Width = 80,
                Text = "No.",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label title = new Label()
            {
                Height = 30,
                Width = 200,
                Text = "Name",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label genre = new Label()
            {
                Height = 30,
                Width = 100,
                Text = "Category",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label Total = new Label()
            {
                Height = 30,
                Width = 100,
                Text = "Total Revenue",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            panel.Controls.Add(stt);
            panel.Controls.Add(title);
            panel.Controls.Add(genre);
            panel.Controls.Add(Total);
            SnackTitlePanel.Controls.Add(panel);
        }

        private void LoadTitleCustomer()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel()
            {
                Height = 35,
                Width = 850
            };
            Label stt = new Label()
            {
                Height = 30,
                Width = 80,
                Text = "No.",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label title = new Label()
            {
                Height = 30,
                Width = 200,
                Text = "Name",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label email = new Label()
            {
                Height = 30,
                Width = 200,
                Text = "Email",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label phone = new Label()
            {
                Height = 30,
                Width = 100,
                Text = "Phone Number",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label membership = new Label()
            {
                Height = 30,
                Width = 100,
                Text = "Membership",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label Total = new Label()
            {
                Height = 30,
                Width = 100,
                Text = "Money Spent",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            panel.Controls.Add(stt);
            panel.Controls.Add(title);
            panel.Controls.Add(email);
            panel.Controls.Add(phone);
            panel.Controls.Add(membership);
            panel.Controls.Add(Total);
            CustomerTitle.Controls.Add(panel);
        }

        private void LoadTitleStaff()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel()
            {
                Height = 35,
                Width = 850
            };
            Label stt = new Label()
            {
                Height = 30,
                Width = 80,
                Text = "No.",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label title = new Label()
            {
                Height = 30,
                Width = 200,
                Text = "Name",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label email = new Label()
            {
                Height = 30,
                Width = 200,
                Text = "Email",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label role = new Label()
            {
                Height = 30,
                Width = 200,
                Text = "Role",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label Total = new Label()
            {
                Height = 30,
                Width = 100,
                Text = "Total Revenue",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            panel.Controls.Add(stt);
            panel.Controls.Add(title);
            panel.Controls.Add(email);
            panel.Controls.Add(role);
            panel.Controls.Add(Total);
            StaffTitle.Controls.Add(panel);
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

        private void cbbValueDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTypeDetail.SelectedIndex != -1 && cbbValueDetail.SelectedIndex != -1)
            {
                int year = Convert.ToInt32(cbbValueDetail.Items[cbbValueDetail.SelectedIndex]);
                int month = 0;
                if (cbbTypeDetail.Items[cbbTypeDetail.SelectedIndex].ToString() != "None")
                {
                    month = Convert.ToInt32(cbbTypeDetail.Items[cbbTypeDetail.SelectedIndex]);
                }
                Detail(month, year);
            }
        }

        private void cbbTypeRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTypeRank.SelectedIndex != -1 && cbbValueRank.SelectedIndex != -1)
            {
                int year = Convert.ToInt32(cbbValueRank.Items[cbbValueRank.SelectedIndex]);
                int month = 0;
                if (cbbTypeRank.Items[cbbTypeRank.SelectedIndex].ToString() != "None")
                {
                    month = Convert.ToInt32(cbbTypeRank.Items[cbbTypeRank.SelectedIndex]);
                }
                Ranking(month, year);
            }    
        }

        private void cbbValueRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTypeRank.SelectedIndex != -1 && cbbValueRank.SelectedIndex != -1)
            {
                int year = Convert.ToInt32(cbbValueRank.Items[cbbValueRank.SelectedIndex]);
                int month = 0;
                if (cbbTypeRank.Items[cbbTypeRank.SelectedIndex].ToString() != "None")
                {
                    month = Convert.ToInt32(cbbTypeRank.Items[cbbTypeRank.SelectedIndex]);
                }
                Ranking(month, year);
            }
        }
    }
}
