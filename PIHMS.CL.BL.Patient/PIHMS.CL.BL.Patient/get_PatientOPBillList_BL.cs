
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Patient;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.API.BL.Patient
{
    class get_PatientOPBillList_BL : cls_BC_BusinessLogic
    {
        public get_PatientOPBillList_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_PatientOPBillList(ref get_PatientOPBillList_IP ip, ref get_PatientOPBillList_OP op)
        {

            m_WhereCondition = " WHERE PatientID = " + ip.m_PatientID;

            List<tbl_trn_bill> ml_PatientTemp = new List<tbl_trn_bill>();
       
            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_PatientTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_PatientOPBill= ml_PatientTemp;

            return m_rc;
        }

    }
}







