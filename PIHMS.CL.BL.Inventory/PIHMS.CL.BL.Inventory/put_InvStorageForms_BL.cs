﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Inventory;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.Inventory
{
    class put_InvStorageForms_BL : cls_BC_BusinessLogic
    {
        public put_InvStorageForms_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }

       
        public int put_InvStorageForms(ref put_InvStorageForms_IP ipdc, ref put_InvStorageForms_OP opdc)
        {

            if (ipdc.m_Inventory.ID > 0)
            {
                //Update Existing Row

                m_rc = put_InvStorageForms_Update(ref ipdc, ref opdc);
                Console.WriteLine("SUCCESSFULLY UPDATED IN EXISTING ROW");
            }
            else
            {
                //Insert New Row

                m_rc = put_InvStorageForms_Insert(ref ipdc, ref opdc);
                Console.WriteLine(opdc.m_Inventory.ID.ToString() + " INSERTED NEW ROW SUCCESSFULLY");
            }


            return m_rc;
        }


        private int put_InvStorageForms_Insert(ref put_InvStorageForms_IP ipdc, ref put_InvStorageForms_OP opdc)
        {
            List<tbl_mas_inv_storageforms> m_InventoryTemp = new List<tbl_mas_inv_storageforms>();


            ipdc.m_Inventory.CreatedDateTime = DateTime.Now;
            ipdc.m_Inventory.UpdatedDateTime = DateTime.Now;
            ipdc.m_Inventory.IsRowDeleted = "N";


            m_InventoryTemp.Add(ipdc.m_Inventory);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_InventoryTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.m_Inventory= m_InventoryTemp[0];

            return m_rc;
        }


        private int put_InvStorageForms_Update(ref put_InvStorageForms_IP ipdc, ref put_InvStorageForms_OP opdc)
        {

            m_WhereCondition = " WHERE ID = " + ipdc.m_Inventory.ID.ToString();
            List<tbl_mas_inv_storageforms> m_InventoryTemp = new List<tbl_mas_inv_storageforms>();
            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_InventoryTemp);


            ipdc.m_Inventory.CreatedDateTime = DateTime.Now;
            ipdc.m_Inventory.UpdatedDateTime = DateTime.Now;
            ipdc.m_Inventory.IsRowDeleted = "N";


            m_InventoryTemp.Add(ipdc.m_Inventory);

            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_InventoryTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }

            opdc.m_Inventory= m_InventoryTemp[0];
            return m_rc;

        }

    }
}












