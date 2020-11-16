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

        //khởi tạo 2 biến với giá trị ban đầu bằng rỗng
        public string user = "";
        public string pass = "";

        public LoginForm()
        {
            InitializeComponent();
        }
        //Hàm Load Form
        private void LoginForm_Load(object sender, EventArgs e)
        { 
            resizeForm();
            pnlLogin.BackColor = Color.FromArgb(100, 0, 0, 0);
            
        }
        //Hàm ResetTextbox
        public void resetTextbox()
        {
            txtUser.Text = user; // gán giá trị textbox user bằng biến user
            txtPassword.Text = pass;// gán giá trị textbox password bằng biến pass
        }
        //Hàm button REgister_Click
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            register.parentForm = this;
            this.Hide();
        }
        //Hàm Reszie FormLogin
        private void LoginForm_Resize(object sender, EventArgs e)
        {

            pnlLogin.Location = new Point(Convert.ToInt32((this.Width / 2) - (pnlLogin.Width / 2)), Convert.ToInt32((this.Height / 2) - (pnlLogin.Width / 2)));

        }
       
        //Hàm Resize Form
        private void resizeForm()
        {
            //pnlLogin với width bằng Form.width /2,và chiều cao bằng Form.Height/2
            pnlLogin.Width = Convert.ToInt32(this.Width / 2 );
            pnlLogin.Height = Convert.ToInt32(this.Height / 2);
            pnlLogin.Location = new Point(Convert.ToInt32((this.Width / 2)-(pnlLogin.Width / 2)),Convert.ToInt32((this.Height / 2) - (pnlLogin.Width / 2)));
            //Tọa độ của lb Login
            lbLogin.Location = new Point(Convert.ToInt32((pnlLogin.Width / 2) - (lbLogin.Width / 2)));
            //Tọa độ của lb Login,txtUser,txtPassword
            lbLogin.Location = new Point(Convert.ToInt32((pnlLogin.Width / 2) - (lbLogin.Width / 2)));
            txtUser.Location = new Point(Convert.ToInt32(pnlLogin.Width * 0.35),Convert.ToInt32(pnlLogin.Height * 0.4));
            txtPassword.Location = new Point(txtUser.Location.X, txtUser.Location.Y + (txtUser.Height * 2));
            //Tọa độ lbUser,lbPass
            lbUser.Location = new Point(Convert.ToInt32(pnlLogin.Width * 0.05),Convert.ToInt32(txtUser.Location.Y + (txtUser.Height / 4)));
            lbPass.Location = new Point(lbUser.Location.X, lbUser.Location.Y + (txtUser.Height * 2));
            //Tọa độ btRegister,btLogin
            btnRegister.Location = new Point(Convert.ToInt32((pnlLogin.Width / 2) - 40 - btnLogin.Width), Convert.ToInt32(pnlLogin.Height * 0.75));
            btnLogin.Location = new Point(Convert.ToInt32(pnlLogin.Width / 2) + 40, btnRegister.Location.Y);
        }
        //Hàm kiểm tra textbox
        private bool textboxIsFilled()
        {
            if (txtUser.Text != "" && txtPassword.Text != "")
            {
                //kiểm tra textbox User và password có trống hay không
                return true;
            }

            return false;
        }
        

        //Hàm ButtonLogin_Click
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (textboxIsFilled())
            {
                //Kiểm tra người dùng đã điền đầy đủ thông tin hay không
                int type = bal.LogInChecking(txtUser.Text, txtPassword.Text);
                if (type == 1)
                {
                    //nếu là admin thì thông báo cho admin
                    //Mở form Admin
                    MessageBox.Show("Admin trở lại!");
                    Admin a = new Admin();
                    a.Show();

                    this.Hide();
                }
                else
                {
                    //Ngược Lại
                    if(type == 2)
                    {
                        //Nếu là người dùng thì thông báo cho người dùng
                        //Mở form MainPage
                        MessageBox.Show("Đăng nhập thành công");
                        MainPage m = new MainPage(txtUser.Text);
                        m.Show();
                        
                        this.Hide();
                    }
                    else
                    {
                        //Ngược Lại 
                        //thông báo cho người dùng
                        MessageBox.Show("Đăng nhập thất bại");
                    }
                }
            }
            else
            {
                //Ngược Lại thông báo cho người dùng
                MessageBox.Show("Hãy điển đầy đủ thông tin");
            }

        }

        //Hàm đóng Form
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn tắt chứ ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                //Nếu người dùng ấn no thì hủy việc đóng form
                e.Cancel = true;
            }
        }

        

        
    }
}
