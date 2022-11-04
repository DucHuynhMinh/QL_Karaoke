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
    public class Cls_ThongBao_BUS
    {
         ClsKetNoiDuLieu KetNoiDl = new ClsKetNoiDuLieu();
         SqlConnection sConn = new SqlConnection();

         public Cls_ThongBao_BUS()
        {
            if(sConn.State==ConnectionState.Broken||sConn.State==ConnectionState.Closed)
            {
                sConn.ConnectionString = KetNoiDl.KetNoiDuLieu();
                
            }
        }

         public DataTable GetTableLoaiDV(string sDK)
         {
             sConn.Open();
             DataTable Tbl = new DataTable();
             string sChuoi = " * From ThongBao ";
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

         public void Insert_Update_Delete(Cls_ThongBao_DTA TB_Data, string sThucThi)
         {
             sConn.Open();

             SqlCommand cmd = new SqlCommand();
             cmd.CommandText = "SP_ThongBao";
             cmd.Connection = this.sConn;
             cmd.CommandType = CommandType.StoredProcedure;

             cmd.Parameters.Add("@MaTB", SqlDbType.Char);
             cmd.Parameters["@MaTB"].Value = TB_Data.MaTBao;

             cmd.Parameters.Add("@NguoiGui", SqlDbType.NVarChar);
             cmd.Parameters["@NguoiGui"].Value = TB_Data.NguoiGui;

             cmd.Parameters.Add("@NguoiNhan", SqlDbType.NVarChar);
             cmd.Parameters["@NguoiNhan"].Value = TB_Data.NguoiNhan;

             cmd.Parameters.Add("@NgayGui", SqlDbType.DateTime);
             cmd.Parameters["@NgayGui"].Value = TB_Data.NgayGui;

             cmd.Parameters.Add("@NgayNhan", SqlDbType.DateTime);
             cmd.Parameters["@NgayNhan"].Value = TB_Data.NgayNhan;

             cmd.Parameters.Add("@NoiDungTB", SqlDbType.NVarChar);
             cmd.Parameters["@NoiDungTB"].Value = TB_Data.NoiDungTB;

             cmd.Parameters.Add("@TrangThaiTB", SqlDbType.Bit);
             cmd.Parameters["@TrangThaiTB"].Value = TB_Data.TrangThaiTB;

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
             string Schuoi = " Top 1 convert(int,right(MaTB,3))+1 From ThongBao Order By MaTB desc";
             SqlCommand cmd = new SqlCommand();
             cmd.CommandText = "SP_ThongBao";
             cmd.Connection = this.sConn;
             cmd.CommandType = CommandType.StoredProcedure;

             cmd.Parameters.Add("@sqlTemp", SqlDbType.NVarChar);
             cmd.Parameters["@sqlTemp"].Value = "Select";

             cmd.Parameters.Add("@SqlChuoi", SqlDbType.NVarChar);
             cmd.Parameters["@SqlChuoi"].Value = Schuoi;

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
