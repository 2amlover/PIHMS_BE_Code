using PIHMS.CL.BL.Patient;
using PIHMS.CL.API.IO.Patient;

namespace PIHMS.CL.BL.Patient.TestApp
{
    internal class cls_Test_get_PatientVisitsPrescription_BL
    {
        String m_DBConnStr;
        public cls_Test_get_PatientVisitsPrescription_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_Patient bl = new BL_Patient();

            get_PatientVisitsPrescription_IP ip = new get_PatientVisitsPrescription_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_Filter.m_Limit = "10";

            get_PatientVisitsPrescription_OP op = new get_PatientVisitsPrescription_OP();

            //RUN
            bl.get_PatientVisitsPrescription(ref ip, ref op);

            //VALIDATE
            if (op.ReturnValue == 0)
            {
                Result += "RAN SUCCESSFULLY, ";
                if (op.ml_Patient.Count == 10)
                {
                    Result += "10 ROWS FETCHED, ";
                    Result += "TEST RESULT = PASS.";
                }
                else
                {
                    Result += op.ml_Patient.Count.ToString() + " ROWS FETCHED, ";
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
