using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Communication;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;
namespace PIHMS.CL.BL.Communication
{
    class put_DashboardMessage_BL : cls_BC_BusinessLogic
    {
        public put_DashboardMessage_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }



        public int put_DashboardMessage(ref put_DashboardMessage_IP ipdc, ref put_DashboardMessage_OP opdc)
        {

            if (ipdc.m_Communication.ID > 0)
            {
                //Update Existing Row

                m_rc = put_DashboardMessage_Update(ref ipdc, ref opdc);
                Console.WriteLine("SUCCESSFULLY UPDATED IN EXISTING ROW");
            }
            else
            {
                //Insert New Row

                m_rc = put_DashboardMessage_Insert(ref ipdc, ref opdc);
                Console.WriteLine(opdc.m_Communication.ID.ToString() + " INSERTED NEW ROW SUCCESSFULLY");
            }


            return m_rc;
        }


        private int put_DashboardMessage_Insert(ref put_DashboardMessage_IP ipdc, ref put_DashboardMessage_OP opdc)
        {
            List<tbl_trn_dashboard_message> m_CommunicationTemp = new List<tbl_trn_dashboard_message>();


            ipdc.m_Communication.CreatedDateTime = DateTime.Now;
            ipdc.m_Communication.UpdatedDateTime = DateTime.Now;
            ipdc.m_Communication.IsRowDeleted = "N";


            m_CommunicationTemp.Add(ipdc.m_Communication);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_CommunicationTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.m_Communication = m_CommunicationTemp[0];

            return m_rc;
        }


        private int put_DashboardMessage_Update(ref put_DashboardMessage_IP ipdc, ref put_DashboardMessage_OP opdc)
        {

            m_WhereCondition = " WHERE ID = " + ipdc.m_Communication.ID.ToString();
            List<tbl_trn_dashboard_message> m_CommunicationTemp = new List<tbl_trn_dashboard_message>();
            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_CommunicationTemp);


            ipdc.m_Communication.CreatedDateTime = DateTime.Now;
            ipdc.m_Communication.UpdatedDateTime = DateTime.Now;
            ipdc.m_Communication.IsRowDeleted = "N";


            m_CommunicationTemp.Add(ipdc.m_Communication);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_CommunicationTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.m_Communication = m_CommunicationTemp[0];
            return m_rc;

        }

    }
}





