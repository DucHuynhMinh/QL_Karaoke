using DataAccessLayer;
using PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhucHien_MinhDuc.QLNguoiDung
{
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }



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

        public void GetTenDangNhap(string sUserName, string sPassWord)
        {

            DataTable TblNhanVien = new DataTable();
            TblNhanVien = NVien_PTA.GetTable(" where TenDN='" + sUserName + "' And MatMaDN='" + sPassWord + "'");
            if (TblNhanVien.Rows.Count != 0)
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

        private void btnDangnhap_Click(object sender, EventArgs e)
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

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_username_Click_1(object sender, EventArgs e)
        {
            txt_username.Text = "";
        }

        private void txt_password_Click_1(object sender, EventArgs e)
        {
            txt_password.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

