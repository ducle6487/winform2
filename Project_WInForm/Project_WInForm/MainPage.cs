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

        int soluong = 0;

        string giohang;

        InfoAccDTO info = new InfoAccDTO();
        
        ProductBAL productBAL = new ProductBAL();

        PictureBox ptbGioHang = new PictureBox();

        Label lbGioHang = new Label();

        List<ProductDTO> ProductList = new List<ProductDTO>();
        
        List<Panel> ListPanel = new List<Panel>();

        private void MainPage_Resize(object sender, EventArgs e)
        {

            resize();


        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            
            this.Width = 1060;
            resize();
            giohang = "Giỏ Hàng: " + soluong;
            SetupUI();
        }

        private void resize()
        {
            pnlToolBox.Height = Convert.ToInt32(this.Height * 0.15);
            pnlToolBox.Width = this.Width;
            fpnlProduct.Height = Convert.ToInt32(this.Height * 0.83);
            fpnlProduct.Width = this.Width;
            lbTittle.Width = Convert.ToInt32(this.Width / 4);
            lbTittle.Height = pnlToolBox.Height;
            lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lbTittle.Font = new Font("Arial", Convert.ToInt32(pnlToolBox.Height * 0.2), FontStyle.Regular);
            lbTittle.Location = new Point(Convert.ToInt32((pnlToolBox.Width / 4)+(pnlToolBox.Width / 8)), pnlToolBox.Location.Y);
            pnlToolLeft.Width = lbTittle.Width;
            pnlToolLeft.Location = new Point(20, 20);
            pnlToolLeft.Height = pnlToolBox.Height - 40;
            pnlToolRight.Height = Convert.ToInt32(pnlToolBox.Height/3);
            pnlToolRight.BorderStyle = BorderStyle.FixedSingle;
            pnlToolRight.Width = Convert.ToInt32(pnlToolBox.Width /8);
            pnlToolRight.Location = new Point(Convert.ToInt32((pnlToolBox.Width / 2) + (pnlToolBox.Width / 3.25) + 20), Convert.ToInt32(pnlToolBox.Height / 4));

            
        }

        private void SetupUI()
        {

            ProductList = productBAL.GetDataProduct();
            for (int i = 0; i < ProductList.Count; i++)
            {
                Panel pnl = new Panel();

                pnl.Width = Convert.ToInt32(250);
                pnl.Height = Convert.ToInt32(fpnlProduct.Height / 2);

                
               
                ListPanel.Add(pnl);

                PictureBox ptb = new PictureBox();
                ptb.Location = pnl.Location;
                ptb.Height = Convert.ToInt32(pnl.Height * 0.7);
                ptb.Width = pnl.Width;
                ptb.SizeMode = PictureBoxSizeMode.Zoom;
                ptb.LoadAsync(ProductList[i].LinkImg);
                ptb.Tag = i.ToString();
                pnl.Controls.Add(ptb);
                ptb.Click += panel_click;
                Label lbName = new Label();
                lbName.Location = new Point(Convert.ToInt32(pnl.Location.X), pnl.Location.Y + ptb.Height);
                lbName.Width = pnl.Width;
                lbName.Height = Convert.ToInt32(pnl.Height * 0.15);
                lbName.Text = ProductList[i].ProductName;
                lbName.Font = new Font("Arial", 15, FontStyle.Regular);
                lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                pnl.Controls.Add(lbName);
                Label lbPrice = new Label();
                lbPrice.Location = new Point(Convert.ToInt32(pnl.Location.X), pnl.Location.Y + ptb.Height + lbName.Height);
                lbPrice.Width = pnl.Width;
                lbPrice.Height = Convert.ToInt32(pnl.Height * 0.15);
                lbPrice.Text = ProductList[i].Dongia;
                lbPrice.Font = new Font("Arial", 13, FontStyle.Regular);
                lbPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                pnl.Controls.Add(lbPrice);

                fpnlProduct.Controls.Add(pnl);
            }

            lbInfo.Text = "Lê Anh Đức";
            lbInfo.Height = Convert.ToInt32(pnlToolBox.Height / 2.5);
            lbInfo.Width = Convert.ToInt32(pnlToolBox.Width / 3);
            lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lbInfo.Location = new Point(Convert.ToInt32(pnlToolLeft.Width / 3), Convert.ToInt32(pnlToolLeft.Height / 9));
            lbInfo.Font = new Font("Arial", Convert.ToInt32(pnlToolBox.Height * 0.12), FontStyle.Regular);
            btInfo.Location = new Point(lbInfo.Location.X, Convert.ToInt32(pnlToolLeft.Height / 9) + lbInfo.Height);
            btInfo.Height = Convert.ToInt32(pnlToolLeft.Height / 3);
            btInfo.Width = lbInfo.Width;

            

            pnlToolRight.Controls.Add(ptbGioHang);
            ptbGioHang.LoadAsync("https://icon-library.com/images/white-shopping-cart-icon/white-shopping-cart-icon-9.jpg");
            ptbGioHang.SizeMode = PictureBoxSizeMode.Zoom;
            ptbGioHang.Height = Convert.ToInt32(pnlToolRight.Height);
            ptbGioHang.Width = Convert.ToInt32(pnlToolRight.Width / 3);
            
            pnlToolRight.Controls.Add(lbGioHang);
            lbGioHang.Text = giohang;
            lbGioHang.Font = lbInfo.Font = new Font("Arial", Convert.ToInt32(pnlToolBox.Height * 0.09), FontStyle.Regular);
            lbGioHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lbGioHang.Height = ptbGioHang.Height;
            lbGioHang.ForeColor = Color.White;

            lbGioHang.Width = Convert.ToInt32(pnlToolRight.Width * 0.7);
            lbGioHang.Location = new Point(ptbGioHang.Width, ptbGioHang.Location.Y);
        }

        private void panel_click(object sender, EventArgs e)
        {

            PictureBox ptb = sender as PictureBox;

            MessageBox.Show(ProductList[Convert.ToInt32(ptb.Tag.ToString())].ProductName);
            
        }




        private void pnlToolLeft_Resize(object sender, EventArgs e)
        {


            lbInfo.Height = Convert.ToInt32(pnlToolBox.Height / 2.5);
            lbInfo.Width = Convert.ToInt32(pnlToolBox.Width / 3);
            lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lbInfo.Location = new Point(Convert.ToInt32(pnlToolLeft.Width / 3), Convert.ToInt32(pnlToolLeft.Height / 9));
            lbInfo.Font =  new Font("Arial", Convert.ToInt32(pnlToolBox.Height * 0.12) , FontStyle.Regular);
            btInfo.Location = new Point(lbInfo.Location.X, Convert.ToInt32(pnlToolLeft.Height / 9) + lbInfo.Height);
            btInfo.Height = Convert.ToInt32(pnlToolLeft.Height / 3);
            btInfo.Width = lbInfo.Width;

        }

        private void pnlToolRight_Resize(object sender, EventArgs e)
        {
            ptbGioHang.Height = Convert.ToInt32(pnlToolRight.Height);
            ptbGioHang.Width = Convert.ToInt32(pnlToolRight.Width / 3);
            lbGioHang.Height = ptbGioHang.Height;

            lbGioHang.Width = Convert.ToInt32(pnlToolRight.Width * 0.7);
            lbGioHang.Location = new Point(ptbGioHang.Width, ptbGioHang.Location.Y);
        }
    }
}
