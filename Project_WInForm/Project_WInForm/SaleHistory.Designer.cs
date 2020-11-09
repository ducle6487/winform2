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
            this.dgvSaleHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSaleHistory
            // 
            this.dgvSaleHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvSaleHistory.Name = "dgvSaleHistory";
            this.dgvSaleHistory.RowHeadersWidth = 62;
            this.dgvSaleHistory.RowTemplate.Height = 28;
            this.dgvSaleHistory.Size = new System.Drawing.Size(1461, 869);
            this.dgvSaleHistory.TabIndex = 0;
            // 
            // SaleHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 869);
            this.Controls.Add(this.dgvSaleHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleHistory";
            this.Text = "SaleHistory";
            this.Load += new System.EventHandler(this.SaleHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSaleHistory;
    }
}