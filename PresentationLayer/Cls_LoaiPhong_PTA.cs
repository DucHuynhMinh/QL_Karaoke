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
    public class Cls_LoaiPhong_PTA
    {
        Cls_LoaiPhong_BUS LP_Bus = new Cls_LoaiPhong_BUS();

        public void Insert_Update_Delete(Cls_LoaiPhong_DTA LP_Data,string sThucThi)
        {
            LP_Bus.Insert_Update_Delete(LP_Data, sThucThi);
        }

        public DataTable GetDatata(string sDK)
        {
            return LP_Bus.GetTableLoaiPhong(sDK);
        }

        public string TaoMa(string ST,int Length)
        {
            return LP_Bus.TaoMa(ST, Length);
        }
    }
}
