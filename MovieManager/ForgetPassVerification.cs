using Guna.UI2.WinForms;
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
    public partial class ForgetPassVerification : Form
    {
        public ForgetPassVerification()
        {
            InitializeComponent();
            Number1TextboxForgetVerify.Focus();
        }

        private void InitiateOther()
        {
            Number1TextboxForgetVerify.Focus();
        }


        private void PreviousButtonForgetVerify_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LimitCharacter(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '1' && e.KeyChar <= '9') || char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }
        

        private void Number1TextboxForgetVerify_TextChanged(object sender, EventArgs e)
        {
            Guna2TextBox txb = (Guna2TextBox)sender;
            if (txb.Text.Length == 1)
            {
                Number2TextboxForgetPassVerify.Enabled = true;
                Number2TextboxForgetPassVerify.Focus();
                return;
            }
        }

        private void Number2TextboxForgetPassVerify_TextChanged(object sender, EventArgs e)
        {
            Guna2TextBox txb = (Guna2TextBox)sender;
            if (txb.Text.Length == 1)
            {
                Number3TextboxForgetPassVerify.Enabled = true;
                Number3TextboxForgetPassVerify.Focus();
                return;
            }
        }

        private void Number3TextboxForgetPassVerify_TextChanged(object sender, EventArgs e)
        {
            Guna2TextBox txb = (Guna2TextBox)sender;
            if (txb.Text.Length == 1)
            {
                Number4TextboxForgetPassVerify.Enabled = true;
                Number4TextboxForgetPassVerify.Focus();
                return;
            }
        }

        private void Number4TextboxForgetPassVerify_TextChanged(object sender, EventArgs e)
        {
            Guna2TextBox txb = (Guna2TextBox)sender;
            if (txb.Text.Length == 1)
            {
                Number5TextboxForgetPassVerify.Enabled = true;
                Number5TextboxForgetPassVerify.Focus();
                return;
            }
        }

        private void Number5TextboxForgetPassVerify_TextChanged(object sender, EventArgs e)
        {
            Guna2TextBox txb = (Guna2TextBox)sender;
            if (txb.Text.Length == 1)
            {
                Number6TextboxForgetPassVerify.Enabled = true;
                Number6TextboxForgetPassVerify.Focus();
                return;
            }
        }

        private void Number6TextboxForgetPassVerify_TextChanged(object sender, EventArgs e)
        {
            Guna2TextBox txb = (Guna2TextBox)sender;
            if (txb.Text.Length == 1)
            {
                ResetButtonForgetVerify.Focus();
                return;
            }
        }
        
    }
}
