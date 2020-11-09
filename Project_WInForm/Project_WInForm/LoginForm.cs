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


        public string user = "";
        public string pass = "";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        { 
            resizeForm();
            
        }

        public void resetTextbox()
        {
            txtUser.Text = user;
            txtPassword.Text = pass;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            register.parentForm = this;
            this.Hide();
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {

            pnlLogin.Location = new Point(Convert.ToInt32((this.Width / 2) - (pnlLogin.Width / 2)), Convert.ToInt32((this.Height / 2) - (pnlLogin.Width / 2)));

        }
       

        private void resizeForm()
        {
            pnlLogin.Width = Convert.ToInt32(this.Width / 2 );
            pnlLogin.Height = Convert.ToInt32(this.Height / 2);
            pnlLogin.Location = new Point(Convert.ToInt32((this.Width / 2)-(pnlLogin.Width / 2)),Convert.ToInt32((this.Height / 2) - (pnlLogin.Width / 2)));

            lbLogin.Location = new Point(Convert.ToInt32((pnlLogin.Width / 2) - (lbLogin.Width / 2)));
            

        }
        
        private bool textboxIsFilled()
        {
            if (txtUser.Text != "" && txtPassword.Text != "")
            {
                return true;
            }

            return false;
        }
        


        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (textboxIsFilled())
            {
                int type = bal.LogInChecking(txtUser.Text, txtPassword.Text);
                if (type == 1)
                {
                    MessageBox.Show("Admin trở lại!");
                    Admin a = new Admin();
                    a.Show();

                    this.Hide();
                }
                else
                {
                    if(type == 2)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        MainPage m = new MainPage(txtUser.Text);
                        m.Show();
                        
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy điển đầy đủ thông tin");
            }

        }


        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn tắt chứ ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        

        
    }
}
