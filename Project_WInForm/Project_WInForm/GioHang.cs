using BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DTO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_WInForm
{
    public partial class GioHang : Form
    {
        public int sl;
        List<Panel> ListPanel = new List<Panel>();
        List<GioHangDTO> GioHangList = new List<GioHangDTO>();
        PaymentBAL productBAL = new PaymentBAL();
        public GioHang()
        {
            InitializeComponent();
           
        }
        private void LoadData()
        {

        }

        private void GioHang_Load(object sender, EventArgs e)
        {
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            this.Hide();
            hd.Show();
        }

        private void pnHead_Resize(object sender, EventArgs e)
        {
            pnHeadResize();
        }

        private void GioHang_Resize(object sender, EventArgs e)
        {
            GioHangResize();
        }

        private void pnFooter_Resize(object sender, EventArgs e)
        {
            pnFooterResize();
        }


        private void SetupUI()
        {

            GioHangList = PaymentBAL.GetDataProduct();
            if (GioHangList.Count > 0)
            {
                for (int i = 0; i < GioHangList.Count; i++)
                {
                    Panel pnl = new Panel();

                    pnl.Width = flpnContain.Width;
                    pnl.Height = Convert.ToInt32(flpnContain.Height / 3);



                    ListPanel.Add(pnl);

                    PictureBox ptb = new PictureBox();
                    ptb.Location = pnl.Location;
                    ptb.Height = Convert.ToInt32(pnl.Height * 0.7);
                    ptb.Width = Convert.ToInt32(pnl.Width * 0.3);
                    ptb.SizeMode = PictureBoxSizeMode.Zoom;
                    ptb.LoadAsync(GioHangList[i].LinkImg);
                    ptb.Tag = i.ToString();
                    pnl.Controls.Add(ptb);
                    ptb.Click += panel_click;
                    Label lbName = new Label();
                    lbName.Location = new Point(Convert.ToInt32(pnl.Location.X + ptb.Width), pnl.Location.Y);
                    lbName.Width = Convert.ToInt32(pnl.Width * 0.25);
                    lbName.Height = Convert.ToInt32(pnl.Height * 0.15);
                    lbName.Text = GioHangList[i].ProductName;
                    lbName.Font = new Font("Arial", 15, FontStyle.Regular);
                    lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    pnl.Controls.Add(lbName);
                    Label lbSize = new Label();
                    lbSize.Location = new Point(Convert.ToInt32(pnl.Location.X + ptb.Width + lbName.Width), pnl.Location.Y);
                    lbSize.Width = Convert.ToInt32(pnl.Width * 0.15);
                    lbSize.Height = Convert.ToInt32(pnl.Height * 0.15);
                    lbSize.Text = GioHangList[i].Size;
                    lbSize.Font = new Font("Arial", 13, FontStyle.Regular);
                    lbSize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                    pnl.Controls.Add(lbSize);
                    Label lbsoluong = new Label();
                    lbsoluong.Location = new Point(Convert.ToInt32(pnl.Location.X + ptb.Width + lbName.Width + lbPrice.Width), pnl.Location.Y);
                    lbsoluong.Width = Convert.ToInt32(pnl.Width * 0.1);
                    lbsoluong.Height = Convert.ToInt32(pnl.Height * 0.15);
                    lbsoluong.Text = GioHangList[i].Soluong;
                    pnl.Controls.Add(lbsoluong);
                    Label lbDonGia = new Label();
                    lbDonGia.Location = new Point(Convert.ToInt32(pnl.Location.X + ptb.Width + lbName.Width + lbPrice.Width), pnl.Location.Y);
                    lbDonGia.Width = Convert.ToInt32(pnl.Width * 0.2);
                    lbDonGia.Height = Convert.ToInt32(pnl.Height * 0.15);
                    lbDonGia.Text = GioHangList[i].Dongia;
                    pnl.Controls.Add(lbDonGia);
                    flpnContain.Controls.Add(pnl);
                }
            }
            else
            {
                Panel pnl = new Panel();

                pnl.Width = Convert.ToInt32(350);
                pnl.Height = Convert.ToInt32(flpnContain.Height / 3);



                ListPanel.Add(pnl);

                PictureBox ptb = new PictureBox();
                ptb.Location = pnl.Location;
                ptb.Height = Convert.ToInt32(pnl.Height * 0.7);
                ptb.Width = Convert.ToInt32(pnl.Width * 0.3);
                ptb.SizeMode = PictureBoxSizeMode.Zoom;
                ptb.LoadAsync();
                pnl.Controls.Add(ptb);
                ptb.Click += Ptb_Click;
                Label lbName = new Label();
                lbName.Location = new Point(Convert.ToInt32(pnl.Location.X ), pnl.Location.Y+ ptb.Width);
                lbName.Width = Convert.ToInt32(pnl.Width * 0.25);
                lbName.Height = Convert.ToInt32(pnl.Height * 0.15);
                lbName.Text = "Không Có Sản Phẩm Nào Trong Giỏ Hàng Của Bạn";
                lbName.Font = new Font("Arial", 15, FontStyle.Regular);
                lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                pnl.Controls.Add(lbName);
                Button bt = new Button();
                bt.Location = new Point(Convert.ToInt32(pnl.Location.X), pnl.Location.Y + ptb.Width + lbName.Height);
                bt.Width = Convert.ToInt32(pnl.Width * 0.25);
                bt.Height = Convert.ToInt32(pnl.Height * 0.15);
                bt.Click += Bt_Click;
                bt.Text = "Tiếp Tục Mua Sắm";
                bt.Font = new Font("Arial", 15, FontStyle.Regular);
                bt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                pnl.Controls.Add(bt);
                flpnContain.Controls.Add(pnl);
            }
            
        }

        private void Ptb_Click(object sender, EventArgs e)
        {
            PictureBox ptb = sender as PictureBox;

            MessageBox.Show(GioHangList[Convert.ToInt32(ptb.Tag.ToString())].ProductName);
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            this.Hide();
            mp.Show();
        }

        private void pnImage_Resize(object sender, EventArgs e)
        {
            pnImageResize();
        }

        private void pnTitle_Resize(object sender, EventArgs e)
        {
            pnTitleResize();
        }

        private void pnCount_Resize(object sender, EventArgs e)
        {
            pnCountResize();
        }
        private void pnSanPham_Resize(object sender, EventArgs e)
        {
            pnSanPhamResize();
        }
        private void pnImageResize()
        {
            pbxImage.Width = pnImage.Width;
            pbxImage.Height = Convert.ToInt32(pnImage.Height * .85);
            //pbx
           // pnImage.Controls.Add(pnImage);
            pbxImage.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void pnCountResize()
        {
            btCongSL.Width = Convert.ToInt32(pnCount.Width * 0.3);
            btCongSL.Height = Convert.ToInt32(pnCount.Height *0.24);
            btTruSL.Width = Convert.ToInt32(pnCount.Width * 0.3);
            btTruSL.Height = Convert.ToInt32(pnCount.Height *0.24);
            txtSoLuong.Width = Convert.ToInt32(pnCount.Width * 0.3);
            txtSoLuong.Height = Convert.ToInt32(pnCount.Height / 5);
            btCongSL.Location = new Point(Convert.ToInt32(btTruSL.Width+txtSoLuong.Width), Convert.ToInt32(pnCount.Height * 0.24));
            btTruSL.Location = new Point(0, Convert.ToInt32(pnCount.Height *0.24));
            txtSoLuong.Location = new Point(btTruSL.Width, Convert.ToInt32(pnCount.Height * 0.26));
        }
        private void pnTitleResize()
        {
            lbGioHang.Width = pnTitle.Width / 3;
            lbGioHang.Height = pnTitle.Height / 2;
            chbName.Width = Convert.ToInt32(pnTitle.Width * 0.2);
            chbName.Height = Convert.ToInt32(pnTitle.Height * 0.2);
            lbGioHang.Location = new Point(0,Convert.ToInt32(pnTitle.Height/2));
            chbName.Location = new Point(Convert.ToInt32(pnTitle.Width/2),Convert.ToInt32(pnTitle.Height/2));
        }
        
        private void pnSanPhamResize()
        {
            lbSanPham.Width = Convert.ToInt32(pnSanPham.Width * 0.65);
            lbSanPham.Height = Convert.ToInt32(pnSanPham.Height * 0.2);
            lbSanPham.Location = new Point(Convert.ToInt32(pnTitle.Location.X + 10), pnTitle.Height / 2);
        }
        private void pnFooterResize()
        {
            btHuy.Width = Convert.ToInt32(pnFooter.Width / 3);
            btHuy.Height = Convert.ToInt32(pnFooter.Height * 0.7);
            btThanhToan.Width = Convert.ToInt32(pnFooter.Width / 3);
            btThanhToan.Height = Convert.ToInt32(pnFooter.Height * 0.7);
            btHuy.Location = new Point(Convert.ToInt32(pnFooter.Width*0.2),10);
            btThanhToan.Location = new Point(Convert.ToInt32((pnFooter.Width*0.2) + btHuy.Width+20),10);
        }
        private void pnHeadResize()
        {
            pnTitle.Width = pnHead.Width;
            pnTitle.Height = Convert.ToInt32(pnHead.Height / 3);
            pnImage.Width = Convert.ToInt32(pnHead.Width * 0.4);
            pnImage.Height = Convert.ToInt32(pnHead.Height * 0.6);
            pnSanPham.Width = Convert.ToInt32(pnHead.Width * 0.35);
            pnSanPham.Height = Convert.ToInt32(pnHead.Height * 0.6);
            pnCount.Width = Convert.ToInt32(pnHead.Width * 0.2);
            pnCount.Height = Convert.ToInt32(pnHead.Height * 0.6);
            pnTitle.Location = new Point(0,0);
            pnImage.Location = new Point(0,Convert.ToInt32(pnHead.Location.X+pnTitle.Height));
            pnSanPham.Location = new Point(pnImage.Width,Convert.ToInt32(pnHead.Location.X + pnTitle.Height));
            pnCount.Location = new Point(Convert.ToInt32(pnImage.Width+pnSanPham.Width), Convert.ToInt32(pnHead.Location.X + pnTitle.Height));
        }
        private void GioHangResize()
        {
            pnHead.Width = this.Width;
            flpnContain.Width = this.Width;
            pnFooter.Width = this.Width;
            pnHead.Height = Convert.ToInt32(this.Height * 0.3);
            flpnContain.Height = Convert.ToInt32(this.Height *0.55);
            pnFooter.Height = Convert.ToInt32(this.Height * 0.2);
            pnHead.Location = new Point(0, 0);
            flpnContain.Location = new Point(0, Convert.ToInt32(pnHead.Height + pnHead.Location.Y));
            pnFooter.Location = new Point(0, Convert.ToInt32(pnHead.Height + pnHead.Location.Y +flpnContain.Height));
        }
        private void btTruSL_Click(object sender, EventArgs e)
        {
            TruSL();
        }

        private void btCongSL_Click(object sender, EventArgs e)
        {
            CongSL();
        }
        private void CongSL()
        {
            sl = Convert.ToInt32(txtSoLuong.Text);
            if (sl >= 1)
            {
                sl += 1;
                TextChange(sl.ToString());
            }
            else
            {
                //Ngược Lại
                sl = 1;
                TextChange(sl.ToString());
               
            }
        }
        // Hàm Trừ Số Lượng
        private void TruSL()
        {
            sl = Convert.ToInt32(txtSoLuong.Text);
            if (sl >= 1)
            {
                //Điểu Kiện tối thiểu để có thể trừ số lượng là phải lớn hơn 1
                //khi nhấn nút thì biến sẽ trừ đi một giá trị
                // sau đó gán lại lbSoLuong bằng biến mới lưu giá trị mới
                sl -= 1;
                TextChange(sl.ToString());
            }
            else 
            {
                //Ngược Lại

            }
        }
        // Hàm Thay Đổi Số Lượng
        private void TextChange(string sl)
        {
            txtSoLuong.Text = sl; // gán giá trị mới cho lbSoLuong
        }

        
    }
}
