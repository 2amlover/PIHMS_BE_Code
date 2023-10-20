
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
using System.Reflection;
using PIHMS.CL.BL.InPatient;

namespace PIHMS.ConsoleApp.API.BL.InPatient.Test
{
    internal class cls_test_get_IPCaseSignsAndSystems_BL
    {
        String m_DBConnStr;
        public cls_test_get_IPCaseSignsAndSystems_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }

        
        public String SC_001()
        {
           
            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseSignsAndSystems_IP ip = new get_IPCaseSignsAndSystems_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_IPCaseID = 6962;

            get_IPCaseSignsAndSystems_OP op = new get_IPCaseSignsAndSystems_OP();

            //RUN
            bl.get_IPCaseSignsAndSystems(ref ip, ref op);

            //VALIDATE
            Console.WriteLine(op.m_IPCase.ID);
            Console.WriteLine(op.ml_IPCaseSignandsymptoms[0].DepartmentID);


            return Result;
        }

        public String SC_002()
        {
            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseSignsAndSystems_IP ip = new get_IPCaseSignsAndSystems_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_IPCaseID = 24;

            get_IPCaseSignsAndSystems_OP op = new get_IPCaseSignsAndSystems_OP();

            //RUN
            bl.get_IPCaseSignsAndSystems(ref ip, ref op);

            //VALIDATE
          if (op.ml_IPCaseSignandsymptoms.Count > 0 )
            {
                Result = op.ml_IPCaseSignandsymptoms.Count +"  " +"Row Fetched  , Test Reult = Pass" ;

                for (int i = 0; i < op.ml_IPCaseSignandsymptoms.Count; i++)
                {
                    Console.WriteLine("ID : " + op.ml_IPCaseSignandsymptoms[i].ID);
                }
            }

          else
            {
                Result = "No Data Found , Test Reult = Fail";
            }
            return Result;
        }
    }
}








