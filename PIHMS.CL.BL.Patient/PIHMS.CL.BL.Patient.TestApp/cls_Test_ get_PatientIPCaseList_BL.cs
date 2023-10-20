
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

using PIHMS.CL.API.IO.Patient;
using PIHMS.CL.API.BL.Patient;
using System.ComponentModel.DataAnnotations;

namespace PIHMS.CL.BL.Patient.TestApp
{
    internal class cls_Test_get_PatientIPCaseList_BL
    {
        String m_DBConnStr;
        public cls_Test_get_PatientIPCaseList_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_Patient bl = new BL_Patient();

            get_PatientIPCaseList_IP ip = new get_PatientIPCaseList_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_PatientID = 55112;
            ip.m_Limit = "10";

            get_PatientIPCaseList_OP op = new get_PatientIPCaseList_OP();

            //RUN
            bl.get_PatientIPCaseList(ref ip, ref op);

           // Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
                for (int i = 0; i < op.ml_PatientIPCase.Count; i++)
                {
                    if (op.ml_PatientIPCase[i].ID == 55112)
                    {
                        Result += " ROW FETCHED, " +" " +op.ml_PatientIPCase[i].ID+" ";
                        Result += "TEST RESULT = PASS.";
                    }
                    else
                    {
                        Result += op.ml_PatientIPCase[i].ID + " ROW FETCHED, ";
                        Result += "TEST RESULT = WARNING.";
                        return Result;
                    }
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
            BL_Patient bl = new BL_Patient();

            get_PatientIPCaseList_IP ip = new get_PatientIPCaseList_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_PatientID = 55112;
            ip.m_Limit = "10";

            get_PatientIPCaseList_OP op = new get_PatientIPCaseList_OP();

            //RUN
            bl.get_PatientIPCaseList(ref ip, ref op);

            //   Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                if (op.ml_PatientIPCase.Count > 0)
                {
                    foreach (var IPCase in op.ml_PatientIPCase)
                    {
                        Console.WriteLine("ROW FETCHED, TEST RESULT = PASS.");
                        Console.WriteLine($"Patient Number: {IPCase.PatientNumber}");
                        Console.WriteLine($"Patient Number: {IPCase.Name}");
                        Console.WriteLine($"Patient Name: {IPCase.IPCaseNumber}");
                    }
                    // Add more properties as needed
                }
                else
                {
                    Result += "INPUT ID IS NOT CORRECT, ";
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

        public String SC_003()
        {
            String Result = "";
            //PREPARE
            BL_Patient bl = new BL_Patient();

            get_PatientIPCaseList_IP ip = new get_PatientIPCaseList_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_PatientID = 664;
            ip.m_OrderBy = "DESC";

            get_PatientIPCaseList_OP op = new get_PatientIPCaseList_OP();

            //RUN
            bl.get_PatientIPCaseList(ref ip, ref op);

            //  Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                if (op.ml_PatientIPCase.Count > 0)
                {
                    foreach (var IPCase in op.ml_PatientIPCase)
                    {
                        Console.WriteLine("ROW FETCHED, TEST RESULT = PASS.");
                        Console.WriteLine($"Patient Number: {IPCase.PatientNumber}");
                        Console.WriteLine($"Patient Number: {IPCase.Name}");
                        Console.WriteLine($"Patient Name: {IPCase.IPCaseNumber}");
                    }
                    // Add more properties as needed
                }
                else
                {
                    Result += "INPUT ID IS NOT CORRECT, ";
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
    }
}
