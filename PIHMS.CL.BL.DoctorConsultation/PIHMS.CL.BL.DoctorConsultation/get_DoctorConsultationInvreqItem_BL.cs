using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.DoctorConsultation;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.DoctorConsultation
{
    class get_DoctorConsultationInvreqItem_BL : cls_BC_BusinessLogic
    {
        public get_DoctorConsultationInvreqItem_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_DoctorConsultationInvreqItem(ref get_DoctorConsultationInvreqItem_IP ipdc, ref get_DoctorConsultationInvreqItem_OP opdc)
        {
            m_WhereCondition = " WHERE ID > 0 order by ID desc limit " + ipdc.m_Filter.m_Limit;

            List<tbl_trn_doctor_consultation_invreq_item> ml_DoctorConsultation = new List<tbl_trn_doctor_consultation_invreq_item>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_DoctorConsultation);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.ml_DoctorConsultation = ml_DoctorConsultation;
            return m_rc;
        }

    }
}








