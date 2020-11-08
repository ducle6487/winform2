using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ProductDAL: DatabaseService
    {

        

        public List<ProductDTO> GetDataProduct()
        {
            List<ProductDTO> list = new List<ProductDTO>();

            try
            {
                string sql = "select * from Product";

                SqlDataReader reader = ReadData(sql);
                while (reader.Read())
                {
                    ProductDTO a = new ProductDTO();
                    a.ProductID = reader.GetInt32(0);
                    a.ProductName = reader.GetString(1);
                    a.Dongia = reader.GetSqlMoney(2).ToString();
                    a.LinkImg = reader.GetString(3);
                    list.Add(a);
                }

            }catch(Exception ex)
            {
                ex.ToString();

            }
            finally
            {
                closeConnection();
            }
            
            return list;
        }

    }
}
