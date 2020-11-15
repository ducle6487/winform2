namespace Project_WInForm
{
    partial class SaleHistory
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
            this.pnlDgv = new System.Windows.Forms.Panel();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.dgvSaleHistory = new System.Windows.Forms.DataGridView();
            this.pnlFilterInfo = new System.Windows.Forms.Panel();
            this.btFilterTyped = new System.Windows.Forms.Button();
            this.txtDataFilter = new System.Windows.Forms.TextBox();
            this.cbxFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btShowAll = new System.Windows.Forms.Button();
            this.btDateFilter = new System.Windows.Forms.Button();
            this.lbto = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlDgv.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleHistory)).BeginInit();
            this.pnlFilterInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.dgvSaleHistory);
            this.pnlDgv.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDgv.Location = new System.Drawing.Point(0, 0);
            this.pnlDgv.Name = "pnlDgv";
            this.pnlDgv.Size = new System.Drawing.Size(1303, 869);
            this.pnlDgv.TabIndex = 0;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.pnlFilterInfo);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilter.Location = new System.Drawing.Point(1303, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(581, 869);
            this.pnlFilter.TabIndex = 1;
            // 
            // dgvSaleHistory
            // 
            this.dgvSaleHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvSaleHistory.Name = "dgvSaleHistory";
            this.dgvSaleHistory.RowHeadersWidth = 62;
            this.dgvSaleHistory.RowTemplate.Height = 28;
            this.dgvSaleHistory.Size = new System.Drawing.Size(1303, 869);
            this.dgvSaleHistory.TabIndex = 1;
            // 
            // pnlFilterInfo
            // 
            this.pnlFilterInfo.Controls.Add(this.label4);
            this.pnlFilterInfo.Controls.Add(this.btFilterTyped);
            this.pnlFilterInfo.Controls.Add(this.txtDataFilter);
            this.pnlFilterInfo.Controls.Add(this.cbxFilter);
            this.pnlFilterInfo.Controls.Add(this.label3);
            this.pnlFilterInfo.Controls.Add(this.label2);
            this.pnlFilterInfo.Controls.Add(this.label1);
            this.pnlFilterInfo.Controls.Add(this.btShowAll);
            this.pnlFilterInfo.Controls.Add(this.btDateFilter);
            this.pnlFilterInfo.Controls.Add(this.lbto);
            this.pnlFilterInfo.Controls.Add(this.lbFrom);
            this.pnlFilterInfo.Controls.Add(this.dtpTo);
            this.pnlFilterInfo.Controls.Add(this.dtpFrom);
            this.pnlFilterInfo.Location = new System.Drawing.Point(22, 12);
            this.pnlFilterInfo.Name = "pnlFilterInfo";
            this.pnlFilterInfo.Size = new System.Drawing.Size(533, 845);
            this.pnlFilterInfo.TabIndex = 0;
            // 
            // btFilterTyped
            // 
            this.btFilterTyped.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFilterTyped.Location = new System.Drawing.Point(202, 732);
            this.btFilterTyped.Name = "btFilterTyped";
            this.btFilterTyped.Size = new System.Drawing.Size(188, 69);
            this.btFilterTyped.TabIndex = 20;
            this.btFilterTyped.Text = "Lọc";
            this.btFilterTyped.UseVisualStyleBackColor = true;
            this.btFilterTyped.Click += new System.EventHandler(this.btFilterTyped_Click);
            // 
            // txtDataFilter
            // 
            this.txtDataFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFilter.Location = new System.Drawing.Point(211, 552);
            this.txtDataFilter.Name = "txtDataFilter";
            this.txtDataFilter.Size = new System.Drawing.Size(285, 35);
            this.txtDataFilter.TabIndex = 19;
            // 
            // cbxFilter
            // 
            this.cbxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilter.FormattingEnabled = true;
            this.cbxFilter.Location = new System.Drawing.Point(211, 632);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(285, 37);
            this.cbxFilter.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 635);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Lọc theo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 555);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Dữ liệu lọc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lọc theo ngày";
            // 
            // btShowAll
            // 
            this.btShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowAll.Location = new System.Drawing.Point(202, 33);
            this.btShowAll.Name = "btShowAll";
            this.btShowAll.Size = new System.Drawing.Size(188, 61);
            this.btShowAll.TabIndex = 14;
            this.btShowAll.Text = "Hiện tất cả";
            this.btShowAll.UseVisualStyleBackColor = true;
            this.btShowAll.Click += new System.EventHandler(this.btShowAll_Click);
            // 
            // btDateFilter
            // 
            this.btDateFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDateFilter.Location = new System.Drawing.Point(202, 361);
            this.btDateFilter.Name = "btDateFilter";
            this.btDateFilter.Size = new System.Drawing.Size(188, 69);
            this.btDateFilter.TabIndex = 13;
            this.btDateFilter.Text = "Lọc theo ngày";
            this.btDateFilter.UseVisualStyleBackColor = true;
            this.btDateFilter.Click += new System.EventHandler(this.btDateFilter_Click);
            // 
            // lbto
            // 
            this.lbto.AutoSize = true;
            this.lbto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbto.Location = new System.Drawing.Point(54, 282);
            this.lbto.Name = "lbto";
            this.lbto.Size = new System.Drawing.Size(114, 29);
            this.lbto.TabIndex = 11;
            this.lbto.Text = "Đến ngày";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrom.Location = new System.Drawing.Point(54, 207);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(99, 29);
            this.lbFrom.TabIndex = 12;
            this.lbFrom.Text = "Từ ngày";
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(211, 277);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(285, 35);
            this.dtpTo.TabIndex = 9;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(211, 202);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(285, 35);
            this.dtpFrom.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Lọc theo loại dữ liệu";
            // 
            // SaleHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 869);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleHistory";
            this.Text = "SaleHistory";
            this.Load += new System.EventHandler(this.SaleHistory_Load);
            this.Resize += new System.EventHandler(this.SaleHistory_Resize);
            this.pnlDgv.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleHistory)).EndInit();
            this.pnlFilterInfo.ResumeLayout(false);
            this.pnlFilterInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDgv;
        private System.Windows.Forms.DataGridView dgvSaleHistory;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Panel pnlFilterInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btFilterTyped;
        private System.Windows.Forms.TextBox txtDataFilter;
        private System.Windows.Forms.ComboBox cbxFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btShowAll;
        private System.Windows.Forms.Button btDateFilter;
        private System.Windows.Forms.Label lbto;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
    }
}