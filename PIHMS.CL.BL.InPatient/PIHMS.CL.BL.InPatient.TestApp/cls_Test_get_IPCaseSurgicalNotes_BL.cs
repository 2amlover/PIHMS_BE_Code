using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.Util.DBAccess;
using PIHMS.CL.DB.Table;

using PIHMS.CL.API.IO.InPatient;
using PIHMS.CL.BL.InPatient;

namespace PIHMS.CL.BL.InPatient.TestApp
{
    internal class cls_Test_get_IPCaseSurgicalNotes_BL
    {
        String m_DBConnStr;
        public cls_Test_get_IPCaseSurgicalNotes_BL(String dbCon)
        {
            m_DBConnStr = dbCon;
        }


        public String SC_001()
        {
            String Result = "";
            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPcaseSurgicalNotes_IP ip = new get_IPcaseSurgicalNotes_IP();
            ip.UserDBConnStr = m_DBConnStr;
            ip.m_IPCaseID = 6962;


            get_IPcaseSurgicalNotes_OP op = new get_IPcaseSurgicalNotes_OP();

            //RUN

            bl.get_IPcaseSurgicalNotes(ref ip, ref op);
            Console.WriteLine(op.m_IPCase.PatientID);
            //Console.WriteLine(op.ml_IPCaseSurgertnotes[0].StaffID);
            return Result;
        }



        public string SC_002()
        {
            string Result = "";

            //PREPARE
            BL_InPatient bl = new BL_InPatient();

            get_IPcaseSurgicalNotes_IP ip = new get_IPcaseSurgicalNotes_IP();
            ip.UserDBConnStr = m_DBConnStr;
            // ip.m_IPCaseID = 121;
            ip.m_IPCaseID = 11;


            get_IPcaseSurgicalNotes_OP op = new get_IPcaseSurgicalNotes_OP();

            //RUN
            bl.get_IPcaseSurgicalNotes(ref ip, ref op);

            if (op.ml_IPCaseSurgertnotes.Count > 0)
            {

                Result = "StaffID value: " + op.ml_IPCaseSurgertnotes[0].StaffID;
                for (int i = 0; i < op.ml_IPCaseSurgertnotes.Count; i++)
                {
                    Console.WriteLine(op.ml_IPCaseSurgertnotes[i].ID);
                }
            }
            else
            {

                Result = "No IPcaseSurgicalNotes found";
            }

            return Result;
        }
    }
}
