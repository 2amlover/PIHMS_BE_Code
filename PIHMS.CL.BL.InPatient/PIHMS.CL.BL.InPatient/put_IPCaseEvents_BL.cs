﻿





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.InPatient;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.InPatient
{
    class put_IPCaseEvents_BL : cls_BC_BusinessLogic
    {
        public put_IPCaseEvents_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

       
        public int put_IPCaseEvents(ref put_IPCaseEvents_IP ipdc, ref put_IPCaseEvents_OP opdc)
        {


                if (ipdc.m_InPatient.ID > 0)
                {
                    //Update Existing Row


                    m_rc = put_InPatient_Update(ref ipdc, ref opdc);

                }
            
            else

            
                {
                    //Insert New Row

                    m_rc = put_InPatient_Insert(ref ipdc, ref opdc);


                }
            

            return m_rc;
        }


        private int put_InPatient_Insert(ref put_IPCaseEvents_IP ipdc, ref put_IPCaseEvents_OP opdc)
        {
            List<tbl_trn_ipcase_events> m_InPatientTemp = new List<tbl_trn_ipcase_events>();
            ipdc.m_InPatient.CreatedDateTime = DateTime.Now;
            ipdc.m_InPatient.UpdatedDateTime = DateTime.Now;
            ipdc.m_InPatient.IsRowDeleted = "N";

            m_InPatientTemp.Add(ipdc.m_InPatient);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_InPatientTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.m_InPatient = m_InPatientTemp[0];
            Console.WriteLine("NEW ROW INSERTED SUCCESSFULLY");
            return m_rc;
        }


        private int put_InPatient_Update(ref put_IPCaseEvents_IP ipdc, ref put_IPCaseEvents_OP opdc)
        {

            m_WhereCondition = " WHERE ID = " + ipdc.m_InPatient.ID.ToString();

            List<tbl_trn_ipcase_events> m_InPatientTemp = new List<tbl_trn_ipcase_events>();
            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_InPatientTemp);



            m_InPatientTemp.Add(ipdc.m_InPatient);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_InPatientTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.m_InPatient = m_InPatientTemp[0];
            var b = ipdc.m_InPatient.ID.ToString();
            Console.WriteLine("UPDATED IN " + b + " ROW SUCCESSFULLY");
            return m_rc;

        }
    }
}










