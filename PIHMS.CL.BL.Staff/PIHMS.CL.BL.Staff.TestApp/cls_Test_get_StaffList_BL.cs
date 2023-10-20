
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
    internal class cls_Test_get_StaffList_BL
    {
        String m_DBConnStr;
        public cls_Test_get_StaffList_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_Staff bl = new BL_Staff();

            get_StaffList_IP ip = new get_StaffList_IP();
            ip.UserDBConnStr = m_DBConnStr;
            //ip.m_Filter.m_Limit ="10";
            ip.m_FilterOptions.m_ID = 652;

            get_StaffList_OP op = new get_StaffList_OP();

            //RUN
            bl.get_StaffList(ref ip, ref op);

            // Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
                
                    if (op.ml_StaffList.Count>0)
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

            get_StaffList_IP ip = new get_StaffList_IP();
            ip.UserDBConnStr = m_DBConnStr;
           // ip.m_Filter.m_Limit = "10";
           ip.m_FilterOptions.m_ID = 652;



            get_StaffList_OP op = new get_StaffList_OP();

            //RUN
            bl.get_StaffList(ref ip, ref op);

            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";

                if (op.ml_StaffList.Count > 0)
                {
                    foreach (var staffList in op.ml_StaffList)
                    {
                        Console.WriteLine("ROW FETCHED," + " " + "TEST RESULT PASS");
                        // Display staff details in the console
                        Console.WriteLine($"Staff AppFeatureID: {staffList.StaffNumber}");
                        Console.WriteLine($"Staff ViewName: {staffList.DisplayName}");
                        Console.WriteLine($"Staff Setting: {staffList.Gender}");
                        // Add more properties as needed
                    }

                    // Console.WriteLine(op.ml_FeatureSetting);
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

            get_StaffList_IP ip = new get_StaffList_IP();
            ip.UserDBConnStr = m_DBConnStr;
            // ip.m_Filter.m_Limit = "10";
            ip.m_FilterOptions.m_ID = 16581322;



            get_StaffList_OP op = new get_StaffList_OP();

            //RUN
            bl.get_StaffList(ref ip, ref op);

            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";

                if (op.ml_StaffList.Count > 0)
                {
                    foreach (var staffList in op.ml_StaffList)
                    {
                        Console.WriteLine("ROW FETCHED," + " " + "TEST RESULT PASS");
                        // Display staff details in the console
                        Console.WriteLine($"Staff AppFeatureID: {staffList.StaffNumber}");
                        Console.WriteLine($"Staff ViewName: {staffList.DisplayName}");
                        Console.WriteLine($"Staff Setting: {staffList.Gender}");
                        // Add more properties as needed
                    }

                    // Console.WriteLine(op.ml_FeatureSetting);
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
