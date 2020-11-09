using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BAL
{
    public class SaleHistoryBAL
    {

        SaleHistoryDAL dal = new SaleHistoryDAL();

        public List<SaleHistoryDTO> GetSaleHistories()
        {
            return dal.GetSaleHistories();
        }

    }
}
