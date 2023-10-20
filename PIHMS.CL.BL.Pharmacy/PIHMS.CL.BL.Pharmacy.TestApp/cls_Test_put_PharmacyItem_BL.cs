

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

using PIHMS.CL.API.IO.Pharmacy;
using PIHMS.CL.BL.Pharmacy;
using System.Text.Json;

namespace PIHMS.CL.BL.Pharmacy.TestApp
{
    internal class cls_Test_put_PharmacyItem_BL
    {
        String m_DBConnStr;
        public cls_Test_put_PharmacyItem_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        //Test case for insert
        public String SC_001(string data)
        {
            String Result = "";
            //PREPARE
            BL_Pharmacy bl = new BL_Pharmacy();
            string jsondata = File.ReadAllText(data);
            put_PharmacyItem_IP ip = JsonSerializer.Deserialize<put_PharmacyItem_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;

            put_PharmacyItem_OP op = new put_PharmacyItem_OP();
            //RUN
            bl.put_PharmacyItem(ref ip, ref op);
            return Result;
        }

        // Test case for update
        public String SC_002(string data)
        {
            String Result = "";
            //PREPARE
            BL_Pharmacy bl = new BL_Pharmacy();
            string jsondata = File.ReadAllText(data);
            put_PharmacyItem_IP ip = JsonSerializer.Deserialize<put_PharmacyItem_IP>(jsondata);

            ip.UserDBConnStr = m_DBConnStr;

            put_PharmacyItem_OP op = new put_PharmacyItem_OP();
            //RUN
            bl.put_PharmacyItem(ref ip, ref op);
            return Result;
        }

    }
}

