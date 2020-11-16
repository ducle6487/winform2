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

        //bien khoi tao account bal
        AccountBAL bal = new AccountBAL();

        //danh sach chua thong tin tât cac tai khoan
        List<InfoAccDTO> list = new List<InfoAccDTO>();

        //hàm resize form
        private void resize()
        {
            //pnlright chieu ngang = 65% chieu ngang cua form,chieu cao = 100% chieu cao form
            pnlRight.Width = Convert.ToInt32(this.Width * 0.65);
            pnlRight.Height = this.Height;
            // pnlLeft chieu ngang = 35 % chieu ngang cua form,chieu cao = 100 % chieu cao form
            pnlLeft.Width = Convert.ToInt32(this.Width * 0.35);
            pnlLeft.Height = this.Height;

            Console.WriteLine(this.Width.ToString());

            //pnlInfo la panel chua cac text box vị trí luon nam giua cua pnlLeft
            pnlInfo.Location = new Point(Convert.ToInt32((pnlLeft.Width / 2) - (pnlInfo.Width / 2)),Convert.ToInt32((pnlLeft.Height / 2) - (pnlInfo.Height / 2)));
            dgvAccount.Width = pnlRight.Width;
            dgvAccount.Height = pnlRight.Height;
        }



        //hàm load Form
        private void Account_Load(object sender, EventArgs e)
        {
            resize();//resize cac thanh phan trong form
            //lấy thông tin tất ca tai khoan
            list = bal.GetInfoAccs();
            //hien thi danh sach tai khoan len dgv
            dgvAccount.DataSource = list;
            btShowAll.Enabled = false;

            //lay thong tin cac kieu filter trong combobox
            //duyet qua cac cot trong dgv
            for(int i = 1; i <= dgvAccount.Columns.Count; i++)
            {
                //truyen vao combobox header của collumn
                cbxFilter.Items.Add(dgvAccount.Columns[i - 1].HeaderText);
            }
           
        }

        //hàm thuc thi khi resize pnlRight
        private void pnlRight_Resize(object sender, EventArgs e)
        {
            //dgv ben trong luon lon bang pnl
            dgvAccount.Width = pnlRight.Width;
            dgvAccount.Height = pnlRight.Height;
        }

        //hàm hàm thuc thi khi resize form
        private void Account_Resize_1(object sender, EventArgs e)
        {
            resize();//resize cac thanh phan ben trong form
        }

        //ham thuc thi khi nhan vao 1 cell trong dgv
        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lay vi tri nhan
            int index = dgvAccount.CurrentRow.Index;

            //truyen du lieu cua hang chua vi tri nhan vao cac textbox tuong ung
            txtFullName.Text = list[index].TenKH;
            txtAge.Text = list[index].Tuoi.ToString();
            txtAddress.Text = list[index].Diachi;
            txtGender.Text = list[index].Gioitinh;
            txtPhoneNumber.Text = list[index].Sdt;
            txtID.Text = list[index].AccID;

        }

        //ham thuc thi khi nhan nut show all
        private void btShowAll_Click(object sender, EventArgs e)
        {
            //vo hieu hoa nut nhan
            btShowAll.Enabled = false;
            
            //truyen tat ca thong tin tai khoan vao dgv
            dgvAccount.DataSource = list;
            clearTextbox();
            
        }

        //hàm khien tat ca textbox va combobox clear
        private void clearTextbox()
        {
            txtDataFilter.Clear();
            txtAddress.Clear();
            txtAge.Clear();
            txtFullName.Clear();
            txtGender.Clear();
            txtID.Clear();
            txtPhoneNumber.Clear();
            cbxFilter.Text = "";
        }


        //hàm kiem tra 1 chuoi co la so hay khong
        private bool checkNumber(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsDigit(str[i]))
                {
                    return false;
                }
            }
            return true;
        }


        //ham thuc thi khi nhan nut filter ,xac nhan lọc
        private void btFilter_Click(object sender, EventArgs e)
        {

            //tao 1 danh sach tam chua cac thong tin có them loc dc
            List<InfoAccDTO> listTemp = new List<InfoAccDTO>();

            //check blank space
            if (txtDataFilter.Text != "")
            {
                if(cbxFilter.Text != "")
            {

                    //lọc ID
                    if(cbxFilter.Text == "AccID")
                    {
                        foreach (InfoAccDTO info in list)
                        {
                            if (info.AccID == txtDataFilter.Text)
                            {
                                listTemp.Add(info);
                            }
                        }
                    }
                    else
                    {
                        //loc tenkh
                        if (cbxFilter.Text == "TenKH")
                        {
                            foreach (InfoAccDTO info in list)
                            {
                                if (info.TenKH == txtDataFilter.Text)
                                {
                                    listTemp.Add(info);
                                }
                            }
                        }
                        else
                        {
                            //loc dia chi
                            if (cbxFilter.Text == "Diachi")
                            {
                                foreach (InfoAccDTO info in list)
                                {
                                    if (info.Diachi == txtDataFilter.Text)
                                    {
                                        listTemp.Add(info);
                                    }
                                }
                            }
                            else
                            {
                                //loc gioi tinh
                                if (cbxFilter.Text == "Gioitinh")
                                {
                                    foreach (InfoAccDTO info in list)
                                    {
                                        if (info.Gioitinh == txtDataFilter.Text)
                                        {
                                            listTemp.Add(info);
                                        }
                                    }
                                }
                                else
                                {
                                    //loc so dt
                                    if (cbxFilter.Text == "Sdt")
                                    {
                                        //kiem tra sdt co la so khong
                                        if (checkNumber(txtDataFilter.Text))
                                        {
                                            foreach (InfoAccDTO info in list)
                                            {
                                                if (info.Sdt == txtDataFilter.Text)
                                                {
                                                    listTemp.Add(info);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Sdt phải là số");
                                        }
                                    }
                                    else
                                    {
                                        //loc tuoi
                                        if (cbxFilter.Text == "Tuoi")
                                        {
                                            if (checkNumber(txtDataFilter.Text))
                                            {
                                                foreach (InfoAccDTO info in list)
                                                {
                                                    if (info.Tuoi == Convert.ToInt32(txtDataFilter.Text))
                                                    {
                                                        listTemp.Add(info);
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Tuổi phải là số");
                                            }
                                        }
                                            
                                    }
                                }
                            }
                        }
                    }
                    //hien thi danh sach loc dc vao dgv
                    dgvAccount.DataSource = listTemp;
                    btShowAll.Enabled = true;
                    //clear tat cac textbox va combobox
                    clearTextbox();
                }
                else
                {
                    //Ngược Lại
                    //Thông Báo cho người dùng
                    MessageBox.Show("chọn loại muốn lọc");
                }
            }
            else
            {
                //Ngược Lại Thông Báo cho người dùng
                MessageBox.Show("nhập dữ liệu lọc");
            }
           
        }


    }
}
