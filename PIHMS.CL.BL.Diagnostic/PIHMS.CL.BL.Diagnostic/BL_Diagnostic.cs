
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.DB.Table;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Diagnostic;
using PIHMS.CL.API.Util.DBAccess;


namespace PIHMS.CL.BL.Diagnostic
{
    public class BL_Diagnostic
    {
        private int rc;
        private cls_Util_DBAccess m_dbc;
        private cls_BC_IO _ip;
        private cls_BC_IO _op;

        public int get_DiagTests(ref get_DiagTests_IP ip, ref get_DiagTests_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_DiagTests_BL bl = new get_DiagTests_BL(ref m_dbc);
                rc = bl.get_DiagTests(ref ip, ref op);
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


        public int get_DiagPlanList(ref get_DiagPlanList_IP ip, ref get_DiagPlanList_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_DiagPlanList_BL bl = new get_DiagPlanList_BL(ref m_dbc);
                rc = bl.get_DiagPlanList(ref ip, ref op);
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



        public int get_DiagRegenerate(ref get_DiagRegenerate_IP ip, ref get_DiagRegenerate_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_DiagRegenerate_BL bl = new get_DiagRegenerate_BL(ref m_dbc);
                rc = bl.get_DiagRegenerate(ref ip, ref op);
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


        public int get_DiagTestPlanList(ref get_DiagTestPlanList_IP ip, ref get_DiagTestPlanList_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_DiagTestPlanList_BL bl = new get_DiagTestPlanList_BL(ref m_dbc);
                rc = bl.get_DiagTestPlanList(ref ip, ref op);
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




        public int get_DiagReport(ref get_DiagReport_IP ip, ref get_DiagReport_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_DiagReport_BL bl = new get_DiagReport_BL(ref m_dbc);
                rc = bl.get_DiagReport(ref ip, ref op);
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



        public int get_DiagTestgroups(ref get_DiagTestgroups_IP ip, ref get_DiagTestgroups_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_DiagTestgroups_BL bl = new get_DiagTestgroups_BL(ref m_dbc);
                rc = bl.get_DiagTestgroups(ref ip, ref op);
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




        public int get_DiagTestranges(ref get_DiagTestranges_IP ip, ref get_DiagTestranges_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_DiagTestranges_BL bl = new get_DiagTestranges_BL(ref m_dbc);
                rc = bl.get_DiagTestranges(ref ip, ref op);
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



        public int get_DiagTestTemplate(ref get_DiagTestTemplate_IP ip, ref get_DiagTestTemplate_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_DiagTestTemplate_BL bl = new get_DiagTestTemplate_BL(ref m_dbc);
                rc = bl.get_DiagTestTemplate(ref ip, ref op);
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




        public int get_DiagTestplanDoc(ref get_DiagTestplanDoc_IP ip, ref get_DiagTestplanDoc_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_DiagTestplanDoc_BL bl = new get_DiagTestplanDoc_BL(ref m_dbc);
                rc = bl.get_DiagTestplanDoc(ref ip, ref op);
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


        public int get_DiagUnits(ref get_DiagUnits_IP ip, ref get_DiagUnits_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_DiagUnits_BL bl = new get_DiagUnits_BL(ref m_dbc);
                rc = bl.get_DiagUnits(ref ip, ref op);
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


        public int get_DiagSamplesMas(ref get_DiagSamplesMas_IP ip, ref get_DiagSamplesMas_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_DiagSamplesMas_BL bl = new get_DiagSamplesMas_BL(ref m_dbc);
                rc = bl.get_DiagSamplesMas(ref ip, ref op);
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


        public int get_DiagTestinstrumentationName(ref get_DiagTestinstrumentationName_IP ip, ref get_DiagTestinstrumentationName_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_DiagTestinstrumentationName_BL bl = new get_DiagTestinstrumentationName_BL(ref m_dbc);
                rc = bl.get_DiagTestinstrumentationName(ref ip, ref op);
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



        public int get_DiagReportStatus(ref get_DiagReportStatus_IP ip, ref get_DiagReportStatus_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_DiagReportStatus_BL bl = new get_DiagReportStatus_BL(ref m_dbc);
                rc = bl.get_DiagReportStatus(ref ip, ref op);
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



        public int get_DiagSamplesTrn(ref get_DiagSamplesTrn_IP ip, ref get_DiagSamplesTrn_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_DiagSamplesTrn_BL bl = new get_DiagSamplesTrn_BL(ref m_dbc);
                rc = bl.get_DiagSamplesTrn(ref ip, ref op);
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


        public int get_ScanUsreport(ref get_ScanUsreport_IP ip, ref get_ScanUsreport_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_ScanUsreport_BL bl = new get_ScanUsreport_BL(ref m_dbc);
                rc = bl.get_ScanUsreport(ref ip, ref op);
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


        public int get_ScannedreportItems(ref get_ScannedreportItems_IP ip, ref get_ScannedreportItems_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_ScannedreportItems_BL bl = new get_ScannedreportItems_BL(ref m_dbc);
                rc = bl.get_ScannedreportItems(ref ip, ref op);
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



        public int get_Scannedreports(ref get_Scannedreports_IP ip, ref get_Scannedreports_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_Scannedreports_BL bl = new get_Scannedreports_BL(ref m_dbc);
                rc = bl.get_Scannedreports(ref ip, ref op);
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
        //Puts

        public int put_DiagPlanList(ref put_DiagPlanList_IP ip, ref put_DiagPlanList_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_DiagPlanList_BL bl = new put_DiagPlanList_BL(ref m_dbc);
                rc = bl.put_DiagPlanList(ref ip, ref op);
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

        public int put_DiagRegenerate(ref put_DiagRegenerate_IP ip, ref put_DiagRegenerate_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_DiagRegenerate_BL bl = new put_DiagRegenerate_BL(ref m_dbc);
                rc = bl.put_DiagRegenerate(ref ip, ref op);
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

        public int put_DiagTestPlanList(ref put_DiagTestPlanList_IP ip, ref put_DiagTestPlanList_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_DiagTestPlanList_BL bl = new put_DiagTestPlanList_BL(ref m_dbc);
                rc = bl.put_DiagTestPlanList(ref ip, ref op);
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


        public int put_DiagReport(ref put_DiagReport_IP ip, ref put_DiagReport_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_DiagReport_BL bl = new put_DiagReport_BL(ref m_dbc);
                rc = bl.put_DiagReport(ref ip, ref op);
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


        public int put_DiagTestgroups(ref put_DiagTestgroups_IP ip, ref put_DiagTestgroups_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_DiagTestgroups_BL bl = new put_DiagTestgroups_BL(ref m_dbc);
                rc = bl.put_DiagTestgroups(ref ip, ref op);
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



        public int put_DiagTests(ref put_DiagTests_IP ip, ref put_DiagTests_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_DiagTests_BL bl = new put_DiagTests_BL(ref m_dbc);
                rc = bl.put_DiagTests(ref ip, ref op);
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


        public int put_DiagTestranges(ref put_DiagTestranges_IP ip, ref put_DiagTestranges_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_DiagTestranges_BL bl = new put_DiagTestranges_BL(ref m_dbc);
                rc = bl.put_DiagTestranges(ref ip, ref op);
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



        public int put_DiagTestTemplate(ref put_DiagTestTemplate_IP ip, ref put_DiagTestTemplate_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_DiagTestTemplate_BL bl = new put_DiagTestTemplate_BL(ref m_dbc);
                rc = bl.put_DiagTestTemplate(ref ip, ref op);
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




        public int put_DiagTestplanDoc(ref put_DiagTestplanDoc_IP ip, ref put_DiagTestplanDoc_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_DiagTestplanDoc_BL bl = new put_DiagTestplanDoc_BL(ref m_dbc);
                rc = bl.put_DiagTestplanDoc(ref ip, ref op);
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



        public int put_DiagUnits(ref put_DiagUnits_IP ip, ref put_DiagUnits_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_DiagUnits_BL bl = new put_DiagUnits_BL(ref m_dbc);
                rc = bl.put_DiagUnits(ref ip, ref op);
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



        public int put_DiagSamplesMas(ref put_DiagSamplesMas_IP ip, ref put_DiagSamplesMas_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_DiagSamplesMas_BL bl = new put_DiagSamplesMas_BL(ref m_dbc);
                rc = bl.put_DiagSamplesMas(ref ip, ref op);
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




        public int put_DiagTestinstrumentationName(ref put_DiagTestinstrumentationName_IP ip, ref put_DiagTestinstrumentationName_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_DiagTestinstrumentationName_BL bl = new put_DiagTestinstrumentationName_BL(ref m_dbc);
                rc = bl.put_DiagTestinstrumentationName(ref ip, ref op);
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




        public int put_DiagReportStatus(ref put_DiagReportStatus_IP ip, ref put_DiagReportStatus_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_DiagReportStatus_BL bl = new put_DiagReportStatus_BL(ref m_dbc);
                rc = bl.put_DiagReportStatus(ref ip, ref op);
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

        public int put_DiagSamplesTrn(ref put_DiagSamplesTrn_IP ip, ref put_DiagSamplesTrn_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_DiagSamplesTrn_BL bl = new put_DiagSamplesTrn_BL(ref m_dbc);
                rc = bl.put_DiagSamplesTrn(ref ip, ref op);
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


        public int put_ScanUsreport(ref put_ScanUsreport_IP ip, ref put_ScanUsreport_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_ScanUsreport_BL bl = new put_ScanUsreport_BL(ref m_dbc);
                rc = bl.put_ScanUsreport(ref ip, ref op);
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


        public int put_ScannedReportItems(ref put_ScannedReportItems_IP ip, ref put_ScannedReportItems_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_ScannedReportItems_BL bl = new put_ScannedReportItems_BL(ref m_dbc);
                rc = bl.put_ScannedReportItems(ref ip, ref op);
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


        public int put_ScannedReports(ref put_ScannedReports_IP ip, ref put_ScannedReports_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_ScannedReports_BL bl = new put_ScannedReports_BL(ref m_dbc);
                rc = bl.put_ScannedReports(ref ip, ref op);
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
