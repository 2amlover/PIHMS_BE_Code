

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;


namespace PIHMS.CL.BL.OPBilling.TestApp
{
    internal class cls_Test_get_NewOPBillMaster_BL
    {
        String m_DBConnStr;
        public cls_Test_get_NewOPBillMaster_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_OPBilling bl = new BL_OPBilling();

            get_NewOPBillMaster_IP ip = new get_NewOPBillMaster_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_pageName = "OPBillList";
            ip.m_PatientID = 65987;
            ip.m_OPBillDomainID = 5;

            get_NewOPBillMaster_OP op = new get_NewOPBillMaster_OP();

            //RUN
            bl.get_NewOPBillMaster(ref ip, ref op);

            Console.WriteLine(op.ml_NewOPBills);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
                if (op.ml_NewOPBills.Count>0)
                {
                    Result += " ROW FETCHED, ";
                    Result += "TEST RESULT = PASS.";
                }
                else
                {
                    Result += " ROW FETCHED, ";
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




