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
        public SelectMovie()
        {
            InitializeComponent();
        }
        private Movie currentMovie;

        public SelectMovie(Movie movie, Control parentContainer)
        {
            InitializeComponent();
            currentMovie = movie;
            TitleSelectMovie.Text = currentMovie.Title;
            LoadShowTime();
            this.parentContainer = parentContainer;
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
            MovieDisplay md = new MovieDisplay();
            parentContainer.Controls.Clear();
            parentContainer.Controls.Add(md);
            md.Dock = DockStyle.Fill;
        }
        private void SelectStartTime_Click(object sender, EventArgs e)
        {
            // từ idMovie và StartTime lấy ds id ghế 
            // từ ds id ghế lấy ra chi tiết từng ghế 
            Guna2GradientButton btn = (Guna2GradientButton)sender;
            if (btn.Tag is ShowTime showtime)
            {
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
                    screen1.Reload(ListSeat);
                    screen1.Dock = DockStyle.Fill;
                    ScreenPanel.Controls.Add(screen1);
                }    
            }    
        }
    }
}
