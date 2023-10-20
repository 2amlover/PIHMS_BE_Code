using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.OPBilling
{

    class get_OPBillDetail_BL : cls_BC_BusinessLogic
    {
        public get_OPBillDetail_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_OPBillDetail(ref get_OPBillDetail_IP ip, ref get_OPBillDetail_OP op)
        {
            m_WhereCondition = " WHERE ID = " + ip.m_BillID;

            tbl_trn_bill m_OPDetailTemp = new tbl_trn_bill();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_OPDetailTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.m_OPBill = m_OPDetailTemp;


            m_WhereCondition = " WHERE BillID = " + ip.m_BillID;

            List<tbl_trn_bill_item> ml_OPBillItemTemp = new List<tbl_trn_bill_item>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_OPBillItemTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_OPBillItem = ml_OPBillItemTemp;


            m_WhereCondition = " WHERE BillID = " + ip.m_BillID;

            List<tbl_trn_bill_payment> ml_OPBillPaymentTemp = new List<tbl_trn_bill_payment>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_OPBillPaymentTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_OPBillPayment = ml_OPBillPaymentTemp;


            m_WhereCondition = " WHERE BillID = " + ip.m_BillID;

            List<tbl_trn_bill_refund> ml_OPBillrefundTemp = new List<tbl_trn_bill_refund>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_OPBillrefundTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_OPBillRefund = ml_OPBillrefundTemp;


            m_WhereCondition = " WHERE StartBillID = " + ip.m_BillID;

            tbl_trn_bill_session m_OPBillsessionTemp = new tbl_trn_bill_session();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_OPBillsessionTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.m_OPBillSession = m_OPBillsessionTemp;


            m_WhereCondition = " WHERE BillID = " + ip.m_BillID;

            List<tbl_trn_split_bill> ml_OPBillslitTemp = new List<tbl_trn_split_bill>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_OPBillslitTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_OPSplitbill = ml_OPBillslitTemp;


            return m_rc;
        }
    }
}