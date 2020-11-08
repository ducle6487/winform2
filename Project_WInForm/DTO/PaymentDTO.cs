using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PaymentDTO
    {

        string billID;
        string accID;
        DateTime ngaydat;

        public string BillID { get => billID; set => billID = value; }
        public string AccID { get => accID; set => accID = value; }
        public DateTime Ngaydat { get => ngaydat; set => ngaydat = value; }
    }
}
