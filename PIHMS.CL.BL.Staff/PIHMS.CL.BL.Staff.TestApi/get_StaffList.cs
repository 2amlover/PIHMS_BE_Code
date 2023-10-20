using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PIHMS.CL.BL.Staff.TestApi
{
    internal class get_StaffList
    {
        public async Task StaffList(string jsonFilePath)
        {
            string url = "http://ganga.pihms.co.in/Staff/get_StaffList";
            HttpClient client = new HttpClient();

            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(url, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            // Store the response body in a JSON file
            string responseFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestApi\\ResoponseBody\\get_StaffListType5.json";
            File.WriteAllText(responseFilePath, responseResult);

            Console.WriteLine("Response Body saved as Jsonfile.");

            // Deserialize the JSON response
            var responseObject = JsonConvert.DeserializeObject<ResponseObject>(responseResult);

            // Count the number of rows fetched
            int rowCount = responseObject.ml_StaffList.Length;

            Console.WriteLine($"{rowCount} : rows fetched");

            Console.ReadLine();
        }


        public class ResponseObject

        {
            public get_StaffList[] ml_StaffList { get; set; }

        }

    }
}
