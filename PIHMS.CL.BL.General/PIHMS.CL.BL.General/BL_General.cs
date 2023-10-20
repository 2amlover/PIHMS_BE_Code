
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.DB.Table;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.API.IO.General;

namespace PIHMS.CL.BL.General
{
    public class BL_General
    {
        private int rc;
        private cls_Util_DBAccess m_dbc;
        private cls_BC_IO _ip;
        private cls_BC_IO _op;

        // this is Main BL
        public int get_Feedback(ref get_Feedback_IP ip, ref get_Feedback_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_Feedback_BL bl = new get_Feedback_BL(ref m_dbc);
                rc = bl.get_Feedback(ref ip, ref op);
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
        public int get_MessagingEmailMessages(ref get_MessagingEmailMessages_IP ip, ref get_MessagingEmailMessages_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_MessagingEmailMessages_BL bl = new get_MessagingEmailMessages_BL(ref m_dbc);
                rc = bl.get_MessagingEmailMessages(ref ip, ref op);
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
       
        public int put_Feedback(ref put_Feedback_IP ip, ref put_Feedback_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_Feedback_BL bl = new put_Feedback_BL(ref m_dbc);
                rc = bl.put_Feedback(ref ip, ref op);
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
        public int put_MessagingEmailMessages(ref put_MessagingEmailMessages_IP ip, ref put_MessagingEmailMessages_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_MessagingEmailMessages_BL bl = new put_MessagingEmailMessages_BL(ref m_dbc);
                rc = bl.put_MessagingEmailMessages(ref ip, ref op);
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
