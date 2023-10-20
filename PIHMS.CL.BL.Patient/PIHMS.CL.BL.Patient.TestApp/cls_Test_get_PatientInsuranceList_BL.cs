
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

namespace PIHMS.CL.BL.Patient.TestApp
{
    internal class cls_Test_get_PatientInsuranceList_BL
    {
        String m_DBConnStr;
        public cls_Test_get_PatientInsuranceList_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_Patient bl = new BL_Patient();

            get_PatientInsuranceList_IP ip = new get_PatientInsuranceList_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_PatientID = 10555;

            get_PatientInsuranceList_OP op = new get_PatientInsuranceList_OP();

            //RUN
            bl.get_PatientInsuranceList(ref ip, ref op);

            // Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";

                if (op.ml_PatientInsurance.Count > 0)
                {
                    Result += " ROW FETCHED, " + " ";
                    Result += "TEST RESULT = PASS.";
                }
                else
                {
                    Result += " ROW FETCHED, ";
                    Result += "TEST RESULT = WARNING.";
                    return Result;
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

            get_PatientInsuranceList_IP ip = new get_PatientInsuranceList_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_PatientID = 10555;
            ip.m_Limit = "10";

            get_PatientInsuranceList_OP op = new get_PatientInsuranceList_OP();

            //RUN
            bl.get_PatientInsuranceList(ref ip, ref op);

            //   Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                if (op.ml_PatientInsurance.Count > 0)
                {
                    foreach (var patientinsurance in op.ml_PatientInsurance)
                    {
                        Console.WriteLine("ROW FETCHED, TEST RESULT = PASS.");
                        Console.WriteLine($"Patient Number: {patientinsurance.InsurerNameAsInPolicy}");
                        Console.WriteLine($"Patient Name: {patientinsurance.InsuranceProviderName}");
                        // Add more properties as needed
                    }
                }
                else
                {
                    Result += " ROW FETCHED, ";
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

            get_PatientInsuranceList_IP ip = new get_PatientInsuranceList_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_PatientID = 10557;
            ip.m_OrderBy = "DESC";

            get_PatientInsuranceList_OP op = new get_PatientInsuranceList_OP();

            //RUN
            bl.get_PatientInsuranceList(ref ip, ref op);

            //  Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                if (op.ml_PatientInsurance.Count > 0)
                {
                    foreach (var patientinsurance in op.ml_PatientInsurance)
                    {
                        Console.WriteLine("ROW FETCHED, TEST RESULT = PASS.");
                        Console.WriteLine($"Patient Number: {patientinsurance.InsurerNameAsInPolicy}");
                        Console.WriteLine($"Patient Name: {patientinsurance.InsuranceProviderName}");
                        // Add more properties as needed
                    }
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

