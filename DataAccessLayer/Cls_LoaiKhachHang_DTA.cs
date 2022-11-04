using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Cls_LoaiKhachHang_DTA
    {
        private string _MaLoaiKH;
        private string _TenLoaiKH;
        private int _SoLuong;

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        public string TenLoaiKH
        {
            get { return _TenLoaiKH; }
            set { _TenLoaiKH = value; }
        }

        public string MaLoaiKH
        {
            get { return _MaLoaiKH; }
            set { _MaLoaiKH = value; }
        }

        public Cls_LoaiKhachHang_DTA()
        {

        }

        public Cls_LoaiKhachHang_DTA (string sMaLoaiKH,string sTenLoaiKH,int iSoLuong)
        {
            MaLoaiKH = sMaLoaiKH;
            TenLoaiKH = sTenLoaiKH;
            SoLuong = iSoLuong;
        }

        public Cls_LoaiKhachHang_DTA(Cls_LoaiKhachHang_DTA LoaiKH_Data)
        {
            MaLoaiKH = LoaiKH_Data.MaLoaiKH;
            TenLoaiKH = LoaiKH_Data.TenLoaiKH;
            SoLuong = LoaiKH_Data.SoLuong;
        }
    }
}
