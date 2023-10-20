using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.Staff
{
    class get_StaffDetail_BL : cls_BC_BusinessLogic
    {
        public get_StaffDetail_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_StaffDetail(ref get_StaffDetail_IP ip, ref get_StaffDetail_OP op)
        {

            m_WhereCondition = " WHERE ID = " + ip.m_StaffID;

            tbl_mas_staff m_StaffIDTemp = new tbl_mas_staff();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_StaffIDTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.m_Staff = m_StaffIDTemp;


            m_WhereCondition = "WHERE StaffID =" + ip.m_StaffID;

            List<tbl_mas_staff_address> ml_StaffaddressTemp = new List<tbl_mas_staff_address>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_StaffaddressTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_StaffAddress = ml_StaffaddressTemp;

            return m_rc;

        }
    }
}