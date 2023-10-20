using PIHMS.CL.API.IO.DoctorConsultation;
//using PIHMS.ConsoleApp.API.BL.Masters.Test;
using System.Text.Json;

namespace PIHMS.CL.BL.DoctorConsultation.TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            String ConnectionString = "Server=127.0.0.1; database=db_ymsh_production; UID=root; password=root";



            //get
            cls_Test_get_ConsultScannedFiles_BL test1 = new cls_Test_get_ConsultScannedFiles_BL(ConnectionString);
            Console.WriteLine(test1.SC_001());


            cls_Test_get_DoctorConsultation_BL test2 = new cls_Test_get_DoctorConsultation_BL(ConnectionString);
            Console.WriteLine(test2.SC_001());


            cls_Test_get_DoctorConsultationDocument_BL test3 = new cls_Test_get_DoctorConsultationDocument_BL(ConnectionString);
            Console.WriteLine(test3.SC_001());


            cls_Test_get_DoctorConsultationInvreq_BL test4 = new cls_Test_get_DoctorConsultationInvreq_BL(ConnectionString);
            Console.WriteLine(test4.SC_001());


            cls_Test_get_DoctorConsultationInvreqItem_BL test5 = new cls_Test_get_DoctorConsultationInvreqItem_BL(ConnectionString);
            Console.WriteLine(test5.SC_001());


            cls_Test_get_DoctorConsultationMedication_BL test6 = new cls_Test_get_DoctorConsultationMedication_BL(ConnectionString);
            Console.WriteLine(test6.SC_001());


            cls_Test_get_OPConsultAppointment_BL test7 = new cls_Test_get_OPConsultAppointment_BL(ConnectionString);
            Console.WriteLine(test7.SC_001());


            cls_Test_get_PharmacyOpconsultItem_BL test8 = new cls_Test_get_PharmacyOpconsultItem_BL(ConnectionString);
            Console.WriteLine(test8.SC_001());


            //put
            cls_Test_put_ConsultScannedFiles_BL cls_Test_put_ConsultScannedFiles_BL = new cls_Test_put_ConsultScannedFiles_BL(ConnectionString);
            cls_Test_put_ConsultScannedFiles_BL.SC_001("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.DoctorConsultation\\PIHMS.CL.BL.DoctorConsultation.TestApp\\JsonFile\\cls_Test_put_ConsultScannedFiles_BL_SC001.json");

            cls_Test_put_ConsultScannedFiles_BL cls_Test_put_ConsultScannedFiles_BL1 = new cls_Test_put_ConsultScannedFiles_BL(ConnectionString);
            cls_Test_put_ConsultScannedFiles_BL1.SC_002("C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.DoctorConsultation\\PIHMS.CL.BL.DoctorConsultation.TestApp\\JsonFile\\cls_Test_put_ConsultScannedFiles_BL_SC002.json");


            cls_Test_put_DoctorConsultation_BL cls_Test_put_DoctorConsultation_BL = new cls_Test_put_DoctorConsultation_BL(ConnectionString);
            cls_Test_put_DoctorConsultation_BL.SC_001(@"C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.DoctorConsultation\\PIHMS.CL.BL.DoctorConsultation.TestApp\\JsonFile\\cls_Test_put_DoctorConsultation_BL_SC001.json");

            cls_Test_put_DoctorConsultation_BL cls_Test_put_DoctorConsultation_BL1 = new cls_Test_put_DoctorConsultation_BL(ConnectionString);
            cls_Test_put_DoctorConsultation_BL1.SC_002(@"C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.DoctorConsultation\\PIHMS.CL.BL.DoctorConsultation.TestApp\\JsonFile\\cls_Test_put_DoctorConsultation_BL_SC002.json");


            cls_Test_put_DoctorConsultationDocument_BL cls_Test_put_DoctorConsultationDocument_BL = new cls_Test_put_DoctorConsultationDocument_BL(ConnectionString);
            cls_Test_put_DoctorConsultationDocument_BL.SC_001(@"C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.DoctorConsultation\\PIHMS.CL.BL.DoctorConsultation.TestApp\\JsonFile\\cls_Test_put_DoctorConsultationDocument_BL_SC001.json");

            cls_Test_put_DoctorConsultationDocument_BL cls_Test_put_DoctorConsultationDocument_BL1 = new cls_Test_put_DoctorConsultationDocument_BL(ConnectionString);
            cls_Test_put_DoctorConsultationDocument_BL1.SC_002(@"C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.DoctorConsultation\\PIHMS.CL.BL.DoctorConsultation.TestApp\\JsonFile\\cls_Test_put_DoctorConsultationDocument_BL_SC002.json");


            cls_Test_put_DoctorConsultationInvreq_BL cls_Test_put_DoctorConsultationInvreq_BL = new cls_Test_put_DoctorConsultationInvreq_BL(ConnectionString);
            cls_Test_put_DoctorConsultationInvreq_BL.SC_001(@"C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.DoctorConsultation\\PIHMS.CL.BL.DoctorConsultation.TestApp\\JsonFile\\cls_Test_put_DoctorConsultationInvreq_BL_SC001.json");

            cls_Test_put_DoctorConsultationInvreq_BL cls_Test_put_DoctorConsultationInvreq_BL1 = new cls_Test_put_DoctorConsultationInvreq_BL(ConnectionString);
            cls_Test_put_DoctorConsultationInvreq_BL1.SC_002(@"C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.DoctorConsultation\\PIHMS.CL.BL.DoctorConsultation.TestApp\\JsonFile\\cls_Test_put_DoctorConsultationInvreq_BL_SC002.json");


            cls_Test_put_DoctorConsultationInvreqItem_BL cls_Test_put_DoctorConsultationInvreqItem_BL = new cls_Test_put_DoctorConsultationInvreqItem_BL(ConnectionString);
            cls_Test_put_DoctorConsultationInvreqItem_BL.SC_001(@"C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.DoctorConsultation\\PIHMS.CL.BL.DoctorConsultation.TestApp\\JsonFile\\cls_Test_put_DoctorConsultationInvreqItem_BL_SC001.json");

            cls_Test_put_DoctorConsultationInvreqItem_BL cls_Test_put_DoctorConsultationInvreqItem_BL1 = new cls_Test_put_DoctorConsultationInvreqItem_BL(ConnectionString);
            cls_Test_put_DoctorConsultationInvreqItem_BL1.SC_002(@"C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.DoctorConsultation\\PIHMS.CL.BL.DoctorConsultation.TestApp\\JsonFile\\cls_Test_put_DoctorConsultationInvreqItem_BL_SC002.json");

            cls_Test_put_DoctorConsultationMedication_BL cls_Test_put_DoctorConsultationMedication_BL = new cls_Test_put_DoctorConsultationMedication_BL(ConnectionString);
            cls_Test_put_DoctorConsultationMedication_BL.SC_001(@"C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.DoctorConsultation\\PIHMS.CL.BL.DoctorConsultation.TestApp\\JsonFile\\cls_Test_put_DoctorConsultationMedication_BL_SC001.json");

            cls_Test_put_DoctorConsultationMedication_BL cls_Test_put_DoctorConsultationMedication_BL1 = new cls_Test_put_DoctorConsultationMedication_BL(ConnectionString);
            cls_Test_put_DoctorConsultationMedication_BL1.SC_002(@"C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.DoctorConsultation\\PIHMS.CL.BL.DoctorConsultation.TestApp\\JsonFile\\cls_Test_put_DoctorConsultationMedication_BL_SC002.json");


            cls_Test_put_OPConsultAppointment_BL cls_Test_put_OPConsultAppointment_BL = new cls_Test_put_OPConsultAppointment_BL(ConnectionString);
            cls_Test_put_OPConsultAppointment_BL.SC_001(@"C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.DoctorConsultation\\PIHMS.CL.BL.DoctorConsultation.TestApp\\JsonFile\\cls_Test_put_OPConsultAppointment_BL_SC001.json");

            cls_Test_put_OPConsultAppointment_BL cls_Test_put_OPConsultAppointment_BL1 = new cls_Test_put_OPConsultAppointment_BL(ConnectionString);
            cls_Test_put_OPConsultAppointment_BL1.SC_002(@"C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.DoctorConsultation\\PIHMS.CL.BL.DoctorConsultation.TestApp\\JsonFile\\cls_Test_put_OPConsultAppointment_BL_SC002.json");


            cls_Test_put_PharmacyOpconsultItem_BL cls_Test_put_PharmacyOpconsultItem_BL = new cls_Test_put_PharmacyOpconsultItem_BL(ConnectionString);
            cls_Test_put_PharmacyOpconsultItem_BL.SC_001(@"C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.DoctorConsultation\\PIHMS.CL.BL.DoctorConsultation.TestApp\\JsonFile\\cls_Test_put_PharmacyOpconsultItem_BL_SC001.json");

            cls_Test_put_PharmacyOpconsultItem_BL cls_Test_put_PharmacyOpconsultItem_BL1 = new cls_Test_put_PharmacyOpconsultItem_BL(ConnectionString);
            cls_Test_put_PharmacyOpconsultItem_BL1.SC_002(@"C:\\Users\\ravibm\\Desktop\\PIHMS_GIT_HUB_V1\\PIHMS_Module_Code\\PIHMS.Module.Code\\PIHMS.CL.BL.DoctorConsultation\\PIHMS.CL.BL.DoctorConsultation.TestApp\\JsonFile\\cls_Test_put_PharmacyOpconsultItem_BL_SC002.json");

        }
    }

}
