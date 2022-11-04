using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Cls_KhuyenMai_DTA
    {
        private string _MaKM;
        private string _TenKM;
        private string _NoiDung;
        private float _GiaKM;
        private float _GiaHT;
        private DateTime _NgayBD;
        private DateTime _NgayKT;
        private bool _TrangThai;

        public bool TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }

        public DateTime NgayKT
        {
            get { return _NgayKT; }
            set { _NgayKT = value; }
        }

        public DateTime NgayBD
        {
            get { return _NgayBD; }
            set { _NgayBD = value; }
        }

        public float GiaHT
        {
            get { return _GiaHT; }
            set { _GiaHT = value; }
        }

        public float GiaKM
        {
            get { return _GiaKM; }
            set { _GiaKM = value; }
        }

        public string NoiDung
        {
            get { return _NoiDung; }
            set { _NoiDung = value; }
        }

        public string TenKM
        {
            get { return _TenKM; }
            set { _TenKM = value; }
        }

        public string MaKM
        {
            get { return _MaKM; }
            set { _MaKM = value; }
        }

        public Cls_KhuyenMai_DTA()
        {

        }

        public Cls_KhuyenMai_DTA(string sMaKM,string sTenKM,string sNoiDung,float fGiaKM,float fGiaHT,DateTime dNgayBD,DateTime dNgayKT,bool bTrangThai)
        {
            MaKM = sMaKM;
            TenKM = sTenKM;
            NoiDung = sNoiDung;
            GiaKM = fGiaKM;
            GiaHT = fGiaHT;
            NgayBD = dNgayBD;
            NgayKT = dNgayKT;
            TrangThai = bTrangThai;
        }

        public Cls_KhuyenMai_DTA(Cls_KhuyenMai_DTA KMai_Data)
        {
            MaKM = KMai_Data.MaKM;
            TenKM = KMai_Data.TenKM;
            NoiDung = KMai_Data.NoiDung;
            GiaKM = KMai_Data.GiaKM;
            GiaHT = KMai_Data.GiaHT;
            NgayBD = KMai_Data.NgayBD;
            NgayKT = KMai_Data.NgayKT;
            TrangThai = KMai_Data.TrangThai;
        }
    }
}
