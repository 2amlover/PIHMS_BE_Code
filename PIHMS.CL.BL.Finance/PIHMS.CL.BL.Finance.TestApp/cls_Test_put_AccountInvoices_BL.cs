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
using Microsoft.VisualBasic;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Text.Json;

namespace PIHMS.CL.BL.Finance.TestApp
{
    internal class cls_Test_put_AccountInvoices_BL
    {
        String m_DBConnStr;
        public cls_Test_put_AccountInvoices_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001(string DataFile)
        {
            String Result = "";
            //PREPARE
            BL_Finance bl = new BL_Finance();
            String jsonData = File.ReadAllText(DataFile);
            put_AccountInvoices_IP ip = JsonSerializer.Deserialize<put_AccountInvoices_IP>(jsonData);
           
            ip.UserDBConnStr = m_DBConnStr;

            put_AccountInvoices_OP op = new put_AccountInvoices_OP();

            //RUN
            bl.put_AccountInvoices(ref ip, ref op);
            
            return Result;
        }

        public String SC_002(string DataFile)
        {
            String Result = "";
            //PREPARE
            BL_Finance bl = new BL_Finance();
            String jsonData = File.ReadAllText(DataFile);
            put_AccountInvoices_IP ip = JsonSerializer.Deserialize<put_AccountInvoices_IP>(jsonData);

            ip.UserDBConnStr = m_DBConnStr;

            put_AccountInvoices_OP op = new put_AccountInvoices_OP();

            //RUN
            bl.put_AccountInvoices(ref ip, ref op);

            return Result;
        }
    }
}