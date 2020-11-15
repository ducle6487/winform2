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
    public partial class SaleHistory : Form
    {
        public SaleHistory()
        {
            InitializeComponent();
        }

        List<SaleHistoryDTO> list = new List<SaleHistoryDTO>();

        SaleHistoryBAL bal = new SaleHistoryBAL();

        private void SaleHistory_Load(object sender, EventArgs e)
        {

            loadDataToUI();
            pnlDgv.Width = Convert.ToInt32(this.Width * 0.7);
            btShowAll.Enabled = false;

            for (int i = 1; i <= dgvSaleHistory.Columns.Count; i++)
            {
                if (dgvSaleHistory.Columns[i - 1].HeaderText != "NgayDat")
                {
                    cbxFilter.Items.Add(dgvSaleHistory.Columns[i - 1].HeaderText);
                }
            }

        }

        private void SaleHistory_Resize(object sender, EventArgs e)
        {
            pnlDgv.Width = Convert.ToInt32(this.Width * 0.7);
            pnlFilter.Width = Convert.ToInt32(this.Width * 0.3);
            pnlFilterInfo.Location = new Point(Convert.ToInt32((pnlFilter.Width / 2) - (pnlFilterInfo.Width / 2)), Convert.ToInt32((pnlFilter.Height / 2) - (pnlFilterInfo.Height / 2)));
        }

        private void clearTextbox()
        {
            txtDataFilter.Text = "";
            cbxFilter.Text = "";
        }

        private void loadDataToUI()
        {
            list = bal.GetSaleHistories();
            dgvSaleHistory.DataSource = list;

            DateTime min = list[0].NgayDat;
            DateTime max = list[0].NgayDat;

            foreach (SaleHistoryDTO item in list)
            {
                if (item.NgayDat < min)
                {
                    min = item.NgayDat;
                }
                if (item.NgayDat > max)
                {
                    max = item.NgayDat;
                }
            }

            dtpFrom.Value = min;
            dtpTo.Value = max;
        }

        private void btShowAll_Click(object sender, EventArgs e)
        {
            loadDataToUI();
            btShowAll.Enabled = false;
            clearTextbox();
        }

        private void btDateFilter_Click(object sender, EventArgs e)
        {
            if (dtpFrom.Value > dtpTo.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
            }
            else
            {

                List<SaleHistoryDTO> listTemp = new List<SaleHistoryDTO>();
                foreach (SaleHistoryDTO item in list)
                {
                    if (item.NgayDat >= dtpFrom.Value && item.NgayDat <= dtpTo.Value)
                    {
                        listTemp.Add(item);
                    }
                }

                dgvSaleHistory.DataSource = listTemp;
                btShowAll.Enabled = true;
                clearTextbox();
            }
        }
        

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

        private void btFilterTyped_Click(object sender, EventArgs e)
        {

            List<SaleHistoryDTO> listTemp = new List<SaleHistoryDTO>();


            if (txtDataFilter.Text != "")
            {
                if (cbxFilter.Text != "")
                {


                    if (cbxFilter.Text == "BillID")
                    {
                        foreach (SaleHistoryDTO info in list)
                        {
                            if (info.BillID == txtDataFilter.Text)
                            {
                                listTemp.Add(info);
                            }
                        }
                    }
                    else
                    {
                        if (cbxFilter.Text == "TenKH")
                        {
                            foreach (SaleHistoryDTO info in list)
                            {
                                if (info.TenKH == txtDataFilter.Text)
                                {
                                    listTemp.Add(info);
                                }
                            }
                        }
                        else
                        {
                            if (cbxFilter.Text == "TenSP")
                            {
                                foreach (SaleHistoryDTO info in list)
                                {
                                    if (info.TenSP == txtDataFilter.Text)
                                    {
                                        listTemp.Add(info);
                                    }
                                }
                            }
                            else
                            {
                                if (cbxFilter.Text == "Size")
                                {
                                    foreach (SaleHistoryDTO info in list)
                                    {
                                        if (info.Size == txtDataFilter.Text)
                                        {
                                            listTemp.Add(info);
                                        }
                                    }
                                }
                                else
                                {
                                    if (cbxFilter.Text == "SoLuong")
                                    {
                                        if (checkNumber(txtDataFilter.Text))
                                        {
                                            foreach (SaleHistoryDTO info in list)
                                            {
                                                if (info.SoLuong == Convert.ToInt32(txtDataFilter.Text))
                                                {
                                                    listTemp.Add(info);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("số lượng phải là số");
                                        }
                                    }
                                    else
                                    {
                                        if (cbxFilter.Text == "TotalPrice")
                                        {
                                            if (checkNumber(txtDataFilter.Text))
                                            {
                                                foreach (SaleHistoryDTO info in list)
                                                {
                                                    if (Convert.ToDouble(info.TotalPrice) == Convert.ToDouble(txtDataFilter.Text))
                                                    {
                                                        listTemp.Add(info);
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Giá phải là số");
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }

                    dgvSaleHistory.DataSource = listTemp;
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
