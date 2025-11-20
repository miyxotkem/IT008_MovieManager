using Guna.UI2.WinForms;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MovieManager.DAO;

namespace MovieManager
{
    public partial class ForgetPassVerification : Form
    {
        private bool HaveSendEmail = false;
        private string UserEmail = "";
        private string UserName;
        private int IDStaff;
        private string SenderEmail = "ctpcinema2006@gmail.com";
        private string AppPassword = "qdhk jzis uoxs xtal";
        private Random random = new Random();
        private string VerificationCode;
        public ForgetPassVerification()
        {
            InitializeComponent();
        }

        public ForgetPassVerification(string user, string _UserEmail, int _IDStaff)
        {
            InitializeComponent();
            UserEmail = _UserEmail;
            IDStaff = _IDStaff;
            UserName = user;
            if (IDStaff != -1 && UserEmail != "")
            {
                SendEmail();
            } else
            {
                MessageBox.Show("Can not send email", "Notification");
            }
        }

        private void VerificationTimeOut()
        {
            ForgetPassUsernameDAO.Instance.EraseVerificationCode(IDStaff, VerificationCode);
        }
        private void SendEmail()
        {
            int RandomNumber = random.Next(0, 100001);
            VerificationCode = RandomNumber.ToString("000000");
            try
            {
                // 1. Tạo nội dung thư
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("CTP Cinema", SenderEmail));
                message.To.Add(new MailboxAddress(UserName, UserEmail));
                message.Subject = "Notification";

                // 2. Tạo nội dung (Body) cho thư
                var bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = $@"
<div style=""font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Helvetica, Arial, sans-serif; background-color: #f5f5f5; padding: 40px;"">
    <div style=""max-width: 560px; margin: 0 auto; background-color: #ffffff; padding: 30px; border-radius: 12px; box-shadow: 0 5px 15px rgba(0,0,0,0.06);"">
        
        <h1 style=""font-size: 24px; color: #E53935; font-weight: 700; margin-top: 0; margin-bottom: 25px;"">
            Password Reset Request
        </h1>

        <p style=""font-size: 16px; color: #333333; line-height: 1.6; margin-bottom: 15px;"">
            Greeting, <strong>{UserName}</strong>.
        </p>

        <p style=""font-size: 16px; color: #333333; line-height: 1.6; margin-bottom: 25px;"">
            This is your verification code to **reset your account's password**.
        </p>

        <div style=""text-align: center; margin-bottom: 30px;"">
            <p style=""font-size: 14px; color: #555555; margin-bottom: 5px;"">
                Your Verification Code:
            </p>
            <strong style=""display: inline-block; font-size: 32px; letter-spacing: 3px; color: #ffffff; background-color: #E53935; padding: 10px 20px; border-radius: 8px; font-family: 'Courier New', Courier, monospace;"">
                {VerificationCode}
            </strong>
        </div>

        <p style=""font-size: 16px; color: #E53935; line-height: 1.6; padding: 15px; background-color: #fff3f3; border-radius: 8px; border-left: 4px solid #E53935; margin-bottom: 25px;"">
            **Please keep this code under your privacy** and do not share it with anybody else.
        </p>

        <p style=""font-size: 14px; color: #777777; line-height: 1.6; margin-bottom: 30px; text-align: center;"">
            The code is single use only and **will be expired within 5 minutes**.
        </p>

        <p style=""font-size: 16px; color: #555555; line-height: 1.6; margin-bottom: 0;"">
            Thanks,
        </p>
        <p style=""font-size: 16px; color: #555555; line-height: 1.6; margin-top: 5px;"">
            CTP Team
        </p>

    </div>
</div>
";
                message.Body = bodyBuilder.ToMessageBody();

                // 3. Kết nối và gửi
                using (var client = new SmtpClient())
                {
                    // Kết nối đến máy chủ SMTP của Gmail qua cổng 587 (TLS)
                    client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);

                    // Xác thực bằng tài khoản và Mật khẩu Ứng Dụng của bạn
                    client.Authenticate(SenderEmail, AppPassword);

                    // Gửi email
                    client.Send(message);

                    // Ngắt kết nối
                    client.Disconnect(true);
                }
                HaveSendEmail = true;
            }
            catch
            {
                MessageBox.Show("Error when sending email", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (HaveSendEmail)
            {
                ForgetPassUsernameDAO.Instance.InsertValueIntoForgetTable(IDStaff, VerificationCode);
                TimeOut.Start();
            }    
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
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || char.IsControl(e.KeyChar))
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

        private void TimeOut_Tick(object sender, EventArgs e)
        {
            VerificationTimeOut();
            TimeOut.Stop();
        }

        private void ResendLinkLabelForgetPassVerify_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendEmail();
        }

        private void ResetButtonForgetVerify_Click(object sender, EventArgs e)
        {
            string VerifyCode = Number1TextboxForgetVerify.Text
                + Number2TextboxForgetPassVerify.Text
                + Number3TextboxForgetPassVerify.Text
                + Number4TextboxForgetPassVerify.Text
                + Number5TextboxForgetPassVerify.Text
                + Number6TextboxForgetPassVerify.Text;
            if (ForgetPassUsernameDAO.Instance.CheckVerificationCode(IDStaff, VerifyCode))
            {
                ForgetPassUsernameDAO.Instance.EraseVerificationCode(IDStaff, VerifyCode);
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("Invalid verification code", "Notification");
            } 
                
        }
    }
}
