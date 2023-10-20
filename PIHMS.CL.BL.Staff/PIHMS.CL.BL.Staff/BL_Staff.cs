
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.DB.Table;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Staff;
using PIHMS.CL.API.Util.DBAccess;


namespace PIHMS.CL.BL.Staff
{
    public class BL_Staff
    {
        private int rc;
        private cls_Util_DBAccess m_dbc;
        private cls_BC_IO _ip;
        private cls_BC_IO _op;



        public int get_StaffAttendence(ref get_StaffAttendence_IP ip, ref get_StaffAttendence_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffAttendence_BL bl = new get_StaffAttendence_BL(ref m_dbc);
                rc = bl.get_StaffAttendence(ref ip, ref op);
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

        public int get_StaffBankDetail(ref get_StaffBankDetail_IP ip, ref get_StaffBankDetail_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffBankDetail_BL bl = new get_StaffBankDetail_BL(ref m_dbc);
                rc = bl.get_StaffBankDetail(ref ip, ref op);
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


        public int get_StaffDetail(ref get_StaffDetail_IP ip, ref get_StaffDetail_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffDetail_BL bl = new get_StaffDetail_BL(ref m_dbc);
                rc = bl.get_StaffDetail(ref ip, ref op);
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

        public int get_StaffDocuments(ref get_StaffDocuments_IP ip, ref get_StaffDocuments_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffDocuments_BL bl = new get_StaffDocuments_BL(ref m_dbc);
                rc = bl.get_StaffDocuments(ref ip, ref op);
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

        public int get_StaffEducation(ref get_StaffEducation_IP ip, ref get_StaffEducation_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffEducation_BL bl = new get_StaffEducation_BL(ref m_dbc);
                rc = bl.get_StaffEducation(ref ip, ref op);
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



        public int get_StaffEmployment(ref get_StaffEmployment_IP ip, ref get_StaffEmployment_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffEmployment_BL bl = new get_StaffEmployment_BL(ref m_dbc);
                rc = bl.get_StaffEmployment(ref ip, ref op);
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



        public int get_StaffLeaves(ref get_StaffLeaves_IP ip, ref get_StaffLeaves_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffLeaves_BL bl = new get_StaffLeaves_BL(ref m_dbc);
                rc = bl.get_StaffLeaves(ref ip, ref op);
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



        public int get_StaffList(ref get_StaffList_IP ip, ref get_StaffList_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffList_BL bl = new get_StaffList_BL(ref m_dbc);
                rc = bl.get_StaffList(ref ip, ref op);
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


        public int get_StaffListMaster(ref get_StaffListMaster_IP ip, ref get_StaffListMaster_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffListMaster_BL bl = new get_StaffListMaster_BL(ref m_dbc);
                rc = bl.get_StaffListMaster(ref ip, ref op);
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

        public int get_StaffPayroll(ref get_StaffPayroll_IP ip, ref get_StaffPayroll_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffPayroll_BL bl = new get_StaffPayroll_BL(ref m_dbc);
                rc = bl.get_StaffPayroll(ref ip, ref op);
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


        public int get_StaffPaySlip(ref get_StaffPaySlip_IP ip, ref get_StaffPaySlip_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffPaySlip_BL bl = new get_StaffPaySlip_BL(ref m_dbc);
                rc = bl.get_StaffPaySlip(ref ip, ref op);
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

        public int get_Staff(ref get_Staff_IP ip, ref get_Staff_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_Staff_BL bl = new get_Staff_BL(ref m_dbc);
                rc = bl.get_Staff(ref ip, ref op);
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
        public int get_StaffAttendance(ref get_StaffAttendance_IP ip, ref get_StaffAttendance_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffAttendance_BL bl = new get_StaffAttendance_BL(ref m_dbc);
                rc = bl.get_StaffAttendance(ref ip, ref op);
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
        public int get_StaffBankDetails(ref get_StaffBankDetails_IP ip, ref get_StaffBankDetails_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffBankDetails_BL bl = new get_StaffBankDetails_BL(ref m_dbc);
                rc = bl.get_StaffBankDetails(ref ip, ref op);
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
      
        public int get_StaffLeaveSummary(ref get_StaffLeaveSummary_IP ip, ref get_StaffLeaveSummary_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffLeaveSummary_BL bl = new get_StaffLeaveSummary_BL(ref m_dbc);
                rc = bl.get_StaffLeaveSummary(ref ip, ref op);
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
        public int get_StaffLogin(ref get_StaffLogin_IP ip, ref get_StaffLogin_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffLogin_BL bl = new get_StaffLogin_BL(ref m_dbc);
                rc = bl.get_StaffLogin(ref ip, ref op);
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
        public int get_StaffMyDocuments(ref get_StaffMyDocuments_IP ip, ref get_StaffMyDocuments_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffMyDocuments_BL bl = new get_StaffMyDocuments_BL(ref m_dbc);
                rc = bl.get_StaffMyDocuments(ref ip, ref op);
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
   
        public int get_StaffPaySlips(ref get_StaffPaySlips_IP ip, ref get_StaffPaySlips_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffPaySlips_BL bl = new get_StaffPaySlips_BL(ref m_dbc);
                rc = bl.get_StaffPaySlips(ref ip, ref op);
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
        public int get_StaffReimbursements(ref get_StaffReimbursements_IP ip, ref get_StaffReimbursements_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffReimbursements_BL bl = new get_StaffReimbursements_BL(ref m_dbc);
                rc = bl.get_StaffReimbursements(ref ip, ref op);
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
        public int get_StaffRole(ref get_StaffRole_IP ip, ref get_StaffRole_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffRole_BL bl = new get_StaffRole_BL(ref m_dbc);
                rc = bl.get_StaffRole(ref ip, ref op);
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
        public int get_StaffRoleAppFeature(ref get_StaffRoleAppFeature_IP ip, ref get_StaffRoleAppFeature_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffRoleAppFeature_BL bl = new get_StaffRoleAppFeature_BL(ref m_dbc);
                rc = bl.get_StaffRoleAppFeature(ref ip, ref op);
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
        public int get_StaffRoleModule(ref get_StaffRoleModule_IP ip, ref get_StaffRoleModule_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffRoleModule_BL bl = new get_StaffRoleModule_BL(ref m_dbc);
                rc = bl.get_StaffRoleModule(ref ip, ref op);
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
        public int get_StaffSalaryDeduction(ref get_StaffSalaryDeduction_IP ip, ref get_StaffSalaryDeduction_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffSalaryDeduction_BL bl = new get_StaffSalaryDeduction_BL(ref m_dbc);
                rc = bl.get_StaffSalaryDeduction(ref ip, ref op);
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
        public int get_StaffSalaryEarnings(ref get_StaffSalaryEarnings_IP ip, ref get_StaffSalaryEarnings_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffSalaryEarnings_BL bl = new get_StaffSalaryEarnings_BL(ref m_dbc);
                rc = bl.get_StaffSalaryEarnings(ref ip, ref op);
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
        public int get_StaffWorkItems(ref get_StaffWorkItems_IP ip, ref get_StaffWorkItems_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffWorkItems_BL bl = new get_StaffWorkItems_BL(ref m_dbc);
                rc = bl.get_StaffWorkItems(ref ip, ref op);
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
        public int get_StaffYogDetails(ref get_StaffYogDetails_IP ip, ref get_StaffYogDetails_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffYogDetails_BL bl = new get_StaffYogDetails_BL(ref m_dbc);
                rc = bl.get_StaffYogDetails(ref ip, ref op);
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
        public int get_StaffSalarySummary(ref get_StaffSalarySummary_IP ip, ref get_StaffSalarySummary_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffSalarySummary_BL bl = new get_StaffSalarySummary_BL(ref m_dbc);
                rc = bl.get_StaffSalarySummary(ref ip, ref op);
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
        public int get_StaffAttendanceTrn(ref get_StaffAttendanceTrn_IP ip, ref get_StaffAttendanceTrn_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffAttendanceTrn_BL bl = new get_StaffAttendanceTrn_BL(ref m_dbc);
                rc = bl.get_StaffAttendanceTrn(ref ip, ref op);
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
        public int get_StaffEmploymentTrn(ref get_StaffEmploymentTrn_IP ip, ref get_StaffEmploymentTrn_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffEmploymentTrn_BL bl = new get_StaffEmploymentTrn_BL(ref m_dbc);
                rc = bl.get_StaffEmploymentTrn(ref ip, ref op);
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

        public int get_StaffLeavesTrn(ref get_StaffLeavesTrn_IP ip, ref get_StaffLeavesTrn_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffLeavesTrn_BL bl = new get_StaffLeavesTrn_BL(ref m_dbc);
                rc = bl.get_StaffLeavesTrn(ref ip, ref op);
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
        public int get_StaffSalaryEarningsTrn(ref get_StaffSalaryEarningsTrn_IP ip, ref get_StaffSalaryEarningsTrn_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_StaffSalaryEarningsTrn_BL bl = new get_StaffSalaryEarningsTrn_BL(ref m_dbc);
                rc = bl.get_StaffSalaryEarningsTrn(ref ip, ref op);
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

        public int put_StaffList(ref put_Staff_IP ip, ref put_Staff_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffList_BL bl = new put_StaffList_BL(ref m_dbc);
                rc = bl.put_StaffList(ref ip, ref op);
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
        public int put_StaffAttendance(ref put_StaffAttendance_IP ip, ref put_StaffAttendance_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffAttendance_BL bl = new put_StaffAttendance_BL(ref m_dbc);
                rc = bl.put_StaffAttendance(ref ip, ref op);
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
        public int put_StaffBankDetails(ref put_StaffBankDetails_IP ip, ref put_StaffBankDetails_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffBankDetails_BL bl = new put_StaffBankDetails_BL(ref m_dbc);
                rc = bl.put_StaffBankDetails(ref ip, ref op);
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
        public int put_StaffEducation(ref put_StaffEducation_IP ip, ref put_StaffEducation_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffEducation_BL bl = new put_StaffEducation_BL(ref m_dbc);
                rc = bl.put_StaffEducation(ref ip, ref op);
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
        public int put_StaffEmployment(ref put_StaffEmployment_IP ip, ref put_StaffEmployment_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffEmployment_BL bl = new put_StaffEmployment_BL(ref m_dbc);
                rc = bl.put_StaffEmployment(ref ip, ref op);
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
        public int put_StaffLeaves(ref put_StaffLeaves_IP ip, ref put_StaffLeaves_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffLeaves_BL bl = new put_StaffLeaves_BL(ref m_dbc);
                rc = bl.put_StaffLeaves(ref ip, ref op);
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
        public int put_StaffLeaveSummary(ref put_StaffLeaveSummary_IP ip, ref put_StaffLeaveSummary_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffLeaveSummary_BL bl = new put_StaffLeaveSummary_BL(ref m_dbc);
                rc = bl.put_StaffLeaveSummary(ref ip, ref op);
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
        public int put_StaffLogin(ref put_StaffLogin_IP ip, ref put_StaffLogin_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffLogin_BL bl = new put_StaffLogin_BL(ref m_dbc);
                rc = bl.put_StaffLogin(ref ip, ref op);
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
        public int put_StaffMyDocuments(ref put_StaffMyDocuments_IP ip, ref put_StaffMyDocuments_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffMyDocuments_BL bl = new put_StaffMyDocuments_BL(ref m_dbc);
                rc = bl.put_StaffMyDocuments(ref ip, ref op);
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
        public int put_StaffPayroll(ref put_StaffPayroll_IP ip, ref put_StaffPayroll_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffPayroll_BL bl = new put_StaffPayroll_BL(ref m_dbc);
                rc = bl.put_StaffPayroll(ref ip, ref op);
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
        public int put_StaffPaySlips(ref put_StaffPaySlips_IP ip, ref put_StaffPaySlips_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffPaySlips_BL bl = new put_StaffPaySlips_BL(ref m_dbc);
                rc = bl.put_StaffPaySlips(ref ip, ref op);
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
        public int put_StaffReimbursements(ref put_StaffReimbursements_IP ip, ref put_StaffReimbursements_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffReimbursements_BL bl = new put_StaffReimbursements_BL(ref m_dbc);
                rc = bl.put_StaffReimbursements(ref ip, ref op);
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
        public int put_StaffRole(ref put_StaffRole_IP ip, ref put_StaffRole_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffRole_BL bl = new put_StaffRole_BL(ref m_dbc);
                rc = bl.put_StaffRole(ref ip, ref op);
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
        public int put_StaffRoleAppFeature(ref put_StaffRoleAppFeature_IP ip, ref put_StaffRoleAppFeature_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffRoleAppFeature_BL bl = new put_StaffRoleAppFeature_BL(ref m_dbc);
                rc = bl.put_StaffRoleAppFeature(ref ip, ref op);
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
        public int put_StaffRoleModule(ref put_StaffRoleModule_IP ip, ref put_StaffRoleModule_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffRoleModule_BL bl = new put_StaffRoleModule_BL(ref m_dbc);
                rc = bl.put_StaffRoleModule(ref ip, ref op);
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
        public int put_StaffSalaryDeduction(ref put_StaffSalaryDeduction_IP ip, ref put_StaffSalaryDeduction_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffSalaryDeduction_BL bl = new put_StaffSalaryDeduction_BL(ref m_dbc);
                rc = bl.put_StaffSalaryDeduction(ref ip, ref op);
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
        public int put_StaffSalaryEarnings(ref put_StaffSalaryEarnings_IP ip, ref put_StaffSalaryEarnings_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffSalaryEarnings_BL bl = new put_StaffSalaryEarnings_BL(ref m_dbc);
                rc = bl.put_StaffSalaryEarnings(ref ip, ref op);
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
        public int put_StaffWorkItems(ref put_StaffWorkItems_IP ip, ref put_StaffWorkItems_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffWorkItems_BL bl = new put_StaffWorkItems_BL(ref m_dbc);
                rc = bl.put_StaffWorkItems(ref ip, ref op);
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
        public int put_StaffYogDetails(ref put_StaffYogDetails_IP ip, ref put_StaffYogDetails_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffYogDetails_BL bl = new put_StaffYogDetails_BL(ref m_dbc);
                rc = bl.put_StaffYogDetails(ref ip, ref op);
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
        public int put_StaffSalarySummary(ref put_StaffSalarySummary_IP ip, ref put_StaffSalarySummary_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffSalarySummary_BL bl = new put_StaffSalarySummary_BL(ref m_dbc);
                rc = bl.put_StaffSalarySummary(ref ip, ref op);
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
        public int put_StaffAttendanceTrn(ref put_StaffAttendanceTrn_IP ip, ref put_StaffAttendanceTrn_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffAttendanceTrn_BL bl = new put_StaffAttendanceTrn_BL(ref m_dbc);
                rc = bl.put_StaffAttendanceTrn(ref ip, ref op);
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
        public int put_StaffEmploymentTrn(ref put_StaffEmploymentTrn_IP ip, ref put_StaffEmploymentTrn_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffEmploymentTrn_BL bl = new put_StaffEmploymentTrn_BL(ref m_dbc);
                rc = bl.put_StaffEmploymentTrn(ref ip, ref op);
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
        
        public int put_StaffLeavesTrn(ref put_StaffLeavesTrn_IP ip, ref put_StaffLeavesTrn_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffLeavesTrn_BL bl = new put_StaffLeavesTrn_BL(ref m_dbc);
                rc = bl.put_StaffLeavesTrn(ref ip, ref op);
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
        public int put_StaffSalaryEarningsTrn(ref put_StaffSalaryEarningsTrn_IP ip, ref put_StaffSalaryEarningsTrn_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_StaffSalaryEarningsTrn_BL bl = new put_StaffSalaryEarningsTrn_BL(ref m_dbc);
                rc = bl.put_StaffSalaryEarningsTrn(ref ip, ref op);
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
