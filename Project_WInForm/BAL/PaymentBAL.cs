using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BAL
{
    class PaymentBAL
    {

        PaymentDAL dal = new PaymentDAL();

        public bool AddBillIncludeInfo(string billID, string accID, DateTime ngaydat, int ProductID, int soluong, string size, string tonggia)
        {
            return dal.AddBillIncludeInfo(billID, accID, ngaydat, ProductID, soluong, size, tonggia);
        }

        public List<PaymentHistoryDTO> GetInfoPaymentFromAccID(string Accid)
        {
            return dal.GetInfoPaymentFromAccID(Accid);
        }

    }
}
