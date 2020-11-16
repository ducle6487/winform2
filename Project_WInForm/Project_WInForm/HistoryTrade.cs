using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DTO;

namespace Project_WInForm
{
    public partial class HistoryTrade : Form
    {
        public HistoryTrade()
        {
            InitializeComponent();
        }

        public HistoryTrade(string AccID)
        {
            InitializeComponent();
            this.Accid = AccID;
        }

        string Accid = "";

        List<PaymentHistoryDTO> list = new List<PaymentHistoryDTO>();

        PaymentBAL bal = new PaymentBAL();

        private void HistoryTrade_Load(object sender, EventArgs e)
        {

            dgvHistory.Width = this.Width;
            dgvHistory.Height = this.Height;
            loadDataToUI();
            btShowAll.Enabled = false;

        }

        

        private void loadDataToUI()
        {
            list = bal.GetInfoPaymentFromAccID(Accid);
            dgvHistory.DataSource = list;
            if(list.Count > 0)
            {

                DateTime min = list[0].NgayDat;
                DateTime max = list[0].NgayDat;

                foreach (PaymentHistoryDTO item in list)
                {
                    if (item.NgayDat < min)
                    {
                        min = item.NgayDat;
                    }
                    if (item.NgayDat > max)
                    {
                        max = item.NgayDat;
                    }
                }

                dtpFrom.Value = min;
                dtpTo.Value = max;
            }
        }

        private void HistoryTrade_Resize(object sender, EventArgs e)
        {
            dgvHistory.Width = this.Width;
            dgvHistory.Height = this.Height;
        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            
            if(dtpFrom.Value > dtpTo.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
            }
            else
            {
                
                List<PaymentHistoryDTO> listTemp = new List<PaymentHistoryDTO>();
                foreach(PaymentHistoryDTO item in list)
                {
                    if(item.NgayDat >= dtpFrom.Value && item.NgayDat <= dtpTo.Value)
                    {
                        listTemp.Add(item);
                    }
                }

                dgvHistory.DataSource = listTemp;
                btShowAll.Enabled = true;
            }
        }

        private void btShowAll_Click(object sender, EventArgs e)
        {
            loadDataToUI();
            btShowAll.Enabled = false;
        }
    }
}
