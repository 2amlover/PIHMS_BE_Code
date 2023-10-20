using PIHMS.CL.API.IO.Finance;
using System;
using System.Text.Json;

namespace PIHMS.CL.BL.Finance.TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            String ConnectionString = "Server=127.0.0.1; database=db_ymsh_production; UID=root; password=root";

            cls_Test_put_AccountInvoiceItems_BL cls_Test_put_AccountInvoiceItems_BL = new cls_Test_put_AccountInvoiceItems_BL(ConnectionString);
            cls_Test_put_AccountInvoiceItems_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Finance\PIHMS.CL.BL.Finance.TestApp\json\cls_Test_put_AccountInvoiceItems_BL_SC001.json");

            cls_Test_put_AccountInvoiceItems_BL cls_Test_put_AccountInvoiceItems_BL1 = new cls_Test_put_AccountInvoiceItems_BL(ConnectionString);
            cls_Test_put_AccountInvoiceItems_BL1.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Finance\PIHMS.CL.BL.Finance.TestApp\json\cls_Test_put_AccountInvoiceItems_BL_SC002.json");

            cls_Test_put_AccountInvoices_BL cls_Test_put_AccountInvoices_BL = new cls_Test_put_AccountInvoices_BL(ConnectionString);
            cls_Test_put_AccountInvoices_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Finance\PIHMS.CL.BL.Finance.TestApp\json\cls_Test_put_AccountInvoices_BL_SC001.json");

            cls_Test_put_AccountInvoices_BL cls_Test_put_AccountInvoices_BL2 = new cls_Test_put_AccountInvoices_BL(ConnectionString);
            cls_Test_put_AccountInvoices_BL2.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Finance\PIHMS.CL.BL.Finance.TestApp\json\cls_Test_put_AccountInvoices_BL_SC002.json");

            cls_Test_put_AccountPayables_BL cls_Test_put_AccountPayables_BL = new cls_Test_put_AccountPayables_BL(ConnectionString);
            cls_Test_put_AccountPayables_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Finance\PIHMS.CL.BL.Finance.TestApp\json\cls_Test_put_AccountPayables_BL_SC001.json");

            cls_Test_put_AccountPayables_BL cls_Test_put_AccountPayables_BL3 = new cls_Test_put_AccountPayables_BL(ConnectionString);
            cls_Test_put_AccountPayables_BL3.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Finance\PIHMS.CL.BL.Finance.TestApp\json\cls_Test_put_AccountPayables_BL_SC002.json");

            cls_Test_put_AccountPO_BL cls_Test_put_AccountPO_BL = new cls_Test_put_AccountPO_BL(ConnectionString);
            cls_Test_put_AccountPO_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Finance\PIHMS.CL.BL.Finance.TestApp\json\cls_Test_put_AccountPO_BL_SC001.json");

            cls_Test_put_AccountPO_BL cls_Test_put_AccountPO_BL4 = new cls_Test_put_AccountPO_BL(ConnectionString);
            cls_Test_put_AccountPO_BL4.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Finance\PIHMS.CL.BL.Finance.TestApp\json\cls_Test_put_AccountPO_BL_SC002.json");

            cls_Test_put_AccountPOItems_BL cls_Test_put_AccountPOItems_BL = new cls_Test_put_AccountPOItems_BL(ConnectionString);
            cls_Test_put_AccountPOItems_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Finance\PIHMS.CL.BL.Finance.TestApp\json\cls_Test_put_AccountPOItems_BL_SC001.json");

            cls_Test_put_AccountPOItems_BL cls_Test_put_AccountPOItems_BL5 = new cls_Test_put_AccountPOItems_BL(ConnectionString);
            cls_Test_put_AccountPOItems_BL5.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Finance\PIHMS.CL.BL.Finance.TestApp\json\cls_Test_put_AccountPOItems_BL_SC002.json");

            cls_Test_put_AccountRFQ_BL cls_Test_put_AccountRFQ_BL = new cls_Test_put_AccountRFQ_BL(ConnectionString);
            cls_Test_put_AccountRFQ_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Finance\PIHMS.CL.BL.Finance.TestApp\json\cls_Test_put_AccountRFQ_BL_SC001.json");

            cls_Test_put_AccountRFQ_BL cls_Test_put_AccountRFQ_BL6 = new cls_Test_put_AccountRFQ_BL(ConnectionString);
            cls_Test_put_AccountRFQ_BL6.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Finance\PIHMS.CL.BL.Finance.TestApp\json\cls_Test_put_AccountRFQ_BL_SC002.json");

            cls_Test_put_RelPayables_BL cls_Test_put_RelPayables_BL = new cls_Test_put_RelPayables_BL(ConnectionString);
            cls_Test_put_RelPayables_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Finance\PIHMS.CL.BL.Finance.TestApp\json\cls_Test_put_RelPayables_BL_SC001.json");

            cls_Test_put_RelPayables_BL cls_Test_put_RelPayables_BL7 = new cls_Test_put_RelPayables_BL(ConnectionString);
            cls_Test_put_RelPayables_BL7.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Finance\PIHMS.CL.BL.Finance.TestApp\json\cls_Test_put_RelPayables_BL_SC002.json");

            //Get

            cls_Test_get_AccountInvoiceItems_BL test1 = new cls_Test_get_AccountInvoiceItems_BL(ConnectionString);
            Console.WriteLine(test1.SC_001());

            cls_Test_get_AccountInvoices_BL test2 = new cls_Test_get_AccountInvoices_BL(ConnectionString);
            Console.WriteLine(test2.SC_001());

            cls_Test_get_AccountPayables_BL test3 = new cls_Test_get_AccountPayables_BL(ConnectionString);
            Console.WriteLine(test3.SC_001());

            cls_Test_get_AccountPO_BL test4 = new cls_Test_get_AccountPO_BL(ConnectionString);
            Console.WriteLine(test4.SC_001());

            cls_Test_get_AccountPOItems_BL test5 = new cls_Test_get_AccountPOItems_BL(ConnectionString);
            Console.WriteLine(test5.SC_001());

            cls_Test_get_AccountRFQ_BL test6 = new cls_Test_get_AccountRFQ_BL(ConnectionString);
            Console.WriteLine(test6.SC_001());

            cls_Test_get_RelPayables_BL test7 = new cls_Test_get_RelPayables_BL(ConnectionString);
            Console.WriteLine(test7.SC_001());

            Console.ReadKey();
        }
    }
}
