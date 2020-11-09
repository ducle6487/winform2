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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
            lb1.Location = new Point(pnContain.Location.X,Convert.ToInt32(pnThongTin.Height+10));
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            ResizeHoaDon();
            ResizeContain();
            ResizeFooter();
            ResizePhuongThucThanhToan();
            ResizeThongTin();
        }

        private void HoaDon_Resize(object sender, EventArgs e)
        {
            ResizeHoaDon();
        }

        private void pnContain_Resize(object sender, EventArgs e)
        {
            ResizeContain();
        }

        private void pnFooter_Resize(object sender, EventArgs e)
        {
            ResizeFooter();
        }

        private void pnPhuongThucThanhToan_Resize(object sender, EventArgs e)
        {
            ResizePhuongThucThanhToan();
        }
        private void pnThongTin_Resize(object sender, EventArgs e)
        {
            ResizeThongTin();
        }
        private void ResizeContain()
        {
            pnThongTin.Width = Convert.ToInt32(pnContain.Width * 0.75);
            pnPhuongThucThanhToan.Width = Convert.ToInt32(pnContain.Width * 0.75);
            pnThongTin.Height = Convert.ToInt32(pnContain.Height * 0.75);
            pnPhuongThucThanhToan.Height = Convert.ToInt32(pnContain.Height * 0.2);
            pnThongTin.Location = new Point(pnContain.Location.X, pnContain.Location.Y);
        }
        private void ResizeFooter()
        {
            btDatMua.Width = Convert.ToInt32(pnFooter.Width / 3);
            btDatMua.Height = Convert.ToInt32(pnFooter.Height /2);
            btDatMua.Location = new Point(Convert.ToInt32(pnFooter.Location.X + btDatMua.Width), pnFooter.Height / 3);
        }
        private void ResizeThongTin()
        {
            lbDiaChiGiaoHang.Width = Convert.ToInt32(pnThongTin.Width * 0.6);
            lbDiaChiGiaoHang.Height = Convert.ToInt32(pnThongTin.Height * 0.2);
            lbDiaChiGiaoHang.Location = new Point(Convert.ToInt32(pnContain.Location.X + (lbDiaChiGiaoHang.Width / 9)), Convert.ToInt32(pnContain.Location.Y + lbDiaChiGiaoHang.Height));
            lbHoTen.Width = Convert.ToInt32(pnThongTin.Width * 0.1);
            lbHoTen.Height = Convert.ToInt32(pnThongTin.Height * 0.1);
            lbDienThoaiDiDong.Width = Convert.ToInt32(pnThongTin.Width * 0.1);
            lbDienThoaiDiDong.Height = Convert.ToInt32(pnThongTin.Height * 0.1);
            lbTinhThanhPho.Width = Convert.ToInt32(pnThongTin.Width * 0.1);
            lbTinhThanhPho.Height = Convert.ToInt32(pnThongTin.Height * 0.1);
            lbQuanHuyen.Width = Convert.ToInt32(pnThongTin.Width * 0.1);
            lbQuanHuyen.Height = Convert.ToInt32(pnThongTin.Height * 0.1);
            lbDiaChi.Width = Convert.ToInt32(pnThongTin.Width * 0.1);
            lbDiaChi.Height = Convert.ToInt32(pnThongTin.Height * 0.1);
            txtHoTen.Width = Convert.ToInt32(pnThongTin.Width * 0.55);
            txtHoTen.Height = lbHoTen.Height;
            txtDienThoaiDiDong.Width = Convert.ToInt32(pnThongTin.Width * 0.4);
            txtDienThoaiDiDong.Height = lbHoTen.Height;
            cbxTinhThanhPho.Width = Convert.ToInt32(pnThongTin.Width * 0.45);
            cbxTinhThanhPho.Height = lbHoTen.Height;
            cbxQuanHuyen.Width = Convert.ToInt32(pnThongTin.Width * 0.45);
            cbxQuanHuyen.Height = lbHoTen.Height;
            rtxtDiaChi.Width = Convert.ToInt32(pnThongTin.Width * 0.55);
            rtxtDiaChi.Height = Convert.ToInt32(pnThongTin.Height * 0.2);
        }
        private void ResizePhuongThucThanhToan()
        {
            lbPhuongThucThanhToan.Width = Convert.ToInt32(pnPhuongThucThanhToan.Width * 0.6);
            lbPhuongThucThanhToan.Height = Convert.ToInt32(pnPhuongThucThanhToan.Height * 0.2);
            rbtThanhToanKhiGiaoHang.Width = Convert.ToInt32(pnPhuongThucThanhToan.Width * 0.4);
            rbtThanhToanKhiGiaoHang.Height = Convert.ToInt32(pnPhuongThucThanhToan.Height * 0.2);
            rbtThanhToanThe.Width = Convert.ToInt32(pnPhuongThucThanhToan.Width * 0.4);
            rbtThanhToanThe.Height = Convert.ToInt32(pnPhuongThucThanhToan.Height * 0.2);

        }
        private void ResizeHoaDon()
        {
            pnContain.Height = Convert.ToInt32(this.Height * 0.75);
            pnFooter.Height = Convert.ToInt32(this.Height * 0.2);
            pnContain.Width = this.Width;
            pnFooter.Width = this.Width;
            pnContain.Location = new Point(0, 0);
            pnFooter.Location = new Point(0,Convert.ToInt32(pnContain.Height +5));
        }

        private void btDatMua_Click(object sender, EventArgs e)
        {
            HistoryTrade ht = new HistoryTrade();
            this.Hide();
            ht.Show();
            MessageBox.Show("Đặt Hàng Thành Công");
        }

        private void HoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn tắt chứ ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
