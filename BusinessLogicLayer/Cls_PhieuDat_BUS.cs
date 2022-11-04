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
    public class Cls_PhieuDat_BUS
    {
        ClsKetNoiDuLieu KetNoiDl = new ClsKetNoiDuLieu();
        SqlConnection sConn = new SqlConnection();

        Cls_PhieuDat_DTA PD_Data = new Cls_PhieuDat_DTA();

        public Cls_PhieuDat_BUS()
        {
            if(sConn.State==ConnectionState.Closed||sConn.State==ConnectionState.Broken)
            {
                sConn.ConnectionString = KetNoiDl.KetNoiDuLieu();
            }
        }

        public DataTable GetTablePhieuDP(string sDK)
        {
            sConn.Open();
            DataTable Tbl = new DataTable();
            string sChuoi = "Select * From PhieuDatPhong ";
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

        public void Insert_Delete_Update(Cls_PhieuDat_DTA PD_Data,string sThucThi)
        {
            sConn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_PhieuDatPhong";
            cmd.Connection = this.sConn;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@SoPD", SqlDbType.Char);
            cmd.Parameters["@SoPD"].Value = PD_Data.SoPD;

            cmd.Parameters.Add("@NgayDat", SqlDbType.DateTime);
            cmd.Parameters["@NgayDat"].Value = PD_Data.NgayDat;

            cmd.Parameters.Add("@GioDat", SqlDbType.NVarChar);
            cmd.Parameters["@GioDat"].Value = PD_Data.GioDat;

            cmd.Parameters.Add("@BuoiDat", SqlDbType.NVarChar);
            cmd.Parameters["@BuoiDat"].Value = PD_Data.BuoiDat;

            cmd.Parameters.Add("@TienDatCoc", SqlDbType.Float);
            cmd.Parameters["@TienDatCoc"].Value = PD_Data.TienDatCoc;

            cmd.Parameters.Add("@MaPH", SqlDbType.Char);
            cmd.Parameters["@MaPH"].Value = PD_Data.MaPH;

            cmd.Parameters.Add("@MaKH", SqlDbType.Char);
            cmd.Parameters["@MaKH"].Value = PD_Data.MaKH;


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
            string Schuoi = "Select Top 1 Convert(int,Right(SoPD,3))+1 From PhieuDatPhong Order By SoPD desc";

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
