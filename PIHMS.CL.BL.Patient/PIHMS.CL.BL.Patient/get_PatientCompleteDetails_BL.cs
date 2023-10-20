
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Patient;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.API.BL.Patient
{
    class get_PatientCompleteDetails_BL : cls_BC_BusinessLogic
    {
        public get_PatientCompleteDetails_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_PatientCompleteDetails(ref get_PatientCompleteDetails_IP ip, ref get_PatientCompleteDetails_OP op)
        { 
            m_WhereCondition = " WHERE ID = " + ip.m_PatientID;

            tbl_mas_patient m_PatientTemp = new tbl_mas_patient();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_PatientTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.m_Patient = m_PatientTemp;


            m_WhereCondition = " WHERE PatientID = " + ip.m_PatientID + " ORDER BY PatientID " + ip.m_OrderBy+ " LIMIT " + ip.m_Limit ;

            List<tbl_trn_bill> ml_PatientBillTemp = new List<tbl_trn_bill>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_PatientBillTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_PatientBil = ml_PatientBillTemp;




            m_WhereCondition = " WHERE PatientID = " + ip.m_PatientID + " Order By PatientID " + ip.m_OrderBy + " LIMIT " + ip.m_Limit;

            List<tbl_trn_ipcase> ml_PatientIPCaseTemp = new List<tbl_trn_ipcase>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_PatientIPCaseTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_PatientIPCase = ml_PatientIPCaseTemp;



            m_WhereCondition = " WHERE PatientID = " + ip.m_PatientID + " Order By ID " + ip.m_OrderBy + " LIMIT " + ip.m_Limit;

            List<tbl_trn_doctor_consultation> ml_PatientConsultaionTemp = new List<tbl_trn_doctor_consultation>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_PatientConsultaionTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_PatientConsultaion = ml_PatientConsultaionTemp;


            m_WhereCondition = " WHERE PatientID = " + ip.m_PatientID + " Order By ID " + ip.m_OrderBy + " LIMIT " + ip.m_Limit ;

            List<tbl_mas_patient_insurance> ml_PatientInsuranceTemp = new List<tbl_mas_patient_insurance>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_PatientInsuranceTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_PatientInsurance = ml_PatientInsuranceTemp;


            return m_rc;
        }

    }
}





