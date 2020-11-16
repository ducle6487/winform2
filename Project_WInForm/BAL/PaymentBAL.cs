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

        //hàm thêm 1 bill + thông tin bill
        public bool AddBillIncludeInfo(string billID, string ProductID, int soluong, string size, string tonggia)
        {
            return dal.AddBillIncludeInfo(billID, ProductID, soluong, size, tonggia);
        }


        //tạo mới 1 bill
        public string generateBill(string AccID, DateTime ngaydat)
        {
            return dal.generateBill(AccID,ngaydat);
        }

        //lấy thông tin bill từ AccID
        public List<PaymentHistoryDTO> GetInfoPaymentFromAccID(string Accid)
        {
            return dal.GetInfoPaymentFromAccID(Accid);
        }

    }
}
