using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;
using PIHMS.CL.API.IO.OPBilling;
using PIHMS.CL.BL.OPBilling;
using System.Text.Json;

namespace PIHMS.CL.BL.OPBilling.TestApp
{
    internal class cls_Test_put_BillItemMas_BL
    {
        String m_DBConnStr;
        public cls_Test_put_BillItemMas_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001(string datafile)
        {
            String Result = "";
            //PREPARE
            BL_OPBilling bl = new BL_OPBilling();

            put_BillItemMas_IP ip = new put_BillItemMas_IP();

            ip.UserDBConnStr = m_DBConnStr;

            put_BillItemMas_OP op = new put_BillItemMas_OP();

            //RUN
            bl.put_BillItemMas(ref ip, ref op);

            return Result;
        }
        public String SC_002(string datafile)
        {
            String Result = "";
            //PREPARE
            BL_OPBilling bl = new BL_OPBilling();

            string jsondata = File.ReadAllText(datafile);
            put_BillItemMas_IP ip = JsonSerializer.Deserialize<put_BillItemMas_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;
            put_BillItemMas_OP op = new put_BillItemMas_OP();

            //RUN
            bl.put_BillItemMas(ref ip, ref op);

            return Result;
        }
    }
}