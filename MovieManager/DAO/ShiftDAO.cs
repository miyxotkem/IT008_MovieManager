using MovieManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DAO
{
    public class ShiftDAO
    {
        public static int Width = 200;
        public static int Height = 400;
        private static ShiftDAO instance;

        public static ShiftDAO Instance
        {
            get { if (instance == null) instance = new ShiftDAO(); return ShiftDAO.instance; }
            private set { ShiftDAO.instance = value; }
        }

        private ShiftDAO() { }

        public List<Shift> LoadShiftList()
        {
            List<Shift> ShiftList = new List<Shift>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetShiftList");
            foreach (DataRow row in data.Rows)
            {
                Shift Shift = new Shift(row);
                ShiftList.Add(Shift);
            }
            return ShiftList;
        }
    }
}
