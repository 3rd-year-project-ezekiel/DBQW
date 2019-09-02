using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace DAL
{
    public class DBConnection
    {

        #region Database Connection and Class Varibles
        private string connectionString;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataTable table;

        // Constructor
        public DBConnection(string connectionStringParam = "default")
        {
            this.connectionString = ConfigurationManager.ConnectionStrings[connectionStringParam].ConnectionString;
            this.connection = new SqlConnection(connectionString);
        }

        // 
        public bool UserLogin()
        {
            try
            {
                connection.Open();
            }
            catch (SqlException)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        #endregion

        #region Push Data into Database

        public void QueryExecution(string query)
        {
            MessageBox.Show(query);
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(query, connection);
            }
            catch (Exception)
            {
                throw;
                MessageBox.Show("hey");
            }
            finally
            {
                connection.Close();
            }

            
        }

        // Method of creating a Database on SqlServer
        public void CreateDatabase(List<string> details)
        {
            string query = "Create DataBase " + details[0].ToString() + " ON Primary(Name= " + details[0].ToString() + ", FileName  = '" + details[1].ToString() + @"\" + details[0].ToString() + ".mdf', Size = " + details[2].ToString() + @"mb,MaxSize = UNLIMITED,FileGrowth = 10 %)Log On(Name=" + details[3].ToString() + @",FileName = '" + details[1] + @"\" + details[3].ToString() + @".ldf')";
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        // Method of creating Tables on SqlServer
        public void CreateTable(List<String> tableDetails, string databaseName, string tableName)
        {
            int count = 0;
            int listLength = tableDetails.Count;
            StringBuilder query = new StringBuilder();
            query.Append("USE " + databaseName + " ");
            query.Append("CREATE TABLE " + tableName + " ");
            query.Append("(");
            foreach (string item in tableDetails)
            {
                if (count < listLength)
                {
                    query.Append(item.ToString() + ",");
                }
                else if (count == listLength)
                {
                    query.Append(item.ToString());
                }
            }
            query.Append(")");

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(query.ToString(), connection);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

        }


        #endregion

        #region Pull Data From Database
        // Method of getting a List of Databases from SqlServer
        public List<string> GetDatabases()
        {
            List<string> databases = new List<string>();
            string query = "SELECT * FROM sys.databases";
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(query, connection);
                using (IDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        databases.Add(dr[0].ToString());
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return databases;
        }

        // Method of getting a list of Tables from specified Database from SqlServer
        public List<string> GetTables(string databaseName)
        {
            List<string> tables = new List<string>();
            string query = string.Format("USE {0} SELECT TABLE_NAME FROM information_schema.tables", databaseName);
            DataSet ds = new DataSet();
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(query, connection);
                using (IDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        tables.Add(dr[0].ToString());
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return tables;
        }

        // Method of getting a list of Coloumns from specified Table from SqlServer
        public List<string> GetColumns(string databaseName, string tableName)
        {
            List<string> tables = new List<string>();
            string query = string.Format("use {0} SELECT column_name FROM information_schema.columns WHERE table_name = '{1}'", databaseName, tableName);
            DataSet ds = new DataSet();
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(query, connection);
                using (IDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        tables.Add(dr[0].ToString());
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return tables;
        }

        #endregion

   
    }
}
