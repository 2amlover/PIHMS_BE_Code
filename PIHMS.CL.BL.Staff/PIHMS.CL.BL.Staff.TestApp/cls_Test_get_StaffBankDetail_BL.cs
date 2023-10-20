using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.Staff.TestApp
{
    internal class cls_Test_get_StaffBankDetail_BL
    {
        String m_DBConnStr;
        public cls_Test_get_StaffBankDetail_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_Staff bl = new BL_Staff();

            get_StaffBankDetail_IP ip = new get_StaffBankDetail_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 705;

            get_StaffBankDetail_OP op = new get_StaffBankDetail_OP();

            //RUN
            bl.get_StaffBankDetail(ref ip, ref op);

            // Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
               
          
                    if (op.ml_Staffbankdetail.Count > 0)
                    {
                        Result += " ROW FETCHED,";
                        Result += "TEST RESULT = PASS.";
                    }
                    else
                    {
                        Result += " ROW NOT FETCHED";
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

            get_StaffBankDetail_IP ip = new get_StaffBankDetail_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 0;

            get_StaffBankDetail_OP op = new get_StaffBankDetail_OP();

            //RUN
            bl.get_StaffBankDetail(ref ip, ref op);

            // Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";


                if (op.ml_Staffbankdetail.Count > 0)
                {
                          
                    foreach (var staffBankDetail in op.ml_Staffbankdetail)
                    {

                        Console.WriteLine("ROW FETCHED," + " " + "TEST RESULT PASS");
                        // Display staff details in the console
                        Console.WriteLine($"Staff ID: {staffBankDetail.StaffID}");
                        Console.WriteLine($"Staff Name: {staffBankDetail.StaffName}");
                        Console.WriteLine($"Staff BankName: {staffBankDetail.BankName}");
                        Console.WriteLine($"Staff BankIFSCCode: {staffBankDetail.BankIFSCCode}");
                        Console.WriteLine($"Staff BankAccountNumber: {staffBankDetail.BankAccountNumber}");
                        Console.WriteLine($"Staff PANCardNumber: {staffBankDetail.PANCardNumber}");
                        // Add more properties as needed 
                    }
                }
                else
                {
                    Result += " CHECK THE INPUT ID";
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

            get_StaffBankDetail_IP ip = new get_StaffBankDetail_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 705;

            get_StaffBankDetail_OP op = new get_StaffBankDetail_OP();

            //RUN
            bl.get_StaffBankDetail(ref ip, ref op);

            // Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                if (op.ml_Staffbankdetail.Count > 0)
                {
                    foreach (var staffBankDetail in op.ml_Staffbankdetail)
                    {
                        // Display staff details in the console
                        Console.WriteLine($"Staff ID: {staffBankDetail.StaffID}");
                        Console.WriteLine($"Staff Name: {staffBankDetail.StaffName}");
                        Console.WriteLine($"Staff BankName: {staffBankDetail.BankName}");
                        Console.WriteLine($"Staff BankIFSCCode: {staffBankDetail.BankIFSCCode}");
                        Console.WriteLine($"Staff BankAccountNumber: {staffBankDetail.BankAccountNumber}");
                        Console.WriteLine($"Staff PANCardNumber: {staffBankDetail.PANCardNumber}");
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
    }
}
