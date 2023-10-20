using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

using PIHMS.CL.API.IO.Masters;
using PIHMS.CL.BL.Masters;
using System.Text.Json;

namespace PIHMS.CL.BL.Masters.TestApp
{
    internal class cls_Test_put_MasPayitems_BL
    {
        String m_DBConnStr;
        public cls_Test_put_MasPayitems_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001(String DATAFILE)
        {
            String Result = "";
            //PREPARE
            BL_MasAccount bl = new BL_MasAccount();

            string jsondata = File.ReadAllText(DATAFILE);
            put_MasPayitems_IP ip = JsonSerializer.Deserialize<put_MasPayitems_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;

            put_MasPayitems_OP op = new put_MasPayitems_OP();

            //RUN
            bl.put_MasPayitems(ref ip, ref op);

            //VALIDATE


            return Result;
        }
        public String SC_002(String DATAFILE)
        {
            String Result = "";
            //PREPARE
            BL_MasAccount bl = new BL_MasAccount();

            string jsondata = File.ReadAllText(DATAFILE);
            put_MasPayitems_IP ip = JsonSerializer.Deserialize<put_MasPayitems_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;

            put_MasPayitems_OP op = new put_MasPayitems_OP();

            //RUN
            bl.put_MasPayitems(ref ip, ref op);

            //VALIDATE


            return Result;
        }
    }
}




