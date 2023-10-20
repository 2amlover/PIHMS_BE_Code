using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.DB.Table;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Housekeeping;
using PIHMS.CL.API.Util.DBAccess;


namespace PIHMS.CL.BL.Housekeeping
{
    public class BL_Housekeeping
    {
        private int rc;
        private cls_Util_DBAccess m_dbc;
        private cls_BC_IO _ip;
        private cls_BC_IO _op;


        public int get_RelHousekeepingTasks(ref get_RelHousekeepingTasks_IP ip, ref get_RelHousekeepingTasks_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_RelHousekeepingTasks_BL bl = new get_RelHousekeepingTasks_BL(ref m_dbc);
                rc = bl.get_RelHousekeepingTasks(ref ip, ref op);
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




        public int get_HousekeepingAssignment(ref get_HousekeepingAssignment_IP ip, ref get_HousekeepingAssignment_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_HousekeepingAssignment_BL bl = new get_HousekeepingAssignment_BL(ref m_dbc);
                rc = bl.get_HousekeepingAssignment(ref ip, ref op);
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



        public int get_HousekeepingAssignmentTasks(ref get_HousekeepingAssignmentTasks_IP ip, ref get_HousekeepingAssignmentTasks_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_HousekeepingAssignmentTasks_BL bl = new get_HousekeepingAssignmentTasks_BL(ref m_dbc);
                rc = bl.get_HousekeepingAssignmentTasks(ref ip, ref op);
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



        public int put_RelHousekeepingTasks(ref put_RelHousekeepingTasks_IP ip, ref put_RelHousekeepingTasks_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_RelHousekeepingTasks_BL bl = new put_RelHousekeepingTasks_BL(ref m_dbc);
                rc = bl.put_RelHousekeepingTasks(ref ip, ref op);
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





        public int put_HousekeepingAssignment(ref put_HousekeepingAssignment_IP ip, ref put_HousekeepingAssignment_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_HousekeepingAssignment_BL bl = new put_HousekeepingAssignment_BL(ref m_dbc);
                rc = bl.put_HousekeepingAssignment(ref ip, ref op);
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



        public int put_HousekeepingAssignmentTasks(ref put_HousekeepingAssignmentTasks_IP ip, ref put_HousekeepingAssignmentTasks_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_HousekeepingAssignmentTasks_BL bl = new put_HousekeepingAssignmentTasks_BL(ref m_dbc);
                rc = bl.put_HousekeepingAssignmentTasks(ref ip, ref op);
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



