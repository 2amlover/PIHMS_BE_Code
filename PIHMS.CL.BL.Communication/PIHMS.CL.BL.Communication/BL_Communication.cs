using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.DB.Table;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Communication;
using PIHMS.CL.API.Util.DBAccess;


//this is my first commit
namespace PIHMS.CL.BL.Communication
{
    public class BL_Communication
    {
        private int rc;
        private cls_Util_DBAccess m_dbc;
        private cls_BC_IO _ip;
        private cls_BC_IO _op;
        
        //put
        public int put_SmsDetails(ref put_SmsDetails_IP ip, ref put_SmsDetails_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_SmsDetails_BL bl = new put_SmsDetails_BL(ref m_dbc);
                rc = bl.put_SmsDetails(ref ip, ref op);
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



        public int put_DashboardMail(ref put_DashboardMail_IP ip, ref put_DashboardMail_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_DashboardMail_BL bl = new put_DashboardMail_BL(ref m_dbc);
                rc = bl.put_DashboardMail(ref ip, ref op);
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



        public int put_DashboardMessage(ref put_DashboardMessage_IP ip, ref put_DashboardMessage_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_DashboardMessage_BL bl = new put_DashboardMessage_BL(ref m_dbc);
                rc = bl.put_DashboardMessage(ref ip, ref op);
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

        //get

        public int get_SmsDetails(ref get_SmsDetails_IP ip, ref get_SmsDetails_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_SmsDetails_BL bl = new get_SmsDetails_BL(ref m_dbc);
                rc = bl.get_SmsDetails(ref ip, ref op);
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



        public int get_DashboardMail(ref get_DashboardMail_IP ip, ref get_DashboardMail_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_DashboardMail_BL bl = new get_DashboardMail_BL(ref m_dbc);
                rc = bl.get_DashboardMail(ref ip, ref op);
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



        public int get_DashboardMessage(ref get_DashboardMessage_IP ip, ref get_DashboardMessage_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_DashboardMessage_BL bl = new get_DashboardMessage_BL(ref m_dbc);
                rc = bl.get_DashboardMessage(ref ip, ref op);
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
