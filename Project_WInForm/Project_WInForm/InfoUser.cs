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

        public MainPage showForm { get; set; }

        HistoryTrade history;

        InfoAccDTO info = new InfoAccDTO();

        ChangeInfo changeInfo = new ChangeInfo();

        private void btChangeInfo_Click(object sender, EventArgs e)
        {

            CallToChildForm(changeInfo);
            selectColor(btChangeInfo, btHistory);
        }

        private void btHistory_Click(object sender, EventArgs e)
        {
            CallToChildForm(history);
            
            selectColor(btHistory, btChangeInfo);
        }


        private void selectColor(Button select , Button deselect)
        {

            select.BackColor = Color.White;
            deselect.BackColor = Color.Gray;

        }

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

        private void InfoUser_Load(object sender, EventArgs e)
        {
            history = new HistoryTrade(info.AccID);
            
            changeInfo.InfoUser = this;
            changeInfo.info = info;
            changeInfo.loadTextbox();
            CallToChildForm(changeInfo);
            selectColor(btChangeInfo, btHistory);

            resizeForm();
            
            resizeToolBox();
        }

        

        private void resizeForm()
        {
            pnlToolbox.Width = this.Width;
            pnlToolbox.Height = Convert.ToInt32(this.Height *0.15);
            pnlMain.Width = this.Width;
            pnlMain.Height = this.Height-pnlToolbox.Height;
            
        }

        private void resizeToolBox()
        {
            btChangeInfo.Height = pnlToolbox.Height;
            btHistory.Height = btChangeInfo.Height;
            btChangeInfo.TextAlign = ContentAlignment.MiddleCenter;
            btChangeInfo.Width = Convert.ToInt32(pnlToolbox.Width / 2);
            btHistory.Width = btChangeInfo.Width;
            btHistory.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void InfoUser_Resize(object sender, EventArgs e)
        {
            resizeForm();
        }

        private void pnlToolbox_Resize(object sender, EventArgs e)
        {
            resizeToolBox();
        }

        private void InfoUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (statusClose == 2)
            {
                showForm.reloadInfoUser();
            }
            showForm.Show();
            
            
            
        }
    }
}
