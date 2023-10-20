using System;
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
using Org.BouncyCastle.Utilities;
//using System.Finance.Metrics;
using System.Reflection;
using System.Xml.Linq;
using System.Text.Json;

namespace PIHMS.CL.BL.Finance.TestApp
{
    internal class cls_Test_put_RelPayables_BL
    {
        String m_DBConnStr;
        public cls_Test_put_RelPayables_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        //Test Case for Insert
        public String SC_001(String DataFile)
        {
            String Result = "";
            //PREPARE
            BL_Finance bl = new BL_Finance();

            String jsonData = File.ReadAllText(DataFile);
            put_RelPayables_IP ip = JsonSerializer.Deserialize<put_RelPayables_IP>(jsonData);
            ip.UserDBConnStr = m_DBConnStr;
            put_RelPayables_OP op = new put_RelPayables_OP();

            //RUN
            bl.put_RelPayables(ref ip, ref op);
            return Result;
        }

        //Test Case for Update
        public String SC_002(String DataFile)
        {
            String Result = "";
            //PREPARE
            BL_Finance bl = new BL_Finance();

            String jsonData = File.ReadAllText(DataFile);
            put_RelPayables_IP ip = JsonSerializer.Deserialize<put_RelPayables_IP>(jsonData);
            ip.UserDBConnStr = m_DBConnStr;
            put_RelPayables_OP op = new put_RelPayables_OP();

            //RUN
            bl.put_RelPayables(ref ip, ref op);
            return Result;
        }



    }
}