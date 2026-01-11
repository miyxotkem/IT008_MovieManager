    using MovieManager.DAO;
    using MovieManager.DTO;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
using System.IO;
using System.Linq;
    using System.Runtime.Remoting.Metadata.W3cXsd2001;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace MovieManager
    {
        public partial class AddShowTime : UserControl
        {
            private List<Movie> movies = MovieDAO.Instance.LoadMovieList();
            private List<ShowTime> showtimes = ShowTimeDAO.Instance.LoadShowTimeList();
            public AddShowTime()
            {
                InitializeComponent();
                StartTimeDTP.Value = DateTime.Now;
                foreach (Movie movie in movies)
                    MovieCB.Items.Add(movie.Title);
                FromDTP.Value = DateTime.Now;
                ToDTP.Value = DateTime.Now;
            }
            private int duration = 0;
            private int idmovie = 0;
            private string dest = @"C:\Users\Thinh Phat\Documents\UIT\MovieManager\MovieManager\Posters";
            private void MovieCB_SelectedIndexChanged(object sender, EventArgs e)
            {
                foreach (Movie movie in movies)
                    if (movie.Title == MovieCB.SelectedItem.ToString())
                    {
                        DurationCB.Text = movie.Duration.ToString() + " minutes";
                        duration = movie.Duration;
                        idmovie = movie.ID;
                        EndTimeTB.Text = StartTimeDTP.Value.AddMinutes(movie.Duration + 30).ToString("HH:mm:ss") + " (+30 minutes)";
                        string fileName = movie.ID.ToString() + ".jpg";
                        string fullImagePath = Path.Combine(dest, fileName);
                        if (File.Exists(fullImagePath))
                            PosterPictureBox.Image = LoadImageUnlocked(fullImagePath);
                        break;
                    }
            }

            private Image LoadImageUnlocked(string path)
            {
                byte[] bytes = File.ReadAllBytes(path);
                MemoryStream ms = new MemoryStream(bytes);
                return Image.FromStream(ms);
            }

            private void CancelButton_Click(object sender, EventArgs e)
            {
                Control parentContainer = this.Parent;
                if (parentContainer != null)
                    parentContainer.Controls.Remove(this);
                this.Dispose();
            }
            DataProvider dp = new DataProvider();
            private void ApplyButton_Click(object sender, EventArgs e)
            {
                if (duration == 0)
                {
                    MessageBox.Show("Please select available movie.");
                    return;
                }
                if (ScreenCB.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select available screen.");
                    return;
                }
                if (FromDTP.Value.Date > ToDTP.Value.Date)
                {
                    MessageBox.Show("The 'From' date cannot be later than the 'To' date.");
                    return;
                }

                DateTime cs = FromDTP.Value.Date + StartTimeDTP.Value.TimeOfDay;

                foreach (ShowTime showTime in showtimes)
                {
                    foreach (Movie movie in movies)
                    {
                        if (movie.ID == showTime.IDMovie)
                        {
                            DateTime ss = showTime.Start_time;
                            DateTime se = showTime.Start_time.AddMinutes(movie.Duration + 30);

                            for (DateTime i = cs; i.Date <= ToDTP.Value.Date; i = i.AddDays(1))
                            {
                                DateTime ce = i.AddMinutes(duration + 30);

                                if (i < se && ss < ce)
                                {
                                    if (showTime.IDScreen == ScreenCB.SelectedIndex + 1)
                                    {
                                        MessageBox.Show("Unavailable time. Screen is occupied by " + movie.Title);
                                        return;
                                    }

                                    if (showTime.IDMovie == idmovie)
                                    {
                                        MessageBox.Show("Unavailable time. " + movie.Title + " is already playing on another screen at this time.");
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }

            string query = @"INSERT INTO SHOWTIME (idmovie, idscreen, start_time) VALUES( @idmovie , @idscreen , @time )";

            for (DateTime i = cs; i.Date <= ToDTP.Value.Date; i = i.AddDays(1))
            {
                object[] values = new object[]
                {
            idmovie,
            ScreenCB.SelectedIndex + 1,
            i,
                };
                dp.ExecuteQuery(query, values);
            }
            string query2 = @"INSERT INTO SHOWTIMEDETAIL (idMovie, Start_time, idSeat, available) VALUES ( @idmovie , @start , @seat , @available )";
            for (DateTime i = cs; i.Date <= ToDTP.Value.Date; i = i.AddDays(1))
            {
                for (int j = (ScreenCB.SelectedIndex + 1) * 50 - 49; j <= (ScreenCB.SelectedIndex + 1) * 50; j++)
                {
                    object[] values2 = new object[]
                    {
                idmovie,
                i,
                j,
                0
                    };
                    dp.ExecuteQuery(query2, values2);
                }
            }
            MessageBox.Show("Added successfully!");
            CancelButton.PerformClick();
        }

        private void StartTimeDTP_ValueChanged(object sender, EventArgs e)
            {
                EndTimeTB.Text = StartTimeDTP.Value.AddMinutes(duration + 30).ToString("HH:mm:ss") + " (+30 minutes)";
            }
        }
    }
