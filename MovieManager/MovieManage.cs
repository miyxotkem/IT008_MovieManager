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
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace MovieManager
{
    public partial class MovieManage : UserControl
    {
        private List<Movie> movies;
        private Dictionary<int, bool> checkingStatus;
        public MovieManage()
        {
            InitializeComponent();
            movies = MovieDAO.Instance.LoadMovieList();
            checkingStatus = new Dictionary<int, bool>();
            FilterComboBox.SelectedIndex = 0;
            //LoadMovie(MovieDAO.Instance.LoadMovieList());
            foreach (Movie movie in movies)
                checkingStatus.Add(movie.ID, false);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (FilterComboBox.SelectedIndex == 0)
                SearchAndFilter();
            else
                FilterComboBox.SelectedIndex = 0;
        }
        public void LoadMovie(List<Movie> movieList)
        {
            //Panel p = new Panel()
            //{
            //    Height = 30,
            //    Width = 1300
            //};
            //Label t = new Label()
            //{
            //    Location = new Point(100, 23),
            //    Width = 500,
            //    Text = "Title"
            //};
            //Label g = new Label()
            //{
            //    Location = new Point(750, 23),
            //    Width = 100,
            //    Text = "Gerne"
            //};
            //Label r = new Label()
            //{
            //    Location = new Point(1100, 23),
            //    Width = 100,
            //    Text = "Rated"
            //};
            //Label d = new Label()
            //{
            //    Location = new Point(1450, 23),
            //    Width = 100,
            //    Text = "Duration"
            //};
            //p.Controls.Add(t);
            //p.Controls.Add(g);
            //p.Controls.Add(r);
            //p.Controls.Add(d);
            //flowLayoutPanel1.Controls.Add(p);
            foreach (Movie movie in movieList)
            {
                bool isChecked = false;
                checkingStatus.TryGetValue(movie.ID, out isChecked);
                Guna2GradientPanel pnl = new Guna2GradientPanel()
                {
                    Height = 50,
                    Width = 1200,
                    BorderColor = Color.Black
                };
                CheckBox cb = new CheckBox()
                {
                    Location = new Point(5, 20),
                    AutoSize = true,
                    Tag = movie.ID,
                    Checked = isChecked
                };
                Label title = new Label()
                {
                    Location = new Point(100, 23),
                    Width = 500,
                    Text = movie.Title
                };
                Label genre = new Label()
                {
                    Location = new Point(600, 23),
                    Width = 100,
                    Text = movie.Genre
                };
                Label rated = new Label()
                {
                    Location = new Point(750, 23),
                    Width = 100,
                    Text = movie.Rated
                };
                Label duration = new Label()
                {
                    Location = new Point(900, 23),
                    Width = 100,
                    Text = movie.Duration.ToString()
                };
                Guna2GradientButton edit = new Guna2GradientButton()
                {
                    Image = global::MovieManager.Properties.Resources.MovieDisplay,
                    Animated = true,
                    Tag = movie.ID,
                    BorderRadius = 10,
                    Size = new Size(30, 30),
                    FillColor = Color.FromArgb(175, 62, 62),
                    FillColor2 = Color.FromArgb(218, 108, 108),
                    Location = new Point(1050, 12)
                };
                pnl.Controls.Add(cb);
                cb.CheckedChanged += Check;
                edit.Click += EditButton;
                pnl.Controls.Add(title);
                pnl.Controls.Add(genre);
                pnl.Controls.Add(rated);
                pnl.Controls.Add(duration);
                pnl.Controls.Add(edit);
                flowLayoutPanel1.Controls.Add(pnl);
            }
        }
        void Check(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb != null && cb.Tag is int movieId)
            {
                checkingStatus[movieId] = cb.Checked;
            }
        }

        void EditButton(object sender, EventArgs e)
        {
            Guna2GradientButton btn = sender as Guna2GradientButton;
            if(btn != null && btn.Tag is int movieId)
            {
                Edit_MovieManage emm = new Edit_MovieManage(movieId);
                emm.Location = new Point((this.Size.Width - emm.Width) / 2, (this.Size.Height - emm.Height) / 2);
                this.Controls.Add(emm);
                emm.BringToFront();
            }
        }

        void SearchAndFilter()
        {
            flowLayoutPanel1.Controls.Clear();
            if (SearchTextBox.Text.Length == 0 && FilterComboBox.Text == "All")
            {
                LoadMovie(MovieDAO.Instance.LoadMovieList());
                return;
            }
            List<Movie> filter = new List<Movie>();
            foreach (Movie movie in movies)
            {
                if (SearchTextBox.Text.Length == 0 && movie.Genre == FilterComboBox.Text)
                        filter.Add(movie);
                else if (FilterComboBox.Text == "All" && movie.Title.ToLower().Contains(SearchTextBox.Text.ToLower()))
                        filter.Add(movie);
                else if (movie.Title.ToLower().Contains(SearchTextBox.Text.ToLower()) && movie.Genre == FilterComboBox.Text)
                    filter.Add(movie);
            }
            if (filter.Count > 0)
                LoadMovie(filter);
        }
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchAndFilter();
        }

        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Guna2GradientPanel pnl)
                {
                    foreach (Control childControl in pnl.Controls)
                    {
                        if (childControl is CheckBox cb)
                        {
                            cb.Checked = true;
                            if (cb.Tag is int movieId)
                                checkingStatus[movieId] = true;
                            break;
                        }
                    }
                }
            }
        }

        private void DeselectAllButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Guna2GradientPanel pnl)
                {
                    foreach (Control childControl in pnl.Controls)
                    {
                        if (childControl is CheckBox cb)
                        {
                            cb.Checked = false;
                            if (cb.Tag is int movieId)
                                checkingStatus[movieId] = false;
                            break;
                        }
                    }
                }
            }
        }

        private void DeleteSearchButton_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = "";
            SearchAndFilter();
        }

        private void DeleteFilter_Click(object sender, EventArgs e)
        {
            FilterComboBox.SelectedIndex = 0;
            SearchAndFilter();
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAndFilter();
        }
        private DataProvider dp = new DataProvider();
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (var item in checkingStatus)
            {
                bool isChecked = item.Value;
                if (isChecked)
                    count++;
            }
            if (count > 0)
            {
                if (MessageBox.Show("Delete " + count + " movie(s)?") == DialogResult.OK)
                    foreach (var item in checkingStatus)
                    {
                        int id = item.Key;
                        bool isChecked = item.Value;
                        if (isChecked)
                        {
                            string query = @"DELETE FROM Movie WHERE id = @id";
                            object[] values = new object[] { id };
                            dp.ExecuteNonQuery(query, values);
                        }
                    }
                sync();
            }
            else
                MessageBox.Show("No movies selected");
        }
        void sync()
        {
            movies = MovieDAO.Instance.LoadMovieList();
            flowLayoutPanel1.Controls.Clear();
            foreach (Movie movie in movies)
                if (!checkingStatus.ContainsKey(movie.ID))
                    checkingStatus.Add(movie.ID, false);
            SearchAndFilter();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Edit_MovieManage emm = new Edit_MovieManage();
            emm.Location = new Point((this.Size.Width - emm.Width) / 2, (this.Size.Height - emm.Height) / 2);
            this.Controls.Add(emm);
            emm.BringToFront();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            sync();
        }
    }
}
