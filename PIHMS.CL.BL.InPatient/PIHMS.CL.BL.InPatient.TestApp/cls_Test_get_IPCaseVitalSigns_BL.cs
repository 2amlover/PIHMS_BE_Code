using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

using PIHMS.CL.API.IO.InPatient;
using PIHMS.CL.BL.InPatient;

namespace PIHMS.CL.BL.InPatient.TestApp
{
    internal class cls_Test_get_IPCaseVitalSigns_BL
    {
        String m_DBConnStr;
        public cls_Test_get_IPCaseVitalSigns_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseVitalSigns_IP ip = new get_IPCaseVitalSigns_IP();
            ip.UserDBConnStr = m_DBConnStr;
            //ip.m_IPCaseID = 6479;
            ip.m_IPCaseID = 6962;


            get_IPCaseVitalSigns_OP op = new get_IPCaseVitalSigns_OP();

            //RUN

            bl.get_IPCaseVitalSigns(ref ip, ref op);
            Console.WriteLine(op.m_IPCase.IPCaseNumber);
           Console.WriteLine(op.ml_IPCaseVitalsigns[0].IPCaseID);


            return Result;
        }

        public string SC_002()
        {
            string Result = "";

            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseVitalSigns_IP ip = new get_IPCaseVitalSigns_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_IPCaseID = 6962;

            get_IPCaseVitalSigns_OP op = new get_IPCaseVitalSigns_OP();

            //RUN
            bl.get_IPCaseVitalSigns(ref ip, ref op);

            if (op.ml_IPCaseVitalsigns.Count > 0)
            {

                Result = "BPSystolic value: " + op.ml_IPCaseVitalsigns[0].BPSystolic;
                for (int i = 0; i < op.ml_IPCaseVitalsigns.Count; i++)
                {
                    Console.WriteLine(op.ml_IPCaseVitalsigns[i].ID);
                }
            }
            else
            {

                Result = "No IPCaseVitalsigns found";
            }

            return Result;
        }
    }
}
