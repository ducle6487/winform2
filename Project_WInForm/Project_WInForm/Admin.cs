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

    //form nay chua 2 form AccountInfoForAdmin va SaleHistory
    //hien thi 2 form len panel
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        //khoi tao form AccountInfoForAdmin
        AccountInfoForAdmin account = new AccountInfoForAdmin();

        //khoi tao form SaleHistory
        SaleHistory sale = new SaleHistory();


        //ham thuc thi khi nhan nut account xem thong tin
        private void btAccount_Click(object sender, EventArgs e)
        {
            //thay mau nut
            selectButtonChange(btAccount, btPayment);
            //hien thi form AccountInfoForAdmin len panel main
            CallToChildForm(account);
        }

        //ham thuc thi khi nhan nut payment xem thong tin tat ca giao dich 
        private void btPayment_Click(object sender, EventArgs e)
        {
            //doi mau nut
            selectButtonChange(btPayment, btAccount);
            //hien thi form SaleHistory len panel main
            CallToChildForm(sale);
        }

        //ham thuc thi khi load form
        private void Admin_Load(object sender, EventArgs e)
        {


            //resize thanh phan trong form
            resize();
            //set default la hien thi thong tin account
            selectButtonChange(btAccount, btPayment);
            CallToChildForm(account);
        }


        //ham doi mau nut truyen vao nut nhan va nut khong nhan
        private void selectButtonChange(Button selected, Button deselected)
        {
            selected.BackColor = Color.White;
            selected.ForeColor = Color.Black;
            deselected.BackColor = Color.Black;
            deselected.ForeColor = Color.White;
        }

        //ham resize thanh phan trong form
        private void resize()
        {
            //pnlToolbox chieu cao = 10% form va chieu ngang  = form
            pnlToolbox.Height = Convert.ToInt32(this.Height * 0.1);
            pnlToolbox.Width = this.Width;
            //pnlmain chieu cao la phan con lai khi tru di chieu cao cua toolbox
            pnlMain.Height = this.Height - pnlToolbox.Height;
            pnlMain.Width = this.Width;
            //nut xem thong tin tai khoan nam trong pnltoolbox va ngang bang 1 nua cao bang 100% vitri nam nua ben trái
            btAccount.Width = Convert.ToInt32(pnlToolbox.Width / 2);
            btAccount.Height = pnlToolbox.Height;
            btAccount.Location = new Point(0, 0);
            //nut xem lich su giao dich co size bang nut xem thong ti tai khoan va nam nua phải
            btPayment.Height = btAccount.Height;
            btPayment.Width = btAccount.Width;
            btPayment.Location = new Point(btPayment.Width, 0);


        }


        //ham goi 1 form len panelMain
        private void CallToChildForm(object form)
        {
            //kiem tra xem da co form nao load chua
            if (pnlMain.Controls.Count > 0)
            {
                pnlMain.Controls.RemoveAt(0);
            }

           //hien thi form truyen vao len panelMain
            Form l = form as Form;
            l.TopLevel = false;
            l.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(l);
            l.Show();


        }

        //ham thuc thi khi resize formAdmin
        private void Admin_Resize(object sender, EventArgs e)
        {
            resize();
        }

        //Ham thuc thi khi form dong
        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //thong bao xac nhan tat form
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
