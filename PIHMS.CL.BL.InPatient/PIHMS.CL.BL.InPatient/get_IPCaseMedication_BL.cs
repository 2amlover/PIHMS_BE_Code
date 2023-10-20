
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.InPatient
{
    class get_IPCaseMedication_BL : cls_BC_BusinessLogic
    {
        public get_IPCaseMedication_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }
        public int get_IPCaseMedication(ref get_IPCaseMedication_IP ip, ref get_IPCaseMedication_OP op)
        {
            m_WhereCondition = " WHERE ID = " + ip.m_IPCaseID;

            tbl_trn_ipcase m_IPCaseTemp = new tbl_trn_ipcase();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_IPCaseTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.m_IPCase = m_IPCaseTemp;

          
            List<tbl_trn_ipcase_medications> ml_IPCaseMedicationsTemp = new List<tbl_trn_ipcase_medications>();

            m_WhereCondition = " WHERE IPCaseID=" + ip.m_IPCaseID;

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_IPCaseMedicationsTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }
           
            for (int i = 0; i < ml_IPCaseMedicationsTemp.Count; i++)
            {
               cls_IPCaseMedication m_clsIPCaseMedicationTemp = new cls_IPCaseMedication();
               m_clsIPCaseMedicationTemp.m_IPCaseMedication = ml_IPCaseMedicationsTemp[i];
               // op.ml_clsIPCaseMedication[i].m_IPCaseMedication = ml_IPCaseMedicationsTemp[i];
               op.ml_clsIPCaseMedication.Add(m_clsIPCaseMedicationTemp);
            }
            
            return m_rc; 

        }

    }
}