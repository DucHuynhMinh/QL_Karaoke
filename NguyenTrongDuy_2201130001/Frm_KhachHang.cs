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
    public partial class Frm_KhachHang : Form
    {
        Cls_KhachHang_PTA KH_PTA = new Cls_KhachHang_PTA();
        Cls_KhachHang_DTA KH_Data = new Cls_KhachHang_DTA();

        Cls_LoaiKhachHang_PTA LoaiKH_PTA = new Cls_LoaiKhachHang_PTA();

        int iThem_Sua = 0;
        string sMaID = "";
        int vitri = -1;
        public Frm_KhachHang()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (btn_Them.Text == "&Thêm")
            {
                iThem_Sua = 1;
                XoaKhoangTrang();
                dgv_danhsachkh.Enabled = false;
                btn_Xoa.Enabled = false;
                btn_Sua.Enabled = false;
                btn_Luu.Enabled = true;
                Gpb_ThongTin.Enabled = true;
                btn_Them.Text = "&Hủy";
            }
            else if (btn_Them.Text == "&Hủy")
            {
                iThem_Sua = 0;
                dgv_danhsachkh.Focus();
                dgv_danhsachkh.Select();
                btn_Xoa.Enabled = true;
                btn_Sua.Enabled = true;
                btn_Luu.Enabled = false;
                Gpb_ThongTin.Enabled = false;
                dgv_danhsachkh.Enabled = true;
                btn_Them.Text = "&Thêm";
            }
        }

        private void XoaKhoangTrang()
        {
            txt_TenKH.Text = "";
            txt_TheCard.Text = "";
            rad_nam.Checked = false;
            rad_nu.Checked = false;
            txt_DienThoai.Text = "";
            txt_Email.Text = "";
            txt_DiaChi.Text = "";
            rad_Dkweb.Checked = false;
            rad_GoiDien.Checked = false;
            rad_TrucTiep.Checked = false;
            cbo_LoaiKH.SelectedIndex = -1;
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

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_DienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txt_TheCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void dgv_danhsachkh_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string sPhai = "";
            string sHTDK = "";
            if(e.RowIndex!=-1)
            {
                txt_TenKH.Text = dgv_danhsachkh.CurrentRow.Cells[1].Value.ToString();
                txt_TheCard.Text = dgv_danhsachkh.CurrentRow.Cells[2].Value.ToString();
                dpk_NgaySinh.Value= Convert.ToDateTime(dgv_danhsachkh.CurrentRow.Cells[3].Value);
                sPhai = dgv_danhsachkh.CurrentRow.Cells[4].Value.ToString();
                if (sPhai == "True")
                    rad_nam.Checked = true;
                else rad_nu.Checked = true;
                
                txt_DienThoai.Text = dgv_danhsachkh.CurrentRow.Cells[5].Value.ToString();
                txt_DiaChi.Text = dgv_danhsachkh.CurrentRow.Cells[6].Value.ToString();
                txt_Email.Text = dgv_danhsachkh.CurrentRow.Cells[7].Value.ToString();
                sHTDK = dgv_danhsachkh.CurrentRow.Cells[8].Value.ToString();

                if (sHTDK == "Trực Tiếp")
                    rad_TrucTiep.Checked = true;
                if (sHTDK == "Gọi Điện Thoại")
                    rad_GoiDien.Checked = true;
                else
                    rad_Dkweb.Checked = true;
                cbo_LoaiKH.SelectedValue = dgv_danhsachkh.CurrentRow.Cells[9].Value.ToString();
                vitri = e.RowIndex;
            }
        }

        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            Gpb_ThongTin.Enabled = false;
            dgv_danhsachkh.Focus();
            dgv_danhsachkh.Select();
            txt_TenKH.Select();
            ShowTableDataLoaiKH();
            ShowTableData();
            btn_Luu.Enabled = false;
            
        }

        private void ShowTableDataLoaiKH()
        {
            DataTable tbl=new DataTable();
            tbl = LoaiKH_PTA.GetTable("");
            cbo_LoaiKH.DataSource =tbl ;
            cbo_LoaiKH.ValueMember = "MaLoaiKH";
            cbo_LoaiKH.DisplayMember = "TenLoaiKH";

            MaLoaiKH.DataSource=tbl;
            MaLoaiKH.ValueMember = "MaLoaiKH";
            MaLoaiKH.DisplayMember = "TenLoaiKH";

        }

        private void ShowTableData()
        {
            dgv_danhsachkh.DataSource = KH_PTA.GetTable("");
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (txt_TenKH.Text.Trim() == "")
            {
                txt_TenKH.Focus();
                txt_TenKH.Select();
            }
            
            else if (txt_DienThoai.Text.Trim() == "")
            {
                txt_DienThoai.Focus();
                txt_DienThoai.Select();
            }        
            else if (rad_nam.Checked != true && rad_nu.Checked != true)
            {
                MessageBox.Show("Xin Vui Lòng Chọn Giới Tính", "Thông Báo");
                rad_nu.Focus();
            }
            else
            {

                GanData();
                if (iThem_Sua != 0)
                {
                    sMaID = LoaiKH_PTA.TaoMa("KH", 5);
                    KH_Data.MaKH = sMaID;
                    KH_PTA.Insert_Update_Delete(KH_Data, "Insert");
                    dgv_danhsachkh.CurrentCell = dgv_danhsachkh[0, dgv_danhsachkh.Rows.Count - 1];
                }
                else
                {
                    KH_Data.MaKH = dgv_danhsachkh.CurrentRow.Cells[0].Value.ToString();
                    KH_PTA.Insert_Update_Delete(KH_Data, "Update");
                    dgv_danhsachkh.CurrentCell = dgv_danhsachkh.Rows[vitri].Cells[0];
                }
                ShowTableData();
                btn_Xoa.Enabled = true;
                btn_Luu.Enabled = false;
                btn_Sua.Enabled = true;
                btn_Them.Enabled = true;
                btn_Them.Text = "&Thêm";
                btn_Sua.Text = "&Sửa";
                dgv_danhsachkh.Enabled = true;
            }
        }

        public string ChonHinhThucDK()
        {
            string sDK = "";
            if (rad_TrucTiep.Checked == true)
                sDK = "Trực Tiếp";
            else if (rad_GoiDien.Checked == true)
                sDK = "Gọi Điện Thoại";
            else
                sDK = "ĐK website";
            return sDK;
        }

        private void GanData()
        {
            KH_Data.TenKH = txt_TenKH.Text;
            KH_Data.TheCard = txt_TheCard.Text;
            KH_Data.NgaySinh = dpk_NgaySinh.Value;
            KH_Data.Phai = rad_nam.Checked == true ? true : false;
            KH_Data.DienThoai = txt_DienThoai.Text;
            KH_Data.DiaChi = txt_DiaChi.Text;
            KH_Data.Email = txt_Email.Text;
            KH_Data.HinhThucDK = ChonHinhThucDK();
            KH_Data.MaLoaiKH = cbo_LoaiKH.SelectedValue.ToString();

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_danhsachkh.CurrentRow.Index != -1)
            {
                DialogResult kq = MessageBox.Show("Bạn Có Muốn Xóa Phòng " + txt_TenKH.Text + " Không!", "Thông Báo", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    KH_Data.MaKH = dgv_danhsachkh.CurrentRow.Cells[0].Value.ToString();
                    GanData();
                    KH_PTA.Insert_Update_Delete(KH_Data, "Delete");

                }
                ShowTableData();
                if (dgv_danhsachkh.Rows.Count == 0)
                {
                    XoaKhoangTrang();
                }
            }
        }

       

       
        
    }
}
