using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.InPatient
{
    class get_IPCaseList_BL : cls_BC_BusinessLogic
    {
        public get_IPCaseList_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }
        public int get_IPCaseList(ref get_IPCaseList_IP ip, ref get_IPCaseList_OP op)
        {
            tbl_trn_ipcase tbl_temp = new tbl_trn_ipcase();
            cls_FilterOptions_IP filter_ip = ip.m_Filter;

            m_rc = getSQLQuery(ref filter_ip, ref tbl_temp);

            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            List<tbl_trn_ipcase> ml_IPCaseListTemp = new List<tbl_trn_ipcase>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_IPCaseListTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_IPCaseList = ml_IPCaseListTemp;
            return m_rc;
        }

    }
}