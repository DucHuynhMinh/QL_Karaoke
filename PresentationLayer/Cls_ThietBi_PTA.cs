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
    public class Cls_ThietBi_PTA
    {
        Cls_ThietBi_BUS TB_Bus = new Cls_ThietBi_BUS();

        public DataTable GetTable(string sDK)
        {
            return TB_Bus.GetTableThietBi(sDK);
        }
        //Download source code FREE tai Sharecode.vn
        public string TaoMa(string sTT,int Length)
        {
            return TB_Bus.TaoMa(sTT, Length);
        }

        public void Insert_Update_Delete(Cls_ThietBi_DTA TB_Data,string sThucThi)
        {
            TB_Bus.Insert_Update_Delete(TB_Data, sThucThi);
        }
    }
}
