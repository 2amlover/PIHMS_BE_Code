using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIHMS.CL.BL.OPBilling
{

    class get_OPBillList_BL : cls_BC_BusinessLogic
    {
        public get_OPBillList_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_OPBillList(ref get_OPBillList_IP ip, ref get_OPBillList_OP op)
        {

            List<tbl_trn_bill> ml_PatientTemp = new List<tbl_trn_bill>();
            cls_FilterOptions_IP filter_ip = ip.m_Filter;
            m_rc = getSQLQuery(ref filter_ip, ref ml_PatientTemp);
            

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_PatientTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_OPBillList = ml_PatientTemp;
            return m_rc;
        }

    }

}








