namespace Project_WInForm
{
    partial class InfoUser
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
            this.btHistory = new System.Windows.Forms.Button();
            this.btChangeInfo = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlToolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolbox
            // 
            this.pnlToolbox.Controls.Add(this.btHistory);
            this.pnlToolbox.Controls.Add(this.btChangeInfo);
            this.pnlToolbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbox.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbox.Name = "pnlToolbox";
            this.pnlToolbox.Size = new System.Drawing.Size(1478, 136);
            this.pnlToolbox.TabIndex = 0;
            this.pnlToolbox.Resize += new System.EventHandler(this.pnlToolbox_Resize);
            // 
            // btHistory
            // 
            this.btHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btHistory.Location = new System.Drawing.Point(1363, 0);
            this.btHistory.Name = "btHistory";
            this.btHistory.Size = new System.Drawing.Size(115, 136);
            this.btHistory.TabIndex = 1;
            this.btHistory.Text = "Lịch sử giao dịch";
            this.btHistory.UseVisualStyleBackColor = true;
            this.btHistory.Click += new System.EventHandler(this.btHistory_Click);
            // 
            // btChangeInfo
            // 
            this.btChangeInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btChangeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChangeInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btChangeInfo.Location = new System.Drawing.Point(0, 0);
            this.btChangeInfo.Name = "btChangeInfo";
            this.btChangeInfo.Size = new System.Drawing.Size(115, 136);
            this.btChangeInfo.TabIndex = 0;
            this.btChangeInfo.Text = "Đổi thông tin";
            this.btChangeInfo.UseVisualStyleBackColor = true;
            this.btChangeInfo.Click += new System.EventHandler(this.btChangeInfo_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 136);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1478, 954);
            this.pnlMain.TabIndex = 1;
            // 
            // InfoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 1444);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlToolbox);
            this.Name = "InfoUser";
            this.Text = "ChangeInfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InfoUser_FormClosed);
            this.Load += new System.EventHandler(this.InfoUser_Load);
            this.Resize += new System.EventHandler(this.InfoUser_Resize);
            this.pnlToolbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolbox;
        private System.Windows.Forms.Button btHistory;
        private System.Windows.Forms.Button btChangeInfo;
        private System.Windows.Forms.Panel pnlMain;
    }
}