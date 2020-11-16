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
        //Khởi tạo biến ds list của class SalHistoryDTO
        List<SaleHistoryDTO> list = new List<SaleHistoryDTO>();
        //Khởi tạo biến bal của class SalHistoryBAL
        SaleHistoryBAL bal = new SaleHistoryBAL();
        //Hàm Load Form
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
        //Hàm Resize Form
        private void SaleHistory_Resize(object sender, EventArgs e)
        {
            pnlDgv.Width = Convert.ToInt32(this.Width * 0.7);
            pnlFilter.Width = Convert.ToInt32(this.Width * 0.3);
            pnlFilterInfo.Location = new Point(Convert.ToInt32((pnlFilter.Width / 2) - (pnlFilterInfo.Width / 2)), Convert.ToInt32((pnlFilter.Height / 2) - (pnlFilterInfo.Height / 2)));
        }
        //Hàm Clear TextBox
        private void clearTextbox()
        {
            txtDataFilter.Text = "";
            cbxFilter.Text = "";
        }
        //Hàm Load Dữ liệu lên Form
        private void loadDataToUI()
        {
            list = bal.GetSaleHistories();
            dgvSaleHistory.DataSource = list;

            if(list.Count < 0)
            {
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
        }
        //Hàm Button showAll_Click
        private void btShowAll_Click(object sender, EventArgs e)
        {
            loadDataToUI();
            btShowAll.Enabled = false;
            clearTextbox();
        }
        //Hàm Button DateFilter_Click
        private void btDateFilter_Click(object sender, EventArgs e)
        {
            if (dtpFrom.Value > dtpTo.Value)
            {
                //Ngày Đặt Hàng Lớn hơn ngày giao hàng
                //thông báo cho người dung
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
            }
            else
            {
                //Ngược Lại
                //Khởi tạo biến ds Listtemp của class SaleHistoryDTO
                List<SaleHistoryDTO> listTemp = new List<SaleHistoryDTO>();
                foreach (SaleHistoryDTO item in list)
                {
                    if (item.NgayDat >= dtpFrom.Value && item.NgayDat <= dtpTo.Value)
                    {
                        //Nếu thời gian ngày đặt của biến list nằm trong khoăng từ ngày đặt hàng cho đến ngày giao hàng
                        //thêm vào danh sách Listtemp
                        listTemp.Add(item);
                    }
                }
              
                dgvSaleHistory.DataSource = listTemp; // đổ dữ liệu vào datagridview
                btShowAll.Enabled = true; // cho nút ShowAll được hiển thị
                clearTextbox(); // làm sạch lại textbox
            }
        }
        
        //Hàm kiểm tra Số
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
        //Hàm btFilterTyped_Click
        private void btFilterTyped_Click(object sender, EventArgs e)
        {
            // Khởi tạo   biến ds Listtemp của class SaleHistoryDTO
            List<SaleHistoryDTO> listTemp = new List<SaleHistoryDTO>();


            if (txtDataFilter.Text != "")
            {
                //Kiểm tra textboxDatàilter khác rỗng
                if (cbxFilter.Text != "")
                {
                    //Kiểm tra cbxFilter khác rỗng

                    if (cbxFilter.Text == "BillID")
                    {
                        //Nếu cbxFilter == BillID
                        foreach (SaleHistoryDTO info in list)
                        {
                            //Lấy từng biến trong list
                            if (info.BillID == txtDataFilter.Text)
                            {
                                //Kiẻm tra từng  BIllID của biến với textboxDataFilter  mà bằng nhau
                                listTemp.Add(info);// thêm vào listTemp
                            }
                        }
                    }
                    else
                    {
                        //Ngược Lại
                        if (cbxFilter.Text == "TenKH")
                        {
                            //Kiểm TRa cái cbxFilter mà bằng TenKH
                            foreach (SaleHistoryDTO info in list)
                            {
                                //Lấy từng biến trong list
                                if (info.TenKH == txtDataFilter.Text)
                                {
                                    //Kiểm tra từng TenKH trong biến với textboxDataFilter
                                    listTemp.Add(info); // thêm vào listtemp
                                }
                            }
                        }
                        else
                        {
                            //Ngược Lại
                            if (cbxFilter.Text == "TenSP")
                            {
                                //Kiểm tra cbxFilter == TenSP
                                foreach (SaleHistoryDTO info in list)
                                {
                                    //Lấy từng biến trong list
                                    if (info.TenSP == txtDataFilter.Text)
                                    {  //Kiểm tra từng TenSP trong biến với textboxDataFilter
                                        listTemp.Add(info); // thêm vào listtemp
                                    }
                                }
                            }
                            else
                            {
                                //ngược Lịa
                                if (cbxFilter.Text == "Size")
                                {                             
                                    //Kiểm tra cbxFilter == Size
                                    foreach (SaleHistoryDTO info in list)
                                    {
                                        //Lấy từng biến trong list
                                        if (info.Size == txtDataFilter.Text)
                                        { //Kiểm tra từng TenSP trong biến với textboxDataFilter
                                            listTemp.Add(info); // thêm vào listtemp
                                        }
                                    }
                                }
                                else
                                {
                                    //Ngược Lại
                                    if (cbxFilter.Text == "SoLuong")
                                    { 
                                        //Kiểm tra cbxFilter == SoLuong
                                        if (checkNumber(txtDataFilter.Text))
                                        {
                                            //Kiểm tra cái textbox phải là số không
                                            foreach (SaleHistoryDTO info in list)
                                            {
                                                //Lấy từng biến trong list

                                                if (info.SoLuong == Convert.ToInt32(txtDataFilter.Text))
                                                {
                                                    //Kiểm tra từng TenSP trong biến với textboxDataFilter
                                                    listTemp.Add(info);// thêm vào listtemp
                                                }
                                            }
                                        }
                                        else
                                        {
                                            //Ngược Lại 
                                            //Thông báo cho người dùng
                                            MessageBox.Show("số lượng phải là số");
                                        }
                                    }
                                    else
                                    {
                                        //Ngược Lại
                                        if (cbxFilter.Text == "TotalPrice")
                                        {
                                            if (checkNumber(txtDataFilter.Text))
                                            {
                                                //Kiểm tra có phải là số hay không
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
                                                //ngược Lại
                                                //Thông báo cho người dùng
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
                    //Ngược Lại
                    //Thông báo cho người dùng
                    MessageBox.Show("chọn loại muốn lọc");
                }
            }
            else
            {
                //Ngược Lại
                //Thông báo cho người dùng
                MessageBox.Show("nhập dữ liệu lọc");
            }

        }
    }
}
