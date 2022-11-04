using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public class Cls_NhanPhong_PTA
    {
        Cls_NhanPhong_BUS NPhong_BUS = new Cls_NhanPhong_BUS();

        public DataTable GetTable(string sDK)
        {
            return NPhong_BUS.GetTableNhanPhong(sDK);
        }

        public void Insert_Update_Delete(Cls_NhanPhong_DTA NPhong_DATA,string sThucThi)
        {
            NPhong_BUS.Insert_Update_Delete(NPhong_DATA, sThucThi);
        }

        public string TaoMa(string STT,int Length)
        {
            return NPhong_BUS.TaoMa(STT, Length);
        }
    }
}
