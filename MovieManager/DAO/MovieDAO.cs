using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManager.DAO;
using MovieManager.DTO;
using System.Data;

namespace MovieManager.DAO
{
    public class MovieDAO
    {
        public static int Width = 200;
        public static int Height = 400;
        private static MovieDAO instance;

        public static MovieDAO Instance
        {
            get { if (instance == null) instance = new MovieDAO(); return MovieDAO.instance; }
            private set { MovieDAO.instance = value; }
        }
        
        private MovieDAO() { }

        public List<Movie> LoadMovieList()
        {
            List<Movie> movieList = new List<Movie>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetMovieList");
            foreach(DataRow row in data.Rows)
            {
                Movie movie = new Movie(row);
                movieList.Add(movie);
            }
            return movieList;
        }

        public Movie GetMovieFromIDMovie(int id)
        {
            Movie movie = null;
            string querry = "select * from Movie where id = @id";
            DataTable table = DataProvider.Instance.ExecuteQuery(querry, new object[] { id }); 
            if (table.Rows.Count > 0)
            {
                movie = new Movie(table.Rows[0]);
            }
            return movie;
        }
    }
}

