
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.DB.Table;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.InPatient;
using PIHMS.CL.API.Util.DBAccess;


namespace PIHMS.CL.BL.InPatient
{
    public class BL_InPatient
    {
        private int rc;
        private cls_Util_DBAccess m_dbc;
        private cls_BC_IO _ip;
        private cls_BC_IO _op;

        public int get_IPCaseList(ref get_IPCaseList_IP ip, ref get_IPCaseList_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseList_BL bl = new get_IPCaseList_BL(ref m_dbc);
                rc = bl.get_IPCaseList(ref ip, ref op);
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

        public int get_IPCaseListMaster(ref get_IPCaseListMaster_IP ip, ref get_IPCaseListMaster_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseListMaster_BL bl = new get_IPCaseListMaster_BL(ref m_dbc);
                rc = bl.get_IPCaseListMaster(ref ip, ref op);
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


        public int get_IPCaseDetail(ref get_IPCaseDetail_IP ip, ref get_IPCaseDetail_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseDetail_BL bl = new get_IPCaseDetail_BL(ref m_dbc);
                rc = bl.get_IPCaseDetail(ref ip, ref op);
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

        public int get_IPCaseWardDetails(ref get_IPCaseWardDetails_IP ip, ref get_IPCaseWardDetails_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseWardDetails_BL bl = new get_IPCaseWardDetails_BL(ref m_dbc);
                rc = bl.get_IPCaseWardDetails(ref ip, ref op);
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

        public int get_IPCaseSignsAndSystems(ref get_IPCaseSignsAndSystems_IP ip, ref get_IPCaseSignsAndSystems_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseSignsAndSystems_BL bl = new get_IPCaseSignsAndSystems_BL(ref m_dbc);
                rc = bl.get_IPCaseSignsAndSystems(ref ip, ref op);
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

        public int get_IPCaseVitalSigns(ref get_IPCaseVitalSigns_IP ip, ref get_IPCaseVitalSigns_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseVitalSigns_BL bl = new get_IPCaseVitalSigns_BL(ref m_dbc);
                rc = bl.get_IPCaseVitalSigns(ref ip, ref op);
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

        public int get_IPcaseSurgicalNotes(ref get_IPcaseSurgicalNotes_IP ip, ref get_IPcaseSurgicalNotes_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPcaseSurgicalNotes_BL bl = new get_IPcaseSurgicalNotes_BL(ref m_dbc);
                rc = bl.get_IPcaseSurgicalNotes(ref ip, ref op);
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

        public int get_IPCaseDoctorConsultations(ref get_IPCaseDoctorConsultations_IP ip, ref get_IPCaseDoctorConsultations_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseDoctorConsultations_BL bl = new get_IPCaseDoctorConsultations_BL(ref m_dbc);
                rc = bl.get_IPCaseDoctorConsultations(ref ip, ref op);
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


        public int get_IPCaseBedConsumables(ref get_IPCaseBedConsumables_IP ip, ref get_IPCaseBedConsumables_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseBedConsumables_BL bl = new get_IPCaseBedConsumables_BL(ref m_dbc);
                rc = bl.get_IPCaseBedConsumables(ref ip, ref op);
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

        public int get_IPCaseOTConsumables(ref get_IPCaseOTConsumables_IP ip, ref get_IPCaseOTConsumables_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseOTConsumables_BL bl = new get_IPCaseOTConsumables_BL(ref m_dbc);
                rc = bl.get_IPCaseOTConsumables(ref ip, ref op);
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

        public int get_IPCaseDischargeDetails(ref get_IPCaseDischargeDetails_IP ip, ref get_IPCaseDischargeDetails_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseDischargeDetails_BL bl = new get_IPCaseDischargeDetails_BL(ref m_dbc);
                rc = bl.get_IPCaseDischargeDetails(ref ip, ref op);
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
        public int get_IPCaseBillDetail(ref get_IPCaseBillDetail_IP ip, ref get_IPCaseBillDetail_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseBillDetail_BL bl = new get_IPCaseBillDetail_BL(ref m_dbc);
                rc = bl.get_IPCaseBillDetail(ref ip, ref op);
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

        public int get_IPCaseInsurancePaymentDetail(ref get_IPCaseInsurancePaymentDetail_IP ip, ref get_IPCaseInsurancePaymentDetail_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseInsurancePaymentDetail_BL bl = new get_IPCaseInsurancePaymentDetail_BL(ref m_dbc);
                rc = bl.get_IPCaseInsurancePaymentDetail(ref ip, ref op);
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

        public int get_IPCaseMedication(ref get_IPCaseMedication_IP ip, ref get_IPCaseMedication_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseMedication_BL bl = new get_IPCaseMedication_BL(ref m_dbc);
                rc = bl.get_IPCaseMedication(ref ip, ref op);
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

        public int get_NewIPCaseMaster(ref get_NewIPCaseMaster_IP ip, ref get_NewIPCaseMaster_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_NewIPCaseMaster_BL bl = new get_NewIPCaseMaster_BL(ref m_dbc);
                rc = bl.get_NewIPCaseMaster(ref ip, ref op);
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

        public int get_IPCaseAdmittedFor(ref get_IPCaseAdmittedFor_IP ip, ref get_IPCaseAdmittedFor_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseAdmittedFor_BL bl = new get_IPCaseAdmittedFor_BL(ref m_dbc);
                rc = bl.get_IPCaseAdmittedFor(ref ip, ref op);
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
        public int get_IPCaseBillItems(ref get_IPCaseBillItems_IP ip, ref get_IPCaseBillItems_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseBillItems_BL bl = new get_IPCaseBillItems_BL(ref m_dbc);
                rc = bl.get_IPCaseBillItems(ref ip, ref op);
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
        public int get_IPCaseBills(ref get_IPCaseBills_IP ip, ref get_IPCaseBills_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseBills_BL bl = new get_IPCaseBills_BL(ref m_dbc);
                rc = bl.get_IPCaseBills(ref ip, ref op);
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




        public int get_IPCaseBillPayments(ref get_IPCaseBillPayments_IP ip, ref get_IPCaseBillPayments_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseBillPayments_BL bl = new get_IPCaseBillPayments_BL(ref m_dbc);
                rc = bl.get_IPCaseBillPayments(ref ip, ref op);
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
        public int get_IPCaseBillPaymentReciept(ref get_IPCaseBillPaymentReciept_IP ip, ref get_IPCaseBillPaymentReciept_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseBillPaymentReciept_BL bl = new get_IPCaseBillPaymentReciept_BL(ref m_dbc);
                rc = bl.get_IPCaseBillPaymentReciept(ref ip, ref op);
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
 
        public int get_IPCaseDemographicInfo(ref get_IPCaseDemographicInfo_IP ip, ref get_IPCaseDemographicInfo_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseDemographicInfo_BL bl = new get_IPCaseDemographicInfo_BL(ref m_dbc);
                rc = bl.get_IPCaseDemographicInfo(ref ip, ref op);
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
        public int get_IPCaseDischargeSummary(ref get_IPCaseDischargeSummary_IP ip, ref get_IPCaseDischargeSummary_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseDischargeSummary_BL bl = new get_IPCaseDischargeSummary_BL(ref m_dbc);
                rc = bl.get_IPCaseDischargeSummary(ref ip, ref op);
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
            public int get_IPCaseConsumeable(ref get_IPCaseConsumeable_IP ip, ref get_IPCaseConsumeable_OP op)
            {
                _ip = ip; _op = op;
                if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
                {
                    return -1;
                }

                try
                {
                    get_IPCaseConsumeable_BL bl = new get_IPCaseConsumeable_BL(ref m_dbc);
                    rc = bl.get_IPCaseConsumeable(ref ip, ref op);
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
        public int get_IPCaseBillSummary(ref get_IPCaseBillSummary_IP ip, ref get_IPCaseBillSummary_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseBillSummary_BL bl = new get_IPCaseBillSummary_BL(ref m_dbc);
                rc = bl.get_IPCaseBillSummary(ref ip, ref op);
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
       
            public int get_IPCaseInsuranceDetail(ref get_IPCaseInsuranceDetail_IP ip, ref get_IPCaseInsuranceDetail_OP op)
            {
                _ip = ip; _op = op;
                if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
                {
                    return -1;
                }

                try
                {
                get_IPCaseInsuranceDetail_BL bl = new get_IPCaseInsuranceDetail_BL(ref m_dbc);
                    rc = bl.get_IPCaseInsuranceDetail(ref ip, ref op);
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
        public int get_IPCaseInsurenceReceived(ref get_IPCaseInsurenceReceived_IP ip, ref get_IPCaseInsurenceReceived_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseInsurenceReceived_BL bl = new get_IPCaseInsurenceReceived_BL(ref m_dbc);
                rc = bl.get_IPCaseInsurenceReceived(ref ip, ref op);
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
        public int get_IPCaseConsumeableDetail(ref get_IPCaseConsumeableDetail_IP ip, ref get_IPCaseConsumeableDetail_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseConsumeableDetail_BL bl = new get_IPCaseConsumeableDetail_BL(ref m_dbc);
                rc = bl.get_IPCaseConsumeableDetail(ref ip, ref op);
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



        public int get_IPCasePatientAddress(ref get_IPCasePatientAddress_IP ip, ref get_IPCasePatientAddress_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCasePatientAddress_BL bl = new get_IPCasePatientAddress_BL(ref m_dbc);
                rc = bl.get_IPCasePatientAddress(ref ip, ref op);
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
        public int get_IPCaseMedications(ref get_IPCaseMedications_IP ip, ref get_IPCaseMedications_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseMedications_BL bl = new get_IPCaseMedications_BL(ref m_dbc);
                rc = bl.get_IPCaseMedications(ref ip, ref op);
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
        
        public int get_IPCaseInsurencePayment(ref get_IPCaseInsurencePayment_IP ip, ref get_IPCaseInsurencePayment_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseInsurencePayment_BL bl = new get_IPCaseInsurencePayment_BL(ref m_dbc);
                rc = bl.get_IPCaseInsurencePayment(ref ip, ref op);
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
        public int get_IPCaseDsTitle(ref get_IPCaseDsTitle_IP ip, ref get_IPCaseDsTitle_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseDsTitle_BL bl = new get_IPCaseDsTitle_BL(ref m_dbc);
                rc = bl.get_IPCaseDsTitle(ref ip, ref op);
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
        public int get_IPCaseDsTemplateData(ref get_IPCaseDsTemplateData_IP ip, ref get_IPCaseDsTemplateData_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseDsTemplateData_BL bl = new get_IPCaseDsTemplateData_BL(ref m_dbc);
                rc = bl.get_IPCaseDsTemplateData(ref ip, ref op);
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
        public int get_IPCaseDiagnosisTagging(ref get_IPCaseDiagnosisTagging_IP ip, ref get_IPCaseDiagnosisTagging_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseDiagnosisTagging_BL bl = new get_IPCaseDiagnosisTagging_BL(ref m_dbc);
                rc = bl.get_IPCaseDiagnosisTagging(ref ip, ref op);
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
        public int get_IPCaseICDCodes(ref get_IPCaseICDCodes_IP ip, ref get_IPCaseICDCodes_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseICDCodes_BL bl = new get_IPCaseICDCodes_BL(ref m_dbc);
                rc = bl.get_IPCaseICDCodes(ref ip, ref op);
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
        public int get_IPCaseDoctors(ref get_IPCaseDoctors_IP ip, ref get_IPCaseDoctors_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseDoctors_BL bl = new get_IPCaseDoctors_BL(ref m_dbc);
                rc = bl.get_IPCaseDoctors(ref ip, ref op);
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
    
        public int get_IPCaseDsTemplate(ref get_IPCaseDsTemplate_IP ip, ref get_IPCaseDsTemplate_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseDsTemplate_BL bl = new get_IPCaseDsTemplate_BL(ref m_dbc);
                rc = bl.get_IPCaseDsTemplate(ref ip, ref op);
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
        public int get_IPCaseEstItems(ref get_IPCaseEstItems_IP ip, ref get_IPCaseEstItems_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseEstItems_BL bl = new get_IPCaseEstItems_BL(ref m_dbc);
                rc = bl.get_IPCaseEstItems(ref ip, ref op);
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
        public int get_IPCaseCorprationDetail(ref get_IPCaseCorprationDetail_IP ip, ref get_IPCaseCorprationDetail_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseCorprationDetail_BL bl = new get_IPCaseCorprationDetail_BL(ref m_dbc);
                rc = bl.get_IPCaseCorprationDetail(ref ip, ref op);
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
        public int get_IPCaseEstimatedBillItems(ref get_IPCaseEstimatedBillItems_IP ip, ref get_IPCaseEstimatedBillItems_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseEstimatedBillItems_BL bl = new get_IPCaseEstimatedBillItems_BL(ref m_dbc);
                rc = bl.get_IPCaseEstimatedBillItems(ref ip, ref op);
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
        public int get_IPCaseEstimatedBills(ref get_IPCaseEstimatedBills_IP ip, ref get_IPCaseEstimatedBills_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseEstimatedBills_BL bl = new get_IPCaseEstimatedBills_BL(ref m_dbc);
                rc = bl.get_IPCaseEstimatedBills(ref ip, ref op);
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
        public int get_IPCaseEvents(ref get_IPCaseEvents_IP ip, ref get_IPCaseEvents_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseEvents_BL bl = new get_IPCaseEvents_BL(ref m_dbc);
                rc = bl.get_IPCaseEvents(ref ip, ref op);
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
        public int get_IPCaseNotes(ref get_IPCaseNotes_IP ip, ref get_IPCaseNotes_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseNotes_BL bl = new get_IPCaseNotes_BL(ref m_dbc);
                rc = bl.get_IPCaseNotes(ref ip, ref op);
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
       
        public int get_IPCaseSurgeryNotes(ref get_IPCaseSurgeryNotes_IP ip, ref get_IPCaseSurgeryNotes_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPCaseSurgeryNotes_BL bl = new get_IPCaseSurgeryNotes_BL(ref m_dbc);
                rc = bl.get_IPCaseSurgeryNotes(ref ip, ref op);
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
        public int get_IPDoctorPrice(ref get_IPDoctorPrice_IP ip, ref get_IPDoctorPrice_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPDoctorPrice_BL bl = new get_IPDoctorPrice_BL(ref m_dbc);
                rc = bl.get_IPDoctorPrice(ref ip, ref op);
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

        public int get_IPScanCasesheet(ref get_IPScanCasesheet_IP ip, ref get_IPScanCasesheet_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPScanCasesheet_BL bl = new get_IPScanCasesheet_BL(ref m_dbc);
                rc = bl.get_IPScanCasesheet(ref ip, ref op);
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
        public int get_IPWardequipments(ref get_IPWardequipments_IP ip, ref get_IPWardequipments_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPWardequipments_BL bl = new get_IPWardequipments_BL(ref m_dbc);
                rc = bl.get_IPWardequipments(ref ip, ref op);
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
        public int get_IPWardincharge(ref get_IPWardincharge_IP ip, ref get_IPWardincharge_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPWardincharge_BL bl = new get_IPWardincharge_BL(ref m_dbc);
                rc = bl.get_IPWardincharge(ref ip, ref op);
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
        public int get_IPWardschedule(ref get_IPWardschedule_IP ip, ref get_IPWardschedule_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_IPWardschedule_BL bl = new get_IPWardschedule_BL(ref m_dbc);
                rc = bl.get_IPWardschedule(ref ip, ref op);
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


        public int put_IPCaseList(ref put_IPCaseList_IP ip, ref put_IPCaseList_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseList_BL bl = new put_IPCaseList_BL(ref m_dbc);
                rc = bl.put_IPCaseList(ref ip, ref op);
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
        public int put_IPCaseBillItems(ref put_IPCaseBillItems_IP ip, ref put_IPCaseBillItems_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseBillItems_BL bl = new put_IPCaseBillItems_BL(ref m_dbc);
                rc = bl.put_IPCaseBillItems(ref ip, ref op);
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
        public int put_IPCaseBills(ref put_IPCaseBills_IP ip, ref put_IPCaseBills_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseBills_BL bl = new put_IPCaseBills_BL(ref m_dbc);
                rc = bl.put_IPCaseBills(ref ip, ref op);
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




        public int put_IPCaseBillPayments(ref put_IPCaseBillPayments_IP ip, ref put_IPCaseBillPayments_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseBillPayments_BL bl = new put_IPCaseBillPayments_BL(ref m_dbc);
                rc = bl.put_IPCaseBillPayments(ref ip, ref op);
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
        public int put_IPCaseBillPaymentReciept(ref put_IPCaseBillPaymentReciept_IP ip, ref put_IPCaseBillPaymentReciept_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseBillPaymentReciept_BL bl = new put_IPCaseBillPaymentReciept_BL(ref m_dbc);
                rc = bl.put_IPCaseBillPaymentReciept(ref ip, ref op);
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
        public int put_IPCaseWardDetails(ref put_IPCaseWardDetails_IP ip, ref put_IPCaseWardDetails_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseWardDetails_BL bl = new put_IPCaseWardDetails_BL(ref m_dbc);
                rc = bl.put_IPCaseWardDetails(ref ip, ref op);
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
        public int put_IPCaseDemographicInfo(ref put_IPCaseDemographicInfo_IP ip, ref put_IPCaseDemographicInfo_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseDemographicInfo_BL bl = new put_IPCaseDemographicInfo_BL(ref m_dbc);
                rc = bl.put_IPCaseDemographicInfo(ref ip, ref op);
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
        public int put_IPCaseDischargeSummary(ref put_IPCaseDischargeSummary_IP ip, ref put_IPCaseDischargeSummary_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseDischargeSummary_BL bl = new put_IPCaseDischargeSummary_BL(ref m_dbc);
                rc = bl.put_IPCaseDischargeSummary(ref ip, ref op);
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
        public int put_IPCaseConsumeable(ref put_IPCaseConsumeable_IP ip, ref put_IPCaseConsumeable_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseConsumeable_BL bl = new put_IPCaseConsumeable_BL(ref m_dbc);
                rc = bl.put_IPCaseConsumeable(ref ip, ref op);
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
        public int put_IPCaseBillSummary(ref put_IPCaseBillSummary_IP ip, ref put_IPCaseBillSummary_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseBillSummary_BL bl = new put_IPCaseBillSummary_BL(ref m_dbc);
                rc = bl.put_IPCaseBillSummary(ref ip, ref op);
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

        public int put_IPCaseInsuranceDetail(ref put_IPCaseInsuranceDetail_IP ip, ref put_IPCaseInsuranceDetail_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseInsuranceDetail_BL bl = new put_IPCaseInsuranceDetail_BL(ref m_dbc);
                rc = bl.put_IPCaseInsuranceDetail(ref ip, ref op);
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
        public int put_IPCaseInsurenceReceived(ref put_IPCaseInsurenceReceived_IP ip, ref put_IPCaseInsurenceReceived_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseInsurenceReceived_BL bl = new put_IPCaseInsurenceReceived_BL(ref m_dbc);
                rc = bl.put_IPCaseInsurenceReceived(ref ip, ref op);
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
        public int put_IPCaseConsumeableDetail(ref put_IPCaseConsumeableDetail_IP ip, ref put_IPCaseConsumeableDetail_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseConsumeableDetail_BL bl = new put_IPCaseConsumeableDetail_BL(ref m_dbc);
                rc = bl.put_IPCaseConsumeableDetail(ref ip, ref op);
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



        public int put_IPCasePatientAddress(ref put_IPCasePatientAddress_IP ip, ref put_IPCasePatientAddress_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCasePatientAddress_BL bl = new put_IPCasePatientAddress_BL(ref m_dbc);
                rc = bl.put_IPCasePatientAddress(ref ip, ref op);
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
        public int put_IPCaseMedications(ref put_IPCaseMedications_IP ip, ref put_IPCaseMedications_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseMedications_BL bl = new put_IPCaseMedications_BL(ref m_dbc);
                rc = bl.put_IPCaseMedications(ref ip, ref op);
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
        public int put_IPCaseAdmittedFor(ref put_IPCaseAdmittedFor_IP ip, ref put_IPCaseAdmittedFor_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseAdmittedFor_BL bl = new put_IPCaseAdmittedFor_BL(ref m_dbc);
                rc = bl.put_IPCaseAdmittedFor(ref ip, ref op);
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
        public int put_IPCaseInsurencePayment(ref put_IPCaseInsurencePayment_IP ip, ref put_IPCaseInsurencePayment_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseInsurencePayment_BL bl = new put_IPCaseInsurencePayment_BL(ref m_dbc);
                rc = bl.put_IPCaseInsurencePayment(ref ip, ref op);
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
        public int put_IPCaseDsTitle(ref put_IPCaseDsTitle_IP ip, ref put_IPCaseDsTitle_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseDsTitle_BL bl = new put_IPCaseDsTitle_BL(ref m_dbc);
                rc = bl.put_IPCaseDsTitle(ref ip, ref op);
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
        public int put_IPCaseDsTemplateData(ref put_IPCaseDsTemplateData_IP ip, ref put_IPCaseDsTemplateData_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseDsTemplateData_BL bl = new put_IPCaseDsTemplateData_BL(ref m_dbc);
                rc = bl.put_IPCaseDsTemplateData(ref ip, ref op);
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
        public int put_IPCaseDiagnosisTagging(ref put_IPCaseDiagnosisTagging_IP ip, ref put_IPCaseDiagnosisTagging_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseDiagnosisTagging_BL bl = new put_IPCaseDiagnosisTagging_BL(ref m_dbc);
                rc = bl.put_IPCaseDiagnosisTagging(ref ip, ref op);
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
        public int put_IPCaseICDCodes(ref put_IPCaseICDCodes_IP ip, ref put_IPCaseICDCodes_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseICDCodes_BL bl = new put_IPCaseICDCodes_BL(ref m_dbc);
                rc = bl.put_IPCaseICDCodes(ref ip, ref op);
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
        public int put_IPCaseDoctors(ref put_IPCaseDoctors_IP ip, ref put_IPCaseDoctors_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseDoctors_BL bl = new put_IPCaseDoctors_BL(ref m_dbc);
                rc = bl.put_IPCaseDoctors(ref ip, ref op);
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
        public int put_IPCaseVitalSigns(ref put_IPCaseVitalSigns_IP ip, ref put_IPCaseVitalSigns_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseVitalSigns_BL bl = new put_IPCaseVitalSigns_BL(ref m_dbc);
                rc = bl.put_IPCaseVitalSigns(ref ip, ref op);
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
        public int put_IPCaseDsTemplate(ref put_IPCaseDsTemplate_IP ip, ref put_IPCaseDsTemplate_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseDsTemplate_BL bl = new put_IPCaseDsTemplate_BL(ref m_dbc);
                rc = bl.put_IPCaseDsTemplate(ref ip, ref op);
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
        public int put_IPCaseEstItems(ref put_IPCaseEstItems_IP ip, ref put_IPCaseEstItems_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseEstItems_BL bl = new put_IPCaseEstItems_BL(ref m_dbc);
                rc = bl.put_IPCaseEstItems(ref ip, ref op);
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
        public int put_IPCaseCorprationDetail(ref put_IPCaseCorprationDetail_IP ip, ref put_IPCaseCorprationDetail_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseCorprationDetail_BL bl = new put_IPCaseCorprationDetail_BL(ref m_dbc);
                rc = bl.put_IPCaseCorprationDetail(ref ip, ref op);
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
        public int put_IPCaseEstimatedBillItems(ref put_IPCaseEstimatedBillItems_IP ip, ref put_IPCaseEstimatedBillItems_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseEstimatedBillItems_BL bl = new put_IPCaseEstimatedBillItems_BL(ref m_dbc);
                rc = bl.put_IPCaseEstimatedBillItems(ref ip, ref op);
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
        public int put_IPCaseEstimatedBills(ref put_IPCaseEstimatedBills_IP ip, ref put_IPCaseEstimatedBills_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseEstimatedBills_BL bl = new put_IPCaseEstimatedBills_BL(ref m_dbc);
                rc = bl.put_IPCaseEstimatedBills(ref ip, ref op);
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
        public int put_IPCaseEvents(ref put_IPCaseEvents_IP ip, ref put_IPCaseEvents_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseEvents_BL bl = new put_IPCaseEvents_BL(ref m_dbc);
                rc = bl.put_IPCaseEvents(ref ip, ref op);
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
        public int put_IPCaseNotes(ref put_IPCaseNotes_IP ip, ref put_IPCaseNotes_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseNotes_BL bl = new put_IPCaseNotes_BL(ref m_dbc);
                rc = bl.put_IPCaseNotes(ref ip, ref op);
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
        public int put_IPCaseSignandSymptoms(ref put_IPCaseSignandSymptoms_IP ip, ref put_IPCaseSignandSymptoms_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseSignandSymptoms_BL bl = new put_IPCaseSignandSymptoms_BL(ref m_dbc);
                rc = bl.put_IPCaseSignandSymptoms(ref ip, ref op);
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
        public int put_IPCaseSurgeryNotes(ref put_IPCaseSurgeryNotes_IP ip, ref put_IPCaseSurgeryNotes_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPCaseSurgeryNotes_BL bl = new put_IPCaseSurgeryNotes_BL(ref m_dbc);
                rc = bl.put_IPCaseSurgeryNotes(ref ip, ref op);
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

        public int put_IPDoctorPrice(ref put_IPDoctorPrice_IP ip, ref put_IPDoctorPrice_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPDoctorPrice_BL bl = new put_IPDoctorPrice_BL(ref m_dbc);
                rc = bl.put_IPDoctorPrice(ref ip, ref op);
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
        public int put_IPScanCasesheet(ref put_IPScanCasesheet_IP ip, ref put_IPScanCasesheet_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPScanCasesheet_BL bl = new put_IPScanCasesheet_BL(ref m_dbc);
                rc = bl.put_IPScanCasesheet(ref ip, ref op);
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
        public int put_IPWardequipments(ref put_IPWardequipments_IP ip, ref put_IPWardequipments_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPWardequipments_BL bl = new put_IPWardequipments_BL(ref m_dbc);
                rc = bl.put_IPWardequipments(ref ip, ref op);
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
        public int put_IPWardincharge(ref put_IPWardincharge_IP ip, ref put_IPWardincharge_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPWardincharge_BL bl = new put_IPWardincharge_BL(ref m_dbc);
                rc = bl.put_IPWardincharge(ref ip, ref op);
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
        public int put_IPWardschedule(ref put_IPWardschedule_IP ip, ref put_IPWardschedule_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_IPWardschedule_BL bl = new put_IPWardschedule_BL(ref m_dbc);
                rc = bl.put_IPWardschedule(ref ip, ref op);
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