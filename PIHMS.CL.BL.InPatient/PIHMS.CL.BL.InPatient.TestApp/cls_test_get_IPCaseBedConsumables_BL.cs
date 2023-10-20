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
    internal class cls_test_get_IPCaseBedConsumables_BL
    {
        String m_DBConnStr;
        public cls_test_get_IPCaseBedConsumables_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }

        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseBedConsumables_IP ip = new get_IPCaseBedConsumables_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_IPCaseID = 11328;

            get_IPCaseBedConsumables_OP op = new get_IPCaseBedConsumables_OP();

            //RUN
            bl.get_IPCaseBedConsumables(ref ip, ref op);

            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
                if (op.m_IPCase.ID >0)
                {
                    Result += " ROW FETCHED, ";
                    // Result += "TEST RESULT = PASS.";
                    Result += op.m_IPCase.Name;
                }
                else
                {
                   // Result += op.m_IPCase.ID + " ROW FETCHED, ";
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


        public String SC_002()
        {
            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseBedConsumables_IP ip = new get_IPCaseBedConsumables_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_IPCaseID = 11328;


            get_IPCaseBedConsumables_OP op = new get_IPCaseBedConsumables_OP();

            //RUN
            bl.get_IPCaseBedConsumables(ref ip, ref op);


            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";

                if (op.ml_IPCaseConsumeable.Count > 0)

                {
                    foreach (var m_IPCaaseConsumeabal in op.ml_IPCaseConsumeable)
                    {
                        Result = " ROW FETCHED, " + " " + m_IPCaaseConsumeabal.ConsumableItemName + " ";
                    }
                }
                else
                {
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





