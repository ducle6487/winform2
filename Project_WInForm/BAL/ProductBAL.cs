using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BAL
{
    public class ProductBAL
    {

        ProductDAL dal = new ProductDAL();

        public List<ProductDTO> GetDataProduct()
        {
            return dal.GetDataProduct();
        }

    }
}
