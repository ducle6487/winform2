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

        AccountBAL bal = new AccountBAL();


        List<InfoAccDTO> list = new List<InfoAccDTO>();

        private void resize()
        {

            pnlRight.Width = Convert.ToInt32(this.Width * 0.65);
            pnlRight.Height = this.Height;
            pnlLeft.Width = Convert.ToInt32(this.Width * 0.35);
            pnlLeft.Height = this.Height;

            Console.WriteLine(this.Width.ToString());

            pnlInfo.Location = new Point(Convert.ToInt32((pnlLeft.Width / 2) - (pnlInfo.Width / 2)),Convert.ToInt32((pnlLeft.Height / 2) - (pnlInfo.Height / 2)));
            dgvAccount.Width = pnlRight.Width;
            dgvAccount.Height = pnlRight.Height;
        }




        private void Account_Load(object sender, EventArgs e)
        {
            resize();
            list = bal.GetInfoAccs();
            dgvAccount.DataSource = list;
            btShowAll.Enabled = false;

            for(int i = 1; i <= dgvAccount.Columns.Count; i++)
            {
                cbxFilter.Items.Add(dgvAccount.Columns[i - 1].HeaderText);
            }
           
        }


        private void pnlRight_Resize(object sender, EventArgs e)
        {
            dgvAccount.Width = pnlRight.Width;
            dgvAccount.Height = pnlRight.Height;
        }

        private void Account_Resize_1(object sender, EventArgs e)
        {
            resize();
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = dgvAccount.CurrentRow.Index;

            txtFullName.Text = list[index].TenKH;
            txtAge.Text = list[index].Tuoi.ToString();
            txtAddress.Text = list[index].Diachi;
            txtGender.Text = list[index].Gioitinh;
            txtPhoneNumber.Text = list[index].Sdt;
            txtID.Text = list[index].AccID;

        }

        private void btShowAll_Click(object sender, EventArgs e)
        {
            btShowAll.Enabled = false;
            
            dgvAccount.DataSource = list;
            clearTextbox();
            
        }

        
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


        private void btFilter_Click(object sender, EventArgs e)
        {

            
            List<InfoAccDTO> listTemp = new List<InfoAccDTO>();


            if (txtDataFilter.Text != "")
            {
                if(cbxFilter.Text != "")
            {

                    
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
                                    if (cbxFilter.Text == "Sdt")
                                    {
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

                    dgvAccount.DataSource = listTemp;
                    btShowAll.Enabled = true;
                    clearTextbox();
                }
                else
                {
                    MessageBox.Show("chọn loại muốn lọc");
                }
            }
            else
            {
                MessageBox.Show("nhập dữ liệu lọc");
            }
           
        }


    }
}
