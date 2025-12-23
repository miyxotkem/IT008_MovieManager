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
    public partial class TicketDisplay : UserControl
    {
        public TicketDisplay()
        {
            InitializeComponent();
        }

        public void Reload()
        {
            TicketContain.Controls.Clear(); 
        }

        public void AddTicket(Control control)
        {
            TicketContain.Controls.Add(control);
        }

        private void guna2Panel1_Resize(object sender, EventArgs e)
        {
            Container.Left = (guna2Panel1.ClientSize.Width - Container.Width) / 2;
            Container.Top = (guna2Panel1.ClientSize.Height - Container.Height) / 2; 
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
