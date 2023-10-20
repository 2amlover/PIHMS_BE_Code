﻿


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Staff;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.Staff
{
    class get_StaffYogDetails_BL : cls_BC_BusinessLogic
    {
        public get_StaffYogDetails_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_StaffYogDetails(ref get_StaffYogDetails_IP ipdc, ref get_StaffYogDetails_OP opdc)
        {
            m_WhereCondition = " WHERE ID > 0 order by ID desc limit " + ipdc.m_Filter.m_Limit;

            List<tbl_mas_yog_staff_details> ml_Staff = new List<tbl_mas_yog_staff_details>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_Staff);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.ml_Staff = ml_Staff;
            return m_rc;
        }

    }
}





