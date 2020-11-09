namespace Project_WInForm
{
    partial class Admin
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
            this.pnlToolbox = new System.Windows.Forms.Panel();
            this.btPayment = new System.Windows.Forms.Button();
            this.btAccount = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlToolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolbox
            // 
            this.pnlToolbox.Controls.Add(this.btPayment);
            this.pnlToolbox.Controls.Add(this.btAccount);
            this.pnlToolbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbox.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbox.Name = "pnlToolbox";
            this.pnlToolbox.Size = new System.Drawing.Size(1689, 143);
            this.pnlToolbox.TabIndex = 0;
            // 
            // btPayment
            // 
            this.btPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPayment.Location = new System.Drawing.Point(578, 0);
            this.btPayment.Name = "btPayment";
            this.btPayment.Size = new System.Drawing.Size(1111, 143);
            this.btPayment.TabIndex = 0;
            this.btPayment.Text = "Thông Tin Giao Dịch";
            this.btPayment.UseVisualStyleBackColor = true;
            this.btPayment.Click += new System.EventHandler(this.btPayment_Click);
            // 
            // btAccount
            // 
            this.btAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAccount.Location = new System.Drawing.Point(0, 0);
            this.btAccount.Name = "btAccount";
            this.btAccount.Size = new System.Drawing.Size(1110, 143);
            this.btAccount.TabIndex = 0;
            this.btAccount.Text = "Thông Tin Tài Khoản";
            this.btAccount.UseVisualStyleBackColor = true;
            this.btAccount.Click += new System.EventHandler(this.btAccount_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 143);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1689, 874);
            this.pnlMain.TabIndex = 1;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1689, 981);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlToolbox);
            this.MinimumSize = new System.Drawing.Size(1711, 1037);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.Resize += new System.EventHandler(this.Admin_Resize);
            this.pnlToolbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolbox;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btPayment;
        private System.Windows.Forms.Button btAccount;
    }
}