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
    class get_IPCaseDoctorConsultations_BL : cls_BC_BusinessLogic
    {
        public get_IPCaseDoctorConsultations_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }
        public int get_IPCaseDoctorConsultations(ref get_IPCaseDoctorConsultations_IP ip, ref get_IPCaseDoctorConsultations_OP op)
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

            List<tbl_trn_ipcase_doctors> ml_IPCaseDoctorsTemp = new List<tbl_trn_ipcase_doctors>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_IPCaseDoctorsTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_IPCaseDoctors = ml_IPCaseDoctorsTemp;
            return m_rc;
        }

    }
}