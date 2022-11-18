using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAccessLayer;
using PresentationLayer;

namespace PhucHien_MinhDuc
{
    public partial class Frm_LoaiDV : Form
    {
        Cls_LoaiDichVu_PTA LoaiDV_PTA = new Cls_LoaiDichVu_PTA();
        Cls_LoaiDichVu_DTA LoaiDV_Data = new Cls_LoaiDichVu_DTA();
        int iThem_Sua = 0, vitri = -1;
        string sMaID = "";
        public Frm_LoaiDV()
        {
            InitializeComponent();
        }

        private void Frm_LoaiDV_Load(object sender, EventArgs e)
        {
            Gpb_ThongTin.Enabled = false;
            DGV_DichVu.Focus();
            DGV_DichVu.Select();
            txt_TenDV.Select();
            ShowTableData();
        }

        private void ShowTableData()
        {
            DGV_DichVu.DataSource = LoaiDV_PTA.GetTable("");
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

        private void XoaKhoangTrang()
        {
            txt_TenDV.Text = "";
            txt_LoaiDV.Text = "";
            
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

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(txt_TenDV.Text.Trim()=="")
            {
                txt_TenDV.Focus();
                txt_TenDV.Select();
            }
            else if(txt_LoaiDV.Text.Trim()=="")
            {
                txt_LoaiDV.Focus();
                txt_LoaiDV.Select();
            }
            else
            {
                
                GanData();
                if(iThem_Sua!=0)
                {
                    sMaID = LoaiDV_PTA.TaoMa("MLDV", 7);
                    LoaiDV_Data.MaLoaiDV = sMaID;
                    LoaiDV_PTA.Insert_Update_Delete(LoaiDV_Data, "Insert");
                    DGV_DichVu.CurrentCell = DGV_DichVu[0, DGV_DichVu.Rows.Count - 1];
                }
                else
                {
                    LoaiDV_Data.MaLoaiDV = DGV_DichVu.CurrentRow.Cells[0].Value.ToString();
                    LoaiDV_PTA.Insert_Update_Delete(LoaiDV_Data, "Update");
                    DGV_DichVu.CurrentCell = DGV_DichVu.Rows[vitri].Cells[0];

                }
                ShowTableData();
                btn_Xoa.Enabled = true;
                btn_Luu.Enabled = false;
                btn_Sua.Enabled = true;
                btn_Them.Enabled = true;
                btn_Them.Text = "&Thêm";
                btn_Sua.Text = "&Sửa";
            }
        }

        public void GanData()
        {
            LoaiDV_Data.TenLoaiDV = txt_TenDV.Text;
            LoaiDV_Data.LoaiDV = txt_LoaiDV.Text;
        }

        private void DGV_DichVu_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                txt_TenDV.Text = DGV_DichVu.CurrentRow.Cells[1].Value.ToString();
                txt_LoaiDV.Text = DGV_DichVu.CurrentRow.Cells[2].Value.ToString();
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
                    LoaiDV_Data.MaLoaiDV = DGV_DichVu.CurrentRow.Cells[0].Value.ToString();
                    GanData();
                    LoaiDV_PTA.Insert_Update_Delete(LoaiDV_Data, "Delete");
                }
                ShowTableData();
            }
        }
    }
}
