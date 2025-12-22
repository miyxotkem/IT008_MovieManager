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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MovieManager
{
    public partial class SelectMovie : UserControl
    {
        private Control parentContainer = null;
        private Control cinemaPanel = null;
        private Color Normal = Color.FromArgb(251, 198, 56);
        private Color VIP = Color.FromArgb(247, 175, 64);
        private Color SVIP = Color.FromArgb(233, 134, 30);
        private Color Couple = Color.FromArgb(184, 0, 0);
        private Color Choose = Color.FromArgb(235, 107, 149);
        private Color Occupied = Color.FromArgb(125, 31, 164);
        private ShowTime CurrentShowTime = null;
        private Cinema cinema = null;
        private Bill CurBill = null;
        private bool HaveChooseSeat;
        private int Discount = 0;
        public SelectMovie()
        {
            InitializeComponent();
        }
        private Movie currentMovie;

        public SelectMovie(Movie movie, Control parentContainer, Control cinemaPanel)
        {
            InitializeComponent();
            currentMovie = movie;
            TitleSelectMovie.Text = currentMovie.Title;
            LoadShowTime();
            this.parentContainer = parentContainer;
            this.cinemaPanel = cinemaPanel;
            if (parentContainer != null)
            {
                if (parentContainer.Parent is Cinema cinema)
                {
                    this.cinema = cinema;
                }    
            }    
        }

        public void LoadShowTime()
        {
            StartTimePanelSelectMovie.Controls.Clear();
            List<ShowTime> showtimeList = ShowTimeDAO.Instance.LoadShowTimeList();
            foreach (ShowTime showtime in showtimeList)
            {
                if(showtime.IDMovie == currentMovie.ID)
                {
                       Guna2GradientButton btn = new Guna2GradientButton();
                        btn.Size = new Size(150, 100);
                        btn.BackColor = Color.Transparent;
                        btn.BorderRadius = 12;
                        btn.BorderThickness = 1;
                        btn.ForeColor = Color.Black;
                        btn.BorderColor = Color.FromArgb(175, 62, 62);
                        btn.FillColor = Color.White;
                        btn.FillColor2 = Color.White;
                        btn.HoverState.FillColor = Color.FromArgb(175, 62, 62);
                        btn.HoverState.FillColor2 = Color.FromArgb(218, 108, 108);
                        btn.HoverState.ForeColor = Color.White;
                        btn.Animated = true;
                        btn.Text = showtime.Start_time.ToString();
                        btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                        btn.Click += SelectStartTime_Click;
                        btn.Tag = showtime; 
                        StartTimePanelSelectMovie.Controls.Add(btn);
                }
            }
        }

        private void BackButtonSelectMovie_Click(object sender, EventArgs e)
        {
            if (parentContainer != null)
            {
                if (parentContainer.Parent is Cinema cinema)
                {
                    cinema.ChangeMovieDisplayButton(true);
                }    
            }
            this.Dispose();
        }
        private void SelectStartTime_Click(object sender, EventArgs e)
        {
            // từ idMovie và StartTime lấy ds id ghế 
            // từ ds id ghế lấy ra chi tiết từng ghế 
            Guna2GradientButton btn = (Guna2GradientButton)sender;
            if (btn.Tag is ShowTime showtime)
            {
                CurrentShowTime = showtime;
                List<int> ListIDSeat = ShowTimeDetailDAO.Instance.GetSeatIDListFromMovie(showtime.IDMovie, showtime.Start_time);
                List<Seat> ListSeat = new List<Seat>();
                if (ListIDSeat != null && ListIDSeat.Count > 0)
                {
                    foreach (int id in ListIDSeat)
                    {
                        Seat seat = SeatDAO.Instance.GetSeatInfoFromSeatID(id);
                        ListSeat.Add(seat); 
                    }    
                }
                ScreenPanel.Controls.Clear();
                if (showtime.IDScreen == 1)
                {
                    ScreenLayout1 screen1 = new ScreenLayout1();
                    screen1.Tag = showtime;
                    screen1.Reload(ListSeat);
                    screen1.Dock = DockStyle.Fill;
                    ScreenPanel.Controls.Add(screen1);
                }    
            }    
        }

        private void MoveToPayment_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            if (parentContainer != null)
            {
                parentContainer.Controls.Add(payment);
                payment.Dock = DockStyle.Fill;
                if (CurBill != null)
                {
                    payment.Tag = CurBill;
                }    
                payment.BringToFront();
            }
            this.Dispose();
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (!HaveChooseSeat)
            {
                MessageBox.Show("Please choose your seat first.", "Notification");
                return;
            }    
            if (parentContainer != null )
            {
                if (parentContainer.Parent is Cinema cinema)
                {
                    cinema.ChangeSnackDisplayButton(true);
                }    
            }
            this.Dispose();
        }

        private void ChooseSeatButton_Click(object sender, EventArgs e)
        {
            if (CurrentShowTime == null)
            {
                MessageBox.Show("Please choose film's start time first.", "Notification");
                return;
            }    
            ScreenLayout1 screen = null;
            foreach (Control ctr in ScreenPanel.Controls)
            {
                if (ctr is ScreenLayout1 screenLayout)
                {
                    screen = screenLayout;
                    break;
                }    
            }
            List<Guna2GradientButton> list = screen.GetCurrentChooseButton();
            Bill bill = BillDAO.Instance.GetUncheckedBill();
            if (bill == null) // không có bill
            {
                BillDAO.Instance.CreateBill();
                bill = BillDAO.Instance.GetUncheckedBill();
            }    
            if (BillInfoDAO.Instance.CheckExistingFilmInBill(bill.IdBill))
            {
                MessageBox.Show("Please pay all the previous bill before choosing new films.", "Notification");
                return;
            }    
            if (bill != null)
            {
                CurBill = bill;
            }    
            int TotalSeat = 0;
            float CommonPrice = 0;
            foreach (Guna2GradientButton button in list)
            {
                if (button.FillColor == Choose)
                {
                    button.FillColor = Occupied;
                    button.FillColor2 = Occupied;
                    if (button.Tag is Seat seat)
                    {
                        HaveChooseSeat = true;
                        TotalSeat++;
                        // Đánh dấu ghế đã chọn 
                        ShowTimeDetailDAO.Instance.ChooseSeat(CurrentShowTime.IDMovie, CurrentShowTime.Start_time, seat.IdSeat);
                        // Cho ticket vào database 
                        if (bill != null)
                        {
                            float price = 0;
                            if (seat.SeatType == "Normal")
                            {
                                price = 70000;
                            }
                            else if (seat.SeatType == "VIP")
                            {
                                price = 90000;
                            }
                            else if (seat.SeatType == "SVIP")
                            {
                                price = 110000;
                            }
                            else if (seat.SeatType == "Couple")
                            {
                                price = 115000;
                            }
                            CommonPrice = price;
                            if (cinema != null && cinema.Tag is Account account)
                            {
                                TicketDAO.Instance.CreateTicket(price, CurrentShowTime.IDMovie, CurrentShowTime.Start_time, account.Id, seat.IdSeat, bill.IdBill);
                            }
                        }
                    }
                }
            }    
            if (!HaveChooseSeat)
            {
                MessageBox.Show("Please choose your seat first.", "Notification");
            }
            else
            {
                // Thêm vào BillInfo 
                if (bill != null && currentMovie != null)
                {
                    BillInfoDAO.Instance.AddBillInfoIntoBillID(bill.IdBill, "Ticket", currentMovie.ID, TotalSeat, Discount, CommonPrice);
                    MessageBox.Show("Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            } 
                
        }

        private void CancelSeatButton_Click(object sender, EventArgs e)
        {
            ScreenLayout1 screen = null;
            foreach (Control ctr in ScreenPanel.Controls)
            {
                if (ctr is ScreenLayout1 screenLayout)
                {
                    screen = screenLayout;
                    break;
                }
            }
            List<Guna2GradientButton> list = screen.GetCurrentChooseButton();
            foreach (Guna2GradientButton button in list)
            {
                if (button.FillColor == Choose)
                {
                        Color color = Color.White;
                        if (button.Tag is Seat seat)
                        {
                            if (seat.SeatType == "Normal")
                            {
                                color = Normal;
                            }
                            else if (seat.SeatType == "VIP")
                            {
                                color = VIP;
                            }
                            else if (seat.SeatType == "SVIP")
                            {
                                color = SVIP;
                            }
                            else if (seat.SeatType == "Couple")
                            {
                                color = Couple;
                            }
                        }
                        button.FillColor = color;
                        button.FillColor2 = color; 
                }
            }
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerInput customerInput = new CustomerInput();
            customerInput.ShowDialog();
        }

        private void SelectMovie_Load(object sender, EventArgs e)
        {
            HaveChooseSeat = false;
        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
