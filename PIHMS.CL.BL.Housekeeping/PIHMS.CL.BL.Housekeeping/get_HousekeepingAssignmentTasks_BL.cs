using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Housekeeping;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.Housekeeping
{
    class get_HousekeepingAssignmentTasks_BL : cls_BC_BusinessLogic
    {
        public get_HousekeepingAssignmentTasks_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_HousekeepingAssignmentTasks(ref get_HousekeepingAssignmentTasks_IP ipdc, ref get_HousekeepingAssignmentTasks_OP opdc)
        {
            m_WhereCondition = " WHERE ID > 0 order by ID desc limit " + ipdc.m_Filter.m_Limit;

            List<tbl_trn_housekeeping_tasks> ml_Housekeeping = new List<tbl_trn_housekeeping_tasks>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_Housekeeping);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.ml_Housekeeping = ml_Housekeeping;
            return m_rc;
        }

    }
}








