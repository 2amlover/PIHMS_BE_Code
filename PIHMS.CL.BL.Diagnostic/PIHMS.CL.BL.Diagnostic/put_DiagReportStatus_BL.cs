using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Diagnostic;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.Diagnostic
{
    class put_DiagReportStatus_BL : cls_BC_BusinessLogic
    {
        public put_DiagReportStatus_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int put_DiagReportStatus(ref put_DiagReportStatus_IP ipdc, ref put_DiagReportStatus_OP opdc)
        {

            if (ipdc.m_Diag.ID > 0)
            {
                //Update Existing Row

                m_rc = put_DiagReportStatus_Update(ref ipdc, ref opdc);
                Console.WriteLine("SUCCESSFULLY UPDATED IN EXISTING ROW");
            }
            else
            {
                //Insert New Row

                m_rc = put_DiagReportStatus_Insert(ref ipdc, ref opdc);
                Console.WriteLine(opdc.m_Diag.ID.ToString() + " INSERTED NEW ROW SUCCESSFULLY");
            }


            return m_rc;
        }


        private int put_DiagReportStatus_Insert(ref put_DiagReportStatus_IP ipdc, ref put_DiagReportStatus_OP opdc)
        {
            List<tbl_mas_diag_report_status> m_DiagTemp = new List<tbl_mas_diag_report_status>();

            ipdc.m_Diag.CreatedDateTime = DateTime.Now;
            ipdc.m_Diag.UpdatedDateTime = DateTime.Now;
            ipdc.m_Diag.IsRowDeleted = "N";


            m_DiagTemp.Add(ipdc.m_Diag);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_DiagTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.m_Diag = m_DiagTemp[0];

            return m_rc;
        }


        private int put_DiagReportStatus_Update(ref put_DiagReportStatus_IP ipdc, ref put_DiagReportStatus_OP opdc)
        {

            m_WhereCondition = " WHERE ID = " + ipdc.m_Diag.ID.ToString();
            List<tbl_mas_diag_report_status> m_DiagTemp = new List<tbl_mas_diag_report_status>();
            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_DiagTemp);

            ipdc.m_Diag.CreatedDateTime = DateTime.Now;
            ipdc.m_Diag.UpdatedDateTime = DateTime.Now;
            ipdc.m_Diag.IsRowDeleted = "N";


            m_DiagTemp.Add(ipdc.m_Diag);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_DiagTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.m_Diag = m_DiagTemp[0];
            return m_rc;

        }

    }
}