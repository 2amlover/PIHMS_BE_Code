using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PIHMS.CL.BL.Staff.TestAppApi
{
    internal class cls_Test_get_StaffList_BL
    {
        private string apiUrl = "http://ganga.pihms.co.in/Staff/get_StaffList";

        //Type 0 = get All Columns Based on ID
        public async Task SC_001()
        {
            HttpClient client = new HttpClient();
            string jsonFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\RequestBody\\get_StaffListType0.json";
            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(apiUrl, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            string responseFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\ResponseBody\\get_StaffListType0.json";
            File.WriteAllText(responseFilePath, responseResult);

            Console.WriteLine("Response Body saved as Json file.");
          
            string json = File.ReadAllText(responseFilePath);
            JObject data = JObject.Parse(json);

            JArray staff = (JArray)data["ml_StaffList"];

            int objectCount = staff.Count;
            Console.WriteLine("Number of rows: " + objectCount);
        }



        // Type  2 = get All Columns Based on CreatedDateTime
        public async Task SC_002( )
        {
            HttpClient client = new HttpClient();
            string jsonFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\RequestBody\\get_StaffListType2.json";
            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(apiUrl, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            string responseFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\ResponseBody\\get_StaffListType2.json";
            File.WriteAllText(responseFilePath, responseResult);

            Console.WriteLine("Response Body saved as Json file.");
            string json = File.ReadAllText(responseFilePath);
            JObject data = JObject.Parse(json);

            JArray staff = (JArray)data["ml_StaffList"];

            int objectCount = staff.Count;
            Console.WriteLine("Number of rows: " + objectCount);

        }

        // Type 4 =get All Columns Based on Search Text InColumns
        public async Task SC_003()
        {
            HttpClient client = new HttpClient();
            string jsonFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\RequestBody\\get_StaffListType4.json";
            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(apiUrl, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            string responseFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\ResponseBody\\get_StaffListType4.json";
            File.WriteAllText(responseFilePath, responseResult);

            Console.WriteLine("Response Body saved as Json file.");
            string json = File.ReadAllText(responseFilePath);
            JObject data = JObject.Parse(json);

            JArray staff = (JArray)data["ml_StaffList"];

            int objectCount = staff.Count;
            Console.WriteLine("Number of rows: " + objectCount);

        }


        //Type 5 = get All Columns Lastest Based on SearchLimit
        public async Task SC_004()
        {
            HttpClient client = new HttpClient();
            string jsonFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\RequestBody\\get_StaffListType5.json";
            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(apiUrl, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            string responseFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\ResponseBody\\get_StaffListType5.json";
            File.WriteAllText(responseFilePath, responseResult);

            Console.WriteLine("Response Body saved as Json file.");
            string json = File.ReadAllText(responseFilePath);
            JObject data = JObject.Parse(json);

            JArray staff = (JArray)data["ml_StaffList"];

            int objectCount = staff.Count;
            Console.WriteLine("Number of rows: " + objectCount);

        }


        //Type 6 = get All Columns Lastest Based on Where condition ID
        public async Task SC_005()
        {
            HttpClient client = new HttpClient();
            string jsonFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\RequestBody\\get_StaffListType6ID.json";
            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(apiUrl, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            string responseFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\ResponseBody\\get_StaffListType6ID.json";
            File.WriteAllText(responseFilePath, responseResult);

            Console.WriteLine("Response Body saved as Json file.");
            string json = File.ReadAllText(responseFilePath);
            JObject data = JObject.Parse(json);

            JArray staff = (JArray)data["ml_StaffList"];

            int objectCount = staff.Count;
            Console.WriteLine("Number of rows: " + objectCount);

        }


        //Type 6 = get All Columns Lastest Based on Where condition ASC
        public async Task SC_006()
        {
            HttpClient client = new HttpClient();
            string jsonFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\RequestBody\\get_StaffListType6ASC.json";
            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(apiUrl, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            string responseFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\ResponseBody\\get_StaffListType6ASC.json";
            File.WriteAllText(responseFilePath, responseResult);

            Console.WriteLine("Response Body saved as Json file.");
            string json = File.ReadAllText(responseFilePath);
            JObject data = JObject.Parse(json);

            JArray staff = (JArray)data["ml_StaffList"];

            int objectCount = staff.Count;
            Console.WriteLine("Number of rows: " + objectCount);

        }


        //Type 6 = get All Columns Lastest Based on Where condition DESC
        public async Task SC_007()
        {
            HttpClient client = new HttpClient();
            string jsonFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\RequestBody\\get_StaffListType6DESC.json";
            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(apiUrl, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            string responseFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\ResponseBody\\get_StaffListType6DESC.json";
            File.WriteAllText(responseFilePath, responseResult);

            Console.WriteLine("Response Body saved as Json file.");
            string json = File.ReadAllText(responseFilePath);
            JObject data = JObject.Parse(json);

            JArray staff = (JArray)data["ml_StaffList"];

            int objectCount = staff.Count;
            Console.WriteLine("Number of rows: " + objectCount);

        }


        //Type 6 = get All Columns Lastest Based on Where condition B/w StrDt nd EnDt
        public async Task SC_008()
        {
            HttpClient client = new HttpClient();
            string jsonFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\RequestBody\\get_StaffListType6_Bw StrDt-EnDt.json";
            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(apiUrl, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            string responseFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\ResponseBody\\get_StaffListType6_Bw StrDt-EnDt.json";
            File.WriteAllText(responseFilePath, responseResult);

            Console.WriteLine("Response Body saved as Json file.");
            string json = File.ReadAllText(responseFilePath);
            JObject data = JObject.Parse(json);

            JArray staff = (JArray)data["ml_StaffList"];

            int objectCount = staff.Count;
            Console.WriteLine("Number of rows: " + objectCount);

        }

        //Type 1 = get All Columns Bases on CreatedDateTime Options (Current Day)
        public async Task SC_009()
        {
            HttpClient client = new HttpClient();
            string jsonFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\RequestBody\\get_StaffListType1Current_Day.json";
            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(apiUrl, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            string responseFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\ResponseBody\\get_StaffListType1Current_Day.json";
            File.WriteAllText(responseFilePath, responseResult);

            Console.WriteLine("Response Body saved as Json file.");
            string json = File.ReadAllText(responseFilePath);
            JObject data = JObject.Parse(json);

            JArray staff = (JArray)data["ml_StaffList"];

            int objectCount = staff.Count;
            Console.WriteLine("Number of rows: " + objectCount);

        }

        //Type 1 = get All Columns Bases on CreatedDateTime Options (Current week)
        public async Task SC_010()
        {
            HttpClient client = new HttpClient();
            string jsonFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\RequestBody\\get_StaffListType1Current_Week.json";
            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(apiUrl, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            string responseFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\ResponseBody\\get_StaffListType1Current_Week.json";
            File.WriteAllText(responseFilePath, responseResult);

            Console.WriteLine("Response Body saved as Json file.");
            string json = File.ReadAllText(responseFilePath);
            JObject data = JObject.Parse(json);

            JArray staff = (JArray)data["ml_StaffList"];

            int objectCount = staff.Count;
            Console.WriteLine("Number of rows: " + objectCount);

        }

        //Type 1 = get All Columns Bases on CreatedDateTime Options (Current Month)
        public async Task SC_011()
        {
            HttpClient client = new HttpClient();
            string jsonFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\RequestBody\\get_StaffListType1Current_Month.json";
            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(apiUrl, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            string responseFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\ResponseBody\\get_StaffListType1Current_Month.json";
            File.WriteAllText(responseFilePath, responseResult);

            Console.WriteLine("Response Body saved as Json file.");
            string json = File.ReadAllText(responseFilePath);
            JObject data = JObject.Parse(json);

            JArray staff = (JArray)data["ml_StaffList"];

            int objectCount = staff.Count;
            Console.WriteLine("Number of rows: " + objectCount);

        }

        //Type 1 = get All Columns Bases on CreatedDateTime Options (Current Year)
        public async Task SC_012()
        {
            HttpClient client = new HttpClient();
            string jsonFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\RequestBody\\get_StaffListType1Current_Year.json";
            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(apiUrl, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            string responseFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\ResponseBody\\get_StaffListType1Current_Year.json";
            File.WriteAllText(responseFilePath, responseResult);

            Console.WriteLine("Response Body saved as Json file.");
            string json = File.ReadAllText(responseFilePath);
            JObject data = JObject.Parse(json);

            JArray staff = (JArray)data["ml_StaffList"];

            int objectCount = staff.Count;
            Console.WriteLine("Number of rows: " + objectCount);

        }


        //Type 1 = get All Columns Bases on CreatedDateTime Options (Current Quarter)
        public async Task SC_013()
        {
            HttpClient client = new HttpClient();
            string jsonFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\RequestBody\\get_StaffListType1Current_Quarter.json";
            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(apiUrl, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            string responseFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\ResponseBody\\get_StaffListType1Current_Quarter.json";
            File.WriteAllText(responseFilePath, responseResult);

            Console.WriteLine("Response Body saved as Json file.");
            string json = File.ReadAllText(responseFilePath);
            JObject data = JObject.Parse(json);

            JArray staff = (JArray)data["ml_StaffList"];

            int objectCount = staff.Count;
            Console.WriteLine("Number of rows: " + objectCount);

        }


        //Type 1 = get All Columns Bases on CreatedDateTime Options (All)
        public async Task SC_014()
        {
            HttpClient client = new HttpClient();
            string jsonFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\RequestBody\\get_StaffListType1All.json";
            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(apiUrl, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            string responseFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\ResponseBody\\get_StaffListType1All.json";
            File.WriteAllText(responseFilePath, responseResult);

            Console.WriteLine("Response Body saved as Json file.");
            string json = File.ReadAllText(responseFilePath);
            JObject data = JObject.Parse(json);

            JArray staff = (JArray)data["ml_StaffList"];

            int objectCount = staff.Count;
            Console.WriteLine("Number of rows: " + objectCount);

        }


        //Type 3 = get All Columns Bases on Search Columns
        public async Task SC_015()
        {
            HttpClient client = new HttpClient();
            string jsonFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\RequestBody\\get_StaffListType3.json";
            string jsonBody = File.ReadAllText(jsonFilePath);

            var response = await client.PostAsync(apiUrl, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            string responseResult = await response.Content.ReadAsStringAsync();

            string responseFilePath = "C:\\Users\\User\\Desktop\\PIHMS.Module.Code-master\\PIHMS.Module.Code-master\\PIHMS.CL.BL.Staff\\PIHMS.CL.BL.Staff.TestAppApi\\ResponseBody\\get_StaffListType3.json";
            File.WriteAllText(responseFilePath, responseResult);

            Console.WriteLine("Response Body saved as Json file.");
            string json = File.ReadAllText(responseFilePath);
            JObject data = JObject.Parse(json);

            JArray staff = (JArray)data["ml_StaffList"];

            int objectCount = staff.Count;
            Console.WriteLine("Number of rows: " + objectCount);

        }
    }
}


