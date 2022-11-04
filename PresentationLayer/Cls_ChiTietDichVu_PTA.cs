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
    public class Cls_ChiTietDichVu_PTA
    {
        Cls_ChiTietDichVu_BUS CTDichVu_BUS = new Cls_ChiTietDichVu_BUS();

        public DataTable GetTable(string sDK)
        {
            return CTDichVu_BUS.GetTable(sDK);
        }

        public void Inser_Update_Delete(Cls_ChiTietDichVu_DTA CTDichVu_DATA,string sThucThi)
        {
            CTDichVu_BUS.Insert_Update_Delete(CTDichVu_DATA, sThucThi);
        }

        public DataTable GetTableDVPhong(string sDK)
        {
            return CTDichVu_BUS.GetTableDVPhong(sDK);
        }

        public void DeleteCTDichVu(string sDk)
        {
            CTDichVu_BUS.DeleteCTDichVu(sDk);
        }
    }
}
