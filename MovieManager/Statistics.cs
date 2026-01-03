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
    public partial class Statistics : UserControl
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel1_Resize(object sender, EventArgs e)
        {
            ContainPanel.Left = (this.ClientSize.Width - ContainPanel.Width) / 2;
            ContainPanel.Top = (this.ClientSize.Height - ContainPanel.Height) / 2;
        }
    }
}
