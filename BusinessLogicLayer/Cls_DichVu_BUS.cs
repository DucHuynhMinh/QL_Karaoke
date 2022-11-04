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
    public  class Cls_DichVu_BUS
    {
        ClsKetNoiDuLieu ConnectData = new ClsKetNoiDuLieu();

        SqlConnection sConn = new SqlConnection();

    
        public Cls_DichVu_BUS ()
        {
            if (sConn.State == ConnectionState.Closed || sConn.State == ConnectionState.Broken)
                sConn.ConnectionString = ConnectData.KetNoiDuLieu();
        }

        public DataTable GetTableDV(string sDK)
        {
            sConn.Open();
            DataTable Tbl = new DataTable();
            string sChuoi = " Select * From DichVu";
            if (sDK != "")
            {
                sChuoi +=  sDK ;
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sChuoi;
            cmd.Connection = this.sConn;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            sConn.Close();
            dap.Fill(Tbl);            
            return Tbl;
        }


        public void Insert_Update_Delete(Cls_DichVu_DTA DV_Data,string sThucThi)
        {
            sConn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_DichVu";
            cmd.Connection = this.sConn;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaDV", SqlDbType.Char);
            cmd.Parameters["@MaDV"].Value = DV_Data.MaDV;

            cmd.Parameters.Add("@TenDV", SqlDbType.NVarChar);
            cmd.Parameters["@TenDV"].Value = DV_Data.TenDV;

            cmd.Parameters.Add("@DonViTinh", SqlDbType.NVarChar);
            cmd.Parameters["@DonViTinh"].Value = DV_Data.DVTinh;

            cmd.Parameters.Add("@DonGia", SqlDbType.Float);
            cmd.Parameters["@DonGia"].Value = DV_Data.DonGia;


            cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar);
            cmd.Parameters["@MoTa"].Value = DV_Data.MoTa;

            cmd.Parameters.Add("@MaLoaiDV", SqlDbType.Char);
            cmd.Parameters["@MaLoaiDV"].Value = DV_Data.MaLoaiDV;

            cmd.Parameters.Add("@sqlTemp", SqlDbType.NVarChar);

            if (sThucThi == "Insert" || sThucThi == "Delete" || sThucThi == "Update")
            {

                cmd.Parameters["@sqlTemp"].Value = sThucThi;
                cmd.ExecuteNonQuery();
            }

            sConn.Close();
        }

        public string TaoMa(string St, int Lenght)
        {
            string Result = "";
            sConn.Open();
            string Schuoi = " Select Top 1 convert(int,right(MaDV,3))+1 From DichVu Order By MaDV desc";
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
