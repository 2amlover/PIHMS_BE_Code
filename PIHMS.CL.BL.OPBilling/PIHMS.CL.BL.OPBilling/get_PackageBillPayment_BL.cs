using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.OPBilling;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.OPBilling
{
    class get_PackageBillPayment_BL : cls_BC_BusinessLogic
    {
        public get_PackageBillPayment_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_PackageBillPayment(ref get_PackageBillPayment_IP ipdc, ref get_PackageBillPayment_OP opdc)
        {
            m_WhereCondition = " WHERE ID > 0 order by ID desc limit " + ipdc.m_Filter.m_Limit;

            List<tbl_trn_package_bill_payment> ml_OPBill = new List<tbl_trn_package_bill_payment>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_OPBill);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.ml_OPBill = ml_OPBill;
            return m_rc;
        }
    }
}







