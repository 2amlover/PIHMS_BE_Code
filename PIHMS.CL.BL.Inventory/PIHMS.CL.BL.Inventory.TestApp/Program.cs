using PIHMS.CL.API.IO.Inventory;
using System.Text.Json;

namespace PIHMS.CL.BL.Inventory.TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            String ConnectionString = "Server=127.0.0.1; database=db_ymsh_production; UID=root; password=root";

            //GET

            cls_Test_get_InvDepartment_BL test1 = new cls_Test_get_InvDepartment_BL(ConnectionString);
            Console.WriteLine(test1.SC_001());

            cls_Test_get_InvEquipments_BL test2 = new cls_Test_get_InvEquipments_BL(ConnectionString);
            Console.WriteLine(test2.SC_001());

            cls_Test_get_InvEquipmentTypes_BL test3 = new cls_Test_get_InvEquipmentTypes_BL(ConnectionString);
            Console.WriteLine(test3.SC_001());

            cls_Test_get_InvItem_BL test4 = new cls_Test_get_InvItem_BL(ConnectionString);
            Console.WriteLine(test4.SC_001());

            cls_Test_get_InvPhysicalForms_BL test5 = new cls_Test_get_InvPhysicalForms_BL(ConnectionString);
            Console.WriteLine(test5.SC_001());

            cls_Test_get_InvStorageForms_BL test6 = new cls_Test_get_InvStorageForms_BL(ConnectionString);
            Console.WriteLine(test6.SC_001());

            cls_Test_get_InvStores_BL test7 = new cls_Test_get_InvStores_BL(ConnectionString);
            Console.WriteLine(test7.SC_001());

            cls_Test_get_InvTypes_BL test8 = new cls_Test_get_InvTypes_BL(ConnectionString);
            Console.WriteLine(test8.SC_001());

            cls_Test_get_InvUnit_BL test9 = new cls_Test_get_InvUnit_BL(ConnectionString);
            Console.WriteLine(test9.SC_001());

            cls_Test_get_InvVendor_BL test10 = new cls_Test_get_InvVendor_BL(ConnectionString);
            Console.WriteLine(test10.SC_001());

            cls_Test_get_InvItemBuyConsumeDetails_BL test11 = new cls_Test_get_InvItemBuyConsumeDetails_BL(ConnectionString);
            Console.WriteLine(test11.SC_001());

            cls_Test_get_InvItemVendor_BL test12 = new cls_Test_get_InvItemVendor_BL(ConnectionString);
            Console.WriteLine(test12.SC_001());

            cls_Test_get_InvCurrentStock_BL test13 = new cls_Test_get_InvCurrentStock_BL(ConnectionString);
            Console.WriteLine(test13.SC_001());

            cls_Test_get_InvIssue_BL test14 = new cls_Test_get_InvIssue_BL(ConnectionString);
            Console.WriteLine(test14.SC_001());

            cls_Test_get_InvIssueItem_BL test15 = new cls_Test_get_InvIssueItem_BL(ConnectionString);
            Console.WriteLine(test15.SC_001());

            cls_Test_get_InvIssued_BL test16 = new cls_Test_get_InvIssued_BL(ConnectionString);
            Console.WriteLine(test16.SC_001());

            //cls_Test_get_InvItemIssue_BL test17 = new cls_Test_get_InvItemIssue_BL(ConnectionString);
            //Console.WriteLine(test17.SC_001());

            cls_Test_get_InvItemPurchase_BL test18 = new cls_Test_get_InvItemPurchase_BL(ConnectionString);
            Console.WriteLine(test18.SC_001());

            cls_Test_get_InvPurchase_BL test19 = new cls_Test_get_InvPurchase_BL(ConnectionString);
            Console.WriteLine(test19.SC_001());

            cls_Test_get_InvPurchaseItem_BL test20 = new cls_Test_get_InvPurchaseItem_BL(ConnectionString);
            Console.WriteLine(test20.SC_001());

            cls_Test_get_InvReceived_BL test21 = new cls_Test_get_InvReceived_BL(ConnectionString);
            Console.WriteLine(test21.SC_001());

            cls_Test_get_InvStockBatch_BL test22 = new cls_Test_get_InvStockBatch_BL(ConnectionString);
            Console.WriteLine(test22.SC_001());

            cls_Test_get_InvTaggedAssets_BL test23 = new cls_Test_get_InvTaggedAssets_BL(ConnectionString);
            Console.WriteLine(test23.SC_001());

            cls_Test_get_InvTaggedConsumables_BL test24 = new cls_Test_get_InvTaggedConsumables_BL(ConnectionString);
            Console.WriteLine(test24.SC_001());

            cls_Test_get_InvInventoryItems_BL test25 = new cls_Test_get_InvInventoryItems_BL(ConnectionString);
            Console.WriteLine(test25.SC_001());

            //PUT

            cls_Test_put_InvDepartment_BL cls_Test_put_InvDepartment_BL = new cls_Test_put_InvDepartment_BL(ConnectionString);
            cls_Test_put_InvDepartment_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvDepartment_BL_DATA_SC001.json");

            cls_Test_put_InvDepartment_BL cls_Test_put_InvDepartment_BL1 = new cls_Test_put_InvDepartment_BL(ConnectionString);
            cls_Test_put_InvDepartment_BL1.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvDepartment_BL_DATA_SC002.json");

            cls_Test_put_InvEquipments_BL cls_Test_put_InvEquipments_BL = new cls_Test_put_InvEquipments_BL(ConnectionString);
            cls_Test_put_InvEquipments_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvEquipments_BL_DATA_SC001.json");

            cls_Test_put_InvEquipments_BL cls_Test_put_InvEquipments_BL2 = new cls_Test_put_InvEquipments_BL(ConnectionString);
            cls_Test_put_InvEquipments_BL2.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvEquipments_BL_DATA_SC002.json");

            cls_Test_put_InvEquipmentTypes_BL cls_Test_put_InvEquipmentTypes_BL = new cls_Test_put_InvEquipmentTypes_BL(ConnectionString);
            cls_Test_put_InvEquipmentTypes_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvEquipmentTypes_BL_DATA_SC001.json");

            cls_Test_put_InvEquipmentTypes_BL cls_Test_put_InvEquipmentTypes_BL3 = new cls_Test_put_InvEquipmentTypes_BL(ConnectionString);
            cls_Test_put_InvEquipmentTypes_BL3.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvEquipmentTypes_BL_DATA_SC002.json");

            cls_Test_put_InvItem_BL cls_Test_put_InvItem_BL = new cls_Test_put_InvItem_BL(ConnectionString);
            cls_Test_put_InvItem_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvItem_BL_DATA_SC001.json");

            cls_Test_put_InvItem_BL cls_Test_put_InvItem_BL4 = new cls_Test_put_InvItem_BL(ConnectionString);
            cls_Test_put_InvItem_BL4.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvItem_BL_DATA_SC002.json");

            cls_Test_put_InvPhysicalForms_BL cls_Test_put_InvPhysicalForms_BL = new cls_Test_put_InvPhysicalForms_BL(ConnectionString);
            cls_Test_put_InvPhysicalForms_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvPhysicalForms_BL_DATA_SC001.json");

            cls_Test_put_InvPhysicalForms_BL cls_Test_put_InvPhysicalForms_BL5 = new cls_Test_put_InvPhysicalForms_BL(ConnectionString);
            cls_Test_put_InvPhysicalForms_BL5.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvPhysicalForms_BL_DATA_SC002.json");

            cls_Test_put_InvStorageForms_BL cls_Test_put_InvStorageForms_BL = new cls_Test_put_InvStorageForms_BL(ConnectionString);
            cls_Test_put_InvStorageForms_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvStorageForms_BL_DATA_SC001.json");

            cls_Test_put_InvStorageForms_BL cls_Test_put_InvStorageForms_BL6 = new cls_Test_put_InvStorageForms_BL(ConnectionString);
            cls_Test_put_InvStorageForms_BL6.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvStorageForms_BL_DATA_SC002.json");

            cls_Test_put_InvStores_BL cls_Test_put_InvStores_BL = new cls_Test_put_InvStores_BL(ConnectionString);
            cls_Test_put_InvStores_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvStores_BL_DATA_SC001.json");

            cls_Test_put_InvStores_BL cls_Test_put_InvStores_BL7 = new cls_Test_put_InvStores_BL(ConnectionString);
            cls_Test_put_InvStores_BL7.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvStores_BL_DATA_SC002.json");

            cls_Test_put_InvTypes_BL cls_Test_put_InvTypes_BL = new cls_Test_put_InvTypes_BL(ConnectionString);
            cls_Test_put_InvTypes_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvTypes_BL_DATA_SC001.json");

            cls_Test_put_InvTypes_BL cls_Test_put_InvTypes_BL8 = new cls_Test_put_InvTypes_BL(ConnectionString);
            cls_Test_put_InvTypes_BL8.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvTypes_BL_DATA_SC002.json");

            cls_Test_put_InvUnit_BL cls_Test_put_InvUnit_BL = new cls_Test_put_InvUnit_BL(ConnectionString);
            cls_Test_put_InvUnit_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvUnit_BL_DATA_SC001.json");

            cls_Test_put_InvUnit_BL cls_Test_put_InvUnit_BL9 = new cls_Test_put_InvUnit_BL(ConnectionString);
            cls_Test_put_InvUnit_BL9.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvUnit_BL_DATA_SC002.json");

            cls_Test_put_InvVendor_BL cls_Test_put_InvVendor_BL = new cls_Test_put_InvVendor_BL(ConnectionString);
            cls_Test_put_InvVendor_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvVendor_BL_DATA_SC001.json");

            cls_Test_put_InvVendor_BL cls_Test_put_InvVendor_BL10 = new cls_Test_put_InvVendor_BL(ConnectionString);
            cls_Test_put_InvVendor_BL10.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvVendor_BL_DATA_SC002.json");

            cls_Test_put_InvItemBuyConsumeDetails_BL cls_Test_put_InvItemBuyConsumeDetails_BL = new cls_Test_put_InvItemBuyConsumeDetails_BL(ConnectionString);
            cls_Test_put_InvItemBuyConsumeDetails_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvItemBuyConsumeDetails_BL_DATA_SC001.json");

            cls_Test_put_InvItemBuyConsumeDetails_BL cls_Test_put_InvItemBuyConsumeDetails_BL11 = new cls_Test_put_InvItemBuyConsumeDetails_BL(ConnectionString);
            cls_Test_put_InvItemBuyConsumeDetails_BL11.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvItemBuyConsumeDetails_BL_DATA_SC002.json");

            cls_Test_put_InvItemVendor_BL cls_Test_put_InvItemVendor_BL = new cls_Test_put_InvItemVendor_BL(ConnectionString);
            cls_Test_put_InvItemVendor_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvItemVendor_BL_DATA_SC001.json");

            cls_Test_put_InvItemVendor_BL cls_Test_put_InvItemVendor_BL12 = new cls_Test_put_InvItemVendor_BL(ConnectionString);
            cls_Test_put_InvItemVendor_BL12.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvItemVendor_BL_DATA_SC002.json");

            cls_Test_put_InvCurrentStock_BL cls_Test_put_InvCurrentStock_BL = new cls_Test_put_InvCurrentStock_BL(ConnectionString);
            cls_Test_put_InvCurrentStock_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvCurrentStock_BL_DATA_SC001.json");

            cls_Test_put_InvCurrentStock_BL cls_Test_put_InvCurrentStock_BL13 = new cls_Test_put_InvCurrentStock_BL(ConnectionString);
            cls_Test_put_InvCurrentStock_BL13.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvCurrentStock_BL_DATA_SC002.json");

            cls_Test_put_InvIssue_BL cls_Test_put_InvIssue_BL = new cls_Test_put_InvIssue_BL(ConnectionString);
            cls_Test_put_InvIssue_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvIssue_BL_DATA_SC001.json");

            cls_Test_put_InvIssue_BL cls_Test_put_InvIssue_BL14 = new cls_Test_put_InvIssue_BL(ConnectionString);
            cls_Test_put_InvIssue_BL14.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvIssue_BL_DATA_SC002.json");

            //cls_Test_put_InvIssueItem_BL cls_Test_put_InvIssueItem_BL = new cls_Test_put_InvIssueItem_BL(ConnectionString);
            //cls_Test_put_InvIssueItem_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvIssueItem_BL_DATA_SC001.json");

            //cls_Test_put_InvIssueItem_BL cls_Test_put_InvIssueItem_BL15 = new cls_Test_put_InvIssueItem_BL(ConnectionString);
            //cls_Test_put_InvIssueItem_BL15.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvIssueItem_BL_DATA_SC002.json");

            cls_Test_put_InvIssued_BL cls_Test_put_InvIssued_BL = new cls_Test_put_InvIssued_BL(ConnectionString);
            cls_Test_put_InvIssued_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvIssued_BL_DATA_SC001.json");

            cls_Test_put_InvIssued_BL cls_Test_put_InvIssued_BL16 = new cls_Test_put_InvIssued_BL(ConnectionString);
            cls_Test_put_InvIssued_BL16.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvIssued_BL_DATA_SC002.json");

            //cls_Test_put_InvItemIssue_BL cls_Test_put_InvItemIssue_BL = new cls_Test_put_InvItemIssue_BL(ConnectionString);
            //cls_Test_put_InvItemIssue_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvItemIssue_BL_DATA_SC001.json");

            //cls_Test_put_InvItemIssue_BL cls_Test_put_InvItemIssue_BL17 = new cls_Test_put_InvItemIssue_BL(ConnectionString);
            //cls_Test_put_InvItemIssue_BL17.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvItemIssue_BL_DATA_SC002.json");

            cls_Test_put_InvItemPurchase_BL cls_Test_put_InvItemPurchase_BL = new cls_Test_put_InvItemPurchase_BL(ConnectionString);
            cls_Test_put_InvItemPurchase_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvItemPurchase_BL_DATA_SC001.json");

            cls_Test_put_InvItemPurchase_BL cls_Test_put_InvItemPurchase_BL18 = new cls_Test_put_InvItemPurchase_BL(ConnectionString);
            cls_Test_put_InvItemPurchase_BL18.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvItemPurchase_BL_DATA_SC002.json");

            cls_Test_put_InvPurchase_BL cls_Test_put_InvPurchase_BL = new cls_Test_put_InvPurchase_BL(ConnectionString);
            cls_Test_put_InvPurchase_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvPurchase_BL_DATA_SC001.json");

            cls_Test_put_InvPurchase_BL cls_Test_put_InvPurchase_BL19 = new cls_Test_put_InvPurchase_BL(ConnectionString);
            cls_Test_put_InvPurchase_BL19.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvPurchase_BL_DATA_SC002.json");

            cls_Test_put_InvPurchaseItem_BL cls_Test_put_InvPurchaseItem_BL = new cls_Test_put_InvPurchaseItem_BL(ConnectionString);
            cls_Test_put_InvPurchaseItem_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvPurchaseItem_BL_DATA_SC001.json");

            cls_Test_put_InvPurchaseItem_BL cls_Test_put_InvPurchaseItem_BL20 = new cls_Test_put_InvPurchaseItem_BL(ConnectionString);
            cls_Test_put_InvPurchaseItem_BL20.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvPurchaseItem_BL_DATA_SC002.json");

            cls_Test_put_InvReceived_BL cls_Test_put_InvReceived_BL = new cls_Test_put_InvReceived_BL(ConnectionString);
            cls_Test_put_InvReceived_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvReceived_BL_DATA_SC001.json");

            cls_Test_put_InvReceived_BL cls_Test_put_InvReceived_BL21 = new cls_Test_put_InvReceived_BL(ConnectionString);
            cls_Test_put_InvReceived_BL21.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvReceived_BL_DATA_SC002.json");

            cls_Test_put_InvStockBatch_BL cls_Test_put_InvStockBatch_BL = new cls_Test_put_InvStockBatch_BL(ConnectionString);
            cls_Test_put_InvStockBatch_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvStockBatch_BL_DATA_SC001.json");

            cls_Test_put_InvStockBatch_BL cls_Test_put_InvStockBatch_BL22 = new cls_Test_put_InvStockBatch_BL(ConnectionString);
            cls_Test_put_InvStockBatch_BL22.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvStockBatch_BL_DATA_SC002.json");

            cls_Test_put_InvTaggedAssets_BL cls_Test_put_InvTaggedAssets_BL = new cls_Test_put_InvTaggedAssets_BL(ConnectionString);
            cls_Test_put_InvTaggedAssets_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvTaggedAssets_BL_DATA_SC001.json");

            cls_Test_put_InvTaggedAssets_BL cls_Test_put_InvTaggedAssets_BL23 = new cls_Test_put_InvTaggedAssets_BL(ConnectionString);
            cls_Test_put_InvTaggedAssets_BL23.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvTaggedAssets_BL_DATA_SC002.json");

            cls_Test_put_InvTaggedConsumables_BL cls_Test_put_InvTaggedConsumables_BL = new cls_Test_put_InvTaggedConsumables_BL(ConnectionString);
            cls_Test_put_InvTaggedConsumables_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvTaggedConsumables_BL_DATA_SC001.json");

            cls_Test_put_InvTaggedConsumables_BL cls_Test_put_InvTaggedConsumables_BL24 = new cls_Test_put_InvTaggedConsumables_BL(ConnectionString);
            cls_Test_put_InvTaggedConsumables_BL24.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvTaggedConsumables_BL_DATA_SC002.json");

            cls_Test_put_InvInventoryItems_BL cls_Test_put_InvInventoryItems_BL = new cls_Test_put_InvInventoryItems_BL(ConnectionString);
            cls_Test_put_InvInventoryItems_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvInventoryItems_BL_DATA_SC001.json");

            cls_Test_put_InvInventoryItems_BL cls_Test_put_InvInventoryItems_BL25 = new cls_Test_put_InvInventoryItems_BL(ConnectionString);
            cls_Test_put_InvInventoryItems_BL25.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Inventory\PIHMS.CL.BL.Inventory.TestApp\json\cls_Test_put_InvInventoryItems_BL_DATA_SC002.json");
        }

    }
}

