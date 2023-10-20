

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
using MySqlX.XDevAPI.Common;
using PIHMS.CL.BL.InPatient;

namespace PIHMS.ConsoleApp.API.BL.InPatient.Test
{
    internal class cls_test_get_IPCaseDetail_BL
    {
        String m_DBConnStr;
        public cls_test_get_IPCaseDetail_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {

            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseDetail_IP ip = new get_IPCaseDetail_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_IPCaseID = 9239;

            get_IPCaseDetail_OP op = new get_IPCaseDetail_OP();

            //RUN
            bl.get_IPCaseDetail(ref ip, ref op);

            //VALIDATE
            Console.WriteLine(op.m_IPCase.ID);
            Console.WriteLine(op.m_IPCasePatientAddress.PatientID);
            Console.WriteLine(op.m_IPCaseInsurancedetail.EffectiveDate);
            Console.WriteLine(op.m_IPCaseCorprationdetail.DepartmentID);
            Console.WriteLine(op.m_IPCaseDemographicinfo.ConsultantDoctor);
            return Result;
        }

        public String SC_002()
        {

            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseDetail_IP ip = new get_IPCaseDetail_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_IPCaseID = 9239;

            get_IPCaseDetail_OP op = new get_IPCaseDetail_OP();

            //RUN
            bl.get_IPCaseDetail(ref ip, ref op);

            //VALIDATE
            if (op.m_IPCasePatientAddress.ID > 0)
            {
                Result = " In tbl_trn_ipcase_patient_address Row Fetched  , Test Reult = Pass";
               
            }

            else
            {
                Result = " In tbl_trn_ipcase_patient_address  No Row Fetched  , Test Reult = Fail";
            }

           

            return Result;
        }

       
        public String SC_003()
        {

            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseDetail_IP ip = new get_IPCaseDetail_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_IPCaseID = 9239;

            get_IPCaseDetail_OP op = new get_IPCaseDetail_OP();

            //RUN
            bl.get_IPCaseDetail(ref ip, ref op);

            //VALIDATE
            if (op.m_IPCaseInsurancedetail.ID > 0)
            {
                Result = " In tbl_trn_ipcase_insurancedetail Row Fetched  , Test Reult = Pass";

            }

            else
            {
                Result = " In tbl_trn_ipcase_insurancedetail  No Row Fetched  , Test Reult = Fail";
            }



            return Result;
        }
        public String SC_004()
        {

            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseDetail_IP ip = new get_IPCaseDetail_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_IPCaseID = 9239;

            get_IPCaseDetail_OP op = new get_IPCaseDetail_OP();

            //RUN
            bl.get_IPCaseDetail(ref ip, ref op);

            //VALIDATE
            if (op.m_IPCaseCorprationdetail.ID > 0)
            {
                Result = " In tbl_trn_ipcase_corprationdetail Row Fetched  , Test Reult = Pass";

            }

            else
            {
                Result = " In tbl_trn_ipcase_corprationdetail  No Row Fetched  , Test Reult = Fail";
            }



            return Result;
        }
        public String SC_005()
        {

            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseDetail_IP ip = new get_IPCaseDetail_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_IPCaseID = 9239;

            get_IPCaseDetail_OP op = new get_IPCaseDetail_OP();

            //RUN
            bl.get_IPCaseDetail(ref ip, ref op);

            //VALIDATE
            if (op.m_IPCaseDemographicinfo.ID > 0)
            {
                Result = " In tbl_trn_ipcase_demographicinfo Row Fetched  , Test Reult = Pass";

            }

            else
            {
                Result = " In tbl_trn_ipcase_demographicinfo  No Row Fetched  , Test Reult = Fail";
            }



            return Result;
        }

    }
}








