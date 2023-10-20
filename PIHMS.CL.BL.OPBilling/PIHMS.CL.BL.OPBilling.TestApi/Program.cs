using PIHMS.CL.API.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace PIHMS.CL.BL.OPBilling.TestApi
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //get_OPBillList get_OPBillList = new get_OPBillList();//1
            //await get_OPBillList.OPBillList

            get_OPBillDetail get_OPBillDetail = new get_OPBillDetail();//1
            await get_OPBillDetail.OPBillDetail();

            //get_OPBillListMaster get_OPBillListMaster = new get_OPBillListMaster();
            //await get_OPBillListMaster.OPBillListMaster();
            //get_NewOPBillMaster get_NewOPBillMaster = new get_NewOPBillMaster();
            //await get_NewOPBillMaster.NewOPBillMaster();


            CreateJSONFile("OPBillDetail");
        }
        static void CreateJSONFile(string Classname)
        {
            string strJson = "";
            switch (Classname)
            {
                case "get_OPBillList":
                    get_OPBillList_IP get_OPBillList_IP = new get_OPBillList_IP();
                    strJson = JsonSerializer.Serialize<get_OPBillList_IP>(get_OPBillList_IP);
                    break;

                //case "OPBillListMaster":
                //    get_OPBillListMaster_IP get_OPBillListMaster_IP = new get_OPBillListMaster_IP();
                //    strJson = JsonSerializer.Serialize<get_OPBillListMaster_IP>(get_OPBillListMaster_IP);
                //    break;
                case "OPBillDetail":
                    get_OPBillDetail_IP get_OPBillDetail_IP = new get_OPBillDetail_IP();
                    strJson = JsonSerializer.Serialize<get_OPBillDetail_IP>(get_OPBillDetail_IP);
                    break;

                    //case "NewOPBillMaster":
                    //    get_NewOPBillMaster_IP get_NewOPBillMaster_IP = new get_NewOPBillMaster_IP();
                    //    strJson = JsonSerializer.Serialize<get_NewOPBillMaster_IP>(get_NewOPBillMaster_IP);
                    //    break;

            }
            string Filename = "..\\..\\..\\JsonFile\\" + Classname + ".json";
            File.WriteAllText(Filename, strJson);

        }
    }
}