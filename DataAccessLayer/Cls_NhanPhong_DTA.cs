using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Cls_NhanPhong_DTA
    {
        private string _MaNP;
        private string _TenKH;
        private DateTime _NgayNhan;
        private string _GioNhan;
        private string _MaPH;
        private int _SoLuongNguoi;
        private string _DiaChi;
        private string _Emai;
        private string _SoDienThoai;

        public string SoDienThoai
        {
            get { return _SoDienThoai; }
            set { _SoDienThoai = value; }
        }

        public string Emai
        {
            get { return _Emai; }
            set { _Emai = value; }
        }

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        public int SoLuongNguoi
        {
            get { return _SoLuongNguoi; }
            set { _SoLuongNguoi = value; }
        }

        public string MaPH
        {
            get { return _MaPH; }
            set { _MaPH = value; }
        }

        public string GioNhan
        {
            get { return _GioNhan; }
            set { _GioNhan = value; }
        }

        public DateTime NgayNhan
        {
            get { return _NgayNhan; }
            set { _NgayNhan = value; }
        }

        public string TenKH
        {
            get { return _TenKH; }
            set { _TenKH = value; }
        }

        public string MaNP
        {
            get { return _MaNP; }
            set { _MaNP = value; }
        }

        public Cls_NhanPhong_DTA()
        {

        }

        public Cls_NhanPhong_DTA(string sMaNP,string sTenKH,DateTime dNgayNhan,string sGioNhan,string sMaPH,int iSoLuongNguoi,string sDiaChi,string sEmail,string sSoDienThoai)
        {
            MaNP = sMaNP;
            TenKH = sTenKH;
            NgayNhan = dNgayNhan;
            GioNhan = sGioNhan;
            MaPH = sMaPH;
            SoLuongNguoi = iSoLuongNguoi;
            DiaChi = sDiaChi;
            Emai = sEmail;
            SoDienThoai = sSoDienThoai;
        }

        public Cls_NhanPhong_DTA(Cls_NhanPhong_DTA NPhong_Data)
        {
            MaNP = NPhong_Data.MaNP;
            TenKH = NPhong_Data.TenKH;
            NgayNhan = NPhong_Data.NgayNhan;
            GioNhan = NPhong_Data.GioNhan;
            MaPH = NPhong_Data.MaPH;
            SoLuongNguoi = NPhong_Data.SoLuongNguoi;
            DiaChi = NPhong_Data.DiaChi;
            Emai = NPhong_Data.Emai;
            SoDienThoai = NPhong_Data.SoDienThoai;
        }
    }
}
