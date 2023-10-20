using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

using PIHMS.CL.API.IO;


namespace PIHMS.CL.BL.Security
{
    public class BL_Security
    {
        private int rc;
        private cls_Util_DBAccess m_dbc;
        private cls_BC_IO _ip;
        private cls_BC_IO _op;


        //public int put_Patient(ref put_Patient_IP ip, ref put_Patient_OP op)
        //{
        //    _ip = ip; _op = op;
        //    if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
        //    {
        //        return -1;
        //    }

        //    try
        //    {
        //        put_Patient_BL bl = new put_Patient_BL(ref m_dbc);
        //        rc = bl.put_Patient(ref ip, ref op);
        //    }
        //    catch (Exception ex)
        //    {
        //        op.ReturnMessage = ex.Message;
        //        op.ReturnValue = -1;
        //        return -1;
        //    }

        //    cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
        //    return rc;
        //}

    }
}


