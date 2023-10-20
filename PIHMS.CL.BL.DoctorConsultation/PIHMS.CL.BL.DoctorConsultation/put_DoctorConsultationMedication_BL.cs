using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.DoctorConsultation;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.DoctorConsultation
{
    class put_DoctorConsultationMedication_BL : cls_BC_BusinessLogic
    {
        public put_DoctorConsultationMedication_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }
        public int put_DoctorConsultationMedication(ref put_DoctorConsultationMedication_IP ipdc, ref put_DoctorConsultationMedication_OP opdc)
        {
            if (ipdc.m_DoctorConsultation.ID > 0)
            {
                //Update Existing Row

                m_rc = put_DoctorConsultationMedication_Update(ref ipdc, ref opdc);
                Console.WriteLine("  UPDATE EXISTING ROW SUCCESSFULLY, " + ipdc.m_DoctorConsultation.ID.ToString() + "   tbl_trn_doctor_consultation_medication");
            }

            else
            {
                //Insert New Row

                m_rc = put_DoctorConsultationMedication_Insert(ref ipdc, ref opdc);
                Console.WriteLine(" NEW ROW INSERT SUCCESSFULLY, " + ipdc.m_DoctorConsultation.ID.ToString() + " tbl_trn_doctor_consultation_medication");
            }
            return m_rc;
        }
        private int put_DoctorConsultationMedication_Update(ref put_DoctorConsultationMedication_IP ipdc, ref put_DoctorConsultationMedication_OP opdc)
        {
            m_WhereCondition = " WHERE ID = " + ipdc.m_DoctorConsultation.ID.ToString();
            List<tbl_trn_doctor_consultation_medication> m_DoctorConsultationTemp = new List<tbl_trn_doctor_consultation_medication>();
            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_DoctorConsultationTemp);

            ipdc.m_DoctorConsultation.UpdatedDateTime = DateTime.Now;
            ipdc.m_DoctorConsultation.CreatedDateTime = DateTime.Now;
            ipdc.m_DoctorConsultation.UpdatedDateTime = DateTime.Now;
            ipdc.m_DoctorConsultation.IsRowDeleted = "N";

            m_DoctorConsultationTemp.Add(ipdc.m_DoctorConsultation);
            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_DoctorConsultationTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }
            opdc.m_DoctorConsultation = m_DoctorConsultationTemp[0];
            return m_rc;
        }

        private int put_DoctorConsultationMedication_Insert(ref put_DoctorConsultationMedication_IP ipdc, ref put_DoctorConsultationMedication_OP opdc)
        {
            List<tbl_trn_doctor_consultation_medication> m_DoctorConsultationTemp = new List<tbl_trn_doctor_consultation_medication>();
            ipdc.m_DoctorConsultation.CreatedDateTime = DateTime.Now;
            ipdc.m_DoctorConsultation.UpdatedDateTime = DateTime.Now;
            ipdc.m_DoctorConsultation.IsRowDeleted = "N";

            m_DoctorConsultationTemp.Add(ipdc.m_DoctorConsultation);
            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_DoctorConsultationTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }
            opdc.m_DoctorConsultation = m_DoctorConsultationTemp[0];
            return m_rc;
        }
    }
}















