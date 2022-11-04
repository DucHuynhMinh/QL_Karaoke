using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using PresentationLayer;

namespace NguyenTrongDuy_2201130001
{
    public partial class Frm_ThanhToan : Form
    {
        Cls_NhanPhong_DTA NPhong_DATA = new Cls_NhanPhong_DTA();
        Cls_NhanPhong_PTA NPhong_PTA = new Cls_NhanPhong_PTA();

        Cls_PhongHat_DTA PH_DATA = new Cls_PhongHat_DTA();
        Cls_PhongHat_PTA PH_PTA = new Cls_PhongHat_PTA();

        Cls_LoaiPhong_DTA LP_DATA = new Cls_LoaiPhong_DTA();
        Cls_LoaiPhong_PTA LP_PTA = new Cls_LoaiPhong_PTA();

        Cls_PhieuDat_DTA PD_DATA = new Cls_PhieuDat_DTA();
        Cls_PhieuDat_PTA PD_PTA = new Cls_PhieuDat_PTA();

        Cls_ChiTietDichVu_DTA CTDichVu_DATA = new Cls_ChiTietDichVu_DTA();
        Cls_ChiTietDichVu_PTA CTDichVu_PTA = new Cls_ChiTietDichVu_PTA();

        Cls_KhachHang_DTA KH_DATA = new Cls_KhachHang_DTA();
        Cls_KhachHang_PTA KH_PTA = new Cls_KhachHang_PTA();

        DataTable TblNPhong = new DataTable();
        DataTable TblPHat = new DataTable();
        DataTable TblLoaiPhong = new DataTable();


        private string _MaPH;

        public string MaPH
        {
            get { return _MaPH; }
            set { _MaPH = value; }
        }

        private string _NgayVao;

        public string NgayVao
        {
            get { return _NgayVao; }
            set { _NgayVao = value; }
        }
        private string _GioVao;

        public string GioVao
        {
            get { return _GioVao; }
            set { _GioVao = value; }
        }
        private string _GioRa;

        public string GioRa
        {
            get { return _GioRa; }
            set { _GioRa = value; }
        }
        private string _SoTiengGio;

        public string SoTiengGio
        {
            get { return _SoTiengGio; }
            set { _SoTiengGio = value; }
        }
       
        private string _TongTienPhong;

        public string TongTienPhong
        {
            get { return _TongTienPhong; }
            set { _TongTienPhong = value; }
        }

        private string _TienGio;

        public string TienGio
        {
            get { return _TienGio; }
            set { _TienGio = value; }
        }

        private string _NameKH;

        public string NameKH
        {
            get { return _NameKH; }
            set { _NameKH = value; }
        }

        private string _NameLP;

        public string NameLP
        {
            get { return _NameLP; }
            set { _NameLP = value; }
        }

        private string _NamePhong;

        public string NamePhong
        {
            get { return _NamePhong; }
            set { _NamePhong = value; }
        }

        private string _TienDV;

        public string TienDV
        {
            get { return _TienDV; }
            set { _TienDV = value; }
        }

        private bool _Delete;

        public bool Delete
        {
            get { return _Delete; }
            set { _Delete = value; }
        }

        string smaNP = "";
        double KQ = 0;
        public Frm_ThanhToan()
        {
            
            InitializeComponent();
        }      

        private void Frm_ThanhToan_Load(object sender, EventArgs e)
        {
            ShowThongTinTT();
            GetTablNP(MaPH);
        }

        public void ShowThongTinTT()
        {
            lblKH.Text = NameKH;
            lbl_ngayVao.Text = NgayVao;
            lbl_TongTienPhong.Text = TongTienPhong;            
            lbl_TenPH.Text = NamePhong;
            lbl_GioVao.Text = GioVao;
            lbl_GioRa.Text = GioRa;
            lbl_SoTieng.Text = SoTiengGio;
            lbl_LoaiPhong.Text = NameLP;
            lbl_TienGio.Text = double.Parse(TienGio.ToString()).ToString("#,##0 VND");
            lbl_TongTienDV.Text = TienDV;
        }

        public void GetTablNP(string sDk)
        {
            if (sDk != "")
            {
                //Lay Thong Tin CTDichVu
                double ThanhTien = 0;
                DataTable TblCTDichVu = CTDichVu_PTA.GetTableDVPhong(" where CTDichVu.MaPH='" + sDk + "'");
                if (TblCTDichVu.Rows.Count != 0)
                {
                    ListViewItem item;
                    lst_CTHoaDon.Items.Clear();
                    for (int i = 0; i < TblCTDichVu.Rows.Count; i++)
                    {
                        item = new ListViewItem((i + 1).ToString());
                        item.SubItems.Add(TblCTDichVu.Rows[i]["TenDV"].ToString());
                        item.SubItems.Add(TblCTDichVu.Rows[i]["DonGia"].ToString());
                        item.SubItems.Add(TblCTDichVu.Rows[i]["SoLuong"].ToString());
                        ThanhTien = float.Parse(TblCTDichVu.Rows[i]["DonGia"].ToString()) * int.Parse(TblCTDichVu.Rows[i]["SoLuong"].ToString());
                        item.SubItems.Add(ThanhTien.ToString("#,##0 VND"));
                        lst_CTHoaDon.Items.Add(item);
                    }

                }

            }

        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            Insert_Delete_CTDichVu(MaPH);
            if (Delete != false)
                Inser_Delete_UpdateDatPhong(MaPH);
            else
            {
                TblNPhong = NPhong_PTA.GetTable(" where MaPH='" + MaPH + "'");
                if (TblNPhong.Rows.Count != 0)
                {
                    NPhong_DATA.MaNP = smaNP;
                    NPhong_DATA.MaNP = TblNPhong.Rows[0]["MaNP"].ToString();
                    Inser_Update_tNhanPhong(MaPH);
                    NPhong_PTA.Insert_Update_Delete(NPhong_DATA, "Delete");
                }
            }

            lst_CTHoaDon.Items.Clear();


            this.Close();
        }



        public void Inser_Update_tNhanPhong(string smaid)
        {
            try
            {
                NPhong_DATA.TenKH = lbl_TenKH.Text;
                NPhong_DATA.NgayNhan = Convert.ToDateTime(lbl_ngayVao.Text);
                NPhong_DATA.GioNhan = lbl_GioVao.Text;
                NPhong_DATA.MaPH = smaid;
                NPhong_DATA.SoLuongNguoi = 0;
                NPhong_DATA.DiaChi = "";
                NPhong_DATA.Emai = "";
                NPhong_DATA.SoDienThoai = "";
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Insert_Delete_CTDichVu(string smaid)
        {
           DataTable  TblCTDV = CTDichVu_PTA.GetTable(" where MaPH='" + smaid + "'");
           if (TblCTDV.Rows.Count != 0)
           {
               CTDichVu_DATA.MaDV = TblCTDV.Rows[0]["MaDV"].ToString();
               CTDichVu_DATA.MaPH = smaid;
               CTDichVu_DATA.DonGia = float.Parse(TblCTDV.Rows[0]["DonGia"].ToString());
               CTDichVu_DATA.SoLuong = int.Parse(TblCTDV.Rows[0]["SoLuong"].ToString());
               CTDichVu_PTA.Inser_Update_Delete(CTDichVu_DATA, "Delete");
           }
        }

        public void Inser_Delete_UpdateDatPhong(string smaid)
        {
            DataTable tblDPhong = new DataTable();
            tblDPhong = PD_PTA.GetTablePhieuDP(" where MaPH='" + smaid + "'");
            if (tblDPhong.Rows.Count != 0)
            {
                PD_DATA.SoPD = tblDPhong.Rows[0]["SoPD"].ToString();
                PD_DATA.NgayDat = Convert.ToDateTime(tblDPhong.Rows[0]["NgayDat"]);
                PD_DATA.GioDat = tblDPhong.Rows[0]["GioDat"].ToString();
                PD_DATA.BuoiDat = tblDPhong.Rows[0]["BuoiDat"].ToString();
                PD_DATA.TienDatCoc = int.Parse(tblDPhong.Rows[0]["TienDatCoc"].ToString());
                PD_DATA.MaPH = smaid;
                PD_DATA.MaKH = tblDPhong.Rows[0]["MaKH"].ToString();
                PD_PTA.Insert_Update_Delete(PD_DATA, "Delete");
                
            }
           
        }

        
    }
}
