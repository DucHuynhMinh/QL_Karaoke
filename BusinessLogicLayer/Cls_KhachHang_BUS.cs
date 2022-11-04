using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class Cls_KhachHang_BUS
    {
        ClsKetNoiDuLieu KetNoiDl = new ClsKetNoiDuLieu();
        SqlConnection sConn = new SqlConnection();
        public Cls_KhachHang_BUS()
        {
            if(sConn.State==ConnectionState.Broken||sConn.State==ConnectionState.Closed)
            {
                sConn.ConnectionString = KetNoiDl.KetNoiDuLieu();
                
            }
        }

        public DataTable GetTableKH(string sDK)
        {
            sConn.Open();
            DataTable Tbl = new DataTable();
            string sChuoi = " Select * From KhachHang ";
            if (sDK != "")
                sChuoi += sDK;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sChuoi;
            cmd.Connection = this.sConn;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            sConn.Close();
            dap.Fill(Tbl);
            
            return Tbl;
        }

        public void Insert_Update_Delete_KH(Cls_KhachHang_DTA KH_Data,string sThucThi)
        {
            sConn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_KhachHang";
            cmd.Connection = this.sConn;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaKH", SqlDbType.Char);
            cmd.Parameters["@MaKH"].Value = KH_Data.MaKH;

            cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar);
            cmd.Parameters["@TenKH"].Value = KH_Data.TenKH;

            cmd.Parameters.Add("@TheCard", SqlDbType.NVarChar);
            cmd.Parameters["@TheCard"].Value = KH_Data.TheCard;

            cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime);
            cmd.Parameters["@NgaySinh"].Value = KH_Data.NgaySinh;

            cmd.Parameters.Add("@Phai", SqlDbType.Bit);
            cmd.Parameters["@Phai"].Value = KH_Data.Phai;

            cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar);
            cmd.Parameters["@DienThoai"].Value = KH_Data.DienThoai;

            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
            cmd.Parameters["@DiaChi"].Value = KH_Data.DiaChi;

            cmd.Parameters.Add("@Email", SqlDbType.NVarChar);
            cmd.Parameters["@Email"].Value = KH_Data.Email ;

            cmd.Parameters.Add("@HinhThucDK", SqlDbType.NVarChar);
            cmd.Parameters["@HinhThucDK"].Value = KH_Data.HinhThucDK;

            cmd.Parameters.Add("@MaLoaiKH", SqlDbType.Char);
            cmd.Parameters["@MaLoaiKH"].Value = KH_Data.MaLoaiKH;

            cmd.Parameters.Add("@sqlTemp", SqlDbType.NVarChar);
            if(sThucThi=="Insert"||sThucThi=="Delete"||sThucThi=="Update")
                cmd.Parameters["@sqlTemp"].Value = sThucThi;
            cmd.ExecuteNonQuery();
            sConn.Close();
        }

        public string TaoMa(string St, int Lenght)
        {
            string Result = "";
            sConn.Open();
            string Schuoi = " Select Top 1 convert(int,right(MaKH,3))+1 From KhachHang Order By MaKH desc";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = Schuoi;
            cmd.Connection = this.sConn;
            cmd.CommandType = CommandType.Text;            

            int number = 0;
            try
            {
                object ob = cmd.ExecuteScalar();
                if (ob == null) number = 1;
                else
                    number = (int)ob;
            }
            catch
            {
                return Result;
            }
            int d = Lenght - St.Length - number.ToString().Length;
            Result = St;
            for (int i = 0; i < d; i++)
                Result += '0';
            Result += number.ToString();
            sConn.Close();
            return Result;
        }
    }
}
