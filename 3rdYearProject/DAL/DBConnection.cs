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

        public DBConnection(string connectionStringParam = "default")
        {
            this.connectionString = ConfigurationManager.ConnectionStrings[connectionStringParam].ConnectionString;
            this.connection = new SqlConnection(connectionString);
        }
        
        //public DataTable SelectQuery(string[] SearchArray, string[] TableArray, string[] WhereArray, string[] ConnectionArray = NULL)
        //        {

        //            //string query = "SELECT ";

        //            //for(i = 0, i < SearchArray.length, i++) {
        //            //    query = query + SearchArray[i];
        //            //    if(i != SearchArray.length-1) {
        //            //        query = query + ", ";
        //            //    }
        //            //} //SearchArray must contain the string variables of all things that must be searched

        //            //query = query + " FROM ";

        //            //for(i = 0, i < TableArray.length, i++) {
        //            //    query = query + TableArray[i];
        //            //    if(i != TableArray.length-1) {
        //            //        query = query + ", ";
        //            //    }
        //            //} //TableArray must contain the tables that we are selecting from

        //            //query = query + " WHERE "

        //            //if(ConnectionArray != NULL) {
        //            //    for(i = 0, i < ConnectionArray.length, i++) {
        //            //    query = query + ConnectionArray[i] + " AND ";
        //            //}//ConnectionArray contains the connection for the tablesArray
        //            //}

        //            //for(i = 0, i < WhereArray.length, i++) {
        //            //    query = query + WhereArray[i];
        //            //    if(i != WhereArray.length-1) {
        //            //        query = query + " AND ";
        //            //    }
        //            //}// WhereArray contains the where clauses at the end of the select

        //            //Example of running it

        //            // Search Array : ENum, EName, ESurname, PRating, PPrice
        //            // Table Array : EMP, PROJ
        //            // Where Array : PRating = "Important", PPrice < 50000
        //            // Connection Array: EMP.ENum = PROJ.ENum

        //            // Output predicted: SELECT ENum, EName, ESurname, PRating, PPrice FROM EMP, PROJ WHERE EMP.ENum = PROJ. ENum AND PRating = "Important" AND PPrice < 50000

        //            //This is what I think... If you can tell me if it works

        //            try
        //            {
        //                if (connection.State != ConnectionState.Open)
        //                {
        //                    connection.Open();
        //                }

        //                command = new SqlCommand(query, connection);
        //                adapter = new SqlDataAdapter(command);

        //                table = new DataTable();
        //                adapter.Fill(table);
        //            }
        //            catch (Exception)
        //            {

        //                throw;
        //            }
        //            finally
        //            {
        //                connection.Close();
        //            }

        //            return table;
        //        }

        public void SelectQuery()
        {

        }

        public void CreateDatabase(List<string> details)
        {
            string query = "Create DataBase DataFiles ON Primary(Name= " + details[0].ToString() + ", FileName  = '" + details[1].ToString() + @"\" + details[0].ToString() + ".mdf', Size = " + details[2].ToString() + @"mb,MaxSize = UNLIMITED,FileGrowth = 10 %)Log On(Name=" + details[3].ToString() + @",FileName = '" + details[1] + @"\" + details[3].ToString() + @".ldf')";
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

        public void CreateTable(List<String> tableDetails,string databaseName,string tableName)
        {
            int count = 0;
            int listLength = tableDetails.Count;
            StringBuilder query = new StringBuilder();
            query.Append("use " + databaseName);
            query.Append("Create Table " + tableName);
            query.Append("(");
            foreach (string item in tableDetails)
            {
                if (count<listLength)
                {
                    query.Append(item.ToString()+",");
                }
                else if (count==listLength)
                {
                    query.Append(item.ToString());
                }
            }
            query.Append(")");

        }

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

        public List<string> GetColumns(string databaseName, string tableName)
        {
            List<string> tables = new List<string>();
            string query = string.Format("use {0} SELECT column_name FROM information_schema.columns WHERE table_name = '{1}'",databaseName ,tableName);
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
    }
}
