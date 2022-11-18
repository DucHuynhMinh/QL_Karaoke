using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhucHien_MinhDuc.QLNguoiDung;

namespace PhucHien_MinhDuc
{
    public partial class Frm_Main : Form
    {
        private string _HoTenND;

        public string HoTenND
        {
            get { return _HoTenND; }
            set { _HoTenND = value; }
        }
        private string _QuyenDN;

        public string QuyenDN
        {
            get { return _QuyenDN; }
            set { _QuyenDN = value; }
        }

        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        

        public Frm_Main()
        {
           
            InitializeComponent();
        }

        private void HT_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Admin(false);
            string[] smangNgay = { "Chủ Nhật" ,"Thứ Hai", "Thứ Ba", "Thứ Tư", "Thứ Năm", "Thứ Sáu", "Thứ Bảy"};
            int ingay = DateTime.Now.DayOfWeek.GetHashCode();
            Lbl_HomNay.Text = Lbl_HomNay.Text+ smangNgay[ingay].ToString() + " Ngày " + DateTime.Today.Day.ToString()
                + " Tháng " + DateTime.Today.Month.ToString() + " Năm " + DateTime.Today.Year.ToString();
            HT_DangNhap_Click(sender, e);
            

        }

        private void Menu_DanhMuc_PH_Click(object sender, EventArgs e)
        {
            Frm_PhongHat FrmPH = new Frm_PhongHat();
            FrmPH.MdiParent = this;
            FrmPH.Show();
        }

        private void Menu_DanhMuc_LP_Click(object sender, EventArgs e)
        {
            Frm_LoaiPhong FrmLP = new Frm_LoaiPhong();
            FrmLP.MdiParent = this;
            FrmLP.Show();
        }

        private void Menu_DanhMuc_KH_Click(object sender, EventArgs e)
        {
            Frm_KhachHang FrmKH = new Frm_KhachHang();
            FrmKH.MdiParent = this;
            FrmKH.Show();
        }

        private void Menu_DanhMuc_NhanVien_Click(object sender, EventArgs e)
        {
            Frm_NhanVien FrmNV = new Frm_NhanVien();
            FrmNV.MdiParent = this;
            FrmNV.Show();
        }

        private void Menu_DanhMuc_DV_Click(object sender, EventArgs e)
        {
            Frm_DichVu FrmDV = new Frm_DichVu();
            FrmDV.MdiParent = this;
            FrmDV.Show();
        }

        private void Menu_DanhMuc_LDV_Click(object sender, EventArgs e)
        {
            Frm_LoaiDV FrmLoaiDV = new Frm_LoaiDV();
            FrmLoaiDV.MdiParent = this;
            FrmLoaiDV.Show();
        }

        private void Menu_DanhMuc_TB_Click(object sender, EventArgs e)
        {
            Frm_ThietBi FrmTB = new Frm_ThietBi();
            FrmTB.MdiParent = this;
            FrmTB.Show();
        }

        private void Menu_QuanLy_DP_Click(object sender, EventArgs e)
        {
            Frm_DatPhong FrmDP = new Frm_DatPhong();
            FrmDP.MdiParent = this;
            FrmDP.Show();
        }

        private void Menu_QuanLy_NP_Click(object sender, EventArgs e)
        {
            Frm_QuanLyThueTraPhong FrmQLNThuePhong = new Frm_QuanLyThueTraPhong();            
            FrmQLNThuePhong.MdiParent = this;
            FrmQLNThuePhong.Show();
        }

        private void Menu_QuanLy_TP_Click(object sender, EventArgs e)
        {
            Frm_TimPhong FrmTP = new Frm_TimPhong();
            FrmTP.MdiParent = this;
            FrmTP.Show();
        }

        private void Menu_QuanLy_DV_Click(object sender, EventArgs e)
        {
            Frm_QuanLyDichVu FrmQLDV = new Frm_QuanLyDichVu();
            FrmQLDV.MdiParent = this;
            FrmQLDV.Show();
        }

        public void Admin(bool mo)
        {
            HT_DangNhap.Enabled =!mo;
            HT_DangXuat.Enabled = mo;
            HT_QLNguoiDung.Enabled = mo;
            HT_DoiMatKhau.Enabled = mo;
            HT_PhanQuyen.Enabled = mo;
            HT_PHDuLieu.Enabled = mo;
            HT_SLDuLieu.Enabled = mo;

            Menu_QuanLy_DP.Enabled = mo;
            Menu_QuanLy_DV.Enabled = mo;
            Menu_QuanLy_NP.Enabled = mo;
            Menu_QuanLy_TP.Enabled = mo;
            M_ThongKe_Ngay.Enabled = mo;

            Menu_DanhMuc_DV.Enabled = mo;
            Menu_DanhMuc_KH.Enabled = mo;
            Menu_DanhMuc_LDV.Enabled = mo;
            Menu_DanhMuc_LP.Enabled = mo;
            Menu_DanhMuc_NhanVien.Enabled = mo;
            Menu_DanhMuc_PH.Enabled = mo;
            Menu_DanhMuc_TB.Enabled = mo;

        }

        public void NVThuNgan(bool mo)
        {
            HT_DangNhap.Enabled = !mo;
            Menu_QuanLy_DP.Enabled = mo;
            Menu_QuanLy_DV.Enabled = mo;
            Menu_QuanLy_NP.Enabled = mo;
            Menu_QuanLy_TP.Enabled = mo;
            M_ThongKe_Ngay.Enabled = mo;
        }

        private void HT_DangNhap_Click(object sender, EventArgs e)
        {
            frmDangnhap FrmDNhap = new frmDangnhap();
            FrmDNhap.ShowDialog();
            Lbl_HoTen.ForeColor=Color.PaleGreen;
            Lbl_HoTen.BackColor = Color.Red;
            Lbl_HoTen.Text = Lbl_HoTen.Text+FrmDNhap.HoTenND;
            HoTenND = FrmDNhap.HoTenND;
            QuyenDN = FrmDNhap.QuyenDN;
            MaNV = FrmDNhap.MaNV;
            if (QuyenDN == "Admin")
                Admin(true);
            else if (QuyenDN == "Thu Ngân")
                NVThuNgan(true);
            
        }

        private void HT_DangXuat_Click(object sender, EventArgs e)
        {
            Lbl_HoTen.Text = "Hẹn gặp lại : " + "";
            Admin(false);
        }

        private void HT_QLNguoiDung_Click(object sender, EventArgs e)
        {
            Frm_DSNguoiDung FrmDSNguoiDung = new Frm_DSNguoiDung();
            FrmDSNguoiDung.MdiParent = this;
            FrmDSNguoiDung.Show();
        }

        private void HT_SLDuLieu_Click(object sender, EventArgs e)
        {
            Frm_SaoLuuDuLieu FrmSLDL = new Frm_SaoLuuDuLieu();
            FrmSLDL.MdiParent = this;
            FrmSLDL.Show();
        }

        private void HT_PHDuLieu_Click(object sender, EventArgs e)
        {
            Frm_PhucHoiDuLieu FrmPHDL = new Frm_PhucHoiDuLieu();
            FrmPHDL.MdiParent = this;
            FrmPHDL.Show();
        }

        private void HT_DoiMatKhau_Click(object sender, EventArgs e)
        {
            Frm_DoiMatMa FrmDoiMatMa = new Frm_DoiMatMa(MaNV);
            FrmDoiMatMa.MdiParent = this;
            FrmDoiMatMa.Show();
        }

        private void M_ThongKe_Ngay_Click(object sender, EventArgs e)
        {
          //  Frm_ThongKe FrmThongKe = new Frm_ThongKe();
        //    FrmThongKe.MdiParent = this;
        //    FrmThongKe.Show();
        }

        private void menu_Tacgia_Click(object sender, EventArgs e)
        {
            FrmThongTIn FrmTT = new FrmThongTIn();
            FrmTT.MdiParent = this;
            FrmTT.Show();
        }

       

       
    }
}
