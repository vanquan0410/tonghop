using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Data;

namespace BULs
{
    
    public class MucTinBUS  
    {
        DataProvider data = new DataProvider();
        public DataTable hienThiMucTin(int id)
        {
            DataTable dt = new DataTable();
            String sql = "select *from MucTin where ID_LT=" + id;
            dt = data.ExecuteQuery(sql);
            return dt;
        }
    }
}
