using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Pharmacy;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;
using PIHMS.CL.API.IO.Pharmacy;

namespace PIHMS.CL.BL.Pharmacy
{
    class get_PharmacyItem_BL : cls_BC_BusinessLogic
    {
        public get_PharmacyItem_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_PharmacyItem(ref get_PharmacyItem_IP ipdc, ref get_PharmacyItem_OP opdc)
        {
            m_WhereCondition = " WHERE ID > 0 order by ID desc limit " + ipdc.m_Filter.m_Limit;

            List<tbl_mas_pharmacy_item> ml_Pharmacy = new List<tbl_mas_pharmacy_item>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_Pharmacy);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.ml_Pharmacy = ml_Pharmacy;
            return m_rc;
        }

    }
}