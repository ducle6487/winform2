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
    public partial class ChangeInfo : Form
    {
        public ChangeInfo()
        {
            InitializeComponent();
        }


        public InfoUser InfoUser { get; set; }

        public InfoAccDTO info { get; set; }

        AccountBAL bal = new AccountBAL();

        public void loadTextbox()
        {
            txtAddress.Text = info.Diachi;
            txtAge.Text = info.Tuoi.ToString();
            txtFullName.Text = info.TenKH;
            txtPhoneNumber.Text = info.Sdt;
            cbGender.Text = info.Gioitinh;
        }

        private void btInfo_Click(object sender, EventArgs e)
        {

            if (txtFullName.Text != "" && txtAge.Text != "" && txtAddress.Text != "" && txtPhoneNumber.Text != "" && cbGender.Text != "") 
            {

                if (bal.UpdateInfoAccount(info.AccID, txtFullName.Text, txtAddress.Text, Convert.ToInt32(txtAge.Text), cbGender.Text, txtPhoneNumber.Text))
                {
                    MessageBox.Show("Cập nhật thành công");
                    InfoUser.statusClose = 2;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }

            }
            else
            {
                MessageBox.Show("Hãy điền đủ thông tin");
            }

        }

        private void btPass_Click(object sender, EventArgs e)
        {

            if (txtmk1.Text != "" && txtmk2.Text != "" && txtmk3.Text != "")
            {
                if(txtmk2.Text != txtmk3.Text)
                {
                    MessageBox.Show("Mật khẩu xác nhận không trùng khớp");
                }
                else
                {
                    if (bal.ChangePassword(info.AccID, txtmk1.Text, txtmk2.Text))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy điền đủ thông tin");
            }

        }

        private void ChangeInfo_Load(object sender, EventArgs e)
        {

            resizeForm();
            
        }

        private void resizeForm()
        {
            pnlInfo.Height = this.Height;
            pnlInfo.Width = Convert.ToInt32(this.Width / 2);
            pnlPass.Height = this.Height;
            pnlPass.Width = Convert.ToInt32(this.Width / 2);
        }

        private void ChangeInfo_Resize(object sender, EventArgs e)
        {
            resizeForm();
        }


    }
}
