namespace User_Registration_and_Account_Management_2
{
    partial class ForgotPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtVerificationCode = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblEnterUserID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblEmailSentTo = new System.Windows.Forms.Label();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.lblUserIDStatus = new System.Windows.Forms.Label();
            this.lblPasswordStrength = new System.Windows.Forms.Label();
            this.lblPasswordMatch = new System.Windows.Forms.Label();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(447, 85);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(213, 26);
            this.txtUserID.TabIndex = 0;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            // 
            // txtVerificationCode
            // 
            this.txtVerificationCode.Location = new System.Drawing.Point(447, 158);
            this.txtVerificationCode.Name = "txtVerificationCode";
            this.txtVerificationCode.Size = new System.Drawing.Size(213, 26);
            this.txtVerificationCode.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(447, 222);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(213, 26);
            this.txtNewPassword.TabIndex = 2;
            // 
            // lblEnterUserID
            // 
            this.lblEnterUserID.AutoSize = true;
            this.lblEnterUserID.Location = new System.Drawing.Point(87, 105);
            this.lblEnterUserID.Name = "lblEnterUserID";
            this.lblEnterUserID.Size = new System.Drawing.Size(119, 20);
            this.lblEnterUserID.TabIndex = 3;
            this.lblEnterUserID.Text = "Enter User ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Verification code :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "New Password : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Password : ";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(447, 283);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(213, 26);
            this.txtConfirmPassword.TabIndex = 7;
            // 
            // lblEmailSentTo
            // 
            this.lblEmailSentTo.AutoSize = true;
            this.lblEmailSentTo.Location = new System.Drawing.Point(141, 28);
            this.lblEmailSentTo.Name = "lblEmailSentTo";
            this.lblEmailSentTo.Size = new System.Drawing.Size(452, 20);
            this.lblEmailSentTo.TabIndex = 8;
            this.lblEmailSentTo.Text = "A verification code will be sent to your registered email address.";
            // 
            // btnSendCode
            // 
            this.btnSendCode.Location = new System.Drawing.Point(137, 385);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(126, 66);
            this.btnSendCode.TabIndex = 9;
            this.btnSendCode.Text = "Send code";
            this.btnSendCode.UseVisualStyleBackColor = true;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(309, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 66);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(137, 457);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(307, 84);
            this.btnResetPassword.TabIndex = 11;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // lblUserIDStatus
            // 
            this.lblUserIDStatus.AutoSize = true;
            this.lblUserIDStatus.Location = new System.Drawing.Point(463, 124);
            this.lblUserIDStatus.Name = "lblUserIDStatus";
            this.lblUserIDStatus.Size = new System.Drawing.Size(115, 20);
            this.lblUserIDStatus.TabIndex = 12;
            this.lblUserIDStatus.Text = "User ID Status";
            this.lblUserIDStatus.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblPasswordStrength
            // 
            this.lblPasswordStrength.AutoSize = true;
            this.lblPasswordStrength.Location = new System.Drawing.Point(463, 255);
            this.lblPasswordStrength.Name = "lblPasswordStrength";
            this.lblPasswordStrength.Size = new System.Drawing.Size(144, 20);
            this.lblPasswordStrength.TabIndex = 13;
            this.lblPasswordStrength.Text = "Password Strength";
            this.lblPasswordStrength.Click += new System.EventHandler(this.lblPasswordStrength_Click);
            // 
            // lblPasswordMatch
            // 
            this.lblPasswordMatch.AutoSize = true;
            this.lblPasswordMatch.Location = new System.Drawing.Point(467, 316);
            this.lblPasswordMatch.Name = "lblPasswordMatch";
            this.lblPasswordMatch.Size = new System.Drawing.Size(126, 20);
            this.lblPasswordMatch.TabIndex = 14;
            this.lblPasswordMatch.Text = "Password Match";
            this.lblPasswordMatch.Click += new System.EventHandler(this.lblPasswordMatch_Click);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(667, 255);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(148, 24);
            this.chkShowPassword.TabIndex = 15;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 553);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.lblPasswordMatch);
            this.Controls.Add(this.lblPasswordStrength);
            this.Controls.Add(this.lblUserIDStatus);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.lblEmailSentTo);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEnterUserID);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtVerificationCode);
            this.Controls.Add(this.txtUserID);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtVerificationCode;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblEnterUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblEmailSentTo;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Label lblUserIDStatus;
        private System.Windows.Forms.Label lblPasswordStrength;
        private System.Windows.Forms.Label lblPasswordMatch;
        private System.Windows.Forms.CheckBox chkShowPassword;
    }
}