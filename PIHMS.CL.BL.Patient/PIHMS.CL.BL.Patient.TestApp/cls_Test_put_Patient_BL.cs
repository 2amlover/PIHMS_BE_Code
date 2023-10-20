using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;
using PIHMS.CL.API.IO.Patient;
using PIHMS.CL.BL.Patient;
using Microsoft.VisualBasic;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Text.Json;

namespace PIHMS.CL.BL.Patient.TestApp
{
    internal class cls_Test_put_Patient_BL
    {
        String m_DBConnStr;
        public cls_Test_put_Patient_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }



        //Test case for insert
        public String SC_001(string data)
        {
            String Result = "";
            //PREPARE
            BL_Patient bl = new BL_Patient();
            string jsondata = File.ReadAllText(data);
            put_Patient_IP ip = JsonSerializer.Deserialize<put_Patient_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;

            put_Patient_OP op = new put_Patient_OP();
            //RUN
            bl.put_Patient(ref ip, ref op);
            return Result;
        }

        // Test case for update
        public String SC_002(string data)
        {
            String Result = "";
            //PREPARE
            BL_Patient bl = new BL_Patient();
            string jsondata = File.ReadAllText(data);
            put_Patient_IP ip = JsonSerializer.Deserialize<put_Patient_IP>(jsondata);

            ip.UserDBConnStr = m_DBConnStr;

            put_Patient_OP op = new put_Patient_OP();
            //RUN
            bl.put_Patient(ref ip, ref op);
            return Result;
        }

    }
}