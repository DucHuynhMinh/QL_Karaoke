using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Cls_NhanVien_DTA
    {
        private string _MaNV;
        private string _TenDN;
        private string _MaMaDN;
        private string _QuyenDN;
        private string _HoTenNV;
        private DateTime _NgaySinh;
        private bool _Phai;
        private string _DienThoai;
        private string _DiaChi;
        private float _LuongNV;

        public float LuongNV
        {
            get { return _LuongNV; }
            set { _LuongNV = value; }
        }
        

        public string HoTenNV
        {
            get { return _HoTenNV; }
            set { _HoTenNV = value; }
        }
        

        public string QuyenDN
        {
            get { return _QuyenDN; }
            set { _QuyenDN = value; }
        }
        

        public string MaMaDN
        {
            get { return _MaMaDN; }
            set { _MaMaDN = value; }
        }
        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        

        public string TenDN
        {
            get { return _TenDN; }
            set { _TenDN = value; }
        }
        
        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }

        public bool Phai
        {
            get { return _Phai; }
            set { _Phai = value; }
        }


        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }


        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        public Cls_NhanVien_DTA()
        {

        }
        public Cls_NhanVien_DTA(string sMaNV,string sTenDN,string sMaMaDN,string sQuyenDN, string sHoTenNV, DateTime dNgaySinh, bool bPhai, string sDienThoai, string sDiaChi,float fLuongNV)
        {
            MaNV = sMaNV;
            TenDN = sTenDN;
            MaMaDN = sMaMaDN;
            QuyenDN = sQuyenDN;
            HoTenNV = sHoTenNV;
            NgaySinh = dNgaySinh;
            Phai = bPhai;
            DienThoai = sDienThoai;
            DiaChi = sDiaChi;
            LuongNV = fLuongNV;
        }

        public Cls_NhanVien_DTA(Cls_NhanVien_DTA NV_Data)
        {
            MaNV = NV_Data.MaNV;
            TenDN = NV_Data.TenDN;
            MaMaDN = NV_Data.MaMaDN;
            QuyenDN = NV_Data.QuyenDN;
            HoTenNV = NV_Data.HoTenNV;
            NgaySinh = NV_Data.NgaySinh;
            Phai = NV_Data.Phai;
            DienThoai = NV_Data.DienThoai;
            DiaChi = NV_Data.DiaChi;
            LuongNV = NV_Data.LuongNV;
        }
    }
}
