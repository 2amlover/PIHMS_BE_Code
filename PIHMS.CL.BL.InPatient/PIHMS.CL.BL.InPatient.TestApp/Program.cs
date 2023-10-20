using PIHMS.CL.API.IO.InPatient;
using PIHMS.ConsoleApp.API.BL.InPatient.Test;
using System.Text.Json;

namespace PIHMS.CL.BL.InPatient.TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
          //  String ConnectionString = "Server=127.0.0.1; database=db_ymsh_production; UID=dev; password=dev@1234";
            String ConnectionString = "Server=127.0.0.1; database=db_ymsh_production; UID=root; password=root";


            //cls_test_get_IPCaseDoctorConsultations_BL test1 = new cls_test_get_IPCaseDoctorConsultations_BL(ConnectionString);
            //Console.WriteLine(test1.SC_001());
            //Console.WriteLine(test1.SC_002());

            //cls_test_get_IPCaseBedConsumables_BL test2 = new cls_test_get_IPCaseBedConsumables_BL(ConnectionString);
            //Console.WriteLine(test2.SC_001());
            //Console.WriteLine(test2.SC_002());

            //cls_test_get_IPCaseList_BL test3 = new cls_test_get_IPCaseList_BL(ConnectionString);
            //Console.WriteLine(test3.SC_001());

            cls_Test_get_IPCaseBillDetail_BL test6 = new cls_Test_get_IPCaseBillDetail_BL(ConnectionString);
           Console.WriteLine(test6.SC_001());

            //cls_test_get_IPCaseListMaster_BL test4 = new cls_test_get_IPCaseListMaster_BL(ConnectionString);
            //Console.WriteLine(test4.SC_001());

            //cls_test_get_IPCaseMedication_BL test5 = new cls_test_get_IPCaseMedication_BL(ConnectionString);
          //  Console.WriteLine(test5.SC_001());
            //Console.WriteLine(test2.SC_002());

            //cls_Test_get_IPCaseCorprationDetail_BL test25 = new cls_Test_get_IPCaseCorprationDetail_BL(ConnectionString);
            //Console.WriteLine(test25.SC_001());
            //cls_Test_get_IPCaseList_BL test = new cls_Test_get_IPCaseList_BL(ConnectionString);
            //Console.WriteLine(test.SC_001());
            //cls_Test_get_IPCaseBillItems_BL test1 = new cls_Test_get_IPCaseBillItems_BL(ConnectionString);
            //Console.WriteLine(test1.SC_001());
            //cls_Test_get_IPCaseBills_BL test2 = new cls_Test_get_IPCaseBills_BL(ConnectionString);
            //Console.WriteLine(test2.SC_001());
            //cls_Test_get_IPCaseBillPayments_BL test3 = new cls_Test_get_IPCaseBillPayments_BL(ConnectionString);
            //Console.WriteLine(test3.SC_001());
            //cls_Test_get_IPCaseBillPaymentReciept_BL test4 = new cls_Test_get_IPCaseBillPaymentReciept_BL(ConnectionString);
            //Console.WriteLine(test4.SC_001());
            //cls_Test_get_IPCaseWardDetails_BL test5 = new cls_Test_get_IPCaseWardDetails_BL(ConnectionString);
            //Console.WriteLine(test5.SC_001());
            //cls_Test_get_IPCaseDemographicInfo_BL test6 = new cls_Test_get_IPCaseDemographicInfo_BL(ConnectionString);
            //Console.WriteLine(test6.SC_001());
            //cls_Test_get_IPCaseDischargeSummary_BL test7 = new cls_Test_get_IPCaseDischargeSummary_BL(ConnectionString);
            //Console.WriteLine(test7.SC_001());
            //cls_Test_get_IPCaseConsumeable_BL test8 = new cls_Test_get_IPCaseConsumeable_BL(ConnectionString);
            //Console.WriteLine(test8.SC_001());
            //cls_Test_get_IPCaseBillSummary_BL test9 = new cls_Test_get_IPCaseBillSummary_BL(ConnectionString);
            //Console.WriteLine(test9.SC_001());
            //cls_Test_get_IPCaseInsuranceDetail_BL test10 = new cls_Test_get_IPCaseInsuranceDetail_BL(ConnectionString);
            //Console.WriteLine(test10.SC_001());
            //cls_Test_get_IPCaseInsurenceReceived_BL test11 = new cls_Test_get_IPCaseInsurenceReceived_BL(ConnectionString);
            //Console.WriteLine(test11.SC_001());
            //cls_Test_get_IPCaseConsumeableDetail_BL test12 = new cls_Test_get_IPCaseConsumeableDetail_BL(ConnectionString);
            //Console.WriteLine(test12.SC_001());
            //cls_Test_get_IPCasePatientAddress_BL test13 = new cls_Test_get_IPCasePatientAddress_BL(ConnectionString);
            //Console.WriteLine(test13.SC_001());
            //cls_Test_get_IPCaseMedications_BL test14 = new cls_Test_get_IPCaseMedications_BL(ConnectionString);
            //Console.WriteLine(test14.SC_001());
            //cls_Test_get_IPCaseAdmittedFor_BL test15 = new cls_Test_get_IPCaseAdmittedFor_BL(ConnectionString);
            //Console.WriteLine(test15.SC_001());
            //cls_Test_get_IPCaseInsurencePayment_BL test16 = new cls_Test_get_IPCaseInsurencePayment_BL(ConnectionString);
            //Console.WriteLine(test16.SC_001());
            //cls_Test_get_IPCaseDsTitle_BL test17 = new cls_Test_get_IPCaseDsTitle_BL(ConnectionString);
            //Console.WriteLine(test17.SC_001());
            //cls_Test_get_IPCaseDsTemplateData_BL test18 = new cls_Test_get_IPCaseDsTemplateData_BL(ConnectionString);
            //Console.WriteLine(test18.SC_001());
            //cls_Test_get_IPCaseDiagnosisTagging_BL test19 = new cls_Test_get_IPCaseDiagnosisTagging_BL(ConnectionString);
            //Console.WriteLine(test19.SC_001());
            //cls_Test_get_IPCaseICDCodes_BL test20 = new cls_Test_get_IPCaseICDCodes_BL(ConnectionString);
            //Console.WriteLine(test20.SC_001());
            //cls_Test_get_IPCaseDoctors_BL test21 = new cls_Test_get_IPCaseDoctors_BL(ConnectionString);
            //Console.WriteLine(test21.SC_001());
            //cls_Test_get_IPCaseVitalSigns_BL test22 = new cls_Test_get_IPCaseVitalSigns_BL(ConnectionString);
            //Console.WriteLine(test22.SC_001());
            //cls_Test_get_IPCaseDsTemplate_BL test23 = new cls_Test_get_IPCaseDsTemplate_BL(ConnectionString);
            //Console.WriteLine(test23.SC_001());
            //cls_Test_get_IPCaseEstItems_BL test24 = new cls_Test_get_IPCaseEstItems_BL(ConnectionString);
            //Console.WriteLine(test24.SC_001());
            //cls_Test_get_IPCaseEstimatedBillItems_BL test26 = new cls_Test_get_IPCaseEstimatedBillItems_BL(ConnectionString);
            //Console.WriteLine(test26.SC_001());
            //cls_Test_get_IPCaseEstimatedBills_BL test27 = new cls_Test_get_IPCaseEstimatedBills_BL(ConnectionString);
            //Console.WriteLine(test27.SC_001());
            //cls_Test_get_IPCaseEvents_BL test28 = new cls_Test_get_IPCaseEvents_BL(ConnectionString);
            //Console.WriteLine(test28.SC_001());
            //cls_Test_get_IPCaseNotes_BL test29 = new cls_Test_get_IPCaseNotes_BL(ConnectionString);
            //Console.WriteLine(test29.SC_001());
            //cls_Test_get_IPCaseSignandSymptoms_BL test30 = new cls_Test_get_IPCaseSignandSymptoms_BL(ConnectionString);
            //Console.WriteLine(test30.SC_001());
            //cls_Test_get_IPCaseSurgeryNotes_BL test31 = new cls_Test_get_IPCaseSurgeryNotes_BL(ConnectionString);
            //Console.WriteLine(test31.SC_001());
            //cls_Test_get_IPDoctorPrice_BL test64 = new cls_Test_get_IPDoctorPrice_BL(ConnectionString);
            //Console.WriteLine(test64.SC_001());
            //cls_Test_get_IPScanCasesheet_BL test65 = new cls_Test_get_IPScanCasesheet_BL(ConnectionString);
            //Console.WriteLine(test65.SC_001());
            //cls_Test_get_IPWardequipments_BL test66 = new cls_Test_get_IPWardequipments_BL(ConnectionString);
            //Console.WriteLine(test66.SC_001());
            //cls_Test_get_IPWardincharge_BL test67 = new cls_Test_get_IPWardincharge_BL(ConnectionString);
            //Console.WriteLine(test67.SC_001());
            //cls_Test_get_IPWardschedule_BL test68 = new cls_Test_get_IPWardschedule_BL(ConnectionString);
            //Console.WriteLine(test68.SC_001());






            //cls_Test_put_IPCaseList_BL test32 = new cls_Test_put_IPCaseList_BL(ConnectionString);
            //test32.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseList_BL_SC001.json");
            //test32.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseList_BL_SC002.json");

            //cls_Test_put_IPCaseBillItems_BL test33 = new cls_Test_put_IPCaseBillItems_BL(ConnectionString);
            //test33.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseBillItems_BL_SC001.json");
            //test33.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseBillItems_BL_SC002.json");
            //cls_Test_put_IPCaseBills_BL test34 = new cls_Test_put_IPCaseBills_BL(ConnectionString);
            //test34.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseBills_BL_SC001.json");
            //test34.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseBills_BL_SC002.json");

            //cls_Test_put_IPCaseBillPayments_BL test35 = new cls_Test_put_IPCaseBillPayments_BL(ConnectionString);
            //test35.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseBillPayments_BL_SC001.json");
            //test35.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseBillPayments_BL_SC002.json");

            //cls_Test_put_IPCaseBillPaymentReciept_BL test36 = new cls_Test_put_IPCaseBillPaymentReciept_BL(ConnectionString);
            //test36.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseBillPaymentReciept_BL_SC001.json");
            //test36.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseBillPaymentReciept_BL_SC002.json");

            //cls_Test_put_IPCaseWardDetails_BL test37 = new cls_Test_put_IPCaseWardDetails_BL(ConnectionString);
            //test37.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseWardDetails_BL_SC001.json");
            //test37.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseWardDetails_BL_SC002.json");

            //cls_Test_put_IPCaseDemographicInfo_BL test38 = new cls_Test_put_IPCaseDemographicInfo_BL(ConnectionString);
            //test38.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseDemographicInfo_BL_SC001.json");
            //test38.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseDemographicInfo_BL_SC002.json");

            //cls_Test_put_IPCaseDischargeSummary_BL test39 = new cls_Test_put_IPCaseDischargeSummary_BL(ConnectionString);
            //test39.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseDischargeSummary_BL_SC001.json");
            //test39.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseDischargeSummary_BL_SC002.json");

            //cls_Test_put_IPCaseConsumeable_BL test40 = new cls_Test_put_IPCaseConsumeable_BL(ConnectionString);
            //test40.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseConsumeable_BL_SC001.json");
            //test40.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseConsumeable_BL_SC002.json");

            //cls_Test_put_IPCaseBillSummary_BL test41 = new cls_Test_put_IPCaseBillSummary_BL(ConnectionString);
            //test41.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseBillSummary_BL_SC001.json");
            //test41.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseBillSummary_BL_SC002.json");

            //cls_Test_put_IPCaseInsuranceDetail_BL test42 = new cls_Test_put_IPCaseInsuranceDetail_BL(ConnectionString);
            //test42.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseInsuranceDetail_BL_SC001.json");
            //test42.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseInsuranceDetail_BL_SC002.json");

            //cls_Test_put_IPCaseInsurenceReceived_BL test43 = new cls_Test_put_IPCaseInsurenceReceived_BL(ConnectionString);
            //test43.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseInsurenceReceived_BL_SC001.json");
            //test43.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseInsurenceReceived_BL_SC002.json");

            //cls_Test_put_IPCaseConsumeableDetail_BL test44 = new cls_Test_put_IPCaseConsumeableDetail_BL(ConnectionString);
            //test44.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseConsumeableDetail_BL_SC001.json");
            //test44.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseConsumeableDetail_BL_SC002.json");

            //cls_Test_put_IPCasePatientAddress_BL test45 = new cls_Test_put_IPCasePatientAddress_BL(ConnectionString);
            //test45.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCasePatientAddress_BL_SC001.json");
            //test45.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCasePatientAddress_BL_SC002.json");

            //cls_Test_put_IPCaseMedications_BL test46 = new cls_Test_put_IPCaseMedications_BL(ConnectionString);
            //test46.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseMedications_BL_SC001.json");
            //test46.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseMedications_BL_SC002.json");

            //cls_Test_put_IPCaseAdmittedFor_BL test47 = new cls_Test_put_IPCaseAdmittedFor_BL(ConnectionString);
            //test47.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseAdmittedFor_BL_SC001.json");
            //test47.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseAdmittedFor_BL_SC002.json");

            //cls_Test_put_IPCaseInsurencePayment_BL test48 = new cls_Test_put_IPCaseInsurencePayment_BL(ConnectionString);
            //test48.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseInsurencePayment_BL_SC001.json");
            //test48.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseInsurencePayment_BL_SC002.json");

            //cls_Test_put_IPCaseDsTitle_BL test49 = new cls_Test_put_IPCaseDsTitle_BL(ConnectionString);
            //test49.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseDsTitle_BL_SC001.json");
            //test49.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseDsTitle_BL_SC002.json");

            //cls_Test_put_IPCaseDsTemplateData_BL test50 = new cls_Test_put_IPCaseDsTemplateData_BL(ConnectionString);
            //test50.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseDsTemplateData_BL_SC001.json");
            //test50.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseDsTemplateData_BL_SC002.json");

            //cls_Test_put_IPCaseDiagnosisTagging_BL test51 = new cls_Test_put_IPCaseDiagnosisTagging_BL(ConnectionString);
            //test51.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseDiagnosisTagging_BL_SC001.json");
            //test51.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseDiagnosisTagging_BL_SC002.json");

            //cls_Test_put_IPCaseICDCodes_BL test52 = new cls_Test_put_IPCaseICDCodes_BL(ConnectionString);
            //test52.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseICDCodes_BL_SC001.json");
            //test52.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseICDCodes_BL_SC002.json");

            //cls_Test_put_IPCaseDoctors_BL test53 = new cls_Test_put_IPCaseDoctors_BL(ConnectionString);
            //test53.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseDoctors_BL_SC001.json");
            //test53.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseDoctors_BL_SC002.json");

            //cls_Test_put_IPCaseVitalSigns_BL test54 = new cls_Test_put_IPCaseVitalSigns_BL(ConnectionString);
            //test54.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseVitalSigns_BL_SC001.json");
            //test54.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseVitalSigns_BL_SC002.json");

            //cls_Test_put_IPCaseDsTemplate_BL test55 = new cls_Test_put_IPCaseDsTemplate_BL(ConnectionString);
            //test55.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseDsTemplate_BL_SC001.json");
            //test55.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseDsTemplate_BL_SC002.json");

            //cls_Test_put_IPCaseEstItems_BL test56 = new cls_Test_put_IPCaseEstItems_BL(ConnectionString);
            //test56.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseEstItems_BL_SC001.json");
            //test56.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseEstItems_BL_SC002.json");

            //cls_Test_put_IPCaseCorprationDetail_BL test57 = new cls_Test_put_IPCaseCorprationDetail_BL(ConnectionString);
            //test57.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseCorprationDetail_BL_SC001.json");
            //test57.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseCorprationDetail_BL_SC002.json");

            //cls_Test_put_IPCaseEstimatedBillItems_BL test58 = new cls_Test_put_IPCaseEstimatedBillItems_BL(ConnectionString);
            //test58.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseEstimatedBillItems_BL_SC001.json");
            //test58.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseEstimatedBillItems_BL_SC002.json");

            //cls_Test_put_IPCaseEstimatedBills_BL test59 = new cls_Test_put_IPCaseEstimatedBills_BL(ConnectionString);
            //test59.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseEstimatedBills_BL_SC001.json");
            //test59.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseEstimatedBills_BL_SC002.json");

            //cls_Test_put_IPCaseEvents_BL test60 = new cls_Test_put_IPCaseEvents_BL(ConnectionString);
            //test60.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseEvents_BL_SC001.json");
            //test60.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseEvents_BL_SC002.json");

            //cls_Test_put_IPCaseNotes_BL test61 = new cls_Test_put_IPCaseNotes_BL(ConnectionString);
            //test61.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseNotes_BL_SC001.json");
            //test61.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseNotes_BL_SC002.json");

            //cls_Test_put_IPCaseSignandSymptoms_BL test62 = new cls_Test_put_IPCaseSignandSymptoms_BL(ConnectionString);
            //test62.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseSignandSymptoms_BL_SC001.json");
            //test62.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseSignandSymptoms_BL_SC002.json");

            //cls_Test_put_IPCaseSurgeryNotes_BL test63 = new cls_Test_put_IPCaseSurgeryNotes_BL(ConnectionString);
            //test63.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseSurgeryNotes_BL_SC001.json");
            //test63.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPCaseSurgeryNotes_BL_SC002.json");

            //cls_Test_put_IPDoctorPrice_BL test69 = new cls_Test_put_IPDoctorPrice_BL(ConnectionString);
            //test69.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPDoctorPrice_BL_SC001.json");
            //test69.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPDoctorPrice_BL_SC002.json");

            //cls_Test_put_IPScanCasesheet_BL test70 = new cls_Test_put_IPScanCasesheet_BL(ConnectionString);
            //test70.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPScanCasesheet_BL_SC001.json");
            //test70.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPScanCasesheet_BL_SC002.json");

            //cls_Test_put_IPWardequipments_BL test71 = new cls_Test_put_IPWardequipments_BL(ConnectionString);
            //test71.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPWardequipments_BL_SC001.json");
            //test71.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPWardequipments_BL_SC002.json");

            //cls_Test_put_IPWardincharge_BL test72 = new cls_Test_put_IPWardincharge_BL(ConnectionString);
            //test72.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPWardincharge_BL_SC001.json");
            //test72.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPWardincharge_BL_SC002.json");

            //cls_Test_put_IPWardschedule_BL test73 = new cls_Test_put_IPWardschedule_BL(ConnectionString);
            //test73.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPWardschedule_BL_SC001.json");
            //test73.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.InPatient\PIHMS.CL.BL.InPatient.TestApp\JsonFile\\cls_Test_put_IPWardschedule_BL_SC002.json");

            //Console.ReadLine();
            //CreateJSONFile("cls_Test_put_IPDoctorPrice_BL_SC001");

            //CreateJSONFile("cls_Test_put_IPScanCasesheet_BL_SC001");

            //CreateJSONFile("cls_Test_put_IPWardequipments_BL_SC001");

            //CreateJSONFile("cls_Test_put_IPWardincharge_BL_SC001");

            //CreateJSONFile("cls_Test_put_IPWardschedule_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseBillSummary_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseConsumeable_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseConsumeableDetail_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseCorprationDetail_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseDemographicInfo_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseDiagnosisTagging_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseDischargeSummary_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseDoctors_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseDsTemplate_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseDsTemplateData_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseDsTitle_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseEstimatedBillItems_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseEstimatedBills_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseEstItems_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseEvents_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseICDCodes_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseInsuranceDetail_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseInsurencePayment_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseInsurenceReceived_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseList_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseMedications_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseNotes_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCasePatientAddress_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseSignandSymptoms_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseSurgeryNotes_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseVitalSigns_BL_SC001");
            //CreateJSONFile("cls_Test_put_IPCaseWardDetails_BL_SC001");


        }
        //static void CreateJSONFile(string Classname)
        //{
        //    string strJson = "";
        //    switch (Classname)
        //    {
        //        case "cls_Test_put_IPDoctorPrice_BL_SC001":
        //            put_IPDoctorPrice_IP put_IPDoctorPrice_IP = new put_IPDoctorPrice_IP();
        //            strJson = JsonSerializer.Serialize<put_IPDoctorPrice_IP>(put_IPDoctorPrice_IP);
        //            break;
        //        case "cls_Test_put_IPScanCasesheet_BL_SC001":
        //            put_IPScanCasesheet_IP put_IPScanCasesheet_IP = new put_IPScanCasesheet_IP();
        //            strJson = JsonSerializer.Serialize<put_IPScanCasesheet_IP>(put_IPScanCasesheet_IP);
        //            break;
        //        case "cls_Test_put_IPWardequipments_BL_SC001":
        //            put_IPWardequipments_IP put_IPWardequipments_IP = new put_IPWardequipments_IP();
        //            strJson = JsonSerializer.Serialize<put_IPWardequipments_IP>(put_IPWardequipments_IP);
        //            break;

        //        case "cls_Test_put_IPWardincharge_BL_SC001":
        //            put_IPWardincharge_IP put_IPWardincharge_IP = new put_IPWardincharge_IP();
        //            strJson = JsonSerializer.Serialize<put_IPWardincharge_IP>(put_IPWardincharge_IP);
        //            break;

        //        case "cls_Test_put_IPWardschedule_BL_SC001":
        //            put_IPWardschedule_IP put_IPWardschedule_IP = new put_IPWardschedule_IP();
        //            strJson = JsonSerializer.Serialize<put_IPWardschedule_IP>(put_IPWardschedule_IP);
        //            break;

        //        case "cls_Test_put_IPCaseBillSummary_BL_SC001":
        //            put_IPCaseBillSummary_IP put_IPCaseBillSummary_IP = new put_IPCaseBillSummary_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseBillSummary_IP>(put_IPCaseBillSummary_IP);
        //            break;

        //        case "cls_Test_put_IPCaseConsumeable_BL_SC001":
        //            put_IPCaseConsumeable_IP put_IPCaseConsumeable_IP = new put_IPCaseConsumeable_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseConsumeable_IP>(put_IPCaseConsumeable_IP);
        //            break;

        //        case "cls_Test_put_IPCaseConsumeableDetail_BL_SC001":
        //            put_IPCaseConsumeableDetail_IP put_IPCaseConsumeableDetail_IP = new put_IPCaseConsumeableDetail_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseConsumeableDetail_IP>(put_IPCaseConsumeableDetail_IP);
        //            break;

        //        case "cls_Test_put_IPCaseCorprationDetail_BL_SC001":
        //            put_IPCaseCorprationDetail_IP put_IPCaseCorprationDetail_IP = new put_IPCaseCorprationDetail_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseCorprationDetail_IP>(put_IPCaseCorprationDetail_IP);
        //            break;

        //        case "cls_Test_put_IPCaseDemographicInfo_BL_SC001":
        //            put_IPCaseDemographicInfo_IP put_IPCaseDemographicInfo_IP = new put_IPCaseDemographicInfo_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseDemographicInfo_IP>(put_IPCaseDemographicInfo_IP);
        //            break;

        //        case "cls_Test_put_IPCaseDiagnosisTagging_BL_SC001":
        //            put_IPCaseDiagnosisTagging_IP put_IPCaseDiagnosisTagging_IP = new put_IPCaseDiagnosisTagging_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseDiagnosisTagging_IP>(put_IPCaseDiagnosisTagging_IP);
        //            break;

        //        case "cls_Test_put_IPCaseDischargeSummary_BL_SC001":
        //            put_IPCaseDischargeSummary_IP put_IPCaseDischargeSummary_IP = new put_IPCaseDischargeSummary_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseDischargeSummary_IP>(put_IPCaseDischargeSummary_IP);
        //            break;

        //        case "cls_Test_put_IPCaseDoctors_BL_SC001":
        //            put_IPCaseDoctors_IP put_IPCaseDoctors_IP = new put_IPCaseDoctors_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseDoctors_IP>(put_IPCaseDoctors_IP);
        //            break;

        //        case "cls_Test_put_IPCaseDsTemplate_BL_SC001":
        //            put_IPCaseDsTemplate_IP put_IPCaseDsTemplate_IP = new put_IPCaseDsTemplate_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseDsTemplate_IP>(put_IPCaseDsTemplate_IP);
        //            break;

        //        case "cls_Test_put_IPCaseDsTemplateData_BL_SC001":
        //            put_IPCaseDsTemplateData_IP put_IPCaseDsTemplateData_IP = new put_IPCaseDsTemplateData_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseDsTemplateData_IP>(put_IPCaseDsTemplateData_IP);
        //            break;

        //        case "cls_Test_put_IPCaseDsTitle_BL_SC001":
        //            put_IPCaseDsTitle_IP put_IPCaseDsTitle_IP = new put_IPCaseDsTitle_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseDsTitle_IP>(put_IPCaseDsTitle_IP);
        //            break;

        //        case "cls_Test_put_IPCaseEstimatedBillItems_BL_SC001":
        //            put_IPCaseEstimatedBillItems_IP put_IPCaseEstimatedBillItems_IP = new put_IPCaseEstimatedBillItems_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseEstimatedBillItems_IP>(put_IPCaseEstimatedBillItems_IP);
        //            break;

        //        case "cls_Test_put_IPCaseEstimatedBills_BL_SC001":
        //            put_IPCaseEstimatedBills_IP put_IPCaseEstimatedBills_IP = new put_IPCaseEstimatedBills_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseEstimatedBills_IP>(put_IPCaseEstimatedBills_IP);
        //            break;

        //        case "cls_Test_put_IPCaseEstItems_BL_SC001":
        //            put_IPCaseEstItems_IP put_IPCaseEstItems_IP = new put_IPCaseEstItems_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseEstItems_IP>(put_IPCaseEstItems_IP);
        //            break;

        //        case "cls_Test_put_IPCaseEvents_BL_SC001":
        //            put_IPCaseEvents_IP put_IPCaseEvents_IP = new put_IPCaseEvents_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseEvents_IP>(put_IPCaseEvents_IP);
        //            break;

        //        case "cls_Test_put_IPCaseICDCodes_BL_SC001":
        //            put_IPCaseICDCodes_IP put_IPCaseICDCodes_IP = new put_IPCaseICDCodes_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseICDCodes_IP>(put_IPCaseICDCodes_IP);
        //            break;

        //        case "cls_Test_put_IPCaseInsuranceDetail_BL_SC001":
        //            put_IPCaseInsuranceDetail_IP put_IPCaseInsuranceDetail_IP = new put_IPCaseInsuranceDetail_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseInsuranceDetail_IP>(put_IPCaseInsuranceDetail_IP);
        //            break;

        //        case "cls_Test_put_IPCaseInsurencePayment_BL_SC001":
        //            put_IPCaseInsurencePayment_IP put_IPCaseInsurencePayment_IP = new put_IPCaseInsurencePayment_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseInsurencePayment_IP>(put_IPCaseInsurencePayment_IP);
        //            break;

        //        case "cls_Test_put_IPCaseInsurenceReceived_BL_SC001":
        //            put_IPCaseInsurenceReceived_IP put_IPCaseInsurenceReceived_IP = new put_IPCaseInsurenceReceived_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseInsurenceReceived_IP>(put_IPCaseInsurenceReceived_IP);
        //            break;
        //        case "cls_Test_put_IPCaseList_BL_SC001":
        //            put_IPCaseList_IP put_IPCaseList_IP = new put_IPCaseList_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseList_IP>(put_IPCaseList_IP);
        //            break;

        //        case "cls_Test_put_IPCaseMedications_BL_SC001":
        //            put_IPCaseMedications_IP put_IPCaseMedications_IP = new put_IPCaseMedications_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseMedications_IP>(put_IPCaseMedications_IP);
        //            break;

        //        case "cls_Test_put_IPCaseNotes_BL_SC001":
        //            put_IPCaseNotes_IP put_IPCaseNotes_IP = new put_IPCaseNotes_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseNotes_IP>(put_IPCaseNotes_IP);
        //            break;

        //        case "cls_Test_put_IPCasePatientAddress_BL_SC001":
        //            put_IPCasePatientAddress_IP put_IPCasePatientAddress_IP = new put_IPCasePatientAddress_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCasePatientAddress_IP>(put_IPCasePatientAddress_IP);
        //            break;
        //        case "cls_Test_put_IPCaseSignandSymptoms_BL_SC001":
        //            put_IPCaseSignandSymptoms_IP put_IPCaseSignandSymptoms_IP = new put_IPCaseSignandSymptoms_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseSignandSymptoms_IP>(put_IPCaseSignandSymptoms_IP);
        //            break;
        //        case "cls_Test_put_IPCaseSurgeryNotes_BL_SC001":
        //            put_IPCaseSurgeryNotes_IP put_IPCaseSurgeryNotes_IP = new put_IPCaseSurgeryNotes_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseSurgeryNotes_IP>(put_IPCaseSurgeryNotes_IP);
        //            break;

        //        case "cls_Test_put_IPCaseVitalSigns_BL_SC001":
        //            put_IPCaseVitalSigns_IP put_IPCaseVitalSigns_IP = new put_IPCaseVitalSigns_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseVitalSigns_IP>(put_IPCaseVitalSigns_IP);
        //            break;
        //        case "cls_Test_put_IPCaseWardDetails_BL_SC001":
        //            put_IPCaseWardDetails_IP put_IPCaseWardDetails_IP = new put_IPCaseWardDetails_IP();
        //            strJson = JsonSerializer.Serialize<put_IPCaseWardDetails_IP>(put_IPCaseWardDetails_IP);
        //            break;







        //}
        //string Filename = "..\\..\\..\\JsonFile\\" + Classname + ".json";
        //File.WriteAllText(Filename, strJson);
    }
}
