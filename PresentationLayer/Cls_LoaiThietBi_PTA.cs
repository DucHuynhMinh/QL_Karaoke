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
    public class Cls_LoaiThietBi_PTA
    {
        Cls_LoaiThietBi_BUS LoaiTB_BUS = new Cls_LoaiThietBi_BUS();

        public DataTable GetTable(string sDK)
        {
            return LoaiTB_BUS.GetTableLoaiTB(sDK);
        }

        public void Insert_Update_Delete(Cls_LoaiThietBi_DTA LoaiTB_Data,string sThucThi)
        {
            LoaiTB_BUS.Insert_Update_Delete(LoaiTB_Data, sThucThi);
        }

        public string TaoMa(string sTT,int Length)
        {
            return LoaiTB_BUS.TaoMa(sTT, Length);
        }
    }
}
