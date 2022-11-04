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
    public class Cls_KhuyenMai_BUS
    {
         ClsKetNoiDuLieu ConnectData = new ClsKetNoiDuLieu();

        SqlConnection sConn = new SqlConnection();


        public Cls_KhuyenMai_BUS()
        {
            if (sConn.State == ConnectionState.Closed || sConn.State == ConnectionState.Broken)
                sConn.ConnectionString = ConnectData.KetNoiDuLieu();
        }

        public DataTable GetTableKM(string sDK)
        {
            sConn.Open();
            DataTable Tbl = new DataTable();
            string sChuoi = " * From KhuyenMai";
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

        public void Insert_Update_Delete(Cls_KhuyenMai_DTA KM_Data,string sThucThi)
        {
            sConn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_KhuyenMai";
            cmd.Connection = this.sConn;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaKM", SqlDbType.Char);
            cmd.Parameters["@MaKH"].Value = KM_Data.MaKM;

            cmd.Parameters.Add("@TenKM", SqlDbType.NVarChar);
            cmd.Parameters["@TenKM"].Value = KM_Data.TenKM;

            cmd.Parameters.Add("@NoiDung", SqlDbType.NVarChar);
            cmd.Parameters["@NoiDung"].Value = KM_Data.NoiDung;

            cmd.Parameters.Add("@GiaKM", SqlDbType.Float);
            cmd.Parameters["@GiaKM"].Value = KM_Data.GiaKM;

            cmd.Parameters.Add("@GiaHT", SqlDbType.Float);
            cmd.Parameters["@GiaHT"].Value = KM_Data.GiaHT;

            cmd.Parameters.Add("@NgayBD", SqlDbType.DateTime);
            cmd.Parameters["@NgayBD"].Value = KM_Data.NgayBD;

            cmd.Parameters.Add("@NgayKT", SqlDbType.DateTime);
            cmd.Parameters["@NgayKT"].Value = KM_Data.NgayKT;

            cmd.Parameters.Add("@TrangThai", SqlDbType.Bit);
            cmd.Parameters["@TrangThai"].Value = KM_Data.TrangThai;

            cmd.Parameters.Add("@sqlTemp", SqlDbType.Char);
            if(sThucThi=="Insert"||sThucThi=="Update"||sThucThi=="Delete")
                cmd.Parameters["@sqlTemp"].Value = sThucThi;
            cmd.ExecuteNonQuery();
            sConn.Close();
        }

        public string TaoMa(string St, int Lenght)
        {
            string Result = "";
            sConn.Open();
            string Schuoi = " Top 1 convert(int,right(MaKM,3))+1 From KhuyenMai Order By MaKM desc";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_KhuyenMai";
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
