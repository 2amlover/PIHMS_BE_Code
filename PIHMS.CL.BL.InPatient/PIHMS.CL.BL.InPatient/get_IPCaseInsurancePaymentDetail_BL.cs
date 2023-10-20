using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.InPatient
{
    class get_IPCaseInsurancePaymentDetail_BL : cls_BC_BusinessLogic
    {
        public get_IPCaseInsurancePaymentDetail_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }
        public int get_IPCaseInsurancePaymentDetail(ref get_IPCaseInsurancePaymentDetail_IP ip, ref get_IPCaseInsurancePaymentDetail_OP op)
        {
            m_WhereCondition = " WHERE ID = " + ip.m_IPCaseID;

            tbl_trn_ipcase m_IPCaseTemp = new tbl_trn_ipcase();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_IPCaseTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.m_IPCase = m_IPCaseTemp;


            m_WhereCondition = " WHERE IPCaseID = " + ip.m_IPCaseID;

            tbl_trn_ipcase_billsummary ml_IPCaseBillSummaryTemp = new tbl_trn_ipcase_billsummary();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_IPCaseBillSummaryTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.m_IPCaseBillSummary = ml_IPCaseBillSummaryTemp;



            m_WhereCondition = " WHERE IPCaseID = " + ip.m_IPCaseID;

            tbl_trn_ipcase_insurencepayment ml_IPCaseInsurancePaymentTemp = new tbl_trn_ipcase_insurencepayment();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_IPCaseInsurancePaymentTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.m_IPCaseInsurancePayment = ml_IPCaseInsurancePaymentTemp;


            m_WhereCondition = " WHERE IPCaseID = " + ip.m_IPCaseID;

            tbl_trn_ipcase_insurencereceived ml_IPCaseInsurancereceivedTemp = new tbl_trn_ipcase_insurencereceived();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_IPCaseInsurancereceivedTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.m_IPCaseInsurencereceived = ml_IPCaseInsurancereceivedTemp;
            return m_rc;
        }
    }
}
