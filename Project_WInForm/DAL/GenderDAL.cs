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

        public List<GenderDTO> GetInfoGender()
        {
            List<GenderDTO> list = new List<GenderDTO>();

            try
            {
                string sql = "select * from GenderType";

                SqlDataReader reader = ReadData(sql);
                while (reader.Read())
                {
                    GenderDTO g = new GenderDTO();
                    g.GenderID = reader.GetInt32(0);
                    g.Des1 = reader.GetString(1);
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
