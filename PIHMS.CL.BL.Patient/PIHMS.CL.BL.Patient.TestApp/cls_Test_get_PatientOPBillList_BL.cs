
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
    internal class cls_Test_get_PatientOPBillList_BL
    {
        String m_DBConnStr;
        public cls_Test_get_PatientOPBillList_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_Patient bl = new BL_Patient();

            get_PatientOPBillList_IP ip = new get_PatientOPBillList_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_PatientID = 65986;
            ip.m_Limit = "10";

            get_PatientOPBillList_OP op = new get_PatientOPBillList_OP();

            //RUN
            bl.get_PatientOPBillList(ref ip, ref op);

           // Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
                
                    if (op.ml_PatientOPBill.Count > 0)
                    {
                        Result += " ROW FETCHED, " +" ";
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

            get_PatientOPBillList_IP ip = new get_PatientOPBillList_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_PatientID = 65986;
            //ip.m_OrderBy = "DESC";

            get_PatientOPBillList_OP op = new get_PatientOPBillList_OP();

            //RUN
            bl.get_PatientOPBillList(ref ip, ref op);

          //  Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                    if (op.ml_PatientOPBill.Count > 0)
                    {
                        foreach (var OPBillList in op.ml_PatientOPBill)
                        {
                            Console.WriteLine("ROW FETCHED, TEST RESULT = PASS.");
                            Console.WriteLine($"Patient Number: {OPBillList.PatientNumber}");
                            Console.WriteLine($"Patient Name: {OPBillList.PatientName}");
                            // Add more properties as needed
                        }
                    }
                    else
                    {
                        Result +=  " ROW FETCHED, ";
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

            get_PatientOPBillList_IP ip = new get_PatientOPBillList_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_PatientID = 1253;
            //ip.m_OrderBy = "DESC";

            get_PatientOPBillList_OP op = new get_PatientOPBillList_OP();

            //RUN
            bl.get_PatientOPBillList(ref ip, ref op);

            //  Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            { 
                    if (op.ml_PatientOPBill.Count > 0)
                    {
                        foreach (var OPBillList in op.ml_PatientOPBill)
                        {
                            Console.WriteLine("ROW FETCHED, TEST RESULT = PASS.");
                            Console.WriteLine($"Patient Number: {OPBillList.PatientNumber}");
                            Console.WriteLine($"Patient Name: {OPBillList.PatientName}");
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
