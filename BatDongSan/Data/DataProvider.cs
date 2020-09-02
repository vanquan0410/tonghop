using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataProvider
    {
        string strCon = @"Data Source=DESKTOP-VQPCJ5U\SQLEXPRESS;Initial Catalog=BatDongSan;Integrated Security=True";
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn=new SqlConnection(strCon))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
            }
            return data;
        }
        public int ExecuteUpdate(string query)
        {
            int data;
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                data = command.ExecuteNonQuery();
                conn.Close();
            }
            return data;  
        }
        public void excutenonquery(String query)
        {
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
