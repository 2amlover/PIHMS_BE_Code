using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.InPatient;
using PIHMS.CL.API.Util.DBAccess;
using System.Text.Json;
namespace PIHMS.CL.BL.InPatient.TestApi
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello!");
            //get_IPCaseDetail get_IPCaseDetail = new get_IPCaseDetail();
            //await get_IPCaseDetail.IPCaseDetail();

            //get_IPCaseList get_IPCaseList = new get_IPCaseList();
            //await get_IPCaseList.IPCaseList();

            //get_IPCaseWardDetails get_IPCaseWardDetails = new get_IPCaseWardDetails();
            //await get_IPCaseWardDetails.IPCaseWardDetails();

            //get_IPCaseSignsAndSystems get_IPCaseSignsAndSystems = new get_IPCaseSignsAndSystems();
            //await get_IPCaseSignsAndSystems.IPCaseSignsAndSystems();

            //get_IPCaseVitalSigns get_IPCaseVitalSigns = new get_IPCaseVitalSigns();
            //await get_IPCaseVitalSigns.IPCaseVitalSigns();

            //get_IPcaseSurgicalNotes get_IPcaseSurgicalNotes = new get_IPcaseSurgicalNotes();
            //await get_IPcaseSurgicalNotes.IPcaseSurgicalNotes();

            //get_IPCaseOTConsumables get_IPCaseOTConsumables = new get_IPCaseOTConsumables();
            //await get_IPCaseOTConsumables.IPCaseOTConsumables();

            //get_IPCaseDoctorConsultations get_IPCaseDoctorConsultations = new get_IPCaseDoctorConsultations();
            //await get_IPCaseDoctorConsultations.IPCaseDoctorConsultations();

            //get_IPCaseBedConsumables get_IPCaseBedConsumables = new get_IPCaseBedConsumables();
            //await get_IPCaseBedConsumables.IPCaseBedConsumables();

            //get_IPCaseDischargeDetails get_IPCaseDischargeDetails = new get_IPCaseDischargeDetails();
            //await get_IPCaseDischargeDetails.IPCaseDischargeDetails();

            //get_IPCaseInsurancePaymentDetail get_IPCaseInsurancePaymentDetail = new get_IPCaseInsurancePaymentDetail();
            //await get_IPCaseInsurancePaymentDetail.IPCaseInsurancePaymentDetail();

            //get_IPCaseBillDetail get_IPCaseBillDetail = new get_IPCaseBillDetail();
            //await get_IPCaseBillDetail.IPCaseBillDetail();

            //get_IPCaseMedication get_IPCaseMedication = new get_IPCaseMedication();
            //await get_IPCaseMedication.IPCaseMedication();

            //get_IPCaseListMaster get_IPCaseListMaster = new get_IPCaseListMaster();
            //await get_IPCaseListMaster.IPCaseListMaster();




            //CreateJSONFile("get_IPCaseDetail");
            //CreateJSONFile("get_IPCaseList");
            //CreateJSONFile("get_IPCaseWardDetails");
            //CreateJSONFile("get_IPCaseSignsAndSystems");
            //CreateJSONFile("get_IPCaseVitalSigns");
            //CreateJSONFile("get_IPcaseSurgicalNotes");
            //CreateJSONFile("get_IPCaseOTConsumables");
            //CreateJSONFile("get_IPCaseDoctorConsultations");
            //CreateJSONFile("get_IPCaseBedConsumables");
            //CreateJSONFile("get_IPCaseDischargeDetails");
            //CreateJSONFile("get_IPCaseInsurancePaymentDetail");
            //CreateJSONFile("get_IPCaseBillDetail");
            //CreateJSONFile("get_IPCaseMedication");
            //CreateJSONFile("get_NewIPCaseMaster");
            //CreateJSONFile("get_IPCaseListMaster");
            Console.ReadLine();
        }
        static void CreateJSONFile(string Classname)
        {
            string strJson = "";
            switch (Classname)
            {
                //case "get_IPCaseDetail":
                //    get_IPCaseDetail_IP get_IPCaseDetail_IP = new get_IPCaseDetail_IP();
                //    strJson = JsonSerializer.Serialize<get_IPCaseDetail_IP>(get_IPCaseDetail_IP);
                //    break;

                //case "get_IPCaseList":
                //    get_IPCaseList_IP get_IPCaseList_IP = new get_IPCaseList_IP();
                //    strJson = JsonSerializer.Serialize<get_IPCaseList_IP>(get_IPCaseList_IP);
                //    break;

                //case "get_IPCaseWardDetails":
                //    get_IPCaseWardDetails_IP get_IPCaseWardDetails_IP = new get_IPCaseWardDetails_IP();
                //    strJson = JsonSerializer.Serialize<get_IPCaseWardDetails_IP>(get_IPCaseWardDetails_IP);
                //    break;

                //case "get_IPCaseSignsAndSystems":
                //    get_IPCaseSignsAndSystems_IP get_IPCaseSignsAndSystems_IP = new get_IPCaseSignsAndSystems_IP();
                //    strJson = JsonSerializer.Serialize<get_IPCaseSignsAndSystems_IP>(get_IPCaseSignsAndSystems_IP);
                //    break;

                //case "get_IPCaseVitalSigns":
                //    get_IPCaseVitalSigns_IP get_IPCaseVitalSigns_IP = new get_IPCaseVitalSigns_IP();
                //    strJson = JsonSerializer.Serialize<get_IPCaseVitalSigns_IP>(get_IPCaseVitalSigns_IP);
                //    break;

                //case "get_IPcaseSurgicalNotes":
                //    get_IPcaseSurgicalNotes_IP get_IPcaseSurgicalNotes_IP = new get_IPcaseSurgicalNotes_IP();
                //    strJson = JsonSerializer.Serialize<get_IPcaseSurgicalNotes_IP>(get_IPcaseSurgicalNotes_IP);
                //    break;

                //case "get_IPCaseOTConsumables":
                //    get_IPCaseOTConsumables_IP get_IPCaseOTConsumables_IP = new get_IPCaseOTConsumables_IP();
                //    strJson = JsonSerializer.Serialize<get_IPCaseOTConsumables_IP>(get_IPCaseOTConsumables_IP);
                //    break;

                //case "get_IPCaseDoctorConsultations":
                //    get_IPCaseDoctorConsultations_IP get_IPCaseDoctorConsultations_IP = new get_IPCaseDoctorConsultations_IP();
                //    strJson = JsonSerializer.Serialize<get_IPCaseDoctorConsultations_IP>(get_IPCaseDoctorConsultations_IP);
                //    break;

                //case "get_IPCaseBedConsumables":
                //    get_IPCaseBedConsumables_IP get_IPCaseBedConsumables_IP = new get_IPCaseBedConsumables_IP();
                //    strJson = JsonSerializer.Serialize<get_IPCaseBedConsumables_IP>(get_IPCaseBedConsumables_IP);
                //    break;

                //case "get_IPCaseDischargeDetails":
                //    get_IPCaseDischargeDetails_IP get_IPCaseDischargeDetails_IP = new get_IPCaseDischargeDetails_IP();
                //    strJson = JsonSerializer.Serialize<get_IPCaseDischargeDetails_IP>(get_IPCaseDischargeDetails_IP);
                //    break;

                //case "get_IPCaseInsurancePaymentDetail":
                //    get_IPCaseInsurancePaymentDetail_IP get_IPCaseInsurancePaymentDetail_IP = new get_IPCaseInsurancePaymentDetail_IP();
                //    strJson = JsonSerializer.Serialize<get_IPCaseInsurancePaymentDetail_IP>(get_IPCaseInsurancePaymentDetail_IP);
                //    break;

                //case "get_IPCaseBillDetail":
                //    get_IPCaseBillDetail_IP get_IPCaseBillDetail_IP = new get_IPCaseBillDetail_IP();
                //    strJson = JsonSerializer.Serialize<get_IPCaseBillDetail_IP>(get_IPCaseBillDetail_IP);
                //    break;

                //case "get_NewIPCaseMaster":
                //    get_NewIPCaseMaster_IP get_NewIPCaseMaster_IP = new get_NewIPCaseMaster_IP();
                //    strJson = JsonSerializer.Serialize<get_NewIPCaseMaster_IP>(get_NewIPCaseMaster_IP);
                //    break;

                case "get_IPCaseListMaster":
                    get_IPCaseListMaster_IP get_IPCaseListMaster_IP = new get_IPCaseListMaster_IP();
                    strJson = JsonSerializer.Serialize<get_IPCaseListMaster_IP>(get_IPCaseListMaster_IP);
                    break;

            }
            string Filename = "..\\..\\..\\JsonFile\\" + Classname + ".json";
            File.WriteAllText(Filename, strJson);
        }
    }
}