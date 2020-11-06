using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PaymentDAL:DatabaseService
    {

        //hàm dem so luong bill trong db
        private int CountingBill()
        {
            int kq = 0;//defalt values

            try
            {
                //query dem so luong bill trong Payment table
                string sql = "select count(*) from Payment";
                SqlDataReader reader = ReadData(sql);
                if (reader.Read())
                {
                    //lay gia tri dem dc gan vao kq
                    kq = reader.GetInt32(0);
                }
            }catch(Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                closeConnection();
            }
            //tra ve sl bill
            return kq;
        }

        //hàm them bill vao table Payment
        private bool AddBill(string billID, string accID, DateTime ngaydat)
        {
            bool kq = false;

            

            try
            {
                //query them 1 bill vao payment
                string sql = "insert into Payment values ( @bill, @acc, @date )";
                SqlParameter bill = new SqlParameter("@bill", System.Data.SqlDbType.NVarChar);
                SqlParameter acc = new SqlParameter("@acc", System.Data.SqlDbType.NVarChar);
                SqlParameter date = new SqlParameter("@date", System.Data.SqlDbType.DateTime);

                bill.Value = billID;
                acc.Value = accID;
                date.Value = ngaydat;

                //gan ket qua thuc hien cau lenh tren
                kq = writeDataPars(sql, new[] { bill, acc, date });

            }catch(Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                closeConnection();
            }

            //tra ve ket qua thuc hien tren
            return kq;
        }

        //ham them bill voi infoBill
        public bool AddBillIncludeInfo(string billID, string accID, DateTime ngaydat, )



    }
}
