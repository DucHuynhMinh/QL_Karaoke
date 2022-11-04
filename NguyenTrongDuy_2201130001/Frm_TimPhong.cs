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
    public partial class Frm_TimPhong : Form
    {

        Cls_LoaiPhong_PTA LP_PTA = new Cls_LoaiPhong_PTA();

        Cls_PhongHat_PTA PH_PTA = new Cls_PhongHat_PTA();

        int sTrangThai = -1;
      

        SqlDataAdapter da;
        SqlCommandBuilder cmdb;

        public Frm_TimPhong()
        {
            InitializeComponent();
        }

        private void Frm_TimPhong_Load(object sender, EventArgs e)
        {
            gpb_NoiDungTim.Enabled = false;
         
            ShowDataLoaiPhong();
           
        }

        private void ShowDataLoaiPhong()
        {
            MaLoai.DataSource = LP_PTA.GetDatata("");
            MaLoai.ValueMember = "MaLoai";
            MaLoai.DisplayMember = "TenPhong";

            

        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            txt_TimKiem.Text = "Gõ Từ Khóa Cần Tìm";
        }

        

        private void txt_TimKiem_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Text = "";
        }

        private void rad_PhongTrong_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_PhongTrong.Checked != false)
                gpb_NoiDungTim.Enabled = true;
            sTrangThai = 0;
        }

        private void rad_PhongCoKhach_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_PhongCoKhach.Checked != false)
                gpb_NoiDungTim.Enabled = true;
            sTrangThai = 1;
        }

        private void rad_PhongDaDat_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_PhongDaDat.Checked != false)
                gpb_NoiDungTim.Enabled = true;
            sTrangThai = 2;
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
       {
            string sDieuKien="";
            DataSet ds = new DataSet();
            if (txt_TimKiem.Text.Trim() == "" || txt_TimKiem.Text == "Gõ Từ Khóa Cần Tìm")
                sDieuKien = "";
            else
            {
                if(rad_NgayGio.Checked!=false)
                {
                    sDieuKien = " TrangThai='" + sTrangThai + "'" + " and Ngayvao Like '" + txt_TimKiem.Text + "%'";
                }
                else if(rad_LoaiPhong.Checked!=false)
                {
                    sDieuKien = " TrangThai='" + sTrangThai + "'" + " and MaLoai Like '" + txt_TimKiem.Text + "%'";
                }
                else
                {
                    sDieuKien = "TrangThai='" + sTrangThai + "'" + " and SucChua Like '" + txt_TimKiem.Text + "%'";
                }
                ds = PH_PTA.GetTable(ref da, cmdb, sDieuKien);
                dgv_DanhSachTimKiem.DataSource = ds.Tables[0];
                //code này dùng để hiển thị imaglist lên datagridview image column
                for (int i = 0; i < img_ListHinh.Images.Count; i++)
                {
                    if (sTrangThai == i)
                        TrangThai.Image = img_ListHinh.Images[i];
                }
            }
           
        }

       

       
       

        

       
        
    }
}
