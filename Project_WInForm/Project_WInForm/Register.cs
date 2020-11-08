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

        public LoginForm parentForm {get;set;}
        
        private void Register_Load(object sender, EventArgs e)
        {
            pnRegister.BackColor = Color.FromArgb(100, 0, 0, 0); //Cho màu của panel Login đổi xuống màu tối
            pnRegister.Location = new Point(Convert.ToInt32((this.Width / 2) - (pnRegister.Width / 2)), Convert.ToInt32((this.Height / 2) - (pnRegister.Width / 2)));
            lbTitle.Location = new Point(Convert.ToInt32((this.Width / 2) - (lbTitle.Width / 2)), Convert.ToInt32((this.Height / 12)));
            
        }

        
        private bool textboxIsFilled()
        {
            if (txtFullName.Text!=""&&txtAddress.Text!=""&&txtAge.Text != ""&&txtPassword.Text!=""&&txtPhoneNumber.Text!=""&&txtUser.Text!=""&&cbGender.Text!="")
            {
                return true;
            }

            return false;
        }


        private bool isNumber(string num)
        {

            for(int i = 0; i < num.Length; i++)
            {
                if (Char.IsDigit(num[i])==false)
                {
                    return false;
                }
            }

            return true;
        }
        
        private void btnRegisterNow_Click(object sender, EventArgs e)
        {
            if (textboxIsFilled())
            {
                if (isNumber(txtPhoneNumber.Text)==false)
                {
                    MessageBox.Show("Số điện thoại tào lao");
                }
                else
                {
                    if (isNumber(txtAge.Text) == false)
                    {
                        MessageBox.Show("Tuổi không đúng");
                    }
                    else
                    {
                        if (bal.RegisterAccountIncludeInfo(txtUser.Text, txtPassword.Text, txtFullName.Text, txtAddress.Text, Convert.ToInt32(txtAge.Text), cbGender.Text, txtPhoneNumber.Text))
                        {
                            MessageBox.Show("Đăng ký thành công");
                            parentForm.user = txtUser.Text;
                            parentForm.pass = txtPassword.Text;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký thất bại");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập thông tin đầy đủ đi ");
            }
        }

        private void Register_Resize(object sender, EventArgs e)
        {
            lbTitle.Location = new Point(Convert.ToInt32((this.Width / 2) - (lbTitle.Width / 2)), Convert.ToInt32((this.Height / 15)));
            pnRegister.Location = new Point(Convert.ToInt32((this.Width / 2) - (pnRegister.Width / 2)), Convert.ToInt32((this.Height / 2) - (pnRegister.Width / 2)));
            
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
            parentForm.resetTextbox();
        }
    }
}
