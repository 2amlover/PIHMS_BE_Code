﻿
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

namespace PIHMS.CL.BL.Patient
{
    class get_PatientHistoryScannedFiles_BL : cls_BC_BusinessLogic
    {
        public get_PatientHistoryScannedFiles_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_PatientHistoryScannedFiles(ref get_PatientHistoryScannedFiles_IP ipdc, ref get_PatientHistoryScannedFiles_OP opdc)
        {
            m_WhereCondition = " WHERE ID > 0 order by ID desc limit " + ipdc.m_Filter.m_Limit;

            List <tbl_trn_patienthistory_scannedfiles>  ml_Patient = new List<tbl_trn_patienthistory_scannedfiles>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_Patient);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.ml_Patient = ml_Patient;
            return m_rc;
        }

    }
}






