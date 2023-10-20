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
using Org.BouncyCastle.Utilities;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Xml.Linq;
using System.Text.Json;

namespace PIHMS.CL.BL.Diagnostic.TestApp
{
    internal class cls_Test_put_ScannedReports_BL
    {
        String m_DBConnStr;
        public cls_Test_put_ScannedReports_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        //Test Case for Insert
        public String SC_001(String DataFile)
        {
            String Result = "";
            //PREPARE
            BL_Diagnostic bl = new BL_Diagnostic();

            String jsonData = File.ReadAllText(DataFile);
            put_ScannedReports_IP ip = JsonSerializer.Deserialize<put_ScannedReports_IP>(jsonData);
            ip.UserDBConnStr = m_DBConnStr;
            put_ScannedReports_OP op = new put_ScannedReports_OP();

            //RUN
            bl.put_ScannedReports(ref ip, ref op);
            return Result;
        }

        //Test Case for Update
        public String SC_002(String DataFile)
        {
            String Result = "";
            //PREPARE
            BL_Diagnostic bl = new BL_Diagnostic();

            String jsonData = File.ReadAllText(DataFile);
            put_ScannedReports_IP ip = JsonSerializer.Deserialize<put_ScannedReports_IP>(jsonData);
            ip.UserDBConnStr = m_DBConnStr;
            put_ScannedReports_OP op = new put_ScannedReports_OP();

            //RUN
            bl.put_ScannedReports(ref ip, ref op);
            return Result;
        }


    }
}