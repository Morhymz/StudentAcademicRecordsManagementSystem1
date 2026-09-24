using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace User_Registration_and_Account_Management_2
{
    public partial class frmRegistrstion : Form
    {
        string FilePath = @"C:\Users\bongu\Desktop\Users.txt";
        public frmRegistrstion()
        {
            InitializeComponent();
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
           
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                lblPasswordMatch.ForeColor = Color.Green;
                lblPasswordMatch.Text = "✓ Passwords Match";
            }
            else
            {
                lblPasswordMatch.ForeColor = Color.Red;
                lblPasswordMatch.Text = "✗ Passwords Do Not Match";
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string FilePath = @"C:\Users\bongu\Desktop\Users.txt";

            string LineRec = "";

            string[] UserDetails = new string[9];

            bool UsernameTaken = false;

            if (File.Exists(FilePath) == false)
            {
                StreamWriter UserFileW = new StreamWriter(FilePath);
                

                using (UserFileW)
                {

                }
            }
            if (txtName.Text == "" ||txtSurname.Text == "" ||txtEmail.Text == "" ||txtPhoneNumber.Text == "" ||txtUsername.Text == "" ||txtPassword.Text == "" ||txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please complete all required fields.","Missing Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password do not Match.");
                return;
            }

            if(lblEmailValidation.Text.Contains("Invalid"))
            {
                MessageBox.Show("Please enter a valid email.");
                return;
            }

            if(lblPhoneValidation.Text.Contains("Invalid"))
            {
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }

            UsernameTaken = false;

            LineRec = "";
            UserDetails = new string[10];

            if (File.Exists(FilePath))
            {    

                StreamReader UserFileR = new StreamReader(FilePath);

                using (UserFileR)
                {
                    LineRec = UserFileR.ReadLine();

                    while (LineRec != null)
                    {
                        UserDetails = LineRec.Split('\t');

                        if (UserDetails.Length > 5)
                        {
                            if (txtUsername.Text == UserDetails[5])
                            {
                                UsernameTaken = true;
                            }
                        }

                        LineRec = UserFileR.ReadLine();
                    }
                }
            }

            if (UsernameTaken == true)
            {
                MessageBox.Show("Username already exists.");

                txtUsername.Focus();

                return;
            }

            string UserID = "";
            int Count = 1;

            LineRec = "";

            if (File.Exists(FilePath))
            {
                StreamReader UserFileR = new StreamReader(FilePath);

                using (UserFileR)
                {
                    LineRec = UserFileR.ReadLine();

                    while (LineRec != null)
                    {
                        Count++;

                        LineRec = UserFileR.ReadLine();
                    }
                }
            }

            if (cmbRole.Text == "Student")
            {
                UserID = "STU" + Count.ToString("000");
            }
            else if (cmbRole.Text == "Lecturer")
            {
                UserID = "LEC" + Count.ToString("000");
            }

            StreamWriter UserFile =new StreamWriter(FilePath, true);

            using (UserFile)
            {
                UserFile.WriteLine( UserID + "\t" + txtName.Text + "\t" +txtSurname.Text + "\t" +txtEmail.Text + "\t" +txtPhoneNumber.Text + "\t" +txtUsername.Text + "\t" +txtPassword.Text + "\t" +cmbRole.Text+"\t"+ DateTime.Now.ToShortDateString());
            }

            try
            {
                MailMessage message = new MailMessage();

                message.From =
                    new MailAddress("oscorpsarms@gmail.com");

                message.To.Add(txtEmail.Text);

                message.Subject =
                    "Registration Successful";

                message.Body =
                    "Welcome to OSCORP Student Academic Records Management System" +
                    "\n\nYour User ID is: " + UserID +
                    "\nUsername: " + txtUsername.Text +
                    "\nRole: " + cmbRole.Text;

                SmtpClient smtp =
                    new SmtpClient("smtp.gmail.com");

                smtp.Port = 587;

                smtp.Credentials =
                    new NetworkCredential(
                        "oscorpsarms@gmail.com",
                        "uhep mddb bvoy oiox");

                smtp.EnableSsl = true;

                smtp.Send(message);

                txtName.Clear();
                txtSurname.Clear();
                txtEmail.Clear();
                txtPhoneNumber.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                txtConfirmPassword.Clear();

                cmbRole.SelectedIndex = -1;

                lblEmailValidation.Text = "";
                lblPhoneValidation.Text = "";
                lblUsernameStatus.Text = "";
                lblPasswordStrength.Text = "";
                lblPasswordMatch.Text = "";

                MessageBox.Show(
                    "Registration Successful. User ID has been sent to your email.");
            }
            catch
            {
                MessageBox.Show(
                    "Registration successful, but email could not be sent.");
            }
        }

        private void txtEmailAddress_TextChanged(object sender, EventArgs e)
        {
           
            if (txtEmail.Text.Contains("@") &&
                txtEmail.Text.Contains("."))
            {
                lblEmailValidation.ForeColor = Color.Green;
                lblEmailValidation.Text = "✓ Valid Email Address";
            }
            else
            {
                lblEmailValidation.ForeColor = Color.Red;
                lblEmailValidation.Text = "✗ Invalid Email Address";
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
           
            long phoneNumber;

            if (long.TryParse(txtPhoneNumber.Text, out phoneNumber)
                && txtPhoneNumber.Text.Length == 10)
            {
                lblPhoneValidation.ForeColor = Color.Green;
                lblPhoneValidation.Text = "✓ Valid Phone Number";
            }
            else
            {
                lblPhoneValidation.ForeColor = Color.Red;
                lblPhoneValidation.Text = "✗ Phone Number Must Contain 10 Digits";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
            if (txtPassword.Text.Length < 6)
            {
                lblPasswordStrength.ForeColor = Color.Red;
                lblPasswordStrength.Text = "Weak";
            }
            else if (txtPassword.Text.Length < 8)
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
                txtPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
            bool UsernameTaken = false;

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

                        if (UserDetails.Length > 5)
                        {
                            if (txtUsername.Text == UserDetails[5])
                            {
                                UsernameTaken = true;
                            }
                        }

                        LineRec = UserFile.ReadLine();
                    }
                }
            }

            if (UsernameTaken == true)
            {
                lblUsernameStatus.ForeColor = Color.Red;
                lblUsernameStatus.Text = "Username Already Exists";
            }
            else
            {
                lblUsernameStatus.ForeColor = Color.Green;
                lblUsernameStatus.Text = "Username Available";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            DialogResult Choice;

            Choice = MessageBox.Show( 
                "Do you want to clear all entered information?",
                "Clear Form",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (Choice == DialogResult.Yes)
            {
                txtName.Clear();
                txtSurname.Clear();
                txtEmail.Clear();
                txtPhoneNumber.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                txtConfirmPassword.Clear();

                cmbRole.SelectedIndex = -1;

                lblEmailValidation.Text = "";
                lblPhoneValidation.Text = "";
                lblUsernameStatus.Text = ""; 
                lblPasswordStrength.Text = "";
                lblPasswordMatch.Text = "";

                txtName.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void lblExistanceUsername_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void lblPasswordMatch_Click(object sender, EventArgs e)
        {

        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
    
    
    
}
