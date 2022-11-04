using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Data;
using System.Data.SqlClient;


namespace PresentationLayer
{
    public class Cls_KhachHang_PTA
    {
        Cls_KhachHang_BUS KH_BUS = new BusinessLogicLayer.Cls_KhachHang_BUS(); 

        public DataTable GetTable(string sDK)
        {
            return KH_BUS.GetTableKH(sDK);
        }

        public void Insert_Update_Delete(Cls_KhachHang_DTA KH_DATA,string sThucThi)
        {
            KH_BUS.Insert_Update_Delete_KH(KH_DATA, sThucThi);
        }

        public string TaoMa(string sTT,int Length)
        {
            return KH_BUS.TaoMa(sTT, Length);
        }
    }
}
