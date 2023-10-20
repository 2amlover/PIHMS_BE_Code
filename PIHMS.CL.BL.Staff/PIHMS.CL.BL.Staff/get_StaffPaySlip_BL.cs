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
    class get_StaffPaySlip_BL : cls_BC_BusinessLogic
    {
        public get_StaffPaySlip_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_StaffPaySlip(ref get_StaffPaySlip_IP ip, ref get_StaffPaySlip_OP op)
        {

            m_WhereCondition = " WHERE StaffID = " + ip.m_StaffID;

            List<tbl_mas_staff_payslips> ml_StaffPaySlipsTemp = new List<tbl_mas_staff_payslips>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_StaffPaySlipsTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_StaffPaySlip = ml_StaffPaySlipsTemp;
            return m_rc;

        }
    }
}
