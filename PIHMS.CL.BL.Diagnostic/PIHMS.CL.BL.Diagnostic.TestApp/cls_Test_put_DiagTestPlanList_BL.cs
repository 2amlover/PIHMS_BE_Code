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

using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace PIHMS.CL.BL.Diagnostic.TestApp
{
    internal class cls_Test_put_DiagTestPlanList_BL
    {
        String m_DBConnStr;
        public cls_Test_put_DiagTestPlanList_BL(String dbCon)
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
            put_DiagTestPlanList_IP ip = JsonSerializer.Deserialize<put_DiagTestPlanList_IP>(jsonData);
            ip.UserDBConnStr = m_DBConnStr;
            put_DiagTestPlanList_OP op = new put_DiagTestPlanList_OP();

            //RUN
            bl.put_DiagTestPlanList(ref ip, ref op);
            return Result;
        }

        //Test Case for Update
        public String SC_002(String DataFile)
        {
            String Result = "";
            BL_Diagnostic bl = new BL_Diagnostic();
            string jsonData = File.ReadAllText(DataFile);
            put_DiagTestPlanList_IP ip = JsonSerializer.Deserialize<put_DiagTestPlanList_IP>(jsonData);

            ip.UserDBConnStr = m_DBConnStr;

            string updatedJsonData = JsonSerializer.Serialize(ip);
            put_DiagTestPlanList_OP op = new put_DiagTestPlanList_OP();
            File.WriteAllText(DataFile, updatedJsonData);
            bl.put_DiagTestPlanList(ref ip, ref op);
            return Result;
        }


    }
}