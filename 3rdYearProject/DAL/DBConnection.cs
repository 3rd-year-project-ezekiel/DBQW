using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DBConnection
    {
        private string connectionString;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataTable table;

        public DBConnection(string connectionStringParam)
        {
            this.connectionString = connectionStringParam;
        }

        public bool UserLogin()
        {
            try
            {
                connection = new SqlConnection(this.connectionString);
            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }
    }
}
