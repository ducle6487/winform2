using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PaymentHistoryDTO
    {

        string billID;
        string productName;
        DateTime ngayDat;
        string size;
        int amount;
        string totalPrice;


        public string BillID { get => billID; set => billID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public DateTime NgayDat { get => ngayDat; set => ngayDat = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Size { get => size; set => size = value; }
        public string TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
