using Guna.UI2.WinForms;
using MovieManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieManager
{
    public partial class ScreenLayout1 : UserControl
    {
        private Color Normal = Color.FromArgb(251, 198, 56);
        private Color VIP = Color.FromArgb(247, 175, 64);
        private Color SVIP = Color.FromArgb(233, 134, 30);
        private Color Couple = Color.FromArgb(184, 0, 0);
        private Color Choose = Color.FromArgb(235, 107, 149);
        private Color Occupied = Color.FromArgb(125, 31, 164);
        public ScreenLayout1()
        {
            InitializeComponent();
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
                                btn.FillColor = Color.White;
                                btn.FillColor2 = Color.White;
                                Color color = new Color();
                                if (list[index].SeatType == "Normal")
                                {
                                    color = Normal;
                                }  else if (list[index].SeatType == "VIP")
                                {
                                    color = VIP;
                                } else if (list[index].SeatType == "SVIP")
                                {
                                    color = SVIP;
                                }    else if (list[index].SeatType == "Couple")
                                {
                                    color = Couple;
                                }    
                                btn.FillColor = color;
                                btn.FillColor2 = color;
                                btn.Click += new EventHandler(btn_click);
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
            NotePanel.Left = (SeatPanel.ClientSize.Width - NotePanel.ClientSize.Width) / 2;
        }

        private void btn_click(object sender, EventArgs e)
        {
            Guna2GradientButton btn = (Guna2GradientButton)sender;
            if (btn.FillColor == Choose)
            {
                Color color = Color.White;
                if (btn.Tag is Seat seat)
                {
                    if (seat.SeatType == "Normal")
                    {
                        color = Normal;
                    } else if (seat.SeatType == "VIP")
                    {
                        color = VIP;
                    } else if (seat.SeatType == "SVIP")
                    {
                        color = SVIP;
                    } else if (seat.SeatType == "Couple")
                    {
                        color = Couple;
                    }    
                }    
                btn.FillColor = color;
                btn.FillColor2 = color;
            } else if (btn.FillColor != Occupied)
            {
                btn.FillColor = Choose;
                btn.FillColor2 = Choose;
            }    
        }
    }
}
