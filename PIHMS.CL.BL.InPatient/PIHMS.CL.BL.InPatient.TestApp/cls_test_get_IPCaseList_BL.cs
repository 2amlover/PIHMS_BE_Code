using PIHMS.CL.API.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIHMS.CL.BL.InPatient.TestApp
{
    internal class cls_test_get_IPCaseList_BL
    {
        String m_DBConnStr;
        public cls_test_get_IPCaseList_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }

        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseList_IP ip = new get_IPCaseList_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_Filter.m_ID = 6962;

            get_IPCaseList_OP op = new get_IPCaseList_OP();

            //RUN
            bl.get_IPCaseList(ref ip, ref op);

            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
                if (op.ml_IPCaseList.Count > 0)
                {
                    for(int i = 0;i<op.ml_IPCaseList.Count;i++) 
                    {
                        Result = op.ml_IPCaseList[i].Address;
                    }
                }
                else
                {
                    Result = "TEST RESULT = WARNING.";
                 
                }
            }

            return Result;
        }

    }
}