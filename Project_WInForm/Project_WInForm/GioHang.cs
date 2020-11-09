using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_WInForm
{
    public partial class GioHang : Form
    {
        public GioHang()
        {
            InitializeComponent();
        }

        List<GioHangDTO> list = new List<GioHangDTO>();


        public GioHang(List<GioHangDTO> list)
        {
            InitializeComponent();
            this.list = list;
        }


        private void GioHang_Load(object sender, EventArgs e)
        {
            resizeForm();
            
        }

        private void resizeForm()
        {

            this.Height = 950;
            this.Width = 700;

            ControlBox = false;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            pnlTop.Height = Convert.ToInt32(this.Height * 0.075);
            pnlTop.Width = this.Width;

            pnlBottom.Height = Convert.ToInt32(this.Height * 0.175);
            pnlBottom.Width = this.Width;

            btBack.Width = Convert.ToInt32(pnlBottom.Width / 3.25);
            btPay.Width = btBack.Width;
            btBack.Height = Convert.ToInt32(pnlBottom.Height / 3.5);
            btPay.Height = btBack.Height;

            btBack.Location = new Point(Convert.ToInt32((pnlBottom.Width / 4) - (btBack.Width / 2)),Convert.ToInt32((pnlBottom.Height / 2)));
            btPay.Location = new Point(Convert.ToInt32((pnlBottom.Width * 0.75) - (btPay.Width / 2)), btBack.Location.Y);

            lbTotalPrice.Location = new Point(Convert.ToInt32(pnlBottom.Width / 2), 5);
            lbTotalPrice.Font = new Font("Arial", 19, FontStyle.Regular);


            lbTittle.Font = new Font("Arial", 24, FontStyle.Bold);
            lbTittle.Location = new Point(Convert.ToInt32((pnlTop.Width / 2) - (lbTittle.Width / 2)),Convert.ToInt32((pnlTop.Height / 2)- (lbTittle.Height / 2)));
        }

    }
}
