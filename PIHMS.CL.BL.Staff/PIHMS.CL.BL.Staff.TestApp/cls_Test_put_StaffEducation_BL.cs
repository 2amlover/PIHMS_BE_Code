﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

using PIHMS.CL.API.IO.Staff;
using PIHMS.CL.BL.Staff;
using System.Text.Json;

namespace PIHMS.CL.BL.Staff.TestApp
{
    internal class cls_Test_put_StaffEducation_BL
    {
        String m_DBConnStr;
        public cls_Test_put_StaffEducation_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001(string JsonFile)
        {
            String Result = "";
            //PREPARE
            BL_Staff bl = new BL_Staff();


            string jsondata = File.ReadAllText(JsonFile);
            put_StaffEducation_IP ip = JsonSerializer.Deserialize<put_StaffEducation_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;


            put_StaffEducation_OP op = new put_StaffEducation_OP();

            //RUN
            bl.put_StaffEducation(ref ip, ref op);

            //VALIDATE




            return Result;
        }

        public String SC_002(string JsonFile)
        {
            String Result = "";
            //PREPARE
            BL_Staff bl = new BL_Staff();


            string jsondata = File.ReadAllText(JsonFile);
            put_StaffEducation_IP ip = JsonSerializer.Deserialize<put_StaffEducation_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;


            put_StaffEducation_OP op = new put_StaffEducation_OP();

            //RUN
            bl.put_StaffEducation(ref ip, ref op);

            //VALIDATE

            return Result;
        }

    }
}


