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
    internal class cls_Test_get_StaffPaySlip_BL
    {
        String m_DBConnStr;
        public cls_Test_get_StaffPaySlip_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_Staff bl = new BL_Staff();

            get_StaffPaySlip_IP ip = new get_StaffPaySlip_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 5;

            get_StaffPaySlip_OP op = new get_StaffPaySlip_OP();

            //RUN
            bl.get_StaffPaySlip(ref ip, ref op);

            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
                
                    if (op.ml_StaffPaySlip.Count > 0)
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

            get_StaffPaySlip_IP ip = new get_StaffPaySlip_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 5;

            get_StaffPaySlip_OP op = new get_StaffPaySlip_OP();

            //RUN
            bl.get_StaffPaySlip(ref ip, ref op);

            //VALIDATE
            if (op.ReturnValue == 0)
            {
                

                if (op.ml_StaffPaySlip.Count > 0)
                {
                    foreach (var staffPaySlip in op.ml_StaffPaySlip)
                    {
                        Console.WriteLine("ROW FETCHED," + " " + "TEST RESULT PASS");
                        // Display staff details in the console
                        Console.WriteLine($"Staff ID: {staffPaySlip.StaffID}");
                        Console.WriteLine($"Staff Name: {staffPaySlip.StaffName}");
                        Console.WriteLine($"Staff BranchID: {staffPaySlip.BranchID}"); 
                        Console.WriteLine($"Staff DaysInMonth: {staffPaySlip.DaysInMonth}");
                        Console.WriteLine($"Staff DaysPresent: {staffPaySlip.DaysPresent}");
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

            get_StaffPaySlip_IP ip = new get_StaffPaySlip_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 599;

            get_StaffPaySlip_OP op = new get_StaffPaySlip_OP();

            //RUN
            bl.get_StaffPaySlip(ref ip, ref op);

            //VALIDATE
            if (op.ReturnValue == 0)
            {


                if (op.ml_StaffPaySlip.Count > 0)
                {
                    foreach (var staffPaySlip in op.ml_StaffPaySlip)
                    {

                        Console.WriteLine("ROW FETCHED," + " " + "TEST RESULT PASS");
                        // Display staff details in the console
                        Console.WriteLine($"Staff ID: {staffPaySlip.StaffID}");
                        Console.WriteLine($"Staff Name: {staffPaySlip.StaffName}");
                        Console.WriteLine($"Staff BranchID: {staffPaySlip.BranchID}");
                        Console.WriteLine($"Staff DaysInMonth: {staffPaySlip.DaysInMonth}");
                        Console.WriteLine($"Staff DaysPresent: {staffPaySlip.DaysPresent}");
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