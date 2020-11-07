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
            this.pnContain = new System.Windows.Forms.Panel();
            this.pnHead = new System.Windows.Forms.Panel();
            this.pnCount = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnTenSanPham = new System.Windows.Forms.Panel();
            this.lbTenSanPham = new System.Windows.Forms.Label();
            this.pnImage = new System.Windows.Forms.Panel();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lbGioHang = new System.Windows.Forms.Label();
            this.chbName = new System.Windows.Forms.CheckBox();
            this.btHuy = new System.Windows.Forms.Button();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.pnFooter = new System.Windows.Forms.Panel();
            this.pnHead.SuspendLayout();
            this.pnCount.SuspendLayout();
            this.pnTenSanPham.SuspendLayout();
            this.pnImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.pnTitle.SuspendLayout();
            this.pnFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContain
            // 
            this.pnContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContain.Location = new System.Drawing.Point(0, 178);
            this.pnContain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnContain.Name = "pnContain";
            this.pnContain.Size = new System.Drawing.Size(1200, 884);
            this.pnContain.TabIndex = 2;
            // 
            // pnHead
            // 
            this.pnHead.Controls.Add(this.pnCount);
            this.pnHead.Controls.Add(this.pnTenSanPham);
            this.pnHead.Controls.Add(this.pnImage);
            this.pnHead.Controls.Add(this.pnTitle);
            this.pnHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHead.Location = new System.Drawing.Point(0, 0);
            this.pnHead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnHead.Name = "pnHead";
            this.pnHead.Size = new System.Drawing.Size(1200, 178);
            this.pnHead.TabIndex = 1;
            // 
            // pnCount
            // 
            this.pnCount.Controls.Add(this.button2);
            this.pnCount.Controls.Add(this.textBox1);
            this.pnCount.Controls.Add(this.button1);
            this.pnCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnCount.Location = new System.Drawing.Point(1023, 78);
            this.pnCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnCount.Name = "pnCount";
            this.pnCount.Size = new System.Drawing.Size(177, 100);
            this.pnCount.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(15, 32);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "-";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 26);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(120, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "+";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnTenSanPham
            // 
            this.pnTenSanPham.Controls.Add(this.lbTenSanPham);
            this.pnTenSanPham.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTenSanPham.Location = new System.Drawing.Point(429, 78);
            this.pnTenSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnTenSanPham.Name = "pnTenSanPham";
            this.pnTenSanPham.Size = new System.Drawing.Size(596, 100);
            this.pnTenSanPham.TabIndex = 3;
            // 
            // lbTenSanPham
            // 
            this.lbTenSanPham.AutoSize = true;
            this.lbTenSanPham.Location = new System.Drawing.Point(168, 46);
            this.lbTenSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenSanPham.Name = "lbTenSanPham";
            this.lbTenSanPham.Size = new System.Drawing.Size(114, 20);
            this.lbTenSanPham.TabIndex = 0;
            this.lbTenSanPham.Text = "Tên Sản Phẩm";
            // 
            // pnImage
            // 
            this.pnImage.Controls.Add(this.pbxImage);
            this.pnImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnImage.Location = new System.Drawing.Point(0, 78);
            this.pnImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnImage.Name = "pnImage";
            this.pnImage.Size = new System.Drawing.Size(429, 100);
            this.pnImage.TabIndex = 2;
            // 
            // pbxImage
            // 
            this.pbxImage.Location = new System.Drawing.Point(4, 0);
            this.pbxImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(424, 100);
            this.pbxImage.TabIndex = 0;
            this.pbxImage.TabStop = false;
            // 
            // pnTitle
            // 
            this.pnTitle.Controls.Add(this.lbGioHang);
            this.pnTitle.Controls.Add(this.chbName);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1200, 78);
            this.pnTitle.TabIndex = 0;
            // 
            // lbGioHang
            // 
            this.lbGioHang.AutoSize = true;
            this.lbGioHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioHang.Location = new System.Drawing.Point(4, 18);
            this.lbGioHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGioHang.Name = "lbGioHang";
            this.lbGioHang.Size = new System.Drawing.Size(138, 33);
            this.lbGioHang.TabIndex = 1;
            this.lbGioHang.Text = "Giỏ Hàng";
            // 
            // chbName
            // 
            this.chbName.AutoSize = true;
            this.chbName.Location = new System.Drawing.Point(588, 18);
            this.chbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbName.Name = "chbName";
            this.chbName.Size = new System.Drawing.Size(77, 24);
            this.chbName.TabIndex = 0;
            this.chbName.Text = "Name";
            this.chbName.UseVisualStyleBackColor = true;
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(320, 18);
            this.btHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(201, 80);
            this.btHuy.TabIndex = 2;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            // 
            // btThanhToan
            // 
            this.btThanhToan.Location = new System.Drawing.Point(646, 18);
            this.btThanhToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(201, 80);
            this.btThanhToan.TabIndex = 3;
            this.btThanhToan.Text = "Thanh Toán";
            this.btThanhToan.UseVisualStyleBackColor = true;
            // 
            // pnFooter
            // 
            this.pnFooter.Controls.Add(this.btThanhToan);
            this.pnFooter.Controls.Add(this.btHuy);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 1062);
            this.pnFooter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(1200, 117);
            this.pnFooter.TabIndex = 0;
            // 
            // GioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 1179);
            this.Controls.Add(this.pnContain);
            this.Controls.Add(this.pnHead);
            this.Controls.Add(this.pnFooter);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GioHang";
            this.Text = "GioHang";
            this.pnHead.ResumeLayout(false);
            this.pnCount.ResumeLayout(false);
            this.pnCount.PerformLayout();
            this.pnTenSanPham.ResumeLayout(false);
            this.pnTenSanPham.PerformLayout();
            this.pnImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.pnFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnContain;
        private System.Windows.Forms.Panel pnHead;
        private System.Windows.Forms.Panel pnImage;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Panel pnCount;
        private System.Windows.Forms.Panel pnTenSanPham;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.Panel pnFooter;
        private System.Windows.Forms.CheckBox chbName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Label lbTenSanPham;
        private System.Windows.Forms.Label lbGioHang;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}