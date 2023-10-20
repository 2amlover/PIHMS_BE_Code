using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;
using System.Xml;
using System.Net.Http.Json;

namespace PIHMS.CL.BL.TestAPI
{
    public class cls_TestAPI_get_StaffPaySlip_BL
    {
        public string m_url = "";
        public string m_ipop_data_path = "";
        public string m_res_data_path = "";

        public cls_TestAPI_get_StaffPaySlip_BL()
        {

        }

        public async Task SC001()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC001_IP.json";
            string op_flie = m_ipop_data_path + "SC001_OP.json";

            string res_file = m_res_data_path + "SC001_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";


            string ip_data = File.ReadAllText(ip_file);

            var response = await client.PostAsync(m_url, new StringContent(ip_data, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            File.WriteAllText(res_file, responseResult);

            string ExpectedData = File.ReadAllText(op_flie);

            if (responseResult == ExpectedData)
            {
                Console.WriteLine("SC001 PASS");
            }
            else
            {
                Console.WriteLine("SC001 FAIL");
            }

        }

    }
}
