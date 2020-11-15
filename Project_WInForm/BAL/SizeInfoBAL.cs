using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class SizeInfoBAL
    {

        SizeDAL dal = new SizeDAL();

        public List<string> getSize()
        {
            return dal.getSize();
        }

    }
}
