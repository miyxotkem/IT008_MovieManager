using Guna.UI2.WinForms;
using MovieManager.DAO;
using MovieManager.DTO;
using System;
using System.Collections;
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
    public partial class ShowTimeManage : UserControl
    {
        private List<ShowTime> showtimes = ShowTimeDAO.Instance.LoadShowTimeList();
        private List<Movie> movies = MovieDAO.Instance.LoadMovieList();
        public ShowTimeManage()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SearchAndFilter();
        }

        public void LoadShowTime(List<Movie> movieList)
        {
            Panel p = new Panel()
            {
                Height = 30,
                Width = 800
            };
            Label n = new Label()
            {
                Location = new Point(100, 10),
                Width = 300,
                Text = "Title",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label r = new Label()
            {
                Location = new Point(400, 10),
                Width = 100,
                Text = "Rated",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label d = new Label()
            {
                Location = new Point(550, 10),
                Width = 100,
                Text = "Duration",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label e = new Label()
            {
                Location = new Point(700, 10),
                Width = 100,
                Text = "Info",
                Font = new Font(Font, FontStyle.Bold)
            };
            p.Controls.Add(n);
            p.Controls.Add(r);
            p.Controls.Add(d);
            p.Controls.Add(e);
            flowLayoutPanel2.Controls.Add(p);
            foreach (Movie movie in movieList)
            {
                Guna2GradientPanel pnl = new Guna2GradientPanel()
                {
                    Height = 50,
                    Width = 800
                };
                Label name = new Label()
                {
                    Location = new Point(100, 20),
                    Width = 300,
                    Text = movie.Title
                };
                Label rated = new Label()
                {
                    Location = new Point(400, 20),
                    Width = 100,
                    Text = movie.Rated
                };
                Label duration = new Label()
                {
                    Location = new Point(550, 20),
                    Width = 100,
                    Text = movie.Duration.ToString()
                };
                Guna2GradientButton edit = new Guna2GradientButton()
                {
                    Image = global::MovieManager.Properties.Resources.info_30dp_BLACK_FILL0_wght400_GRAD0_opsz24,
                    Animated = true,
                    Tag = movie.ID,
                    BorderRadius = 10,
                    Size = new Size(30, 30),
                    FillColor = Color.FromArgb(175, 62, 62),
                    FillColor2 = Color.FromArgb(218, 108, 108),
                    Location = new Point(700, 12)
                };
                edit.Click += EditButton;
                pnl.Controls.Add(name);
                pnl.Controls.Add(rated);
                pnl.Controls.Add(duration);
                pnl.Controls.Add(edit);
                flowLayoutPanel1.Controls.Add(pnl);
            }
        }

        void SearchAndFilter()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            if (SearchTextBox.Text.Length == 0)
            {
                LoadShowTime(movies);
                return;
            }
            List<Movie> filter = new List<Movie>();
            foreach (Movie movie in movies)
                if (movie.Title.ToLower().Contains(SearchTextBox.Text.ToLower()))
                    filter.Add(movie);
            if (filter.Count > 0)
                LoadShowTime(filter);
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

        void EditButton(object sender, EventArgs e)
        {
            Guna2GradientButton btn = sender as Guna2GradientButton;
            if (btn != null && btn.Tag is int stId)
            {
                Info_ShowTime esm = new Info_ShowTime(stId);
                esm.Location = new Point((this.Size.Width - esm.Width) / 2, (this.Size.Height - esm.Height) / 2);
                this.Controls.Add(esm);
                esm.BringToFront();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddShowTime esm = new AddShowTime();
            esm.Location = new Point((this.Size.Width - esm.Width) / 2, (this.Size.Height - esm.Height) / 2);
            this.Controls.Add(esm);
            esm.BringToFront();
        }
    }
}
