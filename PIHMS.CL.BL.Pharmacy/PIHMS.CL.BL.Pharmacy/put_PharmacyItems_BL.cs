using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Pharmacy;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;


namespace PIHMS.CL.BL.Pharmacy
{
    class put_PharmacyItems_BL : cls_BC_BusinessLogic
    {
        public put_PharmacyItems_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }



        public int put_PharmacyItems(ref put_PharmacyItems_IP ipdc, ref put_PharmacyItems_OP opdc)
        {

            if (ipdc.m_Pharmacy.ID > 0)
            {
                //Update Existing Row

                m_rc = put_PharmacyItems_Update(ref ipdc, ref opdc);
                Console.WriteLine("SUCCESSFULLY UPDATED IN EXISTING ROW");
            }
            else
            {
                //Insert New Row

                m_rc = put_PharmacyItems_Insert(ref ipdc, ref opdc);
                Console.WriteLine(opdc.m_Pharmacy.ID.ToString() + " INSERTED NEW ROW SUCCESSFULLY");
            }


            return m_rc;
        }


        private int put_PharmacyItems_Insert(ref put_PharmacyItems_IP ipdc, ref put_PharmacyItems_OP opdc)
        {
            List<tbl_trn_pharmacy_items> m_PharmacyTemp = new List<tbl_trn_pharmacy_items>();

            ipdc.m_Pharmacy.CreatedDateTime = DateTime.Now;
            ipdc.m_Pharmacy.UpdatedDateTime = DateTime.Now;
            ipdc.m_Pharmacy.IsRowDeleted = "N";


            m_PharmacyTemp.Add(ipdc.m_Pharmacy);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_PharmacyTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.m_Pharmacy = m_PharmacyTemp[0];

            return m_rc;
        }


        private int put_PharmacyItems_Update(ref put_PharmacyItems_IP ipdc, ref put_PharmacyItems_OP opdc)
        {

            m_WhereCondition = " WHERE ID = " + ipdc.m_Pharmacy.ID.ToString();
            List<tbl_trn_pharmacy_items> m_PharmacyTemp = new List<tbl_trn_pharmacy_items>();
            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_PharmacyTemp);

            ipdc.m_Pharmacy.CreatedDateTime = DateTime.Now;
            ipdc.m_Pharmacy.UpdatedDateTime = DateTime.Now;
            ipdc.m_Pharmacy.IsRowDeleted = "N";


            m_PharmacyTemp.Add(ipdc.m_Pharmacy);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_PharmacyTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.m_Pharmacy = m_PharmacyTemp[0];
            return m_rc;

        }

    }
}











