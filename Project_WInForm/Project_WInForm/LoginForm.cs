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
    public partial class LoginForm : Form
    {
        AccountBAL bal = new AccountBAL();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pnLogin.BackColor = Color.FromArgb(100, 0, 0, 0); //Cho màu của panel Login đổi xuống màu tối  
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            

        }
        public void dangnhap()
        {

            if (this.txtUser.Text.Length == 0 && this.txtPassword.Text.Length == 0) //Nếu chưa nhập gì vào User và Password thì ..
                MessageBox.Show("Mời bạn nhập tài khoản và mật khẩu !");
            else
                    if (this.txtUser.Text.Length == 0) //Nếu chưa nhập gì cho User thì...
                MessageBox.Show("Mời bạn nhập tài khoản !");
            else
                if (this.txtPassword.Text.Length == 0) //Nếu chưa nhập gì cho Password thì...
                MessageBox.Show("Mời bạn nhập mật khẩu !");
         
            

        }
        // Hàm này kiểm tra đăng nhập
        public int LogInChecking(string user, string pass) 
        {
            return bal.LogInChecking(user, pass);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool kq = false;
            if (txtUser.Text != "" && txtPassword.Text != "") //Nếu nhập vào User và Password vào
            {
                if (LogInChecking(txtUser.Text, txtPassword.Text)==1) //Nếu kiểm tra đăng nhập=1 thì thì Admin
                {
                    MessageBox.Show("Chào mừng Admin !"); 
                    
                    if(LogInChecking(txtUser.Text, txtPassword.Text) == 2) //Nếu kiểm tra đăng nhập=2 thì là người dùng
                    { 
                        MessageBox.Show("Chào mừng bạn đến shop !");
                        
                    }
                        else
                        {
                        kq = false;
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !");
                    }    
                 }
                     else
                     {
                        kq = false;
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !");
                     }               
            }
              else
              {
                dangnhap();
                kq = true;
              }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        
    }
}
