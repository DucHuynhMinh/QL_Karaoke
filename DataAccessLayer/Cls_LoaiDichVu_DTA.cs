using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Cls_LoaiDichVu_DTA
    {
        private string _MaLoaiDV;
        private string _TenLoaiDV;
        private string _LoaiDV;

        public string LoaiDV
        {
            get { return _LoaiDV; }
            set { _LoaiDV = value; }
        }

        public string MaLoaiDV
        {
            get { return _MaLoaiDV; }
            set { _MaLoaiDV = value; }
        }
        


        public string TenLoaiDV
        {
            get { return _TenLoaiDV; }
            set { _TenLoaiDV = value; }
        }

        public Cls_LoaiDichVu_DTA()
        {

        }

        public Cls_LoaiDichVu_DTA(string sMaLoaiDV,string sTenLoaiDV,string bLoaiDV)
        {
            MaLoaiDV = sMaLoaiDV;
            TenLoaiDV = sTenLoaiDV;
            LoaiDV = bLoaiDV;
        }

        public Cls_LoaiDichVu_DTA(Cls_LoaiDichVu_DTA LoaiDV_Data)
        {
            MaLoaiDV = LoaiDV_Data.MaLoaiDV;
            TenLoaiDV = LoaiDV_Data.TenLoaiDV;
            LoaiDV = LoaiDV_Data.LoaiDV;
        }
       
    }
}
