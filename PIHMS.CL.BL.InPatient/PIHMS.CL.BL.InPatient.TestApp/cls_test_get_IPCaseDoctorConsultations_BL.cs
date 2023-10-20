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
using PIHMS.CL.API.IO.Patient;

namespace PIHMS.ConsoleApp.API.BL.InPatient.Test
{
    internal class cls_test_get_IPCaseDoctorConsultations_BL
    {
        String m_DBConnStr;
        public cls_test_get_IPCaseDoctorConsultations_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }

        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseDoctorConsultations_IP ip = new get_IPCaseDoctorConsultations_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_IPCaseID = 923924;

            get_IPCaseDoctorConsultations_OP op = new get_IPCaseDoctorConsultations_OP();

            //RUN
            bl.get_IPCaseDoctorConsultations(ref ip, ref op);

            //Console.WriteLine(op.m_IPCase);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
                if (op.m_IPCase.ID > 0)
                {
                    //Result += " ROW FETCHED, ";
                    //Result += "TEST RESULT = PASS.";
                    Result += op.m_IPCase.BillNumber;
                }
                else
                {
                   // Result += op.m_IPCase.ID + " ROW FETCHED, ";
                    Result += "TEST RESULT = WARNING.";
                }
            }

            if (op.ReturnValue > 0)
            {
                Result += "RAN WITH WARNING, ";
                Result += "WARNING MESSAGE = " + op.ReturnMessage;
            }

            if (op.ReturnValue < 0)
            {
                Result += "RAN WITH ERROR, ";
                Result += "ERROR MESSAGE = " + op.ReturnMessage;
            }


            return Result;
        }


        public String SC_002()
        {
            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseDoctorConsultations_IP ip = new get_IPCaseDoctorConsultations_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_IPCaseID = 9239;


            get_IPCaseDoctorConsultations_OP op = new get_IPCaseDoctorConsultations_OP();

            //RUN
            bl.get_IPCaseDoctorConsultations(ref ip, ref op);

            // Console.WriteLine(op.m_IPCase);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";

                if (op.ml_IPCaseDoctors.Count > 0)

                {
                    foreach (var m_IPCaseDoctor in op.ml_IPCaseDoctors)
                    {
                        Result += " ROW FETCHED, " + " " + m_IPCaseDoctor.DoctorName+ " ";
                    }
                }
                else
                {
                    Result = "TEST RESULT = WARNING.";
                }

            }


            if (op.ReturnValue > 0)
            {
                Result += "RAN WITH WARNING, ";
                Result += "WARNING MESSAGE = " + op.ReturnMessage;
            }

            if (op.ReturnValue < 0)
            {
                Result += "RAN WITH ERROR, ";
                Result += "ERROR MESSAGE = " + op.ReturnMessage;
            }


            return Result;
        }
    }
}








