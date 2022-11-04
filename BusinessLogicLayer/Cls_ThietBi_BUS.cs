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
    public class Cls_ThietBi_BUS
    {
         ClsKetNoiDuLieu KetNoiDl = new ClsKetNoiDuLieu();
         SqlConnection sConn = new SqlConnection();

         public Cls_ThietBi_BUS()
        {
            if(sConn.State==ConnectionState.Broken||sConn.State==ConnectionState.Closed)
            {
                sConn.ConnectionString = KetNoiDl.KetNoiDuLieu();
                
            }
        }

         public DataTable GetTableThietBi(string sDK)
         {
             sConn.Open();
             DataTable Tbl = new DataTable();
             string sChuoi = " Select tb.MaTB,tb.TenTB,tb.DonGia,tb.SoLuong,tb.TrangThai,tb.MaLoaiTB,ltb.XuatXu From ThietBi tb INNER JOIN LoaiThietBi ltb On tb.MaLoaiTB=ltb.MaLoaiTB ";
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

         public void Insert_Update_Delete(Cls_ThietBi_DTA TB_Data, string sThucThi)
         {
             sConn.Open();
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.CommandText = "SP_ThietBi";
                 cmd.Connection = this.sConn;
                 cmd.CommandType = CommandType.StoredProcedure;

                 cmd.Parameters.Add("@MaTB", SqlDbType.Char);
                 cmd.Parameters["@MaTB"].Value = TB_Data.MaTB;

                 cmd.Parameters.Add("@TenTB", SqlDbType.NVarChar);
                 cmd.Parameters["@TenTB"].Value = TB_Data.TenTB;

                 cmd.Parameters.Add("@DonGia", SqlDbType.Float);
                 cmd.Parameters["@DonGia"].Value = TB_Data.DonGia;

                 cmd.Parameters.Add("@SoLuong", SqlDbType.Int);
                 cmd.Parameters["@SoLuong"].Value = TB_Data.SoLuong;

                 cmd.Parameters.Add("@TrangThai", SqlDbType.Bit);
                 cmd.Parameters["@TrangThai"].Value = TB_Data.TrangThai;

                 cmd.Parameters.Add("@MaLoaiTB", SqlDbType.Char);
                 cmd.Parameters["@MaLoaiTB"].Value = TB_Data.MaLoaiTB;

                 cmd.Parameters.Add("@sqlTemp", SqlDbType.NVarChar);
                 if (sThucThi == "Insert" || sThucThi == "Delete" || sThucThi == "Update")
                     cmd.Parameters["@sqlTemp"].Value = sThucThi;
                 cmd.ExecuteNonQuery();

             }
             catch (Exception)
             {

                 throw;
             }
             sConn.Close();
         }

         public string TaoMa(string St, int Lenght)
         {
             string Result = "";
             try
             {
                 sConn.Open();
                 string Schuoi = " Select Top 1 convert(int,right(MaTB,3))+1 From ThietBi Order By MaTB desc";
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
             }
             catch (Exception)
             {

                 throw;
             }
             sConn.Close();
             return Result;
         }
    }
}
