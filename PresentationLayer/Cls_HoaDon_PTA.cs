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
    public class Cls_HoaDon_PTA
    {
        Cls_HoaDon_BUS HDon_BUS = new Cls_HoaDon_BUS();


        public string sChuoiKetNoi()
        {
            return HDon_BUS.sChuoiKetNoi();
        }

        public DataSet GetTable(string sDK)
        {
            return HDon_BUS.GetTable(sDK);
        }

        public void Insert_Update_Delete(Cls_HoaDon_DTA HDon_DATA, string sThucThi)
        {
            HDon_BUS.Insert_Update_Delete(HDon_DATA, sThucThi);
        }

        public string TaoMa(String sTT, int Length)
        {
            return HDon_BUS.TaoMa(sTT, Length);
        }
    }
}
