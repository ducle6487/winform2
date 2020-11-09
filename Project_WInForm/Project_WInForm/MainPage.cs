using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BAL;
using System.Windows.Forms.VisualStyles;

namespace Project_WInForm
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        public MainPage(string username)
        {
            InitializeComponent();
            this.userName = username;
            
        }

        //danh sách chứa các mặt hàng thệm vào giỏ hàng
        List<ProductDTO> ListPayment = new List<ProductDTO>();

        
        string giohang;
        
        //bien nhan accid ma user da dang nhap
        public string userName = "";

        //bien chua thong tin user da dang nhap
        InfoAccDTO infoUser;

        //bien chua AccountBAL
        AccountBAL bal = new AccountBAL();
        //bien khoi tao producBAL
        ProductBAL productBAL = new ProductBAL();

        //khoi tao hinh xe day hang va label soluong sp trong panel phải của panel toolbox
        PictureBox ptbGioHang = new PictureBox();

        Label lbGioHang = new Label();

        List<ProductDTO> ProductList = new List<ProductDTO>();

        private void MainPage_Resize(object sender, EventArgs e)
        {

            resize();


        }

        public void themSanPham(ProductDTO mathang)
        {
            ListPayment.Add(mathang);
        }

        public void reloadSoluong()
        {
            giohang = "Giỏ Hàng: " + ListPayment.Count;
            lbGioHang.Text = giohang;
        }

        public void reloadInfoUser()
        {
            infoUser = bal.GetInfoFromUsername(userName);
            lbInfo.Text = "Tên KH: " + infoUser.TenKH;//nhớ thay như vậy trong setupUI
            
            //nhớ gọi hàm này trong formload
        }

        //hàm load form
        private void MainPage_Load(object sender, EventArgs e)
        {
            Console.WriteLine("username"+userName);
            //lay thong tin user từ accid da dang nhap
            reloadInfoUser();
            this.Width = 1060;
            resize();//hàm resize cac component
            
            //thiet lap UI (user interface)
            SetupUI();

            //cap nhat so luong sp trong gio hang
            reloadSoluong();

            resizeToolLeft();

        }

        //ham thiet lap kich thuoc cho cac component
        private void resize()
        {
            //setup chieu cao va chieu rong cho panel
            pnlToolBox.Height = Convert.ToInt32(this.Height * 0.15);
            pnlToolBox.Width = this.Width;
            fpnlProduct.Height = Convert.ToInt32(this.Height * 0.83);
            fpnlProduct.Width = this.Width;
            //chieu cao chieu rong cho labeltitle
            lbTittle.Width = Convert.ToInt32(this.Width / 4);
            lbTittle.Height = pnlToolBox.Height;
            lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lbTittle.Font = new Font("Arial", Convert.ToInt32(pnlToolBox.Height * 0.2), FontStyle.Regular);//chinh font lon theo kich thuoc cua form
            lbTittle.Location = new Point(Convert.ToInt32((pnlToolBox.Width / 4)+(pnlToolBox.Width / 8)), pnlToolBox.Location.Y);//vi tri cua title o giua màn hình

            //chieu cao chieu rong cho panel trái trong panel toolbox
            pnlToolLeft.Width = lbTittle.Width;
            pnlToolLeft.Location = new Point(20, 20);
            pnlToolLeft.Height = pnlToolBox.Height - 40;
            //chieu cao chieu rong cho panel phải trong panel toolbox
            pnlToolRight.Height = Convert.ToInt32(pnlToolBox.Height/3);
            pnlToolRight.BorderStyle = BorderStyle.FixedSingle;
            pnlToolRight.Width = Convert.ToInt32(pnlToolBox.Width /8);
            pnlToolRight.Location = new Point(Convert.ToInt32((pnlToolBox.Width / 2) + (pnlToolBox.Width / 3.25) + 20), Convert.ToInt32(pnlToolBox.Height / 4));

            
        }

        //setup gia dien nguoi dùng (phần danh sách sản phẩm trong panel main)
        private void SetupUI()
        {
            //lay thong tin tat ca sản pham
            ProductList = productBAL.GetDataProduct();
            //duyen tat ca san pham trong danh sach
            for (int i = 0; i < ProductList.Count; i++)
            {

                //danh sach co hinh dang nhu sau
                //la 1 flowlayoutpanel
                //gom nhieu panel nhu the nay

                /*---------------------
                 * -   picturebox     -
                 * -                  -
                 * -                  -
                 * -                  -
                 * -                  -
                 * --------------------
                 * -    label ten sp  -
                 * --------------------
                 * -     label gia    -
                 * --------------------*/

                //tao 1 panel chua ptb, label name, label gia
                Panel pnl = new Panel();
                //dinh dang height width
                pnl.Width = Convert.ToInt32(250);
                pnl.Height = Convert.ToInt32(fpnlProduct.Height / 2);

                
                
                //tao moi 1 ptb va dinh dang height width
                PictureBox ptb = new PictureBox();
                ptb.Location = pnl.Location;
                ptb.Height = Convert.ToInt32(pnl.Height * 0.7);
                ptb.Width = pnl.Width;
                ptb.SizeMode = PictureBoxSizeMode.Zoom;
                //load hình với sizemode là zoom
                ptb.LoadAsync(ProductList[i].LinkImg);
                //gan tag bang vi tri cua no trong danh sach sản phẩm
                ptb.Tag = i.ToString();
                //add ptb vao panel 
                pnl.Controls.Add(ptb);
                //tao action click vao hình se hien len thong tin chi tiet
                ptb.Click += Picturebox_click;
                //tao 1 label name va dinh vi vi tri x = bang voi vi tri x cua panel cha, y= chieu cao cua picturebox , height va width
                Label lbName = new Label();
                lbName.Location = new Point(Convert.ToInt32(pnl.Location.X), pnl.Location.Y + ptb.Height);
                lbName.Width = pnl.Width;
                lbName.Height = Convert.ToInt32(pnl.Height * 0.15);
                lbName.Text = ProductList[i].ProductName;//lay ten sản pham tu i trong danh sach sp
                lbName.Font = new Font("Arial", 15, FontStyle.Regular);
                lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; // alight center
                pnl.Controls.Add(lbName);//them lbname vao panel
                //label gia tương tự . có vấn đề liên hệ Lê Anh Đức gmail: ducle6487@gmail.com
                Label lbPrice = new Label();
                lbPrice.Location = new Point(Convert.ToInt32(pnl.Location.X), pnl.Location.Y + ptb.Height + lbName.Height);
                lbPrice.Width = pnl.Width;
                lbPrice.Height = Convert.ToInt32(pnl.Height * 0.15);
                lbPrice.Text = ProductList[i].Dongia;
                lbPrice.Font = new Font("Arial", 13, FontStyle.Regular);
                lbPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                pnl.Controls.Add(lbPrice);
                //add panel 1 san pham vao flowlayoutPanel
                fpnlProduct.Controls.Add(pnl);
            }

            //thiet lap label hien ten user , height width location nam ben trái center vertical so voi panel toolbox
            //button xem thong tin user nam ben duoi ten user
            
            


            //hinh anh toolbox nhu vay ne
            /*--------------------------------------------------------------------------------------------
             * -  panel trái             -                                 -         panel phải          -
             * -  chua tenuser           -        title                    -       chua 1 ptb va label   -label hien thi so sp trong gio hang
             * -------------------------------------------------------------------------------------------
            */

            //panel ben phải trong paneltoolbox
            //them ptb vao pnel phai load hinh anh xe day hang len
            pnlToolRight.Controls.Add(ptbGioHang);
            ptbGioHang.LoadAsync("https://icon-library.com/images/white-shopping-cart-icon/white-shopping-cart-icon-9.jpg");
            ptbGioHang.SizeMode = PictureBoxSizeMode.Zoom;
            //thiet lap kich thuoc vi tri cho ptb
            ptbGioHang.Height = Convert.ToInt32(pnlToolRight.Height);
            ptbGioHang.Width = Convert.ToInt32(pnlToolRight.Width / 3);
            ptbGioHang.Click += gioHang_click;
            //them label so luong sp vao panel phai
            pnlToolRight.Controls.Add(lbGioHang);
            lbGioHang.Font = lbInfo.Font = new Font("Arial", Convert.ToInt32(pnlToolBox.Height * 0.09), FontStyle.Regular);
            lbGioHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lbGioHang.Height = ptbGioHang.Height;
            lbGioHang.ForeColor = Color.White;
            lbGioHang.Click += gioHang_click;

            lbGioHang.Width = Convert.ToInt32(pnlToolRight.Width * 0.7);
            lbGioHang.Location = new Point(ptbGioHang.Width, ptbGioHang.Location.Y);
        }


        //Action cho nhung ptb trong panel 1 san pham xem thông tin sản phẩm
        private void Picturebox_click(object sender, EventArgs e)
        {

            PictureBox ptb = sender as PictureBox;
            //truyen qua info product
            Description d = new Description(ProductList[Convert.ToInt32(ptb.Tag)],this);
            d.Show();
            this.Enabled = false;
        }

        //action khi nhan vao ptb xedayhang hoac label so luong sp
        private void gioHang_click(object sender, EventArgs e)
        {

            //MessageBox.Show("show gio hang truyen vao list giohanginfo va accinfo(infoUser)");
            GioHang g = new GioHang();


        }


        //resize component trong panel trái
        private void pnlToolLeft_Resize(object sender, EventArgs e)
        {

            resizeToolLeft();

        }

        

        //hàm resize cac component trong panel phai
        private void pnlToolRight_Resize(object sender, EventArgs e)
        {
            //tat cả size như trong hàm setupUI
            ptbGioHang.Height = Convert.ToInt32(pnlToolRight.Height);
            ptbGioHang.Width = Convert.ToInt32(pnlToolRight.Width / 3);
            lbGioHang.Height = ptbGioHang.Height;

            lbGioHang.Width = Convert.ToInt32(pnlToolRight.Width * 0.7);
            lbGioHang.Location = new Point(ptbGioHang.Width, ptbGioHang.Location.Y);
        }

        private void resizeToolLeft()
        {
            btInfo.Height = Convert.ToInt32(pnlToolLeft.Height / 3);
            btInfo.Width = Convert.ToInt32(pnlToolLeft.Width / 3);
            btInfo.Location = new Point(Convert.ToInt32((pnlToolLeft.Width / 2) - (btInfo.Width / 2)), Convert.ToInt32((pnlToolLeft.Height / 2)));
            lbInfo.Font = new Font("Arial", Convert.ToInt32(pnlToolBox.Height * 0.12), FontStyle.Regular);
            lbInfo.Location = new Point(Convert.ToInt32((pnlToolLeft.Width / 2) - lbInfo.Width / 2), btInfo.Location.Y - btInfo.Height);
        }

        //action khi nhan nut thay doi thong tin user
        private void btInfo_Click(object sender, EventArgs e)
        {

            //hien thi form Infouser ẩn form hien tai di
            InfoUser info = new InfoUser(infoUser);
            info.showForm = this;
            this.Hide();
            info.Show();
            
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {


            DialogResult result = MessageBox.Show("Bạn có muốn tắt chứ ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                System.Environment.Exit(1);
            }


        }
    }
}
