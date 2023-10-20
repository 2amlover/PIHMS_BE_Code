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
using Org.BouncyCastle.Asn1.Ocsp;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;


namespace PIHMS.CL.BL.Patient
{
    class put_PatientBirthDetails_BL : cls_BC_BusinessLogic
    {
        public put_PatientBirthDetails_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int put_PatientBirthDetails(ref put_PatientBirthDetails_IP ipdc, ref put_PatientBirthDetails_OP opdc)
        {
            if (ipdc.m_Patient.ID > 0)
            {
                //Update Existing Row

                m_rc = put_PatientBirthDetails_Update(ref ipdc, ref opdc);
                Console.WriteLine(ipdc.m_Patient.ID.ToString() + "  UPDATE EXISTING ROW SUCCESSFULLY, ");
            }
            else
            {
                //Insert New Row

                m_rc = put_PatientBirthDetails_Insert(ref ipdc, ref opdc);
                Console.WriteLine(ipdc.m_Patient.ID.ToString() + " NEW ROW INSERT SUCCESSFULLY, ");
            }
            return m_rc;
        }
        private int put_PatientBirthDetails_Update(ref put_PatientBirthDetails_IP ipdc, ref put_PatientBirthDetails_OP opdc)
        {
            m_WhereCondition = " WHERE ID = " + ipdc.m_Patient.ID.ToString();
            List<tbl_mas_patient_birthdetails> m_PatientTemp = new List<tbl_mas_patient_birthdetails>();
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

        private int put_PatientBirthDetails_Insert(ref put_PatientBirthDetails_IP ipdc, ref put_PatientBirthDetails_OP opdc)
        {
            List<tbl_mas_patient_birthdetails> m_PatientTemp = new List<tbl_mas_patient_birthdetails>();
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

