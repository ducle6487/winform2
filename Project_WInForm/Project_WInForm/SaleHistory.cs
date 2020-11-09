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
    public partial class SaleHistory : Form
    {
        public SaleHistory()
        {
            InitializeComponent();
        }

        SaleHistoryBAL bal = new SaleHistoryBAL();

        private void SaleHistory_Load(object sender, EventArgs e)
        {
            List<SaleHistoryDTO> list = new List<SaleHistoryDTO>();
            list = bal.GetSaleHistories();
            dgvSaleHistory.DataSource = list;
        }
    }
}
