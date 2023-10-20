

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
    internal class cls_test_get_IPCaseDischargeDetails_BL
    {
        String m_DBConnStr;
        public cls_test_get_IPCaseDischargeDetails_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {

            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseDischargeDetails_IP ip = new get_IPCaseDischargeDetails_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_IPCaseID = 6962;

            get_IPCaseDischargeDetails_OP op = new get_IPCaseDischargeDetails_OP();

            //RUN
            bl.get_IPCaseDischargeDetails(ref ip, ref op);

            //VALIDATE
            Console.WriteLine(op.m_IPCase.ID);
            Console.WriteLine(op.m_IPCaseDischargesummary.UpdatedStaffID);
           


            return Result;
        }

        public String SC_002()
        {

            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseDischargeDetails_IP ip = new get_IPCaseDischargeDetails_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_IPCaseID = 662;

            get_IPCaseDischargeDetails_OP op = new get_IPCaseDischargeDetails_OP();

            //RUN
            bl.get_IPCaseDischargeDetails(ref ip, ref op);

            if (op.m_IPCaseDischargesummary.ID > 0)
            {
                Result = " In tbl_trn_ipcase_dischargesummary Row Fetched  , Test Reult = Pass";

            }

            else
            {
                Result = " In tbl_trn_ipcase_dischargesummary  No Row Fetched  , Test Reult = Fail";
            }


            return Result;
        }
    }
}








