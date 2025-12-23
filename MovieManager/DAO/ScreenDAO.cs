using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManager.DTO;
namespace MovieManager.DAO
{
    public class ScreenDAO
    {
        private static ScreenDAO instance;

        public static ScreenDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ScreenDAO();
                }
                return ScreenDAO.instance;
            }
            private set
            {
                ScreenDAO.instance = value;
            }
        }

        private ScreenDAO() { }

        public Screen GetScreen(int idScreen)
        {
            Screen screen = null;
            string query = "select * from Screen where id = @id ";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { idScreen });
            if (table.Rows.Count > 0 )
            {
                screen = new Screen(table.Rows[0]);
            }
            return screen;
        }
    }
}
