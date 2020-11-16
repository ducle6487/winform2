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

        
        //hàm lấy thông tin sản phẩm
        public List<ProductDTO> GetDataProduct()
        {
            //danh sach ket qua
            List<ProductDTO> list = new List<ProductDTO>();

            try
            {
                //query lấy thong tin
                string sql = "select * from Product";

                SqlDataReader reader = ReadData(sql);
                while (reader.Read())
                {
                    //tao 1 bien productDTO va truuyen du lieu vao
                    ProductDTO a = new ProductDTO();
                    a.ProductID = reader.GetString(0);
                    a.ProductName = reader.GetString(1);
                    a.Dongia = reader.GetSqlMoney(2).ToString();
                    a.LinkImg = reader.GetString(3);
                    //them bien vua tao vao list
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
