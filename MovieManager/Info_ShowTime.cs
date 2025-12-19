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
    public partial class Info_ShowTime : UserControl
    {
        private List<ShowTime> showtimes = ShowTimeDAO.Instance.LoadShowTimeList();
        private List<Movie> movies = MovieDAO.Instance.LoadMovieList();
        public Info_ShowTime()
        {
            InitializeComponent();
        }

        public Info_ShowTime(int id)
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            foreach (Movie movie in movies)
                if (movie.ID == id)
                    Title.Text = movie.Title;
            foreach (ShowTime showtime in showtimes)
            {
                if (showtime.IDMovie == id)
                {
                    Panel pnl = new Panel()
                    {
                        Width = 550,
                        Height = 50,
                    };
                    Label lbl = new Label()
                    {
                        Location = new Point(80, 30),
                        Width = 500,
                        Font = new Font("Microsoft Sans Serif", 15f),
                        Text = showtime.Start_time.ToString("hh:mm dd/mm/yyyy")
                    };
                    CheckBox delete = new CheckBox()
                    {
                        Location = new Point(50, 25),
                    };
                    pnl.Controls.Add(lbl);
                    if (showtime.IDScreen == 1)
                        flowLayoutPanel1.Controls.Add(pnl);
                    else if (showtime.IDScreen == 2)
                        flowLayoutPanel2.Controls.Add(pnl);
                    else if (showtime.IDScreen == 2)
                        flowLayoutPanel3.Controls.Add(pnl);
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Control parentContainer = this.Parent;
            if (parentContainer != null)
                parentContainer.Controls.Remove(this);
            this.Dispose();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
