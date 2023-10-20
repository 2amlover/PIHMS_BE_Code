




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

using PIHMS.CL.API.IO.InPatient;
using PIHMS.CL.BL.InPatient;
using System.Text.Json;

namespace PIHMS.CL.BL.InPatient.TestApp
{
    internal class cls_Test_put_IPCaseConsumeable_BL
    {
        String m_DBConnStr;
        public cls_Test_put_IPCaseConsumeable_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }

        public String SC_001(string JsonFile)
        {

            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            string jsondata = File.ReadAllText(JsonFile);
            put_IPCaseConsumeable_IP ip = JsonSerializer.Deserialize<put_IPCaseConsumeable_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;

            put_IPCaseConsumeable_OP op = new put_IPCaseConsumeable_OP();

            //RUN
            bl.put_IPCaseConsumeable(ref ip, ref op);



            return Result;

        }
        public String SC_002(string JsonFile)
        {

            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            string jsondata = File.ReadAllText(JsonFile);
            put_IPCaseConsumeable_IP ip = JsonSerializer.Deserialize<put_IPCaseConsumeable_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;

            put_IPCaseConsumeable_OP op = new put_IPCaseConsumeable_OP();

            //RUN
            bl.put_IPCaseConsumeable(ref ip, ref op);



            return Result;

        }

    }
}



