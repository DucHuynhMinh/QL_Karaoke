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
    public class Cls_LoaiKhachHang_PTA
    {
        Cls_LoaiKhachHang_BUS LoaiKH_Bus = new Cls_LoaiKhachHang_BUS();

        public DataTable GetTable(string sDK)
        {
            return LoaiKH_Bus.GetTableLoaiKH("");
        }

        public void Insert_Update_Delete(Cls_LoaiKhachHang_DTA LoaiKH_Data,string sThucThi)
        {
            LoaiKH_Bus.Insert_Update_Delete(LoaiKH_Data, sThucThi);
        }

        public string TaoMa(string sTT,int Length)
        {
            return LoaiKH_Bus.TaoMa(sTT, Length);
        }
    }
}
