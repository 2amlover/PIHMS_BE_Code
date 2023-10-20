﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Finance;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;
using Org.BouncyCastle.Asn1.Ocsp;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;


namespace PIHMS.CL.BL.Finance
{
    class put_AccountInvoiceItems_BL : cls_BC_BusinessLogic
    {
        public put_AccountInvoiceItems_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

        public int put_AccountInvoiceItems(ref put_AccountInvoiceItems_IP ipdc, ref put_AccountInvoiceItems_OP opdc)
        {
            if (ipdc.m_Finance.ID > 0)
            {
                //Update Existing Row

                m_rc = put_AccountInvoiceItems_Update(ref ipdc, ref opdc);
                Console.WriteLine("  UPDATE EXISTING ROW SUCCESSFULLY, ");
            }
            else
            {
                //Insert New Row

                m_rc = put_AccountInvoiceItems_Insert(ref ipdc, ref opdc);
                Console.WriteLine(ipdc.m_Finance.ID.ToString() + " NEW ROW INSERT SUCCESSFULLY, ");
            }
            return m_rc;
        }
        private int put_AccountInvoiceItems_Update(ref put_AccountInvoiceItems_IP ipdc, ref put_AccountInvoiceItems_OP opdc)
        {
            m_WhereCondition = " WHERE ID = " + ipdc.m_Finance.ID.ToString();
            List<tbl_trn_acc_invoice_items> m_FinanceTemp = new List<tbl_trn_acc_invoice_items>();
            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_FinanceTemp);
            ipdc.m_Finance.CreatedDateTime = DateTime.Now;
            ipdc.m_Finance.UpdatedDateTime = DateTime.Now;
            ipdc.m_Finance.IsRowDeleted = "N";
            m_FinanceTemp.Add(ipdc.m_Finance);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_FinanceTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }
            opdc.m_Finance = m_FinanceTemp[0];
            return m_rc;
        }

        private int put_AccountInvoiceItems_Insert(ref put_AccountInvoiceItems_IP ipdc, ref put_AccountInvoiceItems_OP opdc)
        {
            List<tbl_trn_acc_invoice_items> m_FinanceTemp = new List<tbl_trn_acc_invoice_items>();
            ipdc.m_Finance.CreatedDateTime = DateTime.Now;
            ipdc.m_Finance.UpdatedDateTime = DateTime.Now;
            ipdc.m_Finance.IsRowDeleted = "N";

            m_FinanceTemp.Add(ipdc.m_Finance);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_FinanceTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }
            opdc.m_Finance = m_FinanceTemp[0];
            return m_rc;
        }
    }
}

