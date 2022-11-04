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
    public class Cls_NhanPhong_BUS
    {
         ClsKetNoiDuLieu KetNoiDl = new ClsKetNoiDuLieu();
         SqlConnection sConn = new SqlConnection();

         public Cls_NhanPhong_BUS()
         {
             if (sConn.State == ConnectionState.Broken || sConn.State == ConnectionState.Closed)
             {
                 sConn.ConnectionString = KetNoiDl.KetNoiDuLieu();

             }
         }

         public DataTable GetTableNhanPhong(string sDK)
         {
             sConn.Open();
             DataTable Tbl = new DataTable();
             string sChuoi = "Select * From NhanPhong ";
             if (sDK != "")
                 sChuoi += sDK;

             SqlCommand cmd = new SqlCommand();
             cmd.CommandText = sChuoi;
             cmd.Connection = this.sConn;
             cmd.CommandType = CommandType.Text;


             SqlDataAdapter dap = new SqlDataAdapter(cmd);
             dap.Fill(Tbl);
             sConn.Close();
             return Tbl;
         }

         public void Insert_Update_Delete(Cls_NhanPhong_DTA NP_Data, string sThucThi)
         {
             sConn.Open();

             SqlCommand cmd = new SqlCommand();
             cmd.CommandText = "SP_NhanPhong";
             cmd.Connection = this.sConn;
             cmd.CommandType = CommandType.StoredProcedure;

             cmd.Parameters.Add("@MaNP", SqlDbType.Char);
             cmd.Parameters["@MaNP"].Value = NP_Data.MaNP;

             cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar);
             cmd.Parameters["@TenKH"].Value = NP_Data.TenKH;

             cmd.Parameters.Add("@NgayNhan", SqlDbType.DateTime);
             cmd.Parameters["@NgayNhan"].Value = NP_Data.NgayNhan;

             cmd.Parameters.Add("@GioNhan", SqlDbType.NVarChar);
             cmd.Parameters["@GioNhan"].Value = NP_Data.GioNhan;

             cmd.Parameters.Add("@MaPH", SqlDbType.Char);
             cmd.Parameters["@MaPH"].Value = NP_Data.MaPH;

             cmd.Parameters.Add("@SoLuongNguoi", SqlDbType.Int);
             cmd.Parameters["@SoLuongNguoi"].Value = NP_Data.SoLuongNguoi;

             cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
             cmd.Parameters["@DiaChi"].Value = NP_Data.DiaChi;

             cmd.Parameters.Add("@Email", SqlDbType.NVarChar);
             cmd.Parameters["@Email"].Value = NP_Data.Emai;

             cmd.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar);
             cmd.Parameters["@SoDienThoai"].Value = NP_Data.SoDienThoai;

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
             string Schuoi = " Select Top 1 convert(int,right(MaNP,3))+1 From NhanPhong Order By MaNP desc";
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
