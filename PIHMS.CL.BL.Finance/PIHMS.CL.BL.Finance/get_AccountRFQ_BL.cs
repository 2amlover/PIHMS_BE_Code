using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Finance;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;


namespace PIHMS.CL.BL.Finance
{
    class get_AccountRFQ_BL : cls_BC_BusinessLogic
    {
        public get_AccountRFQ_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_AccountRFQ(ref get_AccountRFQ_IP ipdc, ref get_AccountRFQ_OP opdc)
        {
            m_WhereCondition = " WHERE ID > 0 order by ID desc limit " + ipdc.m_Filter.m_Limit;

            List<tbl_trn_acc_rfq> ml_Finance = new List<tbl_trn_acc_rfq>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_Finance);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.ml_Finance = ml_Finance;
            return m_rc;
        }

    }
}







