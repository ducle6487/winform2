using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InfoPaymentDTO
    {

        string billID;
        int productID;
        int soluong;
        string size;

        public string BillID { get => billID; set => billID = value; }
        public int ProductID { get => productID; set => productID = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Size { get => size; set => size = value; }
    }
}
