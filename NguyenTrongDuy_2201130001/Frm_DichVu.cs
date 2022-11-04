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
    public partial class Frm_DichVu : Form
    {

        Cls_DichVu_PTA DV_PTA = new Cls_DichVu_PTA();
        Cls_DichVu_DTA DV_Data = new Cls_DichVu_DTA();

        Cls_LoaiDichVu_PTA LoaiDV_PTA = new Cls_LoaiDichVu_PTA();

        int iThem_Sua = 0;
        string sMaID = "";
        int vitri = -1;

        public Frm_DichVu()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (btn_Them.Text == "&Thêm")
            {
                iThem_Sua = 1;
                XoaKhoangTrang();
                DGV_DichVu.Enabled = false;
                btn_Xoa.Enabled = false;
                btn_Sua.Enabled = false;
                btn_Luu.Enabled = true;
                Gpb_ThongTin.Enabled = true;
                btn_Them.Text = "&Hủy";
                txt_TenDV.Focus();
                txt_TenDV.Select();
            }
            else if (btn_Them.Text == "&Hủy")
            {
                iThem_Sua = 0;
                DGV_DichVu.Focus();
                DGV_DichVu.Select();
                btn_Xoa.Enabled = true;
                btn_Sua.Enabled = true;
                btn_Luu.Enabled = false;
                Gpb_ThongTin.Enabled = false;
                DGV_DichVu.Enabled = true;
                btn_Them.Text = "&Thêm";
            }
        }

       
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_DichVu_Load(object sender, EventArgs e)
        {
            Gpb_ThongTin.Enabled = false;
            DGV_DichVu.Focus();
            DGV_DichVu.Select();
            GetTableLoaiDV();
            ShowTableData();
            btn_Luu.Enabled = false;
        }

        public void GetTableLoaiDV()
        {
            cbo_DichVu.DataSource = LoaiDV_PTA.GetTable("");
            cbo_DichVu.ValueMember = "MaLoaiDV";
            cbo_DichVu.DisplayMember = "TenLoaiDV";
        }

        public void ShowTableData()
        {
            MaLoaiDV.DataSource = LoaiDV_PTA.GetTable("");
            MaLoaiDV.ValueMember = "MaLoaiDV";
            MaLoaiDV.DisplayMember = "TenLoaiDV";

            DGV_DichVu.DataSource = DV_PTA.GetTable("");
        }

        public void XoaKhoangTrang()
        {
            txt_TenDV.Text = "";
            txt_DVTinh.Text = "";
            txt_DonGia.Text = "";
            txt_MoTa.Text = "";
            cbo_DichVu.SelectedIndex = -1;
            txt_TenDV.Focus();
            txt_TenDV.Select();
        }

        public void DK(bool mo)
        {
            
            btn_Xoa.Enabled = !mo;
            btn_Sua.Enabled = !mo;
            btn_Luu.Enabled = mo;
            Gpb_ThongTin.Enabled = mo;
           
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
            if(txt_TenDV.Text.Trim()=="")
            {
                txt_TenDV.Focus();
                txt_TenDV.Select();
            }
            else if (txt_DVTinh.Text.Trim() == "")
            {
                txt_DVTinh.Focus();
                txt_DVTinh.Select();
            }
            else if (txt_DonGia.Text.Trim() == "")
            {
                txt_DonGia.Focus();
                txt_DonGia.Select();
            }           
            else if (cbo_DichVu.SelectedIndex==-1)
            {
                cbo_DichVu.Focus();
                cbo_DichVu.Select();
            }
            else
            {
                
                GanData();
                if(iThem_Sua!=0)
                {
                    sMaID = DV_PTA.TaoMa("DV", 5);
                    DV_Data.MaDV = sMaID;
                    DV_PTA.Insert_Update_Delete(DV_Data, "Insert");
                    DGV_DichVu.CurrentCell = DGV_DichVu[0, DGV_DichVu.Rows.Count - 1];
                }
                else
                {
                    DV_Data.MaDV=DGV_DichVu.CurrentRow.Cells[0].Value.ToString();
                    DV_PTA.Insert_Update_Delete(DV_Data, "Update");
                    DGV_DichVu.CurrentCell = DGV_DichVu[0, vitri];
                    DGV_DichVu.CurrentRow.Selected = DGV_DichVu[0, vitri].Selected = true;
                }
                ShowTableData();
                btn_Xoa.Enabled = true;
                btn_Luu.Enabled = false;
                btn_Sua.Enabled = true;
                btn_Them.Enabled = true;
                btn_Them.Text = "&Thêm";
                btn_Sua.Text = "&Sửa";
                DGV_DichVu.Enabled = true;
                

            }
        }

        public void GanData()
        {
            DV_Data.TenDV = txt_TenDV.Text;
            DV_Data.DVTinh = txt_DVTinh.Text;
            DV_Data.DonGia = float.Parse(txt_DonGia.Text);
           
            DV_Data.MoTa = txt_MoTa.Text;
            DV_Data.MaLoaiDV = cbo_DichVu.SelectedValue.ToString();
        }

        private void DGV_DichVu_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                txt_TenDV.Text = DGV_DichVu.CurrentRow.Cells[1].Value.ToString();
                txt_DVTinh.Text = DGV_DichVu.CurrentRow.Cells[2].Value.ToString();
                txt_DonGia.Text = DGV_DichVu.CurrentRow.Cells[3].Value.ToString();
                txt_MoTa.Text = DGV_DichVu.CurrentRow.Cells[4].Value.ToString();
                cbo_DichVu.SelectedValue = DGV_DichVu.CurrentRow.Cells[5].Value.ToString();
                vitri = e.RowIndex;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (DGV_DichVu.CurrentRow.Index != -1)
            {
                DialogResult kq = MessageBox.Show("Bạn Có Muốn Xóa Phòng " + txt_TenDV.Text + " Không!", "Thông Báo", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    DV_Data.MaDV = DGV_DichVu.CurrentRow.Cells[0].Value.ToString();
                    GanData();
                    DV_PTA.Insert_Update_Delete(DV_Data, "Delete");
                }
                ShowTableData();
            }
        }

        private void txt_DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
