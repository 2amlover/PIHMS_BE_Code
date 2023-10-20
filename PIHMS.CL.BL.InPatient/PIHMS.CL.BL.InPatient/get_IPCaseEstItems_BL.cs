





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
    class get_IPCaseEstItems_BL : cls_BC_BusinessLogic
    {
        public get_IPCaseEstItems_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_IPCaseEstItems(ref get_IPCaseEstItems_IP ipdc, ref get_IPCaseEstItems_OP opdc)
        {
            m_WhereCondition = " WHERE ID > 0 order by ID desc limit " + ipdc.m_Filter.m_Limit;

            List < tbl_rel_ipcase_est_items > ml_InPatient = new List<tbl_rel_ipcase_est_items>();

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










