

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

using PIHMS.CL.API.IO.General;
using PIHMS.CL.BL.General;
using System.Text.Json;

namespace PIHMS.CL.BL.General.TestApp
{
    internal class cls_Test_put_MessagingEmailMessages_BL
    {
        String m_DBConnStr;
        public cls_Test_put_MessagingEmailMessages_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001(string JsonFile)
        {
            String Result = "";
            //PREPARE
            BL_General bl = new BL_General();

            string jsondata = File.ReadAllText(JsonFile);
            put_MessagingEmailMessages_IP ip = JsonSerializer.Deserialize<put_MessagingEmailMessages_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;
              

            put_MessagingEmailMessages_OP op = new put_MessagingEmailMessages_OP();

            //RUN
            bl.put_MessagingEmailMessages(ref ip, ref op);

            //VALIDATE
             
            

            return Result;
        }
        public String SC_002(string JsonFile)
        {
            String Result = "";
            //PREPARE
            BL_General bl = new BL_General();

            string jsondata = File.ReadAllText(JsonFile);
            put_MessagingEmailMessages_IP ip = JsonSerializer.Deserialize<put_MessagingEmailMessages_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;


            put_MessagingEmailMessages_OP op = new put_MessagingEmailMessages_OP();

            //RUN
            bl.put_MessagingEmailMessages(ref ip, ref op);

            //VALIDATE



            return Result;
        }

    }
}


