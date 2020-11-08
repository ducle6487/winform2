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

        public int LogInChecking(string user, string pass)
        {

            return dal.LogInChecking(user, pass);

        }

        public bool RegisterAccountIncludeInfo(string user, string pass, string ten, string diachi, int namsinh, string gioitinh, string sdt)
        {
            return dal.RegisterAccountIncludeInfo(user, pass, ten, diachi, namsinh, gioitinh, sdt);
        }

        public bool UpdateInfoAccount(string AccID, string ten, string diachi, int namsinh, string gioitinh, string sdt)
        {
            return dal.UpdateInfoAccount(AccID, ten, diachi, namsinh, gioitinh, sdt);
        }

        public bool ChangePassword(string Accid, string oldPass, string newPass)
        {
            return dal.ChangePassword(Accid, oldPass, newPass);
        }


    }
}
