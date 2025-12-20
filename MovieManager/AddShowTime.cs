    using MovieManager.DAO;
    using MovieManager.DTO;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
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
                foreach (Movie movie in movies)
                    MovieCB.Items.Add(movie.Title);
            }
            private int duration = 0;
            private int idmovie = 0;
            private void MovieCB_SelectedIndexChanged(object sender, EventArgs e)
            {
                foreach (Movie movie in movies)
                    if (movie.Title == MovieCB.SelectedItem.ToString())
                    {
                        DurationCB.Text = movie.Duration.ToString() + " minutes";
                        duration = movie.Duration;
                        idmovie = movie.ID;
                        EndTimeTB.Text = StartTimeDTP.Value.AddMinutes(movie.Duration + 30).ToString("HH:mm:ss") + " (+30 minutes)";
                        break;
                    }
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
                if(ScreenCB.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select available screen.");
                    return;
            }
                DateTime cs = FromDTP.Value.Date + StartTimeDTP.Value.TimeOfDay;
                foreach (ShowTime showTime in showtimes)
                {
                    foreach (Movie movie in movies)
                        if (movie.ID == showTime.IDMovie && showTime.IDScreen == ScreenCB.SelectedIndex + 1)
                        {
                            DateTime ss = showTime.Start_time;
                            DateTime se = showTime.Start_time.AddMinutes(movie.Duration + 30);
                            for (DateTime i = cs; i.Date <= ToDTP.Value.Date; i = i.AddDays(1))
                            {
                                DateTime ce = i.AddMinutes(duration + 30);
                                if (i < se && ss < ce)
                                {
                                    MessageBox.Show("Unavailable time. " + movie.Title.ToString() + " has occupied.");
                                    return;
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
                string query2 = @"INSERT INTO SHOWTIMEDETAIL (idMovie, Start_time, idSeat, available) VALUES ( @idmvovie , @start , @seat , @available )";
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
                CancelButton.PerformClick();
            }

            private void StartTimeDTP_ValueChanged(object sender, EventArgs e)
            {
                EndTimeTB.Text = StartTimeDTP.Value.AddMinutes(duration + 30).ToString("HH:mm:ss") + " (+30 minutes)";
            }
        }
    }
