using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                reader.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }

            //tra ve ket qua thuc hien tren
            return kq;
        }


        //hàm new bill
        public string generateBill(string AccID, DateTime ngaydat)
        {
            
            string IDbill = "B" + (CountingBill() + 1);//id bill co dinh dang Bx voi x la so thu tu cua bill.

            AddBill(IDbill, AccID, ngaydat);

            return IDbill;
        }



        //ham them bill voi infoBill
        public bool AddBillIncludeInfo(string billID, string ProductID, int soluong, string size, string tonggia)
        {

            bool kq = false;


            try
            {

                string sql = "insert into PaymentInfo values ( @bill, @product, @amount, @size, @total )";
                SqlParameter bill = new SqlParameter("@bill", System.Data.SqlDbType.NVarChar);
                SqlParameter product = new SqlParameter("@product", System.Data.SqlDbType.NVarChar);
                SqlParameter amount = new SqlParameter("@amount", System.Data.SqlDbType.Int);
                SqlParameter sizing = new SqlParameter("@size", System.Data.SqlDbType.NVarChar);
                SqlParameter total = new SqlParameter("@total", System.Data.SqlDbType.Money);

                bill.Value = billID;
                product.Value = ProductID;
                amount.Value = soluong;
                sizing.Value = size;
                total.Value = Convert.ToDouble(tonggia);

                kq = writeDataPars(sql, new[] { bill, product, amount, sizing, total });


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
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
                string sql = "select c.BillID, a.ProductName, b.NgayDat, c.Size, c.Amount, c.TotalPrice "
                        + "from Product a, Payment b, PaymentInfo c where b.AccID = @id and c.BillID = b.BillID and a.ProductID = c.ProductID";

                SqlParameter id = new SqlParameter("@id", System.Data.SqlDbType.NVarChar);
                id.Value = Accid;

                SqlDataReader reader = ReadDataPars(sql, new[] { id });


                while (reader.Read())
                {
                    //truyen thong tin giao dich vao danh sach
                    PaymentHistoryDTO a = new PaymentHistoryDTO();
                    a.BillID = reader.GetString(0);
                    a.ProductName = reader.GetString(1);
                    a.NgayDat = reader.GetDateTime(2);
                    a.Size = reader.GetString(3);
                    a.Amount = reader.GetInt32(4);
                    a.TotalPrice = reader.GetSqlMoney(5).ToString();
                    list.Add(a);
                }
                reader.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }

            return list;
        }
        
    }
}
