using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.DB.Table;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Inventory;
using PIHMS.CL.API.Util.DBAccess;


namespace PIHMS.CL.BL.Inventory
{
    public class BL_Inventory
    {
        private int rc;
        private cls_Util_DBAccess m_dbc;
        private cls_BC_IO _ip;
        private cls_BC_IO _op;

        public int put_InvDepartment(ref put_InvDepartment_IP ip, ref put_InvDepartment_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvDepartment_BL bl = new put_InvDepartment_BL(ref m_dbc);
                rc = bl.put_InvDepartment(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int put_InvEquipments(ref put_InvEquipments_IP ip, ref put_InvEquipments_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvEquipments_BL bl = new put_InvEquipments_BL(ref m_dbc);
                rc = bl.put_InvEquipments(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int put_InvEquipmentTypes(ref put_InvEquipmentTypes_IP ip, ref put_InvEquipmentTypes_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvEquipmentTypes_BL bl = new put_InvEquipmentTypes_BL(ref m_dbc);
                rc = bl.put_InvEquipmentTypes(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }


        public int put_InvItem(ref put_InvItem_IP ip, ref put_InvItem_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvItem_BL bl = new put_InvItem_BL(ref m_dbc);
                rc = bl.put_InvItem(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int put_InvPhysicalForms(ref put_InvPhysicalForms_IP ip, ref put_InvPhysicalForms_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvPhysicalForms_BL bl = new put_InvPhysicalForms_BL(ref m_dbc);
                rc = bl.put_InvPhysicalForms(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }


        public int put_InvStorageForms(ref put_InvStorageForms_IP ip, ref put_InvStorageForms_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvStorageForms_BL bl = new put_InvStorageForms_BL(ref m_dbc);
                rc = bl.put_InvStorageForms(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }


        public int put_InvStores(ref put_InvStores_IP ip, ref put_InvStores_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvStores_BL bl = new put_InvStores_BL(ref m_dbc);
                rc = bl.put_InvStores(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int put_InvTypes(ref put_InvTypes_IP ip, ref put_InvTypes_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvTypes_BL bl = new put_InvTypes_BL(ref m_dbc);
                rc = bl.put_InvTypes(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int put_InvUnit(ref put_InvUnit_IP ip, ref put_InvUnit_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvUnit_BL bl = new put_InvUnit_BL(ref m_dbc);
                rc = bl.put_InvUnit(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int put_InvVendor(ref put_InvVendor_IP ip, ref put_InvVendor_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvVendor_BL bl = new put_InvVendor_BL(ref m_dbc);
                rc = bl.put_InvVendor(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }
       



        public int put_InvItemBuyConsumeDetails(ref put_InvItemBuyConsumeDetails_IP ip, ref put_InvItemBuyConsumeDetails_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvItemBuyConsumeDetails_BL bl = new put_InvItemBuyConsumeDetails_BL(ref m_dbc);
                rc = bl.put_InvItemBuyConsumeDetails(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int put_InvItemVendor(ref put_InvItemVendor_IP ip, ref put_InvItemVendor_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvItemVendor_BL bl = new put_InvItemVendor_BL(ref m_dbc);
                rc = bl.put_InvItemVendor(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }


        public int put_InvCurrentStock(ref put_InvCurrentStock_IP ip, ref put_InvCurrentStock_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvCurrentStock_BL bl = new put_InvCurrentStock_BL(ref m_dbc);
                rc = bl.put_InvCurrentStock(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }


        public int put_InvIssue(ref put_InvIssue_IP ip, ref put_InvIssue_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvIssue_BL bl = new put_InvIssue_BL(ref m_dbc);
                rc = bl.put_InvIssue(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int put_InvIssueItem(ref put_InvIssueItem_IP ip, ref put_InvIssueItem_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvIssueItem_BL bl = new put_InvIssueItem_BL(ref m_dbc);
                rc = bl.put_InvIssueItem(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int put_InvIssued(ref put_InvIssued_IP ip, ref put_InvIssued_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvIssued_BL bl = new put_InvIssued_BL(ref m_dbc);
                rc = bl.put_InvIssued(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }


        public int put_InvItemIssue(ref put_InvItemIssue_IP ip, ref put_InvItemIssue_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvItemIssue_BL bl = new put_InvItemIssue_BL(ref m_dbc);
                rc = bl.put_InvItemIssue(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int put_InvItemPurchase(ref put_InvItemPurchase_IP ip, ref put_InvItemPurchase_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvItemPurchase_BL bl = new put_InvItemPurchase_BL(ref m_dbc);
                rc = bl.put_InvItemPurchase(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int put_InvPurchase(ref put_InvPurchase_IP ip, ref put_InvPurchase_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvPurchase_BL bl = new put_InvPurchase_BL(ref m_dbc);
                rc = bl.put_InvPurchase(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }




        public int put_InvPurchaseItem(ref put_InvPurchaseItem_IP ip, ref put_InvPurchaseItem_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvPurchaseItem_BL bl = new put_InvPurchaseItem_BL(ref m_dbc);
                rc = bl.put_InvPurchaseItem(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int put_InvReceived(ref put_InvReceived_IP ip, ref put_InvReceived_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvReceived_BL bl = new put_InvReceived_BL(ref m_dbc);
                rc = bl.put_InvReceived(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }


        public int put_InvStockBatch(ref put_InvStockBatch_IP ip, ref put_InvStockBatch_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvStockBatch_BL bl = new put_InvStockBatch_BL(ref m_dbc);
                rc = bl.put_InvStockBatch(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int put_InvTaggedAssets(ref put_InvTaggedAssets_IP ip, ref put_InvTaggedAssets_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvTaggedAssets_BL bl = new put_InvTaggedAssets_BL(ref m_dbc);
                rc = bl.put_InvTaggedAssets(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int put_InvTaggedConsumables(ref put_InvTaggedConsumables_IP ip, ref put_InvTaggedConsumables_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvTaggedConsumables_BL bl = new put_InvTaggedConsumables_BL(ref m_dbc);
                rc = bl.put_InvTaggedConsumables(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int put_InvInventoryItems(ref put_InvInventoryItems_IP ip, ref put_InvInventoryItems_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                put_InvInventoryItems_BL bl = new put_InvInventoryItems_BL(ref m_dbc);
                rc = bl.put_InvInventoryItems(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int get_InvDepartment(ref get_InvDepartment_IP ip, ref get_InvDepartment_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvDepartment_BL bl = new get_InvDepartment_BL(ref m_dbc);
                rc = bl.get_InvDepartment(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int get_InvEquipments(ref get_InvEquipments_IP ip, ref get_InvEquipments_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvEquipments_BL bl = new get_InvEquipments_BL(ref m_dbc);
                rc = bl.get_InvEquipments(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int get_InvEquipmentTypes(ref get_InvEquipmentTypes_IP ip, ref get_InvEquipmentTypes_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvEquipmentTypes_BL bl = new get_InvEquipmentTypes_BL(ref m_dbc);
                rc = bl.get_InvEquipmentTypes(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }


        public int get_InvItem(ref get_InvItem_IP ip, ref get_InvItem_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvItem_BL bl = new get_InvItem_BL(ref m_dbc);
                rc = bl.get_InvItem(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int get_InvPhysicalForms(ref get_InvPhysicalForms_IP ip, ref get_InvPhysicalForms_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvPhysicalForms_BL bl = new get_InvPhysicalForms_BL(ref m_dbc);
                rc = bl.get_InvPhysicalForms(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }


        public int get_InvStorageForms(ref get_InvStorageForms_IP ip, ref get_InvStorageForms_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvStorageForms_BL bl = new get_InvStorageForms_BL(ref m_dbc);
                rc = bl.get_InvStorageForms(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }


        public int get_InvStores(ref get_InvStores_IP ip, ref get_InvStores_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvStores_BL bl = new get_InvStores_BL(ref m_dbc);
                rc = bl.get_InvStores(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int get_InvTypes(ref get_InvTypes_IP ip, ref get_InvTypes_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvTypes_BL bl = new get_InvTypes_BL(ref m_dbc);
                rc = bl.get_InvTypes(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int get_InvUnit(ref get_InvUnit_IP ip, ref get_InvUnit_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvUnit_BL bl = new get_InvUnit_BL(ref m_dbc);
                rc = bl.get_InvUnit(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int get_InvVendor(ref get_InvVendor_IP ip, ref get_InvVendor_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvVendor_BL bl = new get_InvVendor_BL(ref m_dbc);
                rc = bl.get_InvVendor(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }




        public int get_InvItemBuyConsumeDetails(ref get_InvItemBuyConsumeDetails_IP ip, ref get_InvItemBuyConsumeDetails_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvItemBuyConsumeDetails_BL bl = new get_InvItemBuyConsumeDetails_BL(ref m_dbc);
                rc = bl.get_InvItemBuyConsumeDetails(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int get_InvItemVendor(ref get_InvItemVendor_IP ip, ref get_InvItemVendor_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvItemVendor_BL bl = new get_InvItemVendor_BL(ref m_dbc);
                rc = bl.get_InvItemVendor(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }


        public int get_InvCurrentStock(ref get_InvCurrentStock_IP ip, ref get_InvCurrentStock_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvCurrentStock_BL bl = new get_InvCurrentStock_BL(ref m_dbc);
                rc = bl.get_InvCurrentStock(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }


        public int get_InvIssue(ref get_InvIssue_IP ip, ref get_InvIssue_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvIssue_BL bl = new get_InvIssue_BL(ref m_dbc);
                rc = bl.get_InvIssue(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int get_InvIssueItem(ref get_InvIssueItem_IP ip, ref get_InvIssueItem_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvIssueItem_BL bl = new get_InvIssueItem_BL(ref m_dbc);
                rc = bl.get_InvIssueItem(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int get_InvIssued(ref get_InvIssued_IP ip, ref get_InvIssued_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvIssued_BL bl = new get_InvIssued_BL(ref m_dbc);
                rc = bl.get_InvIssued(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }


        public int get_InvItemIssue(ref get_InvItemIssue_IP ip, ref get_InvItemIssue_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvItemIssue_BL bl = new get_InvItemIssue_BL(ref m_dbc);
                rc = bl.get_InvItemIssue(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int get_InvItemPurchase(ref get_InvItemPurchase_IP ip, ref get_InvItemPurchase_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvItemPurchase_BL bl = new get_InvItemPurchase_BL(ref m_dbc);
                rc = bl.get_InvItemPurchase(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int get_InvPurchase(ref get_InvPurchase_IP ip, ref get_InvPurchase_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvPurchase_BL bl = new get_InvPurchase_BL(ref m_dbc);
                rc = bl.get_InvPurchase(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }




        public int get_InvPurchaseItem(ref get_InvPurchaseItem_IP ip, ref get_InvPurchaseItem_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvPurchaseItem_BL bl = new get_InvPurchaseItem_BL(ref m_dbc);
                rc = bl.get_InvPurchaseItem(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int get_InvReceived(ref get_InvReceived_IP ip, ref get_InvReceived_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvReceived_BL bl = new get_InvReceived_BL(ref m_dbc);
                rc = bl.get_InvReceived(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }


        public int get_InvStockBatch(ref get_InvStockBatch_IP ip, ref get_InvStockBatch_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvStockBatch_BL bl = new get_InvStockBatch_BL(ref m_dbc);
                rc = bl.get_InvStockBatch(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int get_InvTaggedAssets(ref get_InvTaggedAssets_IP ip, ref get_InvTaggedAssets_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvTaggedAssets_BL bl = new get_InvTaggedAssets_BL(ref m_dbc);
                rc = bl.get_InvTaggedAssets(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int get_InvTaggedConsumables(ref get_InvTaggedConsumables_IP ip, ref get_InvTaggedConsumables_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvTaggedConsumables_BL bl = new get_InvTaggedConsumables_BL(ref m_dbc);
                rc = bl.get_InvTaggedConsumables(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }



        public int get_InvInventoryItems(ref get_InvInventoryItems_IP ip, ref get_InvInventoryItems_OP op)
        {
            _ip = ip; _op = op;
            if (cls_Util_DBAccessManagement.RequestConnectionObject(ref m_dbc, ref _ip, ref _op) < 0)
            {
                return -1;
            }

            try
            {
                get_InvInventoryItems_BL bl = new get_InvInventoryItems_BL(ref m_dbc);
                rc = bl.get_InvInventoryItems(ref ip, ref op);
            }
            catch (Exception ex)
            {
                op.ReturnMessage = ex.Message;
                op.ReturnValue = -1;
                return -1;
            }

            cls_Util_DBAccessManagement.FreeConnectionObject(ref m_dbc, ref _ip, ref _op);
            return rc;
        }

    }
}

