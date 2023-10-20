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
    class put_DiagSamplesMas_BL : cls_BC_BusinessLogic
    {
        public put_DiagSamplesMas_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int put_DiagSamplesMas(ref put_DiagSamplesMas_IP ipdc, ref put_DiagSamplesMas_OP opdc)
        {

            if (ipdc.m_Diag.ID > 0)
            {
                //Update Existing Row

                m_rc = put_DiagSamplesMas_Update(ref ipdc, ref opdc);
                Console.WriteLine("SUCCESSFULLY UPDATED IN EXISTING ROW");
            }
            else
            {
                //Insert New Row

                m_rc = put_DiagSamplesMas_Insert(ref ipdc, ref opdc);
                Console.WriteLine(opdc.m_Diag.ID.ToString() + " INSERTED NEW ROW SUCCESSFULLY");
            }


            return m_rc;
        }


        private int put_DiagSamplesMas_Insert(ref put_DiagSamplesMas_IP ipdc, ref put_DiagSamplesMas_OP opdc)
        {
            List<tbl_mas_diag_samples> m_DiagTemp = new List<tbl_mas_diag_samples>();

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


        private int put_DiagSamplesMas_Update(ref put_DiagSamplesMas_IP ipdc, ref put_DiagSamplesMas_OP opdc)
        {

            m_WhereCondition = " WHERE ID = " + ipdc.m_Diag.ID.ToString();
            List<tbl_mas_diag_samples> m_DiagTemp = new List<tbl_mas_diag_samples>();
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