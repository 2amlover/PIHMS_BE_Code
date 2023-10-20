using PIHMS.CL.API.IO.Communication;
using System.Text.Json;

namespace PIHMS.CL.BL.Communication.TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            String ConnectionString = "Server=127.0.0.1; database=db_ymsh_production; UID=root; password=root";

             //put

            cls_Test_put_DashboardMail_BL cls_Test_put_DashboardMail_BL = new cls_Test_put_DashboardMail_BL(ConnectionString);
            cls_Test_put_DashboardMail_BL.SC_001(@"E:\User_Data\shrutit\PIHMS_Code_For_Ravi\PIHMS.ClassLibrary.API.BL.Communication\PIHMS.ConsoleApp.API.BL.Communication.Test\Json\cls_Test_put_DashboardMail_BL_SC001.json");

            cls_Test_put_DashboardMail_BL cls_Test_put_DashboardMail_BL1 = new cls_Test_put_DashboardMail_BL(ConnectionString);
            cls_Test_put_DashboardMail_BL1.SC_002(@"E:\User_Data\shrutit\PIHMS_Code_For_Ravi\PIHMS.ClassLibrary.API.BL.Communication\PIHMS.ConsoleApp.API.BL.Communication.Test\Json\cls_Test_put_DashboardMail_BL_SC002.json");

            cls_Test_put_DashboardMessage_BL cls_Test_put_DashboardMessage_BL = new cls_Test_put_DashboardMessage_BL(ConnectionString);
            cls_Test_put_DashboardMessage_BL.SC_001(@"E:\User_Data\shrutit\PIHMS_Code_For_Ravi\PIHMS.ClassLibrary.API.BL.Communication\PIHMS.ConsoleApp.API.BL.Communication.Test\Json\cls_Test_put_DashboardMessage_BL_SC001.json");

            cls_Test_put_DashboardMessage_BL cls_Test_put_DashboardMessage_BL2 = new cls_Test_put_DashboardMessage_BL(ConnectionString);
            cls_Test_put_DashboardMessage_BL2.SC_002(@"E:\User_Data\shrutit\PIHMS_Code_For_Ravi\PIHMS.ClassLibrary.API.BL.Communication\PIHMS.ConsoleApp.API.BL.Communication.Test\Json\cls_Test_put_DashboardMessage_BL_SC002.json");

            cls_Test_put_SmsDetails_BL cls_Test_put_SmsDetails_BL = new cls_Test_put_SmsDetails_BL(ConnectionString);
            cls_Test_put_SmsDetails_BL.SC_001(@"E:\User_Data\shrutit\PIHMS_Code_For_Ravi\PIHMS.ClassLibrary.API.BL.Communication\PIHMS.ConsoleApp.API.BL.Communication.Test\Json\cls_Test_put_SmsDetails_BL_SC001.json");

            cls_Test_put_SmsDetails_BL cls_Test_put_SmsDetails_BL3 = new cls_Test_put_SmsDetails_BL(ConnectionString);
            cls_Test_put_SmsDetails_BL3.SC_002(@"E:\User_Data\shrutit\PIHMS_Code_For_Ravi\PIHMS.ClassLibrary.API.BL.Communication\PIHMS.ConsoleApp.API.BL.Communication.Test\Json\cls_Test_put_SmsDetails_BL_SC002.json");

            //get

            cls_Test_get_SmsDetails_BL test1 = new cls_Test_get_SmsDetails_BL(ConnectionString);
            Console.WriteLine(test1.SC_001());

            cls_Test_get_DashboardMail_BL test2 = new cls_Test_get_DashboardMail_BL(ConnectionString);
            Console.WriteLine(test2.SC_001());

            cls_Test_get_DashboardMessage_BL test3 = new cls_Test_get_DashboardMessage_BL(ConnectionString);
            Console.WriteLine(test3.SC_001());

        }

    }
}
