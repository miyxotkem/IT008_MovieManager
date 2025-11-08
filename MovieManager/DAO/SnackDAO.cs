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
    public class SnackDAO
    {
        public static int Width = 200;
        public static int Height = 400;
        private static SnackDAO instance;

        public static SnackDAO Instance
        {
            get { if (instance == null) instance = new SnackDAO(); return SnackDAO.instance; }
            private set { SnackDAO.instance = value; }
        }

        private SnackDAO() { }

        public List<Snack> LoadSnackList()
        {
            List<Snack> snackList = new List<Snack>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetSnackList");
            foreach (DataRow row in data.Rows)
            {
                Snack snack = new Snack(row);
                snackList.Add(snack);
            }
            return snackList;
        }
    }
}

