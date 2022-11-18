using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer;
using BusinessLogicLayer;
using System.Data.SqlClient;

namespace PhucHien_MinhDuc.QLNguoiDung
{
    public partial class Frm_SaoLuuDuLieu : Form
    {
        Cls_CSDL_PTA Backup_Retore = new Cls_CSDL_PTA();
        private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Reader;
        string sql = "";
        string ChuoiConnect = "";
        
        public Frm_SaoLuuDuLieu()
        {
            InitializeComponent();
        }

        private void Frm_PhucHoiDuLieu_Load(object sender, EventArgs e)
        {

            ShowDatabase();
        }

        public void ShowDatabase()
        {
            ChuoiConnect = @"Data Source=DESKTOP-CPMAR3K.\SQLEXpress;Integrated Security=True";
            Conn = new SqlConnection(ChuoiConnect);
            Conn.Open();
            //sql="EXEC sp_databases";
            sql = "SELECT * FROM sys.databases d WHERE d.database_id>4";
            Cmd = new SqlCommand(sql, Conn);
            Reader = Cmd.ExecuteReader();
            cbo_database.Items.Clear();
            while(Reader.Read())
            {
                cbo_database.Items.Add(Reader[0].ToString());
            }
            Reader.Dispose();
            Conn.Close();
            Conn.Dispose();
        }

        private void btn_brow_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup File(*.bak)|*.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_restore.Text = dlg.FileName;
            }
          
        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo_database.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Please select a database");
                    return;
                }
                Conn = new SqlConnection(ChuoiConnect);
                Conn.Open();
                sql = "BACKUP DATABASE " + cbo_database.Text + " TO DISK= '" + txt_backup.Text + "\\" + cbo_database.Text + "-" + DateTime.Now.Ticks.ToString() + ".bak'";
                Cmd = new SqlCommand(sql, Conn);
                Cmd.ExecuteNonQuery();
                Conn.Close();
                Conn.Dispose();
                MessageBox.Show("Sucessfully Database Backup Completed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string Splitquery(string sChuoi)
        {
            string sResult = "", stemp = "";
            for(int i=sChuoi.Length-1;i>0;i--)
            {
                if (sChuoi[i].ToString() != "\\")
                {
                    sResult += sChuoi[i];
                }
                else
                    break;
            }
            for (int j = sResult.Length - 1; j > 0; j--)               
                    stemp += sResult[j].ToString();
            string[] kq = stemp.Split('.', '_');
            return kq[0].ToString();
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo_database.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Please select a database");
                    return;
                }
                Conn = new SqlConnection(ChuoiConnect);
                Conn.Open();
                sql = "Alter Database " + cbo_database.Text + " Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += " Restore Database " + cbo_database.Text + " From Disk='" + txt_restore.Text + "' WITH REPLACE;";
                Cmd = new SqlCommand(sql, Conn);
                Cmd.ExecuteNonQuery();
                Conn.Close();
                Conn.Dispose();
                MessageBox.Show("Successfully a Database Restore Complete");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_browBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                txt_backup.Text = dlg.SelectedPath;
        }
    }
}
