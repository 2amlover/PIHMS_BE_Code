﻿
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
    class get_AccountPO_BL : cls_BC_BusinessLogic
    {
        public get_AccountPO_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_AccountPO(ref get_AccountPO_IP ipdc, ref get_AccountPO_OP opdc)
        {
            m_WhereCondition = " WHERE ID > 0 order by ID desc limit " + ipdc.m_Filter.m_Limit;

            List<tbl_trn_acc_po> ml_Finance = new List<tbl_trn_acc_po>();

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







