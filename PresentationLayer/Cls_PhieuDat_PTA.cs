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
    public class Cls_PhieuDat_PTA
    {
        Cls_PhieuDat_BUS PD_BUS = new BusinessLogicLayer.Cls_PhieuDat_BUS();

        public DataTable GetTablePhieuDP(string sDK)
        {
            return PD_BUS.GetTablePhieuDP(sDK);
        }

        public void Insert_Update_Delete(Cls_PhieuDat_DTA PD_DATA,string sThucThi)
        {
            PD_BUS.Insert_Delete_Update(PD_DATA, sThucThi);
        }

        public string TaoMa(string STT,int Length)
        {
            return PD_BUS.TaoMa(STT, Length);
        }
    }
}
