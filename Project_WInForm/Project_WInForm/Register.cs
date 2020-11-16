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
    public partial class Register : Form
    {
        //Khởi tạo biến của class AccountBal
        AccountBAL balAccount = new AccountBAL();
        //Khởi tạo biến của class balGender
        GenderBAL balGender = new GenderBAL();

        public Register()
        {
            InitializeComponent();
        }
        //Khởi tạo danh sách lưu giới tính
        List<GenderDTO> listGender = new List<GenderDTO>();
        //Khởi tạo biến thuộc Form Login
        public LoginForm parentForm {get;set;}
        //Hàm Load Dữ Liệu của Form Đăng Kí
        private void Register_Load(object sender, EventArgs e)
        {
            pnRegister.BackColor = Color.FromArgb(100, 0, 0, 0); //Cho màu của panel Login đổi xuống màu tối
            pnRegister.Location = new Point(Convert.ToInt32((this.Width / 2) - (pnRegister.Width / 2)), Convert.ToInt32((this.Height / 2) - (pnRegister.Width / 2)));
            lbTitle.Location = new Point(Convert.ToInt32((this.Width / 2) - (lbTitle.Width / 2)), Convert.ToInt32((this.Height / 12)));

            listGender = balGender.GetInfoGender();
            Console.WriteLine(listGender[0].Des1);

            List<string> listTempGender = new List<string>();

            foreach( GenderDTO item in listGender)
            {
                listTempGender.Add(item.Des1);
            }

            cbGender.DataSource = listTempGender;
            
        }

        //Hàm kiểm tra khách hàng đã điền đầy đủ thông tin hay không
        private bool textboxIsFilled()
        {
            if (txtFullName.Text!=""&&txtAddress.Text!=""&&txtAge.Text != ""&&txtPassword.Text!=""&&txtPhoneNumber.Text!=""&&txtUser.Text!=""&&cbGender.Text!="")
            {
                return true;
            }

            return false;
        }

        //Hàm Kiểm tra có phải là số hay không
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
        //Hàm Đăng Kí
        private void btnRegisterNow_Click(object sender, EventArgs e)
        {
            if (textboxIsFilled())
            {
                //Kiểm tra coi đã điền đầy đủ thông tin hay chưa
                if (isNumber(txtPhoneNumber.Text)==false)
                {
                    //Nếu mà Hàm isNumber trả về giá trị bằng false
                    //Có nghĩa là textbox số điện thoại có chữ
                    //thông báo cho người dùng
                    MessageBox.Show("Số điện thoại tào lao");
                }
                else
                {
                    //ngược lại
                    if (isNumber(txtAge.Text) == false)
                    {
                        //kiểm tra coi textbox Age nhập số hay không
                        // nếu không phải là số thì thông báo cho người dùng
                        MessageBox.Show("Tuổi không đúng");
                    }
                    else
                    {
                        //Ngược lại
                        if (balAccount.RegisterAccountIncludeInfo(txtUser.Text, txtPassword.Text, txtFullName.Text, txtAddress.Text, Convert.ToInt32(txtAge.Text), cbGender.Text, txtPhoneNumber.Text))
                        {
                            //Hàm Đăng Kí thành viên
                            //Thông báo cho người dùng
                            //lưu 2 giá trị password và user vào 2 biến được tạo trong form LoginForm
                            MessageBox.Show("Đăng ký thành công");
                            parentForm.user = txtUser.Text;
                            parentForm.pass = txtPassword.Text;
                            this.Close();
                        }
                        else
                        {
                            //Ngược Lại
                            //Thông báo cho người dùng
                            MessageBox.Show("Đăng ký thất bại");
                        }
                    }
                }
            }
            else
            {
                //Ngược Lại
                //Thông báo cho người dùng
                MessageBox.Show("Nhập thông tin đầy đủ đi ");
            }
        }
        //Hàm resize form Resister
        private void Register_Resize(object sender, EventArgs e)
        {
            lbTitle.Location = new Point(Convert.ToInt32((this.Width / 2) - (lbTitle.Width / 2)), Convert.ToInt32((this.Height / 15)));
            pnRegister.Location = new Point(Convert.ToInt32((this.Width / 2) - (pnRegister.Width / 2)), Convert.ToInt32((this.Height / 2) - (pnRegister.Width / 2)));
            
        }
        //Hàm đóng REgister
        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show(); //Gọi lại form Login
            parentForm.resetTextbox(); //gán 2 giá trị vừa user,password vào textbox user,pass
        }
    }
}
