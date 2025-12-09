using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DAO
{
    public class ShowTimeDetailDAO
    {
        private static ShowTimeDetailDAO instance;

        public static ShowTimeDetailDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ShowTimeDetailDAO(); 
                }
                return ShowTimeDetailDAO.instance;
                    
            }

            private set
            {
                ShowTimeDetailDAO.instance = value;
            }
        }

        private ShowTimeDetailDAO() { }

        public List<int> GetSeatIDListFromMovie(int idMovie, DateTime start_time)
        {
            List<int> ListIDSeat = new List<int>();

            string Start_time = start_time.ToString("dd/MM/yyyy HH:mm:ss");

            string querry = "select idSeat from ShowTimeDetail where idMovie = @id and Start_time = @time";
            DataTable table = DataProvider.Instance.ExecuteQuery(querry, new object[] { idMovie, start_time });

            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in  table.Rows)
                {
                    ListIDSeat.Add(Convert.ToInt32(row["idSeat"]));
                }    
            }    
            return ListIDSeat;
        }
    }
}
