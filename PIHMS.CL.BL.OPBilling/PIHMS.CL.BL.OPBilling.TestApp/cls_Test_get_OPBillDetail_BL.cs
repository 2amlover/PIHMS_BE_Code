using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;
using PIHMS.CL.BL.OPBilling;


namespace PIHMS.CL.BL.OPBilling.TestApp
{
    internal class cls_Test_get_OPBillDetail_BL
    {
        String m_DBConnStr;
        public cls_Test_get_OPBillDetail_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_OPBilling bl = new BL_OPBilling();

            get_OPBillDetail_IP ip = new get_OPBillDetail_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_BillID = 165813;

            get_OPBillDetail_OP op = new get_OPBillDetail_OP();

            //RUN
            bl.get_OPBillDetail(ref ip, ref op);

            
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
                if (op.m_OPBill.ID > 0)
                {
                    Result += " ROW FETCHED, ";
                    Result += "TEST RESULT = PASS.";
                }
                else
                {
                    Result += op.m_OPBill.ID + " ROW FETCHED, ";
                    Result += "TEST RESULT = WARNING.";
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

            get_OPBillDetail_IP ip = new get_OPBillDetail_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_BillID = 165813;

            get_OPBillDetail_OP op = new get_OPBillDetail_OP();

            //RUN
            bl.get_OPBillDetail(ref ip, ref op);

            //Console.WriteLine(op.m_OPBill.PatientName);
            //Console.WriteLine(op.m_OPBillSession.StaffName);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
                if (op.ml_OPSplitbill.Count > 0)
                {
                    foreach (var opsplitbill in op.ml_OPSplitbill)
                    {
                        // Display staff details in the console
                        Console.WriteLine($"Staff AppFeatureID: {opsplitbill.BillID}");
                        Console.WriteLine($"Staff ViewName: {opsplitbill.PatientName}");

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

        public String SC_003()
        {
            String Result = "";
            //PREPARE
            BL_OPBilling bl = new BL_OPBilling();

            get_OPBillDetail_IP ip = new get_OPBillDetail_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_BillID = 16583;

            get_OPBillDetail_OP op = new get_OPBillDetail_OP();

            //RUN
            bl.get_OPBillDetail(ref ip, ref op);

            //Console.WriteLine(op.m_OPBill.PatientName);
            //Console.WriteLine(op.m_OPBillSession.StaffName);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
                if (op.ml_OPSplitbill.Count > 0)
                {
                    foreach (var opsplitbill in op.ml_OPSplitbill)
                    {
                        // Display staff details in the console
                        Console.WriteLine($"Staff AppFeatureID: {opsplitbill.BillID}");
                        Console.WriteLine($"Staff ViewName: {opsplitbill.PatientName}");
                        
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