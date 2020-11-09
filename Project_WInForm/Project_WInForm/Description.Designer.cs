namespace Project_WInForm
{
    partial class Description
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pbxImage2 = new System.Windows.Forms.PictureBox();
            this.pbxImage1 = new System.Windows.Forms.PictureBox();
            this.pnBigImage = new System.Windows.Forms.Panel();
            this.pbxBigImage = new System.Windows.Forms.PictureBox();
            this.pnDescription = new System.Windows.Forms.Panel();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.btTiepTucMuaSam = new System.Windows.Forms.Button();
            this.btCongSL = new System.Windows.Forms.Button();
            this.btTruSL = new System.Windows.Forms.Button();
            this.btSizeXL = new System.Windows.Forms.Button();
            this.btSizeL = new System.Windows.Forms.Button();
            this.btSizeM = new System.Windows.Forms.Button();
            this.btThemVaoGio = new System.Windows.Forms.Button();
            this.pnMain.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage1)).BeginInit();
            this.pnBigImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBigImage)).BeginInit();
            this.pnDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.LightGray;
            this.pnMain.Controls.Add(this.pnlLeft);
            this.pnMain.Controls.Add(this.pnBigImage);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1200, 545);
            this.pnMain.TabIndex = 1;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLeft.Controls.Add(this.pbxImage2);
            this.pnlLeft.Controls.Add(this.pbxImage1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(230, 545);
            this.pnlLeft.TabIndex = 5;
            this.pnlLeft.Resize += new System.EventHandler(this.pnlLeft_Resize);
            // 
            // pbxImage2
            // 
            this.pbxImage2.Location = new System.Drawing.Point(42, 300);
            this.pbxImage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxImage2.Name = "pbxImage2";
            this.pbxImage2.Size = new System.Drawing.Size(136, 170);
            this.pbxImage2.TabIndex = 1;
            this.pbxImage2.TabStop = false;
            this.pbxImage2.Click += new System.EventHandler(this.pbxImage2_Click);
            // 
            // pbxImage1
            // 
            this.pbxImage1.Location = new System.Drawing.Point(42, 60);
            this.pbxImage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxImage1.Name = "pbxImage1";
            this.pbxImage1.Size = new System.Drawing.Size(136, 179);
            this.pbxImage1.TabIndex = 4;
            this.pbxImage1.TabStop = false;
            this.pbxImage1.Click += new System.EventHandler(this.pbxImage1_Click);
            // 
            // pnBigImage
            // 
            this.pnBigImage.Controls.Add(this.pbxBigImage);
            this.pnBigImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnBigImage.Location = new System.Drawing.Point(225, 0);
            this.pnBigImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnBigImage.Name = "pnBigImage";
            this.pnBigImage.Size = new System.Drawing.Size(975, 545);
            this.pnBigImage.TabIndex = 4;
            // 
            // pbxBigImage
            // 
            this.pbxBigImage.BackColor = System.Drawing.Color.White;
            this.pbxBigImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxBigImage.Location = new System.Drawing.Point(0, 0);
            this.pbxBigImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxBigImage.Name = "pbxBigImage";
            this.pbxBigImage.Size = new System.Drawing.Size(975, 545);
            this.pbxBigImage.TabIndex = 2;
            this.pbxBigImage.TabStop = false;
            // 
            // pnDescription
            // 
            this.pnDescription.Controls.Add(this.lbSoLuong);
            this.pnDescription.Controls.Add(this.lbGia);
            this.pnDescription.Controls.Add(this.btTiepTucMuaSam);
            this.pnDescription.Controls.Add(this.btCongSL);
            this.pnDescription.Controls.Add(this.btTruSL);
            this.pnDescription.Controls.Add(this.btSizeXL);
            this.pnDescription.Controls.Add(this.btSizeL);
            this.pnDescription.Controls.Add(this.btSizeM);
            this.pnDescription.Controls.Add(this.btThemVaoGio);
            this.pnDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDescription.Location = new System.Drawing.Point(0, 546);
            this.pnDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnDescription.Name = "pnDescription";
            this.pnDescription.Size = new System.Drawing.Size(1200, 252);
            this.pnDescription.TabIndex = 2;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.BackColor = System.Drawing.Color.White;
            this.lbSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSoLuong.Location = new System.Drawing.Point(1008, 12);
            this.lbSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(65, 42);
            this.lbSoLuong.TabIndex = 10;
            this.lbSoLuong.Text = "1";
            this.lbSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGia
            // 
            this.lbGia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbGia.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.Location = new System.Drawing.Point(346, 11);
            this.lbGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(555, 46);
            this.lbGia.TabIndex = 9;
            this.lbGia.Text = "3000000";
            this.lbGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btTiepTucMuaSam
            // 
            this.btTiepTucMuaSam.BackColor = System.Drawing.Color.Black;
            this.btTiepTucMuaSam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTiepTucMuaSam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTiepTucMuaSam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTiepTucMuaSam.Location = new System.Drawing.Point(482, 169);
            this.btTiepTucMuaSam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTiepTucMuaSam.Name = "btTiepTucMuaSam";
            this.btTiepTucMuaSam.Size = new System.Drawing.Size(285, 58);
            this.btTiepTucMuaSam.TabIndex = 8;
            this.btTiepTucMuaSam.Text = "Tiếp Tục Mua Sắm";
            this.btTiepTucMuaSam.UseVisualStyleBackColor = false;
            this.btTiepTucMuaSam.Click += new System.EventHandler(this.btTiepTucMuaSam_Click);
            // 
            // btCongSL
            // 
            this.btCongSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCongSL.Location = new System.Drawing.Point(1072, 11);
            this.btCongSL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCongSL.Name = "btCongSL";
            this.btCongSL.Size = new System.Drawing.Size(66, 46);
            this.btCongSL.TabIndex = 6;
            this.btCongSL.Text = "+";
            this.btCongSL.UseVisualStyleBackColor = true;
            this.btCongSL.Click += new System.EventHandler(this.btCongSL_Click);
            // 
            // btTruSL
            // 
            this.btTruSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTruSL.Location = new System.Drawing.Point(945, 11);
            this.btTruSL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTruSL.Name = "btTruSL";
            this.btTruSL.Size = new System.Drawing.Size(66, 46);
            this.btTruSL.TabIndex = 5;
            this.btTruSL.Text = "-";
            this.btTruSL.UseVisualStyleBackColor = true;
            this.btTruSL.Click += new System.EventHandler(this.btTruSL_Click);
            // 
            // btSizeXL
            // 
            this.btSizeXL.BackColor = System.Drawing.Color.Black;
            this.btSizeXL.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btSizeXL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSizeXL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSizeXL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSizeXL.Location = new System.Drawing.Point(225, 11);
            this.btSizeXL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSizeXL.Name = "btSizeXL";
            this.btSizeXL.Size = new System.Drawing.Size(51, 46);
            this.btSizeXL.TabIndex = 4;
            this.btSizeXL.Text = "XL";
            this.btSizeXL.UseVisualStyleBackColor = false;
            this.btSizeXL.Click += new System.EventHandler(this.btsizeXL_Click);
            // 
            // btSizeL
            // 
            this.btSizeL.BackColor = System.Drawing.Color.Black;
            this.btSizeL.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btSizeL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSizeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSizeL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSizeL.Location = new System.Drawing.Point(132, 11);
            this.btSizeL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSizeL.Name = "btSizeL";
            this.btSizeL.Size = new System.Drawing.Size(51, 46);
            this.btSizeL.TabIndex = 3;
            this.btSizeL.Text = "L";
            this.btSizeL.UseVisualStyleBackColor = false;
            this.btSizeL.Click += new System.EventHandler(this.btsizeL_Click);
            // 
            // btSizeM
            // 
            this.btSizeM.BackColor = System.Drawing.Color.Black;
            this.btSizeM.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btSizeM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSizeM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSizeM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSizeM.Location = new System.Drawing.Point(42, 11);
            this.btSizeM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSizeM.Name = "btSizeM";
            this.btSizeM.Size = new System.Drawing.Size(51, 46);
            this.btSizeM.TabIndex = 2;
            this.btSizeM.Text = "M";
            this.btSizeM.UseVisualStyleBackColor = false;
            this.btSizeM.Click += new System.EventHandler(this.btsizeM_Click);
            // 
            // btThemVaoGio
            // 
            this.btThemVaoGio.BackColor = System.Drawing.Color.Black;
            this.btThemVaoGio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btThemVaoGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemVaoGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemVaoGio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThemVaoGio.Location = new System.Drawing.Point(294, 89);
            this.btThemVaoGio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btThemVaoGio.Name = "btThemVaoGio";
            this.btThemVaoGio.Size = new System.Drawing.Size(668, 77);
            this.btThemVaoGio.TabIndex = 0;
            this.btThemVaoGio.Text = "THÊM VÀO GIỎ HÀNG";
            this.btThemVaoGio.UseVisualStyleBackColor = false;
            this.btThemVaoGio.Click += new System.EventHandler(this.btThemVaoGio_Click);
            // 
            // Description
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 798);
            this.Controls.Add(this.pnDescription);
            this.Controls.Add(this.pnMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Description";
            this.Text = "Description";
            this.Load += new System.EventHandler(this.Description_Load);
            this.pnMain.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage1)).EndInit();
            this.pnBigImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBigImage)).EndInit();
            this.pnDescription.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnDescription;
        private System.Windows.Forms.Panel pnBigImage;
        private System.Windows.Forms.Button btSizeXL;
        private System.Windows.Forms.Button btSizeL;
        private System.Windows.Forms.Button btSizeM;
        private System.Windows.Forms.Button btThemVaoGio;
        private System.Windows.Forms.Button btCongSL;
        private System.Windows.Forms.Button btTruSL;
        private System.Windows.Forms.PictureBox pbxBigImage;
        private System.Windows.Forms.PictureBox pbxImage2;
        private System.Windows.Forms.PictureBox pbxImage1;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Button btTiepTucMuaSam;
        private System.Windows.Forms.Panel pnlLeft;
    }
}