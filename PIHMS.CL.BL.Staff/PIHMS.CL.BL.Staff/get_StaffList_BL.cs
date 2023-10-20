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
    class get_StaffList_BL : cls_BC_BusinessLogic
    {
        public get_StaffList_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_StaffList(ref get_StaffList_IP ip, ref get_StaffList_OP op)
        {


            //tbl_mas_staff tbl_temp = new tbl_mas_staff();
            //cls_FilterOptions_IP filter_ip = ip.m_Filter;

            //m_rc = getSQLQuery(ref filter_ip, ref tbl_temp);

            //if (m_rc < 0)
            //{
            //    op.ReturnMessage = m_ErrorMessage;
            //    op.ReturnValue = m_rc;
            //    return m_rc;
            //}

            List<tbl_mas_staff> ml_StaffbillTemp = new List<tbl_mas_staff>();
            cls_FilterOptions_IP filter_ip = ip.m_FilterOptions;
            m_rc = getSQLQuery(ref filter_ip, ref ml_StaffbillTemp);


            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_StaffbillTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_StaffList = ml_StaffbillTemp;

            return m_rc;
        }
    }
}


