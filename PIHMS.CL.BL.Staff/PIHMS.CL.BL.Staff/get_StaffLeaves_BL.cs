using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIHMS.CL.BL.Staff
{

    class get_StaffLeaves_BL : cls_BC_BusinessLogic
    {
        public get_StaffLeaves_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_StaffLeaves(ref get_StaffLeaves_IP ip, ref get_StaffLeaves_OP op)
        {

            m_WhereCondition = " WHERE ID = " + ip.m_StaffID;

            tbl_mas_staff_leavesummary m_StaffLeaveSummaryTemp = new tbl_mas_staff_leavesummary();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_StaffLeaveSummaryTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.m_StaffLeaveSummary = m_StaffLeaveSummaryTemp;


            m_WhereCondition = " WHERE ID = " + ip.m_StaffID;

            List<tbl_trn_staff_leaves> ml_MyLeavesTemp = new List<tbl_trn_staff_leaves>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_MyLeavesTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_MyLeaves = ml_MyLeavesTemp;

            m_WhereCondition = " WHERE ID = " + ip.m_StaffID;

            List<tbl_trn_staff_leaves> ml_ForApprovalTemp = new List<tbl_trn_staff_leaves>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_ForApprovalTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_ForApproval = ml_ForApprovalTemp;
            return m_rc;

        }
    }

}



