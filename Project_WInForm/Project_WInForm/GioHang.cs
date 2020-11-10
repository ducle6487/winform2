using BAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
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

        PaymentBAL paymentBAL = new PaymentBAL();

        ProductBAL productBAL = new ProductBAL();

        List<ProductDTO> listProduct = new List<ProductDTO>();

        List<string> listProductID = new List<string>();

        public GioHang(MainPage parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        //list sản phẩm tạm dùng để lưu thông tin cần xóa khi nhấn xóa 1 don hàng trong giỏ
        List<GioHangDTO> listGioHangTemp = new List<GioHangDTO>();


        List<Label> listLabelSoLuong = new List<Label>();

        List<Label> listLabelPrice = new List<Label>();

        MainPage parent {get;set;}


        private void GioHang_Load(object sender, EventArgs e)
        {
            
            resizeForm();
            setupUIFlowlayoutPanel();
            listGioHangTemp = parent.ListGioHang;
            reloadTotalPrice();
            listProduct = productBAL.GetDataProduct();
        }


        private void setupUIFlowlayoutPanel()
        {

            
            for(int i = 0; i < parent.ListGioHang.Count; i++)
            {

                Panel pnlCover = new Panel();

                pnlCover.Height = Convert.ToInt32(fpnlSanPham.Height / 4.25);
                pnlCover.Width = this.Width;
                pnlCover.BackColor = Color.White;

                PictureBox ptbImage = new PictureBox();
                pnlCover.Controls.Add(ptbImage);
                ptbImage.LoadAsync(parent.ListGioHang[i].ImgLink);
                ptbImage.SizeMode = PictureBoxSizeMode.Zoom;
                pnlCover.BackColor = Color.White;
                ptbImage.Height = pnlCover.Height;
                ptbImage.Width = Convert.ToInt32(pnlCover.Width * 0.2);
                ptbImage.Location = new Point(0, 0);


                Label lbName = new Label();
                pnlCover.Controls.Add(lbName);
                lbName.Text = parent.ListGioHang[i].ProductName;
                lbName.ForeColor = Color.Black;
                //lbName.MaximumSize = new System.Drawing.Size(Convert.ToInt32(this.Width * 0.4), lbName.Height);
                lbName.AutoEllipsis = true;
                lbName.AutoSize = true;
                lbName.Location = new Point(ptbImage.Width + 30, Convert.ToInt32((pnlCover.Height / 2) - lbName.Height - 15));
                lbName.Font = new Font("Arial", 16, FontStyle.Regular);

                Label lbDelete = new Label();
                pnlCover.Controls.Add(lbDelete);
                lbDelete.ForeColor = Color.Red;
                lbDelete.BackColor = Color.White;
                lbDelete.Font = new Font("Arial", 9, FontStyle.Italic);
                lbDelete.Height = 30;
                lbDelete.Width = 70;
                lbDelete.Location = new Point(lbName.Location.X, Convert.ToInt32(pnlCover.Height / 2) + 15);
                lbDelete.Text = "Xóa";
                lbDelete.Tag = i.ToString();
                lbDelete.Click += XoaSanPham_click;

                Label lbGia = new Label();
                pnlCover.Controls.Add(lbGia);
                listLabelPrice.Add(lbGia);
                lbGia.Text = parent.ListGioHang[i].Size + "  |  " + (Convert.ToDouble(parent.ListGioHang[i].Dongia) * parent.ListGioHang[i].Soluong).ToString();
                lbGia.Location = new Point(Convert.ToInt32((this.Width * 0.77) - (lbGia.Width / 2)),Convert.ToInt32((pnlCover.Height / 4) - (lbGia.Height / 2)));
                lbGia.Font = new Font("Arial", 13, FontStyle.Regular);
                lbGia.AutoEllipsis = true;
                lbGia.AutoSize = true;



                Label lbSoLuong = new Label();
                listLabelSoLuong.Add(lbSoLuong);
                pnlCover.Controls.Add(lbSoLuong);
                lbSoLuong.Text = parent.ListGioHang[i].Soluong.ToString();
                lbSoLuong.Font = new Font("Arial", 11, FontStyle.Bold);
                lbSoLuong.Location = new Point(Convert.ToInt32(lbGia.Location.X + (lbGia.Width / 2)), Convert.ToInt32((pnlCover.Height * 0.65)));
                lbSoLuong.Width = 35;
                lbSoLuong.Height = 28;
                lbSoLuong.BackColor = Color.White;
                lbSoLuong.TextAlign = ContentAlignment.MiddleCenter;
                lbSoLuong.BorderStyle = BorderStyle.FixedSingle;


                Button btPlus = new Button();
                pnlCover.Controls.Add(btPlus);
                btPlus.Width = btPlus.Height = 30;
                btPlus.Font = new Font("Arial", 13, FontStyle.Bold);
                btPlus.Text = "+";
                btPlus.Location = new Point(lbSoLuong.Location.X + lbSoLuong.Width, lbSoLuong.Location.Y-1);
                btPlus.Tag = i.ToString();
                btPlus.Click += PlusSoLuong_click;

                Button btMinus = new Button();
                pnlCover.Controls.Add(btMinus);
                btMinus.Width = btMinus.Height = 30;
                btMinus.Font = new Font("Arial", 13, FontStyle.Bold);
                btMinus.Text = "-";
                btMinus.Location = new Point(lbSoLuong.Location.X - btMinus.Width, lbSoLuong.Location.Y-1);
                btMinus.Tag = i.ToString();
                btMinus.Click += MinusSoLuong_click;

                fpnlSanPham.Controls.Add(pnlCover);

            }


        }

        private void XoaSanPham_click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có muốn xóa chứ ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Label lb = sender as Label;

                parent.ListGioHang.RemoveAll(item => item.ProductName == listGioHangTemp[Convert.ToInt32(lb.Tag)].ProductName && item.Size == listGioHangTemp[Convert.ToInt32(lb.Tag)].Size);
                reloadTotalPrice();
                fpnlSanPham.Controls.RemoveAt(Convert.ToInt32(lb.Tag));
            }

            

        }

        private void reloadPriceAndAmount(Button bt)
        {
            listLabelSoLuong[Convert.ToInt32(bt.Tag)].Text = parent.ListGioHang[Convert.ToInt32(bt.Tag)].Soluong.ToString();
            listLabelPrice[Convert.ToInt32(bt.Tag)].Text = parent.ListGioHang[Convert.ToInt32(bt.Tag)].Size + "  |  " + (Convert.ToDouble(parent.ListGioHang[Convert.ToInt32(bt.Tag)].Dongia) * parent.ListGioHang[Convert.ToInt32(bt.Tag)].Soluong).ToString();
        }

        private void reloadTotalPrice()
        {

            double kq = 0;
            foreach (GioHangDTO donhang in parent.ListGioHang)
            {
                kq += Convert.ToDouble(donhang.Dongia) * donhang.Soluong;
            }

            lbTotalPrice.Text = "Thành Tiền: " + kq.ToString();

        }

        private void MinusSoLuong_click(object sender, EventArgs e)
        {

            Button bt = sender as Button;

            if (parent.ListGioHang[Convert.ToInt32(bt.Tag)].Soluong > 1)
            {


                parent.ListGioHang[Convert.ToInt32(bt.Tag)].Soluong -= 1;
                reloadPriceAndAmount(bt);
                reloadTotalPrice();
            }
            else
            {
                //Ngược Lại

            }

        }

        private void PlusSoLuong_click(object sender, EventArgs e)
        {

            Button bt = sender as Button;
            if (parent.ListGioHang[Convert.ToInt32(bt.Tag)].Soluong >= 1)
            {
                parent.ListGioHang[Convert.ToInt32(bt.Tag)].Soluong += 1;
                reloadPriceAndAmount(bt);
                reloadTotalPrice();
            }


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

        private void btBack_Click(object sender, EventArgs e)
        {

            parent.Enabled = true;
            parent.reloadSoluong();
            this.Close();
        }

        private void btPay_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thanh toán chứ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DateTime currentDay = DateTime.Today;

                string BillID = paymentBAL.generateBill(parent.infoUser.AccID, currentDay);
                getListProductID();

                for(int i = 0; i < parent.ListGioHang.Count; i++)
                {
                    double tonggia = parent.ListGioHang[i].Soluong * Convert.ToDouble(parent.ListGioHang[i].Dongia);

                    paymentBAL.AddBillIncludeInfo(BillID, listProductID[i], parent.ListGioHang[i].Soluong, parent.ListGioHang[i].Size, tonggia.ToString());
                }

                

                parent.Enabled = true;
                parent.ListGioHang.Clear();
                parent.reloadSoluong();
                this.Close();
                MessageBox.Show("Đơn Hàng đã được gửi đi. Vui lòng xác nhận khi được gọi điện.");
            }
        }

        private void getListProductID()
        {
            foreach (GioHangDTO donhang in parent.ListGioHang)
            {
                foreach (ProductDTO product in listProduct)
                {
                    if(donhang.ProductName == product.ProductName)
                    {
                        listProductID.Add(product.ProductID);
                    }
                }
            }
        }
    }
}
