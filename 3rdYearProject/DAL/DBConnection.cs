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

        public void CreateDatabase(List<string> details)
        {
            string query = @"Create DataBase DataFiles ON Primary(Name= " + details[0].ToString() + @", 

                                    FileName  = '" + details[1].ToString() + @".mdf',
                                    Size = " + details[2].ToString()+@"\"+details[1].ToString() + @"mb,
                                    MaxSize = UNLIMITED,
                                    FileGrowth = 10 %
                                    )
                                    Log On
                                    (
                                        Name=" + details[3].ToString()+@",
                                        FileName = '"+details[2]+@"/"+details[3].ToString()+@".ldf'
                                    )";

        }

        public bool UserLogin()
        {
            try
            {
                SqlConnection con = new SqlConnection(this.connectionString);
            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }
    }
}
