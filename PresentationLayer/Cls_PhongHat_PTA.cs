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
    public class Cls_PhongHat_PTA
    {
        Cls_PhongHat_BUS PH_Bus = new Cls_PhongHat_BUS();

        public DataTable GetTablePH(string sDK)
        {
            return PH_Bus.GetData(sDK);
        }

        public string TaoMa(string ST,int Length)
        {
            return PH_Bus.TaoMa(ST, Length);
        }

        public void Insert_Update_Delete(Cls_PhongHat_DTA PH_Data,string sThucThi)
        {
            PH_Bus.Insert_Update_Delete(PH_Data, sThucThi);
        }

        public DataSet GetTable(ref SqlDataAdapter da,SqlCommandBuilder cmdb ,string sDieuKien)
        {
            return PH_Bus.GetTable(ref da, ref cmdb, sDieuKien);
        }

        public DataSet GetHaiTable(ref SqlDataAdapter da, SqlCommandBuilder cmdb, string sDieuKien)
        {
            return PH_Bus.GetHaiTable(ref da, ref cmdb, sDieuKien);
        }


       
    }
}
