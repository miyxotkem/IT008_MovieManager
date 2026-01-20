using MovieManager.DAO;
using MovieManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieManager
{
    public partial class History_SnackManage : UserControl
    {
        private List<History> histories = HistoryDAO.Instance.LoadHistoryList();
        private List<Snack> snacks = SnackDAO.Instance.LoadSnackList();
        public History_SnackManage()
        {
            InitializeComponent();
            HistoryLoad();
        }
        void HistoryLoad()
        {
            Panel pnl = new Panel()
            {
                Width = 800,
                Height = 30
            };
            Label n = new Label()
            {
                Location = new Point(50, 10),
                Width = 200,
                Text = "Name",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label s = new Label()
            {
                Location = new Point(250, 10),
                Width = 150,
                Text = "Stock",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label d = new Label()
            {
                Location = new Point(400, 10),
                Width = 150,
                Text = "Date",
                Font = new Font(Font, FontStyle.Bold)
            };
            pnl.Controls.Add(n);
            pnl.Controls.Add(s);
            pnl.Controls.Add(d);
            panel3.Controls.Add(pnl);
            foreach (History history in histories.AsEnumerable().Reverse())
            {
                Panel panel = new Panel()
                {
                    Width = 800,
                    Height = 30,
                    Margin = new Padding(0, 0, 0, 5)
                };
                string text = "";
                foreach (Snack snack in snacks)
                    if (snack.ID == history.Idsnack)
                        text = snack.Name;
                Label name = new Label()
                {
                    AutoSize = false,
                    Width = 200,
                    Location = new Point(50, 0),
                    Text = text,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                Label quantity = new Label()
                {
                    AutoSize = false,
                    Width = 150,
                    Location = new Point(250, 0),
                    Text = history.Quantity.ToString(),
                    TextAlign = ContentAlignment.MiddleLeft
                };
                Label date = new Label()
                {
                    AutoSize = false,
                    Width = 150,
                    Location = new Point(400, 0),
                    Text = history.Date.ToString("dd/MM/yyyy"),
                    TextAlign = ContentAlignment.MiddleLeft
                };
                panel.Controls.Add(name);
                panel.Controls.Add(quantity);
                panel.Controls.Add(date);
                FLP.Controls.Add(panel);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Control parentContainer = this.Parent;
            if (parentContainer != null)
                parentContainer.Controls.Remove(this);
            this.Dispose();
        }
    }
}
