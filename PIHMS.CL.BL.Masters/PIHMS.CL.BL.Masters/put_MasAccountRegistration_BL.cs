﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Masters;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.Masters
{
    class put_MasAccountRegistration_BL : cls_BC_BusinessLogic
    {
        public put_MasAccountRegistration_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        
        public int put_MasAccountRegistration(ref put_MasAccountRegistration_IP ipdc, ref put_MasAccountRegistration_OP opdc)
        {
            if (ipdc.m_Masters.ID > 0)
            {
                //Update Existing Row

                m_rc = put_MasAccountRegistration_Update(ref ipdc, ref opdc);
                Console.WriteLine("  UPDATE EXISTING ROW SUCCESSFULLY, " + ipdc.m_Masters.ID.ToString() + "   tbl_mas_acc_registration");
            }

            else
            {
                //Insert New Row

                m_rc = put_MasAccountRegistration_Insert(ref ipdc, ref opdc);
                Console.WriteLine(" NEW ROW INSERT SUCCESSFULLY, " + ipdc.m_Masters.ID.ToString() + " tbl_mas_acc_registration");
            }
            return m_rc;
        }
        private int put_MasAccountRegistration_Update(ref put_MasAccountRegistration_IP ipdc, ref put_MasAccountRegistration_OP opdc)
        {
            m_WhereCondition = " WHERE ID = " + ipdc.m_Masters.ID.ToString();
            List<tbl_mas_acc_registration> m_MastersTemp = new List<tbl_mas_acc_registration>();
            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_MastersTemp);

            ipdc.m_Masters.UpdatedDateTime = DateTime.Now;
            ipdc.m_Masters.CreatedDateTime = DateTime.Now;
            ipdc.m_Masters.UpdatedDateTime = DateTime.Now;
            ipdc.m_Masters.IsRowDeleted = "N";

            m_MastersTemp.Add(ipdc.m_Masters);
            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_MastersTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }
            opdc.m_Masters = m_MastersTemp[0];
            return m_rc;
        }

        private int put_MasAccountRegistration_Insert(ref put_MasAccountRegistration_IP ipdc, ref put_MasAccountRegistration_OP opdc)
        {
            List<tbl_mas_acc_registration> m_MastersTemp = new List<tbl_mas_acc_registration>();
            ipdc.m_Masters.CreatedDateTime = DateTime.Now;
            ipdc.m_Masters.UpdatedDateTime = DateTime.Now;
            ipdc.m_Masters.IsRowDeleted = "N";

            m_MastersTemp.Add(ipdc.m_Masters);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_MastersTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }
            opdc.m_Masters = m_MastersTemp[0];
            return m_rc;
        }
    }
}















