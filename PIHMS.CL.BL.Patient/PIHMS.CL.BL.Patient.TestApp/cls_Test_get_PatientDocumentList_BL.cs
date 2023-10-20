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
    internal class cls_Test_get_PatientDocumentList_BL
    {
        String m_DBConnStr;
        public cls_Test_get_PatientDocumentList_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_Patient bl = new BL_Patient();

            get_PatientDocumentList_IP ip = new get_PatientDocumentList_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_PatientID = 5;

            get_PatientDocumentList_OP op = new get_PatientDocumentList_OP();

            //RUN
            bl.get_PatientDocumentList(ref ip, ref op);

            // Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";

                if (op.ml_PatientDocument.Count > 0)
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

            get_PatientDocumentList_IP ip = new get_PatientDocumentList_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_PatientID = 5;
            ip.m_Limit = "10";

            get_PatientDocumentList_OP op = new get_PatientDocumentList_OP();

            //RUN
            bl.get_PatientDocumentList(ref ip, ref op);

            //   Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                if (op.ml_PatientDocument.Count > 0)
                {
                    foreach (var patientdocument in op.ml_PatientDocument)
                    {
                        Console.WriteLine("ROW FETCHED, TEST RESULT = PASS.");
                        Console.WriteLine($"Patient Number: {patientdocument.DocumentType}");
                        Console.WriteLine($"Patient Name: {patientdocument.DocuemntName}");
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

            get_PatientDocumentList_IP ip = new get_PatientDocumentList_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_PatientID = 6;
            ip.m_OrderBy = "DESC";

            get_PatientDocumentList_OP op = new get_PatientDocumentList_OP ();

            //RUN
            bl.get_PatientDocumentList(ref ip, ref op);

            //  Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                if (op.ml_PatientDocument.Count > 0)
                {
                    foreach (var patientdocument in op.ml_PatientDocument)
                    {
                        Console.WriteLine("ROW FETCHED, TEST RESULT = PASS.");
                        Console.WriteLine($"Patient Number: {patientdocument.DocumentType}");
                        Console.WriteLine($"Patient Name: {patientdocument.DocuemntName}");
                        // Add more properties as needed
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

