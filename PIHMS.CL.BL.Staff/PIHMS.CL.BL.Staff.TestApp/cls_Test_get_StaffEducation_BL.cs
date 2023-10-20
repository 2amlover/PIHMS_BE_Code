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
    internal class cls_Test_get_StaffEducation_BL
    {
        String m_DBConnStr;
        public cls_Test_get_StaffEducation_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_Staff bl = new BL_Staff();

            get_StaffEducation_IP ip = new get_StaffEducation_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 652;

            get_StaffEducation_OP op = new get_StaffEducation_OP();

            //RUN
            bl.get_StaffEducation(ref ip, ref op);

            Console.WriteLine(op.ml_StaffEducation);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";

                if (op.ml_StaffEducation.Count > 0)
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

            get_StaffEducation_IP ip = new get_StaffEducation_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 652;
         

            get_StaffEducation_OP op = new get_StaffEducation_OP();

            //RUN
            bl.get_StaffEducation(ref ip, ref op);

            Console.WriteLine(op.ml_StaffEducation);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";

                if (op.ml_StaffEducation.Count > 0)
                {
                    foreach (var staffEducation in op.ml_StaffEducation)
                    {
                        // Display staff details in the console
                        Console.WriteLine($"Staff ID: {staffEducation.StaffNumber}");
                        Console.WriteLine($"Staff Name: {staffEducation.CollegeName}");
                        Console.WriteLine($"Staff Name: {staffEducation.Degree}");
                        // Add more properties as needed
                    }

                    Console.WriteLine(op.ml_StaffEducation);
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
        public String SC_003()
        {
            String Result = "";
            //PREPARE
            BL_Staff bl = new BL_Staff();

            get_StaffEducation_IP ip = new get_StaffEducation_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 1234;


            get_StaffEducation_OP op = new get_StaffEducation_OP();

            //RUN
            bl.get_StaffEducation(ref ip, ref op);

            Console.WriteLine(op.ml_StaffEducation);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";

                if (op.ml_StaffEducation.Count > 0)
                {
                    foreach (var staffEducation in op.ml_StaffEducation)
                    {
                        Console.WriteLine("ROW FETCHED," + " " + "TEST RESULT PASS");
                        // Display staff details in the console
                        Console.WriteLine($"Staff ID: {staffEducation.StaffNumber}");
                        Console.WriteLine($"Staff Name: {staffEducation.CollegeName}");
                        Console.WriteLine($"Staff Name: {staffEducation.Degree}");
                        // Add more properties as needed
                    }

                    // Console.WriteLine(op.ml_StaffEducation);
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
