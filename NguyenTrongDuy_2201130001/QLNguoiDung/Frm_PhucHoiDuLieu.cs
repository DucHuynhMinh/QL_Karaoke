using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NguyenTrongDuy_2201130001.QLNguoiDung;
using PresentationLayer;

namespace NguyenTrongDuy_2201130001.QLNguoiDung
{
    public partial class Frm_PhucHoiDuLieu : Form
    {
        Cls_CSDL_PTA RESTORE_BACKUP = new Cls_CSDL_PTA();
        public Frm_PhucHoiDuLieu()
        {
            InitializeComponent();
        }

        private void btn_brow_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if(op.ShowDialog()==DialogResult.OK)
            {
                txt_name.Text = op.FileName.ToString();
                
            }
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Trim() != "")
            {
                try
                {
                    RESTORE_BACKUP.RESTORE(txt_name.Text);
                    MessageBox.Show("Phuc hoi thanh cong!");
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
