using PIHMS.CL.BL.Masters;
using PIHMS.CL.API.IO.Masters;
using System.Text.Json;

namespace PIHMS.CL.BL.Masters.TestApp
{
    internal class cls_Test_put_MasApplicationFeature_BL
    {
        String m_DBConnStr;
        public cls_Test_put_MasApplicationFeature_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001(String DATAFILE)
        {
            String Result = "";
            //PREPARE
            BL_MasAccount bl = new BL_MasAccount();

            string jsondata = File.ReadAllText(DATAFILE);
            put_MasApplicationFeature_IP ip = JsonSerializer.Deserialize<put_MasApplicationFeature_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;
           

            put_MasApplicationFeature_OP op = new put_MasApplicationFeature_OP();

            //RUN
            bl.put_MasApplicationFeature(ref ip, ref op);

            

            return Result;
        }
        public String SC_002(String DATAFILE)
        {
            String Result = "";
            //PREPARE
            BL_MasAccount bl = new BL_MasAccount();

            string jsondata = File.ReadAllText(DATAFILE);
            put_MasApplicationFeature_IP ip = JsonSerializer.Deserialize<put_MasApplicationFeature_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;


            put_MasApplicationFeature_OP op = new put_MasApplicationFeature_OP();

            //RUN
            bl.put_MasApplicationFeature(ref ip, ref op);



            return Result;
        }

    }
}




