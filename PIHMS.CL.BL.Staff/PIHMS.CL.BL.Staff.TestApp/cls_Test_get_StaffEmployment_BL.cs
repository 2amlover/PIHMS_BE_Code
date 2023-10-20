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
    internal class cls_Test_get_StaffEmployment_BL
    {
        String m_DBConnStr;
        public cls_Test_get_StaffEmployment_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_Staff bl = new BL_Staff();

            get_StaffEmployment_IP ip = new get_StaffEmployment_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 705;

            get_StaffEmployment_OP op = new get_StaffEmployment_OP();

            //RUN
            bl.get_StaffEmployment(ref ip, ref op);

            // Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
               
                    if (op.ml_StaffEmployment.Count >0)
                    {
                        Result += " ROW FETCHED, ";
                        Result += "TEST RESULT = PASS.";
                    }
                    else
                    {
                        Result +=  " ROW FETCHED, ";
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

            get_StaffEmployment_IP ip = new get_StaffEmployment_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 705;

            get_StaffEmployment_OP op = new get_StaffEmployment_OP();

            //RUN
            bl.get_StaffEmployment(ref ip, ref op);

            // Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                if (op.ml_StaffEmployment.Count > 0)
                {
                    foreach (var staffEmployment in op.ml_StaffEmployment)
                    {
                        // Display staff details in the console
                        Console.WriteLine($"Staff ID: {staffEmployment.StaffID}");
                        Console.WriteLine($"Staff EmployerName: {staffEmployment.Employer}");
                        Console.WriteLine($"Staff WorkingPeriodFrom: {staffEmployment.WorkingPeriodFrom}");
                        Console.WriteLine($"Staff WorkingPeriodTo: {staffEmployment.WorkingPeriodTo}");
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

        //public String SC_003()
        //{
        //    String Result = "";
        //    //PREPARE
        //    BL_Staff bl = new BL_Staff();

        //    get_StaffEmployment_IP ip = new get_StaffEmployment_IP();
        //    ip.UserDBConnStr = m_DBConnStr;
        //    ip.m_StaffID = 705;

        //    get_StaffEmployment_OP op = new get_StaffEmployment_OP();

        //    //RUN
        //    bl.get_StaffEmployment(ref ip, ref op);

        //    // Console.WriteLine(op.ml_PatientOPBill);
        //    //VALIDATE
        //    if (op.ReturnValue == 0)
        //    {
        //        Result += "RAN SUCCESSFULLY, ";

        //        if (op.ml_StaffEmployment.Count > 0)
        //        {
        //            foreach (var WorkingPeriod in op.ml_StaffEmployment)
        //            {
        //                DateTime WorkingPeriodFromDateTime = WorkingPeriod.WorkingPeriodFrom.Value;
        //                DateTime WorkingPeriodToDateTime = WorkingPeriod.WorkingPeriodTo.Value;

        //                TimeSpan WorkingPeriodFrom = WorkingPeriodFromDateTime.TimeOfDay;
        //                TimeSpan WorkingPeriodTo = WorkingPeriodToDateTime.TimeOfDay;
        //                TimeSpan difference = WorkingPeriodTo - WorkingPeriodFrom;
        //                Console.WriteLine("Working period: {0} hours, {1} minutes, {2} seconds",
        //                    difference.Hours, difference.Minutes, difference.Seconds);
                       
        //            }
        //            Result += " ROW FETCHED, ";
        //            Result += "TEST RESULT = PASS.";
        //        }
        //        else
        //        {
        //            Result += " ROW FETCHED, ";
        //            Result += "TEST RESULT = WARNING.";
        //            return Result;
        //        }

        //    }

        //    if (op.ReturnValue > 0)
        //    {
        //        Result += "RAN WITH WARNING, ";
        //        Result += "WARNING MESSAGE = " + op.ReturnMessage;
        //    }

        //    if (op.ReturnValue < 0)
        //    {
        //        Result += "RAN WITH ERROR, ";
        //        Result += "ERROR MESSAGE = " + op.ReturnMessage;
        //    }


        //    return Result;
        //}

        public String SC_003()
        {
            String Result = "";
            //PREPARE
            BL_Staff bl = new BL_Staff();

            get_StaffEmployment_IP ip = new get_StaffEmployment_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 7055;

            get_StaffEmployment_OP op = new get_StaffEmployment_OP();

            //RUN
            bl.get_StaffEmployment(ref ip, ref op);

            // Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                if (op.ml_StaffEmployment.Count > 0)
                {
                    foreach (var staffEmployment in op.ml_StaffEmployment)
                    {
                        Console.WriteLine("ROW FETCHED," + " " + "TEST RESULT PASS");
                        // Display staff details in the console
                        Console.WriteLine($"Staff ID: {staffEmployment.StaffID}");
                        Console.WriteLine($"Staff EmployerName: {staffEmployment.Employer}");
                        Console.WriteLine($"Staff WorkingPeriodFrom: {staffEmployment.WorkingPeriodFrom}");
                        Console.WriteLine($"Staff WorkingPeriodTo: {staffEmployment.WorkingPeriodTo}");
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