using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

using PIHMS.CL.API.IO.Pharmacy;
using PIHMS.CL.BL.Pharmacy;

namespace PIHMS.CL.BL.Pharmacy.TestApp
{
    internal class cls_Test_put_Pharmacy_BL
    {
        String m_DBConnStr;
        public cls_Test_put_Pharmacy_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }
        //public string CreateIPJSONFile()
        //{
        //    string strJson = "";
        //    try
        //    {
        //        put_Pharmacy_IP put_Pharmacy_IP = new put_Pharmacy_IP();
        //        String strJson1 = JsonSerializer.Serialize<put_Pharmacy_IP>(put_Pharmacy_IP);
        //        Console.WriteLine(strJson1);
        //        File.WriteAllText("put_Pharmacy_IP.json", strJson1);
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.Message;
        //    }
        //    return strJson;
        //}

        //Test case for insert
        public String SC_001(string data)
        {
            String Result = "";
            //PREPARE
            BL_Pharmacy bl = new BL_Pharmacy();
            string jsondata = File.ReadAllText(data);
            put_Pharmacy_IP ip = JsonSerializer.Deserialize<put_Pharmacy_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;

            put_Pharmacy_OP op = new put_Pharmacy_OP();
            //RUN
            bl.put_Pharmacy(ref ip, ref op);
            return Result;
        }

        // Test case for update
        public String SC_002(string data)
        {
            String Result = "";
            //PREPARE
            BL_Pharmacy bl = new BL_Pharmacy();
            string jsondata = File.ReadAllText(data);
            put_Pharmacy_IP ip = JsonSerializer.Deserialize<put_Pharmacy_IP>(jsondata);

            ip.UserDBConnStr = m_DBConnStr;

            put_Pharmacy_OP op = new put_Pharmacy_OP();
            //RUN
            bl.put_Pharmacy(ref ip, ref op);
            return Result;
        }

    }
}
