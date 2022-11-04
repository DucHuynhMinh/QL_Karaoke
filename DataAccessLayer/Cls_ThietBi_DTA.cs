using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Cls_ThietBi_DTA
    {
        private string _MaTB;
        private string _TenTB;
        private float _DonGia;
        private int _SoLuong;
        private bool _TrangThai;
        private string _MaLoaiTB;

        public string MaLoaiTB
        {
            get { return _MaLoaiTB; }
            set { _MaLoaiTB = value; }
        }

        public bool TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        public float DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }

        public string TenTB
        {
            get { return _TenTB; }
            set { _TenTB = value; }
        }

        public string MaTB
        {
            get { return _MaTB; }
            set { _MaTB = value; }
        }

        public Cls_ThietBi_DTA()
        {

        }

        public Cls_ThietBi_DTA(string sMaTB,string sTenTB,float fDonGia,int iSoLuong,bool bTrangThai,string sMaLoaiTB)
        {
            MaTB=sMaTB;
            TenTB = sTenTB;
            DonGia = fDonGia;
            SoLuong = iSoLuong;
            TrangThai = bTrangThai;
            MaLoaiTB = sMaLoaiTB;
        }

        public Cls_ThietBi_DTA(Cls_ThietBi_DTA TB_Data)
        {
            MaTB = TB_Data.MaTB;
            TenTB = TB_Data.TenTB;
            DonGia = TB_Data.DonGia;
            SoLuong = TB_Data.SoLuong;
            TrangThai = TB_Data.TrangThai;
            MaLoaiTB = TB_Data.MaLoaiTB;
        }
    }
}
