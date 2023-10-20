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
using System.Text.Json;

namespace PIHMS.CL.BL.Patient.TestApp
{
    internal class cls_Test_put_PatientHistory_BL
    {
        String m_DBConnStr;
        public cls_Test_put_PatientHistory_BL(String dbCon)
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
            put_PatientHistory_IP ip = JsonSerializer.Deserialize<put_PatientHistory_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;
            //ip.m_Patient.ID = 1;

            put_PatientHistory_OP op = new put_PatientHistory_OP();

            //RUN
            bl.put_PatientHistory(ref ip, ref op);

            return Result;
        }
        //Test case for update
        public String SC_002(string data)
        {
            String Result = "";
            //PREPARE
            BL_Patient bl = new BL_Patient();

            string jsondata = File.ReadAllText(data);
            put_PatientHistory_IP ip = JsonSerializer.Deserialize<put_PatientHistory_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;
            //ip.m_Patient.ID = 1;

            put_PatientHistory_OP op = new put_PatientHistory_OP();

            //RUN
            bl.put_PatientHistory(ref ip, ref op);

            return Result;
        }
    }
}