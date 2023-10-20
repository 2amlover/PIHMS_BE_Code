using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.InPatient
{
    class get_IPCaseListMaster_BL : cls_BC_BusinessLogic
    {
        public get_IPCaseListMaster_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }
        public int get_IPCaseListMaster(ref get_IPCaseListMaster_IP ip, ref get_IPCaseListMaster_OP op)
        {
            m_WhereCondition = " WHERE FeatureViewPage = " + ip.m_pageName;

            List<tbl_mas_app_feature_setting> m_PatientTemp = new List<tbl_mas_app_feature_setting>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_PatientTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_FeatureSetting = m_PatientTemp;
            return m_rc;
        }

    }
}
