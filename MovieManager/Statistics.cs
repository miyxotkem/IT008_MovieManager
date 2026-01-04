using MimeKit.Tnef;
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

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbType.SelectedIndex != -1)
            {
                string Type = (string)cbbType.Items[cbbType.SelectedIndex];
                if (Type == "Month")
                {
                    cbbValue.Items.Clear();
                    for (int i=1;i<=12;i++)
                    {
                        cbbValue.Items.Add(i.ToString());
                    }
                }
                else
                {
                    cbbValue.Items.Clear();
                    DateTime now = DateTime.Now;
                    int year = now.Year;
                    for (int i=10;i>=0;i--)
                    {
                        cbbValue.Items.Add((year - i).ToString());
                    }    
                } 
            }    
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            if (cbbType.SelectedIndex == -1 || cbbValue.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose appropriate time to summarize.","Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (cbbType.SelectedIndex != -1)
                {
                    cbbType.Focus();
                }
                else
                {
                    cbbValue.Focus();
                } 
                    
                return;
            }   
            

        }

        private void cbbTypeDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTypeDetail.SelectedIndex != -1)
            {
                string Type = (string)cbbTypeDetail.Items[cbbTypeDetail.SelectedIndex];
                if (Type == "Month")
                {
                    cbbValueDetail.Items.Clear();
                    for (int i = 1; i <= 12; i++)
                    {
                        cbbValueDetail.Items.Add(i.ToString());
                    }
                }
                else
                {
                    cbbValueDetail.Items.Clear();
                    DateTime now = DateTime.Now;
                    int year = now.Year;
                    for (int i = 10; i >= 0; i--)
                    {
                        cbbValueDetail.Items.Add((year - i).ToString());
                    }
                }
            }
        }

        private void ReloadButtonDetail_Click(object sender, EventArgs e)
        {
            if (cbbTypeDetail.SelectedIndex == -1 || cbbValueDetail.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose appropriate time to summarize.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (cbbTypeDetail.SelectedIndex != -1)
                {
                    cbbTypeDetail.Focus();
                }
                else
                {
                    cbbValueDetail.Focus();
                }

                return;
            }
        }
    }
}
