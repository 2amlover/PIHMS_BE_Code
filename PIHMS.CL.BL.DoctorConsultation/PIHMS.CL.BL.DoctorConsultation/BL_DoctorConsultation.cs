using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.DB.Table;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.DoctorConsultation;
using PIHMS.CL.API.Util.DBAccess;


namespace PIHMS.CL.BL.DoctorConsultation
{
    public class BL_DoctorConsultation
    {
        private int rc;
        private cls_Util_DBAccess m_dbc;
        private cls_BC_IO _ip;
        private cls_BC_IO _op;




        public int get_ConsultScannedFiles(ref get_ConsultScannedFiles_IP ip, ref get_ConsultScannedFiles_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_ConsultScannedFiles_BL bl = new get_ConsultScannedFiles_BL(ref m_dbc);
                rc = bl.get_ConsultScannedFiles(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int get_DoctorConsultation(ref get_DoctorConsultation_IP ip, ref get_DoctorConsultation_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_DoctorConsultation_BL bl = new get_DoctorConsultation_BL(ref m_dbc);
                rc = bl.get_DoctorConsultation(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }


        public int get_DoctorConsultationDocument(ref get_DoctorConsultationDocument_IP ip, ref get_DoctorConsultationDocument_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_DoctorConsultationDocument_BL bl = new get_DoctorConsultationDocument_BL(ref m_dbc);
                rc = bl.get_DoctorConsultationDocument(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }


        public int get_DoctorConsultationInvreq(ref get_DoctorConsultationInvreq_IP ip, ref get_DoctorConsultationInvreq_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_DoctorConsultationInvreq_BL bl = new get_DoctorConsultationInvreq_BL(ref m_dbc);
                rc = bl.get_DoctorConsultationInvreq(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }


        public int get_DoctorConsultationInvreqItem(ref get_DoctorConsultationInvreqItem_IP ip, ref get_DoctorConsultationInvreqItem_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_DoctorConsultationInvreqItem_BL bl = new get_DoctorConsultationInvreqItem_BL(ref m_dbc);
                rc = bl.get_DoctorConsultationInvreqItem(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int get_DoctorConsultationMedication(ref get_DoctorConsultationMedication_IP ip, ref get_DoctorConsultationMedication_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_DoctorConsultationMedication_BL bl = new get_DoctorConsultationMedication_BL(ref m_dbc);
                rc = bl.get_DoctorConsultationMedication(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int get_OPConsultAppointment(ref get_OPConsultAppointment_IP ip, ref get_OPConsultAppointment_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_OPConsultAppointment_BL bl = new get_OPConsultAppointment_BL(ref m_dbc);
                rc = bl.get_OPConsultAppointment(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int get_PharmacyOpconsultItem(ref get_PharmacyOpconsultItem_IP ip, ref get_PharmacyOpconsultItem_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_PharmacyOpconsultItem_BL bl = new get_PharmacyOpconsultItem_BL(ref m_dbc);
                rc = bl.get_PharmacyOpconsultItem(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int put_ConsultScannedFiles(ref put_ConsultScannedFiles_IP ip, ref put_ConsultScannedFiles_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_ConsultScannedFiles_BL bl = new put_ConsultScannedFiles_BL(ref m_dbc);
                rc = bl.put_ConsultScannedFiles(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }

        public int put_DoctorConsultation(ref put_DoctorConsultation_IP ip, ref put_DoctorConsultation_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_DoctorConsultation_BL bl = new put_DoctorConsultation_BL(ref m_dbc);
                rc = bl.put_DoctorConsultation(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int put_DoctorConsultationDocument(ref put_DoctorConsultationDocument_IP ip, ref put_DoctorConsultationDocument_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_DoctorConsultationDocument_BL bl = new put_DoctorConsultationDocument_BL(ref m_dbc);
                rc = bl.put_DoctorConsultationDocument(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int put_DoctorConsultationInvreq(ref put_DoctorConsultationInvreq_IP ip, ref put_DoctorConsultationInvreq_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_DoctorConsultationInvreq_BL bl = new put_DoctorConsultationInvreq_BL(ref m_dbc);
                rc = bl.put_DoctorConsultationInvreq(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int put_DoctorConsultationInvreqItem(ref put_DoctorConsultationInvreqItem_IP ip, ref put_DoctorConsultationInvreqItem_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_DoctorConsultationInvreqItem_BL bl = new put_DoctorConsultationInvreqItem_BL(ref m_dbc);
                rc = bl.put_DoctorConsultationInvreqItem(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int put_DoctorConsultationMedication(ref put_DoctorConsultationMedication_IP ip, ref put_DoctorConsultationMedication_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_DoctorConsultationMedication_BL bl = new put_DoctorConsultationMedication_BL(ref m_dbc);
                rc = bl.put_DoctorConsultationMedication(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int put_OPConsultAppointment(ref put_OPConsultAppointment_IP ip, ref put_OPConsultAppointment_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_OPConsultAppointment_BL bl = new put_OPConsultAppointment_BL(ref m_dbc);
                rc = bl.put_OPConsultAppointment(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int put_PharmacyOpconsultItem(ref put_PharmacyOpconsultItem_IP ip, ref put_PharmacyOpconsultItem_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_PharmacyOpconsultItem_BL bl = new put_PharmacyOpconsultItem_BL(ref m_dbc);
                rc = bl.put_PharmacyOpconsultItem(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }
    }
}
