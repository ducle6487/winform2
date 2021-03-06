﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class SaleHistoryDAL:DatabaseService
    {

        //hàm lấy thong tin lich su giao dịch
        public List<SaleHistoryDTO> GetSaleHistories()
        {
            List<SaleHistoryDTO> list = new List<SaleHistoryDTO>();

            try
            {
                //câu lenh query lấy các thành phần co trong salehistoryDTO
                string sql =    "select c.BillID, a.TenKH, b.NgayDat, d.ProductName, c.Size, c.Amount, c.TotalPrice"
                                + " from AccInfo a, Payment b, PaymentInfo c, Product d"
                                + " where a.AccID = b.AccID and b.BillID = c.BillID and d.ProductID = c.ProductID";
                SqlDataReader reader = ReadData(sql);
                while (reader.Read())
                {
                    //tao bien salehistoryDTO va truyen du lieu vao
                    SaleHistoryDTO s = new SaleHistoryDTO();
                    s.BillID = reader.GetString(0);
                    s.TenKH = reader.GetString(1);
                    s.NgayDat = reader.GetDateTime(2);
                    s.TenSP = reader.GetString(3);
                    s.Size = reader.GetString(4);
                    s.SoLuong = reader.GetInt32(5);
                    s.TotalPrice = reader.GetSqlMoney(6).ToString();
                    //them bien vua tao vao list
                    list.Add(s);
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
