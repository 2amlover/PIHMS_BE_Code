﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Masters;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.Masters
{
    class get_MasPharmacyItem_BL : cls_BC_BusinessLogic
    {
        public get_MasPharmacyItem_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_MasPharmacyItem(ref get_MasPharmacyItem_IP ipdc, ref get_MasPharmacyItem_OP opdc)
        {
            m_WhereCondition = " WHERE ID > 0 order by ID desc limit " + ipdc.m_Filter.m_Limit;

            List<tbl_mas_pharmacy_item> ml_Masters = new List<tbl_mas_pharmacy_item>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_Masters);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.ml_Masters = ml_Masters;
            return m_rc;
        }

    }
}








