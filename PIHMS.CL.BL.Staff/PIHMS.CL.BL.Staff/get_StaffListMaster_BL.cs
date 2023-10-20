using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIHMS.CL.BL.Staff
{
    class get_StaffListMaster_BL : cls_BC_BusinessLogic
    {
        public get_StaffListMaster_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int get_StaffListMaster(ref get_StaffListMaster_IP ip, ref get_StaffListMaster_OP op)
        {


            m_WhereCondition = " WHERE FeatureViewName = '"+ ip.m_pageName+"'";

            List<tbl_mas_app_feature_setting> ml_FeatureSettingTemp = new List<tbl_mas_app_feature_setting>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_FeatureSettingTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_FeatureSetting = ml_FeatureSettingTemp;

            return m_rc;
        }
    }
}


