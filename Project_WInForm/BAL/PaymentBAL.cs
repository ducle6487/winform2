using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BAL
{
    public class PaymentBAL
    {

        PaymentDAL dal = new PaymentDAL();

        public bool AddBillIncludeInfo(string billID, string ProductID, int soluong, string size, string tonggia)
        {
            return dal.AddBillIncludeInfo(billID, ProductID, soluong, size, tonggia);
        }

        public string generateBill(string AccID, DateTime ngaydat)
        {
            return dal.generateBill(AccID,ngaydat);
        }

        public List<PaymentHistoryDTO> GetInfoPaymentFromAccID(string Accid)
        {
            return dal.GetInfoPaymentFromAccID(Accid);
        }

    }
}
