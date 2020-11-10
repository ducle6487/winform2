using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SaleHistoryDTO
    {

        string billID;
        string tenKH;
        DateTime ngayDat;
        string tenSP;
        string size;
        int soLuong;
        string totalPrice;


        public string BillID { get => billID; set => billID = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public DateTime NgayDat { get => ngayDat; set => ngayDat = value; }
        public string Size { get => size; set => size = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
