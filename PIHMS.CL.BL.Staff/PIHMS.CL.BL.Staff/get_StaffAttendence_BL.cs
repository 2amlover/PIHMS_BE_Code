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
    class get_StaffAttendence_BL : cls_BC_BusinessLogic
    {
        public get_StaffAttendence_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_StaffAttendence(ref get_StaffAttendence_IP ip, ref get_StaffAttendence_OP op)
        {
           
          
            if(ip.Get_Type=="Current Week")
            {
                ip.m_StartDate = DateTime.Now.StartOfWeek(DayOfWeek.Sunday);
                ip.m_EndDate = ip.m_StartDate.AddDays(6);
            }

            else if (ip.Get_Type == "Current Month")
            {
                DateTime date = DateTime.Now;
                 ip.m_StartDate = new DateTime(date.Year, date.Month, 1);
                 ip.m_EndDate = ip.m_StartDate.AddMonths(1).AddDays(-1);

            }
            string startDate = ip.m_StartDate.ToString("yyyy-MM-dd HH:mm:ss");
            string endDate = ip.m_EndDate.ToString("yyyy-MM-dd HH:mm:ss");
            m_WhereCondition = " WHERE StaffID = " +ip.m_StaffID+ " AND AttendanceDate >='" + startDate + "' AND AttendanceDate <='"+ endDate + "'";

          
            
            
            
            
            List<tbl_trn_staff_attendance> ml_StaffAttendnceTemp = new List<tbl_trn_staff_attendance>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_StaffAttendnceTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_StaffAttendnce = ml_StaffAttendnceTemp;
            return m_rc;

        }

  
    }
    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
}


    


