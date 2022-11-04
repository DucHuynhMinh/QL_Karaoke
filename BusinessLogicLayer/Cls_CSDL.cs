using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace BusinessLogicLayer
{
    public class Cls_CSDL
    {
         ClsKetNoiDuLieu ConnectData = new ClsKetNoiDuLieu();       
        
        SqlConnection sConn = new SqlConnection(); 
       
        public Cls_CSDL()
        {
            string sChuoiKetNoi = @"Data Source=DESKTOP-CPMAR3K;Integrated Security=True";
            if (sConn.State == ConnectionState.Closed || sConn.State == ConnectionState.Broken)
                sConn.ConnectionString = sChuoiKetNoi;
        }

        public void Backup(string sFileName)
        {
            sConn.Open();
           
            string schuoi = "backup database QLQuanKaraoke TO DISK = '" + sFileName + ".bak'";
            SqlCommand cmd = new SqlCommand(schuoi, this.sConn);
            cmd.CommandType = CommandType.Text;            
            cmd.ExecuteNonQuery();
            sConn.Close();
            
        }

        public void Restore(string sFileName)
        {
            sConn.Open();
            SqlCommand cmd = new SqlCommand("use master", this.sConn);
            cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            string alter = "ALTER DATABASE QLQuanKaraoke  SET Single_User WITH Rollback Immediate";
            cmd = new SqlCommand(alter, this.sConn);
            cmd.ExecuteNonQuery();
            string Restore = "RESTORE DATABASE QLQuanKaraoke FROM DISK = '" + sFileName + "' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10 ALTER DATABASE QLQuanKaraoke SET MULTI_USER";
            cmd = new SqlCommand(Restore, this.sConn);
            cmd.ExecuteNonQuery();

            alter = "ALTER DATABASE QLQuanKaraoke SET Multi_User";
            cmd = new SqlCommand(alter, this.sConn);
            cmd.ExecuteNonQuery();


            //string sChuoiRestore = "RESTORE DATABASE QLQuanKaraoke FROM DISK='" + sFileName + "'";
            cmd.ExecuteNonQuery();
            sConn.Close();

        }
    }
}
