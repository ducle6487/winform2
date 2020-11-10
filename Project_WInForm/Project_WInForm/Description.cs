﻿using System;
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
    
    public partial class Description : Form
    {

        GioHangDTO donhang = new GioHangDTO();

        ProductDTO product = new ProductDTO();

        bool isExistInList = false;

        MainPage parent { get; set; }

        public Description()
        {
            InitializeComponent();
        }

        public Description(ProductDTO product, MainPage parent)
        {
            this.SetTopLevel(true);
            InitializeComponent();
            this.product = product;
            pbxImage1.LoadAsync(product.LinkImg.ToString());
            pbxImage1.SizeMode = PictureBoxSizeMode.Zoom;
            pbxBigImage.LoadAsync(product.LinkImg);
            pbxBigImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbxImage2.LoadAsync("http://artistclub.vn/upload/images/size%20tee(2).png");
            pbxImage2.SizeMode = PictureBoxSizeMode.Zoom;
            this.parent = parent;
            
        }

        private void Description_Load(object sender, EventArgs e)
        {

            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            ControlBox = false;

            btTruSL.Enabled = false;

            //lb1.Location = new Point(Convert.ToInt32(pnDescription.Location.X + (pnDescription.Height *0.17)),pnDescription.Height/18);
            DescriptionResize();
            pnDescriptionResize();
            pnMainResize();
            pnBigImageResize();
            ClickSizeM();
            donhang.Soluong = Convert.ToInt32(lbSoLuong.Text);
            GiaChange(donhang.Soluong.ToString());
        }

        private void btsizeXL_Click(object sender, EventArgs e)
        {
            ClickSizeXL();// Hàm Thay Đổi màu chữ,nền Khi Click Vào btSizeXL
            
        }

        private void btsizeL_Click(object sender, EventArgs e)
        {
            ClickSizeL();// Hàm Thay Đổi màu chữ,nền Khi Click Vào btSizeL
            
        }

        private void btsizeM_Click(object sender, EventArgs e)
        {
            ClickSizeM(); // Hàm Thay Đổi màu chữ,nền Khi Click Vào btSizeM
            
        }

        private void btThemVaoGio_Click(object sender, EventArgs e)
        {

            

            donhang.Dongia = product.Dongia;
            donhang.ImgLink = product.LinkImg;
            donhang.ProductName = product.ProductName;

            for (int i = 0; i < parent.ListGioHang.Count; i++)
            {
                if(donhang.ProductName == parent.ListGioHang[i].ProductName && donhang.Size == parent.ListGioHang[i].Size)
                {
                    isExistInList = true;
                    parent.ListGioHang[i].Soluong += donhang.Soluong;
                }
            }
            if(isExistInList == false)
            {
                parent.ListGioHang.Add(donhang);
            }
            
            parent.Enabled = true;
            parent.reloadSoluong();
            this.Close();


        }
        private void btTiepTucMuaSam_Click(object sender, EventArgs e)
        {
            parent.Enabled = true;
            this.Close();
        }

        private void btCongSL_Click(object sender, EventArgs e)
        {
            CongSL(); // Hàm Cộng Số Lượng
        }

        private void btTruSL_Click(object sender, EventArgs e)
        {
            TruSL(); // Hàm Trừ Số Lượng

        }

        private void pbxImage1_Click(object sender, EventArgs e)
        {

            pbxBigImage.LoadAsync(product.LinkImg);

        }
        private void pbxImage2_Click(object sender, EventArgs e)
        {
            pbxBigImage.LoadAsync("http://artistclub.vn/upload/images/size%20tee(2).png");
        }
        // Hàm Cộng Số Lượng
        private void CongSL()
        {
            btTruSL.Enabled = true;
            donhang.Soluong = Convert.ToInt32(lbSoLuong.Text);
            if (donhang.Soluong >= 1)
            {
                donhang.Soluong += 1;
                TextChange(donhang.Soluong.ToString());
                GiaChange(donhang.Soluong.ToString());
            }
            else
            {
                //Ngược Lại
                donhang.Soluong = 1;
                TextChange(donhang.Soluong.ToString());
                GiaChange(donhang.Soluong.ToString());
            }
        }
        // Hàm Trừ Số Lượng
        private void TruSL()
        {
            donhang.Soluong = Convert.ToInt32(lbSoLuong.Text);
            if (donhang.Soluong > 1)
            {
                
                //Điểu Kiện tối thiểu để có thể trừ số lượng là phải lớn hơn 1
                //khi nhấn nút thì biến sẽ trừ đi một giá trị
                // sau đó gán lại lbSoLuong bằng biến mới lưu giá trị mới
                donhang.Soluong -= 1;
                TextChange(donhang.Soluong.ToString());
                GiaChange(donhang.Soluong.ToString());
                if(donhang.Soluong == 1)
                {
                    btTruSL.Enabled = false;
                }
            }
            else
            {
                //Ngược Lại
                
            }
        }
        // Hàm Thay Đổi Số Lượng
        private void TextChange(string sl)
        {
            lbSoLuong.Text = sl; // gán giá trị mới cho lbSoLuong
        }
        // hàm thay đổi màu cho btSizeM khi xảy ra hiện tượng Click chuột vào button
        private void ClickSizeM()
        {
            btSizeM.ForeColor = Color.Aqua;// thay đổi màu chữ cho btSizeM
            btSizeM.BackColor = Color.Blue;// thay đổi nền cho btSizeM
            btSizeL.ForeColor = SystemColors.ButtonHighlight;// Gán màu chữ cho btSizeL khi hiện tượng click btSizeM xảy ra
            btSizeL.BackColor = Color.Black;// gán màu nền cho btSizeL khi hiện tượng click btSizeM xảy ra
            btSizeXL.ForeColor = SystemColors.ButtonHighlight;// Gán màu chữ cho btSizeXL khi hiện tượng click btSizeM xảy ra
            btSizeXL.BackColor = Color.Black;// gán màu nền cho btSizeXL khi hiện tượng click btSizeM xãy ra
            donhang.Size = "M";
        }
        // hàm thay đổi màu cho btSizeL khi xảy ra hiện tượng Click chuột vào button
        private void ClickSizeL()
        {
            donhang.Size = "L";
            btSizeL.ForeColor = Color.Aqua;// thay đổi màu chữ cho btSizeL
            btSizeL.BackColor = Color.Blue;// thay đổi nền cho btSizeL
            btSizeXL.ForeColor = SystemColors.ButtonHighlight;// Gán màu chữ cho btSizeXL khi hiện tượng click btSizeL xảy ra
            btSizeXL.BackColor = Color.Black;// gán màu nền cho btSizeXL khi hiện tượng click btSizeL xãy ra
            btSizeM.ForeColor = SystemColors.ButtonHighlight;// Gán màu chữ cho btSizeM khi hiện tượng click btSizeL xảy ra
            btSizeM.BackColor = Color.Black;// gán màu nền cho btSizeM khi hiện tượng click btSizeL xãy ra
        }
        // hàm thay đổi màu cho btSizeXL khi xảy ra hiện tượng Click chuột vào button
        private void ClickSizeXL()
        {
            btSizeXL.ForeColor = Color.Aqua;// thay đổi màu chữ cho btSizeXL
            btSizeXL.BackColor = Color.Blue; // thay đổi nền cho btSizeXL
            btSizeL.ForeColor = SystemColors.ButtonHighlight; // Gán màu chữ cho btSizeL khi hiện tượng click btSizeXL xảy ra
            btSizeL.BackColor = Color.Black; // gán màu nền cho btSizeL khi hiện tượng click btSizeXL xãy ra
            btSizeM.ForeColor = SystemColors.ButtonHighlight;// Gán màu chữ cho btSizeM khi hiện tượng click btSizeXL xảy ra
            btSizeM.BackColor = Color.Black; // gán màu nền cho btSizeM khi hiện tượng click btSizeXL xãy ra
            donhang.Size = "XL";
        }
        //Hàm khi Tăng số lượng hay giảm số lượng thì giá sẽ giảm hoặc tăng theo
        private void GiaChange(string sl)
        {
            
            donhang.Dongia = product.Dongia; // truyền giá trong sql server vào
            lbGia.Text = (Convert.ToDouble(product.Dongia) * Convert.ToInt32(sl)).ToString(); // gán lại giá trị mới cho lbGia
        }

        
        private void DescriptionResize()
        {
            pnDescription.Width = this.Width;
            pnDescription.Height = Convert.ToInt32(this.Height * 0.3);
            pnDescription.Location = new Point(0, pnMain.Height + 10);
            pnMain.Width = this.Width;
            pnMain.Height = Convert.ToInt32(this.Height * 0.65);
            pnMain.Location = new Point(0, 0);
        }
        private void pnDescriptionResize()
        {
             btSizeM.Width = Convert.ToInt32(pnDescription.Width /20);
             btSizeM.Height = Convert.ToInt32(pnDescription.Height / 6);
             btSizeL.Width = Convert.ToInt32(pnDescription.Width / 20);
             btSizeL.Height = Convert.ToInt32(pnDescription.Height / 6);
             btSizeXL.Width = Convert.ToInt32(pnDescription.Width / 20);
             btSizeXL.Height = Convert.ToInt32(pnDescription.Height / 6);
             lbGia.Width = Convert.ToInt32(pnDescription.Width / 2.3);
            lbGia.Height = Convert.ToInt32(pnDescription.Height / 6);
            btCongSL.Width = Convert.ToInt32(pnDescription.Width / 19.5);
            btCongSL.Height = Convert.ToInt32(pnDescription.Height / 6); ;
            btTruSL.Width = Convert.ToInt32(pnDescription.Width / 19.5);
            btTruSL.Height = Convert.ToInt32(pnDescription.Height / 6); ;
            lbSoLuong.Width = Convert.ToInt32(pnDescription.Width / 19.5);
            lbSoLuong.Height = Convert.ToInt32(pnDescription.Height / 6.8); ;
            btThemVaoGio.Width = Convert.ToInt32(pnDescription.Width/2);
            btThemVaoGio.Height = Convert.ToInt32(pnDescription.Height/4);
            btTiepTucMuaSam.Width = Convert.ToInt32(pnDescription.Width / 3);
            btTiepTucMuaSam.Height = Convert.ToInt32(pnDescription.Height / 4);
            btSizeM.Location = new Point(Convert.ToInt32(pnDescription.Location.X + (pnDescription.Height *0.17)),pnDescription.Height/18);
            btSizeL.Location = new Point(Convert.ToInt32(pnDescription.Location.X + (pnDescription.Height * 0.2)+btSizeM.Width), pnDescription.Height / 18);
            btSizeXL.Location =new Point(Convert.ToInt32(pnDescription.Location.X + (pnDescription.Height * 0.23)+btSizeM.Width+btSizeL.Width), pnDescription.Height / 18);
            lbGia.Location =new Point(Convert.ToInt32(pnDescription.Location.X + (pnDescription.Height * 0.25)+btSizeM.Width+btSizeXL.Width+btSizeL.Width ), pnDescription.Height / 18);
            lbSoLuong.Location =new Point(Convert.ToInt32(pnDescription.Location.X + (pnDescription.Height * 0.41)+btSizeM.Width+btSizeXL.Width+btSizeL.Width+ lbGia.Width + btTruSL.Width-2), pnDescription.Height / 18);
            btTruSL.Location =new Point(Convert.ToInt32(pnDescription.Location.X + (pnDescription.Height * 0.4)+btSizeM.Width+btSizeXL.Width+btSizeL.Width+lbGia.Width), pnDescription.Height / 18);
            btCongSL.Location =new Point(Convert.ToInt32(pnDescription.Location.X + (pnDescription.Height * 0.39)+btSizeM.Width+btSizeXL.Width+btSizeL.Width+ lbGia.Width+btTruSL.Width+lbSoLuong.Width), pnDescription.Height / 18);
            btThemVaoGio.Location = new Point(Convert.ToInt32(pnDescription.Location.X + (btThemVaoGio.Width * 0.45)), pnDescription.Height / 3);
            btTiepTucMuaSam.Location = new Point(Convert.ToInt32(pnDescription.Location.X + (btTiepTucMuaSam.Width * 0.9)), Convert.ToInt32(pnDescription.Height * 0.68));
        }
        private void pnMainResize()
        {
            pnBigImage.Width = Convert.ToInt32(pnMain.Width * 0.8);
            pnBigImage.Height = pnMain.Height;
            pnBigImage.Location = new Point(Convert.ToInt32(pnMain.Location.X + (pnMain.Width / 6)),pnMain.Location.Y);
            
        }
        
        private void pnlLeftResize()
        {

            pnlLeft.Height = pnBigImage.Height;
            pnlLeft.Width = this.Width - pnBigImage.Width;

            pbxImage1.Width = pbxImage2.Width = Convert.ToInt32(pnlLeft.Width * 0.7);
            pbxImage1.Height = pbxImage2.Height = Convert.ToInt32(pnlLeft.Height * 0.3);

            pbxImage1.Location = new Point(Convert.ToInt32(pnlLeft.Width * 0.15), Convert.ToInt32(pnlLeft.Height * 0.15));
            pbxImage2.Location = new Point(pbxImage1.Location.X, Convert.ToInt32((pnlLeft.Height * 0.55)));


        }
        private void pnBigImageResize()
        {
            //pbxBigImage thêm dữ liệu vào
            pbxBigImage.Width = Convert.ToInt32(pnBigImage.Width * 0.8);
            pbxBigImage.Height = Convert.ToInt32(pnBigImage.Height * 0.8);
            pnBigImage.Controls.Add(pbxBigImage);
            pbxBigImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

    }
}
