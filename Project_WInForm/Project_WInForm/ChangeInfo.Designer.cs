namespace Project_WInForm
{
    partial class ChangeInfo
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
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lbTitleInfo = new System.Windows.Forms.Label();
            this.pnlPass = new System.Windows.Forms.Panel();
            this.btPass = new System.Windows.Forms.Button();
            this.txtmk3 = new System.Windows.Forms.TextBox();
            this.txtmk2 = new System.Windows.Forms.TextBox();
            this.txtmk1 = new System.Windows.Forms.TextBox();
            this.lbmk3 = new System.Windows.Forms.Label();
            this.lbmk2 = new System.Windows.Forms.Label();
            this.lbmk1 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbTitlePass = new System.Windows.Forms.Label();
            this.btInfo = new System.Windows.Forms.Button();
            this.pnlInfo.SuspendLayout();
            this.pnlPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlInfo.Controls.Add(this.btInfo);
            this.pnlInfo.Controls.Add(this.cbGender);
            this.pnlInfo.Controls.Add(this.txtPhoneNumber);
            this.pnlInfo.Controls.Add(this.txtAddress);
            this.pnlInfo.Controls.Add(this.txtAge);
            this.pnlInfo.Controls.Add(this.txtFullName);
            this.pnlInfo.Controls.Add(this.lbPhoneNumber);
            this.pnlInfo.Controls.Add(this.lbAddress);
            this.pnlInfo.Controls.Add(this.lbGender);
            this.pnlInfo.Controls.Add(this.lbAge);
            this.pnlInfo.Controls.Add(this.lbFullName);
            this.pnlInfo.Controls.Add(this.lbTitleInfo);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(780, 858);
            this.pnlInfo.TabIndex = 0;
            // 
            // lbTitleInfo
            // 
            this.lbTitleInfo.AutoSize = true;
            this.lbTitleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleInfo.Location = new System.Drawing.Point(303, 89);
            this.lbTitleInfo.Name = "lbTitleInfo";
            this.lbTitleInfo.Size = new System.Drawing.Size(180, 29);
            this.lbTitleInfo.TabIndex = 0;
            this.lbTitleInfo.Text = "Đổi Thông Tin";
            // 
            // pnlPass
            // 
            this.pnlPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlPass.Controls.Add(this.btPass);
            this.pnlPass.Controls.Add(this.txtmk3);
            this.pnlPass.Controls.Add(this.txtmk2);
            this.pnlPass.Controls.Add(this.txtmk1);
            this.pnlPass.Controls.Add(this.lbmk3);
            this.pnlPass.Controls.Add(this.lbmk2);
            this.pnlPass.Controls.Add(this.lbmk1);
            this.pnlPass.Controls.Add(this.lbTitlePass);
            this.pnlPass.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPass.Location = new System.Drawing.Point(782, 0);
            this.pnlPass.Name = "pnlPass";
            this.pnlPass.Size = new System.Drawing.Size(760, 858);
            this.pnlPass.TabIndex = 1;
            // 
            // btPass
            // 
            this.btPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPass.ForeColor = System.Drawing.Color.White;
            this.btPass.Location = new System.Drawing.Point(255, 588);
            this.btPass.Name = "btPass";
            this.btPass.Size = new System.Drawing.Size(266, 88);
            this.btPass.TabIndex = 2;
            this.btPass.Text = "Đổi mật khẩu";
            this.btPass.UseVisualStyleBackColor = false;
            this.btPass.Click += new System.EventHandler(this.btPass_Click);
            // 
            // txtmk3
            // 
            this.txtmk3.Location = new System.Drawing.Point(343, 352);
            this.txtmk3.Name = "txtmk3";
            this.txtmk3.Size = new System.Drawing.Size(315, 26);
            this.txtmk3.TabIndex = 1;
            // 
            // txtmk2
            // 
            this.txtmk2.Location = new System.Drawing.Point(343, 299);
            this.txtmk2.Name = "txtmk2";
            this.txtmk2.Size = new System.Drawing.Size(315, 26);
            this.txtmk2.TabIndex = 1;
            // 
            // txtmk1
            // 
            this.txtmk1.Location = new System.Drawing.Point(343, 246);
            this.txtmk1.Name = "txtmk1";
            this.txtmk1.Size = new System.Drawing.Size(315, 26);
            this.txtmk1.TabIndex = 1;
            // 
            // lbmk3
            // 
            this.lbmk3.AutoSize = true;
            this.lbmk3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmk3.Location = new System.Drawing.Point(104, 351);
            this.lbmk3.Name = "lbmk3";
            this.lbmk3.Size = new System.Drawing.Size(204, 25);
            this.lbmk3.TabIndex = 0;
            this.lbmk3.Text = "Nhập lại mật khẩu mới";
            // 
            // lbmk2
            // 
            this.lbmk2.AutoSize = true;
            this.lbmk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmk2.Location = new System.Drawing.Point(104, 298);
            this.lbmk2.Name = "lbmk2";
            this.lbmk2.Size = new System.Drawing.Size(129, 25);
            this.lbmk2.TabIndex = 0;
            this.lbmk2.Text = "Mật khẩu mới";
            // 
            // lbmk1
            // 
            this.lbmk1.AutoSize = true;
            this.lbmk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmk1.Location = new System.Drawing.Point(104, 246);
            this.lbmk1.Name = "lbmk1";
            this.lbmk1.Size = new System.Drawing.Size(119, 25);
            this.lbmk1.TabIndex = 0;
            this.lbmk1.Text = "Mật khẩu cũ";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(333, 339);
            this.cbGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(90, 28);
            this.cbGender.TabIndex = 29;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(333, 449);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(259, 26);
            this.txtPhoneNumber.TabIndex = 28;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(333, 396);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(259, 26);
            this.txtAddress.TabIndex = 27;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(333, 282);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(50, 26);
            this.txtAge.TabIndex = 26;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(333, 228);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(259, 26);
            this.txtFullName.TabIndex = 23;
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.lbPhoneNumber.Location = new System.Drawing.Point(143, 448);
            this.lbPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(143, 25);
            this.lbPhoneNumber.TabIndex = 22;
            this.lbPhoneNumber.Text = "Phone Number";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.BackColor = System.Drawing.Color.Transparent;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.ForeColor = System.Drawing.Color.Black;
            this.lbAddress.Location = new System.Drawing.Point(143, 395);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(85, 25);
            this.lbAddress.TabIndex = 21;
            this.lbAddress.Text = "Address";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.BackColor = System.Drawing.Color.Transparent;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.ForeColor = System.Drawing.Color.Black;
            this.lbGender.Location = new System.Drawing.Point(143, 338);
            this.lbGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(77, 25);
            this.lbGender.TabIndex = 20;
            this.lbGender.Text = "Gender";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.BackColor = System.Drawing.Color.Transparent;
            this.lbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAge.ForeColor = System.Drawing.Color.Black;
            this.lbAge.Location = new System.Drawing.Point(143, 281);
            this.lbAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(48, 25);
            this.lbAge.TabIndex = 19;
            this.lbAge.Text = "Age";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.BackColor = System.Drawing.Color.Transparent;
            this.lbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullName.ForeColor = System.Drawing.Color.Black;
            this.lbFullName.Location = new System.Drawing.Point(143, 227);
            this.lbFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(100, 25);
            this.lbFullName.TabIndex = 16;
            this.lbFullName.Text = "Full Name";
            // 
            // lbTitlePass
            // 
            this.lbTitlePass.AutoSize = true;
            this.lbTitlePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitlePass.Location = new System.Drawing.Point(303, 89);
            this.lbTitlePass.Name = "lbTitlePass";
            this.lbTitlePass.Size = new System.Drawing.Size(168, 29);
            this.lbTitlePass.TabIndex = 0;
            this.lbTitlePass.Text = "Đổi Mật Khẩu";
            // 
            // btInfo
            // 
            this.btInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInfo.ForeColor = System.Drawing.Color.White;
            this.btInfo.Location = new System.Drawing.Point(259, 588);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(266, 88);
            this.btInfo.TabIndex = 2;
            this.btInfo.Text = "Đổi thông tin";
            this.btInfo.UseVisualStyleBackColor = false;
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // ChangeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 858);
            this.Controls.Add(this.pnlPass);
            this.Controls.Add(this.pnlInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeInfo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ChangeInfo_Load);
            this.Resize += new System.EventHandler(this.ChangeInfo_Resize);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlPass.ResumeLayout(false);
            this.pnlPass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlPass;
        private System.Windows.Forms.Button btPass;
        private System.Windows.Forms.TextBox txtmk3;
        private System.Windows.Forms.TextBox txtmk2;
        private System.Windows.Forms.TextBox txtmk1;
        private System.Windows.Forms.Label lbmk3;
        private System.Windows.Forms.Label lbmk2;
        private System.Windows.Forms.Label lbmk1;
        private System.Windows.Forms.Label lbTitleInfo;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbTitlePass;
        private System.Windows.Forms.Button btInfo;
    }
}