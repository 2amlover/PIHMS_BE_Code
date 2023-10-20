using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIHMS.CL.API.Util.BLUtils;
using PIHMS.CL.API.IO;
using PIHMS.CL.API.IO.Masters;
using PIHMS.CL.API.Util.DBAccess;

using PIHMS.CL.DB.Table;

namespace PIHMS.CL.BL.Masters
{
    class put_MasMiscDistricts_BL : cls_BC_BusinessLogic
    {
        public put_MasMiscDistricts_BL(ref cls_Util_DBAccess dbc)
        {
            m_dbc = dbc;
        }
        public int put_MasMiscDistricts(ref put_MasMiscDistricts_IP ipdc, ref put_MasMiscDistricts_OP opdc)
        {
            if (ipdc.m_Masters.ID > 0)
            {
                //Update Existing Row

                m_rc = put_MasMiscDistricts_Update(ref ipdc, ref opdc);
                Console.WriteLine("  UPDATE EXISTING ROW SUCCESSFULLY, " + ipdc.m_Masters.ID.ToString() + "   tbl_mas_misc_districts");
            }

            else
            {
                //Insert New Row

                m_rc = put_MasMiscDistricts_Insert(ref ipdc, ref opdc);
                Console.WriteLine(" NEW ROW INSERT SUCCESSFULLY, " + ipdc.m_Masters.ID.ToString() + " tbl_mas_misc_districts");
            }
            return m_rc;
        }
        private int put_MasMiscDistricts_Update(ref put_MasMiscDistricts_IP ipdc, ref put_MasMiscDistricts_OP opdc)
        {
            m_WhereCondition = " WHERE ID = " + ipdc.m_Masters.ID.ToString();
            List<tbl_mas_misc_districts> m_MastersTemp = new List<tbl_mas_misc_districts>();
            m_rc = m_dbc.Select(ref m_ErrorMessage, m_WhereCondition, ref m_MastersTemp);

            ipdc.m_Masters.UpdatedDateTime = DateTime.Now;
            ipdc.m_Masters.CreatedDateTime = DateTime.Now;
            ipdc.m_Masters.UpdatedDateTime = DateTime.Now;
            ipdc.m_Masters.IsRowDeleted = "N";
            
            m_MastersTemp.Add(ipdc.m_Masters);
            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_MastersTemp);
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }
            opdc.m_Masters = m_MastersTemp[0];
            return m_rc;
        }

        private int put_MasMiscDistricts_Insert(ref put_MasMiscDistricts_IP ipdc, ref put_MasMiscDistricts_OP opdc)
        {
            List<tbl_mas_misc_districts> m_MastersTemp = new List<tbl_mas_misc_districts>();
            ipdc.m_Masters.CreatedDateTime = DateTime.Now;
            ipdc.m_Masters.UpdatedDateTime = DateTime.Now;
            ipdc.m_Masters.IsRowDeleted = "N";

            m_MastersTemp.Add(ipdc.m_Masters);
            m_rc = m_dbc.Save(ref m_ErrorMessage, ref m_MastersTemp);          
            if (m_rc < 0)
            {
                opdc.ReturnMessage = m_ErrorMessage;
                opdc.ReturnValue = m_rc;
                return m_rc;
            }
            opdc.m_Masters = m_MastersTemp[0];
            return m_rc;
        }
    }
}















