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
    public partial class Frm_ThietBi : Form
    {
        Cls_ThietBi_DTA TB_Data = new Cls_ThietBi_DTA();
        Cls_ThietBi_PTA TB_PTA = new Cls_ThietBi_PTA();

        Cls_LoaiThietBi_PTA LoaiTB_PTA = new Cls_LoaiThietBi_PTA();

        int iThem_Sua = 0, vitri = -1;
        string sMaID = "";
        bool sTrangThai = false;

        public Frm_ThietBi()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (btn_Them.Text == "&Thêm")
            {
                iThem_Sua = 1;
                XoaKhoangTrang();
                DGV_DanhSachTB.Enabled = false;
                btn_Xoa.Enabled = false;
                btn_Sua.Enabled = false;
                btn_Luu.Enabled = true;
                Gpb_ThongTin.Enabled = true;
                btn_Them.Text = "&Hủy";
            }
            else if (btn_Them.Text == "&Hủy")
            {
                iThem_Sua = 0;
                DGV_DanhSachTB.Focus();
                DGV_DanhSachTB.Select();
                btn_Xoa.Enabled = true;
                btn_Sua.Enabled = true;
                btn_Luu.Enabled = false;
                Gpb_ThongTin.Enabled = false;
                DGV_DanhSachTB.Enabled = true;
                btn_Them.Text = "&Thêm";
            }
        }

        private void XoaKhoangTrang()
        {
            txt_TenTB.Text = "";
            txt_DonGia.Text = "";
            txt_SoLuong.Text = "";
            cbo_LoaiTB.SelectedIndex = -1;
            rad_conhan.Checked = false;
            rad_hethan.Checked = false;
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

        private void btn_Thoai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Frm_ThietBi_Load(object sender, EventArgs e)
        {
            Gpb_ThongTin.Enabled = false;
            DGV_DanhSachTB.Focus();
            DGV_DanhSachTB.Select();
            GetTableLoaiTB();
            ShowTableData();
        }

        private void ShowTableData()
        {
            DGV_DanhSachTB.DataSource = TB_PTA.GetTable("");
        }

        private void GetTableLoaiTB()
        {
            DataTable Tbl=new DataTable();
            Tbl=LoaiTB_PTA.GetTable("");
            cbo_LoaiTB.DataSource = Tbl;
            cbo_LoaiTB.ValueMember = "MaLoaiTB";
            cbo_LoaiTB.DisplayMember = "TenLoaiTB";

            MaLoaiTB.DataSource = Tbl;
            MaLoaiTB.ValueMember = "MaLoaiTB";
            MaLoaiTB.DisplayMember = "TenLoaiTB";
        }

        public bool sKiemTraTT()
        {
            if (rad_conhan.Checked == true)
                sTrangThai = true;
            return sTrangThai;

        }

        private void DGV_DanhSachTB_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                txt_TenTB.Text = DGV_DanhSachTB.CurrentRow.Cells[1].Value.ToString();
                txt_DonGia.Text = DGV_DanhSachTB.CurrentRow.Cells[2].Value.ToString();
                txt_SoLuong.Text = DGV_DanhSachTB.CurrentRow.Cells[3].Value.ToString();
                GetTT(DGV_DanhSachTB.CurrentRow.Cells[4].Value.ToString());
                cbo_LoaiTB.SelectedValue = DGV_DanhSachTB.CurrentRow.Cells[5].Value.ToString();
                vitri = e.RowIndex;
            }
        }

        public void GetTT(string sGet)
        {
            if (sGet == "true")
                rad_conhan.Checked = true;
            rad_hethan.Checked = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (txt_TenTB.Text.Trim() == "")
            {
                txt_TenTB.Focus();
                txt_TenTB.Select();
            }
           
            else if (txt_DonGia.Text.Trim() == "")
            {
                txt_DonGia.Focus();
                txt_DonGia.Select();
            }
            else if (txt_SoLuong.Text.Trim() == "")
            {
                txt_SoLuong.Focus();
                txt_SoLuong.Select();
            }
            else if (rad_conhan.Checked != true && rad_hethan.Checked != true)
            {
                rad_hethan.Focus();
            }

            else if (cbo_LoaiTB.SelectedIndex == -1)
            {
                cbo_LoaiTB.Focus();
                cbo_LoaiTB.Select();
            }
            else
            {
                
                GanData();
                if (iThem_Sua != 0)
                {
                    sMaID = TB_PTA.TaoMa("DV", 5);
                    TB_Data.MaTB = sMaID;
                    TB_PTA.Insert_Update_Delete(TB_Data, "Insert");
                    btn_Them.Text = "&Thêm";
                    DGV_DanhSachTB.CurrentCell = DGV_DanhSachTB[0, DGV_DanhSachTB.Rows.Count - 1];
                }
                else
                {
                    TB_Data.MaTB = DGV_DanhSachTB.CurrentRow.Cells[0].Value.ToString();
                    TB_PTA.Insert_Update_Delete(TB_Data, "Update");
                    btn_Sua.Text = "&Sửa";
                    DGV_DanhSachTB.CurrentCell = DGV_DanhSachTB.Rows[vitri].Cells[0];
                }
                ShowTableData();
                btn_Xoa.Enabled = true;
                btn_Luu.Enabled = false;
                btn_Sua.Enabled = true;
                btn_Them.Enabled = true;
                
                DGV_DanhSachTB.Enabled = true;

            }
        }

        private void GanData()
        {
            TB_Data.TenTB = txt_TenTB.Text;
            TB_Data.DonGia = float.Parse(txt_DonGia.Text);
            TB_Data.SoLuong = int.Parse(txt_SoLuong.Text);
            TB_Data.TrangThai = sKiemTraTT();
            TB_Data.MaLoaiTB = cbo_LoaiTB.SelectedValue.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (DGV_DanhSachTB.CurrentRow.Index != -1)
            {
                DialogResult kq = MessageBox.Show("Bạn Có Muốn Xóa Phòng " + txt_TenTB.Text + " Không!", "Thông Báo", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    TB_Data.MaTB = DGV_DanhSachTB.CurrentRow.Cells[0].Value.ToString();
                    GanData();
                    TB_PTA.Insert_Update_Delete(TB_Data, "Delete");
                }
                ShowTableData();
                if(DGV_DanhSachTB.Rows.Count==0)
                {
                    XoaKhoangTrang();
                }
            }
        }



       
    }
}
