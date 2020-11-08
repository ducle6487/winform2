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

namespace Project_WInForm
{
    public partial class Register : Form
    {
        AccountBAL bal = new AccountBAL();
        public Register()
        {
            InitializeComponent();
        }

        
        private void Register_Load(object sender, EventArgs e)
        {
            pnRegister.BackColor = Color.FromArgb(100, 0, 0, 0); //Cho màu của panel Login đổi xuống màu tối
            
        }

        public bool RegisterAccountIncludeInfo(string user, string pass, string ten, string diachi, int tuoi, string gioitinh, string sdt)
        {
            return bal.RegisterAccountIncludeInfo(user, pass, ten, diachi, tuoi, gioitinh, sdt);
        }
        
        private void btnRegisterNow_Click(object sender, EventArgs e)
        {
            bool kq = false;
            // Kiểm tra đầy đủ thông tin hay chưa ?
            //Nếu chưa thì quăng ra lỗi
            if (txtFullName.Text == "" || txtUser.Text == "" || txtPassword.Text == "" || txtAddress.Text == "" || txtAge.Text == "" || cbGender.Text == "" || txtPhoneNumber.Text == "") throw new Exception("Vui lòng điền đầy đủ thông tin !");
            if (txtFullName.Text == "" && txtUser.Text == "" && txtPassword.Text == "" && txtAddress.Text == "" && txtAge.Text == "" && cbGender.Text == "" && txtPhoneNumber.Text == "") 
            {
                if(bal.RegisterAccountIncludeInfo(txtFullName.Text , txtUser.Text , txtPassword.Text , txtAddress.Text, Convert.ToInt32(txtAge) , cbGender.Text,  txtPhoneNumber.Text)==false )
                {
                    MessageBox.Show("Bạn đăng kí thất bại !");
                }
                else
                {
                    kq = true;
                    MessageBox.Show("Chúc mừng bạn đã đăng kí thành công !");
                }    
            }
            else
            {
                kq = true;
            }
        }
    }
}
