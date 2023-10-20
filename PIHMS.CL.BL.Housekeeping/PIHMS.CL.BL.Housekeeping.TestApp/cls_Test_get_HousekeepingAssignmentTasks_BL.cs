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

namespace PIHMS.CL.BL.Masters.TestApp
{
    internal class cls_Test_get_HousekeepingAssignmentTasks_BL
    {
        String m_DBConnStr;
        public cls_Test_get_HousekeepingAssignmentTasks_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_Housekeeping bl = new BL_Housekeeping();

            get_HousekeepingAssignmentTasks_IP ip = new get_HousekeepingAssignmentTasks_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_Filter.m_Limit = "10";

            get_HousekeepingAssignmentTasks_OP op = new get_HousekeepingAssignmentTasks_OP();

            //RUN
            bl.get_HousekeepingAssignmentTasks(ref ip, ref op);

            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
                if (op.ml_Housekeeping.Count == 10)
                {
                    Result += "10 ROWS FETCHED, ";
                    Result += "TEST RESULT = PASS.";
                }
                else
                {
                    Result += op.ml_Housekeeping.Count.ToString() + " ROWS FETCHED, ";
                    Result += "TEST RESULT = WARNING.";
                }
            }

            if (op.ReturnValue > 0)
            {
                Result += "RAN WITH WARNING, ";
                Result += "WARNING MESSAGE = " + op.ReturnMessage;
            }

            if (op.ReturnValue < 0)
            {
                Result += "RAN WITH ERROR, ";
                Result += "ERROR MESSAGE = " + op.ReturnMessage;
            }

            return Result;
        }

    }
}




