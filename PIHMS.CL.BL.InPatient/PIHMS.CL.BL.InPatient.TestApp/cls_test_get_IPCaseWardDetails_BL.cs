
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;
using PIHMS.CL.API.IO.InPatient;
using PIHMS.CL.BL.InPatient;

namespace PIHMS.ConsoleApp.API.BL.InPatient.Test
{
    internal class cls_test_get_IPCaseWardDetails_BL
    {
        String m_DBConnStr;
        public cls_test_get_IPCaseWardDetails_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }

       
        public String SC_001()
        {

            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseWardDetails_IP ip = new get_IPCaseWardDetails_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_IPCaseID = 6962;

            get_IPCaseWardDetails_OP op = new get_IPCaseWardDetails_OP();

            //RUN
            bl.get_IPCaseWardDetails(ref ip, ref op);

            //VALIDATE
            Console.WriteLine(op.m_IPCase.ID);
            Console.WriteLine(op.ml_IPCasewarddetail[0].DepartmentID);


            return Result;
        }

        public String SC_002()
        {

            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseWardDetails_IP ip = new get_IPCaseWardDetails_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_IPCaseID = 1;

            get_IPCaseWardDetails_OP op = new get_IPCaseWardDetails_OP();

            //RUN
            bl.get_IPCaseWardDetails(ref ip, ref op);

            //VALIDATE
            if (op.ml_IPCasewarddetail.Count > 0)
            {
                Result = op.ml_IPCasewarddetail.Count + "  " + "Row Fetched  , Test Reult = Pass";
                for (int i = 0;i< op.ml_IPCasewarddetail.Count;i++)
                {
                    Console.WriteLine("ID : "+op.ml_IPCasewarddetail[i].ID);
                }
            }

            else
            {
                Result = "No Data Found , Test Reult = Fail";
            }


            return Result;
        }
    }
}








