﻿namespace Project_WInForm
{
    partial class HoaDon
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
            this.pnFooter = new System.Windows.Forms.Panel();
            this.btDatMua = new System.Windows.Forms.Button();
            this.pnContain = new System.Windows.Forms.Panel();
            this.pnPhuongThucThanhToan = new System.Windows.Forms.Panel();
            this.pnThongTin = new System.Windows.Forms.Panel();
            this.lbTinhThanhPho = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lbDiaChiGiaoHang = new System.Windows.Forms.Label();
            this.lbDienThoaiDiDong = new System.Windows.Forms.Label();
            this.lbPhuongThucThanhToan = new System.Windows.Forms.Label();
            this.rbtThanhToanKhiGiaoHang = new System.Windows.Forms.RadioButton();
            this.rbtThanhToanThe = new System.Windows.Forms.RadioButton();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbQuanHuyen = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.txtDienThoaiDiDong = new System.Windows.Forms.TextBox();
            this.cbxTinhThanhPho = new System.Windows.Forms.ComboBox();
            this.cbxQuanHuyen = new System.Windows.Forms.ComboBox();
            this.rtxtDiaChi = new System.Windows.Forms.RichTextBox();
            this.pnFooter.SuspendLayout();
            this.pnContain.SuspendLayout();
            this.pnPhuongThucThanhToan.SuspendLayout();
            this.pnThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnFooter
            // 
            this.pnFooter.Controls.Add(this.btDatMua);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 463);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(496, 89);
            this.pnFooter.TabIndex = 1;
            // 
            // btDatMua
            // 
            this.btDatMua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btDatMua.Font = new System.Drawing.Font("Ink Free", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDatMua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btDatMua.Location = new System.Drawing.Point(167, 31);
            this.btDatMua.Name = "btDatMua";
            this.btDatMua.Size = new System.Drawing.Size(143, 46);
            this.btDatMua.TabIndex = 2;
            this.btDatMua.Text = "ĐẶT MUA";
            this.btDatMua.UseVisualStyleBackColor = false;
            // 
            // pnContain
            // 
            this.pnContain.Controls.Add(this.pnThongTin);
            this.pnContain.Controls.Add(this.pnPhuongThucThanhToan);
            this.pnContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContain.Location = new System.Drawing.Point(0, 0);
            this.pnContain.Name = "pnContain";
            this.pnContain.Size = new System.Drawing.Size(496, 463);
            this.pnContain.TabIndex = 2;
            // 
            // pnPhuongThucThanhToan
            // 
            this.pnPhuongThucThanhToan.Controls.Add(this.rbtThanhToanThe);
            this.pnPhuongThucThanhToan.Controls.Add(this.lbPhuongThucThanhToan);
            this.pnPhuongThucThanhToan.Controls.Add(this.rbtThanhToanKhiGiaoHang);
            this.pnPhuongThucThanhToan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnPhuongThucThanhToan.Location = new System.Drawing.Point(0, 390);
            this.pnPhuongThucThanhToan.Name = "pnPhuongThucThanhToan";
            this.pnPhuongThucThanhToan.Size = new System.Drawing.Size(496, 73);
            this.pnPhuongThucThanhToan.TabIndex = 1;
            // 
            // pnThongTin
            // 
            this.pnThongTin.Controls.Add(this.rtxtDiaChi);
            this.pnThongTin.Controls.Add(this.cbxQuanHuyen);
            this.pnThongTin.Controls.Add(this.cbxTinhThanhPho);
            this.pnThongTin.Controls.Add(this.txtDienThoaiDiDong);
            this.pnThongTin.Controls.Add(this.lbDiaChi);
            this.pnThongTin.Controls.Add(this.lbQuanHuyen);
            this.pnThongTin.Controls.Add(this.lbHoTen);
            this.pnThongTin.Controls.Add(this.lbDienThoaiDiDong);
            this.pnThongTin.Controls.Add(this.lbDiaChiGiaoHang);
            this.pnThongTin.Controls.Add(this.txtHoTen);
            this.pnThongTin.Controls.Add(this.lbTinhThanhPho);
            this.pnThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThongTin.Location = new System.Drawing.Point(0, 0);
            this.pnThongTin.Name = "pnThongTin";
            this.pnThongTin.Size = new System.Drawing.Size(496, 390);
            this.pnThongTin.TabIndex = 2;
            // 
            // lbTinhThanhPho
            // 
            this.lbTinhThanhPho.AutoSize = true;
            this.lbTinhThanhPho.Location = new System.Drawing.Point(36, 118);
            this.lbTinhThanhPho.Name = "lbTinhThanhPho";
            this.lbTinhThanhPho.Size = new System.Drawing.Size(86, 13);
            this.lbTinhThanhPho.TabIndex = 0;
            this.lbTinhThanhPho.Text = "Tỉnh/Thành Phố";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(167, 39);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(192, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // lbDiaChiGiaoHang
            // 
            this.lbDiaChiGiaoHang.AutoSize = true;
            this.lbDiaChiGiaoHang.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChiGiaoHang.Location = new System.Drawing.Point(12, 9);
            this.lbDiaChiGiaoHang.Name = "lbDiaChiGiaoHang";
            this.lbDiaChiGiaoHang.Size = new System.Drawing.Size(156, 16);
            this.lbDiaChiGiaoHang.TabIndex = 2;
            this.lbDiaChiGiaoHang.Text = "2.Địa Chỉ Giao Hàng";
            // 
            // lbDienThoaiDiDong
            // 
            this.lbDienThoaiDiDong.AutoSize = true;
            this.lbDienThoaiDiDong.Location = new System.Drawing.Point(36, 80);
            this.lbDienThoaiDiDong.Name = "lbDienThoaiDiDong";
            this.lbDienThoaiDiDong.Size = new System.Drawing.Size(104, 13);
            this.lbDienThoaiDiDong.TabIndex = 3;
            this.lbDienThoaiDiDong.Text = " Điện Thoại Di Động";
            // 
            // lbPhuongThucThanhToan
            // 
            this.lbPhuongThucThanhToan.AutoSize = true;
            this.lbPhuongThucThanhToan.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhuongThucThanhToan.Location = new System.Drawing.Point(12, 3);
            this.lbPhuongThucThanhToan.Name = "lbPhuongThucThanhToan";
            this.lbPhuongThucThanhToan.Size = new System.Drawing.Size(237, 16);
            this.lbPhuongThucThanhToan.TabIndex = 4;
            this.lbPhuongThucThanhToan.Text = "3.Chọn Hình Thức Thanh Toán";
            // 
            // rbtThanhToanKhiGiaoHang
            // 
            this.rbtThanhToanKhiGiaoHang.AutoSize = true;
            this.rbtThanhToanKhiGiaoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtThanhToanKhiGiaoHang.Location = new System.Drawing.Point(39, 22);
            this.rbtThanhToanKhiGiaoHang.Name = "rbtThanhToanKhiGiaoHang";
            this.rbtThanhToanKhiGiaoHang.Size = new System.Drawing.Size(214, 19);
            this.rbtThanhToanKhiGiaoHang.TabIndex = 4;
            this.rbtThanhToanKhiGiaoHang.TabStop = true;
            this.rbtThanhToanKhiGiaoHang.Text = " Thanh toán tiền mặt khi giao hàng";
            this.rbtThanhToanKhiGiaoHang.UseVisualStyleBackColor = true;
            // 
            // rbtThanhToanThe
            // 
            this.rbtThanhToanThe.AutoSize = true;
            this.rbtThanhToanThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtThanhToanThe.Location = new System.Drawing.Point(39, 50);
            this.rbtThanhToanThe.Name = "rbtThanhToanThe";
            this.rbtThanhToanThe.Size = new System.Drawing.Size(150, 19);
            this.rbtThanhToanThe.TabIndex = 5;
            this.rbtThanhToanThe.TabStop = true;
            this.rbtThanhToanThe.Text = "Thanh Toán Bằng Thẻ ";
            this.rbtThanhToanThe.UseVisualStyleBackColor = true;
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(36, 42);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(43, 13);
            this.lbHoTen.TabIndex = 4;
            this.lbHoTen.Text = "Họ Tên";
            // 
            // lbQuanHuyen
            // 
            this.lbQuanHuyen.AutoSize = true;
            this.lbQuanHuyen.Location = new System.Drawing.Point(38, 155);
            this.lbQuanHuyen.Name = "lbQuanHuyen";
            this.lbQuanHuyen.Size = new System.Drawing.Size(69, 13);
            this.lbQuanHuyen.TabIndex = 5;
            this.lbQuanHuyen.Text = "Quận/Huyện";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(38, 198);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(41, 13);
            this.lbDiaChi.TabIndex = 7;
            this.lbDiaChi.Text = "Địa Chỉ";
            // 
            // txtDienThoaiDiDong
            // 
            this.txtDienThoaiDiDong.Location = new System.Drawing.Point(167, 77);
            this.txtDienThoaiDiDong.Name = "txtDienThoaiDiDong";
            this.txtDienThoaiDiDong.Size = new System.Drawing.Size(165, 20);
            this.txtDienThoaiDiDong.TabIndex = 8;
            // 
            // cbxTinhThanhPho
            // 
            this.cbxTinhThanhPho.FormattingEnabled = true;
            this.cbxTinhThanhPho.Location = new System.Drawing.Point(167, 115);
            this.cbxTinhThanhPho.Name = "cbxTinhThanhPho";
            this.cbxTinhThanhPho.Size = new System.Drawing.Size(165, 21);
            this.cbxTinhThanhPho.TabIndex = 9;
            // 
            // cbxQuanHuyen
            // 
            this.cbxQuanHuyen.FormattingEnabled = true;
            this.cbxQuanHuyen.Location = new System.Drawing.Point(167, 152);
            this.cbxQuanHuyen.Name = "cbxQuanHuyen";
            this.cbxQuanHuyen.Size = new System.Drawing.Size(165, 21);
            this.cbxQuanHuyen.TabIndex = 10;
            // 
            // rtxtDiaChi
            // 
            this.rtxtDiaChi.Location = new System.Drawing.Point(167, 195);
            this.rtxtDiaChi.Name = "rtxtDiaChi";
            this.rtxtDiaChi.Size = new System.Drawing.Size(192, 48);
            this.rtxtDiaChi.TabIndex = 11;
            this.rtxtDiaChi.Text = "";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 552);
            this.Controls.Add(this.pnContain);
            this.Controls.Add(this.pnFooter);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.pnFooter.ResumeLayout(false);
            this.pnContain.ResumeLayout(false);
            this.pnPhuongThucThanhToan.ResumeLayout(false);
            this.pnPhuongThucThanhToan.PerformLayout();
            this.pnThongTin.ResumeLayout(false);
            this.pnThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnFooter;
        private System.Windows.Forms.Button btDatMua;
        private System.Windows.Forms.Panel pnContain;
        private System.Windows.Forms.Panel pnThongTin;
        private System.Windows.Forms.Panel pnPhuongThucThanhToan;
        private System.Windows.Forms.RichTextBox rtxtDiaChi;
        private System.Windows.Forms.ComboBox cbxQuanHuyen;
        private System.Windows.Forms.ComboBox cbxTinhThanhPho;
        private System.Windows.Forms.TextBox txtDienThoaiDiDong;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbQuanHuyen;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbDienThoaiDiDong;
        private System.Windows.Forms.Label lbDiaChiGiaoHang;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lbTinhThanhPho;
        private System.Windows.Forms.RadioButton rbtThanhToanThe;
        private System.Windows.Forms.Label lbPhuongThucThanhToan;
        private System.Windows.Forms.RadioButton rbtThanhToanKhiGiaoHang;
    }
}