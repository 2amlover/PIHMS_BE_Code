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
    class get_StaffBankDetail_BL : cls_BC_BusinessLogic
    {
        public get_StaffBankDetail_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_StaffBankDetail(ref get_StaffBankDetail_IP ip, ref get_StaffBankDetail_OP op)
        {

            m_WhereCondition = " WHERE StaffID = " + ip.m_StaffID;

            List<tbl_mas_staff_bankdetails> ml_StaffbankdetailTemp = new List<tbl_mas_staff_bankdetails>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_StaffbankdetailTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_Staffbankdetail = ml_StaffbankdetailTemp;
            return m_rc;

        }
    }
}