
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Diagnostic;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.Diagnostic
{
    class get_DiagSamplesMas_BL : cls_BC_BusinessLogic
    {
        public get_DiagSamplesMas_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_DiagSamplesMas(ref get_DiagSamplesMas_IP ipdc, ref get_DiagSamplesMas_OP opdc)
        {
            m_WhereCondition = " WHERE ID > 0 order by ID desc limit " + ipdc.m_Filter.m_Limit;

            List < tbl_mas_diag_samples > ml_Diag  = new List<tbl_mas_diag_samples>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_Diag);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.ml_Diag = ml_Diag;
            return m_rc;
        }

    }
}






