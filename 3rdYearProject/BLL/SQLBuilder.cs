using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace BLL
{
    public class SQLBuilder
    {
        #region Fields
        private List<string> sqlBuilderLIst;
        // This list will contain the Sql Query while the user builds it
        // every time the query is modified, sqlBuilderLIst will change and then from there the changes will be distributed
        #endregion

        #region Constructor
        public SQLBuilder()
        { sqlBuilderLIst = new List<string>(); }
        // When the class is first called, a new list will be created to hold the new Query
        #endregion

        #region Algorithm
        // This region contains all the functions that will modify the query

        #region Database
        // Database add + change
        public List<string> DatabaseBaseBuilder(string dataBaseName)
        {
            if (sqlBuilderLIst.Count == 0)      // if no database has been selected
            { sqlBuilderLIst.Add("USE " + dataBaseName); sqlBuilderLIst.Add("GO"); }   // add a database
            else
            if (sqlBuilderLIst.Count > 0)     // if a database was already selected
            {
                    sqlBuilderLIst.Clear();     // clear query
                    sqlBuilderLIst.Add("USE " + dataBaseName);    // add new database
                    sqlBuilderLIst.Add("GO");
            }
            return sqlBuilderLIst;
        }

        #endregion
       
        #region Procedure
        // Procedure base add and remove
        public List<string> ProcedureBaseBuilder()
        {

            try
            {
                if ((sqlBuilderLIst[2])[0] == 'C' && (sqlBuilderLIst[2])[7] == 'P')
                {
                    sqlBuilderLIst.RemoveRange(2, 4);
                    sqlBuilderLIst.RemoveRange(sqlBuilderLIst.Count - 1, 1);
                }
                else
                {
                    sqlBuilderLIst[sqlBuilderLIst.Count] = "";
                }
            }
            catch (Exception)
            {
                try
                {
                    List<string> tempList = new List<string>();

                    for (int i = 2; i < sqlBuilderLIst.Count; i++)
                    {
                        tempList.Add(sqlBuilderLIst[i]);
                    }
                    sqlBuilderLIst.RemoveRange(2, sqlBuilderLIst.Count - 2);
                    sqlBuilderLIst.Add("CREATE PROCEDURE testtest");
                    sqlBuilderLIst.Add("()");
                    sqlBuilderLIst.Add("AS");
                    sqlBuilderLIst.Add("BEGIN");
                    sqlBuilderLIst.AddRange(tempList);
                    
                }
                catch (Exception)
                {
                    sqlBuilderLIst.Add("CREATE PROCEDURE testtest");
                    sqlBuilderLIst.Add("()");
                    sqlBuilderLIst.Add("AS");
                    sqlBuilderLIst.Add("BEGIN");
                }
                sqlBuilderLIst.Add("END");

            }

            return sqlBuilderLIst;
        }

        // Add a varible to Procedure
        public List<string> ProcedureAddVaribles(string varible)
        {
            sqlBuilderLIst[3].Replace(')', ',');
            sqlBuilderLIst[3] += varible + ")";
            return sqlBuilderLIst;
        }

        // Remove a Varible From Procedure
        public List<string> ProcedureRemoveVarible(string varible)
        {
            List<string> theList = sqlBuilderLIst[3].Replace(')', ',').Replace('(', ',').Split(',').ToList(); // replaces the brackets with colons then splited on the colons
            theList.Remove(varible);                                                                          // if there is somthing to remove, the first sighting of the will be removed
            sqlBuilderLIst[3] = "(" + ListToString(theList) + ")";                                           // adds whats left back to sql
            return sqlBuilderLIst;
        }

        // Adds or changes the procedureName
        public List<String> ProcedureNameChange(string varible)
        {

            return sqlBuilderLIst; 
        }
        #endregion

        #region Views
        public List<string> ViewBaseBuilder(string tableName = "")
        {

            try
            {
                if ((sqlBuilderLIst[2])[0] == 'C' && (sqlBuilderLIst[2])[7] == 'P')
                {
                    sqlBuilderLIst.RemoveAt(sqlBuilderLIst.Count - 1);
                    if (sqlBuilderLIst.Count > 5)
                        sqlBuilderLIst.RemoveRange(6, (sqlBuilderLIst.Count - 6));
                    sqlBuilderLIst.Add("CREATE VIEW >Enter Name< AS");
                    sqlBuilderLIst.Add("SELECT ");
                    sqlBuilderLIst.Add("FROM ");
                    if (tableName != "")
                        sqlBuilderLIst[sqlBuilderLIst.Count - 1] += tableName;
                    sqlBuilderLIst.Add("END");

                }
                else
                {
                    sqlBuilderLIst[sqlBuilderLIst.Count] = "";
                }
            }
            catch (Exception)
            {
                if (sqlBuilderLIst.Count > 2)
                    sqlBuilderLIst.RemoveRange(2, (sqlBuilderLIst.Count - 2));
                sqlBuilderLIst.Add("CREATE VIEW >Enter Name< AS");
                sqlBuilderLIst.Add("SELECT ");
                sqlBuilderLIst.Add("FROM ");
                if (tableName != "")
                    sqlBuilderLIst[sqlBuilderLIst.Count - 1] += tableName;

            }

            return sqlBuilderLIst;
        }

        #endregion

        #region Insert
        // Insert base + table + changes to them
        public List<string> InsertBaseBuilder(string tableName = "")
        {

            try
            {
                if ((sqlBuilderLIst[2])[0] == 'C' && (sqlBuilderLIst[2])[7] == 'P')
                {
                    sqlBuilderLIst.RemoveAt(sqlBuilderLIst.Count - 1);
                    if (sqlBuilderLIst.Count > 5)
                        sqlBuilderLIst.RemoveRange(6, (sqlBuilderLIst.Count - 6));

                    sqlBuilderLIst.Add("INSERT INTO ");
                    if (tableName != "")
                        sqlBuilderLIst[sqlBuilderLIst.Count - 1] += tableName;
                    sqlBuilderLIst.Add("VALUES ");
                    sqlBuilderLIst.Add("END");

                }
                else
                {
                    sqlBuilderLIst[sqlBuilderLIst.Count] = "";
                }
            }
            catch (Exception)
            {
                if (sqlBuilderLIst.Count > 2)
                    sqlBuilderLIst.RemoveRange(2, (sqlBuilderLIst.Count - 2));

                sqlBuilderLIst.Add("INSERT INTO ");
                if (tableName != "")
                    sqlBuilderLIst[sqlBuilderLIst.Count - 1] += tableName;
                sqlBuilderLIst.Add("VALUES ");

            }
           
            return sqlBuilderLIst;
        }

        public List<string> InsertValue(string Column, string value)
        {

            int insertLine = 0;
            int valueline = 0;

            try
            {
                if ((sqlBuilderLIst[2])[0] == 'C' && (sqlBuilderLIst[2])[7] == 'P')
                {
                    insertLine = 6;
                    valueline = 7;
                }
                else
                {
                    sqlBuilderLIst[sqlBuilderLIst.Count] = "";
                }
            }
            catch (Exception)
            {
                insertLine = 2;
                valueline = 3;

            }

            List<string> theColumnList = sqlBuilderLIst[insertLine].Split('(').ToList();
            List<string> theValueList = sqlBuilderLIst[valueline].Split('(').ToList();
            if (theColumnList.Count == 1)
            {
                sqlBuilderLIst[insertLine] += " (" + Column + ")";
                sqlBuilderLIst[valueline] += " (" + value + ")";
            }
            else
            {
                string lineHolder = theColumnList[0];
                string listholder = "";
                theColumnList = theColumnList[1].Split(',').ToList();
                foreach (string item in theColumnList)
                {
                    listholder += ','+item;
                }
                sqlBuilderLIst[insertLine] = lineHolder + " (" + Column + listholder;

                lineHolder = theValueList[0];
                listholder = "";
                theValueList = theValueList[1].Split(',').ToList();
                foreach (string item in theValueList)
                {
                    listholder += ','+item;
                }
                sqlBuilderLIst[valueline] = lineHolder + " (" + value + listholder;
            }

            return sqlBuilderLIst;
        }

        public List<string> InsertRemoveValue(string Column, string value)
        {
            int insertLine = 0;
            int valueline = 0;

            try
            {
                if ((sqlBuilderLIst[2])[0] == 'C' && (sqlBuilderLIst[2])[7] == 'P')
                {
                    insertLine = 6;
                    valueline = 7;
                }
                else
                {
                    sqlBuilderLIst[sqlBuilderLIst.Count] = "";
                }
            }
            catch (Exception)
            {
                insertLine = 2;
                valueline = 3;

            }
            List<string> theInsertLineList = sqlBuilderLIst[insertLine].Split('(').ToList();
            List<string> theValueLineList = sqlBuilderLIst[valueline].Split('(').ToList();

            List<string> columnList = theInsertLineList[1].Split(',').ToList();
            columnList[columnList.Count - 1] = columnList[columnList.Count - 1].Substring(0, columnList[columnList.Count - 1].IndexOf(')'));
            List<string> valueList = theValueLineList[1].Split(',').ToList();
            valueList[valueList.Count - 1] = valueList[valueList.Count - 1].Substring(0, valueList[valueList.Count - 1].IndexOf(')'));

            columnList.Remove(Column);
            valueList.Remove(value);

            sqlBuilderLIst[insertLine] = theInsertLineList[0];
            sqlBuilderLIst[valueline] = theValueLineList[0];

            if (columnList.Count != 0)
            {
                sqlBuilderLIst[insertLine] += '(' + ListToString(columnList) + ')';
                sqlBuilderLIst[valueline] += '(' + ListToString(valueList) + ')';
            }
            
            return sqlBuilderLIst;
        }
        #endregion

        #region Delete
        // Delete base + table + changes to them
        public List<string> DeleteBaseBuilder(string tableName = "")
        {

            try
            {
                if ((sqlBuilderLIst[2])[0] == 'C' && (sqlBuilderLIst[2])[7] == 'P')
                {
                    sqlBuilderLIst.RemoveAt(sqlBuilderLIst.Count - 1);
                    if (sqlBuilderLIst.Count > 5)
                        sqlBuilderLIst.RemoveRange(6, (sqlBuilderLIst.Count - 6));

                    sqlBuilderLIst.Add("DELETE FROM ");
                    if (tableName != "")
                        sqlBuilderLIst[sqlBuilderLIst.Count - 1] += tableName;
                    sqlBuilderLIst.Add("END");

                }
                else
                {
                    sqlBuilderLIst[sqlBuilderLIst.Count] = "";
                }
            }
            catch (Exception)
            {
                if (sqlBuilderLIst.Count > 2)
                    sqlBuilderLIst.RemoveRange(2, (sqlBuilderLIst.Count - 2));

                sqlBuilderLIst.Add("DELETE FROM ");
                if (tableName != "")
                    sqlBuilderLIst[sqlBuilderLIst.Count - 1] += tableName;

            }

            return sqlBuilderLIst;
        }

        #endregion

        #region Update
        // Update base + table + changes to them
        public List<string> UpdateBaseBuilder(string tableName = "")
        {

            try
            {
                if ((sqlBuilderLIst[2])[0] == 'C' && (sqlBuilderLIst[2])[7] == 'P')
                {
                    sqlBuilderLIst.RemoveAt(sqlBuilderLIst.Count - 1);
                    if (sqlBuilderLIst.Count > 5)
                        sqlBuilderLIst.RemoveRange(6, (sqlBuilderLIst.Count - 6));

                    sqlBuilderLIst.Add("UPDATE ");
                    if (tableName != "")
                        sqlBuilderLIst[sqlBuilderLIst.Count - 1] += tableName;
                    sqlBuilderLIst.Add("SET");
                    sqlBuilderLIst.Add("END");

                }
                else
                {
                    sqlBuilderLIst[sqlBuilderLIst.Count] = "";
                }
            }
            catch (Exception)
            {
                if (sqlBuilderLIst.Count > 2)
                    sqlBuilderLIst.RemoveRange(2, (sqlBuilderLIst.Count - 2));

                sqlBuilderLIst.Add("UPDATE ");
                if (tableName != "")
                    sqlBuilderLIst[sqlBuilderLIst.Count - 1] += tableName;
                sqlBuilderLIst.Add("SET");

            }

            return sqlBuilderLIst;
        }

        public List<string> UpdateSet(string ColumnAndValue)
        {


            int setLine = 0;

            try
            {
                if ((sqlBuilderLIst[2])[0] == 'C' && (sqlBuilderLIst[2])[7] == 'P')
                {
                    setLine = 7;
                }
                else
                {
                    sqlBuilderLIst[sqlBuilderLIst.Count] = "";
                }
            }
            catch (Exception)
            {
                setLine = 3;

            }

            char[] test = new char[1] { ' ' };
            List<string> theList = sqlBuilderLIst[setLine].Split(test,2).ToList();
            if (theList.Count == 1 || theList[1] == "")
            {
                sqlBuilderLIst[setLine] += " " + ColumnAndValue;
            }
            else
            {
                string lineHolder = theList[0];
                string listholder = "";
                theList = theList[1].Split(',').ToList();
                foreach (string item in theList)
                {
                    listholder +=  item + ',';
                }
                sqlBuilderLIst[setLine] = lineHolder + " " + listholder + ColumnAndValue;
            }

            return sqlBuilderLIst;
        }

        public List<string> UpdateRemoveSet(string ColumnAndValue)
        {
            int setLine = 0;

            try
            {
                if ((sqlBuilderLIst[2])[0] == 'C' && (sqlBuilderLIst[2])[7] == 'P')
                {
                    setLine = 7;
                }
                else
                {
                    sqlBuilderLIst[sqlBuilderLIst.Count] = "";
                }
            }
            catch (Exception)
            {
                setLine = 3;
            }
            char[] test = new char[1] { ' ' };
            List<string> theList = sqlBuilderLIst[setLine].Split(test, 2).ToList();
            
            List<string> valueList = theList[1].Split(',').ToList();
            valueList.Remove(ColumnAndValue);

            sqlBuilderLIst[setLine] = theList[0];

            if (valueList.Count != 0)
            {
                sqlBuilderLIst[setLine] += ' ' + ListToString(valueList) ;
            }

            return sqlBuilderLIst;

        }

        #endregion

        #region Select
        // Select base + table + changes to them
        public List<string> SelectBaseBuilder(string tableName = "")
        {

            try
            {
                if ((sqlBuilderLIst[2])[0] == 'C' && (sqlBuilderLIst[2])[7] == 'P')
                {
                    sqlBuilderLIst.RemoveAt(sqlBuilderLIst.Count - 1);
                    if (sqlBuilderLIst.Count > 5)
                        sqlBuilderLIst.RemoveRange(6, (sqlBuilderLIst.Count - 6));

                    sqlBuilderLIst.Add("SELECT *");
                    sqlBuilderLIst.Add("FROM ");
                    if (tableName != "")
                        sqlBuilderLIst[sqlBuilderLIst.Count - 1] += tableName;
                    sqlBuilderLIst.Add("END");

                }
                else
                {
                    sqlBuilderLIst[sqlBuilderLIst.Count] = "";
                }
            }
            catch (Exception)
            {
                if (sqlBuilderLIst.Count > 2)
                    sqlBuilderLIst.RemoveRange(2, (sqlBuilderLIst.Count - 2));

                sqlBuilderLIst.Add("SELECT ");
                sqlBuilderLIst.Add("FROM ");
                if (tableName != "")
                    sqlBuilderLIst[sqlBuilderLIst.Count - 1] += tableName;

            }

            return sqlBuilderLIst;
        }

        #endregion

        #region Where
        public List<string> WhereClauseBuilder(string whereClause)
        {
            whereClause = "(" + whereClause + ")";
            // Checks to see if there is a where already
            for (int index = 3; index < sqlBuilderLIst.Count; index++)
            {
                if ((sqlBuilderLIst[index])[0] == 'W')
                {
                    string tempHolder = sqlBuilderLIst[index];
                    sqlBuilderLIst[index] = tempHolder + "AND" + whereClause;
                    return sqlBuilderLIst;
                }
            }

            if ((sqlBuilderLIst[2])[0] == 'C' && (sqlBuilderLIst[2])[7] == 'P')
            {
                sqlBuilderLIst[sqlBuilderLIst.Count - 1] = "WHERE" + whereClause;
                sqlBuilderLIst.Add("END");
            }
            else
            {
                sqlBuilderLIst.Add("WHERE" + whereClause);
            }


            return sqlBuilderLIst;

        }

        public List<string> WhereClauseRemover(string whereClause)
        {
            // Finds Where's position
            for (int index = 3; index < sqlBuilderLIst.Count; index++)
            {
                if ((sqlBuilderLIst[index])[0] == 'W')
                {
                    List<string> tempHolder = sqlBuilderLIst[index].Split('(').ToList();


                    for (int i = 1; i < tempHolder.Count; i++)
                    {
                        string tempClause = tempHolder[i].Substring(0, tempHolder[i].IndexOf(')'));
                        if (tempClause == whereClause)
                        {
                            tempHolder.RemoveAt(i);

                            if (tempHolder.Count > 1)
                            {
                                string holder = "";
                                foreach (string item in tempHolder)
                                {
                                    holder += item+"(";
                                }
                                sqlBuilderLIst[index] = holder.Substring(0, holder.LastIndexOf(')') + 1);
                            }
                            else
                            {
                                sqlBuilderLIst.RemoveAt(index);
                            }

                            return sqlBuilderLIst;
                        }
                    }
                }
            }

            return sqlBuilderLIst;
        }
        #endregion

        #region Having
        public List<string> HavingClauseBuilder(string havingClause)
        {
            havingClause = "(" + havingClause + ")";
            // Checks to see if there is a where already
            for (int index = 3; index < sqlBuilderLIst.Count; index++)
            {
                if ((sqlBuilderLIst[index])[0] == 'H')
                {
                    string tempHolder = sqlBuilderLIst[index];
                    sqlBuilderLIst[index] = tempHolder + "AND" + havingClause;
                    return sqlBuilderLIst;
                }
            }

            if ((sqlBuilderLIst[2])[0] == 'C' && (sqlBuilderLIst[2])[7] == 'P')
            {
                sqlBuilderLIst[sqlBuilderLIst.Count - 1] = "HAVING" + havingClause;
                sqlBuilderLIst.Add("END");
            }
            else
            {
                sqlBuilderLIst.Add("HAVING" + havingClause);
            }


            return sqlBuilderLIst;

        }

        public List<string> HavingClauseRemover(string havingClause)
        {
            // Finds Where's position
            for (int index = 3; index < sqlBuilderLIst.Count; index++)
            {
                if ((sqlBuilderLIst[index])[0] == 'H')
                {
                    string[] temp = sqlBuilderLIst[index].Split('(');
                    List<string> tempHolder = temp.ToList();

                    for (int i = 1; i < tempHolder.Count; i++)
                    {
                        string tempClause = tempHolder[i].Substring(0, tempHolder[i].IndexOf(')'));
                        if (tempClause == havingClause)
                        {
                            tempHolder.RemoveAt(i);

                            if (tempHolder.Count > 1)
                            {
                                string holder = "";
                                foreach (string item in tempHolder)
                                {
                                    holder += item + "(";
                                }
                                sqlBuilderLIst[index] = holder.Substring(0, holder.LastIndexOf(')') + 1);
                            }
                            else
                            {
                                sqlBuilderLIst.RemoveAt(index);
                            }

                            return sqlBuilderLIst;
                        }
                    }
                }
            }

            return sqlBuilderLIst;
        }
        #endregion

        #region Order By

        public List<string> OrderByClauseBuilder(string orderByClause)
        {
            // Checks to see if there is a where already
            for (int index = 3; index < sqlBuilderLIst.Count; index++)
            {
                if ((sqlBuilderLIst[index])[0] == 'O')
                {
                    string tempHolder = sqlBuilderLIst[index];
                    sqlBuilderLIst[index] = tempHolder + "," + orderByClause;
                    return sqlBuilderLIst;
                }
            }

            if ((sqlBuilderLIst[2])[0] == 'C' && (sqlBuilderLIst[2])[7] == 'P')
            {
                sqlBuilderLIst[sqlBuilderLIst.Count - 1] = "ORDER BY " + orderByClause;
                sqlBuilderLIst.Add("END");
            }
            else
            {
                sqlBuilderLIst.Add("ORDER BY " + orderByClause);
            }

            return sqlBuilderLIst;
        }

        public List<string> OrderByClauseRemover(string orderByClause)
        {
            for (int index = 3; index < sqlBuilderLIst.Count; index++)
            {
                if ((sqlBuilderLIst[index])[0] == 'O')
                {
                    char[] test = new char[1] { ' ' };
                    List<string> tempList = sqlBuilderLIst[index].Split(test, 3).ToList();
                    List<string> tempHolder = tempList[2].Split(',').ToList();


                    for (int i = 0; i < tempHolder.Count; i++)
                    {
                        if (tempHolder[i].Equals(orderByClause))
                        {
                            tempHolder.RemoveAt(i);

                            if (tempHolder.Count > 0)
                            {
                                string holder = tempList[0] + " " + tempList[1] + " ";
                                foreach (string item in tempHolder)
                                {
                                    holder += item + ",";
                                }
                                sqlBuilderLIst[index] = holder.Substring(0, holder.LastIndexOf(','));
                            }
                            else
                            {
                                sqlBuilderLIst.RemoveAt(index);
                            }

                            return sqlBuilderLIst;
                        }
                    }
                }
            }

            return sqlBuilderLIst;
        }

        #endregion

        #region Group By
        public List<string> GroupByClauseBuilder(string groupByClause)
        {
            // Checks to see if there is a group by already
            for (int index = 3; index < sqlBuilderLIst.Count; index++)
            {
                if ((sqlBuilderLIst[index])[0] == 'G')
                {
                    string tempHolder = sqlBuilderLIst[index];
                    sqlBuilderLIst[index] = tempHolder + "," + groupByClause;
                    return sqlBuilderLIst;
                }
            }

            if ((sqlBuilderLIst[2])[0] == 'C' && (sqlBuilderLIst[2])[7] == 'P')
            {
                sqlBuilderLIst[sqlBuilderLIst.Count - 1] = "GROUP BY " + groupByClause;
                sqlBuilderLIst.Add("END");
            }
            else
            {
                sqlBuilderLIst.Add("GROUP BY " + groupByClause);
            }

            return sqlBuilderLIst;
        }

        public List<string> GroupByClauseRemover(string groupByClause)
        {
            for (int index = 3; index < sqlBuilderLIst.Count; index++)
            {
                if ((sqlBuilderLIst[index])[0] == 'G')
                {
                    char[] test = new char[1] { ' ' };
                    List<string> tempList = sqlBuilderLIst[index].Split(test, 3).ToList();
                    List<string> tempHolder = tempList[2].Split(',').ToList();


                    for (int i = 0; i < tempHolder.Count; i++)
                    {
                        if (tempHolder[i].Equals(groupByClause))
                        {
                            tempHolder.RemoveAt(i);

                            if (tempHolder.Count > 0)
                            {
                                string holder = tempList[0] + " " + tempList[1] + " ";
                                foreach (string item in tempHolder)
                                {
                                    holder += item + ",";
                                }
                                sqlBuilderLIst[index] = holder.Substring(0, holder.LastIndexOf(','));
                            }
                            else
                            {
                                sqlBuilderLIst.RemoveAt(index);
                            }

                            return sqlBuilderLIst;
                        }
                    }
                }
            }

            return sqlBuilderLIst;
        }

        #endregion
        // finish
        #region Joins

        #endregion
        // finish
        #region Transactions

        #endregion
        // finish
        #region Query Execute
        public void ExecuteQuery()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < sqlBuilderLIst.Count(); i++)
            {
                stringBuilder.Append(" " + sqlBuilderLIst[i]);
            }

            DBConnection dataLayer = new DBConnection();
            dataLayer.QueryExecution(stringBuilder.ToString());
        }
        #endregion

        #region Support Methods

        private List<String> SplitValuesOrColumns(string input)
        {

            return sqlBuilderLIst;
        }

        private string ListToString(List<string> theList)
        {
            string line = "";

            foreach (string item in theList)
            {
                line += item + ",";
            }

            return line.Substring(0, line.LastIndexOf(','));
        }



        #endregion

        #endregion
    }

}

// Still to do
// - write tables query part
// - in table combobox add a search for table
// - varible table for procedure
// - Fix form so that table name doesnt randomly dissapear
// - finish comments and orginize all classes

