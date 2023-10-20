


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;
using PIHMS.CL.API.IO.General;

namespace PIHMS.CL.BL.General
{
    class get_MessagingEmailMessages_BL : cls_BC_BusinessLogic
    {
        public get_MessagingEmailMessages_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_MessagingEmailMessages(ref get_MessagingEmailMessages_IP ipdc, ref get_MessagingEmailMessages_OP opdc)
        {
            m_WhereCondition = " WHERE ID > 0 order by ID desc limit " + ipdc.m_Filter.m_Limit;

            List<tbl_trn_messaging_email_messages> ml_General = new List<tbl_trn_messaging_email_messages>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_General);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.ml_General = ml_General;
            return m_rc;
        }

    }
}






