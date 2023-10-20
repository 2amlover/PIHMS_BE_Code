
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
    internal class cls_Test_get_StaffAttendence_BL
    {
        String m_DBConnStr;
        public cls_Test_get_StaffAttendence_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_Staff bl = new BL_Staff();

            get_StaffAttendence_IP ip = new get_StaffAttendence_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 1234;
            ip.m_StartDate = DateTime.Now;
            ip.m_EndDate = DateTime.Now;
            ip.Get_Type = "Current Week";

            get_StaffAttendence_OP op = new get_StaffAttendence_OP();

            //RUN
            bl.get_StaffAttendence(ref ip, ref op);

            // Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";

                if (op.ml_StaffAttendnce.Count > 0)
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

        public bool SC_002()
        {
            // PREPARE
            BL_Staff bl = new BL_Staff();

            get_StaffAttendence_IP ip = new get_StaffAttendence_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 652; // Replace with the staff ID you want to validate
            ip.m_StartDate = new DateTime(2023, 2, 2);
            ip.m_EndDate = DateTime.Now;


            get_StaffAttendence_OP op = new get_StaffAttendence_OP();

            // RUN
            bl.get_StaffAttendence(ref ip, ref op);



            // VALIDATE
            if (op.ReturnValue == 0)
            {
                if (op.ml_StaffAttendnce.Count > 0)
                {
                    // Staff details retrieved successfully
                    //for (int i = 0; i < op.ml_StaffAttendnce.Count; i++)
                    //    op.ml_StaffAttendnce[i]
                    foreach (var staffDetail in op.ml_StaffAttendnce)
                    {
                        // Display staff details in the console
                        Console.WriteLine($"Staff ID: {staffDetail.StaffID}");
                        Console.WriteLine($"Staff Name: {staffDetail.AttendanceDate}");
                        // Add more properties as needed
                    }
                    return true;
                }
                else
                {
                    // No staff details fetched
                    Console.WriteLine("No staff details found.");
                    return false;
                }
            }
            else if (op.ReturnValue > 0)
            {
                // Ran with warning
                Console.WriteLine($"Warning message: {op.ReturnMessage}");
                return false;
            }
            else
            {
                // Ran with error
                Console.WriteLine($"Error message: {op.ReturnMessage}");
                return false;
            }
        }
        public String SC_003()
        {
            String Result = "";
            //PREPARE
            BL_Staff bl = new BL_Staff();

            get_StaffAttendence_IP ip = new get_StaffAttendence_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 1234;
            //ip.m_StartDate = DateTime.Now;
            //ip.m_EndDate = DateTime.Now;
            ip.Get_Type = "Current Month";

            get_StaffAttendence_OP op = new get_StaffAttendence_OP();

            //RUN
            bl.get_StaffAttendence(ref ip, ref op);

            Console.WriteLine(op.ml_StaffAttendnce);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";

                if (op.ml_StaffAttendnce.Count > 0)
                {
                    foreach (var staffDetail in op.ml_StaffAttendnce)
                    {
                        // Display staff details in the console
                        Console.WriteLine($"Staff ID: {staffDetail.StaffID}");
                        Console.WriteLine($"Staff Name: {staffDetail.AttendanceDate}");
                        // Add more properties as needed
                    }

                    Console.WriteLine(op.ml_StaffAttendnce);
                }
                else
                {
                    Result += " NO ROW FETCHED, ";
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


        public String SC_004()
        {
            String Result = "";
            //PREPARE
            BL_Staff bl = new BL_Staff();

            get_StaffAttendence_IP ip = new get_StaffAttendence_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 123;
            ip.m_StartDate = DateTime.Now;
            ip.m_EndDate = DateTime.Now;
            ip.Get_Type = "Current Week";

            get_StaffAttendence_OP op = new get_StaffAttendence_OP();

            //RUN
            bl.get_StaffAttendence(ref ip, ref op);

            // Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";

                if (op.ml_StaffAttendnce.Count > 0)
                {

                    foreach (var staffDetail in op.ml_StaffAttendnce)
                    {

                        Console.WriteLine("ROW FETCHED," + " "+"TEST RESULT PASS");
                        // Display staff details in the console
                        Console.WriteLine($"Staff ID: {staffDetail.StaffID}");
                        Console.WriteLine($"Staff Name: {staffDetail.AttendanceDate}");
                        // Add more properties as needed
                    }

                }
                
                else
                {
                    Result += "INPUT ID IS NOT CORRECT";
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




