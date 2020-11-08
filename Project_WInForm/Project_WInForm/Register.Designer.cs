namespace Project_WInForm
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.pnRegister = new System.Windows.Forms.Panel();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnRegisterNow = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnRegister
            // 
            this.pnRegister.BackColor = System.Drawing.Color.White;
            this.pnRegister.Controls.Add(this.cbGender);
            this.pnRegister.Controls.Add(this.btnRegisterNow);
            this.pnRegister.Controls.Add(this.txtPhoneNumber);
            this.pnRegister.Controls.Add(this.txtAddress);
            this.pnRegister.Controls.Add(this.txtAge);
            this.pnRegister.Controls.Add(this.txtPassword);
            this.pnRegister.Controls.Add(this.txtUser);
            this.pnRegister.Controls.Add(this.txtFullName);
            this.pnRegister.Controls.Add(this.lbPhoneNumber);
            this.pnRegister.Controls.Add(this.lbAddress);
            this.pnRegister.Controls.Add(this.lbGender);
            this.pnRegister.Controls.Add(this.lbAge);
            this.pnRegister.Controls.Add(this.lbPassword);
            this.pnRegister.Controls.Add(this.lbUser);
            this.pnRegister.Controls.Add(this.lbFullName);
            this.pnRegister.Location = new System.Drawing.Point(306, 243);
            this.pnRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnRegister.Name = "pnRegister";
            this.pnRegister.Size = new System.Drawing.Size(765, 635);
            this.pnRegister.TabIndex = 0;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(279, 278);
            this.cbGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(251, 28);
            this.cbGender.TabIndex = 15;
            // 
            // btnRegisterNow
            // 
            this.btnRegisterNow.Location = new System.Drawing.Point(238, 505);
            this.btnRegisterNow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegisterNow.Name = "btnRegisterNow";
            this.btnRegisterNow.Size = new System.Drawing.Size(273, 90);
            this.btnRegisterNow.TabIndex = 14;
            this.btnRegisterNow.Text = "Register now";
            this.btnRegisterNow.UseVisualStyleBackColor = true;
            this.btnRegisterNow.Click += new System.EventHandler(this.btnRegisterNow_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(279, 389);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(420, 26);
            this.txtPhoneNumber.TabIndex = 13;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(279, 335);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(420, 26);
            this.txtAddress.TabIndex = 12;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(279, 221);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(211, 26);
            this.txtAge.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(279, 170);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(420, 26);
            this.txtPassword.TabIndex = 9;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(279, 107);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(420, 26);
            this.txtUser.TabIndex = 8;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(279, 55);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(420, 26);
            this.txtFullName.TabIndex = 7;
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPhoneNumber.Location = new System.Drawing.Point(69, 388);
            this.lbPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(132, 20);
            this.lbPhoneNumber.TabIndex = 6;
            this.lbPhoneNumber.Text = "Phone Number";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.BackColor = System.Drawing.Color.Transparent;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAddress.Location = new System.Drawing.Point(69, 335);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(78, 20);
            this.lbAddress.TabIndex = 5;
            this.lbAddress.Text = "Address";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.BackColor = System.Drawing.Color.Transparent;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbGender.Location = new System.Drawing.Point(69, 278);
            this.lbGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(70, 20);
            this.lbGender.TabIndex = 4;
            this.lbGender.Text = "Gender";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.BackColor = System.Drawing.Color.Transparent;
            this.lbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAge.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAge.Location = new System.Drawing.Point(69, 221);
            this.lbAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(41, 20);
            this.lbAge.TabIndex = 3;
            this.lbAge.Text = "Age";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPassword.Location = new System.Drawing.Point(69, 170);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(91, 20);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbUser.Location = new System.Drawing.Point(69, 107);
            this.lbUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(49, 20);
            this.lbUser.TabIndex = 1;
            this.lbUser.Text = "User";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.BackColor = System.Drawing.Color.Transparent;
            this.lbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbFullName.Location = new System.Drawing.Point(69, 55);
            this.lbFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(94, 20);
            this.lbFullName.TabIndex = 0;
            this.lbFullName.Text = "Full Name";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTitle.Location = new System.Drawing.Point(405, 119);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(611, 60);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "CREATER YOUR ACCOUNT";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1361, 1048);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Register";
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.Load += new System.EventHandler(this.Register_Load);
            this.Resize += new System.EventHandler(this.Register_Resize);
            this.pnRegister.ResumeLayout(false);
            this.pnRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnRegister;
        private System.Windows.Forms.Button btnRegisterNow;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ComboBox cbGender;
    }
}