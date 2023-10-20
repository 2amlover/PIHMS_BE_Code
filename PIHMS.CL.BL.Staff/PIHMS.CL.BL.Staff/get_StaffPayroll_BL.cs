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
    class get_StaffPayroll_BL : cls_BC_BusinessLogic
    {
        public get_StaffPayroll_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_StaffPayroll(ref get_StaffPayroll_IP ip, ref get_StaffPayroll_OP op)
        {

            m_WhereCondition = " WHERE StaffID = " + ip.m_StaffID;

            List<tbl_mas_staff_payroll> ml_StaffpayrollTemp = new List <tbl_mas_staff_payroll>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_StaffpayrollTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            for (int i = 0; i < ml_StaffpayrollTemp.Count; i++)
            {
                op.ml_StaffPayroll[i].m_Staffpayroll = ml_StaffpayrollTemp[i];


                m_WhereCondition = " WHERE ID = " + ip.m_StaffID;

                List<tbl_mas_staff_salary_earnings> ml_StaffSalaryEarningTemp = new List<tbl_mas_staff_salary_earnings>();

                m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_StaffSalaryEarningTemp);
                if (m_rc < 0)
                {
                    op.ReturnMessage = m_ErrorMessage;
                    op.ReturnValue = m_rc;
                    return m_rc;
                }

                op.ml_StaffPayroll[i].ml_StaffSalaryEarning = ml_StaffSalaryEarningTemp;

                m_WhereCondition = " WHERE ID = " + ip.m_StaffID;

                List<tbl_mas_staff_salary_deduction> ml_StaffSalaryDeductionTemp = new List<tbl_mas_staff_salary_deduction>();

                m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_StaffSalaryDeductionTemp);
                if (m_rc < 0)
                {
                    op.ReturnMessage = m_ErrorMessage;
                    op.ReturnValue = m_rc;
                    return m_rc;
                }

                op.ml_StaffPayroll[i].ml_StaffSalaryDeduction = ml_StaffSalaryDeductionTemp;
            }
            return m_rc;

        }
    }
}




















