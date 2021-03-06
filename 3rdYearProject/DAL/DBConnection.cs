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

//using Microsoft.Data.Schema.ScriptDom;
//using Microsoft.Data.Schema.ScriptDom.Sql;


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

        // Tests if the server name exists
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
        // Method to execute the query
        public bool QueryExecution(string query)
        {
            
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(query, connection);
                command.ExecuteReader();
            }
            catch (Exception e)
            {
                char colon = '.';
                MessageBox.Show((e.ToString().Split(colon)[3]));

                return false;
            }
            finally 
            {
                connection.Close();
            }

            return true;
        }

        // Method of creating a Database on SqlServer
        public bool CreateDatabase(List<string> details)
        {
            bool flag = true;
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
            catch (Exception e)
            {
                MessageBox.Show("This filepath has been denied, please try a diffrent one.");
                flag = false;
                
            }
            finally
            {
                connection.Close();
            }
            return flag;
        }

        // Method of creating Tables on SqlServer
        public bool CreateTable(List<String> tableDetails, string databaseName, string tableName)
        {
            bool flag = true;
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
            catch (Exception e)
            {
                char colon = '.';
                MessageBox.Show((e.ToString().Split(colon)[3]));
                flag =  false;
            }
            finally
            {
                connection.Close();
            }

            return flag;
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
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
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
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }

            return tables;
        }

        // Method of getting a list of Coloumns from specified Table from SqlServer
        public DataTable GetColumns(string databaseName, string tableName)
        {
            DataTable tables = new DataTable();
            string query = string.Format("use {0} SELECT column_name as 'Column Name', data_type as 'Data Type' FROM information_schema.columns WHERE table_name = '{1}'", databaseName, tableName);
    
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(query, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(tables);

                

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }

            return tables;
        }

        // Method of getting all data from a table in sql server
        public DataTable GetTableContents(string databaseName, string tableName)
        {
            DataTable tables = new DataTable();
            string query = string.Format("use {0} SELECT * FROM {1}", databaseName, tableName);

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(query, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(tables);



            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }

            return tables;
        }

        // if a select was run, then this method will retrive the data
        public DataTable GetSelectData(string query)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(query, connection);
                //command.ExecuteReader();

                adapter = new SqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
            }
            catch (Exception)
            {
               
            }
            finally
            {
                connection.Close();
            }
            
            return table;
        }

        #endregion

   
    }
}
