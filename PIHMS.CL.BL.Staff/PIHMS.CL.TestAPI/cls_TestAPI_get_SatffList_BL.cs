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
    public class cls_TestAPI_get_SatffList_BL
    {
        public string m_url = "";
        public string m_ipop_data_path = "";
        public string m_res_data_path = "";

        public cls_TestAPI_get_SatffList_BL()
        {

        }

        // m_type 0 get All Columns Based on ID
        public async Task SC001()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC001_IP.json";
            string op_flie = m_ipop_data_path + "SC001_OP.json";

            string res_file = m_res_data_path + "SC001_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";


            string ip_data = File.ReadAllText(ip_file);

            var response = await client.PostAsync(m_url, new StringContent(ip_data, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            if (responseResult.Contains("\"ml_StaffList\":[]"))
            {
                Console.WriteLine("Please Enter Valid Input");
            }
            else
            {
                Console.WriteLine("Successfully Generated res_file ");
                File.WriteAllText(res_file, responseResult);
            }

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


        // m_type 1 get All Columns Bases on CreatedDateTime Option Current Day 
        public async Task SC002()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC002_IP.json";
            string op_flie = m_ipop_data_path + "SC002_OP.json";

            string res_file = m_res_data_path + "SC002_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";


            string ip_data = File.ReadAllText(ip_file);

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
                Console.WriteLine("SC002 FAIL");
            }

        }

        // m_type 1 get All Columns Bases on CreatedDateTime Option Current Week
        public async Task SC003()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC003_IP.json";
            string op_flie = m_ipop_data_path + "SC003_OP.json";

            string res_file = m_res_data_path + "SC003_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";


            string ip_data = File.ReadAllText(ip_file);

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
                Console.WriteLine("SC003 FAIL");
            }

        }


        // m_type 1 get All Columns Bases on CreatedDateTime Option Current Month 
        public async Task SC004()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC004_IP.json";
            string op_flie = m_ipop_data_path + "SC004_OP.json";

            string res_file = m_res_data_path + "SC004_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";


            string ip_data = File.ReadAllText(ip_file);

            var response = await client.PostAsync(m_url, new StringContent(ip_data, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            File.WriteAllText(res_file, responseResult);

            string ExpectedData = File.ReadAllText(op_flie);

            if (responseResult == ExpectedData)
            {
                Console.WriteLine("SC004 PASS");
            }
            else
            {
                Console.WriteLine("SC004 FAIL");
            }

        }

        // m_type 1 get All Columns Bases on CreatedDateTime Option Current Quarter 
        public async Task SC005()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC005_IP.json";
            string op_flie = m_ipop_data_path + "SC005_OP.json";

            string res_file = m_res_data_path + "SC005_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";


            string ip_data = File.ReadAllText(ip_file);

            var response = await client.PostAsync(m_url, new StringContent(ip_data, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            File.WriteAllText(res_file, responseResult);

            string ExpectedData = File.ReadAllText(op_flie);

            if (responseResult == ExpectedData)
            {
                Console.WriteLine("SC005 PASS");
            }
            else
            {
                Console.WriteLine("SC005 FAIL");
            }

        }

        // m_type 1 get All Columns Bases on CreatedDateTime Option Current Year 
        public async Task SC006()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC006_IP.json";
            string op_flie = m_ipop_data_path + "SC006_OP.json";

            string res_file = m_res_data_path + "SC006_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";


            string ip_data = File.ReadAllText(ip_file);

            var response = await client.PostAsync(m_url, new StringContent(ip_data, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            File.WriteAllText(res_file, responseResult);

            string ExpectedData = File.ReadAllText(op_flie);

            if (responseResult == ExpectedData)
            {
                Console.WriteLine("SC006 PASS");
            }
            else
            {
                Console.WriteLine("SC006 FAIL");
            }

        }

        // m_type 1  get All Columns Bases on CreatedDateTime Option All
        public async Task SC007()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC007_IP.json";
            string op_flie = m_ipop_data_path + "SC007_OP.json";

            string res_file = m_res_data_path + "SC007_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";


            string ip_data = File.ReadAllText(ip_file);

            var response = await client.PostAsync(m_url, new StringContent(ip_data, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            File.WriteAllText(res_file, responseResult);

            string ExpectedData = File.ReadAllText(op_flie);

            if (responseResult == ExpectedData)
            {
                Console.WriteLine("SC007 PASS");
            }
            else
            {
                Console.WriteLine("SC007 FAIL");
            }

        }

        // m_type 2  get All Columns Based on CreatedDateTime DateRange (m_StartDate, m_EndDate)
        public async Task SC008()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC008_IP.json";
            string op_flie = m_ipop_data_path + "SC008_OP.json";

            string res_file = m_res_data_path + "SC008_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";


            string ip_data = File.ReadAllText(ip_file);

            var response = await client.PostAsync(m_url, new StringContent(ip_data, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            File.WriteAllText(res_file, responseResult);

            string ExpectedData = File.ReadAllText(op_flie);

            if (responseResult == ExpectedData)
            {
                Console.WriteLine("SC008 PASS");
            }
            else
            {
                Console.WriteLine("SC008 FAIL");
            }

        }

        // m_type 3 get All Columns Based on Search Text 
        public async Task SC009()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC009_IP.json";
            string op_flie = m_ipop_data_path + "SC009_OP.json";

            string res_file = m_res_data_path + "SC009_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";


            string ip_data = File.ReadAllText(ip_file);

            var response = await client.PostAsync(m_url, new StringContent(ip_data, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            File.WriteAllText(res_file, responseResult);

            string ExpectedData = File.ReadAllText(op_flie);

            if (responseResult == ExpectedData)
            {
                Console.WriteLine("SC009 PASS");
            }
            else
            {
                Console.WriteLine("SC009 FAIL");
            }

        }

        // m_type 4 get All Columns Based on Search Text InColumns 
        public async Task SC010()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC010_IP.json";
            string op_flie = m_ipop_data_path + "SC010_OP.json";

            string res_file = m_res_data_path + "SC010_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";


            string ip_data = File.ReadAllText(ip_file);

            var response = await client.PostAsync(m_url, new StringContent(ip_data, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            File.WriteAllText(res_file, responseResult);

            
            string ExpectedData = File.ReadAllText(op_flie);

            if (responseResult == ExpectedData)
            {
                Console.WriteLine("SC010 PASS");
            }
            else
            {
                Console.WriteLine("SC010 FAIL");
            }

        }

        // m_type 5 get All Columns Lastest Based on SearchLimit 
        public async Task SC011()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC011_IP.json";
            string op_flie = m_ipop_data_path + "SC011_OP.json";

            string res_file = m_res_data_path + "SC011_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";


            string ip_data = File.ReadAllText(ip_file);

            var response = await client.PostAsync(m_url, new StringContent(ip_data, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            File.WriteAllText(res_file, responseResult);


            string ExpectedData = File.ReadAllText(op_flie);

            if (responseResult == ExpectedData)
            {
                Console.WriteLine("SC011 PASS");
            }
            else
            {
                Console.WriteLine("SC011 FAIL");
            }

        }


        // m_type 6 get All Columns Based on Where Condition ID 
        public async Task SC012()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC012_IP.json";
            string op_flie = m_ipop_data_path + "SC012_OP.json";

            string res_file = m_res_data_path + "SC012_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";


            string ip_data = File.ReadAllText(ip_file);

            var response = await client.PostAsync(m_url, new StringContent(ip_data, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            File.WriteAllText(res_file, responseResult);


            string ExpectedData = File.ReadAllText(op_flie);

            if (responseResult == ExpectedData)
            {
                Console.WriteLine("SC012 PASS");
            }
            else
            {
                Console.WriteLine("SC012 FAIL");
            }

        }


        public async Task SC013()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC013_IP.json";
            string op_flie = m_ipop_data_path + "SC013_OP.json";

            string res_file = m_res_data_path + "SC013_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";


            string ip_data = File.ReadAllText(ip_file);

            var response = await client.PostAsync(m_url, new StringContent(ip_data, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            File.WriteAllText(res_file, responseResult);


            string ExpectedData = File.ReadAllText(op_flie);

            if (responseResult == ExpectedData)
            {
                Console.WriteLine("SC013 : m_type 6 get All Columns Based on Where Condition ORDER BY id DESC : PASS");
            }
            else
            {
                Console.WriteLine("SC013 FAIL");
            }

        }


        public async Task SC014()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC014_IP.json";
            string op_flie = m_ipop_data_path + "SC014_OP.json";

            string res_file = m_res_data_path + "SC014_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";


            string ip_data = File.ReadAllText(ip_file);

            var response = await client.PostAsync(m_url, new StringContent(ip_data, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            File.WriteAllText(res_file, responseResult);


            string ExpectedData = File.ReadAllText(op_flie);

            if (responseResult == ExpectedData)
            {
                Console.WriteLine("SC014 : m_type 6 get All Columns Based on Where Condition ORDER BY id ASC : PASS");
            }
            else
            {
                Console.WriteLine("SC014 FAIL");
            }

        }


        public async Task SC015()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC015_IP.json";
            string op_flie = m_ipop_data_path + "SC015_OP.json";

            string res_file = m_res_data_path + "SC015_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";


            string ip_data = File.ReadAllText(ip_file);

            var response = await client.PostAsync(m_url, new StringContent(ip_data, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            File.WriteAllText(res_file, responseResult);


            string ExpectedData = File.ReadAllText(op_flie);

            if (responseResult == ExpectedData)
            {
                Console.WriteLine("SC015 : m_type 6 get All Columns Based on Where Condition Between CrDtStart and CrDtEnd : PASS");
            }
            else
            {
                Console.WriteLine("SC015 FAIL");
            }

        }


        public async Task SC016()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC016_IP.json";
            string op_flie = m_ipop_data_path + "SC016_OP.json";

            string res_file = m_res_data_path + "SC016_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";


            string ip_data = File.ReadAllText(ip_file);

            var response = await client.PostAsync(m_url, new StringContent(ip_data, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            File.WriteAllText(res_file, responseResult);


            string ExpectedData = File.ReadAllText(op_flie);

            if (responseResult == ExpectedData)
            {
                Console.WriteLine("SC016 : m_type 6 get All Columns  Based on Where condition Dr. : PASS");
            }
            else
            {
                Console.WriteLine("SC016 FAIL");
            }

        }


        public async Task SC017()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC017_IP.json";
            string op_flie = m_ipop_data_path + "SC017_OP.json";

            string res_file = m_res_data_path + "SC017_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";


            string ip_data = File.ReadAllText(ip_file);

            var response = await client.PostAsync(m_url, new StringContent(ip_data, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            File.WriteAllText(res_file, responseResult);


            string ExpectedData = File.ReadAllText(op_flie);

            if (responseResult == ExpectedData)
            {
                Console.WriteLine("SC017 : m_type 6 get All Columns  Based on Where condition Dr. and Gender  : PASS");
            }
            else
            {
                Console.WriteLine("SC017 FAIL");
            }

        }


        public async Task SC018()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC018_IP.json";
            string op_flie = m_ipop_data_path + "SC018_OP.json";

            string res_file = m_res_data_path + "SC018_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";


            string ip_data = File.ReadAllText(ip_file);

            var response = await client.PostAsync(m_url, new StringContent(ip_data, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            File.WriteAllText(res_file, responseResult);


            string ExpectedData = File.ReadAllText(op_flie);

            if (responseResult == ExpectedData)
            {
                Console.WriteLine("SC018 : m_type 6 get All Columns  Based on Where condition IsRowDeleted  : PASS");
            }
            else
            {
                Console.WriteLine("SC018 FAIL");
            }

        }


        public async Task SC019()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC019_IP.json";
            string op_flie = m_ipop_data_path + "SC019_OP.json";

            string res_file = m_res_data_path + "SC019_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";


            string ip_data = File.ReadAllText(ip_file);

            var response = await client.PostAsync(m_url, new StringContent(ip_data, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            File.WriteAllText(res_file, responseResult);


            string ExpectedData = File.ReadAllText(op_flie);

            if (responseResult == ExpectedData)
            {
                Console.WriteLine("SC019 : m_type 6 get All Columns  Based on Where condition MaritalStatus = 'Single' : PASS");
            }
            else
            {
                Console.WriteLine("SC019 FAIL");
            }

        }



        public async Task SC020()
        {
            HttpClient client = new HttpClient();

            string ip_file = m_ipop_data_path + "SC020_IP.json";
            string op_flie = m_ipop_data_path + "SC020_OP.json";

            string res_file = m_res_data_path + "SC020_RES_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".json";


            string ip_data = File.ReadAllText(ip_file);

            var response = await client.PostAsync(m_url, new StringContent(ip_data, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            File.WriteAllText(res_file, responseResult);


            string ExpectedData = File.ReadAllText(op_flie);

            if (responseResult == ExpectedData)
            {
                Console.WriteLine("SC020 : m_type 6 get All Columns  Based on Where condition MaritalStatus = 'Married' : PASS");
            }
            else
            {
                Console.WriteLine("SC020 FAIL");
            }

        }
    }
}
