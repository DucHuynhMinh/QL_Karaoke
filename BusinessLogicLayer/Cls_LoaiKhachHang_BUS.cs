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
    public class Cls_LoaiKhachHang_BUS
    {
        ClsKetNoiDuLieu KetNoiDl = new ClsKetNoiDuLieu();
        SqlConnection sConn = new SqlConnection();
        public Cls_LoaiKhachHang_BUS()
        {
            if(sConn.State==ConnectionState.Broken||sConn.State==ConnectionState.Closed)
            {
                sConn.ConnectionString = KetNoiDl.KetNoiDuLieu();
                
            }
        }

        public DataTable GetTableLoaiKH(string sDK)
        {
            sConn.Open();
            DataTable Tbl = new DataTable();
            string sChuoi = " Select * From LoaiKhachHang ";
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

        public void Insert_Update_Delete(Cls_LoaiKhachHang_DTA LoaiKH_Data, string sThucThi)
        {
            sConn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_LoaiKhachHang";
            cmd.Connection = this.sConn;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaLoaiKH", SqlDbType.Char);
            cmd.Parameters["@MaLoaiKH"].Value = LoaiKH_Data.MaLoaiKH;

            cmd.Parameters.Add("@TenLoaiKH", SqlDbType.NVarChar);
            cmd.Parameters["@TenLoaiKH"].Value = LoaiKH_Data.TenLoaiKH;

            cmd.Parameters.Add("@SoLuong", SqlDbType.Int);
            cmd.Parameters["@SoLuong"].Value = LoaiKH_Data.SoLuong;

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
            string Schuoi = " Select Top 1 convert(int,right(MaLoaiKH,3))+1 From LoaiKhachHang Order By MaLoaiKH desc";
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
