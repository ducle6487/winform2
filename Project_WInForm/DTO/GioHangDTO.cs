using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class GioHangDTO
    {

        string productName;
        string size;
        int soluong;
        int dongia;
        string imgLink;

        public string ProductName { get => productName; set => productName = value; }
        public string Size { get => size; set => size = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string ImgLink { get => imgLink; set => imgLink = value; }
        public int Dongia { get => dongia; set => dongia = value; }
    }
}
