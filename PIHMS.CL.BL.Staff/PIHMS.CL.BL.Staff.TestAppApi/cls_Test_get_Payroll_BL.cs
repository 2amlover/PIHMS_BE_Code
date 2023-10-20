using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIHMS.CL.BL.Staff.TestAppApi
{
    internal class cls_Test_get_Payroll_BL
    {

        private string apiUrl = "http://ganga.pihms.co.in/Staff/get_StaffPayroll";

        //Type 0 = get All Columns Based on ID
        public async Task SC_001()
        {
            HttpClient client = new HttpClient();
            string jsonFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\StaffPayroll_Request\\get_StaffPayroll.json";
            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(apiUrl, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            string responseFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\StaffPayroll_Response\\get_StaffPayroll.json";
            File.WriteAllText(responseFilePath, responseResult);

            Console.WriteLine("Response Body saved as Json file.");

            string json = File.ReadAllText(responseFilePath);
            JObject data = JObject.Parse(json);

            JArray staff = (JArray)data["ml_StaffPayroll"];

            int objectCount = staff.Count;
            Console.WriteLine("Number of rows: " + objectCount);
        }

    }
}
