using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;
using System.Xml.Linq;

namespace PIHMS.CL.BL.Staff.TestApp
{
    internal class cls_Test_get_StaffDocuments_BL
    {
        String m_DBConnStr;
        public cls_Test_get_StaffDocuments_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_Staff bl = new BL_Staff();

            get_StaffDocuments_IP ip = new get_StaffDocuments_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 52;

            get_StaffDocuments_OP op = new get_StaffDocuments_OP();

            //RUN
            bl.get_StaffDocuments(ref ip, ref op);

            // Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
               
                    if (op.ml_StaffMyDocuments.Count > 0)
                    {
                        Result += " ROW FETCHED, ";
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
            BL_Staff bl = new BL_Staff();

            get_StaffDocuments_IP ip = new get_StaffDocuments_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 52;

            get_StaffDocuments_OP op = new get_StaffDocuments_OP();

            //RUN
            bl.get_StaffDocuments(ref ip, ref op);

            //VALIDATE
            if (op.ReturnValue == 0)
            {

                if (op.ml_StaffMyDocuments.Count > 0)
                {
                    foreach (var staffDocuments in op.ml_StaffMyDocuments)
                    {
                        // Display staff details in the console
                        Console.WriteLine($"Staff ID: {staffDocuments.StaffID}"); 
                        Console.WriteLine($"Staff DocumnetType: {staffDocuments.DocumnetType}");
                        Console.WriteLine($"Staff DocDateTime: {staffDocuments.DocDateTime}");
                        // Add more properties as needed
                    }  
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


        public String SC_003()
        {
            String Result = "";
            //PREPARE
            BL_Staff bl = new BL_Staff();

            get_StaffDocuments_IP ip = new get_StaffDocuments_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 521;

            get_StaffDocuments_OP op = new get_StaffDocuments_OP();

            //RUN
            bl.get_StaffDocuments(ref ip, ref op);

            // Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";

                if (op.ml_StaffMyDocuments.Count > 0)
                {
                    

                    foreach (var staffDocuments in op.ml_StaffMyDocuments)
                    {
                        Console.WriteLine("ROW FETCHED," + " " + "TEST RESULT PASS");
                        // Display staff details in the console
                        Console.WriteLine($"Staff ID: {staffDocuments.StaffID}");
                        Console.WriteLine($"Staff DocumnetType: {staffDocuments.DocumnetType}");
                        Console.WriteLine($"Staff DocDateTime: {staffDocuments.DocDateTime}");
                        // Add more properties as needed
                    }
                }
                else
                {
                    Result += "INPUT ID IS NOT CORRECT, ";
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

    }
}