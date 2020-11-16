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

        //danh sach gioi tinh
        List<GenderDTO> listGender = new List<GenderDTO>();

        //bien chua form truoc do
        public InfoUser InfoUser { get; set; }

        //bien chua thong tin tai khoan
        public InfoAccDTO info { get; set; }

        //khoi tao balAccount
        AccountBAL balAccount = new AccountBAL();

        //khoi tao balGioiTinh
        GenderBAL balGender = new GenderBAL();

        //load thong tin tai khoan len 
        public void loadTextbox()
        {
            txtAddress.Text = info.Diachi;
            txtAge.Text = info.Tuoi.ToString();
            txtFullName.Text = info.TenKH;
            txtPhoneNumber.Text = info.Sdt;
            cbGender.Text = info.Gioitinh;
        }


        //ham kiem tra so cua 1 chuoi
        private bool checkNumber(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if (!Char.IsDigit(str[i]))
                {
                    return false;
                }
            }
            return true;
        }

        //ham thuc thi khi nhan nut cap nhat thong tin
        private void btInfo_Click(object sender, EventArgs e)
        {
            //check null
            if (txtFullName.Text != "" && txtAge.Text != "" && txtAddress.Text != "" && txtPhoneNumber.Text != "" && cbGender.Text != "") 
            {
                //kiem tra tuoi la so
                if (checkNumber(txtAge.Text))
                {
                    //kiem tra sdt la so
                    if (checkNumber(txtPhoneNumber.Text))
                    {
                        //kiem tra cap nhat
                        if (balAccount.UpdateInfoAccount(info.AccID, txtFullName.Text, txtAddress.Text, Convert.ToInt32(txtAge.Text), cbGender.Text, txtPhoneNumber.Text))
                        {
                            //thanh cong
                            MessageBox.Show("Cập nhật thành công");
                            InfoUser.statusClose = 2;
                        }
                        else
                        {
                            //that bai
                            MessageBox.Show("Cập nhật thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("sdt chỉ được nhập số");
                    }
                }
                else
                {
                    MessageBox.Show("tuổi chỉ được nhập số");
                }

            }
            else
            {
                MessageBox.Show("Hãy điền đủ thông tin");
            }

        }

        //ham thuc thi khi nhan nut doi pass
        private void btPass_Click(object sender, EventArgs e)
        {
            //check null
            if (txtmk1.Text != "" && txtmk2.Text != "" && txtmk3.Text != "")
            {
                //check xac nhan mat khau
                if(txtmk2.Text != txtmk3.Text)
                {
                    MessageBox.Show("Mật khẩu xác nhận không trùng khớp");
                }
                else
                {
                    //check change pass
                    if (balAccount.ChangePassword(info.AccID, txtmk1.Text, txtmk2.Text))
                    {
                        //thanh cong
                        MessageBox.Show("Đổi mật khẩu thành công");
                    }
                    else
                    {
                        //that bai
                        MessageBox.Show("Đổi mật khẩu thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy điền đủ thông tin");
            }

        }

        //ham load form
        private void ChangeInfo_Load(object sender, EventArgs e)
        {
            //resize cac thanh phan trong form
            resizeForm();

            //lay thong tin gioi tinh vao list
            listGender = balGender.GetInfoGender();


            //lay danh sach gioi tinh
            List<string> listTempGender = new List<string>();

            foreach (GenderDTO item in listGender)
            {
                listTempGender.Add(item.Des1);
            }
            //truyen vao combobox
            cbGender.DataSource = listTempGender;


        }

        //ham resize cac thanh phan trong form
        private void resizeForm()
        {
            //pnlInfo chieu ngang = 1 nua form
            pnlInfo.Height = this.Height;
            pnlInfo.Width = Convert.ToInt32(this.Width / 2);
            //pnlPass la phan con lai
            pnlPass.Height = this.Height;
            pnlPass.Width = Convert.ToInt32(this.Width / 2);
        }

        private void ChangeInfo_Resize(object sender, EventArgs e)
        {
            resizeForm();
        }


    }
}
