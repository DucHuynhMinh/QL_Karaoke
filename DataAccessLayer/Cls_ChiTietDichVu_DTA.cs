using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Cls_ChiTietDichVu_DTA
    {
        private string _MaDV;
        private string _MaPH;
        private float _DonGia;
        private int _SoLuong;

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

        public string MaPH
        {
            get { return _MaPH; }
            set { _MaPH = value; }
        }

        public string MaDV
        {
            get { return _MaDV; }
            set { _MaDV = value; }
        }

        public Cls_ChiTietDichVu_DTA()
        {

        }

        public Cls_ChiTietDichVu_DTA(string sMaDV,string sMaPH,float fDonGia,int iSoLuong)
        {
            MaDV = sMaDV;
            MaPH = sMaPH;
            DonGia = fDonGia;
            SoLuong = iSoLuong;
        }

        public Cls_ChiTietDichVu_DTA(Cls_ChiTietDichVu_DTA CTDV_DATA)
        {
            MaDV = CTDV_DATA.MaDV;
            MaPH = CTDV_DATA.MaPH;
            DonGia = CTDV_DATA.DonGia;
            SoLuong = CTDV_DATA.SoLuong;
        }
    }
}
