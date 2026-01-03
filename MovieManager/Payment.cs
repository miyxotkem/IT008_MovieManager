using Guna.UI2.WinForms;
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
        private float Total_before_discount = 0;
        private Voucher voucher = null;
        public Payment()
        {
            InitializeComponent();
            CreateColumn();
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

        private void CreateColumn()
        {
            FlowLayoutPanel title = new FlowLayoutPanel()
            {
                Width = 900,
                Height = 50
            };
            //title.AutoScroll = true;
            Label STT = new Label()
            {
                Width = 50,
                Height = 80,
                Text = "No.",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            Label cate = new Label()
            {
                Width = 150,
                Height = 80,
                Text = "Category",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            Label Detail = new Label()
            {
                Width = 200,
                Height = 80,
                Text = "Detail",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            Label Quan = new Label()
            {
                Width = 100,
                Height = 80,
                Text = "Quantity",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            Label Dis = new Label()
            {
                Width = 100,
                Height = 80,
                Text = "Discount (%)",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            Label Price = new Label()
            {
                Width = 100,
                Height = 80,
                Text = "Price/Item",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            Label Final = new Label()
            {
                Width = 100,
                Height = 80,
                Text = "Final Price",
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            title.Controls.Add(STT);
            title.Controls.Add(cate);
            title.Controls.Add(Detail);
            title.Controls.Add(Quan);
            title.Controls.Add(Dis);
            title.Controls.Add(Price);
            title.Controls.Add(Final);
            TitlePanel.Controls.Add(title);
            
        }
        public void Reload()
        {
            Total = 0;
            Total_before_discount = 0;
            ContentPanel.Controls.Clear();
            Bill bill = BillDAO.Instance.GetUncheckedBill();
            if (bill != null)
            {
                Voucher v = VoucherDAO.Instance.GetVoucherFromID(bill.IdVoucher);
                voucher = v;
                BillInfoDAO.Instance.ResetTicketDiscount(bill.IdBill);
                if (v != null)
                {
                    if (voucher.Type == 1) // áp dụng cho Ticket 
                    {
                        BillInfoDAO.Instance.ApplyDiscountForTicket(bill.IdBill, voucher.Discount);
                    }
                }
                if (BillDAO.Instance.CheckValidCustomer(bill.IdBill))
                {
                    Customer cus = CustomerDAO.Instance.GetCustomer(bill.IdCustomer);
                    NameLabel.Text = "Customer's name: " + cus.Name;
                }
                else
                {
                    NameLabel.Text = "Customer's name: Guest";
                } 
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
                        Label stt = new Label()
                        {
                            Width = 50,
                            Height = 80,
                            Text = id.ToString(),
                            TextAlign = ContentAlignment.MiddleCenter,
                        };
                        Label Cate = new Label()
                        {
                            Width = 150,
                            Height = 80,
                            Text = info.Category.ToString(),
                            TextAlign = ContentAlignment.MiddleCenter,
                        };
                        Label detail = null;
                        if (info.Category == "Ticket")
                        {
                            Movie movie = MovieDAO.Instance.GetMovieFromIDMovie(info.IdDetail);
                            detail = new Label()
                            {
                                Width = 200,
                                Height = 80,
                                Text = movie.Title.ToString(),
                                TextAlign = ContentAlignment.MiddleCenter,
                            };
                        }
                        else if (info.Category == "Food and Drink")
                        {
                            Snack snack = SnackDAO.Instance.GetSnackFromIDSnack(info.IdDetail);
                            detail = new Label()
                            {
                                Width = 200,
                                Height = 80,
                                Text = snack.Name.ToString(),
                                TextAlign = ContentAlignment.MiddleCenter,
                            };
                        }
                        Label quan = new Label()
                        {
                            Width = 100,
                            Height = 80,
                            Text = info.Quantity.ToString(),
                            TextAlign = ContentAlignment.MiddleCenter,
                        };
                        Label discount = new Label()
                        {
                            Width = 100,
                            Height = 80,
                            Text = info.Discount.ToString(),
                            TextAlign = ContentAlignment.MiddleCenter,
                        };
                        float CurPrice = info.Price * info.Quantity;
                        if (v != null && v.Type == 1 && info.Category =="Ticket")
                        {
                            float max_money = Math.Min(v.Max_money_discount, CurPrice * v.Discount / 100);
                            CurPrice = Math.Max(0, CurPrice - max_money);
                        }
                        else
                        {
                            CurPrice = CurPrice * (100 - info.Discount) / 100;
                            Total_before_discount += CurPrice;
                        } 
                        Label priceper = new Label()
                        {
                            Width = 100,
                            Height = 80,
                            Text = info.Price.ToString("c"),
                            TextAlign = ContentAlignment.MiddleCenter,
                        };
                        Label price = new Label()
                        {
                            Width = 100,
                            Height = 80,
                            Text = CurPrice.ToString("c"),
                            TextAlign = ContentAlignment.MiddleCenter,
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
                        panel.Tag = info;
                        ContentPanel.Controls.Add(panel);
                    }
                }
            }
            else
            {
                NameLabel.Text = "Customer's name: Guest";
            } 
            if (voucher != null)
            {
                if (voucher.Type == 0) // áp dụng cho Bill
                {
                    float max_money = Math.Min(Total * voucher.Discount / 100, voucher.Max_money_discount);
                    Total = Math.Max(0, Total - max_money);
                }    
            }    
            TotalLabel.Text = "Total: " + Total.ToString("c");
        }
        private void Payment_Load(object sender, EventArgs e)
        {
            
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if (!BillDAO.Instance.ExistUncheckedBill())
            {
                MessageBox.Show("No unchecked bill at this moment.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Bill bill = BillDAO.Instance.GetUncheckedBill();
            if (bill != null)
            {
                if (!BillInfoDAO.Instance.CheckExistingFilmInBill(bill.IdBill))
                {
                    MessageBox.Show("No ticket available.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("No ticket available.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } 
            // Có vé 
            TicketDisplay ticketDisplay = new TicketDisplay();
            this.Parent.Controls.Add(ticketDisplay);
            ticketDisplay.Dock = DockStyle.Fill;
            ticketDisplay.Reload();
            List<Ticket> list = TicketDAO.Instance.GetTicketsFromBill(bill.IdBill);
            if (list != null && list.Count > 0)
            {
                foreach (Ticket ticket in list)
                {
                    MovieTicket movieTicket = new MovieTicket(ticket);
                    ticketDisplay.AddTicket(movieTicket);
                }
            }
            ticketDisplay.BringToFront();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (!BillDAO.Instance.ExistUncheckedBill())
            {
                MessageBox.Show("No unchecked bill at this moment.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Bill bill = BillDAO.Instance.GetUncheckedBill();
            if (bill == null)
            {
                MessageBox.Show("No bill available.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            CustomerInput custo = new CustomerInput();
            custo.ShowDialog();
            if (bill != null)
            {
                if (BillDAO.Instance.CheckValidCustomer(bill.IdBill))
                {
                    Customer cus = CustomerDAO.Instance.GetCustomer(bill.IdCustomer);
                    NameLabel.Text = "Customer's name: " + cus.Name;
                }
                else
                {
                    NameLabel.Text = "Customer's name: Guest";
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Bill bill = BillDAO.Instance.GetUncheckedBill();
            if (bill != null)
            {
                // Xóa vé và xóa đồ ăn khỏi billInfo 
                BillInfoDAO.Instance.DeleteFromBillInfo(bill.IdBill);
                List<Ticket> list = TicketDAO.Instance.GetTicketsFromBill(bill.IdBill);
                if (list != null && list.Count > 0)
                {
                    foreach (Ticket ticket in list)
                    {
                        // cập nhật lại ghế 
                        ShowTimeDetailDAO.Instance.UnchooseSeat(ticket.IdMovie, ticket.Start_time, ticket.IdSeat);
                    }    
                }
                // Xóa vé 
                TicketDAO.Instance.DeleteTicket(bill.IdBill);
                // Xóa Bill 
                BillDAO.Instance.DeleteBill(bill.IdBill);
            }
            Reload();
        }

        private void VoucherButton_Click(object sender, EventArgs e)
        {
            Bill bill = BillDAO.Instance.GetUncheckedBill();
            if (bill != null)
            {
                VoucherInput voucher = new VoucherInput(Total_before_discount, bill);
                voucher.ShowDialog();
            }
            else
            {
                MessageBox.Show("No bill to apply voucher.","Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
                
        }
    }
}
