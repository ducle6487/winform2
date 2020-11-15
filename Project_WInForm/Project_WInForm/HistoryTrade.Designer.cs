namespace Project_WInForm
{
    partial class HistoryTrade
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
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistory
            // 
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(1, 129);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersWidth = 62;
            this.dgvHistory.RowTemplate.Height = 28;
            this.dgvHistory.Size = new System.Drawing.Size(1418, 806);
            this.dgvHistory.TabIndex = 0;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(204, 58);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 32);
            this.dtpFrom.TabIndex = 1;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(658, 58);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 32);
            this.dtpTo.TabIndex = 1;
            // 
            // btFilter
            // 
            this.btFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFilter.Location = new System.Drawing.Point(989, 42);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(172, 54);
            this.btFilter.TabIndex = 2;
            this.btFilter.Text = "Lọc";
            this.btFilter.UseVisualStyleBackColor = true;
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ ngày: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày: ";
            // 
            // btShowAll
            // 
            this.btShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowAll.Location = new System.Drawing.Point(1233, 42);
            this.btShowAll.Name = "btShowAll";
            this.btShowAll.Size = new System.Drawing.Size(154, 54);
            this.btShowAll.TabIndex = 4;
            this.btShowAll.Text = "Hiện tất cả";
            this.btShowAll.UseVisualStyleBackColor = true;
            this.btShowAll.Click += new System.EventHandler(this.btShowAll_Click);
            // 
            // HistoryTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 933);
            this.Controls.Add(this.btShowAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btFilter);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.dgvHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryTrade";
            this.Text = "HistoryTrade";
            this.Load += new System.EventHandler(this.HistoryTrade_Load);
            this.Resize += new System.EventHandler(this.HistoryTrade_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btShowAll;
    }
}