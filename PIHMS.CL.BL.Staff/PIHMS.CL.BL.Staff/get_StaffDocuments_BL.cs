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
    class get_StaffDocuments_BL : cls_BC_BusinessLogic
    {
        public get_StaffDocuments_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_StaffDocuments(ref get_StaffDocuments_IP ip, ref get_StaffDocuments_OP op)
        {

            m_WhereCondition = " WHERE StaffID = " + ip.m_StaffID;

            List<tbl_mas_staff_mydocuments> m_StaffdocumentsTemp = new List<tbl_mas_staff_mydocuments>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_StaffdocumentsTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_StaffMyDocuments = m_StaffdocumentsTemp;
            return m_rc;
        }
    }
}