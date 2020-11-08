using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PaymentHistoryDTO
    {

        string linkImage;
        string productName;
        DateTime ngayDat;
        string size;
        int amount;
        string totalPrice;


        public string ProductName { get => productName; set => productName = value; }
        public int Amount { get => amount; set => amount = value; }
        public DateTime NgayDat { get => ngayDat; set => ngayDat = value; }
        public string LinkImage { get => linkImage; set => linkImage = value; }
        public string TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string Size { get => size; set => size = value; }
    }
}
