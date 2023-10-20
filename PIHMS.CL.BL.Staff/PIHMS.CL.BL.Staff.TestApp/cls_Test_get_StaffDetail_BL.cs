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
    internal class cls_Test_get_StaffDetail_BL
    {
        String m_DBConnStr;
        public cls_Test_get_StaffDetail_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_Staff bl = new BL_Staff();

            get_StaffDetail_IP ip = new get_StaffDetail_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 654;

            get_StaffDetail_OP op = new get_StaffDetail_OP();

            //RUN
            bl.get_StaffDetail(ref ip, ref op);

            // Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
               
                    if (op.m_Staff.ID > 0)
                    {
                        Console.WriteLine("Staff ID is " + op.m_Staff.ID + " Staff Name " + op.m_Staff.DisplayName);
                        foreach( var address in op.ml_StaffAddress)
                        {
                            Console.WriteLine("Address is " + address.AddressLine1);

                        }
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

            get_StaffDetail_IP ip = new get_StaffDetail_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 654;

            get_StaffDetail_OP op = new get_StaffDetail_OP();

            //RUN
            bl.get_StaffDetail(ref ip, ref op);

            // Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";

                if (op.m_Staff.ID > 0)
                {
                    
                    foreach (var address in op.ml_StaffAddress)
                    {
                        Console.WriteLine("ROW FETCHED," + " " + "TEST RESULT PASS");
                        Console.WriteLine("Address is " + address.AddressLine1);
                        Console.WriteLine("Staff ID is " + op.m_Staff.ID);
                        Console.WriteLine("Staff Name" + op.m_Staff.DisplayName);

                    }
                    Result += " ROW FETCHED, ";
                    Result += "TEST RESULT = PASS.";
                }
                else
                {
                    Result += "INPUT IS NOT CORRECT ";
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

            get_StaffDetail_IP ip = new get_StaffDetail_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_StaffID = 6548;

            get_StaffDetail_OP op = new get_StaffDetail_OP();

            //RUN
            bl.get_StaffDetail(ref ip, ref op);

            // Console.WriteLine(op.ml_PatientOPBill);
            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";

                if (op.m_Staff.ID > 0)
                {

                    foreach (var address in op.ml_StaffAddress)
                    {
                        Console.WriteLine("ROW FETCHED," + " " + "TEST RESULT PASS");
                        Console.WriteLine("Address is " + address.AddressLine1);
                        Console.WriteLine("Staff ID is " + op.m_Staff.ID);
                        Console.WriteLine("Staff Name" + op.m_Staff.DisplayName);

                    }
                    Result += " ROW FETCHED, ";
                    Result += "TEST RESULT = PASS.";
                }
                else
                {
                    Result += "INPUT IS NOT CORRECT ";
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