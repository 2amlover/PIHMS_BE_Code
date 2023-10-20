
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
    class get_PatientDetail_BL : cls_BC_BusinessLogic
    {
        public get_PatientDetail_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_PatientDetail(ref get_PatientDetail_IP ip, ref get_PatientDetail_OP op)
        {
            if(ip.m_PatientID == 0)
            {
                op.ReturnMessage = "No ID Given";
                op.ReturnValue = -1;
                return -1;
            }

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

            return m_rc;
        }

    }
}





