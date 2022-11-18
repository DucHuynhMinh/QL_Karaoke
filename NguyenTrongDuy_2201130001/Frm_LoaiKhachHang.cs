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

namespace PhucHien_MinhDuc
{
    public partial class Frm_LoaiKhachHang : Form
    {
        Cls_LoaiKhachHang_PTA LoaiKH_PTA = new Cls_LoaiKhachHang_PTA();
        Cls_LoaiKhachHang_DTA LoaiKH_Data = new Cls_LoaiKhachHang_DTA();

        int iThem_Sua = 0, vitri = -1;
        string sMaID = "";

        public Frm_LoaiKhachHang()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (btn_Them.Text == "&Thêm")
            {
                iThem_Sua = 1;
                XoaKhoangTrang();
                DGV_LoaiKH.Enabled = false;
                btn_Xoa.Enabled = false;
                btn_Sua.Enabled = false;
                btn_Luu.Enabled = true;
                Gpb_ThongTin.Enabled = true;
                btn_Them.Text = "&Hủy";
            }
            else if (btn_Them.Text == "&Hủy")
            {
                iThem_Sua = 0;
                DGV_LoaiKH.Focus();
                DGV_LoaiKH.Select();
                btn_Xoa.Enabled = true;
                btn_Sua.Enabled = true;
                btn_Luu.Enabled = false;
                Gpb_ThongTin.Enabled = false;
                DGV_LoaiKH.Enabled = true;
                btn_Them.Text = "&Thêm";
            }
        }

        private void XoaKhoangTrang()
        {
            txt_TenLoaiKH.Text = "";
            txt_SoLuong.Text = "";
            txt_TenLoaiKH.Focus();
            txt_TenLoaiKH.Select();
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

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Frm_LoaiKhachHang_Load(object sender, EventArgs e)
        {
            Gpb_ThongTin.Enabled = false;
            DGV_LoaiKH.Focus();
            DGV_LoaiKH.Select();
            txt_TenLoaiKH.Select();
            ShowTableData();
        }

        private void ShowTableData()
        {
            DGV_LoaiKH.DataSource = LoaiKH_PTA.GetTable("");
        }

        private void DGV_LoaiKH_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                txt_TenLoaiKH.Text = DGV_LoaiKH.CurrentRow.Cells[1].Value.ToString();
                txt_SoLuong.Text = DGV_LoaiKH.CurrentRow.Cells[2].Value.ToString();
                vitri = e.RowIndex;
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (txt_TenLoaiKH.Text.Trim() == "")
            {
                txt_TenLoaiKH.Focus();
                txt_TenLoaiKH.Select();
            }
            else if (txt_SoLuong.Text.Trim() == "")
            {
                txt_SoLuong.Focus();
                txt_SoLuong.Select();
            }
            else
            {
                
                GanData();
                if (iThem_Sua != 0)
                {
                    sMaID = LoaiKH_PTA.TaoMa("LKH", 5);
                    LoaiKH_Data.MaLoaiKH = sMaID;
                    LoaiKH_PTA.Insert_Update_Delete(LoaiKH_Data, "Insert");
                    DGV_LoaiKH.CurrentCell = DGV_LoaiKH[0, DGV_LoaiKH.Rows.Count - 1];
                }
                else
                {
                    LoaiKH_Data.MaLoaiKH = DGV_LoaiKH.CurrentRow.Cells[0].Value.ToString();
                    LoaiKH_PTA.Insert_Update_Delete(LoaiKH_Data, "Update");
                    DGV_LoaiKH.CurrentCell = DGV_LoaiKH.Rows[vitri].Cells[0];
                }
                ShowTableData();
                btn_Xoa.Enabled = true;
                btn_Luu.Enabled = false;
                btn_Sua.Enabled = true;
                btn_Them.Enabled = true;
                btn_Them.Text = "&Thêm";
                btn_Sua.Text = "&Sửa";
                DGV_LoaiKH.Enabled = true;
            }
        }

        private void GanData()
        {
            LoaiKH_Data.TenLoaiKH = txt_TenLoaiKH.Text;
            LoaiKH_Data.SoLuong = int.Parse(txt_SoLuong.Text);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (DGV_LoaiKH.CurrentRow.Index != -1)
            {
                DialogResult kq = MessageBox.Show("Bạn Có Muốn Xóa Phòng " + txt_TenLoaiKH.Text + " Không!", "Thông Báo", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    LoaiKH_Data.MaLoaiKH = DGV_LoaiKH.CurrentRow.Cells[0].Value.ToString();
                    GanData();
                    LoaiKH_PTA.Insert_Update_Delete(LoaiKH_Data, "Delete");

                }
                ShowTableData();
                if (DGV_LoaiKH.Rows.Count == 0)
                {
                    XoaKhoangTrang();
                }
            }
        }
    }
}
