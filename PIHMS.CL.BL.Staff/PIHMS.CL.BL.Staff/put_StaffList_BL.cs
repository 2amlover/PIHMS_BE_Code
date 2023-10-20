using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Staff;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.Staff
{
    class put_StaffList_BL : cls_BC_BusinessLogic
    {
        public put_StaffList_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int put_StaffList(ref put_Staff_IP ipdc, ref put_Staff_OP opdc)
        {


            if (ipdc.m_Staff.ID > 0)
            {
                //Update Existing Row

                m_rc = put_Staff_Update(ref ipdc, ref opdc);
            }

            else
            {
                //Insert New Row

                m_rc = put_Staff_Insert(ref ipdc, ref opdc);
            }

            return m_rc;
        }


        private int put_Staff_Insert(ref put_Staff_IP ipdc, ref put_Staff_OP opdc)
        {
            List<tbl_mas_staff> ml_StaffTemp = new List<tbl_mas_staff>();
            ipdc.m_Staff.CreatedDateTime = DateTime.Now;

            ipdc.m_Staff.UpdatedDateTime = DateTime.Now;

            ipdc.m_Staff.IsRowDeleted = "N";

            ml_StaffTemp.Add(ipdc.m_Staff);
            m_rc = m_dbc.Save(ref m_ErrorMessage, ref ml_StaffTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.m_Staff = ml_StaffTemp[0];
            Console.WriteLine("INSERTED SUCCESSFULLY @ " + ipdc.m_Staff.ID.ToString() + " in tbl_mas_staff");

            return m_rc;
        }


        private int put_Staff_Update(ref put_Staff_IP ipdc, ref put_Staff_OP opdc)
        {
            m_WhereCondition = "WHERE ID = " + ipdc.m_Staff.ID.ToString();
            List<tbl_mas_staff> ml_StaffTemp = new List<tbl_mas_staff>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_StaffTemp);

            //to keep created date time same 
            ipdc.m_Staff.CreatedDateTime = ml_StaffTemp[0].CreatedDateTime;


            ipdc.m_Staff.UpdatedDateTime = DateTime.Now;

            ml_StaffTemp.Add(ipdc.m_Staff);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref ml_StaffTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.m_Staff = ml_StaffTemp[0];
            Console.WriteLine("UPDATED SUCCESSFULLY @ " + ipdc.m_Staff.ID.ToString() + " in tbl_mas_staff");
            return m_rc;
        }

    }
}