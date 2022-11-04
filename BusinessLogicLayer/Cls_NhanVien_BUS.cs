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
    public class Cls_NhanVien_BUS
    {
        ClsKetNoiDuLieu KetNoiDl = new ClsKetNoiDuLieu();
         SqlConnection sConn = new SqlConnection();

         public Cls_NhanVien_BUS()
        {
            if(sConn.State==ConnectionState.Broken||sConn.State==ConnectionState.Closed)
            {
                sConn.ConnectionString = KetNoiDl.KetNoiDuLieu();
            }
        }

         public DataTable GetTable(string sDK)
         {
             sConn.Open();
             DataTable Tbl = new DataTable();
             string sChuoi = " Select * From NhanVien ";
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

         public void Insert_Update_Delete(Cls_NhanVien_DTA NV_Data, string sThucThi)
         {
             sConn.Open();

             SqlCommand cmd = new SqlCommand();
             cmd.CommandText = "SP_NhanVien";
             cmd.Connection = this.sConn;
             cmd.CommandType = CommandType.StoredProcedure;

             cmd.Parameters.Add("@MaNV", SqlDbType.Char);
             cmd.Parameters["@MaNV"].Value = NV_Data.MaNV;

             cmd.Parameters.Add("@TenDN", SqlDbType.NVarChar);
             cmd.Parameters["@TenDN"].Value = NV_Data.TenDN;

             cmd.Parameters.Add("@MatMaDN", SqlDbType.NVarChar);
             cmd.Parameters["@MatMaDN"].Value = NV_Data.MaMaDN;

             cmd.Parameters.Add("@QuyenDN", SqlDbType.NVarChar);
             cmd.Parameters["@QuyenDN"].Value = NV_Data.QuyenDN;

             cmd.Parameters.Add("@HoTenNV", SqlDbType.NVarChar);
             cmd.Parameters["@HoTenNV"].Value = NV_Data.HoTenNV;

             cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime);
             cmd.Parameters["@NgaySinh"].Value = NV_Data.NgaySinh;

             cmd.Parameters.Add("@Phai", SqlDbType.Bit);
             cmd.Parameters["@Phai"].Value = NV_Data.Phai;

             cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar);
             cmd.Parameters["@DienThoai"].Value = NV_Data.DienThoai;

             cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
             cmd.Parameters["@DiaChi"].Value = NV_Data.DiaChi;

             cmd.Parameters.Add("@LuongNV", SqlDbType.Float);
             cmd.Parameters["@LuongNV"].Value = NV_Data.LuongNV;

             cmd.Parameters.Add("@sqlTemp", SqlDbType.NVarChar);
             if (sThucThi == "Insert" || sThucThi == "Delete" || sThucThi == "Update")
                 cmd.Parameters["@sqlTemp"].Value = sThucThi;
             cmd.ExecuteNonQuery();

             sConn.Close();
         }

         public string TaoMa(string St, int Lenght)
         {
             string Result = "";
             sConn.Open();
             string Schuoi = " Select Top 1 convert(int,right(MaNV,3))+1 From NhanVien Order By MaNV desc";
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
