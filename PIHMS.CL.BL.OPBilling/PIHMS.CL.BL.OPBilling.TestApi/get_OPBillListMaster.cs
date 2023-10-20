﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PIHMS.CL.BL.OPBilling.TestApi
{
    internal class get_OPBillListMaster
    {
        public async Task OPBillListMaster()
        {
            string url = "http://ganga.pihms.co.in/OPBilling/get_OPBillListMaster";
            HttpClient client = new HttpClient();

            string jsonFilePath = "C:\\Users\\dev03\\Desktop\\shrutit_my_files\\New Json Opbilling\\PIHMS.CL.BL.OPBilling\\JsonFile\\OPBillListMaster.json";
            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(url, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();
            dynamic jsonResponse = JsonConvert.DeserializeObject(responseResult);

            Console.WriteLine(jsonResponse);
            Console.ReadLine();
        }
    }
}
