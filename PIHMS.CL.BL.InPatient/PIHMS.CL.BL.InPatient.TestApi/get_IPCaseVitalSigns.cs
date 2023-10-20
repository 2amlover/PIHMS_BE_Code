using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIHMS.CL.BL.InPatient.TestApi
{
    internal class get_IPCaseVitalSigns
    {
        public async Task IPCaseVitalSigns()
        {
            string url = "http://ganga.pihms.co.in/InPatient/get_IPCaseVitalSigns";
            HttpClient client = new HttpClient();

            string jsonFilePath = "E:\\PIHMS\\PIHMS.Module.Code\\PIHMS.CL.BL.InPatient\\PIHMS.CL.BL.InPatient.TestApi\\JsonFile\\get_IPCaseVitalSigns.json";
            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(url, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();
            dynamic jsonResponse = JsonConvert.DeserializeObject(responseResult);

            Console.WriteLine(jsonResponse);
            Console.ReadLine();
        }

    }
}
