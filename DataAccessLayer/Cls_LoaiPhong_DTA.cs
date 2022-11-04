using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Cls_LoaiPhong_DTA
    {
        private string _MaLoai;
        private string _TenLoai;
        private float _GioCD;
        private float _GioBT;

              

        

      
        public float GioBT
        {
            get { return _GioBT; }
            set { _GioBT = value; }
        }

        public float GioCD
        {
            get { return _GioCD; }
            set { _GioCD = value; }
        }

        public string TenLoai
        {
            get { return _TenLoai; }
            set { _TenLoai = value; }
        }

        public string MaLoai
        {
            get { return _MaLoai; }
            set { _MaLoai = value; }
        }

        public Cls_LoaiPhong_DTA()
        {

        }

        public Cls_LoaiPhong_DTA(string sMaLoai,string sTenLoai,float fGioCD,float fGioBT)
        {
            MaLoai = sMaLoai;
            TenLoai = sTenLoai;
            GioCD = fGioCD;
            GioBT = fGioBT;
           
            
        }

        public Cls_LoaiPhong_DTA(Cls_LoaiPhong_DTA LPhong_Data)
        {
            MaLoai = LPhong_Data.MaLoai;
            TenLoai = LPhong_Data.TenLoai;
            GioCD = LPhong_Data.GioCD;
            GioBT = LPhong_Data.GioBT;
        }
    }
}
