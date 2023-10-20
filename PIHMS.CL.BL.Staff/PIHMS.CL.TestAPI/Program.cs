using Microsoft.Extensions.Configuration;
using PIHMS.CL.BL.TestAPI;

namespace PIHMS.CL.TestAPI
{

    internal class Program
    {
        static async Task Main(string[] args)
        {
           

            var builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();

            //Console.WriteLine("Running UniTests for API : get_StaffList");
            string API_URL = config["TestSetting:API_URL"];
            string IPOP_DATA_PATH = config["TestSetting:IPOP_DATA_PATH"];
            string RES_DATA_PATH = config["TestSetting:RES_DATA_PATH"];


            //cls_TestAPI_get_SatffList_BL bl_get_StaffList = new cls_TestAPI_get_SatffList_BL();


            //bl_get_StaffList.m_url = API_URL+ "/get_StaffList";
            //bl_get_StaffList.m_ipop_data_path = IPOP_DATA_PATH+ "get_StaffList_Bl\\";
            //bl_get_StaffList.m_res_data_path = RES_DATA_PATH+ "get_StaffList_Bl\\";

            // await bl_get_StaffList.SC001();
            //await bl_get_StaffList.SC002();
            //await bl_get_StaffList.SC003();
            //await bl_get_StaffList.SC004();
            //await bl_get_StaffList.SC005();
            //await bl_get_StaffList.SC006();
            //await bl_get_StaffList.SC007();
            //await bl_get_StaffList.SC008();
            //await bl_get_StaffList.SC009();
            //await bl_get_StaffList.SC010();
            //await bl_get_StaffList.SC011();
            //await bl_get_StaffList.SC012();
            //await bl_get_StaffList.SC013();
            //await bl_get_StaffList.SC014();
            //await bl_get_StaffList.SC015();
            //await bl_get_StaffList.SC016();
            //await bl_get_StaffList.SC017();
            //await bl_get_StaffList.SC018();
            //await bl_get_StaffList.SC019();
            //await bl_get_StaffList.SC020();

            //Console.WriteLine("All DONE");

            //Console.WriteLine("Running UniTests for API : get_Staffdetaile");
            //cls_TestAPI_get_Satffdetaile_BL bl_get_Staffdetaile = new cls_TestAPI_get_Satffdetaile_BL();
            //bl_get_Staffdetaile.m_url = API_URL + "/get_StaffDetaile";
            //bl_get_Staffdetaile.m_ipop_data_path = IPOP_DATA_PATH + "get_StaffDetaile_BL\\";
            //bl_get_Staffdetaile.m_res_data_path = RES_DATA_PATH + "get_StaffDetaile_BL\\";
            //await bl_get_Staffdetaile.SC001();

            //Console.WriteLine("Running UniTests for API : get_StaffPayroll");
            //cls_TestAPI_get_StaffPayroll_BL bl_get_StaffPayroll = new cls_TestAPI_get_StaffPayroll_BL();
            //bl_get_StaffPayroll.m_url = API_URL + "/get_StaffPayroll";
            //bl_get_StaffPayroll.m_ipop_data_path = IPOP_DATA_PATH + "get_StaffPayroll_BL\\";
            //bl_get_StaffPayroll.m_res_data_path = RES_DATA_PATH + "get_StaffPayroll_BL\\";
            //await bl_get_StaffPayroll.SC001();

            //Console.WriteLine("Running UniTests for API : get_StaffListMaster");
            //cls_TestAPI_get_StaffListMaster_BL bl_get_StaffListMaster = new cls_TestAPI_get_StaffListMaster_BL();
            //bl_get_StaffListMaster.m_url = API_URL + "/get_StaffListMaster";
            //bl_get_StaffListMaster.m_ipop_data_path = IPOP_DATA_PATH + "get_StaffListMaster_BL\\";
            //bl_get_StaffListMaster.m_res_data_path = RES_DATA_PATH + "get_StaffListMaster_BL\\";
            //await bl_get_StaffListMaster.SC001();

            //Console.WriteLine("Running UniTests for API : get_StaffEmployment");
            //cls_TestAPI_get_StaffEmployment_BL bl_get_StaffEmployment = new cls_TestAPI_get_StaffEmployment_BL();
            //bl_get_StaffEmployment.m_url = API_URL + "/get_StaffEmployment";
            //bl_get_StaffEmployment.m_ipop_data_path = IPOP_DATA_PATH + "get_StaffEmployment_BL\\";
            //bl_get_StaffEmployment.m_res_data_path = RES_DATA_PATH + "get_StaffEmployment_BL\\";
            //await bl_get_StaffEmployment.SC001();

            //Console.WriteLine("Running UniTests for API : get_StaffDocuments");
            //cls_TestAPI_get_StaffDocument_BL bl_get_StaffDocuments = new cls_TestAPI_get_StaffDocument_BL();
            //bl_get_StaffDocuments.m_url = API_URL + "/get_StaffDocuments";
            //bl_get_StaffDocuments.m_ipop_data_path = IPOP_DATA_PATH + "get_StaffDocument_BL\\";
            //bl_get_StaffDocuments.m_res_data_path = RES_DATA_PATH + "get_StaffDocument_BL\\";
            //await bl_get_StaffDocuments.SC001();

            //Console.WriteLine("Running UniTests for API : get_StaffBankDetail");
            //cls_TestAPI_get_StaffBankDetail_BL bl_get_StaffBankDetail = new cls_TestAPI_get_StaffBankDetail_BL();
            //bl_get_StaffBankDetail.m_url = API_URL + "/get_StaffBankDetail";
            //bl_get_StaffBankDetail.m_ipop_data_path = RES_DATA_PATH + "get_StaffBankDetail_BL\\";
            //bl_get_StaffBankDetail.m_res_data_path = RES_DATA_PATH + "get_StaffBankDetail_BL\\";
            //await bl_get_StaffBankDetail.SC001();
            //await bl_get_StaffBankDetail.SC002();
            //await bl_get_StaffBankDetail.SC003();

            //Console.WriteLine("Running UniTests for API : get_StaffPaySlip");
            //cls_TestAPI_get_StaffPaySlip_BL bl_get_StaffPaySlip = new cls_TestAPI_get_StaffPaySlip_BL();
            //bl_get_StaffPaySlip.m_url = API_URL + "/get_StaffPaySlip";
            //bl_get_StaffPaySlip.m_ipop_data_path = RES_DATA_PATH + "get_StaffPaySlip_BL\\";
            //bl_get_StaffPaySlip.m_res_data_path = RES_DATA_PATH + "get_StaffPaySlip_BL\\";
            //await bl_get_StaffPaySlip.SC001();

            //Console.WriteLine("Running UniTests for API : get_StaffLeaves");
            //cls_TestAPI_get_StaffLeaves_BL bl_get_StaffLeaves = new cls_TestAPI_get_StaffLeaves_BL();
            //bl_get_StaffLeaves.m_url = API_URL + "/get_StaffLeaves";
            //bl_get_StaffLeaves.m_ipop_data_path = RES_DATA_PATH + "get_StaffLeaves_BL\\";
            //bl_get_StaffLeaves.m_res_data_path = RES_DATA_PATH + "get_StaffLeaves_BL\\";
            //await bl_get_StaffLeaves.SC001();

            Console.WriteLine("Running UniTests for API : get_StaffAttendence");
            cls_TestAPI_get_StaffAttendence_BL bl_get_StaffAttendence = new cls_TestAPI_get_StaffAttendence_BL();
            bl_get_StaffAttendence.m_url = API_URL + "/get_StaffAttendence";
            bl_get_StaffAttendence.m_ipop_data_path = RES_DATA_PATH + "get_StaffAttendence_BL\\";
            bl_get_StaffAttendence.m_res_data_path = RES_DATA_PATH + "get_StaffAttendence_BL\\";
            //await bl_get_StaffAttendence.SC001();
            //await bl_get_StaffAttendence.SC002();
            //await bl_get_StaffAttendence.SC003();
            await bl_get_StaffAttendence.SC004();

            //Console.WriteLine("Running UniTests for API : get_StaffEducation");
            //cls_TestAPI_get_StaffEducation_BL bl_get_StaffEducation = new cls_TestAPI_get_StaffEducation_BL();
            //bl_get_StaffEducation.m_url = API_URL + "/get_StaffEducation";
            //bl_get_StaffEducation.m_ipop_data_path = IPOP_DATA_PATH + "get_StaffEducation_BL\\";
            //bl_get_StaffEducation.m_res_data_path = RES_DATA_PATH + "get_StaffEducation_BL\\";
            //await bl_get_StaffEducation.SC001();
            //await bl_get_StaffEducation.SC002();
            //await bl_get_StaffEducation.SC003();







            //Console.WriteLine("Running UniTests for API : get_StaffListMaster");

            //string API_URL3 = config["TestSetting3:API_URL3"];
            //string IPOP_DATA_PATH3 = config["TestSetting3:IPOP_DATA_PATH3"];
            //string RES_DATA_PATH3 = config["TestSetting3:RES_DATA_PATH3"];

            //cls_TestAPI_get_StaffListMaster_BL bl_get_StaffListMaster = new cls_TestAPI_get_StaffListMaster_BL();

            //bl_get_StaffListMaster.m_url = API_URL3;
            //bl_get_StaffListMaster.m_ipop_data_path = IPOP_DATA_PATH3;
            //bl_get_StaffListMaster.m_res_data_path = RES_DATA_PATH3;

            //await bl_get_StaffListMaster.SC001();

            //Console.WriteLine("All DONE");




            //Console.WriteLine("Running UniTests for API : get_StaffEmployment");

            //string API_URL4 = config["TestSetting4:API_URL4"];
            //string IPOP_DATA_PATH4 = config["TestSetting4:IPOP_DATA_PATH4"];
            //string RES_DATA_PATH4 = config["TestSetting4:RES_DATA_PATH4"];

            //cls_TestAPI_get_StaffEmployment_BL bl_get_StaffEmployment = new cls_TestAPI_get_StaffEmployment_BL();

            //bl_get_StaffEmployment.m_url = API_URL4;
            //bl_get_StaffEmployment.m_ipop_data_path = IPOP_DATA_PATH4;
            //bl_get_StaffEmployment.m_res_data_path = RES_DATA_PATH4;

            //await bl_get_StaffEmployment.SC001();

            //Console.WriteLine("All DONE");




            //Console.WriteLine("Running UniTests for API : get_StaffDocuments");

            //string API_URL5 = config["TestSetting5:API_URL5"];
            //string IPOP_DATA_PATH5 = config["TestSetting5:IPOP_DATA_PATH5"];
            //string RES_DATA_PATH5 = config["TestSetting5:RES_DATA_PATH5"];

            //cls_TestAPI_get_StaffDocument_BL bl_get_StaffDocuments = new cls_TestAPI_get_StaffDocument_BL();

            //bl_get_StaffDocuments.m_url = API_URL5;
            //bl_get_StaffDocuments.m_ipop_data_path = IPOP_DATA_PATH5;
            //bl_get_StaffDocuments.m_res_data_path = RES_DATA_PATH5;

            //await bl_get_StaffDocuments.SC001();

            //Console.WriteLine("All DONE");




            //Console.WriteLine("Running UniTests for API : get_StaffBankDetail");

            //string API_URL6 = config["TestSetting6:API_URL6"];
            //string IPOP_DATA_PATH6 = config["TestSetting6:IPOP_DATA_PATH6"];
            //string RES_DATA_PATH6 = config["TestSetting6:RES_DATA_PATH6"];

            //cls_TestAPI_get_StaffBankDetail_BL bl_get_StaffBankDetail = new cls_TestAPI_get_StaffBankDetail_BL();

            //bl_get_StaffBankDetail.m_url = API_URL6;
            //bl_get_StaffBankDetail.m_ipop_data_path = IPOP_DATA_PATH6;
            //bl_get_StaffBankDetail.m_res_data_path = RES_DATA_PATH6;

            //await bl_get_StaffBankDetail.SC001();

            //Console.WriteLine("All DONE");




            //Console.WriteLine("Running UniTests for API : get_StaffPaySlip");

            //string API_URL7 = config["TestSetting7:API_URL7"];
            //string IPOP_DATA_PATH7 = config["TestSetting7:IPOP_DATA_PATH7"];
            //string RES_DATA_PATH7 = config["TestSetting7:RES_DATA_PATH7"];

            //cls_TestAPI_get_StaffPaySlip_BL bl_get_StaffPaySlip = new cls_TestAPI_get_StaffPaySlip_BL();

            //bl_get_StaffPaySlip.m_url = API_URL7;
            //bl_get_StaffPaySlip.m_ipop_data_path = IPOP_DATA_PATH7;
            //bl_get_StaffPaySlip.m_res_data_path = RES_DATA_PATH7;

            //await bl_get_StaffPaySlip.SC001();

            //Console.WriteLine("All DONE");



            //Console.WriteLine("Running UniTests for API : get_StaffLeaves");

            //string API_URL8 = config["TestSetting8:API_URL8"];
            //string IPOP_DATA_PATH8 = config["TestSetting8:IPOP_DATA_PATH8"];
            //string RES_DATA_PATH8 = config["TestSetting8:RES_DATA_PATH8"];

            //cls_TestAPI_get_StaffLeaves_BL bl_get_StaffLeaves = new cls_TestAPI_get_StaffLeaves_BL();

            //bl_get_StaffLeaves.m_url = API_URL8;
            //bl_get_StaffLeaves.m_ipop_data_path = IPOP_DATA_PATH8;
            //bl_get_StaffLeaves.m_res_data_path = RES_DATA_PATH8;

            //await bl_get_StaffLeaves.SC001();

            //Console.WriteLine("All DONE");



            //Console.WriteLine("Running UniTests for API : get_StaffAttendence");

            //string API_URL9 = config["TestSetting9:API_URL9"];
            //string IPOP_DATA_PATH9 = config["TestSetting9:IPOP_DATA_PATH9"];
            //string RES_DATA_PATH9 = config["TestSetting9:RES_DATA_PATH9"];

            //cls_TestAPI_get_StaffAttendence_BL bl_get_StaffAttendence = new cls_TestAPI_get_StaffAttendence_BL();

            //bl_get_StaffAttendence.m_url = API_URL9;
            //bl_get_StaffAttendence.m_ipop_data_path = IPOP_DATA_PATH9;
            //bl_get_StaffAttendence.m_res_data_path = RES_DATA_PATH9;

            //await bl_get_StaffAttendence.SC001();

            //Console.WriteLine("All DONE");



            //Console.WriteLine("Running UniTests for API : get_StaffEducation");

            //string API_URL10 = config["TestSetting10:API_URL10"];
            //string IPOP_DATA_PATH10 = config["TestSetting10:IPOP_DATA_PATH10"];
            //string RES_DATA_PATH10 = config["TestSetting10:RES_DATA_PATH10"];

            //cls_TestAPI_get_StaffEducation_BL bl_get_StaffEducation = new cls_TestAPI_get_StaffEducation_BL();

            //bl_get_StaffEducation.m_url = API_URL10;
            //bl_get_StaffEducation.m_ipop_data_path = IPOP_DATA_PATH10;
            //bl_get_StaffEducation.m_res_data_path = RES_DATA_PATH10;

            //await bl_get_StaffEducation.SC001();

            //Console.WriteLine("All DONE");

        }
    }
}