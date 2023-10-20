using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PIHMS.CL.BL.TestAPI
{
    public class cls_TestAPI_get_StaffAttendence_BL
    {
        public string m_url = "";
        public string m_ipop_data_path = "";
        public string m_res_data_path = "";

        public cls_TestAPI_get_StaffAttendence_BL()
        {

        }

        //SC001 StaffID cannot be null
        public async Task SC001()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC001_IP.json";
            string op_flie = m_ipop_data_path + "SC001_OP.json";
            string res_file = m_res_data_path + "SC001_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";

            string ip_data = File.ReadAllText(ip_file);

            using (JsonDocument document = JsonDocument.Parse(ip_data))
            {
                JsonElement root = document.RootElement;
                if (!root.TryGetProperty("m_StaffID", out JsonElement m_StaffIDElement) || m_StaffIDElement.ValueKind == JsonValueKind.Null)
                {
                    Console.WriteLine("m_StaffID cannot be null.");
                    return;
                }
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
                    Console.WriteLine("SC001 FAIL: ");
                }
            }
        }

        //SC002 StaffID cannot be -ve r less than 0
        public async Task SC002()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC002_IP.json";
            string op_flie = m_ipop_data_path + "SC002_OP.json";
            string res_file = m_res_data_path + "SC003_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";

            string ip_data = File.ReadAllText(ip_file);

            using (JsonDocument document = JsonDocument.Parse(ip_data))
            {
                JsonElement root = document.RootElement;
                if (!root.TryGetProperty("m_StaffID", out JsonElement m_StaffIDElement) || m_StaffIDElement.ValueKind == JsonValueKind.Null)
                {
                    Console.WriteLine("m_StaffID cannot be null.");
                    return;
                }
                int m_StaffID = m_StaffIDElement.GetInt32();
                if (m_StaffID < 0)
                {
                    Console.WriteLine("m_StaffID cannot be negative or less than 0.");
                    return;
                }

                var response = await client.PostAsync(m_url, new StringContent(ip_data, Encoding.UTF8, "application/json"));

                string responseResult = await response.Content.ReadAsStringAsync();
                File.WriteAllText(res_file, responseResult);

                string ExpectedData = File.ReadAllText(op_flie);

                if (responseResult == ExpectedData)
                {
                    Console.WriteLine("SC002 PASS");
                }
                else
                {
                    Console.WriteLine("SC002 FAIL: ");
                }
            }
        }

        //SC003 get_type cannot be null
        public async Task SC003()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC003_IP.json";
            string op_flie = m_ipop_data_path + "SC003_OP.json";
            string res_file = m_res_data_path + "SC003_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";

            string ip_data = File.ReadAllText(ip_file);

            using (JsonDocument document = JsonDocument.Parse(ip_data))
            {
                JsonElement root = document.RootElement;
                if (!root.TryGetProperty("get_Type", out JsonElement get_TypeElement) || get_TypeElement.ValueKind == JsonValueKind.Null)
                {
                    Console.WriteLine("get_Type cannot be null.");
                    return;
                }

                var response = await client.PostAsync(m_url, new StringContent(ip_data, Encoding.UTF8, "application/json"));

                string responseResult = await response.Content.ReadAsStringAsync();
                File.WriteAllText(res_file, responseResult);

                string ExpectedData = File.ReadAllText(op_flie);

                if (responseResult == ExpectedData)
                {
                    Console.WriteLine("SC003 PASS");
                }
                else
                {
                    Console.WriteLine("SC003 FAIL: ");
                }
            }
        }



        //SC004 if my input satisfyl above all conditions with wrong input it says "No data found for ur inputs"
        // if data founds res_file will be generates
        public async Task SC004()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC004_IP.json";
            string op_flie = m_ipop_data_path + "SC004_OP.json";

            string res_file = m_res_data_path + "SC004_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";

            string ip_data = File.ReadAllText(ip_file);

            var response = await client.PostAsync(m_url, new StringContent(ip_data, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            if (responseResult.Contains("\"ml_StaffAttendnce\":[]"))
            {
                Console.WriteLine("No data found for ur inputs");
            }
            else
            {
                Console.WriteLine("Successfully Generated res_file ");
                File.WriteAllText(res_file, responseResult);

            }

            string ExpectedData = File.ReadAllText(op_flie);

            if (responseResult == ExpectedData)
            {
                Console.WriteLine("SC004 PASS");
            }
            else
            {
                Console.WriteLine("SC004 FAIL: ");
            }

        }
    }
}
