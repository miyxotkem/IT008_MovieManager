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

        public bool CheckSeatOccupied(int idMovie, DateTime start_time, int idSeat)
        {
            bool occupied = false;
            string Start_time = start_time.ToString("dd/MM/yyyy HH:mm:ss");
            string querry = "select available from ShowTimeDetail where idMovie = @id and Start_time = @time and idSeat = @seat";
            DataTable table = DataProvider.Instance.ExecuteQuery(querry, new object[] { idMovie, start_time, idSeat });
            if (table.Rows.Count > 0)
            {
                occupied = Convert.ToBoolean(table.Rows[0]["available"]);
            }
            return occupied;
        }

        public void ChooseSeat(int idMovie, DateTime start_time, int idSeat)
        {
            string querry = "Update ShowTimeDetail  set available = 1 where idMovie = @id and Start_time = @start and idSeat = @seat";
            int data = DataProvider.Instance.ExecuteNonQuery(querry, new object[] { idMovie, start_time, idSeat });
        }
    }
}
