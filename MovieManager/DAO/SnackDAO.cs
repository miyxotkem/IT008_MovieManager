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

        public Snack GetSnackFromIDSnack(int id)
        {
            Snack snack = null;
            string querry = "select * from Snack where id = @id";
            DataTable table = DataProvider.Instance.ExecuteQuery(querry, new object[] { id });
            if (table.Rows.Count > 0)
            {
                snack = new Snack(table.Rows[0]);
            }    
            return snack;
        }

        public void UpdateStock(int idSnack, int Quantity)
        {
            string query = "Update Snack set stock = stock - @quan where id = @id ";
            DataProvider.Instance.ExecuteScalar(query, new object[] {Quantity,  idSnack}); 
        }
    }
}

