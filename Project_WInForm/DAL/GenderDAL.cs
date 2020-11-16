using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GenderDAL: DatabaseService
    {

        //hàm lấy thông tin giới tính
        public List<GenderDTO> GetInfoGender()
        {
            List<GenderDTO> list = new List<GenderDTO>();

            try
            {
                //cau lenh query lấy thông tin gender
                string sql = "select * from GenderType";

                SqlDataReader reader = ReadData(sql);
                while (reader.Read())
                {
                    //tao 1 bien genderdto truyen dữ liệu vào
                    GenderDTO g = new GenderDTO();
                    g.GenderID = reader.GetInt32(0);
                    g.Des1 = reader.GetString(1);
                    //them bien vua tao vao list gender
                    list.Add(g);
                }
                reader.Close();
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
