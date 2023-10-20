using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

using PIHMS.CL.API.IO.Housekeeping;
using PIHMS.CL.BL.Housekeeping;
using System.Text.Json;

namespace PIHMS.CL.BL.Housekeeping.TestApp
{
    internal class cls_Test_put_HousekeepingAssignmentTasks_BL
    {
        String m_DBConnStr;
        public cls_Test_put_HousekeepingAssignmentTasks_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001(String JsonFile)
        {
            String Result = "";
            //PREPARE
            BL_Housekeeping bl = new BL_Housekeeping();

            string jsondata = File.ReadAllText(JsonFile);
            put_HousekeepingAssignmentTasks_IP ip = JsonSerializer.Deserialize<put_HousekeepingAssignmentTasks_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;


            put_HousekeepingAssignmentTasks_OP op = new put_HousekeepingAssignmentTasks_OP();

            //RUN
            bl.put_HousekeepingAssignmentTasks(ref ip, ref op);

            //VALIDATE

            return Result;
        }
        public String SC_002(String JsonFile)
        {
            String Result = "";
            //PREPARE
            BL_Housekeeping bl = new BL_Housekeeping();

            string jsondata = File.ReadAllText(JsonFile);
            put_HousekeepingAssignmentTasks_IP ip = JsonSerializer.Deserialize<put_HousekeepingAssignmentTasks_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;


            put_HousekeepingAssignmentTasks_OP op = new put_HousekeepingAssignmentTasks_OP();

            //RUN
            bl.put_HousekeepingAssignmentTasks(ref ip, ref op);

            //VALIDATE
            return Result;
        }

    }
}




