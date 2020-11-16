using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BAL
{
    public class AccountBAL
    {

        AccountDAL dal = new AccountDAL();

        //hàm kiem tra dang nhap
        public int LogInChecking(string user, string pass)
        {

            return dal.LogInChecking(user, pass);

        }

        //hàm dang ky tai khoan + thong tin tai khoan
        public bool RegisterAccountIncludeInfo(string user, string pass, string ten, string diachi, int namsinh, string gioitinh, string sdt)
        {
            return dal.RegisterAccountIncludeInfo(user, pass, ten, diachi, namsinh, gioitinh, sdt);
        }

        //ham cap nhat thong tin tai khoan
        public bool UpdateInfoAccount(string AccID, string ten, string diachi, int namsinh, string gioitinh, string sdt)
        {
            return dal.UpdateInfoAccount(AccID, ten, diachi, namsinh, gioitinh, sdt);
        }

        //hàm đổi mật khẩu
        public bool ChangePassword(string Accid, string oldPass, string newPass)
        {
            return dal.ChangePassword(Accid, oldPass, newPass);
        }

        //hàm lấy thông tin tài khoản với username truyền vào
        public InfoAccDTO GetInfoFromUsername(string username)
        {
            return dal.GetInfoFromUsername(username);
        }


        //hàm lấy thông tin tất cả tài khoản
        public List<InfoAccDTO> GetInfoAccs()
        {
            return dal.GetInfoAccs();
        }

    }
}
