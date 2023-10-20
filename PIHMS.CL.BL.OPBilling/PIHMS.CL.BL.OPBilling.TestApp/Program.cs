using PIHMS.CL.API.IO.OPBilling;
using PIHMS.CL.BL.OPBilling.TestApp;
using System.Text.Json;

namespace PIHMS.CL.BL.OPBilling.TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


           String ConnectionString = "Server=127.0.0.1; database=db_ymsh_production; UID=root; password=root";

            //String ConnectionString = "Server=sql605.main-hosting.eu; database=u294392736_pihms_dev; UID=u294392736_dev; password=Pihms@123$";

            //get


            //cls_Test_get_OPBillList_BL cls_Test_get_OPBillList_BL = new cls_Test_get_OPBillList_BL(ConnectionString);
            //Console.WriteLine(cls_Test_get_OPBillList_BL.SC_001());


            //cls_Test_get_NewOPBillListMaster_BL cls_Test_get_NewOPBillListMaster_BL = new cls_Test_get_NewOPBillListMaster_BL(ConnectionString);
            //Console.WriteLine(cls_Test_get_NewOPBillListMaster_BL.SC_001());

            //cls_Test_get_OPBillDetail_BL cls_Test_get_OPBillDetail_BL = new cls_Test_get_OPBillDetail_BL(ConnectionString);
            //Console.WriteLine(cls_Test_get_OPBillDetail_BL.SC_001());


            cls_Test_get_NewOPBillMaster_BL cls_Test_get_NewOPBillMaster_BL = new cls_Test_get_NewOPBillMaster_BL(ConnectionString);
            Console.WriteLine(cls_Test_get_NewOPBillMaster_BL.SC_001());

            //cls_Test_get_BillList_BL test1 = new cls_Test_get_BillList_BL(ConnectionString);
            //Console.WriteLine(test1.SC_001());

            //cls_Test_get_BillDomain_BL test2 = new cls_Test_get_BillDomain_BL(ConnectionString);
            //Console.WriteLine(test2.SC_001());

            //cls_Test_get_BillItemMas_BL test3 = new cls_Test_get_BillItemMas_BL(ConnectionString);
            //Console.WriteLine(test3.SC_001());

            //cls_Test_get_BillItemPrice_BL test4 = new cls_Test_get_BillItemPrice_BL(ConnectionString);
            //Console.WriteLine(test4.SC_001());

            //cls_Test_get_BillDomainItem_BL test5 = new cls_Test_get_BillDomainItem_BL(ConnectionString);
            //Console.WriteLine(test5.SC_001());

            //cls_Test_get_BillItemTrn_BL test6 = new cls_Test_get_BillItemTrn_BL(ConnectionString);
            //Console.WriteLine(test6.SC_001());

            //cls_Test_get_BillPayment_BL test7 = new cls_Test_get_BillPayment_BL(ConnectionString);
            //Console.WriteLine(test7.SC_001());

            //cls_Test_get_BillRefund_BL test8 = new cls_Test_get_BillRefund_BL(ConnectionString);
            //Console.WriteLine(test8.SC_001());

            //cls_Test_get_BillSession_BL test9 = new cls_Test_get_BillSession_BL(ConnectionString);
            //Console.WriteLine(test9.SC_001());

            //cls_Test_get_PackageBill_BL test10 = new cls_Test_get_PackageBill_BL(ConnectionString);
            //Console.WriteLine(test10.SC_001());

            //cls_Test_get_PackageBillExpense_BL test11 = new cls_Test_get_PackageBillExpense_BL(ConnectionString);
            //Console.WriteLine(test11.SC_001());

            //cls_Test_get_PackageBillPayment_BL test12 = new cls_Test_get_PackageBillPayment_BL(ConnectionString);
            //Console.WriteLine(test12.SC_001());

            //cls_Test_get_SplitBill_BL test13 = new cls_Test_get_SplitBill_BL(ConnectionString);
            //Console.WriteLine(test13.SC_001());

            ////put

            //cls_Test_put_BillList_BL cls_Test_put_BillList_BL = new cls_Test_put_BillList_BL(ConnectionString);
            //cls_Test_put_BillList_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_BillList_BL_SC001.json");

            //cls_Test_put_BillList_BL cls_Test_put_BillList_BL1 = new cls_Test_put_BillList_BL(ConnectionString);
            //cls_Test_put_BillList_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_BillList_BL_SC002.json");


            //cls_Test_put_BillDomain_BL cls_Test_put_BillDomain_BL = new cls_Test_put_BillDomain_BL(ConnectionString);
            //cls_Test_put_BillDomain_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_BillDomain_BL_SC001.json");

            //cls_Test_put_BillDomain_BL cls_Test_put_BillDomain_BL1 = new cls_Test_put_BillDomain_BL(ConnectionString);
            //cls_Test_put_BillDomain_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_BillDomain_BL_SC002.json");


            //cls_Test_put_BillDomainItem_BL cls_Test_put_BillDomainItem_BL = new cls_Test_put_BillDomainItem_BL(ConnectionString);
            //cls_Test_put_BillDomainItem_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_BillDomainItem_BL_SC001.json");

            //cls_Test_put_BillDomainItem_BL cls_Test_put_BillDomainItem_BL1 = new cls_Test_put_BillDomainItem_BL(ConnectionString);
            //cls_Test_put_BillDomainItem_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_BillDomainItem_BL_SC002.json");


            //cls_Test_put_BillItemMas_BL cls_Test_put_BillItemMas_BL = new cls_Test_put_BillItemMas_BL(ConnectionString);
            //cls_Test_put_BillItemMas_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_BillItemMas_BL_SC001.json");

            //cls_Test_put_BillItemMas_BL cls_Test_put_BillItemMas_BL1 = new cls_Test_put_BillItemMas_BL(ConnectionString);
            //cls_Test_put_BillItemMas_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_BillItemMas_BL_SC002.json");


            //cls_Test_put_BillItemPrice_BL cls_Test_put_BillItemPrice_BL = new cls_Test_put_BillItemPrice_BL(ConnectionString);
            //cls_Test_put_BillItemPrice_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_BillItemPrice_BL_SC001.json");

            //cls_Test_put_BillItemPrice_BL cls_Test_put_BillItemPrice_BL1 = new cls_Test_put_BillItemPrice_BL(ConnectionString);
            //cls_Test_put_BillItemPrice_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_BillItemPrice_BL_SC002.json");


            //cls_Test_put_BillItemTrn_BL cls_Test_put_BillItemTrn_BL = new cls_Test_put_BillItemTrn_BL(ConnectionString);
            //cls_Test_put_BillItemTrn_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_BillItemTrn_BL_SC001.json");

            //cls_Test_put_BillItemTrn_BL cls_Test_put_BillItemTrn_BL1 = new cls_Test_put_BillItemTrn_BL(ConnectionString);
            //cls_Test_put_BillItemTrn_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_BillItemTrn_BL_SC002.json");


            //cls_Test_put_BillPayment_BL cls_Test_put_BillPayment_BL = new cls_Test_put_BillPayment_BL(ConnectionString);
            //cls_Test_put_BillPayment_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_BillPayment_BL_SC001.json");

            //cls_Test_put_BillPayment_BL cls_Test_put_BillPayment_BL1 = new cls_Test_put_BillPayment_BL(ConnectionString);
            //cls_Test_put_BillPayment_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_BillPayment_BL_SC002.json");


            //cls_Test_put_BillRefund_BL cls_Test_put_BillRefund_BL = new cls_Test_put_BillRefund_BL(ConnectionString);
            //cls_Test_put_BillRefund_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_BillRefund_BL_SC001.json");

            //cls_Test_put_BillRefund_BL cls_Test_put_BillRefund_BL1 = new cls_Test_put_BillRefund_BL(ConnectionString);
            //cls_Test_put_BillRefund_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_BillRefund_BL_SC002.json");


            //cls_Test_put_BillSession_BL cls_Test_put_BillSession_BL = new cls_Test_put_BillSession_BL(ConnectionString);
            //cls_Test_put_BillSession_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_BillSession_BL_SC001.json");

            //cls_Test_put_BillSession_BL cls_Test_put_BillSession_BL1 = new cls_Test_put_BillSession_BL(ConnectionString);
            //cls_Test_put_BillSession_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_BillSession_BL_SC002.json");


            //cls_Test_put_PackageBill_BL cls_Test_put_PackageBill_BL = new cls_Test_put_PackageBill_BL(ConnectionString);
            //cls_Test_put_PackageBill_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_PackageBill_BL_SC001.json");

            //cls_Test_put_PackageBill_BL cls_Test_put_PackageBill_BL1 = new cls_Test_put_PackageBill_BL(ConnectionString);
            //cls_Test_put_PackageBill_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_PackageBill_BL_SC002.json");


            //cls_Test_put_PackageBillExpense_BL cls_Test_put_PackageBillExpense_BL = new cls_Test_put_PackageBillExpense_BL(ConnectionString);
            //cls_Test_put_PackageBillExpense_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_PackageBillExpense_BL_SC001.json");

            //cls_Test_put_PackageBillExpense_BL cls_Test_put_PackageBillExpense_BL1 = new cls_Test_put_PackageBillExpense_BL(ConnectionString);
            //cls_Test_put_PackageBillExpense_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_PackageBillExpense_BL_SC002.json");


            //cls_Test_put_PackageBillPayment_BL cls_Test_put_PackageBillPayment_BL = new cls_Test_put_PackageBillPayment_BL(ConnectionString);
            //cls_Test_put_PackageBillPayment_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_PackageBillPayment_BL_SC001.json");

            //cls_Test_put_PackageBillPayment_BL cls_Test_put_PackageBillPayment_BL1 = new cls_Test_put_PackageBillPayment_BL(ConnectionString);
            //cls_Test_put_PackageBillPayment_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_PackageBillPayment_BL_SC002.json");


            //cls_Test_put_SplitBill_BL cls_Test_put_SplitBill_BL = new cls_Test_put_SplitBill_BL(ConnectionString);
            //cls_Test_put_SplitBill_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_SplitBill_BL_SC001.json");

            //cls_Test_put_SplitBill_BL cls_Test_put_SplitBill_BL1 = new cls_Test_put_SplitBill_BL(ConnectionString);
            //cls_Test_put_SplitBill_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApp\\datafile\\cls_Test_put_SplitBill_BL_SC002.json");


            //GET

            //cls_Test_get_OPBillList_BL test = new cls_Test_get_OPBillList_BL(ConnectionString);
            //Console.WriteLine(test.SC_001());
            //Console.WriteLine(test.SC_002());
            //Console.WriteLine(test.SC_003());


            //cls_Test_get_NewOPBillListMaster_BL test1 = new cls_Test_get_NewOPBillListMaster_BL(ConnectionString);
            //Console.WriteLine(test1.SC_001());
            //Console.WriteLine(test1.SC_002());
            //Console.WriteLine(test1.SC_003());

            //cls_Test_get_OPBillDetail_BL test2 = new cls_Test_get_OPBillDetail_BL(ConnectionString);
            //Console.WriteLine(test2.SC_001());
            //Console.WriteLine(test2.SC_002());
            //Console.WriteLine(test2.SC_003());
        }
    }
}