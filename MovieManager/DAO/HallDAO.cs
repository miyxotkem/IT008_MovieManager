using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MovieManager.DTO;
namespace MovieManager.DAO
{
    public class HallDAO
    {
        private static HallDAO instance;

        public static HallDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HallDAO();
                }    
                return HallDAO.instance;
            }
            private set
            {
                HallDAO.instance = value;
            }
        }

        private HallDAO() { }

        public Hall GetHall(int idHall)
        {
            Hall hall = null;
            string query = "select * from Hall where id = @id ";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { idHall });
            if (table.Rows.Count > 0)
            {
                hall = new Hall(table.Rows[0]); 
            }
            return hall;
        }
    }
}
