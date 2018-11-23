using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace QuizeSystemWindowsForms
{
    class DbConnection
    {
        public SqlConnection connection = null;
        public DbConnection()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }
        public bool OpenConnection()
        {
            connection.Open();
            if(connection!=null && connection.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CloseConnection()
        {
            connection.Close();
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                return true;
            }
            return false;
        }
    }
}
