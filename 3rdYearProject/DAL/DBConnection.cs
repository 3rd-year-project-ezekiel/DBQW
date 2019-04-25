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
        public class DatabaseConnection
        {
            public class DataHandler
            {
                private string connectionString;
                private SqlConnection connection;
                private SqlCommand command;
                private SqlDataAdapter adapter;
                private DataTable table;

                public DataHandler(string connectionStringParam = "default")
                {
                    connectionString = ConfigurationManager.ConnectionStrings[connectionStringParam].ConnectionString;
                    connection = new SqlConnection(connectionString);
                }


                public DataTable SelectAllUsers(string queryString)
                {
                    string qoute = queryString;
                    try
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }

                        command = new SqlCommand(qoute, connection);
                        adapter = new SqlDataAdapter(command);

                        table = new DataTable();
                        adapter.Fill(table);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    finally
                    {
                        connection.Close();
                    }

                    return table;
                }

                public void InsertUser(ArrayList dataToInsert)
                {
                    string storedProcedureName = "InsertUser";
                    try
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }

                        command = new SqlCommand(storedProcedureName, connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@username", dataToInsert[0]);
                        command.Parameters.Add("@password", dataToInsert[1]);


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


                public void DeleteUser(ArrayList dataToInsert)
                {
                    string storedProcedureName = "DeleteUser";
                    try
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }

                        command = new SqlCommand(storedProcedureName, connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@username", dataToInsert[0]);
                        command.Parameters.Add("@password", dataToInsert[1]);


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
            }
        }
    }
}
