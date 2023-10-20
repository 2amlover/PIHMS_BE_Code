
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;


namespace PIHMS.CL.BL.OPBilling.TestApp
    {
        internal class cls_Test_get_NewOPBillListMaster_BL
        {
            String m_DBConnStr;
            public cls_Test_get_NewOPBillListMaster_BL(String dbCon)
            {
                m_DBConnStr = dbCon;
            }


            public String SC_001()
            {
                String Result = "";
               // PREPARE
                BL_OPBilling bl = new BL_OPBilling();

            get_OPBillListMaster_IP ip = new get_OPBillListMaster_IP();
                ip.UserDBConnStr = m_DBConnStr;
                ip.m_pageName = "shru";

            get_OPBillListMaster_OP op = new get_OPBillListMaster_OP();

              //  RUN
                bl.get_OPBillListMaster(ref ip, ref op);

                
              //  VALIDATE
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
            // PREPARE
            BL_OPBilling bl = new BL_OPBilling();

            get_OPBillListMaster_IP ip = new get_OPBillListMaster_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_pageName = "shru";

            get_OPBillListMaster_OP op = new get_OPBillListMaster_OP();

            //  RUN
            bl.get_OPBillListMaster(ref ip, ref op);


            //  VALIDATE
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
            // PREPARE
            BL_OPBilling bl = new BL_OPBilling();

            get_OPBillListMaster_IP ip = new get_OPBillListMaster_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_pageName = "shr";

            get_OPBillListMaster_OP op = new get_OPBillListMaster_OP();

            //  RUN
            bl.get_OPBillListMaster(ref ip, ref op);


            //  VALIDATE
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





