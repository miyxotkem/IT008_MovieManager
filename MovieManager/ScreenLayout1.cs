using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MovieManager.DTO;

namespace MovieManager
{
    public partial class ScreenLayout1 : UserControl
    {  
        public ScreenLayout1()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void Reload(List<Seat> list)
        {
            if (list != null && list.Count > 0)
            {
                string firstname = "guna2GradientButton";
                for (int index = 0; index < list.Count; index++)
                {
                    string last = Convert.ToString(index + 1);
                    string btnName = firstname + last;  
                    foreach (Control ctrl in SeatPanel.Controls)
                    {
                        if (ctrl is Guna2GradientButton btn)
                        {
                            string name = btn.Name.ToString();
                            if (name == btnName)
                            {
                                btn.Text = Convert.ToString(list[index].SeatRow + list[index].SeatNumber);
                                btn.Tag = list[index];
                                break;
                            }    
                        }    
                    }    
                }    
            }    
        }

        private void Container_Resize(object sender, EventArgs e)
        {
            ScreenPanel.Left = (Container.ClientSize.Width - ScreenPanel.ClientSize.Width) / 2;
            SeatPanel.Left = (Container.ClientSize.Width - SeatPanel.ClientSize.Width) / 2;
        }
    }
}
