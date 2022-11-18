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

namespace PhucHien_MinhDuc.QLNguoiDung
{
    public partial class Frm_DoiMatMa : Form
    {
        Cls_NhanVien_DTA NV_DATA = new Cls_NhanVien_DTA();
        Cls_NhanVien_PTA NV_PTA = new Cls_NhanVien_PTA();
        string MaNV;
        DataTable TblNV = new DataTable();
        public Frm_DoiMatMa(string smanv)
        {
            this.MaNV = smanv;
            InitializeComponent();
        }

        private void btn_matma_Click(object sender, EventArgs e)
        {
            if(txt_matmahientai.Text.Trim()=="")
            {
                txt_matmahientai.Focus();
                txt_matmahientai.Select();
            }
            else if(txt_matmamoi.Text.Trim()=="")
            {
                txt_matmamoi.Focus();
                txt_matmamoi.Select();

            }
            else if(txt_nhaplaimatma.Text.Trim()=="")
            {
                txt_nhaplaimatma.Focus();
                txt_nhaplaimatma.Select();
            }
            else
            {
                if(txt_matmamoi.Text.ToUpper()==txt_nhaplaimatma.Text.ToUpper())
                {
                    GanDuLieu(MaNV);
                    NV_PTA.Insert_Update_Delete(NV_DATA, "Update");
                    MessageBox.Show("đổi mật mã thành công");
                }
            }
        }

        public void GanDuLieu(string smaid)
        {
            
            if(TblNV.Rows.Count!=0)
            {
                NV_DATA.MaNV = smaid;
                NV_DATA.TenDN = TblNV.Rows[0]["TenDN"].ToString();               
                NV_DATA.MaMaDN = txt_matmamoi.Text;
                NV_DATA.QuyenDN = TblNV.Rows[0]["QuyenDN"].ToString();
                NV_DATA.HoTenNV = TblNV.Rows[0]["HoTenNV"].ToString();
                NV_DATA.NgaySinh = Convert.ToDateTime(TblNV.Rows[0]["NgaySinh"]);
                NV_DATA.Phai = Convert.ToBoolean(TblNV.Rows[0]["Phai"]);
                NV_DATA.DienThoai = TblNV.Rows[0]["DienThoai"].ToString();
                NV_DATA.DiaChi = TblNV.Rows[0]["DiaChi"].ToString();
                if (TblNV.Rows[0]["LuongNV"].ToString() != "")
                    NV_DATA.LuongNV = float.Parse(TblNV.Rows[0]["LuongNV"].ToString());
                else
                    NV_DATA.LuongNV = 0;
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_DoiMatMa_Load(object sender, EventArgs e)
        {
            txt_matmahientai.Focus();
            txt_matmahientai.Select();
            TblNV = NV_PTA.GetTable(" where MaNV='" + MaNV + "'");
            if(TblNV.Rows.Count!=0)
                lbl_HoTen.Text = TblNV.Rows[0]["HoTenNV"].ToString();
        }

       
    }
}
