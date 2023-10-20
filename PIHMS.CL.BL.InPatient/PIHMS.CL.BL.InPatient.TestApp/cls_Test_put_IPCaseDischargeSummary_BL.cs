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

using PIHMS.CL.API.IO.InPatient;
using PIHMS.CL.BL.InPatient;
using System.Text.Json;

namespace PIHMS.CL.BL.InPatient.TestApp
{
    internal class cls_Test_put_IPCaseDischargeSummary_BL
    {
        String m_DBConnStr;
        public cls_Test_put_IPCaseDischargeSummary_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001(string JsonFile)
        {

            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            string jsondata = File.ReadAllText(JsonFile);
            put_IPCaseDischargeSummary_IP ip = JsonSerializer.Deserialize<put_IPCaseDischargeSummary_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;

            put_IPCaseDischargeSummary_OP op = new put_IPCaseDischargeSummary_OP();

            //RUN
            bl.put_IPCaseDischargeSummary(ref ip, ref op);



            return Result;

        }
        public String SC_002(string JsonFile)
        {

            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            string jsondata = File.ReadAllText(JsonFile);
            put_IPCaseDischargeSummary_IP ip = JsonSerializer.Deserialize<put_IPCaseDischargeSummary_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;

            put_IPCaseDischargeSummary_OP op = new put_IPCaseDischargeSummary_OP();

            //RUN
            bl.put_IPCaseDischargeSummary(ref ip, ref op);



            return Result;

        }

    }
}



