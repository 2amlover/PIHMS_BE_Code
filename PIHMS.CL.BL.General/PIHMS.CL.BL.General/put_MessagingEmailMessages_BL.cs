

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.General;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.General
{
    class put_MessagingEmailMessages_BL : cls_BC_BusinessLogic
    {
        public put_MessagingEmailMessages_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

      
        public int put_MessagingEmailMessages(ref put_MessagingEmailMessages_IP ipdc, ref put_MessagingEmailMessages_OP opdc)
        {
                if (ipdc.m_General.ID > 0)
                {
                    //Update Existing Row

                    m_rc = put_MessagingEmailMessages_Update(ref ipdc, ref opdc);
                }
            
            else 
                //Insert New Row

                m_rc = put_MessagingEmailMessages_Insert(ref ipdc, ref opdc);
           

            return m_rc;
        }
        private int put_MessagingEmailMessages_Insert(ref put_MessagingEmailMessages_IP ipdc, ref put_MessagingEmailMessages_OP opdc)
        {
            List<tbl_trn_messaging_email_messages> ml_GeneralTemp = new List<tbl_trn_messaging_email_messages>();
            ipdc.m_General.CreatedDateTime = DateTime.Now;
            ipdc.m_General.UpdatedDateTime = DateTime.Now;
            ipdc.m_General.IsRowDeleted = "N";
            ml_GeneralTemp.Add(ipdc.m_General);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref ml_GeneralTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.m_General = ml_GeneralTemp[0];
            Console.WriteLine("INSERTED SUCCESSFULLY @ " + ipdc.m_General.ID.ToString() + " in tbl_trn_messaging_email_messages");
            return m_rc;
        }


        private int put_MessagingEmailMessages_Update(ref put_MessagingEmailMessages_IP ipdc, ref put_MessagingEmailMessages_OP opdc)
        {

            List<tbl_trn_messaging_email_messages> ml_GeneralTemp = new List<tbl_trn_messaging_email_messages>();
            ipdc.m_General.UpdatedDateTime = DateTime.Now;

            ml_GeneralTemp.Add(ipdc.m_General);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref ml_GeneralTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.m_General = ml_GeneralTemp[0];
            Console.WriteLine("UPDATED SUCCESSFULLY @ " + ipdc.m_General.ID.ToString() + " in tbl_trn_messaging_email_messages");
            return m_rc;
        }

    }
}






