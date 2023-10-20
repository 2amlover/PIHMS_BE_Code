﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

using PIHMS.CL.API.IO.Finance;
using PIHMS.CL.BL.Finance;

namespace PIHMS.CL.BL.Finance.TestApp
{
    internal class cls_Test_get_AccountPOItems_BL
    {
        String m_DBConnStr;
        public cls_Test_get_AccountPOItems_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_Finance bl = new BL_Finance();

            get_AccountPOItems_IP ip = new get_AccountPOItems_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_Filter.m_Limit = "10";

            get_AccountPOItems_OP op = new get_AccountPOItems_OP();

            //RUN
            bl.get_AccountPOItems(ref ip, ref op);

            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
                if (op.ml_Finance.Count == 10)
                {
                    Result += "10 ROWS FETCHED, ";
                    Result += "TEST RESULT = PASS.";
                }
                else
                {
                    Result += op.ml_Finance.Count.ToString() + " ROWS FETCHED, ";
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

