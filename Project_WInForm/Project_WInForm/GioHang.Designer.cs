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
            this.pnHead = new System.Windows.Forms.Panel();
            this.pnCount = new System.Windows.Forms.Panel();
            this.btTruSL = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btCongSL = new System.Windows.Forms.Button();
            this.pnImage = new System.Windows.Forms.Panel();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lbGioHang = new System.Windows.Forms.Label();
            this.chbName = new System.Windows.Forms.CheckBox();
            this.lbTenSanPham = new System.Windows.Forms.Label();
            this.btHuy = new System.Windows.Forms.Button();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.pnFooter = new System.Windows.Forms.Panel();
            this.flpnContain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnSanPham = new System.Windows.Forms.Panel();
            this.lbSanPham = new System.Windows.Forms.Label();
            this.pnHead.SuspendLayout();
            this.pnCount.SuspendLayout();
            this.pnImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.pnTitle.SuspendLayout();
            this.pnFooter.SuspendLayout();
            this.pnSanPham.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHead
            // 
            this.pnHead.Controls.Add(this.pnCount);
            this.pnHead.Controls.Add(this.pnSanPham);
            this.pnHead.Controls.Add(this.pnImage);
            this.pnHead.Controls.Add(this.pnTitle);
            this.pnHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHead.Location = new System.Drawing.Point(0, 0);
            this.pnHead.Name = "pnHead";
            this.pnHead.Size = new System.Drawing.Size(478, 144);
            this.pnHead.TabIndex = 1;
            this.pnHead.Resize += new System.EventHandler(this.pnHead_Resize);
            // 
            // pnCount
            // 
            this.pnCount.Controls.Add(this.btTruSL);
            this.pnCount.Controls.Add(this.txtSoLuong);
            this.pnCount.Controls.Add(this.btCongSL);
            this.pnCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnCount.Location = new System.Drawing.Point(353, 51);
            this.pnCount.Name = "pnCount";
            this.pnCount.Size = new System.Drawing.Size(125, 93);
            this.pnCount.TabIndex = 4;
            this.pnCount.Resize += new System.EventHandler(this.pnCount_Resize);
            // 
            // btTruSL
            // 
            this.btTruSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTruSL.Location = new System.Drawing.Point(11, 21);
            this.btTruSL.Name = "btTruSL";
            this.btTruSL.Size = new System.Drawing.Size(27, 22);
            this.btTruSL.TabIndex = 1;
            this.btTruSL.Text = "-";
            this.btTruSL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btTruSL.UseVisualStyleBackColor = true;
            this.btTruSL.Click += new System.EventHandler(this.btTruSL_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(37, 22);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(45, 20);
            this.txtSoLuong.TabIndex = 3;
            this.txtSoLuong.Text = "1";
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btCongSL
            // 
            this.btCongSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCongSL.Location = new System.Drawing.Point(80, 21);
            this.btCongSL.Name = "btCongSL";
            this.btCongSL.Size = new System.Drawing.Size(27, 22);
            this.btCongSL.TabIndex = 0;
            this.btCongSL.Text = "+";
            this.btCongSL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCongSL.UseVisualStyleBackColor = true;
            this.btCongSL.Click += new System.EventHandler(this.btCongSL_Click);
            // 
            // pnImage
            // 
            this.pnImage.Controls.Add(this.pbxImage);
            this.pnImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnImage.Location = new System.Drawing.Point(0, 51);
            this.pnImage.Name = "pnImage";
            this.pnImage.Size = new System.Drawing.Size(102, 93);
            this.pnImage.TabIndex = 2;
            this.pnImage.Resize += new System.EventHandler(this.pnImage_Resize);
            // 
            // pbxImage
            // 
            this.pbxImage.Location = new System.Drawing.Point(0, 0);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(102, 93);
            this.pbxImage.TabIndex = 2;
            this.pbxImage.TabStop = false;
            // 
            // pnTitle
            // 
            this.pnTitle.Controls.Add(this.lbGioHang);
            this.pnTitle.Controls.Add(this.chbName);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(478, 51);
            this.pnTitle.TabIndex = 0;
            this.pnTitle.Resize += new System.EventHandler(this.pnTitle_Resize);
            // 
            // lbGioHang
            // 
            this.lbGioHang.AutoSize = true;
            this.lbGioHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioHang.Location = new System.Drawing.Point(3, 12);
            this.lbGioHang.Name = "lbGioHang";
            this.lbGioHang.Size = new System.Drawing.Size(90, 24);
            this.lbGioHang.TabIndex = 1;
            this.lbGioHang.Text = "Giỏ Hàng";
            // 
            // chbName
            // 
            this.chbName.AutoSize = true;
            this.chbName.Location = new System.Drawing.Point(188, 19);
            this.chbName.Name = "chbName";
            this.chbName.Size = new System.Drawing.Size(54, 17);
            this.chbName.TabIndex = 0;
            this.chbName.Text = "Name";
            this.chbName.UseVisualStyleBackColor = true;
            // 
            // lbTenSanPham
            // 
            this.lbTenSanPham.AutoSize = true;
            this.lbTenSanPham.Location = new System.Drawing.Point(83, 39);
            this.lbTenSanPham.Name = "lbTenSanPham";
            this.lbTenSanPham.Size = new System.Drawing.Size(78, 13);
            this.lbTenSanPham.TabIndex = 0;
            this.lbTenSanPham.Text = "Tên Sản Phẩm";
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(76, 12);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(134, 52);
            this.btHuy.TabIndex = 2;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            // 
            // btThanhToan
            // 
            this.btThanhToan.Location = new System.Drawing.Point(273, 12);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(134, 52);
            this.btThanhToan.TabIndex = 3;
            this.btThanhToan.Text = "Thanh Toán";
            this.btThanhToan.UseVisualStyleBackColor = true;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // pnFooter
            // 
            this.pnFooter.Controls.Add(this.btThanhToan);
            this.pnFooter.Controls.Add(this.btHuy);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 452);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(478, 76);
            this.pnFooter.TabIndex = 0;
            this.pnFooter.Resize += new System.EventHandler(this.pnFooter_Resize);
            // 
            // flpnContain
            // 
            this.flpnContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnContain.Location = new System.Drawing.Point(0, 144);
            this.flpnContain.Name = "flpnContain";
            this.flpnContain.Size = new System.Drawing.Size(478, 308);
            this.flpnContain.TabIndex = 2;

            // 
            // pnSanPham
            // 
            this.pnSanPham.Controls.Add(this.lbSanPham);
            this.pnSanPham.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSanPham.Location = new System.Drawing.Point(102, 51);
            this.pnSanPham.Name = "pnSanPham";
            this.pnSanPham.Size = new System.Drawing.Size(253, 93);
            this.pnSanPham.TabIndex = 3;
            this.pnSanPham.Resize += new System.EventHandler(this.pnSanPham_Resize);
            // 
            // lbSanPham
            // 
            this.lbSanPham.AutoSize = true;
            this.lbSanPham.Location = new System.Drawing.Point(94, 39);
            this.lbSanPham.Name = "lbSanPham";
            this.lbSanPham.Size = new System.Drawing.Size(78, 13);
            this.lbSanPham.TabIndex = 0;
            this.lbSanPham.Text = "Tên Sản Phẩm";
            // 
            // GioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 528);
            this.Controls.Add(this.flpnContain);
            this.Controls.Add(this.pnHead);
            this.Controls.Add(this.pnFooter);
            this.Name = "GioHang";
            this.Text = "GioHang";
            this.Load += new System.EventHandler(this.GioHang_Load);
            this.Resize += new System.EventHandler(this.GioHang_Resize);
            this.pnHead.ResumeLayout(false);
            this.pnCount.ResumeLayout(false);
            this.pnCount.PerformLayout();
            this.pnImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.pnFooter.ResumeLayout(false);
            this.pnSanPham.ResumeLayout(false);
            this.pnSanPham.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnHead;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Panel pnCount;
       // private System.Windows.Forms.Panel pnTenSanPham;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.Panel pnFooter;
        private System.Windows.Forms.CheckBox chbName;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lbTenSanPham;
        private System.Windows.Forms.Label lbGioHang;
        private System.Windows.Forms.Button btTruSL;
        private System.Windows.Forms.Button btCongSL;
        private System.Windows.Forms.Panel pnImage;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.FlowLayoutPanel flpnContain;
        private System.Windows.Forms.Panel pnSanPham;
        private System.Windows.Forms.Label lbSanPham;
    }
}