using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

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
        public bool AddBillIncludeInfo(string billID, string accID, DateTime ngaydat, int ProductID, int soluong, string size, string tonggia)
        {
            bool kq = false;
            string IDbill = "B" + CountingBill() + 1;//id bill co dinh dang Bx voi x la so thu tu cua bill.

            if (AddBill(IDbill, accID, ngaydat))
            {

                try
                {

                    string sql = "insert into PaymentInfo values ( @bill, @product, @amount, @size, @total )";
                    SqlParameter bill = new SqlParameter("@bill", System.Data.SqlDbType.NVarChar);
                    SqlParameter product = new SqlParameter("@product", System.Data.SqlDbType.Int);
                    SqlParameter amount = new SqlParameter("@amount", System.Data.SqlDbType.Int);
                    SqlParameter sizing = new SqlParameter("@size", System.Data.SqlDbType.NVarChar);
                    SqlParameter total = new SqlParameter("@total", System.Data.SqlDbType.Money);

                    bill.Value = IDbill;
                    product.Value = ProductID;
                    amount.Value = soluong;
                    sizing.Value = size;
                    total.Value = tonggia;

                    kq = writeDataPars(sql, new[] { bill, product, amount, sizing, total });


                }catch(Exception ex)
                {
                    ex.ToString();
                }
                finally
                {
                    closeConnection();
                }

            }

            return kq;
        }

        //hàm lay lich su giao dich cua khach hang
        public List<PaymentHistoryDTO> GetInfoPaymentFromAccID(string Accid)
        {
            //danh sach thong tin giao dich
            List<PaymentHistoryDTO> list = new List<PaymentHistoryDTO>();

            
            try
            {
                //cau lenh query lay thong tin giao dich
                string sql = "select a.Path, a.ProductName, b.NgayDat, c.Size, c.Amount, c.TotalPrice "
                        + "from Product a, Payment b, PaymentInfo c where c.ProductID = @id and c.BillID = b.BillID and a.ProductID = c.ProductID";

                SqlParameter id = new SqlParameter("@id", System.Data.SqlDbType.NVarChar);
                id.Value = Accid;

                SqlDataReader reader = ReadDataPars(sql, new[] { id });


                while (reader.Read())
                {
                    //truyen thong tin giao dich vao danh sach
                    PaymentHistoryDTO a = new PaymentHistoryDTO();
                    a.LinkImage = reader.GetString(0);
                    a.ProductName = reader.GetString(1);
                    a.NgayDat = reader.GetDateTime(2);
                    a.Size = reader.GetString(3);
                    a.Amount = reader.GetInt32(4);
                    a.TotalPrice = reader.GetString(5);
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
