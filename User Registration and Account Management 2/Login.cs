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

namespace User_Registration_and_Account_Management_2
{
    public partial class frmLogin : Form
    {
        string FilePath = @"C:\Users\bongu\Desktop\Users.txt";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "" ||txtPassword.Text == "")
            {
                MessageBox.Show(
                    "Please enter your User ID and Password.");

                return;
            }
            bool LoginSuccessful = false;

            string Role = "";

            string FullName = "";

            string LineRec = "";

            string[] UserDetails = new string[9];

            if (File.Exists(FilePath) == false)
            {
                MessageBox.Show("No registered users were found.");

                return;
            }

          
            StreamReader UserFile = new StreamReader(FilePath);

            using (UserFile)
            {
                LineRec = UserFile.ReadLine();

                while (LineRec != null)
                {
                    UserDetails = LineRec.Split('\t');

                    if (UserDetails.Length > 8)
                    {
                        if (txtUserID.Text == UserDetails[0] && txtPassword.Text == UserDetails[6])
                        {
                            LoginSuccessful = true;

                            FullName = UserDetails[1] + " " +UserDetails[2];

                            Role = UserDetails[7];

                            break;
                        }
                    }

                    LineRec = UserFile.ReadLine();
                }
            }
            if (LoginSuccessful == true)
            {
                MessageBox.Show(
                    "Login Successful");

                if (Role == "Student")
                {
                    frmStudentDashboard Student = new frmStudentDashboard();

                    Student.Show();

                    this.Hide();
                }
                else if (Role == "Lecturer")
                {
                    frmLecturerDashboard Lecturer = new frmLecturerDashboard();

                    Lecturer.Show();

                    this.Hide();
                }
                else if (Role == "Administrator")
                {
                    frmAdminDashboard Admin = new frmAdminDashboard();

                    Admin.Show();

                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show(
                    "Invalid User ID or Password.");

                txtUserID.Focus();
            }
        }

        private void lnkRegisterhere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmRegistrstion Register = new frmRegistrstion();

            Register.Show();

            this.Hide();
        
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
           
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
            txtUserID.Clear();

            txtPassword.Clear();

            txtUserID.Focus();
        }

        private void lblUserIDStatus_Click(object sender, EventArgs e)
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

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
