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
    class get_StaffEmployment_BL : cls_BC_BusinessLogic
    {
        public get_StaffEmployment_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_StaffEmployment(ref get_StaffEmployment_IP ip, ref get_StaffEmployment_OP op)
        {

            m_WhereCondition = " WHERE StaffID = " + ip.m_StaffID;

            List<tbl_mas_staff_employment> ml_StaffemploymentTemp = new List<tbl_mas_staff_employment>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_StaffemploymentTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_StaffEmployment = ml_StaffemploymentTemp;

            return m_rc; 
        }
    }
}
