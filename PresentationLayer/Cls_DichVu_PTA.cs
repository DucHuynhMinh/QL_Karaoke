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
    public class Cls_DichVu_PTA
    {
        Cls_DichVu_BUS DV_Bus = new Cls_DichVu_BUS();

        public DataTable GetTable(string sDK)
        {
            return DV_Bus.GetTableDV(sDK);
        }

        public void Insert_Update_Delete(Cls_DichVu_DTA DV_Data,string sThucThi)
        {
            DV_Bus.Insert_Update_Delete(DV_Data, sThucThi);
        }

        public string TaoMa(string sMaID,int Length)
        {
            return DV_Bus.TaoMa(sMaID, Length);
        }
    }
}
