namespace Project_WInForm
{
    partial class AccountInfoForAdmin
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
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.cbxFilter = new System.Windows.Forms.ComboBox();
            this.txtDataFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btFilter = new System.Windows.Forms.Button();
            this.btShowAll = new System.Windows.Forms.Button();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.dgvAccount);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(546, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(931, 900);
            this.pnlRight.TabIndex = 1;
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccount.Location = new System.Drawing.Point(0, 0);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 62;
            this.dgvAccount.RowTemplate.Height = 28;
            this.dgvAccount.Size = new System.Drawing.Size(931, 900);
            this.dgvAccount.TabIndex = 0;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.btShowAll);
            this.pnlInfo.Controls.Add(this.btFilter);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.txtDataFilter);
            this.pnlInfo.Controls.Add(this.cbxFilter);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Controls.Add(this.txtID);
            this.pnlInfo.Controls.Add(this.txtGender);
            this.pnlInfo.Controls.Add(this.txtPhoneNumber);
            this.pnlInfo.Controls.Add(this.txtAddress);
            this.pnlInfo.Controls.Add(this.txtAge);
            this.pnlInfo.Controls.Add(this.txtFullName);
            this.pnlInfo.Controls.Add(this.lbPhoneNumber);
            this.pnlInfo.Controls.Add(this.lbAddress);
            this.pnlInfo.Controls.Add(this.lbGender);
            this.pnlInfo.Controls.Add(this.lbAge);
            this.pnlInfo.Controls.Add(this.lbFullName);
            this.pnlInfo.Location = new System.Drawing.Point(30, 12);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(466, 885);
            this.pnlInfo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(188, 53);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(275, 30);
            this.txtID.TabIndex = 91;
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.White;
            this.txtGender.Enabled = false;
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(188, 282);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 30);
            this.txtGender.TabIndex = 90;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.White;
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNumber.Location = new System.Drawing.Point(188, 437);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(274, 30);
            this.txtPhoneNumber.TabIndex = 89;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(188, 361);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(274, 30);
            this.txtAddress.TabIndex = 88;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.White;
            this.txtAge.Enabled = false;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.Black;
            this.txtAge.Location = new System.Drawing.Point(188, 207);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 30);
            this.txtAge.TabIndex = 87;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.White;
            this.txtFullName.Enabled = false;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.Black;
            this.txtFullName.Location = new System.Drawing.Point(188, 130);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(274, 30);
            this.txtFullName.TabIndex = 84;
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.lbPhoneNumber.Location = new System.Drawing.Point(21, 439);
            this.lbPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(143, 25);
            this.lbPhoneNumber.TabIndex = 83;
            this.lbPhoneNumber.Text = "Phone Number";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.BackColor = System.Drawing.Color.Transparent;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.ForeColor = System.Drawing.Color.Black;
            this.lbAddress.Location = new System.Drawing.Point(21, 364);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(85, 25);
            this.lbAddress.TabIndex = 82;
            this.lbAddress.Text = "Address";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.BackColor = System.Drawing.Color.Transparent;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.ForeColor = System.Drawing.Color.Black;
            this.lbGender.Location = new System.Drawing.Point(21, 287);
            this.lbGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(77, 25);
            this.lbGender.TabIndex = 81;
            this.lbGender.Text = "Gender";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.BackColor = System.Drawing.Color.Transparent;
            this.lbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAge.ForeColor = System.Drawing.Color.Black;
            this.lbAge.Location = new System.Drawing.Point(21, 210);
            this.lbAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(48, 25);
            this.lbAge.TabIndex = 80;
            this.lbAge.Text = "Age";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.BackColor = System.Drawing.Color.Transparent;
            this.lbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullName.ForeColor = System.Drawing.Color.Black;
            this.lbFullName.Location = new System.Drawing.Point(21, 133);
            this.lbFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(100, 25);
            this.lbFullName.TabIndex = 77;
            this.lbFullName.Text = "Full Name";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnlInfo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(540, 900);
            this.pnlLeft.TabIndex = 0;
            // 
            // cbxFilter
            // 
            this.cbxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilter.FormattingEnabled = true;
            this.cbxFilter.Location = new System.Drawing.Point(188, 686);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(251, 33);
            this.cbxFilter.TabIndex = 92;
            // 
            // txtDataFilter
            // 
            this.txtDataFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFilter.Location = new System.Drawing.Point(188, 622);
            this.txtDataFilter.Name = "txtDataFilter";
            this.txtDataFilter.Size = new System.Drawing.Size(251, 30);
            this.txtDataFilter.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 625);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 94;
            this.label2.Text = "Dữ liệu lọc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 689);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 94;
            this.label3.Text = "Lọc theo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 95;
            this.label4.Text = "Lọc dữ liệu";
            // 
            // btFilter
            // 
            this.btFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFilter.Location = new System.Drawing.Point(62, 785);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(136, 64);
            this.btFilter.TabIndex = 96;
            this.btFilter.Text = "Lọc";
            this.btFilter.UseVisualStyleBackColor = true;
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // btShowAll
            // 
            this.btShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowAll.Location = new System.Drawing.Point(271, 785);
            this.btShowAll.Name = "btShowAll";
            this.btShowAll.Size = new System.Drawing.Size(136, 64);
            this.btShowAll.TabIndex = 96;
            this.btShowAll.Text = "Hiện tất cả";
            this.btShowAll.UseVisualStyleBackColor = true;
            this.btShowAll.Click += new System.EventHandler(this.btShowAll_Click);
            // 
            // AccountInfoForAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 900);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountInfoForAdmin";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.Resize += new System.EventHandler(this.Account_Resize_1);
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cbxFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataFilter;
        private System.Windows.Forms.Button btShowAll;
        private System.Windows.Forms.Button btFilter;
    }
}