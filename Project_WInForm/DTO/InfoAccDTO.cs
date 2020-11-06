using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class InfoAccDTO
    {

        string accID;
        string tenKH;
        string diachi;
        DateTime ngaysinh;
        string gioitinh;
        string sdt;

        public string AccID { get => accID; set => accID = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
