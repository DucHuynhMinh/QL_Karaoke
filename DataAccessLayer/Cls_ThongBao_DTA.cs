using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Cls_ThongBao_DTA
    {
        private string _MaTBao;
        private string _NguoiGui;
        private string _NguoiNhan;
        private DateTime _NgayGui;
        private DateTime _NgayNhan;
        private string _NoiDungTB;
        private bool _TrangThaiTB;

        public bool TrangThaiTB
        {
            get { return _TrangThaiTB; }
            set { _TrangThaiTB = value; }
        }

        public string NoiDungTB
        {
            get { return _NoiDungTB; }
            set { _NoiDungTB = value; }
        }

        public DateTime NgayGui
        {
            get { return _NgayGui; }
            set { _NgayGui = value; }
        }
       
     

        public DateTime NgayNhan
        {
            get { return _NgayNhan; }
            set { _NgayNhan = value; }
        }

        public string NguoiNhan
        {
            get { return _NguoiNhan; }
            set { _NguoiNhan = value; }
        }

        public string NguoiGui
        {
            get { return _NguoiGui; }
            set { _NguoiGui = value; }
        }

        public string MaTBao
        {
            get { return _MaTBao; }
            set { _MaTBao = value; }
        }

        public Cls_ThongBao_DTA()
        {

        }

        public Cls_ThongBao_DTA(string sMaTB,string sNguoiGui,string sNguoiNhan,DateTime dNgayGui,DateTime dNgayNhan,string sNoiDungTB,bool bTrangThai)
        {
            MaTBao = sMaTB;
            NguoiGui = sNguoiGui;
            NguoiNhan = sNguoiNhan;
            NgayGui = dNgayGui;
            NgayNhan = dNgayNhan;
            NoiDungTB = sNoiDungTB;
            TrangThaiTB = bTrangThai;
        }

        public Cls_ThongBao_DTA(Cls_ThongBao_DTA TBao_Data)
        {
            MaTBao = TBao_Data.MaTBao;
            NguoiGui = TBao_Data.NguoiGui;
            NguoiNhan = TBao_Data.NguoiNhan;
            NgayGui = TBao_Data.NgayGui;
            NgayNhan = TBao_Data.NgayNhan;
            NoiDungTB = TBao_Data.NoiDungTB;
            TrangThaiTB = TBao_Data.TrangThaiTB;
        }
    }
}
