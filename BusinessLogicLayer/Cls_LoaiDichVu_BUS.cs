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
    public class Cls_LoaiDichVu_BUS
    {
         ClsKetNoiDuLieu KetNoiDl = new ClsKetNoiDuLieu();
         SqlConnection sConn = new SqlConnection();

        public Cls_LoaiDichVu_BUS()
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
            string sChuoi = " Select * From LoaiDichVu ";
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

        public void Insert_Update_Delete(Cls_LoaiDichVu_DTA LoaiDV_Data,string sThucThi)
        {
            sConn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_LoaiDichVu";
            cmd.Connection = this.sConn;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaLoaiDV", SqlDbType.Char);
            cmd.Parameters["@MaLoaiDV"].Value = LoaiDV_Data.MaLoaiDV;

            cmd.Parameters.Add("@TenLoaiDV", SqlDbType.NVarChar);
            cmd.Parameters["@TenLoaiDV"].Value = LoaiDV_Data.TenLoaiDV;

            cmd.Parameters.Add("@LoaiDV", SqlDbType.NVarChar);
            cmd.Parameters["@LoaiDV"].Value = LoaiDV_Data.LoaiDV;

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
            string Schuoi = " Select Top 1 convert(int,right(MaLoaiDV,3))+1 From LoaiDichVu Order By MaLoaiDV desc";
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
