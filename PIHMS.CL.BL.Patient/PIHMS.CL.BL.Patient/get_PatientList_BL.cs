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
    class get_PatientList_BL : cls_BC_BusinessLogic
    {
        public get_PatientList_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_PatientList(ref get_PatientList_IP ip, ref get_PatientList_OP op)
        {
            tbl_mas_patient tbl_temp = new tbl_mas_patient();
            cls_FilterOptions_IP filter_ip = ip.m_FilterOptions;

            m_rc = getSQLQuery(ref filter_ip, ref tbl_temp);

            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            List<tbl_mas_patient> ml_patient = new List<tbl_mas_patient>();
            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_patient);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_Patient = ml_patient;


            return m_rc;
        }

    }
}



