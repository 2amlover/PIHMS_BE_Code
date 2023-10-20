using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

using PIHMS.CL.API.IO.DoctorConsultation;
using PIHMS.CL.BL.DoctorConsultation;
using System.Text.Json;

namespace PIHMS.CL.BL.DoctorConsultation.TestApp
{
    internal class cls_Test_put_DoctorConsultationInvreqItem_BL
    {
        String m_DBConnStr;
        public cls_Test_put_DoctorConsultationInvreqItem_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001(String DATAFILE)
        {
            String Result = "";
            //PREPARE
            BL_DoctorConsultation bl = new BL_DoctorConsultation();

            string jsondata = File.ReadAllText(DATAFILE);
            put_DoctorConsultationInvreqItem_IP ip = JsonSerializer.Deserialize<put_DoctorConsultationInvreqItem_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;


            put_DoctorConsultationInvreqItem_OP op = new put_DoctorConsultationInvreqItem_OP();

            //RUN
            bl.put_DoctorConsultationInvreqItem(ref ip, ref op);

            //VALIDATE

            return Result;
        }
        public String SC_002(String JsonFile)
        {
            String Result = "";
            //PREPARE
            BL_DoctorConsultation bl = new BL_DoctorConsultation();

            string jsondata = File.ReadAllText(JsonFile);
            put_DoctorConsultationInvreqItem_IP ip = JsonSerializer.Deserialize<put_DoctorConsultationInvreqItem_IP>(jsondata);
            ip.UserDBConnStr = m_DBConnStr;


            put_DoctorConsultationInvreqItem_OP op = new put_DoctorConsultationInvreqItem_OP();

            //RUN
            bl.put_DoctorConsultationInvreqItem(ref ip, ref op);

            //VALIDATE

            return Result;
        }
    }
}




