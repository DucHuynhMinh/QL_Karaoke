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
    public class Cls_PhongHat_BUS
    {
        ClsKetNoiDuLieu KetNoiDl = new ClsKetNoiDuLieu();
        SqlConnection sConn = new SqlConnection();

        public Cls_PhongHat_BUS()
        {
            if(sConn.State==ConnectionState.Broken||sConn.State==ConnectionState.Closed)
            {
                sConn.ConnectionString = KetNoiDl.KetNoiDuLieu();
                
            }
        }


        public void Insert_Update_Delete(Cls_PhongHat_DTA PH_Data,string sThucThi)
        {
            sConn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_PhongHat";
            cmd.Connection = this.sConn;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaPH", SqlDbType.Char);
            cmd.Parameters["@MaPH"].Value = PH_Data.MaPH;

            cmd.Parameters.Add("@TenPH", SqlDbType.NVarChar);
            cmd.Parameters["@TenPH"].Value = PH_Data.TenPH;

            cmd.Parameters.Add("@TinhTrang", SqlDbType.Int);
            cmd.Parameters["@TinhTrang"].Value = PH_Data.TinhTrang;

            cmd.Parameters.Add("@TrangThai", SqlDbType.Int);
            cmd.Parameters["@TrangThai"].Value = PH_Data.TrangThai;

            cmd.Parameters.Add("@MaLoai", SqlDbType.Char);
            cmd.Parameters["@MaLoai"].Value = PH_Data.MaLoai;

            cmd.Parameters.Add("@NgayVao", SqlDbType.NVarChar);
            cmd.Parameters["@NgayVao"].Value = PH_Data.NgayVao;

            cmd.Parameters.Add("@GioHT", SqlDbType.NVarChar);
            cmd.Parameters["@GioHT"].Value = PH_Data.GioHT;

            cmd.Parameters.Add("@GioSau", SqlDbType.NVarChar);
            cmd.Parameters["@GioSau"].Value = PH_Data.GioSau;

            cmd.Parameters.Add("@sqlTemp", SqlDbType.NVarChar);
            if (sThucThi == "Insert" || sThucThi == "Delete" || sThucThi == "Update")
                cmd.Parameters["@sqlTemp"].Value = sThucThi;
            cmd.ExecuteNonQuery();

            sConn.Close();
        }

        public DataTable GetData(string sDK)
        {
            sConn.Open();
            DataTable Tbl = new DataTable();
           // string sChuoi = "SELECT PhongHat.MaPH, PhongHat.TenPH, PhongHat.NgayVao, PhongHat.NgayDi, PhongHat.SucChua, PhongHat.TrangThai, LoaiPhong.TenPhong ";
            //sChuoi +=       "FROM   PhongHat INNER JOIN LoaiPhong ON PhongHat.MaLoai = LoaiPhong.MaLoai";
            string sChuoi = "Select * From PhongHat";

            if (sDK != "")
                sChuoi +=  sDK ;            
            SqlCommand cmd = new SqlCommand(sChuoi, this.sConn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            sConn.Close();
            dap.Fill(Tbl);            
            return Tbl;

        }

        public string TaoMa(string St, int Lenght)
        {
            string Result = "";
            string Schuoi = "Select Top 1 convert(int,right(MaPH,3))+1 From PhongHat Order By MaPH desc";
            sConn.Open();
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

        public DataSet GetTable(ref SqlDataAdapter da,ref SqlCommandBuilder cmdb,string sDieuKien )
        {
            sConn.Open();
            DataSet ds = new DataSet();
            string sChuoi = "Select * From PhongHat";
            if (sDieuKien != "")
                sChuoi += " where " + sDieuKien;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sChuoi;
            cmd.Connection = this.sConn;
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            cmdb = new SqlCommandBuilder(da);
            sConn.Close();
            da.Fill(ds);
            return ds;
        }

        public DataSet GetHaiTable(ref SqlDataAdapter da, ref SqlCommandBuilder cmdb, string sDieuKien)
        {
            sConn.Open();
            DataSet ds = new DataSet();
            string sChuoi = "SELECT PhongHat.MaPH, PhongHat.TenPH, PhongHat.TinhTrang, PhongHat.TrangThai, LoaiPhong.TenPhong ";
            sChuoi += "FROM   PhongHat INNER JOIN LoaiPhong ON PhongHat.MaLoai = LoaiPhong.MaLoai";
            if (sDieuKien != "")
                sChuoi += " where " + sDieuKien;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sChuoi;
            cmd.Connection = this.sConn;
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            cmdb = new SqlCommandBuilder(da);
            sConn.Close();
            da.Fill(ds);
            return ds;
        }
    }
}
