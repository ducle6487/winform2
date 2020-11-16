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
    public partial class HistoryTrade : Form
    {
        public HistoryTrade()
        {
            InitializeComponent();
        }

        public HistoryTrade(string AccID)
        {
            InitializeComponent();
            this.Accid = AccID;
        }
        //Tọa ibến Accid
        string Accid = "";
        //Khởi tạo biến ds list của class PaymentHistoryDTO
        List<PaymentHistoryDTO> list = new List<PaymentHistoryDTO>();
        //Khởi tạo biến bal của class PaymentBAl
        PaymentBAL bal = new PaymentBAL();
        //Hàm load Form HistoryTrade
        private void HistoryTrade_Load(object sender, EventArgs e)
        {

            dgvHistory.Width = this.Width;
            dgvHistory.Height = this.Height;
            loadDataToUI();
            btShowAll.Enabled = false;

        }

        
        //Hàm Load Giao Diện Trang
        private void loadDataToUI()
        {
            list = bal.GetInfoPaymentFromAccID(Accid);
            dgvHistory.DataSource = list;
            if(list.Count > 0)
            {
                // cho giá trị min,max bằng giá trị của ngày đặt của biến đầu tiên
                DateTime min = list[0].NgayDat;
                DateTime max = list[0].NgayDat;

                foreach (PaymentHistoryDTO item in list)
                {
                    if (item.NgayDat < min)
                    {
                        //Kiểm tra nếu ngày đặt mà nhỏ hơn min
                        //thì set lại min
                        min = item.NgayDat;
                    }
                    if (item.NgayDat > max)
                    {
                        //Kiểm tra nếu ngày đặt lớn hơn max
                        //thì set lại max
                        max = item.NgayDat;
                    }
                }

                dtpFrom.Value = min;
                dtpTo.Value = max;
            }
        }
        //Hàm Resize Form HistoryTrade
        private void HistoryTrade_Resize(object sender, EventArgs e)
        {
            dgvHistory.Width = this.Width;
            dgvHistory.Height = this.Height;
        }
        //Hàm btFilter_Click
        private void btFilter_Click(object sender, EventArgs e)
        {
            
            if(dtpFrom.Value > dtpTo.Value)
            {
                //kiểm tra ngày đi và ngày đến 
                //nếu ngày đi lớn hơn ngày giao thì thông báo cho người dùng
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
            }
            else
            {
                //Ngược Lại
                //Khởi tạo biến ds listTemp của class PaymenthistoryDTO
                List<PaymentHistoryDTO> listTemp = new List<PaymentHistoryDTO>();
                foreach(PaymentHistoryDTO item in list)
                {
                    //Lấy từng biến trong ds
                    if(item.NgayDat >= dtpFrom.Value && item.NgayDat <= dtpTo.Value)
                    {
                        //Nếu thời gian đặt của biến trong khoảng thời gian từ ngày đặt đến ngày giao
                        listTemp.Add(item); // thêm vào listtemp
                    }
                }

                dgvHistory.DataSource = listTemp;
                btShowAll.Enabled = true;
            }
        }
        //Hàm btShowAll_Click
        private void btShowAll_Click(object sender, EventArgs e)
        {
            loadDataToUI(); // gọi lại hàm LoadDataUI
            btShowAll.Enabled = false; // cho nút btShowAll Ẩn
        }
    }
}
