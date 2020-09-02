using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data;
using System.Data;

namespace BULs
{
    class BatDongSanBUL
    {
        DataProvider provider = new DataProvider();
        public int LayIdBatDongSan()
        {
            String sql = "select top 1 ID_BDS from BatDongSan order by ID_BDS desc";
            DataTable dt = new DataTable();
            dt = provider.ExecuteQuery(sql);
            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }
    }
}
