using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data;
using DTO;
using System.Data;

namespace BULs
{
   public class UserBUS
    {

        DataProvider data = new DataProvider();

        public bool ktUser(String sdt)
        {
            String sql = "select *from userr where sdt="+sdt;
            try
            {
                DataTable dt = data.ExecuteQuery(sql);
                if (dt.Rows.Count != 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return true;
            }
                
        }

        public int LayIdUser()
        {
            String sql = "select top 1 id from userr order by id desc;";
            DataTable dt = new DataTable();
           dt = data.ExecuteQuery(sql);
            return Convert.ToInt32(dt.Rows[0][0].ToString());
            
        }

        public int LayIdUserDaTonTai(String sdt)
        {
            String sql = "select id from userr where sdt="+sdt;
            DataTable dt = new DataTable();
            dt = data.ExecuteQuery(sql);
            return Convert.ToInt32(dt.Rows[0][0].ToString());

        }

        public void themuser(userDTO user)
        {
            String sql = String.Format("insert into userr values('{0}','{1}')", user.sdt, user.name);
            data.excutenonquery(sql);
        }
    }
}
