
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;
using PIHMS.CL.BL.InPatient;

namespace PIHMS.ConsoleApp.API.BL.InPatient.Test
{
    internal class cls_test_get_IPCaseMedication_BL
    {
        String m_DBConnStr;
        public cls_test_get_IPCaseMedication_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";                  
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseMedication_IP ip = new get_IPCaseMedication_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_IPCaseID = 3897;

            get_IPCaseMedication_OP op = new get_IPCaseMedication_OP();

            //RUN
            bl.get_IPCaseMedication(ref ip, ref op);

            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
                if (op.ml_clsIPCaseMedication.Count > 0)
                {
                    Result += op.ml_clsIPCaseMedication.Count +" ROWS FETCHED, ";
                    Result += "TEST RESULT = PASS.";
                }
                else
                {
                    Result += " 0 ROWS FETCHED, ";
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








