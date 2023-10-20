using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIHMS.CL.BL.Staff.TestApi
{
    internal class get_StaffDetail
    {
        public async Task get_StaffDetails()
        {
            string url = "http://ganga.pihms.co.in/Staff/get_StaffDetail";
            HttpClient client = new HttpClient();

            string jsonFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestApi\\Jsonfile\\get_StaffDetail.json";
            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(url, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            dynamic jsonResponse = JsonConvert.DeserializeObject(responseResult);
            Console.WriteLine(jsonResponse);
            Console.ReadLine();
        }
    }
}
