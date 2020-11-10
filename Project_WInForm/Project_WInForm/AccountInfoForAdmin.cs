using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DTO;

namespace Project_WInForm
{
    public partial class AccountInfoForAdmin : Form
    {
        public AccountInfoForAdmin()
        {
            InitializeComponent();
        }

        AccountBAL bal = new AccountBAL();


        List<InfoAccDTO> list = new List<InfoAccDTO>();

        private void resize()
        {

            pnlRight.Width = Convert.ToInt32(this.Width * 0.65);
            pnlRight.Height = this.Height;
            pnlLeft.Width = Convert.ToInt32(this.Width * 0.35);
            pnlLeft.Height = this.Height;

            Console.WriteLine(this.Width.ToString());

            pnlInfo.Location = new Point(Convert.ToInt32((pnlLeft.Width / 2) - (pnlInfo.Width / 2)),Convert.ToInt32((pnlLeft.Height / 2) - (pnlInfo.Height / 2)));
            dgvAccount.Width = pnlRight.Width;
            dgvAccount.Height = pnlRight.Height;
        }




        private void Account_Load(object sender, EventArgs e)
        {
            resize();
            list = bal.GetInfoAccs();
            dgvAccount.DataSource = list;
        }


        private void pnlRight_Resize(object sender, EventArgs e)
        {
            dgvAccount.Width = pnlRight.Width;
            dgvAccount.Height = pnlRight.Height;
        }

        private void Account_Resize_1(object sender, EventArgs e)
        {
            resize();
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = dgvAccount.CurrentRow.Index;

            txtFullName.Text = list[index].TenKH;
            txtAge.Text = list[index].Tuoi.ToString();
            txtAddress.Text = list[index].Diachi;
            txtGender.Text = list[index].Gioitinh;
            txtPhoneNumber.Text = list[index].Sdt;
            txtID.Text = list[index].AccID;

        }
    }
}
