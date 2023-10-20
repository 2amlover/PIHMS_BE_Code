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
using System.Security.Policy;
using System.Text.Json;

namespace PIHMS.CL.BL.OPBilling.TestApp
{
    internal class cls_Test_put_BillRefund_BL
    {
        String m_DBConnStr;
        public cls_Test_put_BillRefund_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001(string datafile)
        {
            String Result = "";
            //PREPARE
            BL_OPBilling bl = new BL_OPBilling();

            put_BillRefund_IP ip = new put_BillRefund_IP();

            ip.UserDBConnStr = m_DBConnStr;

            put_BillRefund_OP op = new put_BillRefund_OP();

            //RUN
            bl.put_BillRefund(ref ip, ref op);

            return Result;
        }
        public String SC_002(string datafile)
        {
            String Result = "";
            //PREPARE
            BL_OPBilling bl = new BL_OPBilling();

            string jsondata = File.ReadAllText(datafile);
            put_BillRefund_IP ip = JsonSerializer.Deserialize<put_BillRefund_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;

            put_BillRefund_OP op = new put_BillRefund_OP();

            //RUN
            bl.put_BillRefund(ref ip, ref op);

            return Result;
        }
    }
}