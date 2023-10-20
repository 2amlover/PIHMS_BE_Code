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

namespace PIHMS.CL.BL.InPatient.TestApp
{
    internal class cls_Test_get_IPCaseInsurancePaymentDetail_BL
    {
        String m_DBConnStr;
        public cls_Test_get_IPCaseInsurancePaymentDetail_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseInsurancePaymentDetail_IP ip = new get_IPCaseInsurancePaymentDetail_IP();
            ip.UserDBConnStr = m_DBConnStr;
           
            //ip.m_IPCaseID = 3751;
            //ip.m_IPCaseID = 6962;
            ip.m_IPCaseID = 8045;

          //  List<get_IPCaseInsurancePaymentDetail_OP> opList = new List<get_IPCaseInsurancePaymentDetail_OP>();

            get_IPCaseInsurancePaymentDetail_OP op = new get_IPCaseInsurancePaymentDetail_OP();
            //RUN
            bl.get_IPCaseInsurancePaymentDetail(ref ip, ref op);
            Console.WriteLine(op.m_IPCaseBillSummary.BillAmountSummary);
            Console.WriteLine(op.m_IPCaseInsurancePayment.PaymentMode);
            Console.WriteLine(op.m_IPCaseInsurencereceived.ReceivedAmountTDS);


            return Result;
        }


        public string SC_002()
        {
            string Result = "";

            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPCaseInsurancePaymentDetail_IP ip = new get_IPCaseInsurancePaymentDetail_IP();
            ip.UserDBConnStr = m_DBConnStr;
            //ip.m_IPCaseID = 8045;
            ip.m_IPCaseID = 1;

            get_IPCaseInsurancePaymentDetail_OP op = new get_IPCaseInsurancePaymentDetail_OP();

            //RUN
            bl.get_IPCaseInsurancePaymentDetail(ref ip, ref op);

            if (op.m_IPCaseBillSummary.ID > 0)
            {

                Result = "BillAmountSummary value: " + op.m_IPCaseBillSummary.BillAmountSummary;
               
            }
            else
            {

                Result = "No IPCaseBillSummary found";
            }

            return Result;
        }
    }
}
