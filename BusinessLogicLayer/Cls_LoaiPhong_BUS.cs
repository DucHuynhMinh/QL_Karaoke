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
    public class Cls_LoaiPhong_BUS
    {
         ClsKetNoiDuLieu KetNoiDl = new ClsKetNoiDuLieu();
         SqlConnection sConn = new SqlConnection();

         public Cls_LoaiPhong_BUS()
        {
            if(sConn.State==ConnectionState.Broken||sConn.State==ConnectionState.Closed)
            {
                sConn.ConnectionString = KetNoiDl.KetNoiDuLieu();
                
            }
        }

         public DataTable GetTableLoaiPhong(string sDK)
         {
             sConn.Open();
             DataTable Tbl = new DataTable();
             string sChuoi = " Select * From LoaiPhong ";
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

         public void Insert_Update_Delete(Cls_LoaiPhong_DTA LP_Data, string sThucThi)
         {
             sConn.Open();

             SqlCommand cmd = new SqlCommand();
             cmd.CommandText = "SP_LoaiPhong";
             cmd.Connection = this.sConn;
             cmd.CommandType = CommandType.StoredProcedure;

             cmd.Parameters.Add("@MaLoai", SqlDbType.Char);
             cmd.Parameters["@MaLoai"].Value = LP_Data.MaLoai;

             cmd.Parameters.Add("@TenPhong", SqlDbType.NVarChar);
             cmd.Parameters["@TenPhong"].Value = LP_Data.TenLoai;

             cmd.Parameters.Add("@GioCD", SqlDbType.Float);
             cmd.Parameters["@GioCD"].Value = LP_Data.GioCD;

             cmd.Parameters.Add("@GioBT", SqlDbType.Float);
             cmd.Parameters["@GioBT"].Value = LP_Data.GioBT;
           

             cmd.Parameters.Add("@sqlTemp", SqlDbType.NVarChar);
             if (sThucThi == "Insert" || sThucThi == "Delete" || sThucThi == "Update")
                 cmd.Parameters["@sqlTemp"].Value = sThucThi;
             cmd.ExecuteNonQuery();

             sConn.Close();
         }

         public string TaoMa(string St, int Lenght)
         {
             string Result = "";
             string sChuoi = "Select Top 1 convert(int,Right(MaLoai,3))+1 From LoaiPhong order by MaLoai DESC";
             sConn.Open();            
             SqlCommand cmd = new SqlCommand();
             cmd.CommandText = sChuoi;
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
