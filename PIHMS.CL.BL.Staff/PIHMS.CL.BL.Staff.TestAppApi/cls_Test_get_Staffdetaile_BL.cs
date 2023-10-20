using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIHMS.CL.BL.Staff.TestAppApi
{
    internal class cls_Test_get_Staffdetaile_BL
    {
        private string apiUrl = "http://ganga.pihms.co.in/Staff/get_StaffDetail";

        //Type 0 = get All Columns Based on ID
        public async Task SC_001()
        {
            HttpClient client = new HttpClient();
            string jsonFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\StaffDetaile_Request\\get_StaffDetail.json";
            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(apiUrl, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            string responseFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\StaffDetaile_Response\\get_StaffDetail.json";
            File.WriteAllText(responseFilePath, responseResult);

            Console.WriteLine("Response Body saved as Json file.");

            string json = File.ReadAllText(responseFilePath);
            JObject data = JObject.Parse(json);

            JObject staff = (JObject)data["m_Staff"];
            JArray staffaddress = (JArray)data["ml_StaffAddress"];

            int staffCount = staff != null ? 1 : 0;
            int staffAddressCount = staffaddress.Count;

            Console.WriteLine("Number of rows Fetched in m_Staff : " + staffCount);
            Console.WriteLine("Number of rows Fetched in ml_StaffAddress : " + staffAddressCount);
        }

    }
}
