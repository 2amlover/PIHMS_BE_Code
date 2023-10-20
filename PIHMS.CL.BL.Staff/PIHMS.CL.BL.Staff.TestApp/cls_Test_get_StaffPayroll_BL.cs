
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
    internal class cls_Test_get_StaffPayroll_BL
    {
        String m_DBConnStr;
        public cls_Test_get_StaffPayroll_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_Staff bl = new BL_Staff();

            get_StaffPayroll_IP ip = new get_StaffPayroll_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 749;

            get_StaffPayroll_OP op = new get_StaffPayroll_OP();

            //RUN
            bl.get_StaffPayroll(ref ip, ref op);

            // Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
               
                
                    if (op.ml_StaffPayroll.Count>0)
                    {
                      
                       foreach(var StaffPayroll in op.ml_StaffPayroll)
                        {
                        Console.WriteLine("Staff ID is " + StaffPayroll.m_Staffpayroll.ID + " Staff Name " + StaffPayroll.m_Staffpayroll.StaffName);
                        
                        foreach(var StaffPayrollEarning in StaffPayroll.ml_StaffSalaryEarning)
                        {
                            Console.WriteLine("Staff Name " + StaffPayrollEarning.Name);
                            Console.WriteLine("Staff Amount " + StaffPayrollEarning.Amount);

                        }
                        foreach (var StaffPayrollDeduction in StaffPayroll.ml_StaffSalaryDeduction)
                        {
                            Console.WriteLine("Staff Name " + StaffPayrollDeduction.Name);
                            Console.WriteLine("Staff Amount " + StaffPayrollDeduction.Amount);

                        }

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
    }
}
