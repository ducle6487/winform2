using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class SizeDAL:DatabaseService
    {

        //hàm lấy thông tin tất cac3 các size 
        public List<string> getSize()
        {
            List<string> kq = new List<string>();

            try
            {
                //câu lệnh query
                string sql = "select * from SizeInfo";
                SqlDataReader reader = ReadData(sql);
                while (reader.Read())
                {
                    //them size vào ds ket qua
                    kq.Add(reader.GetString(0));
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

            return kq;
        }

    }
}
