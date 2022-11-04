using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Cls_PhongHat_DTA
    {
        private string _MaPH;
        private string _TenPH;
        private int _TinhTrang;
        private int _TrangThai;
        private string _MaLoai;
        private string _NgayVao;
        private string _GioHT;
        private string _GioSau;

        public string GioSau
        {
            get { return _GioSau; }
            set { _GioSau = value; }
        }

        public string GioHT
        {
            get { return _GioHT; }
            set { _GioHT = value; }
        }
        public string NgayVao
        {
            get { return _NgayVao; }
            set { _NgayVao = value; }
        }

        public string MaLoai
        {
            get { return _MaLoai; }
            set { _MaLoai = value; }
        }

        public int TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }

        public int TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }

      

        public string TenPH
        {
            get { return _TenPH; }
            set { _TenPH = value; }
        }

        public string MaPH
        {
            get { return _MaPH; }
            set { _MaPH = value; }
        }

        public Cls_PhongHat_DTA()
        {

        }

        public Cls_PhongHat_DTA(string sMaPH, string sTenPH, int iTinhTrang, int bTrangThai, string sMaLoai,string sNgayVao,string sGioHT,string sGioSau)
        {
            MaPH = sMaPH;
            TenPH = sTenPH;
            TinhTrang = iTinhTrang;
            TrangThai = bTrangThai;
            MaLoai = sMaLoai;
            NgayVao = sNgayVao;
            GioHT = sGioHT;
            GioSau = sGioSau;
        }

        public Cls_PhongHat_DTA(Cls_PhongHat_DTA PH_Data)
        {
            MaPH = PH_Data.MaPH;
            TenPH = PH_Data.TenPH;
            TinhTrang = PH_Data.TinhTrang;
            TrangThai = PH_Data.TrangThai;
            MaLoai = PH_Data.MaLoai;
            NgayVao = PH_Data.NgayVao;
            GioHT = PH_Data.GioHT;
            GioSau = PH_Data.GioSau;
        }
    }
}
