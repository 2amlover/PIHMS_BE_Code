using PIHMS.CL.API.IO.Patient;
using System.Text.Json;

namespace PIHMS.CL.BL.Patient.TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            String ConnectionString = "Server=127.0.0.1; database=db_ymsh_production; UID=root; password=root";

            //GET
           // cls_Test_get_PatientCompleteDetails_BL cls_Test_get_PatientCompleteDetails_BL = new cls_Test_get_PatientCompleteDetails_BL(ConnectionString);
            //Console.WriteLine(cls_Test_get_PatientCompleteDetails_BL.SC_001());

            //cls_Test_get_PatientDetail_BL cls_Test_get_PatientDetail_BL = new cls_Test_get_PatientDetail_BL(ConnectionString);
           // Console.WriteLine(cls_Test_get_PatientDetail_BL.SC_001());
         


            //PUT
            //cls_Test_put_Patient_BL cls_Test_put_Patient_BL = new cls_Test_put_Patient_BL(ConnectionString);
            //cls_Test_put_Patient_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Patient\\PIHMS.CL.BL.Patient.TestApp\\json\\cls_Test_put_Patient_BL_DATA_SC001.json");

            //cls_Test_put_Patient_BL cls_Test_put_Patient_BL1 = new cls_Test_put_Patient_BL(ConnectionString);
            //cls_Test_put_Patient_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Patient\\PIHMS.CL.BL.Patient.TestApp\\json\\cls_Test_put_Patient_BL_DATA_SC002.json");

            //cls_Test_put_PatientBirthDetails_BL cls_Test_put_PatientBirthDetails_BL = new cls_Test_put_PatientBirthDetails_BL(ConnectionString);
            //cls_Test_put_PatientBirthDetails_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Patient\\PIHMS.CL.BL.Patient.TestApp\\json\\cls_Test_put_PatientBirthDetails_BL_DATA_SC001.json");

            //cls_Test_put_PatientBirthDetails_BL cls_Test_put_PatientBirthDetails_BL2 = new cls_Test_put_PatientBirthDetails_BL(ConnectionString);
            //cls_Test_put_PatientBirthDetails_BL2.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Patient\\PIHMS.CL.BL.Patient.TestApp\\json\\cls_Test_put_PatientBirthDetails_BL_DATA_SC002.json");

            //cls_Test_put_PatientInsurance_BL cls_Test_put_PatientInsurance_BL = new cls_Test_put_PatientInsurance_BL(ConnectionString);
            //cls_Test_put_PatientInsurance_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Patient\\PIHMS.CL.BL.Patient.TestApp\\json\\cls_Test_put_PatientInsurance_BL_DATA_SC001.json");

            //cls_Test_put_PatientInsurance_BL cls_Test_put_PatientInsurance_BL3 = new cls_Test_put_PatientInsurance_BL(ConnectionString);
            //cls_Test_put_PatientInsurance_BL3.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Patient\\PIHMS.CL.BL.Patient.TestApp\\json\\cls_Test_put_PatientInsurance_BL_DATA_SC002.json");

            //cls_Test_put_IPcasePatientAddress_BL cls_Test_put_IPcasePatientAddress_BL = new cls_Test_put_IPcasePatientAddress_BL(ConnectionString);
            //cls_Test_put_IPcasePatientAddress_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Patient\\PIHMS.CL.BL.Patient.TestApp\\json\\cls_Test_put_IPcasePatientAddress_BL_DATA_SC001.json");

            //cls_Test_put_IPcasePatientAddress_BL cls_Test_put_IPcasePatientAddress_BL4 = new cls_Test_put_IPcasePatientAddress_BL(ConnectionString);
            //cls_Test_put_IPcasePatientAddress_BL4.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Patient\\PIHMS.CL.BL.Patient.TestApp\\json\\cls_Test_put_IPcasePatientAddress_BL_DATA_SC002.json");

            //cls_Test_put_PatientHistory_BL cls_Test_put_PatientHistory_BL = new cls_Test_put_PatientHistory_BL(ConnectionString);
            //cls_Test_put_PatientHistory_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Patient\\PIHMS.CL.BL.Patient.TestApp\\json\\cls_Test_put_PatientHistory_BL_DATA_SC001.json");

            //cls_Test_put_PatientHistory_BL cls_Test_put_PatientHistory_BL5 = new cls_Test_put_PatientHistory_BL(ConnectionString);
            //cls_Test_put_PatientHistory_BL5.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Patient\\PIHMS.CL.BL.Patient.TestApp\\json\\cls_Test_put_PatientHistory_BL_DATA_SC002.json");

            //cls_Test_put_PatientVisits_BL cls_Test_put_PatientVisits_BL = new cls_Test_put_PatientVisits_BL(ConnectionString);
            //cls_Test_put_PatientVisits_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Patient\\PIHMS.CL.BL.Patient.TestApp\\json\\cls_Test_put_PatientVisits_BL_DATA_SC001.json");

            //cls_Test_put_PatientVisits_BL cls_Test_put_PatientVisits_BL6 = new cls_Test_put_PatientVisits_BL(ConnectionString);
            //cls_Test_put_PatientVisits_BL6.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Patient\\PIHMS.CL.BL.Patient.TestApp\\json\\cls_Test_put_PatientVisits_BL_DATA_SC002.json");

            //cls_Test_put_PatientVisitsPrescription_BL cls_Test_put_PatientVisitsPrescription_BL = new cls_Test_put_PatientVisitsPrescription_BL(ConnectionString);
            //cls_Test_put_PatientVisitsPrescription_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Patient\\PIHMS.CL.BL.Patient.TestApp\\json\\cls_Test_put_PatientVisitsPrescription_BL_DATA_SC001.json");

            //cls_Test_put_PatientVisitsPrescription_BL cls_Test_put_PatientVisitsPrescription_BL7 = new cls_Test_put_PatientVisitsPrescription_BL(ConnectionString);
            //cls_Test_put_PatientVisitsPrescription_BL7.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Patient\\PIHMS.CL.BL.Patient.TestApp\\json\\cls_Test_put_PatientVisitsPrescription_BL_DATA_SC002.json");

            //cls_Test_put_PatientHistoryScannedFiles_BL cls_Test_put_PatientHistoryScannedFiles_BL = new cls_Test_put_PatientHistoryScannedFiles_BL(ConnectionString);
            //cls_Test_put_PatientHistoryScannedFiles_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Patient\\PIHMS.CL.BL.Patient.TestApp\\json\\cls_Test_put_PatientHistoryScannedFiles_BL_DATA_SC001.json");

            //cls_Test_put_PatientHistoryScannedFiles_BL cls_Test_put_PatientHistoryScannedFiles_BL8 = new cls_Test_put_PatientHistoryScannedFiles_BL(ConnectionString);
            //cls_Test_put_PatientHistoryScannedFiles_BL8.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.Patient\\PIHMS.CL.BL.Patient.TestApp\\json\\cls_Test_put_PatientHistoryScannedFiles_BL_DATA_SC002.json");

            //Get

            cls_Test_get_PatientList_BL test = new cls_Test_get_PatientList_BL(ConnectionString);
            Console.WriteLine(test.SC_001());


            //cls_Test_get_PatientInsurance_BL test2 = new cls_Test_get_PatientInsurance_BL(ConnectionString);
            //Console.WriteLine(test2.SC_001());


            //cls_Test_get_PatientHistory_BL test3 = new cls_Test_get_PatientHistory_BL(ConnectionString);
            //Console.WriteLine(test3.SC_001());


            //cls_Test_get_IPcasePatientAddress_BL test4 = new cls_Test_get_IPcasePatientAddress_BL(ConnectionString);
            //Console.WriteLine(test4.SC_001());

            //cls_Test_get_PatientBirthDetails_BL test5 = new cls_Test_get_PatientBirthDetails_BL(ConnectionString);
            //Console.WriteLine(test5.SC_001());

            //cls_Test_get_PatientVisits_BL test6 = new cls_Test_get_PatientVisits_BL(ConnectionString);
            //Console.WriteLine(test6.SC_001());


            //cls_Test_get_PatientVisitsPrescription_BL test7 = new cls_Test_get_PatientVisitsPrescription_BL(ConnectionString);
            //Console.WriteLine(test7.SC_001());

            //cls_Test_get_PatientHistoryScannedFiles_BL test8 = new cls_Test_get_PatientHistoryScannedFiles_BL(ConnectionString);
            //Console.WriteLine(test8.SC_001());
        }

    }
}

