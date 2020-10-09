using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL
    {
        public static SqlConnection conn;
        public static void ConnectDB()
        {
            string connectstring = @"Data Source=DESKTOP-0EO86VE\SQLEXPRESS;Initial Catalog=TodoList_DB;Integrated Security=True";
            // string cnnstring = 
            //ConfigurationManager.ConnectionStrings[connectstring].ConnectionString;
            conn = new SqlConnection(connectstring);
            //conn.Open();
        }

    }
}
