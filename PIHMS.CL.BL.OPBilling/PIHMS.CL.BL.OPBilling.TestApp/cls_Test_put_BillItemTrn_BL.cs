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
    internal class cls_Test_put_BillItemTrn_BL
    {
        String m_DBConnStr;
        public cls_Test_put_BillItemTrn_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001(string datafile)
        {
            String Result = "";
            //PREPARE
            BL_OPBilling bl = new BL_OPBilling();

            put_BillItemTrn_IP ip = new put_BillItemTrn_IP();

            ip.UserDBConnStr = m_DBConnStr;

            put_BillItemTrn_OP op = new put_BillItemTrn_OP();

            //RUN
            bl.put_BillItemTrn(ref ip, ref op);

            return Result;
        }
        public String SC_002(string datafile)
        {
            String Result = "";
            //PREPARE
            BL_OPBilling bl = new BL_OPBilling();

            string jsondata = File.ReadAllText(datafile);
            put_BillItemTrn_IP ip = JsonSerializer.Deserialize<put_BillItemTrn_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;

            put_BillItemTrn_OP op = new put_BillItemTrn_OP();

            //RUN
            bl.put_BillItemTrn(ref ip, ref op);

            return Result;
        }
    }
}