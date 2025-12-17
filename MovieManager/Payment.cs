using MovieManager.DAO;
using MovieManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieManager
{
    public partial class Payment : UserControl
    {
        private float Total = 0;
        public Payment()
        {
            InitializeComponent();
        }

        private void ExitButtonSignUp_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void guna2Panel1_Resize(object sender, EventArgs e)
        {
            PaymentLabel.Left = (OutsidePanel.ClientSize.Width - PaymentLabel.Width) / 2;
            Container.Left = (OutsidePanel.ClientSize.Width - Container.Width) / 2;
            Container.Top = (OutsidePanel.ClientSize.Height - Container.Height) / 2;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();  
            FlowLayoutPanel title = new FlowLayoutPanel()
            {
                Width = 900,
                Height = 50
            };
            //title.AutoScroll = true;
            Label STT = new Label()
            {
                Width = 100,
                Height = 80,
                Text = "No.",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label cate = new Label()
            {
                Width = 100,
                Height = 80,
                Text = "Category",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label Detail = new Label()
            {
                Width = 200,
                Height = 80,
                Text = "Detail",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label Quan = new Label()
            {
                Width = 100,
                Height = 80,
                Text = "Quantity",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label Dis = new Label()
            {
                Width = 100,
                Height = 80,
                Text = "Discount (%)",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label Price = new Label()
            {
                Width = 100,
                Height = 80,
                Text = "Price/Item",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label Final = new Label()
            {
                Width = 100,
                Height = 80,
                Text = "Price (after discount)",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            title.Controls.Add(STT);
            title.Controls.Add(cate);
            title.Controls.Add(Detail);
            title.Controls.Add(Quan);
            title.Controls.Add(Dis);
            title.Controls.Add(Price);
            title.Controls.Add(Final);
            ContentPanel.Controls.Add(title);
            if (CustomerDAO.Instance.CurrentCustomer != null)
            {
                int idCustomer = CustomerDAO.Instance.CurrentCustomer.Id;
                Bill bill = BillDAO.Instance.GetIDBillFromIDCustomer(idCustomer);
                if (bill != null)
                {
                    List<BillInfo> list = BillInfoDAO.Instance.GetListBillInfoFromBillID(bill.IdBill);
                    if (list != null && list.Count > 0)
                    {
                        int id = 0;
                        foreach (BillInfo info in list)
                        {
                            id++;
                            FlowLayoutPanel panel = new FlowLayoutPanel()
                            {
                                Width = 900,
                                Height = 50
                            };
                            //panel.AutoScroll = true;
                            Label stt = new Label()
                            {
                                Width = 100,
                                Height = 80,
                                TextAlign = ContentAlignment.MiddleCenter,
                                Text = id.ToString()
                            };
                            Label Cate = new Label()
                            {
                                Width = 100,
                                Height = 80,
                                TextAlign = ContentAlignment.MiddleCenter,
                                Text = info.Category.ToString()
                            };
                            Label detail = null;
                            if (info.Category == "Ticket")
                            {
                                Movie movie = MovieDAO.Instance.GetMovieFromIDMovie(info.IdDetail);
                                detail = new Label()
                                {
                                    Width = 200,
                                    Height = 80,
                                    TextAlign = ContentAlignment.MiddleCenter,
                                    Text = movie.Title.ToString()
                                };
                            }else if (info.Category == "Food and Drink")
                            {
                                Snack snack = SnackDAO.Instance.GetSnackFromIDSnack(info.IdDetail);
                                detail = new Label()
                                {
                                    Width = 200,
                                    Height = 80,
                                    TextAlign = ContentAlignment.MiddleCenter,
                                    Text = snack.Name.ToString()
                                };
                            }
                            Label quan = new Label()
                            {
                                Width = 100,
                                Height = 80,
                                TextAlign = ContentAlignment.MiddleCenter,
                                Text = info.Quantity.ToString()
                            };
                            Label discount = new Label()
                            {
                                Width = 100,
                                Height = 80,
                                TextAlign = ContentAlignment.MiddleCenter,
                                Text = info.Discount.ToString()
                            };
                            float CurPrice = info.Price * info.Quantity;
                            CurPrice = (100 - info.Discount) * CurPrice / 100;
                            Label priceper = new Label()
                            {
                                Width = 100,
                                Height = 80,
                                TextAlign = ContentAlignment.MiddleCenter,
                                Text = info.Price.ToString("c")
                            };
                            Label price = new Label()
                            {
                                Width = 100,
                                Height = 80,
                                TextAlign = ContentAlignment.MiddleCenter,
                                Text = CurPrice.ToString("c")
                            };
                            Total += CurPrice;
                            panel.Controls.Add(stt);
                            panel.Controls.Add(Cate);
                            if (detail != null)
                            panel.Controls.Add(detail);
                            panel.Controls.Add(quan);
                            panel.Controls.Add(discount);
                            panel.Controls.Add(priceper);
                            panel.Controls.Add(price);
                            ContentPanel.Controls.Add(panel);
                        }
                        TotalLabel.Text = "Total: " + Total.ToString("c");
                    }    
                }    
            }    
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if (!BillDAO.Instance.ExistUncheckedBill())
            {
                MessageBox.Show("No unchecked bill at this moment.", "Notification");
                return;
            }    
            PaymentMethod pay = new PaymentMethod(Total);
            if (this.Tag is Bill bill)
            {
                pay.Tag = bill;
            }    
            pay.ShowDialog();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (CustomerDAO.Instance.CurrentCustomer != null)
            {
                int idCustomer = CustomerDAO.Instance.CurrentCustomer.Id;
                Bill bill = BillDAO.Instance.GetIDBillFromIDCustomer(idCustomer);
                if (bill != null)
                {
                    if (!BillInfoDAO.Instance.CheckExistingFilmInBill(bill.IdBill))
                    {
                        MessageBox.Show("No ticket available.", "Notification");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("No ticket available.", "Notification");
                    return;
                } 
                    
            }
            else
            {
                MessageBox.Show("No ticket available.", "Notification");
                return;
            } 
                
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (!BillDAO.Instance.ExistUncheckedBill())
            {
                MessageBox.Show("No unchecked bill at this moment.", "Notification");
                return;
            }
        }
    }
}
