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

namespace PIHMS.CL.BL.Patient
{
    class put_Patient_BL : cls_BC_BusinessLogic
    {
        public put_Patient_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int put_Patient(ref put_Patient_IP ipdc, ref put_Patient_OP opdc)
        {
            if (ipdc.m_Patient.ID > 0)
            {
                //Update Existing Row

                m_rc = put_Patient_Update(ref ipdc, ref opdc);
                Console.WriteLine(ipdc.m_Patient.ID.ToString() + "  UPDATE EXISTING ROW SUCCESSFULLY, ");
            }
            else
            {
                //Insert New Row

                m_rc = put_Patient_Insert(ref ipdc, ref opdc);
                Console.WriteLine(ipdc.m_Patient.ID.ToString() + " NEW ROW INSERT SUCCESSFULLY, ");
            }
            return m_rc;
        }
        private int put_Patient_Update(ref put_Patient_IP ipdc, ref put_Patient_OP opdc)
        {
            m_WhereCondition = " WHERE ID = 2" + ipdc.m_Patient.ID.ToString();
            List<tbl_mas_patient> m_PatientTemp = new List<tbl_mas_patient>();
            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_PatientTemp);
            ipdc.m_Patient.CreatedDateTime = DateTime.Now;
            ipdc.m_Patient.UpdatedDateTime = DateTime.Now;

            m_PatientTemp.Add(ipdc.m_Patient);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_PatientTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }
            opdc.m_Patient = m_PatientTemp[0];
            return m_rc;
        }

        private int put_Patient_Insert(ref put_Patient_IP ipdc, ref put_Patient_OP opdc)
        {
            List<tbl_mas_patient> m_PatientTemp = new List<tbl_mas_patient>();
            ipdc.m_Patient.CreatedDateTime = DateTime.Now;
            ipdc.m_Patient.UpdatedDateTime = DateTime.Now;
            ipdc.m_Patient.IsRowDeleted = "N";

            m_PatientTemp.Add(ipdc.m_Patient);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_PatientTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }
            opdc.m_Patient = m_PatientTemp[0];
            return m_rc;
        }
    }
}

