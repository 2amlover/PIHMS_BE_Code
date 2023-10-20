
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.IO;
using PIHMS.CL.BL.OPBilling;
using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.OPBilling.TestApp
{
    internal class cls_Test_get_OPBillList_BL
    {
        String m_DBConnStr;
        public cls_Test_get_OPBillList_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_OPBilling bl = new BL_OPBilling();

            get_OPBillList_IP ip = new get_OPBillList_IP();
            ip.UserDBConnStr = m_DBConnStr;
           // ip.m_Filter.PatientID = 9077;
            ip.m_Filter.m_ID = 165814;

            get_OPBillList_OP op = new get_OPBillList_OP();

            //RUN
            bl.get_OPBillList(ref ip, ref op);

          
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";

                if (op.ml_OPBillList.Count > 0)
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
            BL_OPBilling bl = new BL_OPBilling();

            get_OPBillList_IP ip = new get_OPBillList_IP();
            ip.UserDBConnStr = m_DBConnStr;
            // ip.m_Filter.m_Limit = "10";
            ip.m_Filter.m_ID = 165813;



            get_OPBillList_OP op = new get_OPBillList_OP();

            //RUN
            bl.get_OPBillList(ref ip, ref op);

            //VALIDATE
            if (op.ReturnValue == 0)
            {
                if (op.ml_OPBillList.Count > 0)
                {
                    foreach (var OpbillList in op.ml_OPBillList)
                    {
                        Console.WriteLine("ROW FETCHED," + " " + "TEST RESULT PASS");
                        
                        Console.WriteLine($"Patient Name: {OpbillList.PatientName}");
                        Console.WriteLine($"Bill Number: {OpbillList.BillNumber}");
                        Console.WriteLine($"Bill Type: {OpbillList.BillType}");
                      
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
            BL_OPBilling bl = new BL_OPBilling();

            get_OPBillList_IP ip = new get_OPBillList_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_Filter.m_ID = 165812;

            get_OPBillList_OP op = new get_OPBillList_OP();

            //RUN
            bl.get_OPBillList(ref ip, ref op);

            //VALIDATE
            if (op.ReturnValue == 0)
            {
                

                if (op.ml_OPBillList.Count > 0)
                {
                    foreach (var OpbillList in op.ml_OPBillList)
                    {
                        Console.WriteLine("ROW FETCHED," + " " + "TEST RESULT PASS");
                        // Display staff details in the console
                        Console.WriteLine($"Patient Name: {OpbillList.PatientName}");
                        Console.WriteLine($"Bill Number: {OpbillList.BillNumber}");
                        Console.WriteLine($"Bill Type: {OpbillList.BillType}");
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



