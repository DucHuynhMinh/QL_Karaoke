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
    public partial class Frm_NhanVien : Form
    {
        Cls_NhanVien_PTA NV_PTA = new Cls_NhanVien_PTA();
        Cls_NhanVien_DTA NV_Data = new Cls_NhanVien_DTA();

        int iThem_Sua = 0, vitri = -1;
        string sMaID = "";
        public Frm_NhanVien()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (btn_Them.Text == "&Thêm")
            {
                iThem_Sua = 1;
                XoaKhoangTrang();
                dgv_DanhSachNV.Enabled = false;
                btn_Xoa.Enabled = false;
                btn_Sua.Enabled = false;
                btn_Luu.Enabled = true;
                Gpb_ThongTin.Enabled = true;
                btn_Them.Text = "&Hủy";
            }
            else if (btn_Them.Text == "&Hủy")
            {
                iThem_Sua = 0;
                dgv_DanhSachNV.Focus();
                dgv_DanhSachNV.Select();
                btn_Xoa.Enabled = true;
                btn_Sua.Enabled = true;
                btn_Luu.Enabled = false;
                Gpb_ThongTin.Enabled = false;
                dgv_DanhSachNV.Enabled = true;
                btn_Them.Text = "&Thêm";
            }
        }

        private void XoaKhoangTrang()
        {
            txt_TenDN.Text = "";
            txt_MatMaDN.Text = "";
            rad_Admin.Checked = rad_NhanVienTN.Checked = rad_NhanVienPV.Checked = rad_Nu.Checked = rad_Nam.Checked = false;
            txt_HoTenNV.Text = "";
            txt_DienThoai.Text = "";
            txt_DiaChi.Text = "";
            txt_LuongNV.Text = "";
            txt_TenDN.Focus();
            txt_TenDN.Select();
            
        }

        public string QuyenNV()
        {
            string sTrangThai = "";
            if (rad_Admin.Checked != false)
                sTrangThai = "Admin";
            else if (rad_NhanVienTN.Checked != false)
                sTrangThai = "Thu Ngân";
            else
                sTrangThai = "Phục Vụ";
            return sTrangThai;
        }

        public bool KTPhai()
        {
            bool sTrangThai = false;
            if (rad_Nam.Checked != false)
                sTrangThai = true;
            return sTrangThai;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (btn_Sua.Text == "&Sửa")
            {
                iThem_Sua = 0;
                btn_Them.Enabled = false;
                btn_Xoa.Enabled = false;
                btn_Luu.Enabled = true;
                Gpb_ThongTin.Enabled = true;
                btn_Sua.Text = "&Hủy";
            }
            else if (btn_Sua.Text == "&Hủy")
            {
                btn_Them.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_Luu.Enabled = false;
                Gpb_ThongTin.Enabled = false;
                btn_Sua.Text = "&Sửa";
            }
        }

        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            Gpb_ThongTin.Enabled = false;
            dgv_DanhSachNV.Focus();
            dgv_DanhSachNV.Select();          
            ShowTableData();
            btn_Luu.Enabled = false;
        }

        private void ShowTableData()
        {
            dgv_DanhSachNV.DataSource = NV_PTA.GetTable("");
        }

        private void txt_LuongNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txt_DienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btn_Thoai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_DanhSachNV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string TestPhai = "";
            if(e.RowIndex!=-1)
            {
                txt_TenDN.Text = dgv_DanhSachNV.CurrentRow.Cells[1].Value.ToString();
                txt_MatMaDN.Text = dgv_DanhSachNV.CurrentRow.Cells[2].Value.ToString();
                sTrangThaiQuyenDN(dgv_DanhSachNV.CurrentRow.Cells[3].Value.ToString());
                txt_HoTenNV.Text = dgv_DanhSachNV.CurrentRow.Cells[4].Value.ToString();
                dpk_NgaySinh.Value = Convert.ToDateTime(dgv_DanhSachNV.CurrentRow.Cells[5].Value);
                TestPhai = dgv_DanhSachNV.CurrentRow.Cells[6].Value.ToString();
                if (TestPhai == "True")
                    rad_Nam.Checked = true;
                else rad_Nu.Checked = true;
                txt_DienThoai.Text = dgv_DanhSachNV.CurrentRow.Cells[7].Value.ToString();
                txt_DiaChi.Text = dgv_DanhSachNV.CurrentRow.Cells[8].Value.ToString();
                txt_LuongNV.Text = dgv_DanhSachNV.CurrentRow.Cells[9].Value.ToString();
                vitri = e.RowIndex;
            }
        }

        public void sTrangThaiQuyenDN(string sTemp)
        {
            if (sTemp == "Admin")
                rad_Admin.Checked = true;
            else if (sTemp == "Thu Ngân")
                rad_NhanVienTN.Checked = true;
            else
                rad_NhanVienPV.Checked = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (txt_TenDN.Text.Trim() == "")
            {
                txt_TenDN.Focus();
                txt_TenDN.Select();
            }
            else if (txt_MatMaDN.Text.Trim() == "")
            {
                txt_MatMaDN.Focus();
                txt_MatMaDN.Select();
            }
            else if (rad_Admin.Checked != true && rad_NhanVienPV.Checked != true && rad_NhanVienTN.Checked != true)
            {
                MessageBox.Show("Xin Vui Lòng chọn quyền đăng nhập", "Thông Báo");
                rad_Admin.Focus();
            }
            else if (txt_HoTenNV.Text.Trim() == "")
            {
                txt_HoTenNV.Focus();
                txt_HoTenNV.Select();
            }
            else if (rad_Nam.Checked != true && rad_Nu.Checked != true)
            {
                MessageBox.Show("Xin Vui Lòng Chọn Giới Tính", "Thông Báo");
                rad_Nam.Focus();
            }           
           
            else
            {

                GanData();
                if (iThem_Sua != 0)
                {
                    sMaID = NV_PTA.TaoMa("NV", 5);
                    NV_Data.MaNV = sMaID;
                    NV_PTA.Insert_Update_Delete(NV_Data, "Insert");
                    dgv_DanhSachNV.CurrentCell = dgv_DanhSachNV[0, dgv_DanhSachNV.Rows.Count - 1];
                }
                else
                {
                    NV_Data.MaNV = dgv_DanhSachNV.CurrentRow.Cells[0].Value.ToString();
                    NV_PTA.Insert_Update_Delete(NV_Data, "Update");
                    dgv_DanhSachNV.CurrentCell = dgv_DanhSachNV.Rows[vitri].Cells[0];
                }
                ShowTableData();
                btn_Xoa.Enabled = true;
                btn_Luu.Enabled = false;
                btn_Sua.Enabled = true;
                btn_Them.Enabled = true;
                btn_Them.Text = "&Thêm";
                btn_Sua.Text = "&Sửa";
                dgv_DanhSachNV.Enabled = true;
            }
        }

        private void GanData()
        {
            NV_Data.TenDN = txt_TenDN.Text;
            NV_Data.MaMaDN = txt_MatMaDN.Text;
            NV_Data.QuyenDN = QuyenNV();
            NV_Data.HoTenNV = txt_HoTenNV.Text;
            NV_Data.NgaySinh = dpk_NgaySinh.Value;
            NV_Data.Phai = KTPhai();
            NV_Data.DienThoai = txt_DienThoai.Text;
            NV_Data.DiaChi = txt_DiaChi.Text;
            if (txt_LuongNV.Text.Trim() != "")
                NV_Data.LuongNV = int.Parse(txt_LuongNV.Text);
            else
            {
                txt_LuongNV.Focus();
                txt_LuongNV.Select();
            }
         
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSachNV.CurrentRow.Index != -1)
            {
                DialogResult kq = MessageBox.Show("Bạn Có Muốn Xóa Phòng " + txt_HoTenNV.Text + " Không!", "Thông Báo", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    NV_Data.MaNV = dgv_DanhSachNV.CurrentRow.Cells[0].Value.ToString();
                    GanData();
                    NV_PTA.Insert_Update_Delete(NV_Data, "Delete");

                }
                ShowTableData();
                if (dgv_DanhSachNV.Rows.Count == 0)
                {
                    XoaKhoangTrang();
                }
            }
        }

        private void txt_LuongNV_Click(object sender, EventArgs e)
        {
            txt_LuongNV.Text = "";
        }
    }
}
