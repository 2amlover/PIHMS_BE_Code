
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
    class get_NewOPBillMaster_BL : cls_BC_BusinessLogic
    {
        public get_NewOPBillMaster_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_NewOPBillMaster(ref get_NewOPBillMaster_IP ip, ref get_NewOPBillMaster_OP op)
        {

            //Patient Details from PatientID
            m_WhereCondition = " WHERE ID = " + ip.m_PatientID;

            tbl_mas_patient m_NewOPPatientTemp = new tbl_mas_patient();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_NewOPPatientTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.m_NewOPPatient = m_NewOPPatientTemp;
            //-----------------------------------------------------------------------

            //Bill Domain from BillDomainID
            m_WhereCondition = " WHERE ID > 0 ";

            List<tbl_mas_bill_domain> ml_NewOPBillDomainTemp = new List<tbl_mas_bill_domain>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_NewOPBillDomainTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_NewOPBillDomain = ml_NewOPBillDomainTemp;

            //-----------------------------------------------------------------------
            //Items from BillID
            m_WhereCondition = " WHERE ID > 0 ";

            List<tbl_mas_bill_item> ml_NewOPBillItemTemp = new List<tbl_mas_bill_item>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_NewOPBillItemTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_NewOPBillItem = ml_NewOPBillItemTemp;

            //-----------------------------------------------------------------------


           //Get every OP Bill using PatientID and BillDomainID
         

            List<tbl_trn_bill> ml_NewOPBillTemp = new List<tbl_trn_bill>();

            m_WhereCondition = " WHERE PatientID = " + ip.m_PatientID +" AND BillDomainID = "+ ip.m_OPBillDomainID ;

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_NewOPBillTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            //For every billID we get the bill items and payments  and store it in ml_NewOPBillItem and ml_NewOPBillPayment
            List<cls_NewOPBill> ml_cls_NewOPBill = new List<cls_NewOPBill>();
            for (int i = 0; i < ml_NewOPBillTemp.Count; i++)
            { 
                cls_NewOPBill m_cls_NewOPBill = new cls_NewOPBill();
                //Storing the first Bill 
                m_cls_NewOPBill.m_NewOPBill = ml_NewOPBillTemp[i];
                
                //getting the items for that billID
                List<tbl_trn_bill_item> ml_BillItemsTemp = new List<tbl_trn_bill_item>();

                m_WhereCondition = " WHERE BillID = " + ml_NewOPBillTemp[i].ID;

                m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_BillItemsTemp);
                if (m_rc < 0)
                {
                    op.ReturnMessage = m_ErrorMessage;
                    op.ReturnValue = m_rc;
                    return m_rc;
                }

                m_cls_NewOPBill.ml_NewOPBillItem = ml_BillItemsTemp;

                //get the payments for the specific bill using billID
                List<tbl_trn_bill_payment> ml_NewOPBillPaymentTemp = new List<tbl_trn_bill_payment>();

                m_WhereCondition = " WHERE BillID = " + ml_NewOPBillTemp[i].ID;

                m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_NewOPBillPaymentTemp);
                if (m_rc < 0)
                {
                    op.ReturnMessage = m_ErrorMessage;
                    op.ReturnValue = m_rc;
                    return m_rc;
                }

                m_cls_NewOPBill.ml_NewOPBillPayment = ml_NewOPBillPaymentTemp;
                ml_cls_NewOPBill.Add(m_cls_NewOPBill);

        }


            op.ml_NewOPBills = ml_cls_NewOPBill;
            return m_rc;
        }
    }
}



