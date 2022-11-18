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
    public partial class Frm_QuanLyDichVu : Form
    {
        Cls_PhongHat_DTA PHat_DATA = new Cls_PhongHat_DTA();
        Cls_PhongHat_PTA PHat_PTA = new Cls_PhongHat_PTA();

        Cls_LoaiDichVu_DTA LoaiDV_DATA = new Cls_LoaiDichVu_DTA();
        Cls_LoaiDichVu_PTA LoaiDV_PTA = new Cls_LoaiDichVu_PTA();

        Cls_DichVu_DTA DV_DATA = new Cls_DichVu_DTA();
        Cls_DichVu_PTA DV_PTA = new Cls_DichVu_PTA();

        Cls_ChiTietDichVu_DTA CTDichVu_DATA = new Cls_ChiTietDichVu_DTA();
        Cls_ChiTietDichVu_PTA CTDichVu_PTA = new Cls_ChiTietDichVu_PTA();


        DataTable TblLoaiDV, TblDV;
        int iTrangThaiPhong = -1;
        SqlDataAdapter da;
        SqlCommandBuilder cmdb;
        string sMaPHID = "", sMaDVID = "";

        public Frm_QuanLyDichVu()
        {
            InitializeComponent();
        }

        private void Frm_QuanLyDichVu_Load(object sender, EventArgs e)
        {
            rad_TatCa.Checked = rad_PhongTrong.Checked = rad_PhongDaDat.Checked = rad_PhongCoKhach.Checked = false;
            ShowTreeView();
            txt_DonGia.ReadOnly = true;
            txt_DonGia.BackColor = Color.DarkSeaGreen;
            Time_DongHo.Start();
            grp_Menu.Enabled = false;
            
            
        }

        public string ShowPhongHatTheoDK()
        {
            string sDk = "";
            if (rad_PhongTrong.Checked != false)
                sDk = " PhongHat.TrangThai=0";
            else if (rad_PhongCoKhach.Checked != false)
                sDk = " PhongHat.TrangThai = 1";
            else if (rad_PhongDaDat.Checked != false)
                sDk = " PhongHat.TrangThai = 2";
            else sDk = "";
            return sDk;
        }

        public void ShowListViewPhong()
        {
            ListViewItem lsv_Item;
            lst_Phong.Items.Clear();
            DataSet DS_Phong = PHat_PTA.GetTable(ref da, cmdb, ShowPhongHatTheoDK());
            for(int i=0;i<DS_Phong.Tables[0].Rows.Count;i++)
            {
                sMaPHID = DS_Phong.Tables[0].Rows[i]["MaPH"].ToString();

                lsv_Item = lst_Phong.Items.Add(DS_Phong.Tables[0].Rows[i]["TenPH"].ToString());              
                lsv_Item.Name=DS_Phong.Tables[0].Rows[i]["MaPH"].ToString();
                if (DS_Phong.Tables[0].Rows[i]["TrangThai"].ToString() == "0")
                    lsv_Item.ImageIndex = 0;
                else if (DS_Phong.Tables[0].Rows[i]["TrangThai"].ToString() == "1")
                    lsv_Item.ImageIndex = 1;
                else if (DS_Phong.Tables[0].Rows[i]["TrangThai"].ToString() == "2")
                    lsv_Item.ImageIndex = 2;
                else
                    lsv_Item.ImageIndex = -1;
            }
        }

        private void rad_TatCa_CheckedChanged(object sender, EventArgs e)
        {
            iTrangThaiPhong = -1;
            ShowListViewPhong();
            
        }

        private void rad_PhongTrong_CheckedChanged(object sender, EventArgs e)
        {
            iTrangThaiPhong = 0;
            ShowListViewPhong();
            grp_Menu.Enabled = false;

        }

        private void rad_PhongCoKhach_CheckedChanged(object sender, EventArgs e)
        {
            iTrangThaiPhong = 1;
            ShowListViewPhong();
            grp_Menu.Enabled = true;
        }

        private void rad_PhongDaDat_CheckedChanged(object sender, EventArgs e)
        {
            iTrangThaiPhong = 2;
            ShowListViewPhong();
            grp_Menu.Enabled = false;
        }

        public void ShowTreeView()
        {
            trv_DichVu.Nodes.Clear();
            TreeNode Trv_LoaiDV, Trv_DV;
            TblLoaiDV = LoaiDV_PTA.GetTable("");
            TblDV = DV_PTA.GetTable("");
            foreach (DataRow dr_LoaiDV in TblLoaiDV.Rows)
            {
                Trv_LoaiDV = new TreeNode();
                Trv_LoaiDV.Text = dr_LoaiDV["TenLoaiDV"].ToString();
                Trv_LoaiDV.Tag = dr_LoaiDV["MaLoaiDV"].ToString();
                foreach (DataRow dr_DV in TblDV.Rows)
                {
                    
                    if(dr_DV["MaLoaiDV"].ToString().ToUpper()==dr_LoaiDV["MaLoaiDV"].ToString().ToUpper())
                    {
                        Trv_DV = new TreeNode();
                        Trv_DV.ForeColor = Color.Red;
                        Trv_DV.Text = dr_DV["TenDV"].ToString();
                        Trv_DV.Tag = dr_DV["MaDV"].ToString();
                        Trv_LoaiDV.Nodes.Add(Trv_DV);
                        txt_DonGia.Text = int.Parse(dr_DV["DonGia"].ToString()).ToString("#,##0 VND");
                    }
                    
                }
                trv_DichVu.Nodes.Add(Trv_LoaiDV);
            }
            trv_DichVu.ExpandAll();

        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void trv_DichVu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (trv_DichVu.SelectedNode != null)
            {
                sMaDVID = trv_DichVu.SelectedNode.Tag.ToString();
                trv_DichVu.SelectedNode.BackColor = Color.Pink;
            }
           
        }

        private void trv_DichVu_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (trv_DichVu.SelectedNode != null)
            {
                trv_DichVu.SelectedNode.BackColor = Color.RosyBrown;
            }
        }
       

        private void Frm_QuanLyDichVu_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Time_DongHo.Stop();
            this.Close();

        }

        private void Time_DongHo_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = "Thời gian :" + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            lbl_Time.BackColor = Color.Teal;
        }

        private void btn_NhanPhong_Click(object sender, EventArgs e)
        {

        }

        private void btn_GoiDV_Click(object sender, EventArgs e)
        {
            if(txt_SoLuong.Text.Trim()=="")
            {
                txt_SoLuong.Focus();
                txt_SoLuong.Select();
            }
            else if(sMaPHID==""||sMaDVID=="")
            {
                MessageBox.Show("Xin Vui Long Chon Thuc An Can Goi", "Thong Bao");
                return;               
            }
            else
            {
                CTDichVu_DATA.MaDV = sMaDVID;
                CTDichVu_DATA.MaPH = lst_Phong.SelectedItems[0].Name;
                CTDichVu_DATA.DonGia = float.Parse(CatKhoangTrang(txt_DonGia.Text));
                CTDichVu_DATA.SoLuong = int.Parse(txt_SoLuong.Text);
                CTDichVu_PTA.Inser_Update_Delete(CTDichVu_DATA, "Insert");
                MessageBox.Show("Goi Thanh Cong");
            }
        }

        public string CatKhoangTrang(string schuoi)
        {
            string[] sMang = schuoi.Split(' ');
            return sMang[0];
        }

      

        private void btn_TinhTien_Click(object sender, EventArgs e)
        {
            //string sIDMaPH=lst_Phong.SelectedItems[0].Name;
            //Frm_ThanhToan FrmThanhToan = new Frm_ThanhToan(sIDMaPH);
            //FrmThanhToan.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       

            

       
       
    }
}
