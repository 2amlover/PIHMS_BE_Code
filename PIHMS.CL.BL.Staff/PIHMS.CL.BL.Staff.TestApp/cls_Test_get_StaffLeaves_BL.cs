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
    internal class cls_Test_get_StaffLeaves_BL
    {
        String m_DBConnStr;
        public cls_Test_get_StaffLeaves_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_Staff bl = new BL_Staff();

            get_StaffLeaves_IP ip = new get_StaffLeaves_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 1;

            get_StaffLeaves_OP op = new get_StaffLeaves_OP();

            //RUN
            bl.get_StaffLeaves(ref ip, ref op);

          
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
                
                    if (op.m_StaffLeaveSummary.ID>0)
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

            get_StaffLeaves_IP ip = new get_StaffLeaves_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 1;

            get_StaffLeaves_OP op = new get_StaffLeaves_OP();

            //RUN
            bl.get_StaffLeaves(ref ip, ref op);


            //VALIDATE
            if (op.ReturnValue == 0)
            {
                if (op.m_StaffLeaveSummary.ID > 0)
                {
                    Console.WriteLine("Staff ID"+ip.m_StaffID + " "+"Staff Name is "+op.m_StaffLeaveSummary.StaffName, op.m_StaffLeaveSummary);
                    
                    foreach (var MyLeaves in  op.ml_MyLeaves )
                    {
                        
                        Console.WriteLine("Type of Leave" + MyLeaves.TypeOfLeave);
                        Console.WriteLine("Reason for Leave" + MyLeaves.ReasonForLeave);

                    }
                    foreach(var ForApproval in op.ml_ForApproval)
                    {
                        Console.WriteLine("Approval ID is" + ForApproval.ApproverID);
                        Console.WriteLine("Approver Name  is" + ForApproval.ApproverName);
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

            get_StaffLeaves_IP ip = new get_StaffLeaves_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 101;

            get_StaffLeaves_OP op = new get_StaffLeaves_OP();

            //RUN
            bl.get_StaffLeaves(ref ip, ref op);


            //VALIDATE
            if (op.ReturnValue == 0)
            {
                if (op.m_StaffLeaveSummary.ID > 0)
                {
                    Console.WriteLine("Staff ID" + ip.m_StaffID + " " + "Staff Name is " + op.m_StaffLeaveSummary.StaffName, op.m_StaffLeaveSummary);

                    foreach (var MyLeaves in op.ml_MyLeaves)
                    {

                        Console.WriteLine("Type of Leave" + MyLeaves.TypeOfLeave);
                        Console.WriteLine("Reason for Leave" + MyLeaves.ReasonForLeave);

                    }
                    foreach (var ForApproval in op.ml_ForApproval)
                    {
                        Console.WriteLine("Approval ID is" + ForApproval.ApproverID);
                        Console.WriteLine("Approver Name  is" + ForApproval.ApproverName);
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
