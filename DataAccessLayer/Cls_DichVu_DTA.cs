using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Cls_DichVu_DTA
    {
        private string _MaDV;
        private string _TenDV;
        private string _DVTinh;
        private float _DonGia;
        private string _MoTa;
        private string _MaLoaiDV;

        public string MaLoaiDV
        {
            get { return _MaLoaiDV; }
            set { _MaLoaiDV = value; }
        }

        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }

     

        public float DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }
        
        

        public string DVTinh
        {
            get { return _DVTinh; }
            set { _DVTinh = value; }
        }

        public string TenDV
        {
            get { return _TenDV; }
            set { _TenDV = value; }
        }

        public string MaDV
        {
            get { return _MaDV; }
            set { _MaDV = value; }
        }

        public Cls_DichVu_DTA()
        {

        }

        public Cls_DichVu_DTA (string sMaDV,string sTenDV,string sDVTinh,float fDonGia,string sMoTa,string sMaLoaiDV)
        {
            MaDV = sMaDV;
            TenDV = sTenDV;
            DVTinh = sDVTinh;
            DonGia = fDonGia;
           
            MoTa = sMoTa;
            MaLoaiDV = sMaLoaiDV;
        }

        public Cls_DichVu_DTA(Cls_DichVu_DTA DV_Data)
        {
            MaDV = DV_Data.MaDV;
            TenDV = DV_Data.TenDV;
            DVTinh = DV_Data.DVTinh;
            DonGia = DV_Data.DonGia;
            MoTa = DV_Data.MoTa;
            MaLoaiDV = DV_Data.MaLoaiDV;
        }
    }
}
