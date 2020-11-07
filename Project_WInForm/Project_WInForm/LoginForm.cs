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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pnLogin.BackColor = Color.FromArgb(100, 0, 0, 0); //Cho màu của panel Login đổi xuống màu tối  
            pnLogin.Height = this.Height / 2;
            pnLogin.Width = this.Width / 2;
            pnLogin.Location = new Point(Convert.ToInt32(this.Width / 4), Convert.ToInt32(this.Height / 4));
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {

            pnLogin.Height = this.Height / 2;
            pnLogin.Width = this.Width / 2;
            pnLogin.Location = new Point(Convert.ToInt32(this.Width / 4), Convert.ToInt32(this.Height / 4));
        }

        
    }
}
