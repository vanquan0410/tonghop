using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class ThanhPhoBUL
    {
        DataProvider provider = new DataProvider();
        public DataTable getListThanhPho()
        {
            DataTable data = new DataTable();
            string query = string.Format("select * from ThanhPho");
            data = provider.ExecuteQuery(query);
            return data;
        }
    }
}
