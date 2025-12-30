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
        private int main = 0;
        private Dictionary<ShowTime, bool> checkingStatus;
        public Info_ShowTime()
        {
            InitializeComponent();
        }

        public Info_ShowTime(int id)
        {
            InitializeComponent();
            checkingStatus = new Dictionary<ShowTime, bool>();
            main = id;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel3.Controls.Clear();
            foreach (Movie movie in movies)
                if (movie.ID == id)
                    Title.Text = movie.Title;
            foreach (ShowTime showtime in showtimes)
            {
                if (showtime.IDMovie == id)
                {
                    checkingStatus.Add(showtime, false);
                    Panel pnl = new Panel()
                    {
                        Width = 250,
                        Height = 50,
                    };
                    Label lbl = new Label()
                    {
                        Location = new Point(80, 30),
                        Width = 250,
                        Font = new Font("Microsoft Sans Serif", 15f),
                        Text = showtime.Start_time.ToString("HH:mm dd/mm/yyyy")
                    };
                    CheckBox delete = new CheckBox()
                    {
                        Location = new Point(50, 32),
                        Tag = showtime
                    };
                    delete.CheckedChanged += Check;
                    pnl.Controls.Add(lbl);
                    pnl.Controls.Add(delete);
                    if (showtime.IDScreen == 1)
                        flowLayoutPanel1.Controls.Add(pnl);
                    else if (showtime.IDScreen == 2)
                        flowLayoutPanel2.Controls.Add(pnl);
                    else if (showtime.IDScreen == 3)
                        flowLayoutPanel3.Controls.Add(pnl);
                }
            }
        }

        void Check(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb != null && cb.Tag is ShowTime st)
            {
                checkingStatus[st] = cb.Checked;
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
        DataProvider dp = new DataProvider();
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!checkingStatus.ContainsValue(true))
            {
                MessageBox.Show("Please select something to delete!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Confirm deletion?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            foreach (var item in checkingStatus.ToList())
            {
                ShowTime st = item.Key;
                bool isChecked = item.Value;

                if (!isChecked) continue;
                string query = "DELETE FROM ShowTime WHERE idmovie = @id AND start_time = @time";
                string sqlTime = st.Start_time.ToString("yyyy-MM-dd HH:mm:ss");

                object[] values = new object[] { st.IDMovie, sqlTime };
                int rowsAffected = dp.ExecuteNonQuery(query, values);

                if (rowsAffected > 0)
                {
                    checkingStatus.Remove(st);
                    RemoveControlByValues(flowLayoutPanel1, st);
                    RemoveControlByValues(flowLayoutPanel2, st);
                    RemoveControlByValues(flowLayoutPanel3, st);
                }
                else
                {
                    MessageBox.Show($"Could not delete showtime at {sqlTime}. It may have been modified externally.");
                }
            }
        }
        void RemoveControlByValues(FlowLayoutPanel panel, ShowTime stToDelete)
        {
            Control toRemove = null;
            foreach (Control pnl in panel.Controls)
            {
                foreach (Control child in pnl.Controls)
                {
                    if (child is CheckBox cb && cb.Tag is ShowTime stInBox)
                    {
                        bool sameMovie = stInBox.IDMovie == stToDelete.IDMovie;
                        bool sameTime = stInBox.Start_time.ToString("yyyy-MM-dd HH:mm:ss") == stToDelete.Start_time.ToString("yyyy-MM-dd HH:mm:ss");

                        if (sameMovie && sameTime)
                        {
                            toRemove = pnl;
                            break;
                        }
                    }
                }
                if (toRemove != null) break;
            }

            if (toRemove != null)
            {
                panel.Controls.Remove(toRemove);
                toRemove.Dispose();
            }
        }
    }
}
