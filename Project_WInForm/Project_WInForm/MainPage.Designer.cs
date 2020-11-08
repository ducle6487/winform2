namespace Project_WInForm
{
    partial class MainPage
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
            this.pnlToolBox = new System.Windows.Forms.Panel();
            this.pnlToolRight = new System.Windows.Forms.Panel();
            this.pnlToolLeft = new System.Windows.Forms.Panel();
            this.btInfo = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbTittle = new System.Windows.Forms.Label();
            this.fpnlProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlToolBox.SuspendLayout();
            this.pnlToolLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolBox
            // 
            this.pnlToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlToolBox.Controls.Add(this.pnlToolRight);
            this.pnlToolBox.Controls.Add(this.pnlToolLeft);
            this.pnlToolBox.Controls.Add(this.lbTittle);
            this.pnlToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBox.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBox.Name = "pnlToolBox";
            this.pnlToolBox.Size = new System.Drawing.Size(1478, 121);
            this.pnlToolBox.TabIndex = 0;
            // 
            // pnlToolRight
            // 
            this.pnlToolRight.Location = new System.Drawing.Point(892, 12);
            this.pnlToolRight.Name = "pnlToolRight";
            this.pnlToolRight.Size = new System.Drawing.Size(574, 100);
            this.pnlToolRight.TabIndex = 1;
            this.pnlToolRight.Resize += new System.EventHandler(this.pnlToolRight_Resize);
            // 
            // pnlToolLeft
            // 
            this.pnlToolLeft.Controls.Add(this.btInfo);
            this.pnlToolLeft.Controls.Add(this.lbInfo);
            this.pnlToolLeft.Location = new System.Drawing.Point(29, 12);
            this.pnlToolLeft.Name = "pnlToolLeft";
            this.pnlToolLeft.Size = new System.Drawing.Size(574, 100);
            this.pnlToolLeft.TabIndex = 1;
            this.pnlToolLeft.Resize += new System.EventHandler(this.pnlToolLeft_Resize);
            // 
            // btInfo
            // 
            this.btInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btInfo.ForeColor = System.Drawing.Color.Lime;
            this.btInfo.Location = new System.Drawing.Point(189, 54);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(152, 33);
            this.btInfo.TabIndex = 1;
            this.btInfo.Text = "Đổi thông tin";
            this.btInfo.UseVisualStyleBackColor = false;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.ForeColor = System.Drawing.Color.White;
            this.lbInfo.Location = new System.Drawing.Point(272, 16);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(51, 20);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "label1";
            // 
            // lbTittle
            // 
            this.lbTittle.Font = new System.Drawing.Font("Candara", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.ForeColor = System.Drawing.Color.White;
            this.lbTittle.Location = new System.Drawing.Point(546, 3);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(487, 121);
            this.lbTittle.TabIndex = 0;
            this.lbTittle.Text = "CỬA HÀNG";
            this.lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fpnlProduct
            // 
            this.fpnlProduct.AutoScroll = true;
            this.fpnlProduct.BackColor = System.Drawing.Color.White;
            this.fpnlProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fpnlProduct.Location = new System.Drawing.Point(0, 127);
            this.fpnlProduct.Name = "fpnlProduct";
            this.fpnlProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fpnlProduct.Size = new System.Drawing.Size(1478, 1317);
            this.fpnlProduct.TabIndex = 1;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1478, 1444);
            this.Controls.Add(this.fpnlProduct);
            this.Controls.Add(this.pnlToolBox);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.Resize += new System.EventHandler(this.MainPage_Resize);
            this.pnlToolBox.ResumeLayout(false);
            this.pnlToolLeft.ResumeLayout(false);
            this.pnlToolLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlToolBox;
        private System.Windows.Forms.FlowLayoutPanel fpnlProduct;
        private System.Windows.Forms.Panel pnlToolRight;
        private System.Windows.Forms.Panel pnlToolLeft;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.Button btInfo;
        private System.Windows.Forms.Label lbInfo;
    }
}