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
