﻿




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
    class get_IPCaseDiagnosisTagging_BL : cls_BC_BusinessLogic
    {
        public get_IPCaseDiagnosisTagging_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_IPCaseDiagnosisTagging(ref get_IPCaseDiagnosisTagging_IP ipdc, ref get_IPCaseDiagnosisTagging_OP opdc)
        {
            m_WhereCondition = " WHERE ID > 0 order by ID desc limit " + ipdc.m_Filter.m_Limit;

            List < tbl_trn_ipcase_diagnosis_tagging > ml_InPatient = new List<tbl_trn_ipcase_diagnosis_tagging>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_InPatient);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.ml_InPatient = ml_InPatient;
            return m_rc;
        }
    }
}









