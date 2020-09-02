using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
namespace BULs
{
    public class ThanhToanBUL
    {
        DataProvider data = new DataProvider();
        public void updateTinDang(int id)
        {
            String sql = "update TinDang set TTThanhToan=0 where ID_TD=" + id;
            data.excutenonquery(sql);
        }
    }
}
