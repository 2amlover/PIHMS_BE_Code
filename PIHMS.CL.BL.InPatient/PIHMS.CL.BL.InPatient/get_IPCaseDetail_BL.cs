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
    class get_IPCaseDetail_BL : cls_BC_BusinessLogic
    {
        public get_IPCaseDetail_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }
        public int get_IPCaseDetail(ref get_IPCaseDetail_IP ip, ref get_IPCaseDetail_OP op)
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

            tbl_trn_ipcase_patient_address m_IPCasePatientAddressTemp = new tbl_trn_ipcase_patient_address();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_IPCasePatientAddressTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.m_IPCasePatientAddress = m_IPCasePatientAddressTemp;


            m_WhereCondition = " WHERE IPCaseID = " + ip.m_IPCaseID;

            tbl_trn_ipcase_insurancedetail m_IPCaseInsurancedetailTemp = new tbl_trn_ipcase_insurancedetail();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_IPCaseInsurancedetailTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.m_IPCaseInsurancedetail = m_IPCaseInsurancedetailTemp;

            m_WhereCondition = " WHERE IPCaseID = " + ip.m_IPCaseID;

            tbl_trn_ipcase_corprationdetail m_IPCaseCorprationdetailTemp = new tbl_trn_ipcase_corprationdetail();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_IPCaseCorprationdetailTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.m_IPCaseCorprationdetail = m_IPCaseCorprationdetailTemp;

            m_WhereCondition = " WHERE IPCaseID = " + ip.m_IPCaseID;

            tbl_trn_ipcase_demographicinfo m_IPCaseDemographicinfoTemp = new tbl_trn_ipcase_demographicinfo();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_IPCaseDemographicinfoTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.m_IPCaseDemographicinfo = m_IPCaseDemographicinfoTemp;

            return m_rc;
        }

    }
}






