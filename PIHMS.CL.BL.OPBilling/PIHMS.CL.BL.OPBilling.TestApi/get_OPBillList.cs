using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PIHMS.CL.BL.OPBilling.TestApi
{
    internal class get_OPBillList
    {
        public async Task OPBillList()
        {
            string url = "http://ganga.pihms.co.in/OPBilling/get_OPBillList";
            HttpClient client = new HttpClient();

            string jsonFilePath = "E:\\PIHMS_GIT\\PIHMS.Module.Code\\PIHMS.CL.BL.OPBilling\\PIHMS.CL.BL.OPBilling.TestApi\\JsonFile\\.json";
            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(url, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();
            dynamic jsonResponse = JsonConvert.DeserializeObject(responseResult);

            Console.WriteLine(jsonResponse);
            Console.ReadLine();
        }
    }
}
