using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Cls_KhachHang_DTA
    {
        private string _MaKH;      
        private string _TenKH;
        private string _TheCard;        
        private DateTime _NgaySinh;
        private bool _Phai;        
        private string _DienThoai;
        private string _DiaChi;
        private string _Email;
        private string _HinhThucDK;
        private string _MaLoaiKH;

        public string MaLoaiKH
        {
            get { return _MaLoaiKH; }
            set { _MaLoaiKH = value; }
        }

        public string TheCard
        {
            get { return _TheCard; }
            set { _TheCard = value; }
        }
        public string MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }
        

        public string TenKH
        {
            get { return _TenKH; }
            set { _TenKH = value; }
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
    

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
             
       

        public string HinhThucDK
        {
            get { return _HinhThucDK; }
            set { _HinhThucDK = value; }
        }

        public Cls_KhachHang_DTA()
        {
            MaKH = TenKH = DienThoai = DiaChi = HinhThucDK = "";
        }

        public Cls_KhachHang_DTA(string sMaKH,string sTenKH,string sTheCard,DateTime dNgaySinh,bool bPhai,string sDienThoai,string sDiaChi,string sEmail,string sHinhThucDK,string sMaLoaiKH)
        {
            MaKH = sMaKH;
            TenKH = sTenKH;
            TheCard = sTheCard;
            NgaySinh = dNgaySinh;
            Phai = bPhai;
            DienThoai = sDienThoai;
            DiaChi = sDiaChi;
            Email = sEmail;
            HinhThucDK = sHinhThucDK;
            MaLoaiKH = sMaLoaiKH;
        }

        public Cls_KhachHang_DTA(Cls_KhachHang_DTA KH_Data)
        {
            MaKH = KH_Data.MaKH;
            TenKH = KH_Data.TenKH;
            TheCard = KH_Data.TheCard;
            NgaySinh = KH_Data.NgaySinh;
            Phai = KH_Data.Phai;
            DienThoai = KH_Data.DienThoai;
            DiaChi = KH_Data.DiaChi;
            Email = KH_Data.Email;
            HinhThucDK = KH_Data.HinhThucDK;
            MaLoaiKH = KH_Data.MaLoaiKH;
        }

    }
}
