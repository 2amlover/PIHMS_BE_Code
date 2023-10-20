using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

using PIHMS.CL.API.IO.Communication;
using PIHMS.CL.BL.Communication;
using System.Text.Json;

namespace PIHMS.CL.BL.Communication.TestApp
{
    internal class cls_Test_put_DashboardMail_BL
    {
        String m_DBConnStr;
        public cls_Test_put_DashboardMail_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001(string DataFile)
        {
            String Result = "";
            //PREPARE
            BL_Communication bl = new BL_Communication();
            String jsonData = File.ReadAllText(DataFile);
            put_DashboardMail_IP ip = JsonSerializer.Deserialize<put_DashboardMail_IP>(jsonData);

            ip.UserDBConnStr = m_DBConnStr;

            put_DashboardMail_OP op = new put_DashboardMail_OP();

            //RUN
            bl.put_DashboardMail(ref ip, ref op);

            return Result;
        }
        public String SC_002(string DataFile)
        {
            String Result = "";
            //PREPARE
            BL_Communication bl = new BL_Communication();
            String jsonData = File.ReadAllText(DataFile);
            put_DashboardMail_IP ip = JsonSerializer.Deserialize<put_DashboardMail_IP>(jsonData);

            ip.UserDBConnStr = m_DBConnStr;

            put_DashboardMail_OP op = new put_DashboardMail_OP();

            //RUN
            bl.put_DashboardMail(ref ip, ref op);

            return Result;
        }
    }
}