using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InfoAccDTO
    {

        string accID;
        string tenKH;
        string diachi;

        int tuoi;
        string gioitinh;
        string sdt;

        public string AccID { get => accID; set => accID = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
    }
}
