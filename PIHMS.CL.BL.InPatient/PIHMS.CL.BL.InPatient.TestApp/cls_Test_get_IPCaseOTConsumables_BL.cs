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
    internal class cls_Test_get_IPCaseOTConsumables_BL
    {
        String m_DBConnStr;
        public cls_Test_get_IPCaseOTConsumables_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseOTConsumables_IP ip = new get_IPCaseOTConsumables_IP();
            ip.UserDBConnStr = m_DBConnStr;
            //ip.m_IPCaseID = 6479;
            ip.m_IPCaseID = 6962;


            get_IPCaseOTConsumables_OP op = new get_IPCaseOTConsumables_OP();

            //RUN

            bl.get_IPCaseOTConsumables(ref ip, ref op);
            Console.WriteLine(op.m_IPCase.IPCaseNumber);
            //  Console.WriteLine(op.ml_IPCaseVitalsigns[0].IPCaseID);


            return Result;
        }

        public string SC_002()
        {
            string Result = "";

            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseOTConsumables_IP ip = new get_IPCaseOTConsumables_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_IPCaseID = 11452;
           // ip.m_IPCaseID = 123;

            get_IPCaseOTConsumables_OP op = new get_IPCaseOTConsumables_OP();

            //RUN
            bl.get_IPCaseOTConsumables(ref ip, ref op);

            if (op.ml_IPCaseConsumeableDetail.Count > 0)
            {

                Result = "Surgery value: " + op.ml_IPCaseConsumeableDetail[0].Surgery;
                for (int i = 0; i < op.ml_IPCaseConsumeableDetail.Count; i++)
                {
                    Console.WriteLine(op.ml_IPCaseConsumeableDetail[i].ID);
                }
            }
            else
            {

                Result = "No IPCaseConsumeableDetail found";
            }

            return Result;
        }
    }
}
