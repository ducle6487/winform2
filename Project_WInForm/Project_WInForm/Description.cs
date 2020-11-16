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
        //khoi tao GioHangDto , chua thong tin cua don hàng hien thi tren form nay
        GioHangDTO donhang = new GioHangDTO();

        //khoi tao productdto
        ProductDTO product = new ProductDTO();

        //khoi tao biến sizeBal trong class SizzeInforBAL
        SizeInfoBAL sizeBAL = new SizeInfoBAL();

        //bien kiem tra ton tai san pham trong gio hang
        bool isExistInList = false;

        //danh sach nut size
        List<Button> listBtnSize = new List<Button>();

        //bien chua form truoc do
        MainPage parent { get; set; }

        public Description()
        {
            InitializeComponent();
        }

        //khoi tao co dieu kien
        public Description(ProductDTO product, MainPage parent)
        {
            //toplevel
            this.SetTopLevel(true);
            InitializeComponent();
            //truyen vao cac thong tin da truyen khi khoi tao 
            this.product = product;
            pbxImage1.LoadAsync(product.LinkImg.ToString());//hien thi hinh san pham
            pbxImage1.SizeMode = PictureBoxSizeMode.Zoom;
            pbxBigImage.LoadAsync(product.LinkImg);
            pbxBigImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbxImage2.LoadAsync("http://artistclub.vn/upload/images/size%20tee(2).png");//hien thi hinh đo size
            pbxImage2.SizeMode = PictureBoxSizeMode.Zoom;
            this.parent = parent;//gan form truoc do 
            
        }

        //ham thuc thi khi load form
        private void Description_Load(object sender, EventArgs e)
        {
            //khoa resize
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            //tat cac nut tren goc phai form
            ControlBox = false;

            
            btTruSL.Enabled = false;

            //load cac default size và location cua cac component co trong form
            //lb1.Location = new Point(Convert.ToInt32(pnDescription.Location.X + (pnDescription.Height *0.17)),pnDescription.Height/18);
            SetupUIForm();
            setupUIPnlMain();
            setupUIPnlBigImg();
            setupUIPnlLeft();
            
            //so luong cua don hang default  = 1
            donhang.Soluong = Convert.ToInt32(lbSoLuong.Text);
            //thay doi gia tuy theo so luong 
            GiaChange(donhang.Soluong.ToString());

            //chon default nut dau tien trong danh sach chon size
            listBtnSize[0].BackColor = Color.Blue;
            donhang.Size = listBtnSize[0].Tag.ToString();
        }


        //ham thuc thi khi nhan chon 1 size
        private void btsize_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;

            //chuyen tat ca cac nut thành mau den
            foreach(Button item in listBtnSize)
            {
                item.BackColor = Color.Black;
                item.ForeColor = Color.White;
            }

            //chuyen nut vua chon thanh mau xanh
            btn.BackColor = Color.Blue;
            //truyen size lay tu tag cua btn truyen vao size cua don hang don hang
            donhang.Size = btn.Tag.ToString();
            
        }


        //ham thuc thi khi nhan nut them vao gio hang
        private void btThemVaoGio_Click(object sender, EventArgs e)
        {

            
            //gan dongia, link hinh, ten sp, vao donhang 
            donhang.Dongia = product.Dongia;
            donhang.ImgLink = product.LinkImg;
            donhang.ProductName = product.ProductName;

            //kiem tra xem don hang nay da c trong gio hang chua
            for (int i = 0; i < parent.ListGioHang.Count; i++)
            {
                if(donhang.ProductName == parent.ListGioHang[i].ProductName && donhang.Size == parent.ListGioHang[i].Size)
                {
                    //neu co thi cong so luong vua dat vao so luong cua san pham co trong don hang 
                    isExistInList = true;
                    parent.ListGioHang[i].Soluong += donhang.Soluong;
                }
            }
            if(isExistInList == false)
            {
                //neu chua ton tai thi them binh thuong
                parent.ListGioHang.Add(donhang);
            }
            
            //tat form va enable form truoc do
            parent.Enabled = true;
            parent.reloadSoluong();
            this.Close();


        }

        //thuc thi khi nhan nut tiep tuc mua sam
        private void btTiepTucMuaSam_Click(object sender, EventArgs e)
        {
            //tat form va enable form truoc do
            parent.Enabled = true;
            this.Close();
        }


        //thuc thi khi cong sl
        private void btCongSL_Click(object sender, EventArgs e)
        {
            CongSL(); // Hàm Cộng Số Lượng
        }

        //ham thuc thi khi tru so luong
        private void btTruSL_Click(object sender, EventArgs e)
        {
            TruSL(); // Hàm Trừ Số Lượng

        }

        //thuc thi khi nhan vao hinh thu nhat
        private void pbxImage1_Click(object sender, EventArgs e)
        {

            pbxBigImage.LoadAsync(product.LinkImg);

        }

        //thuc thi khi nhan vao hinh thu 2
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
                //neu don hang co so luong lon hon 1 thi tang them 1 va cap nhat so luong len UI
                donhang.Soluong += 1;
                TextChange(donhang.Soluong.ToString());
                GiaChange(donhang.Soluong.ToString());
            }
            else
            {
                //Ngược Lại thi so luong = 1
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
                // sau đó cap nhat thong tin so luong len UI
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
            //thay doi gia bang don gia * sl
            donhang.Dongia = product.Dongia; 
            lbGia.Text = (Convert.ToDouble(product.Dongia) * Convert.ToInt32(sl)).ToString(); // gán lại giá trị mới cho lbGia
        }

        
        //ham cai dat height width va location
        private void SetupUIForm()
        {
            //pnldes co chieu cao = 30% chieu cao form, width bang form width
            //location tại ben tren + 10
            pnDescription.Width = this.Width;
            pnDescription.Height = Convert.ToInt32(this.Height * 0.3);
            pnDescription.Location = new Point(0, pnMain.Height + 10);
            //panelMain la phan con lai
            pnMain.Width = this.Width;
            pnMain.Height = Convert.ToInt32(this.Height * 0.65);
            pnMain.Location = new Point(0, 0);

            //tao 1 danh sach lay thong tin cac size
            List<string> size = sizeBAL.getSize();

            for(int i = 0; i < size.Count; i++)
            {
                //tao 1 nut gan tag bang size thu i trong listSize
                //hien thi size thu i trong litsize len button
                //height = width = fpnl width / 4
                //nhan nut goi ham btsize_click
                //mau nen bang mau den
                Button btn = new Button();
                btn.Tag = size[i];
                btn.Text = size[i];
                btn.Width = btn.Height = Convert.ToInt32(fpnlSize.Width / 4);
                listBtnSize.Add(btn);
                btn.Click += btsize_Click;
                btn.BackColor = Color.Black;
                btn.ForeColor = Color.White;
                //them nut do vao fpnl
                fpnlSize.Controls.Add(btn);
            }

        }
        
        //setup size pnlmain
        private void setupUIPnlMain()
        {
            //pnlBigImg cao bang mainPanel, ngang = 80% pnaelmain
            pnBigImage.Width = Convert.ToInt32(pnMain.Width * 0.8);
            pnBigImage.Height = pnMain.Height;
            pnBigImage.Location = new Point(Convert.ToInt32((pnMain.Location.X) + (pnMain.Width / 6)),pnMain.Location.Y);
            
        }
        //hàm setup giao diện cho panel bên cái
        private void setupUIPnlLeft()
        {
            //pnlLeft tao bằng pnlImage,ngang = form.width - pnImage.width
            pnlLeft.Height = pnBigImage.Height;
            pnlLeft.Width = this.Width - pnBigImage.Width;
            //pnlImage1 chieu cao bang pnlLeft.heigth*0.3,width = 70% pnlLeft
            pbxImage1.Width = pbxImage2.Width = Convert.ToInt32(pnlLeft.Width * 0.7);
            pbxImage1.Height = pbxImage2.Height = Convert.ToInt32(pnlLeft.Height * 0.3);
            // chỉnh vị trí của pnlImage1 và pnlImage 2
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
