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
        private void LoadData()
        {
            PictureBox pt = new PictureBox();
            Bitmap bm = new Bitmap(Application.StartupPath + "\\Resources\\logo.png");
            pt.Image = bm;
            flpnContain.Controls.Add(pt);
            MessageBox.Show("Okay");
        }

        private void GioHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
