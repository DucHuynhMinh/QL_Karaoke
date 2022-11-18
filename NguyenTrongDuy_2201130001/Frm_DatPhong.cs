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
using System.Data.SqlClient;

namespace PhucHien_MinhDuc
{
    public partial class Frm_DatPhong : Form
    {
        Cls_PhongHat_DTA PH_Data = new Cls_PhongHat_DTA();
        Cls_PhongHat_PTA PH_Pta = new Cls_PhongHat_PTA();

        Cls_KhachHang_DTA KH_Data = new Cls_KhachHang_DTA();
        Cls_KhachHang_PTA KH_Pta = new Cls_KhachHang_PTA();

        Cls_LoaiKhachHang_PTA LoaiKH_PTA = new Cls_LoaiKhachHang_PTA();

        Cls_PhieuDat_DTA PD_Data = new Cls_PhieuDat_DTA();
        Cls_PhieuDat_PTA PD_Pta = new Cls_PhieuDat_PTA();

        Cls_LoaiPhong_DTA LP_Data = new Cls_LoaiPhong_DTA();
        Cls_LoaiPhong_PTA LP_Pta = new Cls_LoaiPhong_PTA();

        DataTable TblLoaiPhong;
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlCommandBuilder cmdb;
        string sDKTrangThai = "", sNgayVao = "", sGioHT, sMaPH = "", sSoPDID = "", sMaKHID = "", sgioDatPD = "";
        string swhere = "";
        int ivitritrv = -1;
        bool DKDat = false;
        DataSet DsPhong;
        public Frm_DatPhong()
        {
            InitializeComponent();
        }

        private void Frm_DatPhong_Load(object sender, EventArgs e)
        {
            txt_TienDatCoc.Enabled = false;

            TblLoaiPhong = LP_Pta.GetDatata("");    
            
            //ShowTreeView(TblLoaiPhong, TblPhong, trv_DanhSachPhong);
            ShowDataAllTable();
            ShowDataPhieuDP();

            btn_LuuPD.Enabled = false;

            sDKTT(false);
            
        }

        public void sDKTT(bool mo)
        {
            dpk_ngaydat.Enabled = mo ;
            grp_Online.Enabled = mo;
            grp_DanhSach.Enabled = mo;
            grp_ThongTinKH.Enabled = mo;
        }

        public void ShowDataAllTable()
        {
            //HienThi Phòng

            MaPHPD.DataSource = PH_Pta.GetTablePH("");
            MaPHPD.ValueMember = "MaPH";
            MaPHPD.DisplayMember = "TenPH";

            //HienThiTenKH
            DataTable tbl= new DataTable();
            tbl= KH_Pta.GetTable("");
            MaKH.DataSource = tbl;
            MaKH.ValueMember = "MaKH";
            MaKH.DisplayMember = "TenKH";
       
            
            //Loại Khách Hàng

            cbo_LoaiKH.DataSource = LoaiKH_PTA.GetTable("");
            cbo_LoaiKH.ValueMember = "MaLoaiKH";
            cbo_LoaiKH.DisplayMember = "TenLoaiKH";

            //Add các buổi vào combobox
            cbo_Buoidat.Items.Clear();
            string[] Buoi = {"Buổi Sáng","Buổi Trưa","Buổi Tối" };
            cbo_Buoidat.Items.AddRange(Buoi);
            
        }

        public void ShowDataPhieuDP()
        {
            dgv_PhieuDatPhong.DataSource = PD_Pta.GetTablePhieuDP("");
        }

        public void ShowTreeView(DataTable TblLoaiPhong,DataTable TblPhong,TreeView TV_DanhSach)
        {
            TreeNode TN_LoaiPhong, TN_Phong;
            trv_DanhSachPhong.Nodes.Clear();
            foreach (DataRow Dong_LP in TblLoaiPhong.Rows)
            {
                TN_LoaiPhong = new TreeNode();
                TN_LoaiPhong.Text = Dong_LP["TenPhong"].ToString();
                TN_LoaiPhong.Tag = Dong_LP["MaLoai"].ToString();
                foreach (DataRow Dong_P in TblPhong.Rows)
                {
                    if (Dong_P["MaLoai"].ToString().ToUpper() == Dong_LP["MaLoai"].ToString().ToUpper())
                    {
                        TN_Phong = new TreeNode();
                        TN_Phong.ForeColor = Color.Red;
                        TN_Phong.Text = Dong_P["TenPH"].ToString();
                        TN_Phong.Tag = Dong_P["MaPH"].ToString();
                        TN_LoaiPhong.Nodes.Add(TN_Phong);
                    }
                }
                //if (sDKTrangThai == "")
                //{
                //    foreach (DataRow Dong_P in TblPhong.Rows)
                //    {
                //        if (Dong_P["MaLoai"].ToString().ToUpper() == Dong_LP["MaLoai"].ToString().ToUpper())
                //        {
                //            TN_Phong = new TreeNode();
                //            TN_Phong.ForeColor = Color.Red;
                //            TN_Phong.Text = Dong_P["TenPH"].ToString();
                //            TN_Phong.Tag = Dong_P["MaPH"].ToString();
                //            TN_LoaiPhong.Nodes.Add(TN_Phong);
                //        }
                //    }
                //}else
                //{
                    
                //    foreach (DataRow Dong_P in ds.Tables[0].Rows)
                //    {
                //        if (Dong_P["MaLoai"].ToString().ToUpper() == Dong_LP["MaLoai"].ToString().ToUpper())
                //        {
                //            TN_Phong = new TreeNode();
                //            TN_Phong.ForeColor = Color.Red;
                //            TN_Phong.Text = Dong_P["TenPH"].ToString();
                //            TN_Phong.Tag = Dong_P["MaPH"].ToString();
                //            TN_LoaiPhong.Nodes.Add(TN_Phong);
                //        }
                //    }
                //}

                trv_DanhSachPhong.Nodes.Add(TN_LoaiPhong);
            }
            trv_DanhSachPhong.ExpandAll();
        }



        public void DK(bool mo )
        {
            grp_Online.Enabled = mo;
            grp_DanhSach.Enabled = !mo;
        }


       

       
       public void XoaKhoangTrang()
       {
           txt_giodat.Text = "";
           txt_TenKH.Text = "";
           cbo_Buoidat.SelectedIndex = -1;
           rad_nam.Checked = rad_nu.Checked=ckb_TienDacCoc.Checked = false;
           txt_dienthoai.Text = "";
           txt_diachi.Text = "";
           txt_TienDatCoc.Text = "0";
       }
       
        private void btn_datphong_Click(object sender, EventArgs e)
        {
            if (btn_datphong.Text == "&Đặt Phòng")
            {
                XoaKhoangTrang();
                dgv_PhieuDatPhong.Enabled = false;
                
                btn_LuuPD.Enabled = true;
                btn_huyphong.Enabled = false;
                btn_datphong.Text = "&Hủy";
                sDKTT(true);
            }else
            {
                dgv_PhieuDatPhong.Enabled = true;
                btn_LuuPD.Enabled = false;
                btn_huyphong.Enabled = true;
                btn_datphong.Text = "&Đặt Phòng";
                sDKTT(false);
            }
        }

        private void txt_TienDatCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txt_dienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void trv_DanhSachPhong_AfterSelect(object sender, TreeViewEventArgs e)
        {            
            if (trv_DanhSachPhong.SelectedNode.Parent != null)
            {
                sMaPH = trv_DanhSachPhong.SelectedNode.Tag.ToString();
                ivitritrv = trv_DanhSachPhong.SelectedNode.Index;
                trv_DanhSachPhong.SelectedNode.ForeColor = Color.RosyBrown;
               
            }
        
        }

        private void ckb_TienDacCoc_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_TienDacCoc.Checked != false)
                txt_TienDatCoc.Enabled = true;
            else
                txt_TienDatCoc.Enabled = false;
        }

        public bool GioiTinh()
        {
            bool bPhai = false;
            if (rad_nam.Checked != false)
                bPhai = true;
            return bPhai;
        }

        private void btn_LuuPD_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_TenKH.Text.Trim() == "")
                {
                    txt_TenKH.Focus();
                    txt_TenKH.Select();
                }               
                else if (sMaPH == "")
                {
                    MessageBox.Show("Xin Vui Lòng Chọn Phòng Đặt", "Thông Báo");
                    trv_DanhSachPhong.Focus();
                    trv_DanhSachPhong.Select();
                }                
                else
                {
                    sMaKHID = KH_Pta.TaoMa("KH", 5);
                    sSoPDID = PD_Pta.TaoMa("PD", 5);
                    KH_Data.MaKH = sMaKHID;
                    PD_Data.SoPD = sSoPDID;
                    GanData();
                    KH_Pta.Insert_Update_Delete(KH_Data, "Insert");
                    PD_Pta.Insert_Update_Delete(PD_Data, "Insert");
                    dgv_PhieuDatPhong.Enabled = true;

                    //Cập Nhật Trạng Thái phòng;
                    //string[] smanggio = txt_giodat.Text.Split(' ');
                    
                    //if(DKDat!=true)
                    //{
                    //    if (sNgayVao != "")
                    //    {
                    //        PH_Data.TrangThai = 2;
                    //        if (smanggio.Length == 2)
                    //            Update_TrangThaiPhong(sMaPH, sNgayVao, smanggio[0].ToString(), smanggio[1].ToString());
                    //        else
                    //            Update_TrangThaiPhong(sMaPH, sNgayVao, smanggio[0].ToString(), "");
                    //        PH_Pta.Insert_Update_Delete(PH_Data, "Update");
                    //    }
                    //    else
                    //        dpk_ngaydat.Focus();
                    //}
                    //else
                    //{
                    //    PH_Data.TrangThai = 2;
                    //    if (smanggio.Length == 2)
                    //        Update_TrangThaiPhong(sMaPH, sNgayVao, smanggio[0].ToString(), smanggio[1].ToString());
                    //    else
                    //        Update_TrangThaiPhong(sMaPH, sNgayVao, smanggio[0].ToString(), "");
                    //    PH_Pta.Insert_Update_Delete(PH_Data, "Update");
                    //}
                    PH_Data.TrangThai = 2;
                    Update_TrangThaiPhong(sMaPH, "0", "", "");
                    PH_Pta.Insert_Update_Delete(PH_Data, "Update");
                    ShowDataAllTable();
                    ShowDataPhieuDP();
                }
            }
            catch (Exception)
            {

               ShowDataPhieuDP();
            }
            GetTablPhongDK(swhere);
            ShowTreeView(TblLoaiPhong,DsPhong.Tables[0],trv_DanhSachPhong);
            btn_datphong.Enabled = true;
            btn_huyphong.Enabled = true;
            btn_LuuPD.Enabled = true;
            btn_datphong.Text = "&Đặt Phòng";
           
           
            
        }

        public void Update_TrangThaiPhong(string sMaID,string sdkNgay,string sgioht,string sgiosau)
        {
            DataTable TblUpdatTrang = PH_Pta.GetTablePH(" where MaPH='" + sMaID + "'");
            if (TblUpdatTrang.Rows.Count != 0)
            {
                PH_Data.MaPH = sMaID;
                PH_Data.TenPH = TblUpdatTrang.Rows[0]["TenPH"].ToString();
                PH_Data.MaLoai = TblUpdatTrang.Rows[0]["MaLoai"].ToString();
                PH_Data.NgayVao = sdkNgay;
                PH_Data.GioHT = sgioht;
                PH_Data.GioSau = sgiosau;                
            }
            
        }

      

        public void GanData()
        {
            //Insert Khách Hàng;
            KH_Data.TenKH = txt_TenKH.Text;
            KH_Data.TheCard = "";
            KH_Data.NgaySinh = dpk_Ngaysinh.Value;
            KH_Data.Phai = GioiTinh();
            KH_Data.DienThoai = txt_dienthoai.Text;
            KH_Data.DiaChi = txt_diachi.Text;
            KH_Data.Email = "";
            KH_Data.HinhThucDK = "";
            KH_Data.MaLoaiKH = cbo_LoaiKH.SelectedValue.ToString();

            //Insert PhieuDatPhong
            PD_Data.NgayDat = dpk_ngaydat.Value;
            PD_Data.GioDat = txt_giodat.Text;
            if (cbo_Buoidat.SelectedIndex != -1)
                PD_Data.BuoiDat = cbo_Buoidat.SelectedItem.ToString();
            PD_Data.BuoiDat = "";
            PD_Data.TienDatCoc = int.Parse(txt_TienDatCoc.Text) != 0 ? int.Parse(txt_TienDatCoc.Text) : 0;
            PD_Data.MaPH = sMaPH;
            PD_Data.MaKH = sMaKHID;
        }

        private void txt_TienDatCoc_Click(object sender, EventArgs e)
        {
            txt_TienDatCoc.Text = "";
        }

      

        public void checkGioiTinh(string sCheck)
        {
            if (sCheck == "True")
                rad_nam.Checked = true;
            else
                rad_nu.Checked = true;
        }

        private void btn_huyphong_Click(object sender, EventArgs e)
        {

            if (dgv_PhieuDatPhong.Rows.Count > 0)
            {
                if (dgv_PhieuDatPhong.CurrentRow.Index == -1)
                {
                    MessageBox.Show("Xin Vui Lòng Chọn Phiếu Đặt Cần Hủy", "Thông Báo");
                    return;
                }
                else
                {
                    DialogResult kq = MessageBox.Show("Bạn có muốn huy phiếu đăt của khách hàng " + txt_TenKH.Text, "Thông Báo", MessageBoxButtons.YesNo);
                    if (kq == DialogResult.Yes)
                    {
                       
                        PD_Data.SoPD = dgv_PhieuDatPhong.CurrentRow.Cells[0].Value.ToString();
                        KH_Data.MaKH = dgv_PhieuDatPhong.CurrentRow.Cells[6].Value.ToString();
                        sMaPH = dgv_PhieuDatPhong.CurrentRow.Cells[5].Value.ToString();
                        GanData();

                        PD_Pta.Insert_Update_Delete(PD_Data, "Delete");
                        KH_Pta.Insert_Update_Delete(KH_Data, "Delete");
                       
                        PH_Data.TrangThai = 0;
                        Update_TrangThaiPhong(sMaPH, "0", "","");
                        PH_Pta.Insert_Update_Delete(PH_Data, "Update");

                        XoaKhoangTrang();
                    }

                }
            }
            else if (dgv_PhieuDatPhong.Rows.Count == 0)
                XoaKhoangTrang();
            ShowDataPhieuDP();            
            rad_PhongTrong_CheckedChanged(sender, e);

        }

        private void dgv_PhieuDatPhong_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            DataTable tbl = new DataTable();
            if (e.RowIndex != -1)
            {
                dpk_ngaydat.Value = Convert.ToDateTime(dgv_PhieuDatPhong.CurrentRow.Cells[1].Value);
                txt_giodat.Text = sgioDatPD = dgv_PhieuDatPhong.CurrentRow.Cells[2].Value.ToString().Trim();
                cbo_Buoidat.SelectedItem = dgv_PhieuDatPhong.CurrentRow.Cells[3].Value.ToString();
                txt_TienDatCoc.Text = dgv_PhieuDatPhong.CurrentRow.Cells[4].Value.ToString();
                if (int.Parse(txt_TienDatCoc.Text)!=0)
                {
                    txt_TienDatCoc.Enabled = false;
                }

                //Hiển Thị Thông Tin Khách hàng
                sMaKHID = dgv_PhieuDatPhong.CurrentRow.Cells[6].Value.ToString();
                tbl = KH_Pta.GetTable(" where MaKH='" + sMaKHID + "'");
                txt_TenKH.Text = tbl.Rows[0]["TenKH"].ToString();
                dpk_Ngaysinh.Value = Convert.ToDateTime(tbl.Rows[0]["NgaySinh"]);
                checkGioiTinh(tbl.Rows[0]["Phai"].ToString());
                txt_dienthoai.Text = tbl.Rows[0]["DienThoai"].ToString();
                cbo_LoaiKH.SelectedValue = tbl.Rows[0]["MaLoaiKH"].ToString();
                txt_diachi.Text = tbl.Rows[0]["DiaChi"].ToString();
                sMaPH = dgv_PhieuDatPhong.CurrentRow.Cells[5].Value.ToString();

            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rad_PhongTrong_CheckedChanged(object sender, EventArgs e)
        {
            //sDKTrangThai = " TrangThai=0";
            //ds = PH_Pta.GetTable(ref da, cmdb, sDKTrangThai);            
            //ShowTreeView(TblLoaiPhong, ds.Tables[0], trv_DanhSachPhong);
        }

        private void dpk_ngaydat_ValueChanged(object sender, EventArgs e)
        {
            DsPhong = new DataSet();
            sNgayVao = dpk_ngaydat.Value.ToShortDateString();
            //swhere = //" NgayVao<>'" + sNgayVao + "'and TrangThai=0";
            swhere = sTachGio("NgayDat", sNgayVao);
            GetTablPhongDK(swhere);
            ShowTreeView(TblLoaiPhong, DsPhong.Tables[0], trv_DanhSachPhong);
           
        }

        public void GetTablPhongDK(string sDK)
        {
            DsPhong = PH_Pta.GetTable(ref da, cmdb, swhere);
        }

        private void txt_giodat_TextChanged(object sender, EventArgs e)
        {
            DsPhong = new DataSet();
            sGioHT = txt_giodat.Text;
            swhere = sTachGio("GioDat", txt_giodat.Text);
            GetTablPhongDK(swhere);
            ShowTreeView(TblLoaiPhong, DsPhong.Tables[0], trv_DanhSachPhong);
            DKDat = true;
           
            
        }

        public string sTachGio(string sColumn_Name, string schuoigio)
        {
            
            string schuoidk = "";
            string[] smangngay;
            DataTable TblPDTemp = PD_Pta.GetTablePhieuDP("");
            if (TblPDTemp.Rows.Count != 0)
            {
                for (int i = 0; i < TblPDTemp.Rows.Count; i++)
                {
                    smangngay = TblPDTemp.Rows[i][sColumn_Name].ToString().Split(' ');
                    if (smangngay[0].ToString() == schuoigio)
                    {
                        schuoidk = " (NOT EXISTS (SELECT MaPH FROM   PhieuDatPhong   WHERE (MaPH = PhongHat.MaPH)))";
                    }
                    else
                    {
                        if (schuoigio != "")
                        {
                            if (int.Parse(TblPDTemp.Rows[i]["GioDat"].ToString()) + 2 == int.Parse(schuoigio))
                                schuoidk = " TrangThai<>1 OR (EXISTS (SELECT MaPH FROM   PhieuDatPhong   WHERE (MaPH = PhongHat.MaPH)))";
                        }
                    }
                }
            }
            else
            {
                schuoidk = " TrangThai<>1";               
            }
            return schuoidk;        

        }

       
        private void trv_DanhSachPhong_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (ivitritrv != -1)
            {
                if (trv_DanhSachPhong.SelectedNode != null)
                {
                    trv_DanhSachPhong.SelectedNode.ForeColor = Color.Red;
                    ivitritrv = -1;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DsPhong = new DataSet();
            //sGioHT = txt_giodat.Text;
            //swhere = sTachGio("GioDat", txt_giodat.Text);
            //GetTablPhongDK(swhere);
            //ShowTreeView(TblLoaiPhong, DsPhong.Tables[0], trv_DanhSachPhong);
            //DKDat = true;
            
            
        }

        private void txt_giodat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

            

        
       
    }
}
