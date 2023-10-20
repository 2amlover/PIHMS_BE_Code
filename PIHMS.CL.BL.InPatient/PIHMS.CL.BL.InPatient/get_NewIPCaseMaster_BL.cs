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
    class get_NewIPCaseMaster_BL : cls_BC_BusinessLogic
    {
        public get_NewIPCaseMaster_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }
        public int get_NewIPCaseMaster(ref get_NewIPCaseMaster_IP ip, ref get_NewIPCaseMaster_OP op)
        {
            m_WhereCondition = " WHERE ID = " + ip.m_PatientID;

            tbl_mas_patient m_PatientTemp = new tbl_mas_patient();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_PatientTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.m_Patient = m_PatientTemp;

            //table is not found in DB
            //m_WhereCondition = " WHERE PatientID = " + ip.m_PatientID;

            //List<tbl_mas_patient_address> ml_PatientAddressTemp = new List<tbl_mas_patient_address>();

            //m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_PatientAddressTemp);
            //if (m_rc < 0)
            //{
            //    op.ReturnMessage = m_ErrorMessage;
            //    op.ReturnValue = m_rc;
            //    return m_rc;
            //}

            //op.ml_PatientAddress = ml_PatientAddressTemp;


            m_WhereCondition = " WHERE PatientID = " + ip.m_PatientID;

            List<tbl_mas_patient_insurance> ml_PatientInsuranceTemp = new List<tbl_mas_patient_insurance>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_PatientInsuranceTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_PatientInsurance = ml_PatientInsuranceTemp;


            m_WhereCondition = " WHERE ID > 0 ";

            List<tbl_mas_ipcase_admittedfor> ml_IPCaseAdmittedforTemp = new List<tbl_mas_ipcase_admittedfor>();

            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_IPCaseAdmittedforTemp);
            if (m_rc < 0)
            {
                op.ReturnMessage = m_ErrorMessage;
                op.ReturnValue = m_rc;
                return m_rc;
            }

            op.ml_IPCaseAdmittedfor = ml_IPCaseAdmittedforTemp;



            //List<cls_IPWards> ml_IPCasebillTemp = new List<cls_IPWards>();

            //List<tbl_mas_ward> ml_IPCasebillsTemp = new List<tbl_mas_ward>();

            //m_WhereCondition = " WHERE ID > 0 and STATUS = Available";

            //m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_IPCasebillsTemp);
            //if (m_rc < 0)
            //{
            //    op.ReturnMessage = m_ErrorMessage;
            //    op.ReturnValue = m_rc;
            //    return m_rc;
            //}


            //for (int i = 0; i < ml_IPCasebillTemp.Count; i++)
            //{
            //    op.ml_IPCasebill[i].m_Ward = ml_IPCasebillsTemp[0];

            //    List<tbl_mas_ward_bed> ml_BillItemsTemp = new List<tbl_mas_ward_bed>();

            //    m_WhereCondition = " WHERE WardID = " + ml_IPCasebillsTemp[i].ID;

            //    m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref ml_BillItemsTemp);
            //    if (m_rc < 0)
            //    {
            //        op.ReturnMessage = m_ErrorMessage;
            //        op.ReturnValue = m_rc;
            //        return m_rc;
            //    }

            //    op.ml_IPCasebill[i].ml_WardBed = ml_BillItemsTemp;
            //}
            return m_rc;
        }



    }
}