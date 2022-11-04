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
    public partial class Frm_LoaiThietBi : Form
    {
        Cls_LoaiThietBi_PTA LoaiTB_PTA = new Cls_LoaiThietBi_PTA();
        Cls_LoaiThietBi_DTA LoaiTB_Data = new Cls_LoaiThietBi_DTA();
        int iThem_Sua = 0, vitri = -1;
        string sMaID = "";

        public Frm_LoaiThietBi()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (btn_Them.Text == "&Thêm")
            {
                iThem_Sua = 1;
                XoaKhoangTrang();
                DGV_LoaiThietBi.Enabled = false;
                btn_Xoa.Enabled = false;
                btn_Sua.Enabled = false;
                btn_Luu.Enabled = true;
                Gpb_ThongTin.Enabled = true;
                btn_Them.Text = "&Hủy";
            }
            else if (btn_Them.Text == "&Hủy")
            {
                iThem_Sua = 0;
                DGV_LoaiThietBi.Focus();
                DGV_LoaiThietBi.Select();
                btn_Xoa.Enabled = true;
                btn_Sua.Enabled = true;
                btn_Luu.Enabled = false;
                Gpb_ThongTin.Enabled = false;
                DGV_LoaiThietBi.Enabled = true;
                btn_Them.Text = "&Thêm";
            }
        }

        private void XoaKhoangTrang()
        {
            txt_TenLoaiTB.Text = "";
            txt_XuatXu.Text = "";
            txt_TenLoaiTB.Focus();
            txt_TenLoaiTB.Select();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (txt_TenLoaiTB.Text.Trim() == "")
            {
                txt_TenLoaiTB.Focus();
                txt_TenLoaiTB.Select();
            }
            else if (txt_XuatXu.Text.Trim() == "")
            {
                txt_XuatXu.Focus();
                txt_XuatXu.Select();
            }
            else
            {
               
                GanData();
                if (iThem_Sua != 0)
                {
                    sMaID = LoaiTB_PTA.TaoMa("MLTB", 7);
                    LoaiTB_Data.MaLoaiTB = sMaID;
                    LoaiTB_PTA.Insert_Update_Delete(LoaiTB_Data, "Insert");
                    btn_Them.Text = "&Thêm";
                    DGV_LoaiThietBi.CurrentCell = DGV_LoaiThietBi[0, DGV_LoaiThietBi.Rows.Count - 1];
                }
                else
                {
                    LoaiTB_Data.MaLoaiTB = DGV_LoaiThietBi.CurrentRow.Cells[0].Value.ToString();
                    LoaiTB_PTA.Insert_Update_Delete(LoaiTB_Data, "Update");
                    btn_Sua.Text = "&Sửa";
                    DGV_LoaiThietBi.CurrentCell = DGV_LoaiThietBi.Rows[vitri].Cells[0];
                }
                ShowTableData();
                btn_Xoa.Enabled = true;
                btn_Luu.Enabled = false;
                btn_Sua.Enabled = true;
                btn_Them.Enabled = true; 
                
                DGV_LoaiThietBi.Enabled = true;
            }
        }

        private void ShowTableData()
        {
            DGV_LoaiThietBi.DataSource = LoaiTB_PTA.GetTable("");
        }

        private void GanData()
        {
            LoaiTB_Data.TenLoaiTB = txt_TenLoaiTB.Text;
            LoaiTB_Data.XuatXu = txt_XuatXu.Text;
        }

        private void Frm_LoaiThietBi_Load(object sender, EventArgs e)
        {
            Gpb_ThongTin.Enabled = false;
            DGV_LoaiThietBi.Focus();
            DGV_LoaiThietBi.Select();
            txt_TenLoaiTB.Select();
            ShowTableData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (DGV_LoaiThietBi.CurrentRow.Index != -1)
            {
                DialogResult kq = MessageBox.Show("Bạn Có Muốn Xóa Phòng " + txt_TenLoaiTB.Text + " Không!", "Thông Báo", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    LoaiTB_Data.MaLoaiTB = DGV_LoaiThietBi.CurrentRow.Cells[0].Value.ToString();
                    GanData();
                    LoaiTB_PTA.Insert_Update_Delete(LoaiTB_Data, "Delete");
                    
                }
                ShowTableData();
                if (DGV_LoaiThietBi.Rows.Count == 0)
                {
                    XoaKhoangTrang();
                }
            }
        }

        private void DGV_LoaiThietBi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                txt_TenLoaiTB.Text = DGV_LoaiThietBi.CurrentRow.Cells[1].Value.ToString();
                txt_XuatXu.Text = DGV_LoaiThietBi.CurrentRow.Cells[2].Value.ToString();
                vitri = e.RowIndex;
            }
        }
    }
}
