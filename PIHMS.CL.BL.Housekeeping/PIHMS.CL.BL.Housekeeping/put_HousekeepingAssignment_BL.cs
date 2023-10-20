using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Housekeeping;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;
using MySql.Data.MySqlClient;

namespace PIHMS.CL.BL.Housekeeping
{
    class put_HousekeepingAssignment_BL : cls_BC_BusinessLogic
    {
        public put_HousekeepingAssignment_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }


        public int put_HousekeepingAssignment(ref put_HousekeepingAssignment_IP ipdc, ref put_HousekeepingAssignment_OP opdc)
        {
            if (ipdc.m_Housekeeping.ID > 0)
            {
                //Update Existing Row

                m_rc = put_HousekeepingAssignment_Update(ref ipdc, ref opdc);
                Console.WriteLine(" UPDATE EXISTING ROW SUCCESSFULLY, " + ipdc.m_Housekeeping.ID.ToString() + "   tbl_trn_housekeeping_assignment");
            }

            else
            {
                //Insert New Row

                m_rc = put_HousekeepingAssignment_Insert(ref ipdc, ref opdc);
                Console.WriteLine(" NEW ROW INSERT SUCCESSFULLY, " + ipdc.m_Housekeeping.ID.ToString() + " tbl_trn_housekeeping_assignment");
            }
            return m_rc;
        }
        private int put_HousekeepingAssignment_Update(ref put_HousekeepingAssignment_IP ipdc, ref put_HousekeepingAssignment_OP opdc)
        {
            m_WhereCondition = " WHERE ID = " + ipdc.m_Housekeeping.ID.ToString();
            List<tbl_trn_housekeeping_assignment> m_HousekeepingTemp = new List<tbl_trn_housekeeping_assignment>();
            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_HousekeepingTemp);

            ipdc.m_Housekeeping.UpdatedDateTime = DateTime.Now;
            ipdc.m_Housekeeping.CreatedDateTime = DateTime.Now;
            ipdc.m_Housekeeping.UpdatedDateTime = DateTime.Now;
            ipdc.m_Housekeeping.IsRowDeleted = "N";

            m_HousekeepingTemp.Add(ipdc.m_Housekeeping);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_HousekeepingTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }
            opdc.m_Housekeeping = m_HousekeepingTemp[0];
            return m_rc;
        }

        private int put_HousekeepingAssignment_Insert(ref put_HousekeepingAssignment_IP ipdc, ref put_HousekeepingAssignment_OP opdc)
        {
            List<tbl_trn_housekeeping_assignment> m_HousekeepingTemp = new List<tbl_trn_housekeeping_assignment>();
            ipdc.m_Housekeeping.CreatedDateTime = DateTime.Now;
            ipdc.m_Housekeeping.UpdatedDateTime = DateTime.Now;
            ipdc.m_Housekeeping.IsRowDeleted = "N";

            m_HousekeepingTemp.Add(ipdc.m_Housekeeping);
            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_HousekeepingTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }
            opdc.m_Housekeeping = m_HousekeepingTemp[0];
            return m_rc;
        }

    }

}










