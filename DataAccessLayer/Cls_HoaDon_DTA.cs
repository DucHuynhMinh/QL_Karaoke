using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Cls_HoaDon_DTA
    {
        private string _MaHD;
        private string _MaPH;
        private string _MaKM;
        private float _ThanhTien;
        private float _TongTien;
        private bool _TrangThai;
        private string _ThucAn;
        private string _MaLoai;
        private string _NgayLap;
        private string _ThangLap;
        private string _NamLap;

        public string NamLap
        {
            get { return _NamLap; }
            set { _NamLap = value; }
        }

        public string ThangLap
        {
            get { return _ThangLap; }
            set { _ThangLap = value; }
        }

        public string NgayLap
        {
            get { return _NgayLap; }
            set { _NgayLap = value; }
        }

        public string MaLoai
        {
            get { return _MaLoai; }
            set { _MaLoai = value; }
        }


        public string ThucAn
        {
            get { return _ThucAn; }
            set { _ThucAn = value; }
        }

        public bool TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }

        public float TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; }
        }

        public float ThanhTien
        {
            get { return _ThanhTien; }
            set { _ThanhTien = value; }
        }

        public string MaKM
        {
            get { return _MaKM; }
            set { _MaKM = value; }
        }

        public string MaPH
        {
            get { return _MaPH; }
            set { _MaPH = value; }
        }

        public string MaHD
        {
            get { return _MaHD; }
            set { _MaHD = value; }
        }

        public Cls_HoaDon_DTA()
        {

        }

        public Cls_HoaDon_DTA(string sMaHD, string sMaPH, DateTime dNgayLap, string sMaKM, float fThanhTien, float fTongTien, bool bTrangThai, string sThucAn, string sMaLoai, string sNgayLap, string sThangLap, string sNamLap)
        {
            MaHD = sMaHD;
            MaPH = sMaPH;
            MaKM = sMaKM;
            ThanhTien = fThanhTien;
            TongTien = fTongTien;
            TrangThai = bTrangThai;
            ThucAn = sThucAn;
            MaLoai = sMaLoai;
            NgayLap = sNgayLap;
            ThangLap = sThangLap;
            NamLap = sNamLap;
        }

        public Cls_HoaDon_DTA(Cls_HoaDon_DTA HD_Data)
        {
            MaHD = HD_Data.MaHD;
            MaPH = HD_Data.MaPH;
            MaKM = HD_Data.MaKM;
            ThanhTien = HD_Data.ThanhTien;
            TongTien = HD_Data.TongTien;
            TrangThai = HD_Data.TrangThai;
            ThucAn = HD_Data.ThucAn;
            MaLoai = HD_Data.MaLoai;
            NgayLap = HD_Data.NgayLap;
            ThangLap = HD_Data.ThangLap;
            NamLap = HD_Data.NamLap;
        }
    }
}
