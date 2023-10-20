

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Appointment;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.Appointment
{
    class put_Appointment_BL : cls_BC_BusinessLogic
    {
        public put_Appointment_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

      
        public int put_Appointment(ref put_Appointment_IP ipdc, ref put_Appointment_OP opdc)
        {
                if (ipdc.m_Appointment.ID > 0)
                {
                    //Update Existing Row

                    m_rc = put_Appointment_Update(ref ipdc, ref opdc);
                }
            
            else 
                //Insert New Row

                m_rc = put_Appointment_Insert(ref ipdc, ref opdc);
           

            return m_rc;
        }
        private int put_Appointment_Insert(ref put_Appointment_IP ipdc, ref put_Appointment_OP opdc)
        {
            List<tbl_trn_appointment> ml_AppointmentTemp = new List<tbl_trn_appointment>();
            ipdc.m_Appointment.CreatedDateTime = DateTime.Now;
            ipdc.m_Appointment.UpdatedDateTime = DateTime.Now;
            ipdc.m_Appointment.IsRowDeleted = "N";
            ml_AppointmentTemp.Add(ipdc.m_Appointment);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref ml_AppointmentTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.m_Appointment = ml_AppointmentTemp[0];
            Console.WriteLine("INSERTED SUCCESSFULLY");
            return m_rc;
        }


        private int put_Appointment_Update(ref put_Appointment_IP ipdc, ref put_Appointment_OP opdc)
        {

            List<tbl_trn_appointment> ml_AppointmentTemp = new List<tbl_trn_appointment>();
            ipdc.m_Appointment.UpdatedDateTime = DateTime.Now;

            ml_AppointmentTemp.Add(ipdc.m_Appointment);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref ml_AppointmentTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.m_Appointment = ml_AppointmentTemp[0];
            Console.WriteLine("UPDATED SUCCESSFULLY " );
            return m_rc;
        }

    }
}






