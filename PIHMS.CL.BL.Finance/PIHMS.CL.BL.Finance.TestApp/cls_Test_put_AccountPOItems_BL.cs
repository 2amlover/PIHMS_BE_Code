using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

using PIHMS.CL.API.IO.Finance;
using PIHMS.CL.BL.Finance;
using System.Text.Json;

namespace PIHMS.CL.BL.Finance.TestApp
{
    internal class cls_Test_put_AccountPOItems_BL
    {
        String m_DBConnStr;
        public cls_Test_put_AccountPOItems_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001(string DataFile)
        {
            String Result = "";
            //PREPARE
            BL_Finance bl = new BL_Finance();
            String jsonData = File.ReadAllText(DataFile);
            put_AccountPOItems_IP ip = JsonSerializer.Deserialize<put_AccountPOItems_IP>(jsonData);
            ip.UserDBConnStr = m_DBConnStr;
            //ip.m_Finance.ID = 1;

            put_AccountPOItems_OP op = new put_AccountPOItems_OP();

            //RUN
            bl.put_AccountPOItems(ref ip, ref op);
            return Result;
        }

        public String SC_002(string DataFile)
        {
            String Result = "";
            //PREPARE
            BL_Finance bl = new BL_Finance();
            String jsonData = File.ReadAllText(DataFile);
            put_AccountPOItems_IP ip = JsonSerializer.Deserialize<put_AccountPOItems_IP>(jsonData);
            ip.UserDBConnStr = m_DBConnStr;
            //ip.m_Finance.ID = 1;

            put_AccountPOItems_OP op = new put_AccountPOItems_OP();

            //RUN
            bl.put_AccountPOItems(ref ip, ref op);
            return Result;
        }
    }
}