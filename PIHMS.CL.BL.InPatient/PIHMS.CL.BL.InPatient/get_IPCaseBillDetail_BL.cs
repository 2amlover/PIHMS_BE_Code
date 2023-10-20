


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.InPatient;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.InPatient
{
    class get_IPCaseBillDetail_BL : cls_BC_BusinessLogic
    {
        public get_IPCaseBillDetail_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_IPCaseBillDetail(ref get_IPCaseBillDetail_IP ip, ref get_IPCaseBillDetail_OP op)
        {

            //IPCase Details from ID
            m_WhereCondition = " WHERE ID = " + ip.m_IPCaseID;

            tbl_trn_ipcase  m_IPCaseTemp = new tbl_trn_ipcase();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_IPCaseTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.m_IPCase = m_IPCaseTemp;


            //BillSummary from IPCaseID
            m_WhereCondition = " WHERE IPCaseID = " + ip.m_IPCaseID;

            tbl_trn_ipcase_billsummary m_IPCaseBillSummaryTemp = new tbl_trn_ipcase_billsummary();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_IPCaseBillSummaryTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.m_IPCaseBillsummary = m_IPCaseBillSummaryTemp;

            //Payments from IPCaseID
            m_WhereCondition = " WHERE IPCaseID = " + ip.m_IPCaseID;

            List<tbl_trn_ipcase_billpayments> ml_IPCaseBillPaymentsTemp = new List<tbl_trn_ipcase_billpayments>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_IPCaseBillPaymentsTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_IPCaseBillpayments = ml_IPCaseBillPaymentsTemp;

            //Payment Receipts from IPCaseID
            m_WhereCondition = " WHERE IPCaseID = " + ip.m_IPCaseID;

            List<tbl_trn_ipcase_billpaymentreciept> ml_IPCaseBillPaymentRecieptTemp = new List<tbl_trn_ipcase_billpaymentreciept>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_IPCaseBillPaymentRecieptTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_IPCaseBillpaymentreciept = ml_IPCaseBillPaymentRecieptTemp;



            //Get every IPCase Bill using IPCaseID
          //  List<cls_IPCaseBill> ml_IPCaseBillTemp = new List<cls_IPCaseBill>();

            List <tbl_trn_ipcase_bills> ml_IPCaseBillsTemp = new List<tbl_trn_ipcase_bills>();

            m_WhereCondition = " WHERE IPCaseID = " + ip.m_IPCaseID;

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_IPCaseBillsTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            //For every billID we get the bill items and store it in ml_IPCaseBillTemp

            for (int i = 0; i < ml_IPCaseBillsTemp.Count; i++)
            {
                cls_IPCaseBill ml_IPCaseBillTemp = new cls_IPCaseBill();
                ml_IPCaseBillTemp.m_IPCaseBills = ml_IPCaseBillsTemp[i];


                List<tbl_trn_ipcase_billitems> ml_BillItemsTemp = new List<tbl_trn_ipcase_billitems>();

                m_WhereCondition = " WHERE BillID = " + ml_IPCaseBillsTemp[i].ID;

                m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_BillItemsTemp);
                if (m_rc < 0)
                {
                    op.ReturnMessage = m_ErrorMessage;
                    op.ReturnValue = m_rc;
                    return m_rc;
                }

                ml_IPCaseBillTemp.ml_IPCaseBillitems = ml_BillItemsTemp;
                op.ml_IPCaseBill.Add(ml_IPCaseBillTemp);
            }

            return m_rc;
        }
    }
}

   








