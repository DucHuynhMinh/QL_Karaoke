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
    public class Cls_LoaiDichVu_PTA
    {
        Cls_LoaiDichVu_BUS LoaiDV_Bus = new Cls_LoaiDichVu_BUS();

        public DataTable GetTable(string sDK)
        {
            return LoaiDV_Bus.GetTableLoaiDV(sDK);
        }

        public string TaoMa(string ST,int Length)
        {
            return LoaiDV_Bus.TaoMa(ST, Length);
        }
        //Download source code FREE tai Sharecode.vn
        public void Insert_Update_Delete(Cls_LoaiDichVu_DTA LoaiDV_Data,string sThucThi)
        {
            LoaiDV_Bus.Insert_Update_Delete(LoaiDV_Data, sThucThi);
        }
    }
}
