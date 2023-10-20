

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

using PIHMS.CL.API.IO.Appointment;
using PIHMS.CL.BL.Appointment;
using System.Text.Json;

namespace PIHMS.CL.BL.Appointment.TestApp
{
    internal class cls_Test_put_CalEvent_BL
    {
        String m_DBConnStr;
        public cls_Test_put_CalEvent_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }
       
        
        public String SC_001(string JsonFile)
        {
            String Result = "";
            //PREPARE
            BL_Appointment bl = new BL_Appointment();

          
            string jsondata = File.ReadAllText(JsonFile);
            put_CalEvent_IP ip = JsonSerializer.Deserialize<put_CalEvent_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;
              

            put_CalEvent_OP op = new put_CalEvent_OP();

            //RUN
            bl.put_CalEvent(ref ip, ref op);

            //VALIDATE
             
            

            return Result;
        }
        public String SC_002(string JsonFile)
        {
            String Result = "";
            //PREPARE
            BL_Appointment bl = new BL_Appointment();


            string jsondata = File.ReadAllText(JsonFile);
            put_CalEvent_IP ip = JsonSerializer.Deserialize<put_CalEvent_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;


            put_CalEvent_OP op = new put_CalEvent_OP();

            //RUN
            bl.put_CalEvent(ref ip, ref op);

            //VALIDATE



            return Result;
        }





    }
}


