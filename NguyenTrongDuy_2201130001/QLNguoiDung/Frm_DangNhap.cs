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


namespace NguyenTrongDuy_2201130001.QLNguoiDung
{
    public partial class Frm_DangNhap : Form
    {
        Cls_NhanVien_DTA NVien_DATA = new Cls_NhanVien_DTA();
        Cls_NhanVien_PTA NVien_PTA = new Cls_NhanVien_PTA();

        private string _HoTenND;

        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        public string HoTenND
        {
            get { return _HoTenND; }
            set { _HoTenND = value; }
        }
        private string _QuyenDN;

        public string QuyenDN
        {
            get { return _QuyenDN; }
            set { _QuyenDN = value; }
        }

        

        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {

        }

      

        private void txt_username_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
        }

       

        private void txt_password_Click(object sender, EventArgs e)
        {
            txt_password.Text = "";
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Trim() == "" || txt_username.Text == "Nhập Username")
            {
                txt_username.Focus();
                txt_username.Select();
            }
            else if (txt_password.Text.Trim() == "" || txt_password.Text == "Nhập Password")
            {
                txt_password.Focus();
                txt_password.Select();
            }
            else
            {
                try
                {
                    GetTenDangNhap(txt_username.Text.ToUpper().ToString(), txt_password.Text.ToUpper().ToString());
                    this.Close();
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }
        }

        public void GetTenDangNhap(string sUserName,string sPassWord)
        {
            
            DataTable TblNhanVien = new DataTable();
            TblNhanVien = NVien_PTA.GetTable(" where TenDN='" + sUserName + "' And MatMaDN='" + sPassWord + "'");
            if(TblNhanVien.Rows.Count!=0)
            {
                MaNV = TblNhanVien.Rows[0]["MaNV"].ToString();
                HoTenND = TblNhanVien.Rows[0]["HoTenNV"].ToString();
                QuyenDN = TblNhanVien.Rows[0]["QuyenDN"].ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản này không tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
            
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
