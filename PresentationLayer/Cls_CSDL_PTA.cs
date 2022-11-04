using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;
using System.Data;
using System.Data.SqlClient;

namespace PresentationLayer
{
    public class Cls_CSDL_PTA
    {
        Cls_CSDL Backup_Retord = new Cls_CSDL();

        public void Backup(string sFileName)
        {
            Backup_Retord.Backup(sFileName);
        }
        //Download source code FREE tai Sharecode.vn
        public void RESTORE(string sFileName)
        {
            Backup_Retord.Restore(sFileName);
        }
    }
}
