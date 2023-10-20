using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Communication;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;
namespace PIHMS.CL.BL.Communication
{
    class get_DashboardMessage_BL : cls_BC_BusinessLogic
    {
        public get_DashboardMessage_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_DashboardMessage(ref get_DashboardMessage_IP ipdc, ref get_DashboardMessage_OP opdc)
        {
            m_WhereCondition = " WHERE ID > 0 order by ID desc limit " + ipdc.m_Filter.m_Limit;

            List<tbl_trn_dashboard_message> ml_Communication = new List<tbl_trn_dashboard_message>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_Communication);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.ml_Communication = ml_Communication;
            return m_rc;
        }

    }
}







