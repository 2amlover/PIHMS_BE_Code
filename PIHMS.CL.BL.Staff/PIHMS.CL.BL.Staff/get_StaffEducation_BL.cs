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
    class get_StaffEducation_BL : cls_BC_BusinessLogic
    {
        public get_StaffEducation_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_StaffEducation(ref get_StaffEducation_IP ip, ref get_StaffEducation_OP op)
        {

            m_WhereCondition = " WHERE StaffNumber = " + ip.m_StaffID;

            List<tbl_mas_staff_education> ml_StaffEducationTemp = new List<tbl_mas_staff_education>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_StaffEducationTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_StaffEducation = ml_StaffEducationTemp;
            return m_rc;

        }
    }
}



