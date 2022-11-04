using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Cls_PhieuDat_DTA
    {

        private string _SoPD;
        private DateTime _NgayDat;
        private string _GioDat;
        private string _BuoiDat;
        private float _TienDatCoc;
        private string _MaPH;
        private string _MaKH;   
        
       
       
        public string SoPD
        {
            get { return _SoPD; }
            set { _SoPD = value; }
        }

        public DateTime NgayDat
        {
            get { return _NgayDat; }
            set { _NgayDat = value; }
        }

        public string GioDat
        {
            get { return _GioDat; }
            set { _GioDat = value; }
        }

        public string BuoiDat
        {
            get { return _BuoiDat; }
            set { _BuoiDat = value; }
        }

        public float TienDatCoc
        {
            get { return _TienDatCoc; }
            set { _TienDatCoc = value; }
        }

        public string MaPH
        {
            get { return _MaPH; }
            set { _MaPH = value; }
        }


        public string MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }

        public Cls_PhieuDat_DTA()
        {

        }

        public Cls_PhieuDat_DTA(string sSoPD, DateTime dNgayDat, string sGioDat, string sBuoiDat, float fTienDatCoc, string sMaPH, string sMaKH)
        {
            SoPD=sSoPD;
            NgayDat=dNgayDat;
            GioDat=sGioDat;
            BuoiDat=sBuoiDat;
            TienDatCoc=fTienDatCoc;
            MaPH=sMaPH;
            MaKH=sMaKH;
        }

        public Cls_PhieuDat_DTA(Cls_PhieuDat_DTA PD_Data)
        {
            SoPD = PD_Data.SoPD;
            NgayDat = PD_Data.NgayDat;
            GioDat = PD_Data.GioDat;
            BuoiDat = PD_Data.BuoiDat;
            TienDatCoc = PD_Data.TienDatCoc;
            MaPH = PD_Data.MaPH;
            MaKH = PD_Data.MaKH;
        }
    }
}
