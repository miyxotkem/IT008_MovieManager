using MovieManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return StaffDAO.instance; }
            private set { StaffDAO.instance = value; }
        }

        private StaffDAO() { }

        public List<Staff> LoadStaffList()
        {
            List<Staff> StaffList = new List<Staff>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetStaffList");
            foreach (DataRow row in data.Rows)
            {
                Staff Staff = new Staff(row);
                StaffList.Add(Staff);
            }
            return StaffList;
        }
    }
}
