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

namespace PIHMS.CL.BL.Masters.TestApp
{
    internal class cls_Test_get_MasMessagingEmailConfiguration_BL
    {
        String m_DBConnStr;
        public cls_Test_get_MasMessagingEmailConfiguration_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_MasAccount bl = new BL_MasAccount();

            get_MasMessagingEmailConfiguration_IP ip = new get_MasMessagingEmailConfiguration_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_Filter.m_Limit = "10";

            get_MasMessagingEmailConfiguration_OP op = new get_MasMessagingEmailConfiguration_OP();

            //RUN
            bl.get_MasMessagingEmailConfiguration(ref ip, ref op);

            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
                if (op.ml_Masters.Count == 10)
                {
                    Result += "10 ROWS FETCHED, ";
                    Result += "TEST RESULT = PASS.";
                }
                else
                {
                    Result += op.ml_Masters.Count.ToString() + " ROWS FETCHED, ";
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




