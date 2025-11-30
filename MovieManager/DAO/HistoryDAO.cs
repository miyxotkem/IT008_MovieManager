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
    public class HistoryDAO
    {
        public static int Width = 200;
        public static int Height = 400;
        private static HistoryDAO instance;

        public static HistoryDAO Instance
        {
            get { if (instance == null) instance = new HistoryDAO(); return HistoryDAO.instance; }
            private set { HistoryDAO.instance = value; }
        }

        private HistoryDAO() { }

        public List<History> LoadHistoryList()
        {
            List<History> HistoryList = new List<History>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetHistoryList");
            foreach (DataRow row in data.Rows)
            {
                History History = new History(row);
                HistoryList.Add(History);
            }
            return HistoryList;
        }
    }
}

