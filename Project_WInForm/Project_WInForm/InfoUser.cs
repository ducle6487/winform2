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
    public partial class InfoUser : Form
    {
        public InfoUser()
        {
            InitializeComponent();
        }

        public int statusClose = 1;

        public InfoUser(InfoAccDTO info)
        {
            InitializeComponent();

            this.info = info;
            
        }
        //Tạo biến showForm của form MainPage 
        public MainPage showForm { get; set; }
        //tạo biến History của class HistoryTrade
        HistoryTrade history;
        //Khởi tạo biến info của class InfoAccDTO
        InfoAccDTO info = new InfoAccDTO();
        //Khởi tạo biến changeInfo của form ChangeInfo
        ChangeInfo changeInfo = new ChangeInfo();
        //Hàm btChangInfo_Click
        private void btChangeInfo_Click(object sender, EventArgs e)
        {

            CallToChildForm(changeInfo); // gọi Form ChangeInfo truyền vào panel
            selectColor(btChangeInfo, btHistory);
        }
        //Hàm btHistory_Click
        private void btHistory_Click(object sender, EventArgs e)
        {
            CallToChildForm(history); // gọi form History truyền vào panel
            
            selectColor(btHistory, btChangeInfo);
        }

        //Hàm Chọn Màu
        private void selectColor(Button select , Button deselect)
        {

            select.BackColor = Color.White;
            deselect.BackColor = Color.Gray;

        }
        //Hàm gọi Form và chuyền vào panel Main
        private void CallToChildForm(object form)
        {

            if (pnlMain.Controls.Count > 0)
            {
                pnlMain.Controls.RemoveAt(0);
            }

            Form l = form as Form;
            l.TopLevel = false;
            l.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(l);
            l.Show();


        }
        //Hàm Load  form InfoUser
        private void InfoUser_Load(object sender, EventArgs e)
        {
            history = new HistoryTrade(info.AccID);
            
            changeInfo.InfoUser = this;
            changeInfo.info = info;
            changeInfo.loadTextbox();
            CallToChildForm(changeInfo); // truyền form changeInfo vào panel
            selectColor(btChangeInfo, btHistory);

            resizeForm();
            
            resizeToolBox();
        }

        
        //Hàm resize form
        private void resizeForm()
        {
            pnlToolbox.Width = this.Width;
            pnlToolbox.Height = Convert.ToInt32(this.Height *0.15);
            pnlMain.Width = this.Width;
            pnlMain.Height = this.Height-pnlToolbox.Height;
            
        }
        //Hàm Resize toolbox
        private void resizeToolBox()
        {
            //chiều cao của btChangeInfo = chiều cao pnlToolBox bằng chiều cao btHistory
            //Chiều rộng btChangeInfo=btHistory = pntoolbox.width/2
            //Chữ nằm ở giữa
            btChangeInfo.Height = pnlToolbox.Height;
            btHistory.Height = btChangeInfo.Height;
            btChangeInfo.TextAlign = ContentAlignment.MiddleCenter;
            btChangeInfo.Width = Convert.ToInt32(pnlToolbox.Width / 2);
            btHistory.Width = btChangeInfo.Width;
            btHistory.TextAlign = ContentAlignment.MiddleCenter;
        }
        //Hàm Resize form InfoUser
        private void InfoUser_Resize(object sender, EventArgs e)
        {
            resizeForm();
        }
        //Hàm Resize pnlTool
        private void pnlToolbox_Resize(object sender, EventArgs e)
        {
            resizeToolBox();// gọi hàm resize
        }
        //Hàm đóng Form
        private void InfoUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (statusClose == 2)
            {
                showForm.reloadInfoUser(); // load lại reloadInfoUser
            }
            showForm.Show();
            
            
            
        }
    }
}
