using MovieManager.DAO;
using MovieManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieManager
{
    public partial class Edit_MovieManage : UserControl
    {
        private List<Movie> movies = MovieDAO.Instance.LoadMovieList();
        private Movie main = null;
        public Edit_MovieManage()
        {
            InitializeComponent();
        }
        public Edit_MovieManage(int movieid)
        {
            InitializeComponent();
            foreach(Movie movie in movies)
            {
                if(movie.ID == movieid)
                {
                    main = movie;
                    TitleTextBox.Text = movie.Title;
                    GenreComboBox.Text = movie.Genre;
                    RatedComboBox.Text = movie.Rated;
                    try
                    {
                        DateTime parsedDate = DateTime.ParseExact(
                            movie.Release_date,
                            "dd/MM/yyyy HH:mm:ss",
                            CultureInfo.InvariantCulture
                        );
                        ReleaseDateTimePicker.Value = parsedDate;
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Error: The date string is in the wrong format. " + ex.Message);
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        MessageBox.Show("Error: The date is out of range. " + ex.Message);
                    }
                    DirectorTextBox.Text = movie.Director;
                    LanguageTextBox.Text = movie.Language;
                    DurationTextBox.Text = movie.Duration.ToString();
                    FormatComboBox.Text = movie.Format;
                    TrailerTextBox.Text = movie.Trailer;
                    ActorTextBox.Text = movie.Actor;
                    BriefTextBox.Text = movie.Brief;
                }
            }
        }
        private void guna2ShadowForm1_Load(object sender, EventArgs e)
        {
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Control parentContainer = this.Parent;
            if (parentContainer != null)
                parentContainer.Controls.Remove(this);
            this.Dispose();
        }
        private DataProvider dp = new DataProvider();
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE MOVIE SET title = @title , genre = @genre , rated = @rated , release_date = @release_date , director = @director , language = @language , duration = @duration , format = @format , trailer = @trailer , actor = @actor , brief = @brief WHERE id = @id";
            object[] values = new object[]
            {
                    TitleTextBox.Text,
                    GenreComboBox.Text,
                    RatedComboBox.Text,
                    ReleaseDateTimePicker.Value,
                    DirectorTextBox.Text,
                    LanguageTextBox.Text,
                    Convert.ToInt32(DurationTextBox.Text),
                    FormatComboBox.Text,
                    TrailerTextBox.Text,
                    ActorTextBox.Text,
                    BriefTextBox.Text,
                    main.ID
            };
            dp.ExecuteNonQuery(query, values);
            CancelButton.PerformClick();
        }
    }
}
