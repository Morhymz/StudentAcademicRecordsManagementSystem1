using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Registration_and_Account_Management_2
{
    public partial class ForgotPassword : Form
    {
        string FilePath = @"C:\Users\bongu\Desktop\Users.txt";

        string VerificationCode = "";

        string EmailAddress = "";
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            bool UserIDFound = false;

            string LineRec = "";

            string[] UserDetails = new string[9];

            if (File.Exists(FilePath))
            {
                StreamReader UserFile = new StreamReader(FilePath);

                using (UserFile)
                {
                    LineRec = UserFile.ReadLine();

                    while (LineRec != null)
                    {
                        UserDetails = LineRec.Split('\t');

                        if (UserDetails.Length > 0)
                        {
                            if (txtUserID.Text == UserDetails[0])
                            {
                                UserIDFound = true;
                            }
                        }

                        LineRec = UserFile.ReadLine();
                    }
                }
            }

            if (txtUserID.Text == "")
            {
                lblUserIDStatus.Text = "";
            }
            else if (UserIDFound == true)
            {
                lblUserIDStatus.Text = "";
            }
            else
            {
                lblUserIDStatus.ForeColor = Color.Red;
                lblUserIDStatus.Text = "✗ User ID Not Found";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblPasswordMatch_Click(object sender, EventArgs e)
        {
           
            if (txtNewPassword.Text ==
                txtConfirmPassword.Text)
            {
                lblPasswordMatch.ForeColor =
                    Color.Green;

                lblPasswordMatch.Text =
                    "✓ Passwords Match";
            }
            else
            {
                lblPasswordMatch.ForeColor =
                    Color.Red;

                lblPasswordMatch.Text =
                    "✗ Passwords Do Not Match";
            }
        }
        

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            
            bool UserIDFound = false;

            string LineRec = "";

            string[] UserDetails = new string[9];

            if (File.Exists(FilePath))
            {
                StreamReader UserFile =
                    new StreamReader(FilePath);

                using (UserFile)
                {
                    LineRec = UserFile.ReadLine();

                    while (LineRec != null)
                    {
                        UserDetails = LineRec.Split('\t');

                        if (UserDetails.Length > 0)
                        {
                            if (txtUserID.Text == UserDetails[0])
                            {
                                UserIDFound = true;

                                EmailAddress = UserDetails[3];
                            }
                        }

                        LineRec = UserFile.ReadLine();
                    }
                }
            }

            if (txtUserID.Text == "")
            {
                lblUserIDStatus.Text = "";
            }
            else if (UserIDFound == true)
            {
                lblUserIDStatus.Text = "";
            }
            else
            {
                lblUserIDStatus.ForeColor = Color.Red;
                lblUserIDStatus.Text =
                    "✗ User ID Not Found";
            }
        }

        private void lblPasswordStrength_Click(object sender, EventArgs e)
        {
           
            if (txtNewPassword.Text.Length < 6)
            {
                lblPasswordStrength.ForeColor = Color.Red;
                lblPasswordStrength.Text = "Weak";
            }
            else if (txtNewPassword.Text.Length < 8)
            {
                lblPasswordStrength.ForeColor = Color.Orange;
                lblPasswordStrength.Text = "Medium";
            }
            else
            {
                lblPasswordStrength.ForeColor = Color.Green;
                lblPasswordStrength.Text = "Strong";
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkShowPassword.Checked)
            {
                txtNewPassword.UseSystemPasswordChar = false;

                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = true;

                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
           
            if (txtUserID.Text == "")
            {
                MessageBox.Show(
                    "Enter a User ID.");

                return;
            }

            Random RandomCode = new Random();

            VerificationCode =
                RandomCode.Next(100000, 999999).ToString();

            try
            {
                MailMessage message =
                    new MailMessage();

                message.From =
                    new MailAddress(
                        "oscorpsarms@gmail.com");

                message.To.Add(EmailAddress);

                message.Subject =
                    "Password Reset Verification Code";

                message.Body =
                    "Your verification code is: "
                    + VerificationCode;

                SmtpClient smtp =
                    new SmtpClient("smtp.gmail.com");

                smtp.Port = 587;

                smtp.Credentials =
                    new NetworkCredential(
                      "oscorpsarms@gmail.com",
                      "uhep mddb bvoy oiox");

                smtp.EnableSsl = true;

                smtp.Send(message);

                MessageBox.Show(
                    "Verification code sent successfully.");
            }
            catch
            {
                MessageBox.Show(
                    "Unable to send verification code.");
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (txtVerificationCode.Text != VerificationCode)
            {
                MessageBox.Show(
                    "Invalid verification code.");

                return;
            }

            if (txtNewPassword.Text !=
                txtConfirmPassword.Text)
            {
                MessageBox.Show(
                    "Passwords do not match.");

                return;
            }

            if (lblPasswordStrength.Text == "Weak")
            {
                MessageBox.Show(
                    "Please choose a stronger password.");

                return;
            }

            string LineRec = "";

            string NewRecord = "";

            string[] UserDetails = new string[9];

            StreamReader UserFileR = new StreamReader(FilePath);

            StreamWriter TempFile = new StreamWriter("TempUsers.txt");

            using (UserFileR)
            using (TempFile)
            {
                LineRec = UserFileR.ReadLine();

                while (LineRec != null)
                {
                    UserDetails = LineRec.Split('\t');

                    if (UserDetails.Length > 8)
                    {
                        if (txtUserID.Text ==
                            UserDetails[0])
                        {
                            UserDetails[6] =
                                txtNewPassword.Text;

                            NewRecord =
                                UserDetails[0] + "\t" +
                                UserDetails[1] + "\t" +
                                UserDetails[2] + "\t" +
                                UserDetails[3] + "\t" +
                                UserDetails[4] + "\t" +
                                UserDetails[5] + "\t" +
                                UserDetails[6] + "\t" +
                                UserDetails[7] + "\t" +
                                UserDetails[8];

                            TempFile.WriteLine(
                                NewRecord);
                        }
                        else
                        {
                            TempFile.WriteLine(
                                LineRec);
                        }
                    }

                    LineRec = UserFileR.ReadLine();
                }
            }

            File.Delete(FilePath);

            File.Move(
                "TempUsers.txt",
                FilePath);

            MessageBox.Show(
                "Password updated successfully.");

            frmLogin Login =
                new frmLogin();

            Login.Show();

            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
    
}
    
    

