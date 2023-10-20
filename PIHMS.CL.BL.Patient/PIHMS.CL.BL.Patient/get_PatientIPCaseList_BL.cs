
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
    class get_PatientIPCaseList_BL : cls_BC_BusinessLogic
    {
        public get_PatientIPCaseList_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_PatientIPCaseList(ref get_PatientIPCaseList_IP ip, ref get_PatientIPCaseList_OP op)
        {
            m_WhereCondition = " WHERE PatientID = " + ip.m_PatientID;

            List<tbl_trn_ipcase> m_PatientTemp = new List<tbl_trn_ipcase>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_PatientTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_PatientIPCase = m_PatientTemp;
            return m_rc;
        }

    }
}





