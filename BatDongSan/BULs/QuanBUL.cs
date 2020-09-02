using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class QuanBUL
    {
        DataProvider provider = new DataProvider();

        public DataTable getListQuan(string ID_TP)
        {
            DataTable data = new DataTable();
            string query = string.Format("select * from Quan where ID_TP ={0}", ID_TP);
            data = provider.ExecuteQuery(query);
            return data;
        }
    }
}
