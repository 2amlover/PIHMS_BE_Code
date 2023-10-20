using System.Text.Json;
using PIHMS.CL.API.IO.Appointment;

namespace PIHMS.CL.BL.Appointment.TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            String ConnectionString = "Server=127.0.0.1; database=db_ymsh_production; UID=root; password=root";


            cls_Test_get_AccountRFQItems_BL test = new cls_Test_get_AccountRFQItems_BL(ConnectionString);
            Console.WriteLine(test.SC_001());
            cls_Test_get_Appointment_BL test1 = new cls_Test_get_Appointment_BL(ConnectionString);
            Console.WriteLine(test1.SC_001());
            cls_Test_get_CalAttendee_BL test2 = new cls_Test_get_CalAttendee_BL(ConnectionString);
            Console.WriteLine(test2.SC_001());
            cls_Test_get_CalEvent_BL test3 = new cls_Test_get_CalEvent_BL(ConnectionString);
            Console.WriteLine(test3.SC_001());
            cls_Test_get_CalRepeat_BL test4 = new cls_Test_get_CalRepeat_BL(ConnectionString);
            Console.WriteLine(test4.SC_001());
            cls_Test_get_CalRepeatTimings_BL test5 = new cls_Test_get_CalRepeatTimings_BL(ConnectionString);
            Console.WriteLine(test5.SC_001());


            cls_Test_put_AccountRFQItems_BL test38 = new cls_Test_put_AccountRFQItems_BL(ConnectionString);
            test38.SC_001(@"E:\User_Data\shrutit\PIHMS_Code_For_Ravi\PIHMS.ClassLibrary.API.BL.Appointment\PIHMS.ConsoleApp.API.BL.Appointment.Test\JsonFile\cls_Test_put_AccountRFQItems_BL_SC001.json");
            test38.SC_002(@"E:\User_Data\shrutit\PIHMS_Code_For_Ravi\PIHMS.ClassLibrary.API.BL.Appointment\PIHMS.ConsoleApp.API.BL.Appointment.Test\JsonFile\cls_Test_put_AccountRFQItems_BL_SC002.json");

            cls_Test_put_Appointment_BL test24 = new cls_Test_put_Appointment_BL(ConnectionString);
            test24.SC_001(@"E:\User_Data\shrutit\PIHMS_Code_For_Ravi\PIHMS.ClassLibrary.API.BL.Appointment\PIHMS.ConsoleApp.API.BL.Appointment.Test\JsonFile\cls_Test_put_Appointment_BL_SC001.json");
            test24.SC_002(@"E:\User_Data\shrutit\PIHMS_Code_For_Ravi\PIHMS.ClassLibrary.API.BL.Appointment\PIHMS.ConsoleApp.API.BL.Appointment.Test\JsonFile\cls_Test_put_Appointment_BL_SC002.json");

            cls_Test_put_CalAttendee_BL test25 = new cls_Test_put_CalAttendee_BL(ConnectionString);
            test25.SC_001(@"E:\User_Data\shrutit\PIHMS_Code_For_Ravi\PIHMS.ClassLibrary.API.BL.Appointment\PIHMS.ConsoleApp.API.BL.Appointment.Test\JsonFile\cls_Test_put_CalAttendee_BL_SC001.json");
            test25.SC_002(@"E:\User_Data\shrutit\PIHMS_Code_For_Ravi\PIHMS.ClassLibrary.API.BL.Appointment\PIHMS.ConsoleApp.API.BL.Appointment.Test\JsonFile\cls_Test_put_CalAttendee_BL_SC002.json");

            cls_Test_put_CalEvent_BL test26 = new cls_Test_put_CalEvent_BL(ConnectionString);
            test26.SC_001(@"E:\User_Data\shrutit\PIHMS_Code_For_Ravi\PIHMS.ClassLibrary.API.BL.Appointment\PIHMS.ConsoleApp.API.BL.Appointment.Test\JsonFile\cls_Test_put_CalEvent_BL_SC001.json");
            test26.SC_002(@"E:\User_Data\shrutit\PIHMS_Code_For_Ravi\PIHMS.ClassLibrary.API.BL.Appointment\PIHMS.ConsoleApp.API.BL.Appointment.Test\JsonFile\cls_Test_put_CalEvent_BL_SC002.json");

            cls_Test_put_CalRepeat_BL test27 = new cls_Test_put_CalRepeat_BL(ConnectionString);
            test27.SC_001(@"E:\User_Data\shrutit\PIHMS_Code_For_Ravi\PIHMS.ClassLibrary.API.BL.Appointment\PIHMS.ConsoleApp.API.BL.Appointment.Test\JsonFile\cls_Test_put_CalRepeat_BL_SC001.json");
            test27.SC_002(@"E:\User_Data\shrutit\PIHMS_Code_For_Ravi\PIHMS.ClassLibrary.API.BL.Appointment\PIHMS.ConsoleApp.API.BL.Appointment.Test\JsonFile\cls_Test_put_CalRepeat_BL_SC002.json");

            cls_Test_put_CalRepeatTimings_BL test28 = new cls_Test_put_CalRepeatTimings_BL(ConnectionString);
            test28.SC_001(@"E:\User_Data\shrutit\PIHMS_Code_For_Ravi\PIHMS.ClassLibrary.API.BL.Appointment\PIHMS.ConsoleApp.API.BL.Appointment.Test\JsonFile\cls_Test_put_CalRepeatTimings_BL_SC001.json");
            test28.SC_002(@"E:\User_Data\shrutit\PIHMS_Code_For_Ravi\PIHMS.ClassLibrary.API.BL.Appointment\PIHMS.ConsoleApp.API.BL.Appointment.Test\JsonFile\cls_Test_put_CalRepeatTimings_BL_SC002.json");


            Console.ReadKey();
            //CreateJSONFile("cls_Test_put_AccountRFQItems_BL_SC001");
            //CreateJSONFile("cls_Test_put_Appointment_BL_SC001");
            //CreateJSONFile("cls_Test_put_CalAttendee_BL_SC001");
            //CreateJSONFile("cls_Test_put_CalEvent_BL_SC001");
            //CreateJSONFile("cls_Test_put_CalRepeat_BL_SC001");
            //CreateJSONFile("cls_Test_put_CalRepeatTimings_BL_SC001");


        }



        //static void CreateJSONFile(string Classname)
        //{
        //    string strJson = "";
        //    switch (Classname)
        //    {
        //        case "cls_Test_put_AccountRFQItems_BL_SC001":
        //            put_AccountRFQItems_IP put_AccountRFQItems_IP = new put_AccountRFQItems_IP();
        //            strJson = JsonSerializer.Serialize<put_AccountRFQItems_IP>(put_AccountRFQItems_IP);
        //            break;
        //        case "cls_Test_put_Appointment_BL_SC001":
        //            put_Appointment_IP put_Appointment_IP = new put_Appointment_IP();
        //            strJson = JsonSerializer.Serialize<put_Appointment_IP>(put_Appointment_IP);
        //            break;
        //        case "cls_Test_put_CalAttendee_BL_SC001":
        //            put_CalAttendee_IP put_CalAttendee_IP = new put_CalAttendee_IP();
        //            strJson = JsonSerializer.Serialize<put_CalAttendee_IP>(put_CalAttendee_IP);
        //            break;

        //        case "cls_Test_put_CalEvent_BL_SC001":
        //            put_CalEvent_IP put_CalEvent_IP = new put_CalEvent_IP();
        //            strJson = JsonSerializer.Serialize<put_CalEvent_IP>(put_CalEvent_IP);
        //            break;

        //        case "cls_Test_put_CalRepeat_BL_SC001":
        //            put_CalRepeat_IP put_CalRepeat_IP = new put_CalRepeat_IP();
        //            strJson = JsonSerializer.Serialize<put_CalRepeat_IP>(put_CalRepeat_IP);
        //            break;

        //        case "cls_Test_put_CalRepeatTimings_BL_SC001":
        //            put_CalRepeatTimings_IP put_CalRepeatTimings_IP = new put_CalRepeatTimings_IP();
        //            strJson = JsonSerializer.Serialize<put_CalRepeatTimings_IP>(put_CalRepeatTimings_IP);
        //            break;


        //    }
        //    string Filename = "..\\..\\..\\JsonFile\\" + Classname + ".json";
        //    File.WriteAllText(Filename, strJson);

        }
    }
