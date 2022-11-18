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

namespace PhucHien_MinhDuc
{
    public partial class Frm_PhongHat : Form
    {
        Cls_PhongHat_DTA PH_Data = new Cls_PhongHat_DTA();
        Cls_PhongHat_PTA PH_PTA = new Cls_PhongHat_PTA();

        Cls_LoaiPhong_PTA LoaiPhong_PTA = new Cls_LoaiPhong_PTA();

        int iThem_Sua = 0;
        string sMaPH = "";
        int vitri = -1;

        public Frm_PhongHat()
        {
            InitializeComponent();
        }

        private void Frm_PhongHat_Load(object sender, EventArgs e)
        {
            XoaKhoangTrang();
            HienThiLoai_Phong_Hat();
            HienThiPH();
            txt_TenPhong.Focus();
            txt_TenPhong.Select();
            btn_Luu.Enabled = false;
            grp_ThongTin.Enabled = false;
            
          
        }

        public void XoaKhoangTrang()
        {
            txt_TenPhong.Text = "";
            
            rad_DangHD.Checked = true;
            cbo_LoaiPhong.SelectedIndex = -1;
            
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();           
            
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(btn_Them.Text=="&Thêm")
            {
                iThem_Sua = 1;
                XoaKhoangTrang();
                Dgv_DSPhong.Enabled = false;
                btn_Xoa.Enabled = false;
                btn_Sua.Enabled = false;
                btn_Luu.Enabled = true;
                btn_Them.Text = "&Hủy";
                grp_ThongTin.Enabled = true;
            }
            else if(btn_Them.Text=="&Hủy")
            {
                iThem_Sua = 0;
                btn_Xoa.Enabled = true;
                btn_Sua.Enabled = true;
                btn_Luu.Enabled = false;
                Dgv_DSPhong.Enabled = true;
                btn_Them.Text = "&Thêm";
                grp_ThongTin.Enabled = false;
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (txt_TenPhong.Text.Trim() == "")
            {
                txt_TenPhong.Focus();
                txt_TenPhong.Select();
            }           
            else
            {
                GanData();
                if(iThem_Sua!=0)
                {
                    sMaPH = PH_PTA.TaoMa("PH", 5);
                    PH_Data.MaPH = sMaPH;                  
                    PH_PTA.Insert_Update_Delete(PH_Data, "Insert");
                    btn_Them.Text = "&Thêm";
                    HienThiPH();
                    Dgv_DSPhong.CurrentCell = Dgv_DSPhong[0, Dgv_DSPhong.Rows.Count - 1];
                }
                else
                {
                    PH_Data.MaPH = Dgv_DSPhong.CurrentRow.Cells[0].Value.ToString();                    
                    PH_PTA.Insert_Update_Delete(PH_Data, "Update");
                    HienThiPH();
                    btn_Sua.Text = "&Sửa";
                    Dgv_DSPhong.CurrentCell = Dgv_DSPhong.Rows[vitri].Cells[0];
                }
                
                btn_Xoa.Enabled = true;
                btn_Luu.Enabled = false;
                btn_Sua.Enabled = true;
                btn_Them.Enabled = true;
                Dgv_DSPhong.Enabled = true;
                btn_Them.Text = "&Thêm";
                btn_Sua.Text = "&Sửa";                
             
            }
        }

        public void GanData()
        {
            PH_Data.TenPH = txt_TenPhong.Text;
            PH_Data.TinhTrang = sTrangThai();
            PH_Data.TrangThai = 0;
            PH_Data.MaLoai = cbo_LoaiPhong.SelectedValue.ToString();
            PH_Data.NgayVao = "0";
            PH_Data.GioHT = "";
            PH_Data.GioSau = "";
          
        }

        public void HienThiLoai_Phong_Hat()
        {
            ///LoiaPhong
            
            cbo_LoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_LoaiPhong.DataSource = LoaiPhong_PTA.GetDatata("");
            cbo_LoaiPhong.ValueMember = "MaLoai";
            cbo_LoaiPhong.DisplayMember = "TenPhong";
            
        }

        public void HienThiPH()
        {
            
            TenPhong.DataSource = LoaiPhong_PTA.GetDatata("");
            TenPhong.ValueMember = "MaLoai";
            TenPhong.DisplayMember = "TenPhong";
            Dgv_DSPhong.DataSource = PH_PTA.GetTablePH("");
            
        }

        public int sTrangThai()
        {
            int i = -1;
            if (rad_DangHD.Checked == true)
                i = 0;
            else if (rad_DangSuaChu.Checked == true)
                i = 1;
            else
                i = 2;
            return i;
        }


        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (btn_Sua.Text == "&Sửa")
            {
                iThem_Sua = 0;
                btn_Them.Enabled = false;
                btn_Xoa.Enabled = false;
                btn_Luu.Enabled = true;
                btn_Sua.Text = "&Hủy";
                grp_ThongTin.Enabled = true;
            }
            else if (btn_Sua.Text == "&Hủy")
            {
                btn_Them.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_Luu.Enabled = false;
                grp_ThongTin.Enabled = false;
                btn_Sua.Text = "&Sửa";
            }
        }

        private void Dgv_DSPhong_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.RowIndex!=-1)
            {
                txt_TenPhong.Text = Dgv_DSPhong.CurrentRow.Cells[1].Value.ToString();
                TinhTrang(int.Parse(Dgv_DSPhong.CurrentRow.Cells[2].Value.ToString()));                           
                cbo_LoaiPhong.SelectedValue = Dgv_DSPhong.CurrentRow.Cells[4].Value.ToString();
                vitri = e.RowIndex;
            }
        }

        public void TinhTrang(int sTTrang)
        {
            if (sTTrang == 0)
                rad_DangHD.Checked = true;
            else if (sTTrang == 1)
                rad_DangSuaChu.Checked = true;
            else
                rad_KhongHD.Checked = true;
        }

       
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (Dgv_DSPhong.CurrentRow.Index != -1)
            {
                DialogResult kq = MessageBox.Show("Bạn Có Muốn Xóa Phòng " + txt_TenPhong.Text + " Không!", "Thông Báo", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    PH_Data.MaPH = Dgv_DSPhong.CurrentRow.Cells[0].Value.ToString();
                    GanData();
                    PH_Data.MaLoai = Dgv_DSPhong.CurrentRow.Cells[4].Value.ToString();
                    PH_PTA.Insert_Update_Delete(PH_Data, "Delete");
                    HienThiPH();

                }

            }
        }

     

       
    }
}
