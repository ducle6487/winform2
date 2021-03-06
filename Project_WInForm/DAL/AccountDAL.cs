﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class AccountDAL:DatabaseService
    {

        //ham kiem tra login account
        public int LogInChecking(string user, string pass)
        {
            int kq = 0;//bien chua loai account 1 là admin, 2 la user

            try
            {
                //query lay acc type cua account dang nhap
                string sql = "select Acctype from Account where Username = @user and Password = @pass";
                //cac parameter chua username pass;
                SqlParameter username = new SqlParameter("@user", SqlDbType.NVarChar);
                SqlParameter password = new SqlParameter("@pass", SqlDbType.NVarChar);
                username.Value = user;
                password.Value = pass;

                SqlDataReader reader = ReadDataPars(sql, new[] { username, password });

                if (reader.Read())
                {
                    //lay type acc gan vao kq
                    kq = reader.GetInt32(0);
                }
                reader.Close();
            }catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                //ket thuc try catch thi dong connection lai
                closeConnection();
            }

            return kq;//tra ve kq tim dc

        }

        //hàm lấy thông tin thông qua AccID
        public InfoAccDTO GetInfoFromUsername(string username)
        {
            InfoAccDTO kq = new InfoAccDTO();

            try
            {

                string sql = "select b.AccID,b.TenKH,b.DiaChi,b.Tuoi,b.GioiTinh,b.SDT from Account a, AccInfo b where a.Username=@id and a.AccID = b.AccID";
                SqlParameter user = new SqlParameter("@id", SqlDbType.NVarChar);
                user.Value = username;
                SqlDataReader reader = ReadDataPars(sql, new[] { user });
                if (reader.Read())
                {
                    kq.AccID = reader.GetString(0);
                    kq.TenKH = reader.GetString(1);
                    kq.Diachi = reader.GetString(2);
                    kq.Tuoi = reader.GetInt32(3);
                    kq.Gioitinh = reader.GetString(4);
                    kq.Sdt = reader.GetString(5);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return kq;
        }

        //hàm kiem tra ton tai account truoc khi dang ky
        private bool CheckExistAccount(string user)
        {
            bool kq = false;//bien chua kq tra ve

            try
            {
                //query kiem tra so sanh username dang ky voi danh sach username trong db
                string sql = "select * from Account where Username = @user";
                SqlParameter username = new SqlParameter("@user", SqlDbType.NVarChar);
                username.Value = user;

                SqlDataReader reader = ReadDataPars(sql, new[] { username });
                if (reader.Read())
                {
                    //neu ton tai account trong db gan kq = true
                    kq = true;
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

            return kq;//tra ve bool

        }

        //ham dem so luong account trong db
        private int CountingAccount()
        {
            int kq=0;

            try
            {
                //query dem so luong account trong db
                string sql = "select count(*) from Account";
                SqlDataReader reader = ReadData(sql);
                if (reader.Read())
                {
                    //gan kq bang so luong acc dem dc
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

            return kq;//tra ve sl account
        }

        //hàm dang ky account user
        private bool RegisterAccount(string AccID , string user, string pass)
        {
            bool kq = false;

            try
            {
                //query them account vao table account
                string sql = "insert into Account values( @id, @user, @pass, 2 )";
                SqlParameter id = new SqlParameter("@id", SqlDbType.NVarChar);
                SqlParameter username = new SqlParameter("@user", SqlDbType.NVarChar);
                SqlParameter password = new SqlParameter("@pass", SqlDbType.NVarChar);
                id.Value = AccID;
                username.Value = user;
                password.Value = pass;

                //bien chua trang thai da add dc hay chua
                kq = writeDataPars(sql, new[] { id, username, password });

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }

            return kq;
        }



        //ham dang ky  account kem thong tin
        public bool RegisterAccountIncludeInfo(string user, string pass, string ten, string diachi, int tuoi, string gioitinh, string sdt)
        {

            bool kq = false;
            

            //kiem tra ton tai
            if (CheckExistAccount(user)==false)
            {
                //tao id de add acccount 
                //co dinh dang Ax, x la so
                int stt = CountingAccount();
                string id = "A" + (stt +1);

                if (RegisterAccount(id, user, pass))
                {
                    try
                    {
                        //query add info vao table InfoAcc
                        string sql = "insert into AccInfo values ( @id, @name, @address, @birth, @gender, @phone )";
                        //cac bien chua thong tn so sanh trong query
                        SqlParameter Accid = new SqlParameter("@id", SqlDbType.NVarChar);
                        SqlParameter name = new SqlParameter("@name", SqlDbType.NVarChar);
                        SqlParameter address = new SqlParameter("@address", SqlDbType.NVarChar);
                        SqlParameter birth = new SqlParameter("@birth", SqlDbType.Int);
                        SqlParameter gender = new SqlParameter("@gender", SqlDbType.NVarChar);
                        SqlParameter phone = new SqlParameter("@phone", SqlDbType.NVarChar);

                        Accid.Value = id;
                        name.Value = ten;
                        address.Value = diachi;
                        birth.Value = tuoi;
                        gender.Value = gioitinh;
                        phone.Value = sdt;
                        //bien chua trang thai da add dc hay chua
                        kq = writeDataPars(sql, new[] { Accid, name, address, birth, gender, phone });

                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        closeConnection();
                    }
                }

            }


            return kq;
        }


        //ham update Account Info
        public bool UpdateInfoAccount(string AccID, string ten, string diachi, int tuoi, string gioitinh, string sdt)
        {
            bool kq = false;

            try
            {
                //query update acccount voi accis dc truyen vao
                string sql = "update AccInfo set TenKH = @name, DiaChi = @address, Tuoi = @birth, GioiTinh = @gender, SDT = @phone where AccID = @id";
                SqlParameter Accid = new SqlParameter("@id", SqlDbType.NVarChar);
                SqlParameter name = new SqlParameter("@name", SqlDbType.NVarChar);
                SqlParameter address = new SqlParameter("@address", SqlDbType.NVarChar);
                SqlParameter birth = new SqlParameter("@birth", SqlDbType.Int);
                SqlParameter gender = new SqlParameter("@gender", SqlDbType.NVarChar);
                SqlParameter phone = new SqlParameter("@phone", SqlDbType.NVarChar);

                Accid.Value = AccID;
                name.Value = ten;
                address.Value = diachi;
                birth.Value = tuoi;
                gender.Value = gioitinh;
                phone.Value = sdt;

                //kq gan bang ket qua cua ham viet du lieu vao db
                kq = writeDataPars(sql, new[] { Accid, name, address, birth, gender, phone });

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


        //hàm đổi mật khẩu
        public bool ChangePassword(string Accid, string oldPass, string newPass)
        {
            bool kq = false;

            try
            {
                //query cap nhat password voi accid truyen vao;
                string sql = "update Account set Password = @newpass where AccID = @id and Password = @oldpass";
                SqlParameter id = new SqlParameter("@id", SqlDbType.NVarChar);
                SqlParameter oldpass = new SqlParameter("@oldpass", SqlDbType.NVarChar);
                SqlParameter newpass = new SqlParameter("@newpass", SqlDbType.NVarChar);

                id.Value = Accid;
                oldpass.Value = oldPass;
                newpass.Value = newPass;

                kq = writeDataPars(sql, new[] { id, oldpass, newpass });

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }

            return kq;
        }


        //hàm lấy thông tin Account
        public List<InfoAccDTO> GetInfoAccs()
        {
            List<InfoAccDTO> list = new List<InfoAccDTO>();

            try
            {
                string sql = "select b.* from Account a, AccInfo b where a.AccID = b.AccID and a.Acctype = 2";
                SqlDataReader reader = ReadData(sql);
                while (reader.Read())
                {
                    InfoAccDTO i = new InfoAccDTO();
                    i.AccID = reader.GetString(0);
                    i.TenKH = reader.GetString(1);
                    i.Diachi = reader.GetString(2);
                    i.Tuoi = reader.GetInt32(3);
                    i.Gioitinh = reader.GetString(4);
                    i.Sdt = reader.GetString(5);
                    list.Add(i);
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
