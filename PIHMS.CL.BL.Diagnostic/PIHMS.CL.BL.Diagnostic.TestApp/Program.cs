
using PIHMS.CL.API.IO.Diagnostic;
using System.Text.Json;

namespace PIHMS.CL.BL.Diagnostic.TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world.....!");

            //String ConnectionString = "Server=sql605.main-hosting.eu; database=u294392736_pihms_dev; UID=u294392736_dev; password=Pihms@123$";

            String ConnectionString = "Server=127.0.0.1; database=db_ymsh_production; UID=root; password=root";

            cls_Test_put_DiagReport_BL cls_Test_put_DiagReport_BL = new cls_Test_put_DiagReport_BL(ConnectionString);
            cls_Test_put_DiagReport_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagReport_BL_DATA_SC001.json");

            cls_Test_put_DiagReport_BL cls_Test_put_DiagReport_BL1 = new cls_Test_put_DiagReport_BL(ConnectionString);
            cls_Test_put_DiagReport_BL.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagReport_BL_DATA_SC002.json");

            cls_Test_put_DiagPlanList_BL cls_Test_put_DiagPlanList_BL = new cls_Test_put_DiagPlanList_BL(ConnectionString);
            cls_Test_put_DiagPlanList_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagPlanList_BL_DATA_SC001.json");

            cls_Test_put_DiagPlanList_BL cls_Test_put_DiagPlanList_BL2 = new cls_Test_put_DiagPlanList_BL(ConnectionString);
            cls_Test_put_DiagPlanList_BL2.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagPlanList_BL_DATA_SC002.json");

            cls_Test_put_DiagRegenerate_BL cls_Test_put_DiagRegenerate_BL = new cls_Test_put_DiagRegenerate_BL(ConnectionString);
            cls_Test_put_DiagRegenerate_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagRegenerate_BL_DATA_SC001.json");

            cls_Test_put_DiagRegenerate_BL cls_Test_put_DiagRegenerate_BL3 = new cls_Test_put_DiagRegenerate_BL(ConnectionString);
            cls_Test_put_DiagRegenerate_BL3.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagRegenerate_BL_DATA_SC002.json");

            cls_Test_put_DiagReportStatus_BL cls_Test_put_DiagReportStatus_BL = new cls_Test_put_DiagReportStatus_BL(ConnectionString);
            cls_Test_put_DiagReportStatus_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagReportStatus_BL_DATA_SC001.json");

            cls_Test_put_DiagReportStatus_BL cls_Test_put_DiagReportStatus_BL4 = new cls_Test_put_DiagReportStatus_BL(ConnectionString);
            cls_Test_put_DiagReportStatus_BL4.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagReportStatus_BL_DATA_SC002.json");

            cls_Test_put_DiagSamplesMas_BL cls_Test_put_DiagSamplesMas_BL = new cls_Test_put_DiagSamplesMas_BL(ConnectionString);
            cls_Test_put_DiagSamplesMas_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagSamplesMas_BL_DATA_SC001.json");

            cls_Test_put_DiagSamplesMas_BL cls_Test_put_DiagSamplesMas_BL5 = new cls_Test_put_DiagSamplesMas_BL(ConnectionString);
            cls_Test_put_DiagSamplesMas_BL5.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagSamplesMas_BL_DATA_SC002.json");

            cls_Test_put_DiagSamplesTrn_BL cls_Test_put_DiagSamplesTrn_BL = new cls_Test_put_DiagSamplesTrn_BL(ConnectionString);
            cls_Test_put_DiagSamplesTrn_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagSamplesTrn_BL_DATA_SC001.json");

            cls_Test_put_DiagSamplesTrn_BL cls_Test_put_DiagSamplesTrn_BL6 = new cls_Test_put_DiagSamplesTrn_BL(ConnectionString);
            cls_Test_put_DiagSamplesTrn_BL6.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagSamplesTrn_BL_DATA_SC002.json");

            cls_Test_put_DiagTestgroups_BL cls_Test_put_DiagTestgroups_BL = new cls_Test_put_DiagTestgroups_BL(ConnectionString);
            cls_Test_put_DiagTestgroups_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagTestgroups_BL_DATA_SC001.json");

            cls_Test_put_DiagTestgroups_BL cls_Test_put_DiagTestgroups_BL7 = new cls_Test_put_DiagTestgroups_BL(ConnectionString);
            cls_Test_put_DiagTestgroups_BL7.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagTestgroups_BL_DATA_SC002.json");

            cls_Test_put_DiagTestinstrumentationName_BL cls_Test_put_DiagTestinstrumentationName_BL = new cls_Test_put_DiagTestinstrumentationName_BL(ConnectionString);
            cls_Test_put_DiagTestinstrumentationName_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagTestinstrumentationName_BL_DATA_SC001.json");

            cls_Test_put_DiagTestinstrumentationName_BL cls_Test_put_DiagTestinstrumentationName_BL8 = new cls_Test_put_DiagTestinstrumentationName_BL(ConnectionString);
            cls_Test_put_DiagTestinstrumentationName_BL8.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagTestinstrumentationName_BL_DATA_SC002.json");

            cls_Test_put_DiagTestplanDoc_BL cls_Test_put_DiagTestplanDoc_BL = new cls_Test_put_DiagTestplanDoc_BL(ConnectionString);
            cls_Test_put_DiagTestplanDoc_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagTestplanDoc_BL_DATA_SC001.json");

            cls_Test_put_DiagTestplanDoc_BL cls_Test_put_DiagTestplanDoc_BL9 = new cls_Test_put_DiagTestplanDoc_BL(ConnectionString);
            cls_Test_put_DiagTestplanDoc_BL9.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagTestplanDoc_BL_DATA_SC002.json");

            cls_Test_put_DiagTestPlanList_BL cls_Test_put_DiagTestPlanList_BL = new cls_Test_put_DiagTestPlanList_BL(ConnectionString);
            cls_Test_put_DiagTestPlanList_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagTestPlanList_BL_DATA_SC001.json");

            cls_Test_put_DiagTestPlanList_BL cls_Test_put_DiagTestPlanList_BL10 = new cls_Test_put_DiagTestPlanList_BL(ConnectionString);
            cls_Test_put_DiagTestPlanList_BL10.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagTestPlanList_BL_DATA_SC002.json");

            cls_Test_put_DiagTestranges_BL cls_Test_put_DiagTestranges_BL = new cls_Test_put_DiagTestranges_BL(ConnectionString);
            cls_Test_put_DiagTestranges_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagTestranges_BL_DATA_SC001.json");

            //cls_Test_put_DiagTestranges_BL cls_Test_put_DiagTestranges_BL11 = new cls_Test_put_DiagTestranges_BL(ConnectionString);
            //cls_Test_put_DiagTestranges_BL11.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagTestranges_BL_DATA_SC002.json");

            cls_Test_put_DiagTests_BL cls_Test_put_DiagTests_BL = new cls_Test_put_DiagTests_BL(ConnectionString);
            cls_Test_put_DiagTests_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagTests_BL_DATA_SC001.json");

            cls_Test_put_DiagTests_BL cls_Test_put_DiagTests_BL12 = new cls_Test_put_DiagTests_BL(ConnectionString);
            cls_Test_put_DiagTests_BL12.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagTests_BL_DATA_SC002.json");

            cls_Test_put_DiagTestTemplate_BL cls_Test_put_DiagTestTemplate_BL = new cls_Test_put_DiagTestTemplate_BL(ConnectionString);
            cls_Test_put_DiagTestTemplate_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagTestTemplate_BL_DATA_SC001.json");

            cls_Test_put_DiagTestTemplate_BL cls_Test_put_DiagTestTemplate_BL13 = new cls_Test_put_DiagTestTemplate_BL(ConnectionString);
            cls_Test_put_DiagTestTemplate_BL13.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagTestTemplate_BL_DATA_SC002.json");

            cls_Test_put_DiagUnits_BL cls_Test_put_DiagUnits_BL = new cls_Test_put_DiagUnits_BL(ConnectionString);
            cls_Test_put_DiagUnits_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagUnits_BL_DATA_SC001.json");

            cls_Test_put_DiagUnits_BL cls_Test_put_DiagUnits_BL14 = new cls_Test_put_DiagUnits_BL(ConnectionString);
            cls_Test_put_DiagUnits_BL14.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_DiagUnits_BL_DATA_SC002.json");

            cls_Test_put_IPCaseDiagnosisTagging_BL cls_Test_put_IPCaseDiagnosisTagging_BL = new cls_Test_put_IPCaseDiagnosisTagging_BL(ConnectionString);
            cls_Test_put_IPCaseDiagnosisTagging_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_IPCaseDiagnosisTagging_BL_DATA_SC001.json");

            cls_Test_put_IPCaseDiagnosisTagging_BL cls_Test_put_IPCaseDiagnosisTagging_BL15 = new cls_Test_put_IPCaseDiagnosisTagging_BL(ConnectionString);
            cls_Test_put_IPCaseDiagnosisTagging_BL15.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_IPCaseDiagnosisTagging_BL_DATA_SC002.json");

            cls_Test_put_ScanUsreport_BL cls_Test_put_ScanUsreport_BL = new cls_Test_put_ScanUsreport_BL(ConnectionString);
            cls_Test_put_ScanUsreport_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_ScanUsreport_BL_DATA_SC001.json");

            cls_Test_put_ScanUsreport_BL cls_Test_put_ScanUsreport_BL16 = new cls_Test_put_ScanUsreport_BL(ConnectionString);
            cls_Test_put_ScanUsreport_BL16.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_ScanUsreport_BL_DATA_SC002.json");

            cls_Test_put_ScannedReports_BL cls_Test_put_ScannedReports_BL = new cls_Test_put_ScannedReports_BL(ConnectionString);
            cls_Test_put_ScannedReports_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_ScannedReports_BL_DATA_SC001.json");

            cls_Test_put_ScannedReports_BL cls_Test_put_ScannedReports_BL17 = new cls_Test_put_ScannedReports_BL(ConnectionString);
            cls_Test_put_ScannedReports_BL17.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_ScannedReports_BL_DATA_SC002.json");

            cls_Test_put_ScannedReportItems_BL cls_Test_put_ScannedReportItems_BL = new cls_Test_put_ScannedReportItems_BL(ConnectionString);
            cls_Test_put_ScannedReportItems_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_ScannedReportItems_BL_DATA_SC001.json");

            cls_Test_put_ScannedReportItems_BL cls_Test_put_ScannedReportItems_BL18 = new cls_Test_put_ScannedReportItems_BL(ConnectionString);
            cls_Test_put_ScannedReportItems_BL18.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Diagnostic\PIHMS.CL.BL.Diagnostic.TestApp\data\cls_Test_put_ScannedReportItems_BL_DATA_SC002.json");


            //GET

            cls_Test_get_DiagTests_BL test1 = new cls_Test_get_DiagTests_BL(ConnectionString);
            Console.WriteLine(test1.SC_001());

            cls_Test_get_DiagRegenerate_BL test2 = new cls_Test_get_DiagRegenerate_BL(ConnectionString);
            Console.WriteLine(test2.SC_001());

            cls_test_get_DiagTestPlanList test3 = new cls_test_get_DiagTestPlanList(ConnectionString);
            Console.WriteLine(test3.SC_001());

            cls_Test_get_DiagReport_BL test4 = new cls_Test_get_DiagReport_BL(ConnectionString);
            Console.WriteLine(test4.SC_001());

            cls_Test_get_DiagTestgroups_BL test5 = new cls_Test_get_DiagTestgroups_BL(ConnectionString);
            Console.WriteLine(test5.SC_001());

            cls_Test_get_DiagTestranges_BL test7 = new cls_Test_get_DiagTestranges_BL(ConnectionString);
            Console.WriteLine(test7.SC_001());

            cls_Test_get_DiagTestTemplate_BL test8 = new cls_Test_get_DiagTestTemplate_BL(ConnectionString);
            Console.WriteLine(test8.SC_001());

            cls_Test_get_DiagTestplanDoc_BL test9 = new cls_Test_get_DiagTestplanDoc_BL(ConnectionString);
            Console.WriteLine(test9.SC_001());

            cls_Test_get_DiagUnits_BL test10 = new cls_Test_get_DiagUnits_BL(ConnectionString);
            Console.WriteLine(test10.SC_001());

            cls_Test_get_DiagSamplesMas_BL test11 = new cls_Test_get_DiagSamplesMas_BL(ConnectionString);
            Console.WriteLine(test11.SC_001());

            cls_Test_get_DiagTestinstrumentationName_BL test12 = new cls_Test_get_DiagTestinstrumentationName_BL(ConnectionString);
            Console.WriteLine(test12.SC_001());

            cls_Test_get_IPCaseDiagnosisTagging_BL test13 = new cls_Test_get_IPCaseDiagnosisTagging_BL(ConnectionString);
            Console.WriteLine(test13.SC_001());

            cls_Test_get_DiagReportStatus_BL test14 = new cls_Test_get_DiagReportStatus_BL(ConnectionString);
            Console.WriteLine(test14.SC_001());

            cls_Test_get_DiagSamplesTrn_BL test15 = new cls_Test_get_DiagSamplesTrn_BL(ConnectionString);
            Console.WriteLine(test15.SC_001());

        }
    }
}

