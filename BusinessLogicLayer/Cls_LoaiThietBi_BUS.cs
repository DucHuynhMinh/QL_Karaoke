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
    public class Cls_LoaiThietBi_BUS
    {
         ClsKetNoiDuLieu KetNoiDl = new ClsKetNoiDuLieu();
         SqlConnection sConn = new SqlConnection();

         public Cls_LoaiThietBi_BUS()
        {
            if(sConn.State==ConnectionState.Broken||sConn.State==ConnectionState.Closed)
            {
                sConn.ConnectionString = KetNoiDl.KetNoiDuLieu();
                
            }
        }

         public DataTable GetTableLoaiTB(string sDK)
         {
             sConn.Open();
             DataTable Tbl = new DataTable();
             string sChuoi = " Select * From LoaiThietBi ";
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

         public void Insert_Update_Delete(Cls_LoaiThietBi_DTA LoaiTB_Data, string sThucThi)
         {
             sConn.Open();

             SqlCommand cmd = new SqlCommand();
             cmd.CommandText = "SP_LoaiThietBi";
             cmd.Connection = this.sConn;
             cmd.CommandType = CommandType.StoredProcedure;

             cmd.Parameters.Add("@MaLoaiTB", SqlDbType.Char);
             cmd.Parameters["@MaLoaiTB"].Value = LoaiTB_Data.MaLoaiTB;

             cmd.Parameters.Add("@TenLoaiTB", SqlDbType.NVarChar);
             cmd.Parameters["@TenLoaiTB"].Value = LoaiTB_Data.TenLoaiTB;

             cmd.Parameters.Add("@XuatXu", SqlDbType.NVarChar);
             cmd.Parameters["@XuatXu"].Value = LoaiTB_Data.XuatXu;

             cmd.Parameters.Add("@sqlTemp", SqlDbType.NVarChar);
             if (sThucThi == "Insert" || sThucThi == "Delete" || sThucThi == "Update")
                 cmd.Parameters["@sqlTemp"].Value = sThucThi;
             cmd.ExecuteNonQuery();

             sConn.Close();
         }

        public string TaoMa(string ST,int Length)
         {
             sConn.Open();
             string Result = "";
             string sChuoi = "Select Top 1 convert(int,right(MaLoaiTB,3))+1 From LoaiThietBi ORDER BY MaLoaiTB DESC";

             SqlCommand cmd = new SqlCommand();
             cmd.CommandText = sChuoi;
             cmd.Connection = this.sConn;
             cmd.CommandType = CommandType.Text;

             int number = 0;

             try
             {
                 object ob = (object)cmd.ExecuteScalar();
                 if (ob == null) number = 1;
             }
             catch (Exception)
             {
                 return Result;
             }
             int d = Length - ST.Length - number.ToString().Length;
             Result = ST;
             for (int i = 0; i < d; i++)
                 Result += '0';
             Result += number.ToString();
             sConn.Close();
             return Result;
         }
    }
}
