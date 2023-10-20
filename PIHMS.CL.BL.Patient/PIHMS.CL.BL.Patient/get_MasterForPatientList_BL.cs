using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Patient;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.Patient
{
    class get_MasterForPatientList_BL : cls_BC_BusinessLogic
    {
        public get_MasterForPatientList_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_MasterForPatientList(ref get_MasterForPatientList_IP ip, ref get_MasterForPatientList_OP op)
        {
            

            m_WhereCondition = " WHERE FeatureViewName = " + ip.m_PageName;

            List<tbl_mas_app_feature_setting> ml_MasterPatientListTemp = new List<tbl_mas_app_feature_setting>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_MasterPatientListTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_MasterPatientList = ml_MasterPatientListTemp;


            return m_rc;
        }

    }
}



