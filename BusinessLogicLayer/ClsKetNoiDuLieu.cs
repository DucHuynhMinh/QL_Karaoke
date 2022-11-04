using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ClsKetNoiDuLieu
    {
        
        public string KetNoiDuLieu()
        {
            string sChuoiKetNoi = @"Server=DESKTOP-CPMAR3K;AttachDbFilename=|DataDirectory|\QLQuanKaraoke_Data.mdf;Trusted_Connection=Yes;Integrated Security=True";
            return sChuoiKetNoi;
        }
    }
}
