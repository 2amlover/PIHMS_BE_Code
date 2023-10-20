using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.OPBilling;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.OPBilling
{
    class put_BillDomainItem_BL : cls_BC_BusinessLogic
    {
        public put_BillDomainItem_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }
        public int put_BillDomainItem(ref put_BillDomainItem_IP ipdc, ref put_BillDomainItem_OP opdc)
        {
            if (ipdc.m_OPBill.ID > 0)
            {
                //Update Existing Row

                m_rc = put_BillDomainItem_Update(ref ipdc, ref opdc);
                Console.WriteLine("  UPDATE EXISTING ROW SUCCESSFULLY, " + ipdc.m_OPBill.ID.ToString() + "   tbl_rel_bill_domain_item");
            }

            else
            {
                //Insert New Row

                m_rc = put_BillDomainItem_Insert(ref ipdc, ref opdc);
                Console.WriteLine(" NEW ROW INSERT SUCCESSFULLY, " + ipdc.m_OPBill.ID.ToString() + " tbl_rel_bill_domain_item");
            }
            return m_rc;
        }
        private int put_BillDomainItem_Update(ref put_BillDomainItem_IP ipdc, ref put_BillDomainItem_OP opdc)
        {
            m_WhereCondition = " WHERE ID = " + ipdc.m_OPBill.ID.ToString();
            List<tbl_rel_bill_domain_item> m_OPBillTemp = new List<tbl_rel_bill_domain_item>();
            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_OPBillTemp);

            ipdc.m_OPBill.UpdatedDateTime = DateTime.Now;
            ipdc.m_OPBill.CreatedDateTime = DateTime.Now;
            ipdc.m_OPBill.UpdatedDateTime = DateTime.Now;
            ipdc.m_OPBill.IsRowDeleted = "N";
            
            m_OPBillTemp.Add(ipdc.m_OPBill);
            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_OPBillTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }
            opdc.m_OPBill = m_OPBillTemp[0];
            return m_rc;
        }

        private int put_BillDomainItem_Insert(ref put_BillDomainItem_IP ipdc, ref put_BillDomainItem_OP opdc)
        {
            List<tbl_rel_bill_domain_item> m_OPBillTemp = new List<tbl_rel_bill_domain_item>();
            ipdc.m_OPBill.CreatedDateTime = DateTime.Now;
            ipdc.m_OPBill.UpdatedDateTime = DateTime.Now;
            ipdc.m_OPBill.IsRowDeleted = "N";
            
            m_OPBillTemp.Add(ipdc.m_OPBill);
            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_OPBillTemp);         
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }
            opdc.m_OPBill = m_OPBillTemp[0];
            return m_rc;
        }
    }
}

