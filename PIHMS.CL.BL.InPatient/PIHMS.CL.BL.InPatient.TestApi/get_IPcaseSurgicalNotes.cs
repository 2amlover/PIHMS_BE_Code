using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIHMS.CL.BL.InPatient.TestApi
{
    internal class get_IPcaseSurgicalNotes
    {
        public async Task IPcaseSurgicalNotes()
        {
            string url = "http://ganga.pihms.co.in/InPatient/get_IPcaseSurgicalNotes";
            HttpClient client = new HttpClient();

            string jsonFilePath = "E:\\PIHMS\\PIHMS.Module.Code\\PIHMS.CL.BL.InPatient\\PIHMS.CL.BL.InPatient.TestApi\\JsonFile\\get_IPcaseSurgicalNotes.json";
            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(url, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();
            dynamic jsonResponse = JsonConvert.DeserializeObject(responseResult);

            Console.WriteLine(jsonResponse);
            Console.ReadLine();
        }
    }
}
