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
using BAL;

namespace Project_WInForm
{
    
    public partial class Description : Form
    {

        GioHangDTO donhang = new GioHangDTO();

        ProductDTO product = new ProductDTO();

        SizeInfoBAL sizeBAL = new SizeInfoBAL();

        bool isExistInList = false;

        List<Button> listBtnSize = new List<Button>();

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
            SetupUIForm();
            setupUIPnlMain();
            setupUIPnlBigImg();
            setupUIPnlLeft();
            donhang.Soluong = Convert.ToInt32(lbSoLuong.Text);
            GiaChange(donhang.Soluong.ToString());

            listBtnSize[0].BackColor = Color.Blue;
            donhang.Size = listBtnSize[0].Tag.ToString();
        }


        private void btsize_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;

            foreach(Button item in listBtnSize)
            {
                item.BackColor = Color.Black;
                item.ForeColor = Color.White;
            }

            btn.BackColor = Color.Blue;
            donhang.Size = btn.Tag.ToString();
            
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
       
        //Hàm khi Tăng số lượng hay giảm số lượng thì giá sẽ giảm hoặc tăng theo
        private void GiaChange(string sl)
        {
            
            donhang.Dongia = product.Dongia; // truyền giá trong sql server vào
            lbGia.Text = (Convert.ToDouble(product.Dongia) * Convert.ToInt32(sl)).ToString(); // gán lại giá trị mới cho lbGia
        }

        
        private void SetupUIForm()
        {
            pnDescription.Width = this.Width;
            pnDescription.Height = Convert.ToInt32(this.Height * 0.3);
            pnDescription.Location = new Point(0, pnMain.Height + 10);
            pnMain.Width = this.Width;
            pnMain.Height = Convert.ToInt32(this.Height * 0.65);
            pnMain.Location = new Point(0, 0);

            List<string> size = sizeBAL.getSize();
            for(int i = 0; i < size.Count; i++)
            {
                Button btn = new Button();
                btn.Tag = size[i];
                btn.Text = size[i];
                btn.Width = btn.Height = Convert.ToInt32(fpnlSize.Width / 4);
                listBtnSize.Add(btn);
                btn.Click += btsize_Click;
                btn.BackColor = Color.Black;
                btn.ForeColor = Color.White;
                fpnlSize.Controls.Add(btn);
            }

        }
        
        private void setupUIPnlMain()
        {
            pnBigImage.Width = Convert.ToInt32(pnMain.Width * 0.8);
            pnBigImage.Height = pnMain.Height;
            pnBigImage.Location = new Point(Convert.ToInt32(pnMain.Location.X + (pnMain.Width / 6)),pnMain.Location.Y);
            
        }
        
        private void setupUIPnlLeft()
        {

            pnlLeft.Height = pnBigImage.Height;
            pnlLeft.Width = this.Width - pnBigImage.Width;

            pbxImage1.Width = pbxImage2.Width = Convert.ToInt32(pnlLeft.Width * 0.7);
            pbxImage1.Height = pbxImage2.Height = Convert.ToInt32(pnlLeft.Height * 0.3);

            pbxImage1.Location = new Point(Convert.ToInt32(pnlLeft.Width * 0.15), Convert.ToInt32(pnlLeft.Height * 0.15));
            pbxImage2.Location = new Point(pbxImage1.Location.X, Convert.ToInt32((pnlLeft.Height * 0.55)));


        }
        private void setupUIPnlBigImg()
        {
            //pbxBigImage thêm dữ liệu vào
            pbxBigImage.Width = Convert.ToInt32(pnBigImage.Width * 0.8);
            pbxBigImage.Height = Convert.ToInt32(pnBigImage.Height * 0.8);
            pnBigImage.Controls.Add(pbxBigImage);
            pbxBigImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

    }
}
