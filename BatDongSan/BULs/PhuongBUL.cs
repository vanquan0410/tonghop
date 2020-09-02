using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class PhuongBUL
    {
        DataProvider provider = new DataProvider();

        public DataTable getListPhuong(string ID_Q)
        {
            DataTable data = new DataTable();
            string query = string.Format("select * from Phuong where ID_Q={0}", ID_Q);
            data = provider.ExecuteQuery(query);
            return data;
        }
    }
}
