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

namespace PIHMS.CL.BL.DoctorConsultation.TestApp
{
    internal class cls_Test_get_DoctorConsultationMedication_BL
    {
        String m_DBConnStr;
        public cls_Test_get_DoctorConsultationMedication_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_DoctorConsultation bl = new BL_DoctorConsultation();

            get_DoctorConsultationMedication_IP ip = new get_DoctorConsultationMedication_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_Filter.m_Limit = "10";

            get_DoctorConsultationMedication_OP op = new get_DoctorConsultationMedication_OP();

            //RUN
            bl.get_DoctorConsultationMedication(ref ip, ref op);

            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
                if (op.ml_DoctorConsultation.Count == 10)
                {
                    Result += "10 ROWS FETCHED, ";
                    Result += "TEST RESULT = PASS.";
                }
                else
                {
                    Result += op.ml_DoctorConsultation.Count.ToString() + " ROWS FETCHED, ";
                    Result += "TEST RESULT = WARNING.";
                }
            }

            if (op.ReturnValue > 0)
            {
                Result += "RAN WITH WARNING, ";
                Result += "WARNING MESSAGE = " + op.ReturnMessage;
            }

            if (op.ReturnValue < 0)
            {
                Result += "RAN WITH ERROR, ";
                Result += "ERROR MESSAGE = " + op.ReturnMessage;
            }

            return Result;
        }

    }
}




