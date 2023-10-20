using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;
using PIHMS.CL.BL.InPatient;

namespace PIHMS.ConsoleApp.API.BL.InPatient.Test
{
    internal class cls_test_get_NewIPCaseMaster_BL
    {
        String m_DBConnStr;
        public cls_test_get_NewIPCaseMaster_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_NewIPCaseMaster_IP ip = new get_NewIPCaseMaster_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_PatientID = 1;

            get_NewIPCaseMaster_OP op = new get_NewIPCaseMaster_OP();

            //RUN
            bl.get_NewIPCaseMaster(ref ip, ref op);

            //VALIDATE
              Console.WriteLine(op.m_Patient.FirstName);
            //Console.WriteLine(op.ml_PatientAddress[0].PatientID);
            //Console.WriteLine(op.ml_PatientInsurance.Count);
            //Console.WriteLine(op.ml_IPCaseAdmittedfor[0].Type);
            return Result;
        }



        public string SC_002()
        {
            string Result = "";

            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_NewIPCaseMaster_IP ip = new get_NewIPCaseMaster_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_PatientID = 9177;

            get_NewIPCaseMaster_OP op = new get_NewIPCaseMaster_OP();

            //RUN
            bl.get_NewIPCaseMaster(ref ip, ref op);

            if (op.ml_PatientInsurance.Count > 0)
            {

                Result = " value: " + op.ml_PatientInsurance.Count;

                for(int i=0; i< op.ml_PatientInsurance.Count;i++)
                {
                    Console.WriteLine(op.ml_PatientInsurance[i].ID);
                }
            }
            else
            {

                Result = "No NewIPCaseMaster found";
            }

            return Result;
        }

    }
}








