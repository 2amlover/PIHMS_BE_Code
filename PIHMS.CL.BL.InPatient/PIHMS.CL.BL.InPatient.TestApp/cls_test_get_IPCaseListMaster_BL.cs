using PIHMS.CL.API.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIHMS.CL.BL.InPatient.TestApp
{
    internal class cls_test_get_IPCaseListMaster_BL
    {
        String m_DBConnStr;
        public cls_test_get_IPCaseListMaster_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }

        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseListMaster_IP ip = new get_IPCaseListMaster_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_pageName="";

            get_IPCaseListMaster_OP op = new get_IPCaseListMaster_OP();

            //RUN
            bl.get_IPCaseListMaster(ref ip, ref op);

            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
                if (op.ml_FeatureSetting.Count > 0)
                {
                    for(int i=0;i<op.ml_FeatureSetting.Count;i++)
                    {
                        Result = op.ml_FeatureSetting[i].IsRowDeleted;
                    }
                }
                else
                {
                   Result= "TEST RESULT = WARNING.";
                }
            }
            return Result;
        }

    }
}
    

