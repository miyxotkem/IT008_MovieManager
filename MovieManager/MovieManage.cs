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
    public partial class MovieManage : UserControl
    {
        public MovieManage()
        {
            InitializeComponent();
            LoadMovie();
        }
        public void LoadMovie()
        {
            List<Movie> movieList = MovieDAO.Instance.LoadMovieList();
            foreach (Movie movie in movieList)
            {
                Guna2GradientPanel pnl = new Guna2GradientPanel()
                {
                    Height = 50,
                    Width = 1300,
                    BorderColor = Color.Black
                };
                CheckBox cb = new CheckBox()
                {
                    Location = new Point(5, 20),
                    AutoSize = true
                };
                Label title = new Label()
                {
                    Location = new Point(100, 23),
                    Width = 500,
                    Text = movie.Title
                };
                Label genre = new Label()
                {
                    Location = new Point(750, 23),
                    Width = 100,
                    Text = movie.Genre
                };
                Label rated = new Label()
                {
                    Location = new Point(1100, 23),
                    Width = 100,
                    Text = movie.Rated
                };
                Label duration = new Label()
                {
                    Location = new Point(1450, 23),
                    Width = 100,
                    Text = movie.Duration.ToString()
                };
                Guna2GradientButton edit = new Guna2GradientButton()
                {
                    Image = global::MovieManager.Properties.Resources.MovieDisplay,
                    Size = new Size(50, 50),
                    FillColor = Color.FromArgb(175, 62, 62),
                    FillColor2 = Color.FromArgb(218, 108, 108),
                    Location = new Point(1700, 12)
                };
                pnl.Controls.Add(cb);
                pnl.Controls.Add(title);
                pnl.Controls.Add(genre);
                pnl.Controls.Add(rated);
                pnl.Controls.Add(duration);
                pnl.Controls.Add(edit);
                flowLayoutPanel1.Controls.Add(pnl);
            }
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
        }
    }
}
