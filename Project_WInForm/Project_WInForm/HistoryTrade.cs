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

        PaymentBAL bal = new PaymentBAL();

        private void HistoryTrade_Load(object sender, EventArgs e)
        {

            dgvHistory.Width = this.Width;
            dgvHistory.Height = this.Height;
            List<PaymentHistoryDTO> list = bal.GetInfoPaymentFromAccID(Accid);
            dgvHistory.DataSource = list;

        }

        private void HistoryTrade_Resize(object sender, EventArgs e)
        {
            dgvHistory.Width = this.Width;
            dgvHistory.Height = this.Height;
        }
    }
}
