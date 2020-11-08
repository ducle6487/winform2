using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductDTO
    {

        int productID;
        string productName;
        string dongia;
        string linkImg;

        public int ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Dongia { get => dongia; set => dongia = value; }
        public string LinkImg { get => linkImg; set => linkImg = value; }
    }
}
