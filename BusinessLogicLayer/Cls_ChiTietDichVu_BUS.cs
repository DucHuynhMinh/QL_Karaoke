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
    public class Cls_ChiTietDichVu_BUS
    {
        ClsKetNoiDuLieu ConnectData = new ClsKetNoiDuLieu();

        SqlConnection sConn = new SqlConnection();


        public Cls_ChiTietDichVu_BUS()
        {
            if (sConn.State == ConnectionState.Closed || sConn.State == ConnectionState.Broken)
                sConn.ConnectionString = ConnectData.KetNoiDuLieu();
        }

        public DataTable GetTable(string sDK)
        {
            sConn.Open();
            DataTable Tbl = new DataTable();
            string sChuoi = " Select * From CTDichVu";
            if (sDK != "")
            {
                sChuoi += sDK;
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

        public void Insert_Update_Delete(Cls_ChiTietDichVu_DTA CTDichVu_Data, string sThucThi)
        {
            sConn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_CTDichVu";
                cmd.Connection = this.sConn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaDV", SqlDbType.Char);
                cmd.Parameters["@MaDV"].Value = CTDichVu_Data.MaDV;

                cmd.Parameters.Add("@MaPH", SqlDbType.Char);
                cmd.Parameters["@MaPH"].Value = CTDichVu_Data.MaPH;

                cmd.Parameters.Add("@DonGia", SqlDbType.Float);
                cmd.Parameters["@DonGia"].Value = CTDichVu_Data.DonGia;

                cmd.Parameters.Add("@SoLuong", SqlDbType.Int);
                cmd.Parameters["@SoLuong"].Value = CTDichVu_Data.SoLuong;

                cmd.Parameters.Add("@sqlTemp", SqlDbType.NVarChar);

                if (sThucThi == "Insert" || sThucThi == "Delete" || sThucThi == "Update")
                {

                    cmd.Parameters["@sqlTemp"].Value = sThucThi;
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                
                throw;
            }

            sConn.Close();
        }

        public DataTable GetTableDVPhong(string sDK)
        {
            sConn.Open();
            DataTable Tbl = new DataTable();
            string sChuoi = " Select CTDichVu.MaDV, CTDichVu.DonGia,CTDichVu.SoLuong,DichVu.TenDV From CTDichVu INNER JOIN PhongHat on CTDichVu.MaPH=PhongHat.MaPH ";
            sChuoi += " INNER JOIN DichVu ON CTDichVu.MaDV=DichVu.MaDV";
            if (sDK != "")
            {
                sChuoi += sDK;
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

        public void DeleteCTDichVu(string sDk)
        {
            sConn.Open();
            string sChuoi = "Delete From CTDichVu ";
            if (sDk != "")
                sChuoi += sDk;
            SqlCommand cmd = new SqlCommand(sChuoi, this.sConn);
            cmd.ExecuteNonQuery();
            sConn.Close();
        }
    }
}
