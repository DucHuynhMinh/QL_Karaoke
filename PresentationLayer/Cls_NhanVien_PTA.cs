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
    public class Cls_NhanVien_PTA
    {
        Cls_NhanVien_BUS NV_Bus = new Cls_NhanVien_BUS();

        public DataTable GetTable(string sDK)
        {
            return NV_Bus.GetTable(sDK);
        }

        public void Insert_Update_Delete(Cls_NhanVien_DTA NV_Data,string sThucThi)
        {
            NV_Bus.Insert_Update_Delete(NV_Data, sThucThi);
        }
        //Download source code FREE tai Sharecode.vn
        public string TaoMa(string STT,int Length)
        {
            return NV_Bus.TaoMa(STT, Length);
        }
    }
}
