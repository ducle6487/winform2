namespace Project_WInForm
{
    partial class GioHang
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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btPay = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lbTittle = new System.Windows.Forms.Label();
            this.fpnlSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlBottom.Controls.Add(this.btPay);
            this.pnlBottom.Controls.Add(this.btBack);
            this.pnlBottom.Controls.Add(this.lbTotalPrice);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 979);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(894, 181);
            this.pnlBottom.TabIndex = 0;
            // 
            // btPay
            // 
            this.btPay.Location = new System.Drawing.Point(546, 76);
            this.btPay.Name = "btPay";
            this.btPay.Size = new System.Drawing.Size(243, 73);
            this.btPay.TabIndex = 1;
            this.btPay.Text = "Thanh toán";
            this.btPay.UseVisualStyleBackColor = true;
            this.btPay.Click += new System.EventHandler(this.btPay_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(113, 76);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(243, 73);
            this.btBack.TabIndex = 1;
            this.btBack.Text = "Tiếp tục mua";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lbTotalPrice.Location = new System.Drawing.Point(487, 3);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(220, 32);
            this.lbTotalPrice.TabIndex = 0;
            this.lbTotalPrice.Text = "Thành Tiền:  0 đ";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlTop.Controls.Add(this.lbTittle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(894, 103);
            this.pnlTop.TabIndex = 0;
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.Location = new System.Drawing.Point(410, 42);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(77, 20);
            this.lbTittle.TabIndex = 0;
            this.lbTittle.Text = "Giỏ Hàng";
            // 
            // fpnlSanPham
            // 
            this.fpnlSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlSanPham.Location = new System.Drawing.Point(0, 103);
            this.fpnlSanPham.Name = "fpnlSanPham";
            this.fpnlSanPham.Size = new System.Drawing.Size(894, 876);
            this.fpnlSanPham.TabIndex = 1;
            // 
            // GioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(894, 1160);
            this.Controls.Add(this.fpnlSanPham);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Name = "GioHang";
            this.ShowInTaskbar = false;
            this.Text = "▄︻̷̿┻̿═━一";
            this.Load += new System.EventHandler(this.GioHang_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btPay;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.FlowLayoutPanel fpnlSanPham;
    }
}