using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class Cls_HoaDon_BUS
    {
        ClsKetNoiDuLieu ConnectData = new ClsKetNoiDuLieu();

        SqlConnection sConn = new SqlConnection();        

        public string sChuoiKetNoi()
        {
            sConn.Close();
            return ConnectData.KetNoiDuLieu();
        }
       
        public Cls_HoaDon_BUS()
        {
            if (sConn.State == ConnectionState.Closed || sConn.State == ConnectionState.Broken)
                sConn.ConnectionString = ConnectData.KetNoiDuLieu();
        }

        public DataSet  GetTable(string sDk)
        {
            sConn.Open();
            DataSet Tbl = new DataSet();
            string sChuoi = " SELECT  HoaDon.MaHD, HoaDon.ThanhTien, HoaDon.TongTien, HoaDon.NgayLap, HoaDon.ThangLap, HoaDon.NamLap, PhongHat.TenPH ";
            sChuoi += "  FROM  HoaDon INNER JOIN  PhongHat ON HoaDon.MaPH = PhongHat.MaPH ";
            if(sDk!="")
                sChuoi += sDk;
            SqlCommand cmd = new SqlCommand(sChuoi, this.sConn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            sConn.Close();
            dap.Fill(Tbl);            
            return Tbl;
        }

        public void Insert_Update_Delete(Cls_HoaDon_DTA HD_Data,string sThucThi)
        {
            sConn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_HoaDon";
            cmd.Connection = this.sConn;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaHD", SqlDbType.Char);
            cmd.Parameters["@MaHD"].Value = HD_Data.MaHD;

            cmd.Parameters.Add("@MaPH", SqlDbType.Char);
            cmd.Parameters["@MaPH"].Value = HD_Data.MaPH;       

            cmd.Parameters.Add("@MaKM", SqlDbType.Char);
            cmd.Parameters["@MaKM"].Value = HD_Data.MaKM;

            cmd.Parameters.Add("@ThanhTien", SqlDbType.Float);
            cmd.Parameters["@ThanhTien"].Value = HD_Data.ThanhTien;

            cmd.Parameters.Add("@TongTien", SqlDbType.Float);
            cmd.Parameters["@TongTien"].Value = HD_Data.TongTien;

            cmd.Parameters.Add("@TrangThai", SqlDbType.Bit);
            cmd.Parameters["@TrangThai"].Value = HD_Data.TrangThai;

            cmd.Parameters.Add("@ThucAn", SqlDbType.NVarChar);
            cmd.Parameters["@ThucAn"].Value = HD_Data.ThucAn;
           
            cmd.Parameters.Add("@MaLoai", SqlDbType.Char);
            cmd.Parameters["@MaLoai"].Value = HD_Data.MaLoai;

            cmd.Parameters.Add("@NgayLap", SqlDbType.NVarChar);
            cmd.Parameters["@NgayLap"].Value = HD_Data.NgayLap;

            cmd.Parameters.Add("@ThangLap", SqlDbType.NVarChar);
            cmd.Parameters["@ThangLap"].Value = HD_Data.ThangLap;

            cmd.Parameters.Add("@NamLap", SqlDbType.NVarChar);
            cmd.Parameters["@NamLap"].Value = HD_Data.NamLap;

            cmd.Parameters.Add("@sqlTemp", SqlDbType.NVarChar);
            

            if(sThucThi=="Insert"||sThucThi=="Delete"||sThucThi=="Update")
            {
                cmd.Parameters["@sqlTemp"].Value = sThucThi;
                cmd.ExecuteNonQuery();
            }
            sConn.Close();
            
        }

        public string TaoMa(string sTT,int Length)
        {
            sConn.Open();
            string Result = "";
            string sChuoi = " Select Top 1 convert(int,Right(MaHD,4))+1 From HoaDon Order By MaHD Desc";
            SqlCommand cmd = new SqlCommand( sChuoi,this.sConn);
            int number = 0;
            try
            {
                object ob = cmd.ExecuteScalar();
                if (ob == null) number = 1;
                else
                    number = (int)ob;
            }
            catch (Exception)
            {
                
                return Result;
            }
            int d = Length - sTT.Length - number.ToString().Length;
            Result = sTT;
            for (int i = 0; i < d; i++)
                Result +='0';
            Result += number.ToString();
            sConn.Close();
            return Result;
        }
    }
}
