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
    public class ShowTimeDAO
    {
        private static ShowTimeDAO instance;

        public static ShowTimeDAO Instance
        {
            get { if (instance == null) instance = new ShowTimeDAO(); return ShowTimeDAO.instance; }
            private set { ShowTimeDAO.instance = value; }
        }

        private ShowTimeDAO() { }

        public List<ShowTime> LoadShowTimeList()
        {
            List<ShowTime> showtimeList = new List<ShowTime>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetShowTimeList");
            foreach (DataRow row in data.Rows)
            {
                ShowTime showtime = new ShowTime(row);
                showtimeList.Add(showtime);
            }
            return showtimeList;
        }
    }
}

