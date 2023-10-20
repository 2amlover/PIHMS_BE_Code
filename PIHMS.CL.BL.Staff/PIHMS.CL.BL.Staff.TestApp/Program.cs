
using PIHMS.CL.API.IO.Staff;
using System.Text.Json;

namespace PIHMS.CL.BL.Staff.TestApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //String ConnectionString = "Server=127.0.0.1; database=db_ymsh_production; UID=dev1; password=dev@1234";
            //String ConnectionString = "Server=127.0.0.1; database=db_ymsh_production; UID=root; password=root";

            String ConnectionString = "Server=sql605.main-hosting.eu; database=u294392736_pihms_dev; UID=u294392736_dev; password=Pihms@123$";
            //String ConnectionString = "Server=sql605.main-hosting.eu; database=u294392736_pihms_dev01; UID=u294392736_dev01; password=Pihms@123$";

            //new get

            //cls_Test_get_StaffBankDetail_BL cls_Test_get_StaffBankDetail_BL = new cls_Test_get_StaffBankDetail_BL(ConnectionString);
            //Console.WriteLine(cls_Test_get_StaffBankDetail_BL.SC_001());
            //Console.WriteLine(cls_Test_get_StaffBankDetail_BL.SC_002());
            //Console.WriteLine(cls_Test_get_StaffBankDetail_BL.SC_003());


            //cls_Test_get_StaffDetail_BL cls_Test_get_StaffDetail_BL = new cls_Test_get_StaffDetail_BL(ConnectionString);
            //Console.WriteLine(cls_Test_get_StaffDetail_BL.SC_001());
            //Console.WriteLine(cls_Test_get_StaffDetail_BL.SC_002());
            //Console.WriteLine(cls_Test_get_StaffDetail_BL.SC_003());

            //cls_Test_get_StaffDocuments_BL cls_Test_get_StaffDocuments_BL = new cls_Test_get_StaffDocuments_BL(ConnectionString);
            //Console.WriteLine(cls_Test_get_StaffDocuments_BL.SC_001());
            //Console.WriteLine(cls_Test_get_StaffDocuments_BL.SC_002());
            //Console.WriteLine(cls_Test_get_StaffDocuments_BL.SC_003());

            //cls_Test_get_StaffEmployment_BL cls_Test_get_StaffEmployment_BL = new cls_Test_get_StaffEmployment_BL(ConnectionString);
            //Console.WriteLine(cls_Test_get_StaffEmployment_BL.SC_001());
            //Console.WriteLine(cls_Test_get_StaffEmployment_BL.SC_002());
            //Console.WriteLine(cls_Test_get_StaffEmployment_BL.SC_003());

            //cls_Test_get_StaffLeaves_BL cls_Test_get_StaffLeaves_BL = new cls_Test_get_StaffLeaves_BL(ConnectionString);
            //Console.WriteLine(cls_Test_get_StaffLeaves_BL.SC_001());
            //Console.WriteLine(cls_Test_get_StaffLeaves_BL.SC_002());
            //Console.WriteLine(cls_Test_get_StaffLeaves_BL.SC_003());

            //cls_Test_get_StaffList_BL cls_Test_get_StaffList_BL = new cls_Test_get_StaffList_BL(ConnectionString);
            //Console.WriteLine(cls_Test_get_StaffList_BL.SC_001());
            //Console.WriteLine(cls_Test_get_StaffList_BL.SC_002());
            //Console.WriteLine(cls_Test_get_StaffList_BL.SC_003());


            //cls_Test_get_StaffListMaster_BL cls_Test_get_StaffListMaster_BL = new cls_Test_get_StaffListMaster_BL(ConnectionString);
            //Console.WriteLine(cls_Test_get_StaffListMaster_BL.SC_001());
            //Console.WriteLine(cls_Test_get_StaffListMaster_BL.SC_002());
            //Console.WriteLine(cls_Test_get_StaffListMaster_BL.SC_003());



            //cls_Test_get_StaffPayroll_BL cls_Test_get_StaffPayroll_BL = new cls_Test_get_StaffPayroll_BL(ConnectionString);
            //Console.WriteLine(cls_Test_get_StaffPayroll_BL.SC_001());


            //cls_Test_get_StaffPaySlip_BL cls_Test_get_StaffPaySlip_BL = new cls_Test_get_StaffPaySlip_BL(ConnectionString);
            //Console.WriteLine(cls_Test_get_StaffPaySlip_BL.SC_001());
            //Console.WriteLine(cls_Test_get_StaffPaySlip_BL.SC_002());
            //Console.WriteLine(cls_Test_get_StaffPaySlip_BL.SC_003());

            //cls_Test_get_StaffAttendence_BL cls_Test_get_StaffAttendence_BL = new cls_Test_get_StaffAttendence_BL(ConnectionString);
            ////Console.WriteLine(cls_Test_get_StaffAttendence_BL.SC_001());
            //Console.WriteLine(cls_Test_get_StaffAttendence_BL.SC_002());
            //Console.WriteLine(cls_Test_get_StaffAttendence_BL.SC_003());
            //Console.WriteLine(cls_Test_get_StaffAttendence_BL.SC_004());

            //cls_Test_get_StaffAttendence_BL cls_Test_get_StaffAttendence_BL1 = new cls_Test_get_StaffAttendence_BL(ConnectionString);
            //Console.WriteLine(cls_Test_get_StaffAttendence_BL1.SC_003());

            //cls_Test_get_StaffEducation_BL cls_Test_get_StaffEducation_BL = new cls_Test_get_StaffEducation_BL(ConnectionString);
            //Console.WriteLine(cls_Test_get_StaffEducation_BL.SC_001());
            //Console.WriteLine(cls_Test_get_StaffEducation_BL.SC_002());
            //Console.WriteLine(cls_Test_get_StaffEducation_BL.SC_003());


            //.....................................old get down..............................................................................................cls_Test_get_Staff_BL test = new cls_Test_get_Staff_BL(ConnectionString);
            //Console.WriteLine(test.SC_001());
            //cls_Test_get_StaffAttendance_BL test1 = new cls_Test_get_StaffAttendance_BL(ConnectionString);
            //Console.WriteLine(test1.SC_001());
            //cls_Test_get_StaffBankDetails_BL test2 = new cls_Test_get_StaffBankDetails_BL(ConnectionString);
            //Console.WriteLine(test2.SC_001());
            //cls_Test_get_StaffEducation_BL test3 = new cls_Test_get_StaffEducation_BL(ConnectionString);
            //Console.WriteLine(test3.SC_001());
            //cls_Test_get_StaffEmployment_BL test4 = new cls_Test_get_StaffEmployment_BL(ConnectionString);
            //Console.WriteLine(test4.SC_001());
            //cls_Test_get_StaffLeaves_BL test5 = new cls_Test_get_StaffLeaves_BL(ConnectionString);
            //Console.WriteLine(test5.SC_001());
            //cls_Test_get_StaffLeaveSummary_BL test6 = new cls_Test_get_StaffLeaveSummary_BL(ConnectionString);
            //Console.WriteLine(test6.SC_001());
            //cls_Test_get_StaffLogin_BL test7 = new cls_Test_get_StaffLogin_BL(ConnectionString);
            //Console.WriteLine(test7.SC_001());
            //cls_Test_get_StaffMyDocuments_BL test8 = new cls_Test_get_StaffMyDocuments_BL(ConnectionString);
            //Console.WriteLine(test8.SC_001());
            //cls_Test_get_StaffPayroll_BL test9 = new cls_Test_get_StaffPayroll_BL(ConnectionString);
            //Console.WriteLine(test9.SC_001());
            //cls_Test_get_StaffPaySlips_BL test10 = new cls_Test_get_StaffPaySlips_BL(ConnectionString);
            //Console.WriteLine(test10.SC_001());
            //cls_Test_get_StaffReimbursements_BL test11 = new cls_Test_get_StaffReimbursements_BL(ConnectionString);
            //Console.WriteLine(test11.SC_001());
            //cls_Test_get_StaffRole_BL test12 = new cls_Test_get_StaffRole_BL(ConnectionString);
            //Console.WriteLine(test12.SC_001());
            //cls_Test_get_StaffRoleAppFeature_BL test13 = new cls_Test_get_StaffRoleAppFeature_BL(ConnectionString);
            //Console.WriteLine(test13.SC_001());
            //cls_Test_get_StaffRoleModule_BL test14 = new cls_Test_get_StaffRoleModule_BL(ConnectionString);
            //Console.WriteLine(test14.SC_001());
            //cls_Test_get_StaffSalaryDeduction_BL test15 = new cls_Test_get_StaffSalaryDeduction_BL(ConnectionString);
            //Console.WriteLine(test15.SC_001());
            //cls_Test_get_StaffSalaryEarnings_BL test16 = new cls_Test_get_StaffSalaryEarnings_BL(ConnectionString);
            //Console.WriteLine(test16.SC_001());
            //cls_Test_get_StaffWorkItems_BL test17 = new cls_Test_get_StaffWorkItems_BL(ConnectionString);
            //Console.WriteLine(test17.SC_001());
            //cls_Test_get_StaffYogDetails_BL test18 = new cls_Test_get_StaffYogDetails_BL(ConnectionString);
            //Console.WriteLine(test18.SC_001());
            //cls_Test_get_StaffSalarySummary_BL test19 = new cls_Test_get_StaffSalarySummary_BL(ConnectionString);
            //Console.WriteLine(test19.SC_001());
            //cls_Test_get_StaffAttendanceTrn_BL test20 = new cls_Test_get_StaffAttendanceTrn_BL(ConnectionString);
            //Console.WriteLine(test20.SC_001());
            //cls_Test_get_StaffEmploymentTrn_BL test21 = new cls_Test_get_StaffEmploymentTrn_BL(ConnectionString);
            //Console.WriteLine(test21.SC_001());
            //cls_test_get_StaffLeavesTrn_BL test22 = new cls_test_get_StaffLeavesTrn_BL(ConnectionString);
            //Console.WriteLine(test22.SC_001());
            //cls_Test_get_StaffSalaryEarningsTrn_BL test23 = new cls_Test_get_StaffSalaryEarningsTrn_BL(ConnectionString);
            //Console.WriteLine(test23.SC_001());

            //PUT





            //cls_Test_put_StaffList_BL test24 = new cls_Test_put_StaffList_BL(ConnectionString);
            //test24.SC_001(@"C:\Users\User\Desktop\PIHMS.Module.Code-master\PIHMS.Module.Code-master\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\cls_Test_put_Staff_BL_SC001.json");
            //test24.SC_002(@"C:\Users\User\Desktop\PIHMS.Module.Code-master\PIHMS.Module.Code-master\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\cls_Test_put_Staff_BL_SC002.json");

            //cls_Test_put_StaffAttendance_BL test25 = new cls_Test_put_StaffAttendance_BL(ConnectionString);
            //test25.SC_001(@"C:\Users\User\Desktop\PIHMS.Module.Code-master\PIHMS.Module.Code-master\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\cls_Test_put_StaffAttendance_BL_SC001.json");
            //test25.SC_002(@"C:\Users\User\Desktop\PIHMS.Module.Code-master\PIHMS.Module.Code-master\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\cls_Test_put_StaffAttendance_BL_SC002.json");

            //cls_Test_put_StaffBankDetails_BL test26 = new cls_Test_put_StaffBankDetails_BL(ConnectionString);
            //test26.SC_001(@"C:\Users\User\Desktop\PIHMS.Module.Code-master\PIHMS.Module.Code-master\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\cls_Test_put_StaffBankDetails_BL_SC001.json");
            //test26.SC_002(@"C:\Users\User\Desktop\PIHMS.Module.Code-master\PIHMS.Module.Code-master\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\cls_Test_put_StaffBankDetails_BL_SC002.json");

            cls_Test_put_StaffEducation_BL test27 = new cls_Test_put_StaffEducation_BL(ConnectionString);
            //test27.SC_001(@"C:\Users\User\Desktop\PIHMS.Module.Code-master\PIHMS.Module.Code-master\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\cls_Test_put_StaffEducation_BL_SC001.json");
            test27.SC_002(@"C:\Users\User\Desktop\PIHMS.Module.Code-master\PIHMS.Module.Code-master\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\cls_Test_put_StaffEducation_BL_SC002.json");

            //cls_Test_put_StaffEmployment_BL test28 = new cls_Test_put_StaffEmployment_BL(ConnectionString);
            //test28.SC_001(@"C:\Users\User\Desktop\PIHMS.Module.Code-master\PIHMS.Module.Code-master\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\cls_Test_put_StaffEmployment_BL_SC001.json");
            //test28.SC_002(@"C:\Users\User\Desktop\PIHMS.Module.Code-master\PIHMS.Module.Code-master\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\cls_Test_put_StaffEmployment_BL_SC002.json");

            //cls_Test_put_StaffLeaves_BL test29 = new cls_Test_put_StaffLeaves_BL(ConnectionString);
            //test29.SC_001(@"C:\Users\User\Desktop\PIHMS.Module.Code-master\PIHMS.Module.Code-master\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\cls_Test_put_StaffLeaves_BL_SC001.json");
            //test29.SC_002(@"C:\Users\User\Desktop\PIHMS.Module.Code-master\PIHMS.Module.Code-master\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\cls_Test_put_StaffLeaves_BL_SC002.json");

            //cls_Test_put_StaffMyDocuments_BL test32 = new cls_Test_put_StaffMyDocuments_BL(ConnectionString);
            //test32.SC_001(@"C:\Users\User\Desktop\PIHMS.Module.Code-master\PIHMS.Module.Code-master\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\cls_Test_put_StaffMyDocuments_BL_SC001.json");
            //test32.SC_002(@"C:\Users\User\Desktop\PIHMS.Module.Code-master\PIHMS.Module.Code-master\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\cls_Test_put_StaffMyDocuments_BL_SC002.json");

            //cls_Test_put_StaffPayroll_BL test33 = new cls_Test_put_StaffPayroll_BL(ConnectionString);
            //test33.SC_001(@"C:\Users\User\Desktop\PIHMS.Module.Code-master\PIHMS.Module.Code-master\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\cls_Test_put_StaffPayroll_BL_SC001.json");
            //test33.SC_002(@"C:\Users\User\Desktop\PIHMS.Module.Code-master\PIHMS.Module.Code-master\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\cls_Test_put_StaffPayroll_BL_SC002.json");

            //cls_Test_put_StaffPaySlips_BL test34 = new cls_Test_put_StaffPaySlips_BL(ConnectionString);
            //test34.SC_001(@"C:\Users\User\Desktop\PIHMS.Module.Code-master\PIHMS.Module.Code-master\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\cls_Test_put_StaffPaySlips_BL_SC001.json");
            //test34.SC_002(@"C:\Users\User\Desktop\PIHMS.Module.Code-master\PIHMS.Module.Code-master\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\cls_Test_put_StaffPaySlips_BL_SC002.json");






            //cls_Test_put_StaffSalaryEarningsTrn_BL test38 = new cls_Test_put_StaffSalaryEarningsTrn_BL(ConnectionString);
            //test38.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffSalaryEarningsTrn_BL_SC001.json");
            //test38.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffSalaryEarningsTrn_BL_SC002.json");

            //cls_Test_put_StaffLeaveSummary_BL test30 = new cls_Test_put_StaffLeaveSummary_BL(ConnectionString);
            //test30.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffLeaveSummary_BL_SC001.json");
            //test30.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffLeaveSummary_BL_SC002.json");

            //cls_Test_put_StaffLogin_BL test31 = new cls_Test_put_StaffLogin_BL(ConnectionString);
            //test31.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffLogin_BL_SC001.json");
            //test31.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffLogin_BL_SC002.json");


            //cls_Test_put_StaffReimbursements_BL test35 = new cls_Test_put_StaffReimbursements_BL(ConnectionString);
            //test35.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffReimbursements_BL_SC001.json");
            //test35.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffReimbursements_BL_SC002.json");

            //cls_Test_put_StaffRole_BL test36 = new cls_Test_put_StaffRole_BL(ConnectionString);
            //test36.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffRole_BL_SC001.json");
            //test36.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffRole_BL_SC002.json");

            //cls_Test_put_StaffRoleAppFeature_BL test37 = new cls_Test_put_StaffRoleAppFeature_BL(ConnectionString);
            //test37.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffRoleAppFeature_BL_SC001.json");
            //test37.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffRoleAppFeature_BL_SC002.json");


            //cls_Test_put_StaffRoleModule_BL test39 = new cls_Test_put_StaffRoleModule_BL(ConnectionString);
            //test39.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffRole_BL_SC001.json");
            //test39.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffRole_BL_SC002.json");

            //cls_Test_put_StaffSalaryDeduction_BL test40 = new cls_Test_put_StaffSalaryDeduction_BL(ConnectionString);
            //test40.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffSalaryDeduction_BL_SC001.json");
            //test40.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffSalaryDeduction_BL_SC002.json");

            //cls_Test_put_StaffSalaryEarnings_BL test41 = new cls_Test_put_StaffSalaryEarnings_BL(ConnectionString);
            //test41.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffSalaryEarnings_BL_SC001.json");
            //test41.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffSalaryEarnings_BL_SC002.json");

            //cls_Test_put_StaffWorkItems_BL test42 = new cls_Test_put_StaffWorkItems_BL(ConnectionString);
            //test42.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffWorkItems_BL_SC001.json");
            //test42.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffWorkItems_BL_SC002.json");

            //cls_Test_put_StaffYogDetails_BL test43 = new cls_Test_put_StaffYogDetails_BL(ConnectionString);
            //test43.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffYogDetails_BL_SC001.json");
            //test43.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffYogDetails_BL_SC002.json");

            //cls_Test_put_StaffSalarySummary_BL test44 = new cls_Test_put_StaffSalarySummary_BL(ConnectionString);
            //test44.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffSalarySummary_BL_SC001.json");
            //test44.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffSalarySummary_BL_SC002.json");

            //cls_Test_put_StaffAttendanceTrn_BL test45 = new cls_Test_put_StaffAttendanceTrn_BL(ConnectionString);
            //test45.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffAttendanceTrn_BL_SC001.json");
            //test45.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffAttendanceTrn_BL_SC002.json");

            //cls_Test_put_StaffEmploymentTrn_BL test46 = new cls_Test_put_StaffEmploymentTrn_BL(ConnectionString);
            //test46.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffEmploymentTrn_BL_SC001.json");
            //test46.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_Test_put_StaffEmploymentTrn_BL_SC002.json");

            //cls_test_put_StaffLeavesTrn_BL test47 = new cls_test_put_StaffLeavesTrn_BL(ConnectionString);
            //test47.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_test_put_StaffLeavesTrn_BL_SC001.json");
            //test47.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Staff\PIHMS.CL.BL.Staff.TestApp\JsonFile\\cls_test_put_StaffLeavesTrn_BL_SC002.json");


        }

    }
}

