using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MovieManager.DAO;
using Org.BouncyCastle.Math.Field;
namespace MovieManager
{
    public partial class SignUp : Form
    {
        private string AdminEmail;
        private string AppPassword;
        private string SenderEmail;
        private bool HaveSendEmail;
        public SignUp()
        {
            InitializeComponent();
            InitiateInformation();
        }

        private void InitiateInformation()
        {
            AdminEmail = "truongpd.a2.2124@gmail.com";
            SenderEmail = "ctpcinema2006@gmail.com";
            AppPassword = "qdhk jzis uoxs xtal";
            HaveSendEmail = false;
        }


        // Kiem tra thong tin nhap day du
        private bool CheckFillInformation()
        {
            if (FullNameTextBoxSignUp.Text.Length ==0 || EmailTextBoxSignUp.Text.Length ==0 || UsernameTextBoxSignUp.Text.Length ==0
                || PasswordTextBoxSignUp.Text.Length == 0 || RetypePasswordTextBoxSignUp.Text.Length == 0
                || TermsAndConditionsCheckBoxSignUp.Checked == false
                || PasswordTextBoxSignUp.Text != RetypePasswordTextBoxSignUp.Text)
            {
                return false;
            }
            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void SignUpButtonSignUp_Click(object sender, EventArgs e)
        {
            if (CheckFillInformation()) // Da nhap du thong tin
            {
                string UserEmail = EmailTextBoxSignUp.Text;
                string FullName = FullNameTextBoxSignUp.Text;
                string UserName = UsernameTextBoxSignUp.Text;
                if (!IsValidEmail(UserEmail))
                {
                    MessageBox.Show("Invalid email address.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EmailTextBoxSignUp.BorderColor = Color.Red;
                    epEmail.SetError(EmailTextBoxSignUp, "Invalid email address.");
                    return;
                }    
                if (AccountDAO.Instance.CheckAccountExist(UserName))
                {
                    MessageBox.Show("Username has already been used.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UsernameTextBoxSignUp.BorderColor = Color.Red;
                    epUsername.SetError(UsernameTextBoxSignUp, "Username has already been used.");
                    return;
                }    
                try
                {
                    // 1. Tạo nội dung thư
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("CTP Cinema", SenderEmail));
                    message.To.Add(new MailboxAddress(FullName, UserEmail));
                    message.Subject = "Notification";

                    // 2. Tạo nội dung (Body) cho thư
                    var bodyBuilder = new BodyBuilder();
                    bodyBuilder.HtmlBody = $@"
<div style=""font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Helvetica, Arial, sans-serif; background-color: #f5f5f5; padding: 40px;"">
    <div style=""max-width: 560px; margin: 0 auto; background-color: #ffffff; padding: 30px; border-radius: 12px; box-shadow: 0 5px 15px rgba(0,0,0,0.06);"">
        
        <h1 style=""font-size: 24px; color: #E53935; font-weight: 700; margin-top: 0; margin-bottom: 25px;"">
            Welcome to CTP Cinema
        </h1>

        <p style=""font-size: 16px; color: #333333; line-height: 1.6; margin-bottom: 15px;"">
            Greeting, <strong>{FullName}</strong>.
        </p>

        <p style=""font-size: 16px; color: #333333; line-height: 1.6; margin-bottom: 15px;"">
            This is an automated email from CTP Cinema. Thanks for using our application!
        </p>

        <p style=""font-size: 16px; color: #333333; line-height: 1.6; padding: 15px; background-color: #f9f9f9; border-radius: 8px; border-left: 4px solid #E53935; margin-bottom: 25px;"">
            <strong>Please wait for your account to be verified.</strong>
        </p>

        <p style=""font-size: 16px; color: #555555; line-height: 1.6; margin-bottom: 0;"">
            Sincerely thanks,
        </p>
        <p style=""font-size: 16px; color: #555555; line-height: 1.6; margin-top: 5px;"">
            The CTP Cinema Team
        </p>

    </div>
</div>
";
                    message.Body = bodyBuilder.ToMessageBody();

                    // 3. Kết nối và gửi
                    using (var client = new MailKit.Net.Smtp.SmtpClient())
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
                    // Đã gửi thành công
                    MessageBox.Show("Successful! Please check your email.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string Pass = PasswordTextBoxSignUp.Text;
                    AccountDAO.Instance.AddAccountFromSignUp(UserName, Pass, FullName, UserEmail);  
                    try
                    {
                        // 1. Tạo nội dung thư
                        var message = new MimeMessage();
                        message.From.Add(new MailboxAddress("CTP Cinema", SenderEmail));
                        message.To.Add(new MailboxAddress("Truong Pham", AdminEmail));
                        message.Subject = "Notification";

                        // 2. Tạo nội dung (Body) cho thư
                        var bodyBuilder = new BodyBuilder();
                        bodyBuilder.HtmlBody = @"
<div style=""font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Helvetica, Arial, sans-serif; background-color: #f5f5f5; padding: 40px;"">
    <div style=""max-width: 560px; margin: 0 auto; background-color: #ffffff; padding: 30px; border-radius: 12px; box-shadow: 0 5px 15px rgba(0,0,0,0.06);"">
        
        <h1 style=""font-size: 24px; color: #007bff; font-weight: 700; margin-top: 0; margin-bottom: 25px;"">
            System Notification
        </h1>

        <p style=""font-size: 16px; color: #333333; line-height: 1.6; margin-bottom: 15px;"">
            This is an automated alert from the CTP Cinema system.
        </p>
        
        <div style=""font-size: 18px; color: #333333; line-height: 1.6; padding: 20px; background-color: #f9f9f9; border-radius: 8px; text-align: center; border-left: 4px solid #007bff;"">
            <strong>New registrations in the application.</strong>
            <p style=""font-size: 14px; color: #555; margin-top: 10px; margin-bottom: 0;"">Please log in to the admin panel to review and verify.</p>
        </div>

        <p style=""font-size: 14px; color: #888888; line-height: 1.6; margin-top: 25px; margin-bottom: 0;"">
            CTP System Bot
        </p>

    </div>
</div>
";
                        message.Body = bodyBuilder.ToMessageBody();

                        // 3. Kết nối và gửi
                        using (var client = new MailKit.Net.Smtp.SmtpClient())
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

                        Console.WriteLine($"Sent successfully");
                    }
                    catch 
                    {
                        Console.WriteLine("Error!");
                    }
                }    
            }
            else
            {
                MessageBox.Show("Please fill and correct all the information.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (FullNameTextBoxSignUp.Text.Length == 0)
                {
                    FullNameTextBoxSignUp.BorderColor = Color.Red;
                    epFullName.SetError(FullNameTextBoxSignUp, "Please fill the information");
                }
                if (UsernameTextBoxSignUp.Text.Length == 0)
                {
                    UsernameTextBoxSignUp.BorderColor = Color.Red;
                    epUsername.SetError(UsernameTextBoxSignUp, "Plase fill the information");
                }
                if (EmailTextBoxSignUp.Text.Length == 0)
                {
                    EmailTextBoxSignUp.BorderColor = Color.Red;
                    epEmail.SetError(EmailTextBoxSignUp, "Please fill the information");
                }
                if (PasswordTextBoxSignUp.Text.Length == 0)
                {
                    PasswordTextBoxSignUp.BorderColor = Color.Red;
                    epPass.SetError(PasswordTextBoxSignUp, "Please fill the information");
                } 
                if (RetypePasswordTextBoxSignUp.Text.Length == 0)
                {
                    RetypePasswordTextBoxSignUp.BorderColor = Color.Red;
                    epRetype.SetError(RetypePasswordTextBoxSignUp, "Please fill the information");
                }
            }
        }

        private void ExitButtonSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FullNameTextBoxSignUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '_' || e.KeyChar == '-' || e.KeyChar == '@' || e.KeyChar == ' ' || e.KeyChar == '.')
            {
                return;
            }
            e.Handled = true;
        }

        private void UsernameTextBoxSignUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '_' || e.KeyChar == '-' || e.KeyChar == '@' || e.KeyChar == '.')
            {
                return;
            }
            e.Handled = true;
        }

        private void EmailTextBoxSignUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '_' || e.KeyChar == '-' || e.KeyChar == '@' || e.KeyChar == '.')
            {
                return;
            }
            e.Handled = true;
        }

        private void PasswordTextBoxSignUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void RetypePasswordTextBoxSignUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void SetDefaultColor(object sender , EventArgs e)
        {
            Guna2TextBox txb = (Guna2TextBox)sender;
            txb.BorderColor = Color.Gray;
        }

        private void FullNameTextBoxSignUp_Enter(object sender, EventArgs e)
        {
            SetDefaultColor(sender, EventArgs.Empty);
            epFullName.Clear();
        }

        private void UsernameTextBoxSignUp_Enter(object sender, EventArgs e)
        {
            SetDefaultColor(sender , EventArgs.Empty);
            epUsername.Clear();
        }

        private void PasswordTextBoxSignUp_Enter(object sender, EventArgs e)
        {
            SetDefaultColor(sender, EventArgs.Empty);
            epPass.Clear();
        }

        private void EmailTextBoxSignUp_Enter(object sender, EventArgs e)
        {
            SetDefaultColor(sender, EventArgs.Empty);
            epEmail.Clear();    
        }

        private void RetypePasswordTextBoxSignUp_Enter(object sender, EventArgs e)
        {
            SetDefaultColor(sender, EventArgs.Empty);
            epRetype.Clear();   
        }
    }
}
