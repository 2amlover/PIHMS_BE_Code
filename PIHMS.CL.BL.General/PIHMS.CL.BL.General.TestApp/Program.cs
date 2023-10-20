
using PIHMS.CL.API.IO.General;
using System.Text.Json;
namespace PIHMS.CL.BL.General.TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            String ConnectionString = "Server=127.0.0.1; database=db_ymsh_production; UID=root; password=root";


            cls_Test_get_Feedback_BL test = new cls_Test_get_Feedback_BL(ConnectionString);
            Console.WriteLine(test.SC_001());
            cls_Test_get_MeassagingEmailMessages_BL test1 = new cls_Test_get_MeassagingEmailMessages_BL(ConnectionString);
            Console.WriteLine(test1.SC_001());



            cls_Test_put_Feedback_BL test38 = new cls_Test_put_Feedback_BL(ConnectionString);
            test38.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.General\PIHMS.CL.BL.General.TestApp\JsonFile\\cls_Test_put_Feedback_BL_SC001.json");
            test38.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.General\PIHMS.CL.BL.General.TestApp\JsonFile\\cls_Test_put_Feedback_BL_SC002.json");

            cls_Test_put_MessagingEmailMessages_BL test24 = new cls_Test_put_MessagingEmailMessages_BL(ConnectionString);
            test24.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.General\PIHMS.CL.BL.General.TestApp\JsonFile\\cls_Test_put_MessagingEmailMessages_BL_SC001.json");
            test24.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.General\PIHMS.CL.BL.General.TestApp\JsonFile\\cls_Test_put_MessagingEmailMessages_BL_SC002.json");



            Console.ReadKey();
            //CreateJSONFile("cls_Test_put_Feedback_BL_SC001");
            //CreateJSONFile("cls_Test_put_MessagingEmailMessages_BL_SC001");



        }



        //static void CreateJSONFile(string Classname)
        //{
        //    string strJson = "";
        //    switch (Classname)
        //    {
        //        case "cls_Test_put_Feedback_BL_SC001":
        //            put_Feedback_IP put_Feedback_IP = new put_Feedback_IP();
        //            strJson = JsonSerializer.Serialize<put_Feedback_IP>(put_Feedback_IP);
        //            break;
        //        case "cls_Test_put_MessagingEmailMessages_BL_SC001":
        //            put_MessagingEmailMessages_IP put_MessagingEmailMessages_IP = new put_MessagingEmailMessages_IP();
        //            strJson = JsonSerializer.Serialize<put_MessagingEmailMessages_IP>(put_MessagingEmailMessages_IP);
        //            break;
                

        //    }
        //    string Filename = "..\\..\\..\\JsonFile\\" + Classname + ".json";
        //    File.WriteAllText(Filename, strJson);
        //}
}
}
