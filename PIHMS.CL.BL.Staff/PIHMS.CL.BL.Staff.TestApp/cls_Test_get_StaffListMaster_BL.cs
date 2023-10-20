
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
    internal class cls_Test_get_StaffListMaster_BL
    {
        String m_DBConnStr;
        public cls_Test_get_StaffListMaster_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_Staff bl = new BL_Staff();

            get_StaffListMaster_IP ip = new get_StaffListMaster_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_pageName ="shru";

            get_StaffListMaster_OP op = new get_StaffListMaster_OP();

            //RUN
            bl.get_StaffListMaster(ref ip, ref op);

            // Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
               
                    if (op.ml_FeatureSetting.Count > 0)
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

            get_StaffListMaster_IP ip = new get_StaffListMaster_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_pageName = "shru";


            get_StaffListMaster_OP op = new get_StaffListMaster_OP();

            //RUN
            bl.get_StaffListMaster(ref ip, ref op);

            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";

                if (op.ml_FeatureSetting.Count > 0)
                {
                    foreach (var staffList in op.ml_FeatureSetting)
                    {
                        // Display staff details in the console
                        Console.WriteLine($"Staff AppFeatureID: {staffList.AppFeatureID}");
                        Console.WriteLine($"Staff ViewName: {staffList.FeatureViewName}");
                        Console.WriteLine($"Staff Setting: {staffList.SettingType}");
                        // Add more properties as needed
                    }

                    // Console.WriteLine(op.ml_FeatureSetting);
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

            get_StaffListMaster_IP ip = new get_StaffListMaster_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_pageName = "sh";


            get_StaffListMaster_OP op = new get_StaffListMaster_OP();

            //RUN
            bl.get_StaffListMaster(ref ip, ref op);

            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";

                if (op.ml_FeatureSetting.Count > 0)
                {
                    foreach (var staffList in op.ml_FeatureSetting)
                    {

                        Console.WriteLine("ROW FETCHED," + " " + "TEST RESULT PASS");
                        // Display staff details in the console
                        Console.WriteLine($"Staff AppFeatureID: {staffList.AppFeatureID}");
                        Console.WriteLine($"Staff ViewName: {staffList.FeatureViewName}");
                        Console.WriteLine($"Staff Setting: {staffList.SettingType}");
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