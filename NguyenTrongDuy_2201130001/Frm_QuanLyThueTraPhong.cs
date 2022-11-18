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
    public partial class Frm_QuanLyThueTraPhong : Form
    {
        Cls_PhongHat_DTA PH_DATA = new Cls_PhongHat_DTA();
        Cls_PhongHat_PTA PH_PTA = new Cls_PhongHat_PTA();

        Cls_LoaiPhong_DTA LPhong_DATA = new Cls_LoaiPhong_DTA();
        Cls_LoaiPhong_PTA LPhong_PTA = new Cls_LoaiPhong_PTA();

        Cls_LoaiDichVu_DTA LoaiDV_DATA = new Cls_LoaiDichVu_DTA();
        Cls_LoaiDichVu_PTA LoaiDV_PTA = new Cls_LoaiDichVu_PTA();

        Cls_DichVu_DTA DV_DATA = new Cls_DichVu_DTA();
        Cls_DichVu_PTA DV_PTA = new Cls_DichVu_PTA();

        Cls_ChiTietDichVu_DTA CTDichVu_DATA = new Cls_ChiTietDichVu_DTA();
        Cls_ChiTietDichVu_PTA CTDichVu_PTA = new Cls_ChiTietDichVu_PTA();

        Cls_NhanPhong_DTA NPhong_DATA = new Cls_NhanPhong_DTA();
        Cls_NhanPhong_PTA NPhong_PTA = new Cls_NhanPhong_PTA();

        Cls_HoaDon_DTA HDon_DATA = new Cls_HoaDon_DTA();
        Cls_HoaDon_PTA HDon_PTA = new Cls_HoaDon_PTA();

        Cls_PhieuDat_DTA PDPhong_DATA = new Cls_PhieuDat_DTA();
        Cls_PhieuDat_PTA PDPhong_PTA = new Cls_PhieuDat_PTA();

        Cls_KhachHang_DTA KH_DATA = new Cls_KhachHang_DTA();
        Cls_KhachHang_PTA KH_PTA = new Cls_KhachHang_PTA();

        Cls_PhieuDat_DTA PD_DATA = new Cls_PhieuDat_DTA();
        Cls_PhieuDat_PTA PD_PTA = new Cls_PhieuDat_PTA();
        

        SqlDataAdapter da;
        SqlCommandBuilder cmdb;
        string sMaPHID = "", sDk = "", sGioDat = "";

        ListViewItem lsv_Item;
        ListViewItem lsv_ItemLoaiDV = new ListViewItem();
        
        DataTable TblCTDV = new DataTable();
        DataTable TblPhong;
       
        DataTable TblPDatPhong = new DataTable();
        DataTable TblKhachHangPD;
        DataTable TblNPhong;
        DataTable TblDV;

        DataTable TblTemp;

        string sMaDK = "", sMaDVTH = "";
        double ThanhTien = 0, TongTienDV = 0;
        string sGioVao, sGioRa, sTempVao = "", sTempRa = "", sMaPH_Dat = "", sMaPH_Trong = "";
        float fGioCD, fGioBT;
        string sGiaGio = "";
        int iTrong = -1, iDat = -1, iNhan = -1, iupdate = -1, iInsert = 0, iUpdateSoLuong = 0, iNdex = -1;
        string sSoPDDelete = "", sMaPNDelete = "";
       
        private string _MaPH;

        public string MaPH
        {
            get { return _MaPH; }
            set { _MaPH = value; }
        }

        private string _NgayVao;

        public string NgayVao
        {
            get { return _NgayVao; }
            set { _NgayVao = value; }
        }
        private string _GioVao;

        public string GioVao
        {
            get { return _GioVao; }
            set { _GioVao = value; }
        }
        private string _GioRa;

        public string GioRa
        {
            get { return _GioRa; }
            set { _GioRa = value; }
        }
        private string _SoTiengGio;

        public string SoTiengGio
        {
            get { return _SoTiengGio; }
            set { _SoTiengGio = value; }
        }
       
        private string _TongTienPhong;

        public string TongTienPhong
        {
            get { return _TongTienPhong; }
            set { _TongTienPhong = value; }
        }

        private string _TienGio;

        public string TienGio
        {
            get { return _TienGio; }
            set { _TienGio = value; }
        }

        private string _NameKH;

        public string NameKH
        {
            get { return _NameKH; }
            set { _NameKH = value; }
        }

        private string _NameLP;

        public string NameLP
        {
            get { return _NameLP; }
            set { _NameLP = value; }
        }

        private string _NamePhong;

        public string NamePhong
        {
            get { return _NamePhong; }
            set { _NamePhong = value; }
        }

        private string _TienDV;

        public string TienDV
        {
            get { return _TienDV; }
            set { _TienDV = value; }
        }

        private bool _Delete;

        public bool Delete
        {
            get { return _Delete; }
            set { _Delete = value; }
        }

        public Frm_QuanLyThueTraPhong()
        {
            InitializeComponent();
            
        }

        private void Frm_QuanLyThueTraPhong_Load(object sender, EventArgs e)
        {
            TblDV = new DataTable();
            TblDV = LoaiDV_PTA.GetTable("");
            ShowListViewLoaiDV();
            ShowlistviewCTDV(sMaPHID);
            DieuKien(false);

            lst_CTHoaDon.ContextMenuStrip = Menu_CTHoaDon;
            grp_Update.Enabled = false;
                   
        }

        public void DieuKien(bool mo)
        {
            btn_NPhong.Enabled = mo;
            btn_TraPhong.Enabled = mo;
            btn_chuyenphong.Enabled = mo;
            btn_GoiDV.Enabled = mo;
            btn_ThanhToan.Enabled = mo;
            cbo_LoaiDV.Enabled = mo;
            cbo_LoaiDV.SelectedIndex = -1;
            lst_NhanPhong.Enabled = mo;
            //lst_CTHoaDon.Enabled = mo;
        }

        public void GetTableNhanPhong(string sMaPHNP)
        {
            TblNPhong = new DataTable();
            TblNPhong = NPhong_PTA.GetTable(" where MaPH='" + sMaPHNP + "'");    
        }

        public string ShowPhongHatTheoDK()
        {
            
            if (rad_PhongTrong.Checked != false)
                sDk = " TrangThai=0";
            else if (rad_PhongCoKhach.Checked != false)
                sDk = " TrangThai = 1";
            else if (rad_PhongDaDat.Checked != false)
                sDk = " TrangThai = 2";
            else sDk = "";
            return sDk;
        }

        public void ShowListViewPhong(string sdk)
        {            
            lst_Phong.Items.Clear();
            DataSet DS_Phong = PH_PTA.GetTable(ref da, cmdb, sdk);
            for (int i = 0; i < DS_Phong.Tables[0].Rows.Count; i++)
            {
                lsv_Item = lst_Phong.Items.Add(DS_Phong.Tables[0].Rows[i]["TenPH"].ToString());
                lsv_Item.Name = DS_Phong.Tables[0].Rows[i]["MaPH"].ToString();
                if (DS_Phong.Tables[0].Rows[i]["TrangThai"].ToString() == "0")
                    lsv_Item.ImageIndex = 0;
                else if(DS_Phong.Tables[0].Rows[i]["TrangThai"].ToString()=="1")
                    lsv_Item.ImageIndex = 1;
                else
                    lsv_Item.ImageIndex = 2;               
            }
        }

        public void ShowListViewLoaiDV()
        {
            cbo_LoaiDV.DataSource = TblDV;
            cbo_LoaiDV.DisplayMember = "TenLoaiDV";
            cbo_LoaiDV.ValueMember = "MaLoaiDV";
            cbo_LoaiDV.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void rad_PhongTrong_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_PhongTrong.Checked==true)
            {
                sDk = " TrangThai=0";
                ShowListViewPhong(sDk);                
                iTrong = 0;
                if (iNhan == -1)
                    btn_chuyenphong.Enabled = false;
                else
                    btn_chuyenphong.Enabled = true;
            }
        }

        private void rad_PhongCoKhach_CheckedChanged(object sender, EventArgs e)
        {
            if(rad_PhongCoKhach.Checked==true)
            {
                sDk = " TrangThai=1";
                ShowListViewPhong(sDk);                
                iDat = 1;
                if (lst_Phong.Items.Count != 0)
                {
                    btn_chuyenphong.Enabled = true;
                }
            }
        }

        private void rad_PhongDaDat_CheckedChanged(object sender, EventArgs e)
        {
            if(rad_PhongDaDat.Checked==true)
            {
                sDk = " TrangThai=2";
                ShowListViewPhong(sDk);               
            }
        }

        private void rad_Tatca_CheckedChanged(object sender, EventArgs e)
        {
            sDk = "";
            ShowListViewPhong(sDk);
        }
               

        public void ShowThongTinPhong(string sMaPH)
        {
            string sDk = " where MaPH='" + sMaPH + "'";
            DataTable TblPhong = new DataTable();
            DataTable TblLPhong = new DataTable();
            TblPhong = PH_PTA.GetTablePH(sDk);            
            lbl_TenPhong.Text = TblPhong.Rows[0]["TenPH"].ToString();
            TblLPhong = LPhong_PTA.GetDatata(" where MaLoai='" + TblPhong.Rows[0]["MaLoai"].ToString() + "'");
            lbl_LoaiPhong.Text = TblLPhong.Rows[0]["TenPhong"].ToString();
            fGioCD = float.Parse(TblLPhong.Rows[0]["GioCD"].ToString());
            fGioBT=float.Parse(TblLPhong.Rows[0]["GioBT"].ToString());
            lbl_GioCD.Text = fGioCD.ToString("#,##0 VND");
            lbl_GioBT.Text = fGioBT.ToString("#,##0 VND");
            
        }

        private void lst_Phong_Click(object sender, EventArgs e)
        {
            grp_Update.Enabled = false;
            sMaPHID = MaPH = lst_Phong.SelectedItems[0].Name.ToString();
            ShowThongTinPhong(sMaPHID);
            ShowThongTinNhanPhong(sMaPHID);
            ShowlistviewCTDV(sMaPHID);
            if(rad_PhongCoKhach.Checked==true)
            {
                sMaPH_Dat = lst_Phong.SelectedItems[0].Name.ToString();
                ShowThongTinNhanPhong(sMaPH_Dat);
                iNhan = 0;
                btn_ThanhToan.Enabled = true;
                btn_TraPhong.Enabled = true;
                btn_chuyenphong.Enabled = true;
                cbo_LoaiDV.Enabled = true;
                lst_NhanPhong.Enabled = false;
                btn_GoiDV.Enabled = true;
                lst_NhanPhong.Enabled = true;
                
            }
           if(rad_PhongTrong.Checked==true)
            {
                sMaPH_Trong = lst_Phong.SelectedItems[0].Name.ToString();
                btn_NPhong.Enabled = true;
                cbo_LoaiDV.Enabled = false;
                cbo_LoaiDV.SelectedIndex = -1;
                
            }
            if(rad_PhongDaDat.Checked==true)
            {
                ShowListViewPhieuDat(sMaPHID);               
                lsv_phongdat.Enabled = true;
                btn_NPhong.Enabled = true;
                btn_chuyenphong.Enabled = false;
                btn_ThanhToan.Enabled = false;
                btn_TraPhong.Enabled = false;
            }
            else
            {
                lsv_phongdat.Enabled = false;
                
                lsv_phongdat.Items.Clear();
            }
           
        }

        public void ShowListViewPhieuDat(string sMaPHPD)
        {
            lsv_phongdat.Items.Clear();
            TblKhachHangPD = new DataTable();            
            TblPDatPhong = PD_PTA.GetTablePhieuDP(" where MaPH='" + sMaPHPD + "'");
            string[] sNgayDat;
            for (int i = 0; i < TblPDatPhong.Rows.Count; i++)
            {
                ListViewItem lsvItem = new ListViewItem((i+1).ToString());
                lsvItem.Name = TblPDatPhong.Rows[i]["SoPD"].ToString();
                sNgayDat = TblPDatPhong.Rows[i]["NgayDat"].ToString().Split(' ');
                lsvItem.SubItems.Add(sNgayDat[0].ToString());
                lsvItem.SubItems.Add(TblPDatPhong.Rows[i]["GioDat"].ToString());
                TblKhachHangPD = KH_PTA.GetTable(" where MaKH='" + TblPDatPhong.Rows[0]["MaKH"].ToString() + "'");
                lsvItem.SubItems.Add(TblKhachHangPD.Rows[0]["TenKH"].ToString());
                lsv_phongdat.Items.Add(lsvItem);
            }
        }               

        public void Insert_Update_DeletePDPhong(string smaiPD)
        {
            TblPDatPhong = PDPhong_PTA.GetTablePhieuDP(" where MaPH='" + smaiPD + "'");
            if(TblPDatPhong.Rows.Count!=0)
            {
                PD_DATA.SoPD = TblPDatPhong.Rows[0]["SoPD"].ToString();
                PD_DATA.NgayDat = Convert.ToDateTime(TblPDatPhong.Rows[0]["NgayDat"]);
                PD_DATA.GioDat = TblPDatPhong.Rows[0]["GioDat"].ToString();
                PD_DATA.BuoiDat = TblPDatPhong.Rows[0]["BuoiDat"].ToString();
                PD_DATA.TienDatCoc = float.Parse(TblPDatPhong.Rows[0]["TienDatCoc"].ToString());
                PD_DATA.MaPH = smaiPD;
                PD_DATA.MaKH = TblPDatPhong.Rows[0]["MaKH"].ToString();
                PD_PTA.Insert_Update_Delete(PD_DATA, "Delete");
            }
        }

       
        public void ShowThongTinNhanPhong(string smaid)
        {
            GetTableNhanPhong(smaid);
            if(TblNPhong.Rows.Count!=0)
            {
                DataTable Temp = new DataTable();
                string[]sNgayNhan;
                lst_NhanPhong.Items.Clear();
                for (int i = 0; i < TblNPhong.Rows.Count; i++)
                {
                    ListViewItem lstnvitems = new ListViewItem((i + 1).ToString());
                    lstnvitems.Name = TblNPhong.Rows[i]["MaNP"].ToString();
                    Temp = PH_PTA.GetTablePH(" where MaPH ='" + TblNPhong.Rows[i]["MaPH"].ToString() + "'");
                    lstnvitems.SubItems.Add(Temp.Rows[0]["TenPH"].ToString());
                    sNgayNhan = TblNPhong.Rows[i]["NgayNhan"].ToString().Split(' ');
                    lstnvitems.SubItems.Add(sNgayNhan[0].ToString());
                    lstnvitems.SubItems.Add(TblNPhong.Rows[i]["GioNhan"].ToString());
                    lstnvitems.SubItems.Add(TblNPhong.Rows[i]["TenKH"].ToString());
                    lst_NhanPhong.Items.Add(lstnvitems);
                }
            }
        }


        public void ShowListViewDichVu(string sMaID)
        {
            string sDk = " where MaLoaiDV ='" + sMaID + "'";
            TblDV = new DataTable();
            TblDV = DV_PTA.GetTable(sDk);
            dgv_DichVu.DataSource = TblDV;
            dgv_DichVu.Columns[3].ReadOnly = true;
            dgv_DichVu.Columns[4].ReadOnly = true;
            dgv_DichVu.Columns[5].ReadOnly = true;

        }

       
        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

      

        private void dgv_DichVu_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_GoiDV_Click(object sender, EventArgs e)
        {
            if (sMaPHID.Trim() == "")
                MessageBox.Show("Xin Vui Long Chon Phong Can Goi");
            else
            {
                if (cbo_LoaiDV.SelectedIndex != -1)
                {
                    foreach (DataGridViewRow check in dgv_DichVu.Rows)
                    {
                        if ((bool)check.Cells["chon"].FormattedValue)
                        {
                            if (check.Cells["SoLuong"].Value != null)
                            {
                                sMaDK += "," + check.Cells["MaDV"].Value.ToString();
                                sMaDK += "," + check.Cells["SoLuong"].Value.ToString();
                            }
                            else
                            {
                                MessageBox.Show("Xin vui long ghi so luong cần gọi!");
                                dgv_DichVu.Focus();
                            }

                        }
                    }
                    sMaDVTH = sMaDK;
                    InsertTableCTDV(sMaDK);
                    ShowlistviewCTDV(sMaPHID);
                    sMaDK = "";
                }
                else
                    MessageBox.Show("Xin Vui Lòng Chọn Loại DV!");
            }
        }

        public void InsertTableCTDV(string sThongTin)
        {
           
            DataTable TblDV_ = new DataTable();
            int ibien = 0;
            
            string sMaDV = "";
            int iSoLuong = 0;
            float fDonGia = 0;
            string[] sMang = sThongTin.Split(',');
            if (sMang.Length > 0)
            {
                for (int i = 1; i < sMang.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        sMaDV = sMang[i].ToString();
                        TblDV_ = DV_PTA.GetTable(" where MaDV='" + sMaDV + "'");
                        fDonGia = float.Parse(TblDV_.Rows[0]["DonGia"].ToString());
                    }
                    else
                    {
                        ibien = 1;
                        iSoLuong = int.Parse(sMang[i].ToString());
                    }

                    CTDichVu_DATA.MaDV = sMaDV;
                    CTDichVu_DATA.MaPH = sMaPHID;
                    CTDichVu_DATA.DonGia = fDonGia;
                    TblCTDV = CTDichVu_PTA.GetTable(" where MaPH='" + sMaPHID + "' And MaDV='" + sMaDV + "'");
                    if (TblCTDV.Rows.Count != 0)
                    {
                        if (TblCTDV.Rows[0]["MaDV"].ToString() == sMaDV && TblCTDV.Rows[0]["MaPH"].ToString() == sMaPHID)
                        {
                            if (ibien != 0)
                            {
                                CTDichVu_DATA.SoLuong = iSoLuong + int.Parse(TblCTDV.Rows[0]["SoLuong"].ToString());
                                CTDichVu_PTA.Inser_Update_Delete(CTDichVu_DATA, "Update");
                                ibien = 0;
                            }
                        }
                        else
                        {
                            if (ibien != 0)
                            {
                                CTDichVu_DATA.SoLuong = iSoLuong;
                                CTDichVu_PTA.Inser_Update_Delete(CTDichVu_DATA, "Insert");
                                ibien = 0;
                            }
                        }
                    }
                    else
                    {
                        if (ibien != 0)
                        {
                            CTDichVu_DATA.SoLuong = iSoLuong;
                            CTDichVu_PTA.Inser_Update_Delete(CTDichVu_DATA, "Insert");
                            ibien = 0;
                        }
                    }
                }
            }
        }
     
        public void ShowlistviewCTDV(string smaid)
        {
            
            ListViewItem item;
            lst_CTHoaDon.Items.Clear();
            TblCTDV = CTDichVu_PTA.GetTableDVPhong(" where CTDichVu.MaPH='" + smaid + "'");
            for(int i=0;i<TblCTDV.Rows.Count;i++)
            {
                item = new ListViewItem((i+1).ToString());
                item.Name = TblCTDV.Rows[i]["MaDV"].ToString();
                item.SubItems.Add(TblCTDV.Rows[i]["TenDV"].ToString());
                item.SubItems.Add(TblCTDV.Rows[i]["DonGia"].ToString());
                item.SubItems.Add(TblCTDV.Rows[i]["SoLuong"].ToString());
                ThanhTien = float.Parse(TblCTDV.Rows[i]["DonGia"].ToString()) * int.Parse(TblCTDV.Rows[i]["SoLuong"].ToString());
                TongTienDV += ThanhTien;
                item.SubItems.Add(ThanhTien.ToString("#,##0 VND"));
                lst_CTHoaDon.Items.Add(item);
            }         
        }

       

        private void btn_TraPhong_Click(object sender, EventArgs e)
        {
            txt_SoLuon.Clear();
            double kqTongTien = 0;
            if (sMaPHID != ""||sMaPNDelete!="")
            {
                
                sGioRa = DateTime.Now.ToShortTimeString();
                sTempRa = DateTime.Now.ToString();
                lbl_Giora.Text = sGioRa;
                lbl_TGHat.Text = TinhGio(lbl_Giovao.Text, sGioRa);
                if (lbl_TienDatCoc.Text != "")
                    kqTongTien = double.Parse(TinhTienTheoGio(lbl_TGHat.Text)) + TongTienDV - float.Parse(lbl_TienDatCoc.Text);
                else
                    kqTongTien = double.Parse(TinhTienTheoGio(lbl_TGHat.Text)) + TongTienDV;
                TienGio = double.Parse(TinhTienTheoGio(lbl_TGHat.Text)).ToString();
                lbl_TongTien.Text = kqTongTien.ToString("#,##0 VND");
                PH_DATA.TrangThai = 0;
                PH_DATA.NgayVao = "0";
                PH_DATA.GioHT = "";
                PH_DATA.GioSau = "";
                lbl_ThanhTien.Text = TongTienDV.ToString("#,##0 VND");
                
                GetTableNP(sMaPNDelete);
                if (iupdate==1)
                {
                    PH_DATA.TrangThai = 0;                
                    iupdate = 0;
                    lst_NhanPhong.Items.Clear();
                   
                }
                else if (iupdate == 0 || iupdate == -1)
                {
                    PH_DATA.TrangThai = 1;
                    
                }
                ShowThongTinNhanPhong(sMaPHID);
                GanTablePhong(sMaPHID);
                ShowListViewPhong(sDk);

                lbl_GioBT.BackColor = Color.White;
                lbl_GioCD.BackColor = Color.White;

                MaPH = sMaPHID;
                NgayVao = lbl_ngay.Text;
                NamePhong = lbl_TenPhong.Text;
                GioVao = lbl_Giovao.Text;
                GioRa = lbl_Giora.Text;
                SoTiengGio = lbl_TGHat.Text;
                NameLP = lbl_LoaiPhong.Text;
                TongTienPhong = lbl_TongTien.Text;
                TienDV = lbl_ThanhTien.Text;
                NameKH = txt_KhachHang.Text;
                

            }
            else
            {
                MessageBox.Show("Xin Vui Long Chon Phong Hat!", "Thong Bao");
                lst_Phong.Focus();
            }            
            sMaPNDelete = "";
               
        }

     

        public void Inser_Delete_UpdateDatPhong(string smaid)
        {
            DataTable tblDPhong = new DataTable();
            TblTemp = new DataTable();
            tblDPhong = PD_PTA.GetTablePhieuDP(" where SoPD='" + smaid + "'");
            if (tblDPhong.Rows.Count != 0)
            {
                PD_DATA.SoPD = tblDPhong.Rows[0]["SoPD"].ToString();
                PD_DATA.NgayDat = Convert.ToDateTime(tblDPhong.Rows[0]["NgayDat"]);
                PD_DATA.GioDat = sGioDat = tblDPhong.Rows[0]["GioDat"].ToString();
                PD_DATA.BuoiDat = tblDPhong.Rows[0]["BuoiDat"].ToString();
                PD_DATA.TienDatCoc = int.Parse(tblDPhong.Rows[0]["TienDatCoc"].ToString());
                PD_DATA.MaPH = tblDPhong.Rows[0]["MaPH"].ToString();
                PD_DATA.MaKH = tblDPhong.Rows[0]["MaKH"].ToString();
                PD_PTA.Insert_Update_Delete(PD_DATA, "Delete");
                TblTemp = PD_PTA.GetTablePhieuDP(" where MaPH='" + tblDPhong.Rows[0]["MaPH"].ToString() + "'");
                if (TblTemp.Rows.Count == 0)
                {
                    iupdate = 1;
                    lsv_phongdat.Items.Clear();
                }
                
                   
            }           
        }
       
        public void Insert_Delete_CTDichVu(string smaid)
        {
            TblCTDV = CTDichVu_PTA.GetTable(" where MaPH='" + smaid + "'");
            if (TblCTDV.Rows.Count != 0)
            {
                CTDichVu_DATA.MaDV = TblCTDV.Rows[0]["MaDV"].ToString();
                CTDichVu_DATA.MaPH = smaid;
                CTDichVu_DATA.DonGia = float.Parse(TblCTDV.Rows[0]["DonGia"].ToString());
                CTDichVu_DATA.SoLuong = int.Parse(TblCTDV.Rows[0]["SoLuong"].ToString());
                CTDichVu_PTA.Inser_Update_Delete(CTDichVu_DATA, "Delete");
            }
        }

        public void GetTableNP(string smaid)
        {
            TblNPhong = new DataTable();
            
            TblNPhong = NPhong_PTA.GetTable(" where MaNP='" + smaid + "'");
            if (TblNPhong.Rows.Count != 0)
            {
                NPhong_DATA.MaNP = smaid;
                Inser_Update_tNhanPhong(TblNPhong.Rows[0]["MaPH"].ToString());
                NPhong_PTA.Insert_Update_Delete(NPhong_DATA, "Delete");
                GetTableNhanPhong(TblNPhong.Rows[0]["MaPH"].ToString());
                if (TblNPhong.Rows.Count==0) iupdate = 1;
                
            }
        }

        public string TinhTienTheoGio(string sDk)
        {
            double dTienGio = 0;
            try
            {
                
                int iTienGio, iTienPhut;
                if (sDk != "")
                {
                    string[] smangtien = sDk.Split(':');
                    iTienGio = int.Parse(smangtien[0].ToString());
                    iTienPhut = int.Parse(smangtien[1].ToString());
                    float fgiaphong = float.Parse(TinhGiaPhong(lbl_Giovao.Text));
                    if (iTienGio <= 3)
                    {
                        if (iTienGio != 0)
                        {
                            if (iTienPhut <= 45 && iTienPhut >= 20)
                                dTienGio = fgiaphong * iTienGio + fgiaphong * 0.5;
                            else if (iTienPhut <= 60 && iTienPhut >= 45)
                                dTienGio = fgiaphong * iTienGio + fgiaphong * 0.3;
                            else
                                dTienGio = fgiaphong * iTienGio;
                        }
                        else
                            dTienGio = fgiaphong;
                    }
                    else
                    {
                       if(iTienGio!=0)
                       {
                           if (iTienPhut <= 45 && iTienPhut >= 20)
                               dTienGio = fgiaphong * iTienGio + ((iTienGio - 3) * (fgiaphong / 100 * 70)) + fgiaphong * 0.5;
                           else if (iTienPhut <= 60 && iTienPhut >= 45)
                               dTienGio = fgiaphong * iTienGio + ((iTienGio - 3) * (fgiaphong / 100 * 70)) + fgiaphong * 0.3;
                           else
                               dTienGio = fgiaphong * iTienGio + ((iTienGio - 3) * (fgiaphong / 100 * 70));
                       }
                       else
                           dTienGio = fgiaphong ;
                    }
                }

            }
            catch (Exception)
            {

                
            }
            return dTienGio.ToString();
        }

        public string TinhGio(string sGvao,string sGRa)
        {
            int kqPhut = 0, kqGio = 0;
            int ikqchang, ikqle;
            int iBatDau, iKetThuc;
            string Result = "";
            string[] smangGVao1 = sGvao.Split(' ');
            string[] smangGRa1 =  sGRa.Split(' ');

            string[] smangGVao2 = smangGVao1[0].Split(':');
            string[] smangGRa2 = smangGRa1[0].Split(':');
            int iVao=0,iRa=0;
            iVao=int.Parse(smangGVao2[1].ToString());
            iRa=int.Parse(smangGRa2[1].ToString());
            iBatDau = int.Parse(smangGVao2[0].ToString());
            iKetThuc = int.Parse(smangGRa2[0].ToString());
            if(smangGVao1[1].ToString()==smangGRa1[1].ToString())
            {
                kqGio = iKetThuc - iBatDau;
                if (iRa < iVao)
                {
                    kqPhut = kqGio * 60 + iRa - iVao;
                    ikqchang = kqPhut / 60;
                    ikqle = kqPhut % 60;
                    if (ikqchang == 0)
                        if (ikqle.ToString().Length <= 1)
                            Result = "0:0" + ikqle.ToString();
                        else
                            Result = "0:" + ikqle.ToString();
                    else
                        if (ikqle.ToString().Length <= 1)
                            Result = ikqchang + ":0" + ikqle.ToString();
                        else
                            Result = ikqchang + ":" + ikqle.ToString();
                }
                else
                {
                    kqPhut = iRa - iVao;
                    if (kqGio == 0)
                        if (kqPhut.ToString().Length <= 1)
                            Result = "0:0" + kqPhut.ToString();
                        else
                            Result = "0:" + kqPhut.ToString();
                    else
                        if (kqPhut.ToString().Length <= 1)
                            Result = kqGio + ":0" + kqPhut.ToString();
                        else
                            Result = kqGio + ":" + kqPhut.ToString();
                }
            }
            else
            {
                TinhGioKhac(sTempVao, DateTime.Now.ToString());
            }

            return Result;
        }
        public string TinhGiaPhong(string sGvao)
        {
            string GiaPhong = "";
            string[] mangVao = sGvao.Split(':', ' ');
            if (int.Parse(mangVao[0].ToString()) > 7 && int.Parse(mangVao[0].ToString()) < 17)
            {
                GiaPhong = fGioBT.ToString();
            }
            else
                GiaPhong = fGioCD.ToString();
            return GiaPhong;
        }

        private void btn_NPhong_Click(object sender, EventArgs e)
        {
            iNhan = 0;
            float sGiaTam =0;
            float fGiaPD = 0;
            if (sMaPHID != "")
            {
                sGioVao = DateTime.Now.ToShortTimeString();
                sTempVao = DateTime.Now.ToString();
                lbl_Giovao.Text = sGioVao;
                if(rad_PhongTrong.Checked!=false)
                {
                    PH_DATA.TrangThai = 1;
                    string sNgay = DateTime.Now.ToShortDateString();
                    lbl_ngay.Text = string.Format("{0:dd/MM/yyyy}", sNgay);
                    sGiaGio = TinhGiaPhong(sGioVao);
                    sGiaTam = float.Parse(sGiaGio);//dung de nhan biet tinh tien theo gia;
                    if (lbl_GioCD.Text == sGiaTam.ToString("#,##0 VND"))
                        lbl_GioCD.BackColor = Color.ForestGreen;
                    else
                        lbl_GioBT.BackColor = Color.GreenYellow;                   
                }
                else if (rad_PhongDaDat.Checked != false)
                {
                    if(sSoPDDelete!="")
                    {
                        Inser_Delete_UpdateDatPhong(sSoPDDelete);
                        fGiaPD = int.Parse(TinhGiaPhong(sGioDat));
                        if (lbl_GioCD.Text == fGiaPD.ToString("#,##0 VND"))
                            lbl_GioCD.BackColor = Color.ForestGreen;
                        else
                            lbl_GioBT.BackColor = Color.GreenYellow;
                        Delete = true;
                        if (iupdate == 1)
                        {
                            PH_DATA.TrangThai = 1;                           
                            iupdate = 0;
                        }
                        else if (iupdate == 0 || iupdate == -1)
                            PH_DATA.TrangThai = 2;
                    }
                    else
                    {
                        MessageBox.Show("Xin vui Lòng Chọn Phiếu DP!", "Thông Báo");
                        lsv_phongdat.Focus();
                        return;
                    }
                   
                }                
                PH_DATA.NgayVao = NgayVao = lbl_ngay.Text;
                PH_DATA.GioHT = GioVao = lbl_Giovao.Text;
                PH_DATA.GioSau = "";               
                GanTablePhong(sMaPHID);
                ShowListViewPhong(sDk);
                string smanp = NPhong_PTA.TaoMa("NP", 5);
                NPhong_DATA.MaNP = smanp;
                Inser_Update_tNhanPhong(sMaPHID);
                NPhong_PTA.Insert_Update_Delete(NPhong_DATA, "Insert");
                ShowListViewPhieuDat(sMaPHID);

            }
            else
            {
                MessageBox.Show("Xin Vui Long Chon Phong Hat!", "Thong Bao");
                lst_Phong.Focus();
            }
            lbl_TongTien.Text = "";
            lbl_Giora.Text = "";
            lbl_TGHat.Text = "";
            btn_NPhong.Enabled = false;
        }

        public void Inser_Update_tNhanPhong( string smaid)
        {
            NPhong_DATA.TenKH = txt_KhachHang.Text;
            NPhong_DATA.NgayNhan = Convert.ToDateTime(lbl_ngay.Text);
            NPhong_DATA.GioNhan = lbl_Giovao.Text;
            NPhong_DATA.MaPH = smaid;
            NPhong_DATA.SoLuongNguoi = 0;
            NPhong_DATA.DiaChi = "";
            NPhong_DATA.Emai = "";
            NPhong_DATA.SoDienThoai = "";
            
        }

        public void GanTablePhong(string sMaid)
        {
            TblPhong = new DataTable();
            TblPhong = PH_PTA.GetTablePH(" where MaPH='" + sMaid + "'");
            PH_DATA.MaPH = sMaid;           
            PH_DATA.TenPH = TblPhong.Rows[0]["TenPH"].ToString();
            PH_DATA.TinhTrang = int.Parse(TblPhong.Rows[0]["TinhTrang"].ToString());
            PH_DATA.MaLoai = TblPhong.Rows[0]["MaLoai"].ToString();            
            PH_PTA.Insert_Update_Delete(PH_DATA, "Update");
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            Frm_ThanhToan FrmTToan = new Frm_ThanhToan();
            FrmTToan.MaPH = MaPH;
            FrmTToan.NgayVao = NgayVao;
            FrmTToan.GioVao = GioVao;
            FrmTToan.GioRa = GioRa;
            FrmTToan.SoTiengGio = SoTiengGio;
            FrmTToan.NameKH = NameKH;
            FrmTToan.NameLP = NameLP;
            FrmTToan.NamePhong = NamePhong;
            FrmTToan.TienGio = TienGio;
            FrmTToan.TongTienPhong = TongTienPhong;
            FrmTToan.TienDV = TienDV;
            FrmTToan.Delete = Delete;
            ShowlistviewCTDV("");
            //Insert_Delete_CTDichVu(sMaPHID);
            ////Inser_Delete_UpdateDatPhong(sMaPHID);

            //dung them vao hoa don
            string smadvid = "";
            if (sMaDVTH != "")
            {
                string[] sMang = sMaDVTH.Split(',');
                for (int i = 1; i < sMang.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        smadvid += sMang[i].ToString();
                        if (smadvid != "")
                            smadvid += ',';
                    }
                }
                
            }
            Insert_UpdateHoaDon(sMaPHID, "", true, smadvid, "");
            FrmTToan.ShowDialog(); 
            lst_CTHoaDon.Items.Clear();
            xoatrang();
            sMaPHID = "";
            DieuKien(false);

        }

        public string TinhGioKhac(string sgiovao, string sgiora)
        {
            string sgio = "", sphut = "", schuoi = "";

            if (sgiovao != "" && sgiora != "")
            {
                TimeSpan diff = DateTime.Parse(sgiora) - DateTime.Parse(sgiovao);
                String sMsg = diff.Days.ToString()+"-" + diff.Hours+"-" + diff.Minutes+"-" + diff.Seconds;
                string[] smanggio = sMsg.Split('-');
                if (smanggio.Length > 2)
                {
                    if (smanggio[1].ToString().Length <= 1)
                        sgio = "0" + smanggio[1].ToString();
                    else
                        sgio = smanggio[1].ToString();

                    if (smanggio[2].ToString().Length <= 1)
                        sphut = "0" + smanggio[2].ToString();
                    else
                        sphut = smanggio[2].ToString();
                }

                schuoi = sgio + ":" + sphut;
            }

            return schuoi;
        }

        public void xoatrang()
        {
            txt_KhachHang.Text = "";
            lbl_ngay.Text = "";
            lbl_Giovao.Text = "";
            lbl_Giora.Text = "";
            lbl_TenPhong.Text = "";
            lbl_LoaiPhong.Text = "";
            lbl_GioBT.Text = "";
            lbl_GioCD.Text = "";
            lbl_TongTien.Text = "";
            lbl_TGHat.Text = "";
            lbl_ThanhTien.Text = "";
        }

        public void Insert_UpdateHoaDon(string smaphid,string smakm,bool strangthai,string smaDV,string smaloai)
        {
            string[] sChuoiLap = DateTime.Now.ToShortDateString().Split('/');
            string sMaHD = HDon_PTA.TaoMa("SODH", 8);
            HDon_DATA.MaHD = sMaHD;
            HDon_DATA.MaPH = smaphid;            
            HDon_DATA.MaKM = smakm;
            HDon_DATA.ThanhTien = 0;
            HDon_DATA.TongTien = float.Parse(TongTienDV.ToString());
            HDon_DATA.TrangThai = strangthai;
            HDon_DATA.ThucAn = smaDV;
            HDon_DATA.MaLoai = smaloai;
            HDon_DATA.NgayLap = sChuoiLap[1].ToString();
            HDon_DATA.ThangLap = sChuoiLap[0].ToString();
            HDon_DATA.NamLap = sChuoiLap[2].ToString();
            HDon_PTA.Insert_Update_Delete(HDon_DATA, "Insert");
        }

        private void btn_chuyenphong_Click(object sender, EventArgs e)
        {
            if (sMaPH_Dat != "" && sMaPH_Trong != "")
            {
                if (sMaPH_Dat != sMaPH_Trong)
                {
                   
                    if (iDat == 1)
                    {
                        PH_DATA.NgayVao = "0";
                        PH_DATA.GioHT = "";
                        PH_DATA.GioSau = "";
                        PH_DATA.TrangThai = iTrong;                        
                        GanTablePhong(sMaPH_Dat);

                        CTDichVu_DATA.MaPH = sMaPH_Dat;
                        CapNhatCTDVu(sMaPH_Dat, sMaPH_Trong);
                        
                    }
                    if (iTrong == 0)
                    {
                        PH_DATA.NgayVao = lbl_ngay.Text;
                        PH_DATA.GioHT = lbl_Giovao.Text;
                        PH_DATA.GioSau = "";
                        PH_DATA.TrangThai = iDat;
                        GanTablePhong(sMaPH_Trong);

                        CTDichVu_DATA.MaPH = sMaPH_Trong;
                        CapNhatCTDVu(sMaPH_Dat, sMaPH_Trong);
                       
                    }
                    ShowListViewPhong(sDk);                   
                    CapNhatNhanPhong(sMaPH_Dat, sMaPH_Trong);
                    ShowThongTinNhanPhong(sMaPH_Trong);
                }
            }
        }

        public void CapNhatCTDVu(string sMaPHCu,string sMaPHMoi)
        {
            TblCTDV = CTDichVu_PTA.GetTable(" where MaPH='" + sMaPHCu + "'");
            if (iInsert == 0)
                TblTemp = new DataTable();
            if(TblCTDV.Rows.Count!=0)
            {
                TblTemp = TblCTDV;
                if (TblTemp.Rows.Count != 0)
                {
                    for (int i = 0; i < TblTemp.Rows.Count; i++)
                    {
                        CTDichVu_DATA.MaDV = TblTemp.Rows[i]["MaDV"].ToString();
                        CTDichVu_DATA.DonGia = float.Parse(TblTemp.Rows[i]["DonGia"].ToString());
                        CTDichVu_DATA.SoLuong = int.Parse(TblTemp.Rows[i]["SoLuong"].ToString());
                    }

                }
                CTDichVu_PTA.Inser_Update_Delete(CTDichVu_DATA, "Delete");
                iInsert = 1;
            }
            else
            {
                if (TblTemp.Rows.Count != 0)
                {
                    for (int i = 0; i < TblTemp.Rows.Count; i++)
                    {
                        CTDichVu_DATA.MaDV = TblTemp.Rows[i]["MaDV"].ToString();
                        CTDichVu_DATA.DonGia = float.Parse(TblTemp.Rows[i]["DonGia"].ToString());
                        CTDichVu_DATA.SoLuong = int.Parse(TblTemp.Rows[i]["SoLuong"].ToString());
                        CTDichVu_PTA.Inser_Update_Delete(CTDichVu_DATA, "Insert");
                    }
                    TblTemp.Rows.Clear();
                    iInsert = 0;
                }
            }
        }


        public void CapNhatNhanPhong(string sMaPHCu,string sMaPHMoi)
        {
            GetTableNhanPhong(sMaPHCu);
            if(TblNPhong.Rows.Count!=0)
            {
                NPhong_DATA.MaNP = TblNPhong.Rows[0]["MaNP"].ToString();
                NPhong_DATA.TenKH = TblNPhong.Rows[0]["TenKH"].ToString();
                NPhong_DATA.NgayNhan =Convert.ToDateTime(TblNPhong.Rows[0]["NgayNhan"]);
                NPhong_DATA.GioNhan = TblNPhong.Rows[0]["GioNhan"].ToString();
                NPhong_DATA.MaPH = sMaPHMoi;
                NPhong_DATA.SoLuongNguoi = int.Parse(TblNPhong.Rows[0]["SoLuongNguoi"].ToString());
                NPhong_DATA.DiaChi = TblNPhong.Rows[0]["DiaChi"].ToString();
                NPhong_DATA.Emai = TblNPhong.Rows[0]["Email"].ToString();
                NPhong_DATA.SoDienThoai = TblNPhong.Rows[0]["SoDienThoai"].ToString();
                NPhong_PTA.Insert_Update_Delete(NPhong_DATA, "Update");
            }
        }

       

        private void lsv_phongdat_Click(object sender, EventArgs e)
        {
            sSoPDDelete = lsv_phongdat.SelectedItems[0].Name.ToString();
            lbl_ngay.Text = lsv_phongdat.FocusedItem.SubItems[1].Text;
            sGioDat = lsv_phongdat.FocusedItem.SubItems[2].Text;
            txt_KhachHang.Text = lsv_phongdat.FocusedItem.SubItems[3].Text;
            lbl_TienDatCoc.Text = PD_PTA.GetTablePhieuDP(" where SoPD='" + sSoPDDelete + "'").Rows[0]["TienDatCoc"].ToString();
            btn_NPhong.Enabled = true;
        }

        private void cbo_LoaiDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_LoaiDV.SelectedValue!=null)
            {
                ShowListViewDichVu(cbo_LoaiDV.SelectedValue.ToString());
            }
        }

        private void lst_NhanPhong_Click(object sender, EventArgs e)
        {
            sMaPNDelete = lst_NhanPhong.SelectedItems[0].Name.ToString();
            txt_KhachHang.Text = lst_NhanPhong.FocusedItem.SubItems[4].Text;
            lbl_ngay.Text = lst_NhanPhong.FocusedItem.SubItems[2].Text;
            lbl_Giovao.Text = lst_NhanPhong.FocusedItem.SubItems[3].Text;
            int tem = int.Parse(TinhGiaPhong(lbl_Giovao.Text));
            if (lbl_GioCD.Text == tem.ToString("#,##0 VND"))
                lbl_GioCD.BackColor = Color.ForestGreen;
            else
                lbl_GioBT.BackColor = Color.GreenYellow;  
        }

        private void lst_CTHoaDon_Click(object sender, EventArgs e)
        {
            if (lst_CTHoaDon.FullRowSelect != false)
            {
                if (lst_CTHoaDon.FocusedItem.Index != -1)
                {
                    iUpdateSoLuong = int.Parse(lst_CTHoaDon.FocusedItem.SubItems[3].Text);
                    txt_SoLuon.Text = iUpdateSoLuong.ToString();
                    CTDichVu_DATA.MaDV = lst_CTHoaDon.FocusedItem.SubItems[0].Name;
                    CTDichVu_DATA.DonGia = float.Parse(lst_CTHoaDon.FocusedItem.SubItems[2].Text);
                    iNdex = lst_CTHoaDon.FocusedItem.Index;
                }
                grp_Update.Enabled = true;
            }
            
               
           
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sDk = "";
            if(lst_CTHoaDon.FocusedItem.Index!=-1)
            {
                DialogResult DR = MessageBox.Show("Bạn có muốn bỏ dịch vụ: " + lst_CTHoaDon.FocusedItem.SubItems[1].Text, "Thông Báo", MessageBoxButtons.YesNo);
                sDk = "where MaDV='" + lst_CTHoaDon.SelectedItems[0].Name.ToString() + "' And MaPH='" + sMaPHID + "'";
                if(DR==DialogResult.Yes)
                {
                    CTDichVu_PTA.DeleteCTDichVu(sDk);
                    ShowlistviewCTDV(sMaPHID);
                    lst_CTHoaDon.Items[lst_CTHoaDon.Items.Count - 1].Selected = true;
                }
            }else
            {
                MessageBox.Show("Xin Vui Lòng Chọn Dịch Vụ Cần Xóa!", "Thông Báo");
                return;
            }
        }

        private void txt_SoLuon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btn_giam_Click(object sender, EventArgs e)
        {
            if(txt_SoLuon.Text!="")
            {

                if (iUpdateSoLuong > 1)
                {
                    iUpdateSoLuong = iUpdateSoLuong - 1;
                    txt_SoLuon.Text = iUpdateSoLuong.ToString();
                    GanDuLieuCTDichVu(sMaPHID, iUpdateSoLuong);
                    lst_CTHoaDon.Items[iNdex].Selected = true;
                }
            }
        }

        private void btn_Tang_Click(object sender, EventArgs e)
        {
            if (txt_SoLuon.Text != "")
            {
                iUpdateSoLuong = iUpdateSoLuong + 1;
                txt_SoLuon.Text = iUpdateSoLuong.ToString();
                GanDuLieuCTDichVu(sMaPHID, iUpdateSoLuong);
                lst_CTHoaDon.Items[iNdex].Selected = true;
            }
        }
  
        public void GanDuLieuCTDichVu(string sMaPHCT,int iSoLuong)
        {           
            CTDichVu_DATA.MaPH = sMaPHCT;           
            CTDichVu_DATA.SoLuong = iSoLuong;
            CTDichVu_PTA.Inser_Update_Delete(CTDichVu_DATA, "Update");
            ShowlistviewCTDV(sMaPHCT);

        }

    }

}
