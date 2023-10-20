


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.InPatient;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.InPatient
{
    class put_IPCaseWardDetails_BL : cls_BC_BusinessLogic
    {
        public put_IPCaseWardDetails_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        

        public int put_IPCaseWardDetails(ref put_IPCaseWardDetails_IP ipdc, ref put_IPCaseWardDetails_OP opdc)
        {

                if (ipdc.m_InPatient.ID > 0)
                {
                    //Update Existing Row


                    m_rc = put_InPatient_Update(ref ipdc, ref opdc);

                }
            
            else

            
                {
                    //Insert New Row

                    m_rc = put_InPatient_Insert(ref ipdc, ref opdc);


                }
            

            return m_rc;
        }


        private int put_InPatient_Insert(ref put_IPCaseWardDetails_IP ipdc, ref put_IPCaseWardDetails_OP opdc)
        {
            List<tbl_trn_ipcase_warddetails> m_InPatientTemp = new List<tbl_trn_ipcase_warddetails>();
            ipdc.m_InPatient.CreatedDateTime = DateTime.Now;
            ipdc.m_InPatient.UpdatedDateTime = DateTime.Now;
            ipdc.m_InPatient.IsRowDeleted = "N";

            m_InPatientTemp.Add(ipdc.m_InPatient);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_InPatientTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.m_InPatient = m_InPatientTemp[0];
            Console.WriteLine("NEW ROW INSERTED SUCCESSFULLY");
            return m_rc;
        }


        private int put_InPatient_Update(ref put_IPCaseWardDetails_IP ipdc, ref put_IPCaseWardDetails_OP opdc)
        {

            m_WhereCondition = " WHERE ID = " + ipdc.m_InPatient.ID.ToString();

            List<tbl_trn_ipcase_warddetails> m_InPatientTemp = new List<tbl_trn_ipcase_warddetails>();
            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_InPatientTemp);



            m_InPatientTemp.Add(ipdc.m_InPatient);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_InPatientTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.m_InPatient = m_InPatientTemp[0];
            var b = ipdc.m_InPatient.ID.ToString();
            Console.WriteLine("UPDATED IN " + b + " ROW SUCCESSFULLY");
            return m_rc;

        }

    }
}











