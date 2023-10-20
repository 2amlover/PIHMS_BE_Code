//using PIHMS.CL.API.IO;
using System.Text.Json;

namespace PIHMS.CL.BL.Staff.TestApi
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            //get_StaffBankDetail test1 = new get_StaffBankDetail();
            //await test1.StaffBankDetail();

            //get_StaffDetail test = new get_StaffDetail();
            //await test.get_StaffDetails();

            //get_StaffEmployment test3 = new get_StaffEmployment();
            //await test3.StaffEmployment();

            // get_StaffList test1 = new get_StaffList();
            //  string jsonFilePathSC001 = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestApi\\Jsonfile\\get_StaffListType5.json";
            ////string jsonFilePathSC002 = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestApi\\Jsonfile\\get_StaffListType0.json";

            //test1.StaffList(jsonFilePathSC001);
            // test1.StaffList(jsonFilePathSC002);

            //get_StaffPaySlip test8 = new get_StaffPaySlip();
            //await test8.StaffPaySlip();

            //get_StaffDocuments test6 = new get_StaffDocuments();

            //await test6.StaffDocuments();

            //get_StaffLeaves test9 = new get_StaffLeaves();
            //test9.StaffLeaves();

            //get_StaffListMaster test5 = new get_StaffListMaster();
            //test5.StaffListMaster();

            //get_StaffPayroll test7 = new get_StaffPayroll();
            //await test7.StaffPayroll();

            get_StaffAttendence test10 = new get_StaffAttendence();
            await test10.StaffAttendence();




            //get_StaffEducation test11 = new get_StaffEducation();
            //test11.StaffEducation();



            //CreateJSONFile("get_StaffEducation");
            //CreateJSONFile("get_StaffLeaves");
            //CreateJSONFile("get_StaffListMaster");
            //CreateJSONFile("get_StaffAttendence");
            Console.ReadLine();
        }

        //static void CreateJSONFile(string Classname)
        //{
        //    string strJson = "";
        //    switch (Classname)
        //    {
        //        case "get_StaffEducation":
        //            get_StaffEducation_IP get_StaffEducation_IP = new get_StaffEducation_IP();
        //            strJson = JsonSerializer.Serialize<get_StaffEducation_IP>(get_StaffEducation_IP);
        //            break;

        //        case "get_StaffLeaves":
        //            get_StaffLeaves_IP get_StaffLeaves_IP = new get_StaffLeaves_IP();
        //            strJson = JsonSerializer.Serialize<get_StaffLeaves_IP>(get_StaffLeaves_IP);
        //            break;

        //        case "get_StaffListMaster":
        //            get_StaffListMaster_IP get_StaffListMaster_IP = new get_StaffListMaster_IP();
        //            strJson = JsonSerializer.Serialize<get_StaffListMaster_IP>(get_StaffListMaster_IP);
        //            break;

        //        case "get_StaffAttendence":
        //            get_StaffAttendence_IP get_StaffAttendence_IP = new get_StaffAttendence_IP();
        //            strJson = JsonSerializer.Serialize<get_StaffAttendence_IP>(get_StaffAttendence_IP);
        //            break;
        //    }
        //    string Filename = "..\\..\\..\\" + Classname + ".json";
        //    File.WriteAllText(Filename, strJson);
        //}

    }

}
