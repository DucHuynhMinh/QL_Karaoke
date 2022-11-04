using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using PresentationLayer;

namespace NguyenTrongDuy_2201130001
{
    public partial class Frm_LoaiPhong : Form
    {

        Cls_LoaiPhong_PTA LP_PTA = new Cls_LoaiPhong_PTA();
        Cls_LoaiPhong_DTA LP_Data = new Cls_LoaiPhong_DTA();
        int iThem_Luu = 0;
        int vitri = -1;
        public Frm_LoaiPhong()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void Frm_LoaiPhong_Load(object sender, EventArgs e)
        {
            ShowDataLoaiPhong();
            DGV_DSLP.Focus();
            DGV_DSLP.Select();
        }

        public void ShowDataLoaiPhong()
        {
            DGV_DSLP.DataSource = LP_PTA.GetDatata("");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (btn_Them.Text == "&Thêm")
            {
                iThem_Luu = 1;
                DK(true);      
                XoaKhoangTrang();
                btn_Them.Text = "&Hủy";
                grp_thongtin.Enabled = true;
                
            }
            else if (btn_Them.Text == "&Hủy")
            {
                iThem_Luu = 0;
                DK(false);
                DGV_DSLP.Focus();
                DGV_DSLP.Select();
                btn_Them.Text = "&Thêm";
                grp_thongtin.Enabled = false;
                
            }
        }

        public void DK(bool mo)
        {
           
            btn_Sua.Enabled = !mo;
            btn_Xoa.Enabled = !mo;
            btn_Luu.Enabled = mo;

        }

        public void XoaKhoangTrang()
        {
            txt_TenLoai.Text = "";
            txt_GioCD.Text = "";
            txt_GioBT.Text = "";
            txt_TenLoai.Focus();
            txt_TenLoai.Select();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(txt_TenLoai.Text.Trim()=="")
            {
                txt_TenLoai.Focus();
                txt_TenLoai.Select();
            }
            else if(txt_GioCD.Text.Trim()=="")
            {
                txt_GioCD.Focus();
                txt_GioCD.Select();
            }
            else if (txt_GioBT.Text.Trim() == "")
            {
                txt_GioBT.Focus();
                txt_GioBT.Select();
            }
          
            else
            {
                GanData();
                if(iThem_Luu!=0){
                    string sMaLoai = LP_PTA.TaoMa("LP", 5); 
                    LP_Data.MaLoai = sMaLoai;                                     
                    LP_PTA.Insert_Update_Delete(LP_Data, "Insert");
                    btn_Them.Text = "&Thêm";
                    DGV_DSLP.CurrentCell = DGV_DSLP[0, DGV_DSLP.Rows.Count - 1];
                }
                else
                {
                    LP_Data.MaLoai = DGV_DSLP.CurrentRow.Cells[0].Value.ToString(); 
                    LP_PTA.Insert_Update_Delete(LP_Data, "Update");
                    btn_Sua.Text = "&Sửa";
                    DGV_DSLP.CurrentCell = DGV_DSLP.Rows[vitri].Cells[0];
                }
                ShowDataLoaiPhong();
            }
            btn_Them.Enabled = true;
            btn_Them.Text = "&Thêm";
            btn_Sua.Text = "&Sửa";
            DK(false);
        }

        public void GanData()
        {
            LP_Data.TenLoai = txt_TenLoai.Text;
            LP_Data.GioCD = float.Parse(txt_GioCD.Text);
            LP_Data.GioBT = float.Parse(txt_GioBT.Text);
        }
       

       

        private void DGV_DSLP_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                txt_TenLoai.Text = DGV_DSLP.CurrentRow.Cells[1].Value.ToString();
                txt_GioCD.Text = DGV_DSLP.CurrentRow.Cells[2].Value.ToString();
                txt_GioBT.Text = DGV_DSLP.CurrentRow.Cells[3].Value.ToString();
                vitri = e.RowIndex;
            }
            btn_Them.Enabled = true;
            grp_thongtin.Enabled = false;


        }
       

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if(btn_Sua.Text=="&Sửa")
            {
                iThem_Luu = 0;
                btn_Them.Enabled = false;
                btn_Xoa.Enabled = false;
                btn_Luu.Enabled = true;
                btn_Sua.Text = "&Hủy";
                grp_thongtin.Enabled = true;
                DGV_DSLP.Enabled = false;
                
            }
            else if (btn_Sua.Text == "&Hủy")
            {
                btn_Them.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_Luu.Enabled = false;
                btn_Sua.Text = "&Sửa";
                DGV_DSLP.Enabled = true;
                grp_thongtin.Enabled = false;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(DGV_DSLP.CurrentRow.Index!=-1)
            {
                DialogResult kq = MessageBox.Show("Bạn Có Muốn Xóa Phòng " + txt_TenLoai.Text + " Không!", "Thông Báo", MessageBoxButtons.YesNo);
                if(kq==DialogResult.Yes)
                {
                    LP_Data.MaLoai=DGV_DSLP.CurrentRow.Cells[0].Value.ToString();
                    GanData();
                    LP_PTA.Insert_Update_Delete(LP_Data, "Delete");
                    ShowDataLoaiPhong();
                }
                
            }
        }

        private void txt_GioCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txt_GioBT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
