﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

using PIHMS.CL.API.IO.Diagnostic;
using PIHMS.CL.BL.Diagnostic;

namespace PIHMS.CL.BL.Diagnostic.TestApp
{
    internal class cls_test_get_DiagTestPlanList
    {
        String m_DBConnStr;
        public cls_test_get_DiagTestPlanList(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_Diagnostic bl = new BL_Diagnostic();

            get_DiagTestPlanList_IP ip = new get_DiagTestPlanList_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_Filter.m_Limit = "10";

            get_DiagTestPlanList_OP op = new get_DiagTestPlanList_OP();

            //RUN
            bl.get_DiagTestPlanList(ref ip, ref op);

            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
                if (op.ml_Diag.Count == 10)
                {
                    Result += "10 ROWS FETCHED, ";
                    Result += "TEST RESULT = PASS.";
                }
                else
                {
                    Result += op.ml_Diag.Count.ToString() + " ROWS FETCHED, ";
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



