using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Data;

namespace BULs
{
    public class LoaiTinBUL
    {
        DataProvider data = new DataProvider();

        public DataTable getLoaiTin()
        {
            DataTable da = new DataTable();
            String sql = "Select *from LoaiTin";
            da = data.ExecuteQuery(sql);
            return da;
        }
    }
}
