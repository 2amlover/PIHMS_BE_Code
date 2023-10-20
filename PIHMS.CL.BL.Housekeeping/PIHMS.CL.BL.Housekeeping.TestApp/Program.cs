using PIHMS.CL.API.IO.Housekeeping;
using PIHMS.CL.BL.Masters.TestApp;
//using PIHMS.ConsoleApp.API.BL.Masters.Test;
using System.Text.Json;

namespace PIHMS.CL.BL.Housekeeping.TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            //String ConnectionString = "Server=127.0.0.1; database=db_ymsh_production; UID=dev; password=dev@1234";
            String ConnectionString = "Server=127.0.0.1; database=db_ymsh_production; UID=root; password=root";

            //get
            cls_Test_get_RelHousekeepingTasks_BL test1 = new cls_Test_get_RelHousekeepingTasks_BL(ConnectionString);
            Console.WriteLine(test1.SC_001());  

            cls_Test_get_HousekeepingAssignment_BL test2 = new cls_Test_get_HousekeepingAssignment_BL(ConnectionString);
            Console.WriteLine(test2.SC_001());

            cls_Test_get_HousekeepingAssignmentTasks_BL test3 = new cls_Test_get_HousekeepingAssignmentTasks_BL(ConnectionString);
            Console.WriteLine(test3.SC_001());
              
            //put

            cls_Test_put_RelHousekeepingTasks_BL cls_Test_put_RelHousekeepingTasks_BL = new cls_Test_put_RelHousekeepingTasks_BL(ConnectionString);
            cls_Test_put_RelHousekeepingTasks_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Housekeeping\PIHMS.CL.BL.Housekeeping.TestApp\JsonFile\\cls_Test_put_RelHousekeepingTasks_BL_SC001.json");

            cls_Test_put_RelHousekeepingTasks_BL cls_Test_put_RelHousekeepingTasks_BL1 = new cls_Test_put_RelHousekeepingTasks_BL(ConnectionString);
            cls_Test_put_RelHousekeepingTasks_BL1.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Housekeeping\PIHMS.CL.BL.Housekeeping.TestApp\JsonFile\\cls_Test_put_RelHousekeepingTasks_BL_SC002.json");

            cls_Test_put_HousekeepingAssignment_BL cls_Test_put_HousekeepingAssignment_BL = new cls_Test_put_HousekeepingAssignment_BL(ConnectionString);
            cls_Test_put_HousekeepingAssignment_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Housekeeping\PIHMS.CL.BL.Housekeeping.TestApp\JsonFile\\cls_Test_put_HousekeepingAssignment_BL_SC001.json");

            cls_Test_put_HousekeepingAssignment_BL cls_Test_put_HousekeepingAssignment_BL1 = new cls_Test_put_HousekeepingAssignment_BL(ConnectionString);
            cls_Test_put_HousekeepingAssignment_BL1.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Housekeeping\PIHMS.CL.BL.Housekeeping.TestApp\JsonFile\\cls_Test_put_HousekeepingAssignment_BL_SC002.json");

            cls_Test_put_HousekeepingAssignmentTasks_BL cls_Test_put_HousekeepingAssignmentTasks_BL = new cls_Test_put_HousekeepingAssignmentTasks_BL(ConnectionString);
            cls_Test_put_HousekeepingAssignmentTasks_BL.SC_001(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Housekeeping\PIHMS.CL.BL.Housekeeping.TestApp\JsonFile\\cls_Test_put_HousekeepingAssignmentTasks_BL_SC001.json");

            cls_Test_put_HousekeepingAssignmentTasks_BL cls_Test_put_HousekeepingAssignmentTasks_BL1 = new cls_Test_put_HousekeepingAssignmentTasks_BL(ConnectionString);
            cls_Test_put_HousekeepingAssignmentTasks_BL1.SC_002(@"C:\Users\ravibm\Desktop\PIHMS_GIT_HUB_V1\PIHMS_Module_Code\PIHMS.Module.Code\PIHMS.CL.BL.Housekeeping\PIHMS.CL.BL.Housekeeping.TestApp\JsonFile\\cls_Test_put_HousekeepingAssignmentTasks_BL_SC002.json");

        }
    }
}