

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

using PIHMS.CL.API.IO.Inventory;
using PIHMS.CL.BL.Inventory;
using System.Text.Json;

namespace PIHMS.CL.BL.Inventory.TestApp
{
    internal class cls_Test_put_InvTypes_BL
    {
        String m_DBConnStr;
        public cls_Test_put_InvTypes_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }

        //Test Case for Insert
        public String SC_001(String DataFile)
        {
            String Result = "";
            //PREPARE
            BL_Inventory bl = new BL_Inventory();

            String jsonData = File.ReadAllText(DataFile);
            put_InvTypes_IP ip = JsonSerializer.Deserialize<put_InvTypes_IP>(jsonData);
            ip.UserDBConnStr = m_DBConnStr;
            put_InvTypes_OP op = new put_InvTypes_OP();

            //RUN
            bl.put_InvTypes(ref ip, ref op);
            return Result;
        }

        //Test Case for Update
        public String SC_002(String DataFile)
        {
            String Result = "";
            BL_Inventory bl = new BL_Inventory();
            string jsonData = File.ReadAllText(DataFile);
            put_InvTypes_IP ip = JsonSerializer.Deserialize<put_InvTypes_IP>(jsonData);

            ip.UserDBConnStr = m_DBConnStr;

            string updatedJsonData = JsonSerializer.Serialize(ip);
            put_InvTypes_OP op = new put_InvTypes_OP();
            File.WriteAllText(DataFile, updatedJsonData);
            bl.put_InvTypes(ref ip, ref op);
            return Result;
        }


    }
}

