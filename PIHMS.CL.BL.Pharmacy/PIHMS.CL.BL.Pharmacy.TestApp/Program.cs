using PIHMS.CL.API.IO.Pharmacy;
using System.Text.Json;

namespace PIHMS.CL.BL.Pharmacy.TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            String ConnectionString = "Server=127.0.0.1; database=db_ymsh_production; UID=root; password=root";

            //PUT
            cls_Test_put_Pharmacy_BL cls_Test_put_Pharmacy_BL = new cls_Test_put_Pharmacy_BL(ConnectionString);
            cls_Test_put_Pharmacy_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Pharmacy\PIHMS.CL.BL.Pharmacy.TestApp\json\cls_Test_put_Pharmacy_BL_DATA_SC001.json");

            cls_Test_put_Pharmacy_BL cls_Test_put_Pharmacy_BL1 = new cls_Test_put_Pharmacy_BL(ConnectionString);
            cls_Test_put_Pharmacy_BL.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Pharmacy\PIHMS.CL.BL.Pharmacy.TestApp\json\cls_Test_put_Pharmacy_BL_DATA_SC002.json");

            cls_Test_put_PharmacyItem_BL cls_Test_put_PharmacyItem_BL = new cls_Test_put_PharmacyItem_BL(ConnectionString);
            cls_Test_put_PharmacyItem_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Pharmacy\PIHMS.CL.BL.Pharmacy.TestApp\json\cls_Test_put_PharmacyItem_BL_DATA_SC001.json");

            cls_Test_put_PharmacyItem_BL cls_Test_get_PharmacyItem_BL = new cls_Test_put_PharmacyItem_BL(ConnectionString);
            cls_Test_put_PharmacyItem_BL.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Pharmacy\PIHMS.CL.BL.Pharmacy.TestApp\json\cls_Test_put_PharmacyItem_BL_DATA_SC002.json");

            cls_Test_put_PharmacyItems_BL cls_Test_put_PharmacyItems_BL = new cls_Test_put_PharmacyItems_BL(ConnectionString);
            cls_Test_put_PharmacyItems_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Pharmacy\PIHMS.CL.BL.Pharmacy.TestApp\json\cls_Test_put_PharmacyItems_BL_DATA_SC001.json");

            cls_Test_put_PharmacyItems_BL cls_Test_put_PharmacyItems_BL2 = new cls_Test_put_PharmacyItems_BL(ConnectionString);
            cls_Test_put_PharmacyItems_BL.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Pharmacy\PIHMS.CL.BL.Pharmacy.TestApp\json\cls_Test_put_PharmacyItems_BL_DATA_SC002.json");

            //GET
            cls_Test_get_PharmacyItem_BL test1 = new cls_Test_get_PharmacyItem_BL(ConnectionString);
            Console.WriteLine(test1.SC_001());

            cls_Test_get_Pharmacy_BL test2 = new cls_Test_get_Pharmacy_BL(ConnectionString);
            Console.WriteLine(test2.SC_001());

            cls_Test_get_PharmacyItems_BL test3 = new cls_Test_get_PharmacyItems_BL(ConnectionString);
            Console.WriteLine(test3.SC_001());
            Console.ReadKey();
        }

    }
}

