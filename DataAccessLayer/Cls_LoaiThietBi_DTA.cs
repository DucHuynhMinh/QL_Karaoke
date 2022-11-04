using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Cls_LoaiThietBi_DTA
    {
        private string _MaLoaiTB;
        private string _TenLoaiTB;
        private string _XuatXu;

        public string XuatXu
        {
            get { return _XuatXu; }
            set { _XuatXu = value; }
        }

        public string TenLoaiTB
        {
            get { return _TenLoaiTB; }
            set { _TenLoaiTB = value; }
        }

        public string MaLoaiTB
        {
            get { return _MaLoaiTB; }
            set { _MaLoaiTB = value; }
        }

        public Cls_LoaiThietBi_DTA()
        {

        }

        public Cls_LoaiThietBi_DTA(string sMaLoaiTB,string sTenLoaiTB,string sXuatXu)
        {
            MaLoaiTB = sMaLoaiTB;
            TenLoaiTB = sTenLoaiTB;
            XuatXu = sXuatXu;
        }

        public Cls_LoaiThietBi_DTA(Cls_LoaiThietBi_DTA LoaiTB_Data)
        {
            MaLoaiTB = LoaiTB_Data.MaLoaiTB;
            TenLoaiTB = LoaiTB_Data.TenLoaiTB;
            XuatXu = LoaiTB_Data.XuatXu;
        }
    }
}
