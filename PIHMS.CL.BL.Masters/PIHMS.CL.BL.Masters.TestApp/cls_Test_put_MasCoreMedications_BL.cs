﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

using PIHMS.CL.API.IO.Masters;
using PIHMS.CL.BL.Masters;
using System.Text.Json;

namespace PIHMS.CL.BL.Masters.TestApp
{
    internal class cls_Test_put_MasCoreMedications_BL
    {
        String m_DBConnStr;
        public cls_Test_put_MasCoreMedications_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001(String DATAFILE)
        {
            String Result = "";
            //PREPARE
            BL_MasAccount bl = new BL_MasAccount();

            string jsondata = File.ReadAllText(DATAFILE);
            put_MasCoreMedications_IP ip = JsonSerializer.Deserialize<put_MasCoreMedications_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;
            

            put_MasCoreMedications_OP op = new put_MasCoreMedications_OP();

            //RUN
            bl.put_MasCoreMedications(ref ip, ref op);

            //VALIDATE
            

            return Result;
        }
        public String SC_002(String DATAFILE)
        {
            String Result = "";
            //PREPARE
            BL_MasAccount bl = new BL_MasAccount();

            string jsondata = File.ReadAllText(DATAFILE);
            put_MasCoreMedications_IP ip = JsonSerializer.Deserialize<put_MasCoreMedications_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;


            put_MasCoreMedications_OP op = new put_MasCoreMedications_OP();

            //RUN
            bl.put_MasCoreMedications(ref ip, ref op);

            //VALIDATE


            return Result;
        }

    }
}




