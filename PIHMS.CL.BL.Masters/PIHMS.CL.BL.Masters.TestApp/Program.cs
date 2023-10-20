using PIHMS.CL.API.IO.Masters;
//using PIHMS.ConsoleApp.API.BL.Masters.TestApp;
using System.Text.Json;


namespace PIHMS.CL.BL.Masters.TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //String ConnectionString = "Server=127.0.0.1; database=db_ymsh_production; UID=dev; password=dev@1234";

            String ConnectionString = "Server=127.0.0.1; database=db_ymsh_production; UID=root; password=root";



            //get
            cls_Test_get_MasAccount_BL test1 = new cls_Test_get_MasAccount_BL(ConnectionString);
            Console.WriteLine(test1.SC_001());

            cls_Test_get_MasAccountRegistration_BL test2 = new cls_Test_get_MasAccountRegistration_BL(ConnectionString);
            Console.WriteLine(test2.SC_001());

            cls_Test_get_MasApplicationFeature_BL test3 = new cls_Test_get_MasApplicationFeature_BL(ConnectionString);
            Console.WriteLine(test3.SC_001());

            cls_Test_get_MasBranch_BL test4 = new cls_Test_get_MasBranch_BL(ConnectionString);
            Console.WriteLine(test4.SC_001());

            cls_Test_get_MasCalculationEventstatus_BL test5 = new cls_Test_get_MasCalculationEventstatus_BL(ConnectionString);
            Console.WriteLine(test5.SC_001());

            cls_Test_get_MasCalculationEventtype_BL test6 = new cls_Test_get_MasCalculationEventtype_BL(ConnectionString);
            Console.WriteLine(test6.SC_001());

            cls_Test_get_MasConfiguration_BL test7 = new cls_Test_get_MasConfiguration_BL(ConnectionString);
            Console.WriteLine(test7.SC_001());

            cls_Test_get_MasCoreMedications_BL test8 = new cls_Test_get_MasCoreMedications_BL(ConnectionString);
            Console.WriteLine(test8.SC_001());

            cls_Test_get_MasCoreMedications_BL test9 = new cls_Test_get_MasCoreMedications_BL(ConnectionString);
            Console.WriteLine(test9.SC_001());

            cls_Test_get_MasFloor_BL test10 = new cls_Test_get_MasFloor_BL(ConnectionString);
            Console.WriteLine(test10.SC_001());

            cls_Test_get_MasFloor_BL test11 = new cls_Test_get_MasFloor_BL(ConnectionString);
            Console.WriteLine(test11.SC_001());

            cls_Test_get_MasHospitalbuilding_BL test12 = new cls_Test_get_MasHospitalbuilding_BL(ConnectionString);
            Console.WriteLine(test12.SC_001());

            cls_Test_get_MasHousekeepingTasks_BL test13 = new cls_Test_get_MasHousekeepingTasks_BL(ConnectionString);
            Console.WriteLine(test13.SC_001());

            cls_Test_get_MasHousekeepingTasks_BL test14 = new cls_Test_get_MasHousekeepingTasks_BL(ConnectionString);
            Console.WriteLine(test14.SC_001());

            cls_Test_get_MasHousekeepingTasks_BL test15 = new cls_Test_get_MasHousekeepingTasks_BL(ConnectionString);
            Console.WriteLine(test15.SC_001());

            cls_Test_get_MasHousekeepingTasks_BL test16 = new cls_Test_get_MasHousekeepingTasks_BL(ConnectionString);
            Console.WriteLine(test16.SC_001());

            cls_Test_get_MasHousekeepingTasks_BL test17 = new cls_Test_get_MasHousekeepingTasks_BL(ConnectionString);
            Console.WriteLine(test17.SC_001());

            cls_Test_get_MasHousekeepingTasks_BL test18 = new cls_Test_get_MasHousekeepingTasks_BL(ConnectionString);
            Console.WriteLine(test18.SC_001());

            cls_Test_get_MasMiscInsuranceproviders_BL test19 = new cls_Test_get_MasMiscInsuranceproviders_BL(ConnectionString);
            Console.WriteLine(test19.SC_001());

            cls_Test_get_MasMiscOrganizations_BL test20 = new cls_Test_get_MasMiscOrganizations_BL(ConnectionString);
            Console.WriteLine(test20.SC_001());

            cls_Test_get_MasMiscPostalcodes_BL test21 = new cls_Test_get_MasMiscPostalcodes_BL(ConnectionString);
            Console.WriteLine(test21.SC_001());



            cls_Test_get_MasMiscStates_BL test22 = new cls_Test_get_MasMiscStates_BL(ConnectionString);
            Console.WriteLine(test22.SC_001());



            cls_Test_get_MasModule_BL test23 = new cls_Test_get_MasModule_BL(ConnectionString);
            Console.WriteLine(test23.SC_001());



            cls_Test_get_MasModuleLicence_BL test24 = new cls_Test_get_MasModuleLicence_BL(ConnectionString);
            Console.WriteLine(test24.SC_001());



            cls_Test_get_MasPharmacyItem_BL test25 = new cls_Test_get_MasPharmacyItem_BL(ConnectionString);
            Console.WriteLine(test25.SC_001());



            cls_Test_get_MasWard_BL test26 = new cls_Test_get_MasWard_BL(ConnectionString);
            Console.WriteLine(test26.SC_001());



            cls_Test_get_MasWardBed_BL test27 = new cls_Test_get_MasWardBed_BL(ConnectionString);
            Console.WriteLine(test27.SC_001());



            cls_Test_get_MasWardType_BL test28 = new cls_Test_get_MasWardType_BL(ConnectionString);
            Console.WriteLine(test28.SC_001());


            cls_Test_get_MasInsurance_BL test29 = new cls_Test_get_MasInsurance_BL(ConnectionString);
            Console.WriteLine(test29.SC_001());


            cls_Test_get_MasPayitems_BL test30 = new cls_Test_get_MasPayitems_BL(ConnectionString);
            Console.WriteLine(test30.SC_001());


            cls_Test_get_MasScan_BL test31 = new cls_Test_get_MasScan_BL(ConnectionString);
            Console.WriteLine(test31.SC_001());


            cls_Test_get_MasIpDoctorPrice_BL test32 = new cls_Test_get_MasIpDoctorPrice_BL(ConnectionString);
            Console.WriteLine(test32.SC_001());


            cls_Test_get_MasScanTemplate_BL test33 = new cls_Test_get_MasScanTemplate_BL(ConnectionString);
            Console.WriteLine(test33.SC_001());


            cls_Test_get_MasScanningitem_BL test34 = new cls_Test_get_MasScanningitem_BL(ConnectionString);
            Console.WriteLine(test34.SC_001());


            cls_Test_get_MasSurgery_BL test35 = new cls_Test_get_MasSurgery_BL(ConnectionString);
            Console.WriteLine(test35.SC_001());


            //put

            cls_Test_put_MasAccount_BL cls_Test_put_MasAccount_BL = new cls_Test_put_MasAccount_BL(ConnectionString);
            cls_Test_put_MasAccount_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasAccount_BL_SC001.json");

            cls_Test_put_MasAccount_BL cls_Test_put_MasAccount_BL1 = new cls_Test_put_MasAccount_BL(ConnectionString);
            cls_Test_put_MasAccount_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasAccount_BL_SC002.json");


            cls_Test_put_MasAccountRegistration_BL cls_Test_put_MasAccountRegistration_BL = new cls_Test_put_MasAccountRegistration_BL(ConnectionString);
            cls_Test_put_MasAccountRegistration_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasAccountRegistration_BL_SC001.json");

            cls_Test_put_MasAccountRegistration_BL cls_Test_put_MasAccountRegistration_BL1 = new cls_Test_put_MasAccountRegistration_BL(ConnectionString);
            cls_Test_put_MasAccountRegistration_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasAccountRegistration_BL_SC002.json");


            cls_Test_put_MasApplicationFeature_BL cls_Test_put_MasApplicationFeature_BL = new cls_Test_put_MasApplicationFeature_BL(ConnectionString);
            cls_Test_put_MasApplicationFeature_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasApplicationFeature_BL_SC001.json");

            cls_Test_put_MasApplicationFeature_BL cls_Test_put_MasApplicationFeature_BL1 = new cls_Test_put_MasApplicationFeature_BL(ConnectionString);
            cls_Test_put_MasApplicationFeature_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasApplicationFeature_BL_SC002.json");


            cls_Test_put_MasBranch_BL cls_Test_put_MasBranch_BL = new cls_Test_put_MasBranch_BL(ConnectionString);
            cls_Test_put_MasBranch_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasBranch_BL_SC001.json");

            cls_Test_put_MasBranch_BL cls_Test_put_MasBranch_BL1 = new cls_Test_put_MasBranch_BL(ConnectionString);
            cls_Test_put_MasBranch_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasBranch_BL_SC002.json");


            cls_Test_put_MasCalculationEventstatus_BL cls_Test_put_MasCalculationEventstatus_BL = new cls_Test_put_MasCalculationEventstatus_BL(ConnectionString);
            cls_Test_put_MasCalculationEventstatus_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasCalculationEventstatus_BL_SC001.json");

            cls_Test_put_MasCalculationEventstatus_BL cls_Test_put_MasCalculationEventstatus_BL1 = new cls_Test_put_MasCalculationEventstatus_BL(ConnectionString);
            cls_Test_put_MasCalculationEventstatus_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasCalculationEventstatus_BL_SC002.json");


            cls_Test_put_MasCalculationEventtype_BL cls_Test_put_MasCalculationEventtype_BL = new cls_Test_put_MasCalculationEventtype_BL(ConnectionString);
            cls_Test_put_MasCalculationEventtype_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasCalculationEventtype_BL_SC001.json");

            cls_Test_put_MasCalculationEventtype_BL cls_Test_put_MasCalculationEventtype_BL1 = new cls_Test_put_MasCalculationEventtype_BL(ConnectionString);
            cls_Test_put_MasCalculationEventtype_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasCalculationEventtype_BL_SC002.json");


            cls_Test_put_MasConfiguration_BL cls_Test_put_MasConfiguration_BL = new cls_Test_put_MasConfiguration_BL(ConnectionString);
            cls_Test_put_MasConfiguration_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasConfiguration_BL_SC001.json");

            cls_Test_put_MasConfiguration_BL cls_Test_put_MasConfiguration_BL1 = new cls_Test_put_MasConfiguration_BL(ConnectionString);
            cls_Test_put_MasConfiguration_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasConfiguration_BL_SC002.json");


            cls_Test_put_MasCoreMedications_BL cls_Test_put_MasCoreMedications_BL = new cls_Test_put_MasCoreMedications_BL(ConnectionString);
            cls_Test_put_MasCoreMedications_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasCoreMedications_BL_SC001.json");

            cls_Test_put_MasCoreMedications_BL cls_Test_put_MasCoreMedications_BL1 = new cls_Test_put_MasCoreMedications_BL(ConnectionString);
            cls_Test_put_MasCoreMedications_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasCoreMedications_BL_SC002.json");


            cls_Test_put_MasDepartment_BL cls_Test_put_MasDepartment_BL = new cls_Test_put_MasDepartment_BL(ConnectionString);
            cls_Test_put_MasDepartment_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasDepartment_BL_SC001.json");

            cls_Test_put_MasDepartment_BL cls_Test_put_MasDepartment_BL1 = new cls_Test_put_MasDepartment_BL(ConnectionString);
            cls_Test_put_MasDepartment_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasDepartment_BL_SC002.json");


            cls_Test_put_MasFloor_BL cls_Test_put_MasFloor_BL = new cls_Test_put_MasFloor_BL(ConnectionString);
            cls_Test_put_MasFloor_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasFloor_BL_SC001.json");

            cls_Test_put_MasFloor_BL cls_Test_put_MasFloor_BL1 = new cls_Test_put_MasFloor_BL(ConnectionString);
            cls_Test_put_MasFloor_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasFloor_BL_SC002.json");


            cls_Test_put_MasHolidays_BL cls_Test_put_MasHolidays_BL = new cls_Test_put_MasHolidays_BL(ConnectionString);
            cls_Test_put_MasHolidays_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasHolidays_BL_SC001.json");

            cls_Test_put_MasHolidays_BL cls_Test_put_MasHolidays_BL1 = new cls_Test_put_MasHolidays_BL(ConnectionString);
            cls_Test_put_MasHolidays_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasHolidays_BL_SC002.json");


            cls_Test_put_MasHospitalbuilding_BL cls_Test_put_MasHospitalbuilding_BL = new cls_Test_put_MasHospitalbuilding_BL(ConnectionString);
            cls_Test_put_MasHospitalbuilding_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasHospitalbuilding_BL_SC001.json");

            cls_Test_put_MasHospitalbuilding_BL cls_Test_put_MasHospitalbuilding_BL1 = new cls_Test_put_MasHospitalbuilding_BL(ConnectionString);
            cls_Test_put_MasHospitalbuilding_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasHospitalbuilding_BL_SC002.json");


            cls_Test_put_MasHousekeepingTasks_BL cls_Test_put_MasHousekeepingTasks_BL = new cls_Test_put_MasHousekeepingTasks_BL(ConnectionString);
            cls_Test_put_MasHousekeepingTasks_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasHousekeepingTasks_BL_SC001.json");

            cls_Test_put_MasHousekeepingTasks_BL cls_Test_put_MasHousekeepingTasks_BL1 = new cls_Test_put_MasHousekeepingTasks_BL(ConnectionString);
            cls_Test_put_MasHousekeepingTasks_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasHousekeepingTasks_BL_SC002.json");


            cls_Test_put_MasMessagingEmailConfiguration_BL cls_Test_put_MasMessagingEmailConfiguration_BL = new cls_Test_put_MasMessagingEmailConfiguration_BL(ConnectionString);
            cls_Test_put_MasMessagingEmailConfiguration_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasMessagingEmailConfiguration_BL_SC001.json");

            cls_Test_put_MasMessagingEmailConfiguration_BL cls_Test_put_MasMessagingEmailConfiguration_BL1 = new cls_Test_put_MasMessagingEmailConfiguration_BL(ConnectionString);
            cls_Test_put_MasMessagingEmailConfiguration_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasMessagingEmailConfiguration_BL_SC002.json");


            cls_Test_put_MasMiscBanks_BL cls_Test_put_MasMiscBanks_BL = new cls_Test_put_MasMiscBanks_BL(ConnectionString);
            cls_Test_put_MasMiscBanks_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasMiscBanks_BL_SC001.json");

            cls_Test_put_MasMiscBanks_BL cls_Test_put_MasMiscBanks_BL1 = new cls_Test_put_MasMiscBanks_BL(ConnectionString);
            cls_Test_put_MasMiscBanks_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasMiscBanks_BL_SC002.json");


            cls_Test_put_MasMiscCities_BL cls_Test_put_MasMiscCities_BL = new cls_Test_put_MasMiscCities_BL(ConnectionString);
            cls_Test_put_MasMiscCities_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasMiscCities_BL_SC001.json");

            cls_Test_put_MasMiscCities_BL cls_Test_put_MasMiscCities_BL1 = new cls_Test_put_MasMiscCities_BL(ConnectionString);
            cls_Test_put_MasMiscCities_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasMiscCities_BL_SC002.json");


            cls_Test_put_MasMiscCountries_BL cls_Test_put_MasMiscCountries_BL = new cls_Test_put_MasMiscCountries_BL(ConnectionString);
            cls_Test_put_MasMiscCountries_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasMiscCountries_BL_SC001.json");

            cls_Test_put_MasMiscCountries_BL cls_Test_put_MasMiscCountries_BL1 = new cls_Test_put_MasMiscCountries_BL(ConnectionString);
            cls_Test_put_MasMiscCountries_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasMiscCountries_BL_SC002.json");


            cls_Test_put_MasMiscDistricts_BL cls_Test_put_MasMiscDistricts_BL = new cls_Test_put_MasMiscDistricts_BL(ConnectionString);
            cls_Test_put_MasMiscDistricts_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasMiscDistricts_BL_SC001.json");

            cls_Test_put_MasMiscDistricts_BL cls_Test_put_MasMiscDistricts_BL1 = new cls_Test_put_MasMiscDistricts_BL(ConnectionString);
            cls_Test_put_MasMiscDistricts_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasMiscDistricts_BL_SC002.json");


            cls_Test_put_MasMiscInsuranceproviders_BL cls_Test_put_MasMiscInsuranceproviders_BL = new cls_Test_put_MasMiscInsuranceproviders_BL(ConnectionString);
            cls_Test_put_MasMiscInsuranceproviders_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasMiscInsuranceproviders_BL_SC001.json");

            cls_Test_put_MasMiscInsuranceproviders_BL cls_Test_put_MasMiscInsuranceproviders_BL1 = new cls_Test_put_MasMiscInsuranceproviders_BL(ConnectionString);
            cls_Test_put_MasMiscInsuranceproviders_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasMiscInsuranceproviders_BL_SC002.json");


            cls_Test_put_MasMiscOrganizations_BL cls_Test_put_MasMiscOrganizations_BL = new cls_Test_put_MasMiscOrganizations_BL(ConnectionString);
            cls_Test_put_MasMiscOrganizations_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasMiscOrganizations_BL_SC001.json");

            cls_Test_put_MasMiscOrganizations_BL cls_Test_put_MasMiscOrganizations_BL1 = new cls_Test_put_MasMiscOrganizations_BL(ConnectionString);
            cls_Test_put_MasMiscOrganizations_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasMiscOrganizations_BL_SC002.json");


            cls_Test_put_MasMiscPostalcodes_BL cls_Test_put_MasMiscPostalcodes_BL = new cls_Test_put_MasMiscPostalcodes_BL(ConnectionString);
            cls_Test_put_MasMiscPostalcodes_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasMiscPostalcodes_BL_SC001.json");

            cls_Test_put_MasMiscPostalcodes_BL cls_Test_put_MasMiscPostalcodes_BL1 = new cls_Test_put_MasMiscPostalcodes_BL(ConnectionString);
            cls_Test_put_MasMiscPostalcodes_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasMiscPostalcodes_BL_SC002.json");


            cls_Test_put_MasMiscStates_BL cls_Test_put_MasMiscStates_BL = new cls_Test_put_MasMiscStates_BL(ConnectionString);
            cls_Test_put_MasMiscStates_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasMiscStates_BL_SC001.json");

            cls_Test_put_MasMiscStates_BL cls_Test_put_MasMiscStates_BL1 = new cls_Test_put_MasMiscStates_BL(ConnectionString);
            cls_Test_put_MasMiscStates_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasMiscStates_BL_SC002.json");


            cls_Test_put_MasModule_BL cls_Test_put_MasModule_BL = new cls_Test_put_MasModule_BL(ConnectionString);
            cls_Test_put_MasModule_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasModule_BL_SC001.json");

            cls_Test_put_MasModule_BL cls_Test_put_MasModule_BL1 = new cls_Test_put_MasModule_BL(ConnectionString);
            cls_Test_put_MasModule_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasModule_BL_SC002.json");


            cls_Test_put_MasModuleLicence_BL cls_Test_put_MasModuleLicence_BL = new cls_Test_put_MasModuleLicence_BL(ConnectionString);
            cls_Test_put_MasModuleLicence_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasModuleLicence_BL_SC001.json");

            cls_Test_put_MasModuleLicence_BL cls_Test_put_MasModuleLicence_BL1 = new cls_Test_put_MasModuleLicence_BL(ConnectionString);
            cls_Test_put_MasModuleLicence_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasModuleLicence_BL_SC002.json");


            cls_Test_put_MasPharmacyItem_BL cls_Test_put_MasPharmacyItem_BL = new cls_Test_put_MasPharmacyItem_BL(ConnectionString);
            cls_Test_put_MasPharmacyItem_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasPharmacyItem_BL_SC001.json");

            cls_Test_put_MasPharmacyItem_BL cls_Test_put_MasPharmacyItem_BL1 = new cls_Test_put_MasPharmacyItem_BL(ConnectionString);
            cls_Test_put_MasPharmacyItem_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasPharmacyItem_BL_SC002.json");


            cls_Test_put_MasWard_BL cls_Test_put_MasWard_BL = new cls_Test_put_MasWard_BL(ConnectionString);
            cls_Test_put_MasWard_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasWard_BL_SC001.json");

            cls_Test_put_MasWard_BL cls_Test_put_MasWard_BL1 = new cls_Test_put_MasWard_BL(ConnectionString);
            cls_Test_put_MasWard_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasWard_BL_SC002.json");


            cls_Test_put_MasWardBed_BL cls_Test_put_MasWardBed_BL = new cls_Test_put_MasWardBed_BL(ConnectionString);
            cls_Test_put_MasWardBed_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasWardBed_BL_SC001.json");

            cls_Test_put_MasWardBed_BL cls_Test_put_MasWardBed_BL1 = new cls_Test_put_MasWardBed_BL(ConnectionString);
            cls_Test_put_MasWardBed_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasWardBed_BL_SC002.json");


            cls_Test_put_MasWardType_BL cls_Test_put_MasWardType_BL = new cls_Test_put_MasWardType_BL(ConnectionString);
            cls_Test_put_MasWardType_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasWardType_BL_SC001.json");

            cls_Test_put_MasWardType_BL cls_Test_put_MasWardType_BL1 = new cls_Test_put_MasWardType_BL(ConnectionString);
            cls_Test_put_MasWardType_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasWardType_BL_SC002.json");


            cls_Test_put_MasInsurance_BL cls_Test_put_MasInsurance_BL = new cls_Test_put_MasInsurance_BL(ConnectionString);
            cls_Test_put_MasInsurance_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasInsurance_BL_SC001.json");

            cls_Test_put_MasInsurance_BL cls_Test_put_MasInsurance_BL1 = new cls_Test_put_MasInsurance_BL(ConnectionString);
            cls_Test_put_MasInsurance_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasInsurance_BL_SC002.json");


            cls_Test_put_MasPayitems_BL cls_Test_put_MasPayitems_BL = new cls_Test_put_MasPayitems_BL(ConnectionString);
            cls_Test_put_MasPayitems_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasPayitems_BL_SC001.json");

            cls_Test_put_MasPayitems_BL cls_Test_put_MasPayitems_BL1 = new cls_Test_put_MasPayitems_BL(ConnectionString);
            cls_Test_put_MasPayitems_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasPayitems_BL_SC002.json");


            cls_Test_put_MasScan_BL cls_Test_put_MasScan_BL = new cls_Test_put_MasScan_BL(ConnectionString);
            cls_Test_put_MasScan_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasScan_BL_SC001.json");

            cls_Test_put_MasScan_BL cls_Test_put_MasScan_BL1 = new cls_Test_put_MasScan_BL(ConnectionString);
            cls_Test_put_MasScan_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasScan_BL_SC002.json");


            cls_Test_put_MasIpDoctorPrice_BL cls_Test_put_MasIpDoctorPrice_BL = new cls_Test_put_MasIpDoctorPrice_BL(ConnectionString);
            cls_Test_put_MasIpDoctorPrice_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasIpDoctorPrice_BL_SC001.json");

            cls_Test_put_MasIpDoctorPrice_BL cls_Test_put_MasIpDoctorPrice_BL1 = new cls_Test_put_MasIpDoctorPrice_BL(ConnectionString);
            cls_Test_put_MasIpDoctorPrice_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasIpDoctorPrice_BL_SC002.json");


            cls_Test_put_MasScanTemplate_BL cls_Test_put_MasScanTemplate_BL = new cls_Test_put_MasScanTemplate_BL(ConnectionString);
            cls_Test_put_MasScanTemplate_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasScanTemplate_BL_SC001.json");

            cls_Test_put_MasScanTemplate_BL cls_Test_put_MasScanTemplate_BL1 = new cls_Test_put_MasScanTemplate_BL(ConnectionString);
            cls_Test_put_MasScanTemplate_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasScanTemplate_BL_SC002.json");


            cls_Test_put_MasScanningitem_BL cls_Test_put_MasScanningitem_BL = new cls_Test_put_MasScanningitem_BL(ConnectionString);
            cls_Test_put_MasScanningitem_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasScanningitem_BL_SC001.json");

            cls_Test_put_MasScanningitem_BL cls_Test_put_MasScanningitem_BL1 = new cls_Test_put_MasScanningitem_BL(ConnectionString);
            cls_Test_put_MasScanningitem_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasScanningitem_BL_SC002.json");


            cls_Test_put_MasSurgery_BL cls_Test_put_MasSurgery_BL = new cls_Test_put_MasSurgery_BL(ConnectionString);
            cls_Test_put_MasSurgery_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasSurgery_BL_SC001.json");

            cls_Test_put_MasSurgery_BL cls_Test_put_MasSurgery_BL1 = new cls_Test_put_MasSurgery_BL(ConnectionString);
            cls_Test_put_MasSurgery_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Masters\\PIHMS.CL.BL.Masters.TestApp\\DATAFILE\\cls_Test_put_MasSurgery_BL_SC002.json");

        }
    }

}
