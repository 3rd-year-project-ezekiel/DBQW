using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
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

        #region Methods
        public void CopyQueryToClipboard()
        {
            string queryBuilder = "";
            foreach (string item in sqlBuilderLIst)
            {
                queryBuilder += item + Environment.NewLine; 

            }
            Clipboard.SetText(queryBuilder);
            MessageBox.Show("Query is copied to your clipboard");
        }

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

        #region Tables
        // Table base to add or change the tables
        public List<string> TableBuilder(string tableName)
        {
            try
            {
                int counter = 0;
                int splitPosition = 1;  // split position will be used to tell the program where to split to add in the table
                while (counter < sqlBuilderLIst.Count)
                {
                    if (sqlBuilderLIst[counter][0] == 'U' && sqlBuilderLIst[counter][1] == 'P' && sqlBuilderLIst[counter][2] == 'D') // Update
                    {
                        break;
                    }
                    if (sqlBuilderLIst[counter][0] == 'D' && sqlBuilderLIst[counter][1] == 'E' && sqlBuilderLIst[counter][2] == 'L') // Delete
                    {
                        splitPosition = 2;
                        break;
                    }
                    if (sqlBuilderLIst[counter][0] == 'I' && sqlBuilderLIst[counter][1] == 'N' && sqlBuilderLIst[counter][2] == 'S') // Insert
                    {
                        splitPosition = 2;
                        break;
                    }
                    if (sqlBuilderLIst[counter][0] == 'S' && sqlBuilderLIst[counter][1] == 'E' && sqlBuilderLIst[counter][2] == 'L') // Select
                    {
                        counter++;
                        break;
                    }

                    counter++;
                }

                List<string> tableLineHolder = sqlBuilderLIst[counter].Split(' ').ToList();
                // if there is no table name at Update and Select, Add a nerw one
                if (tableLineHolder.Count <= 1 && splitPosition == 1) 
                {
                    tableLineHolder.Add(tableName);
                }

                // if there is a table name in Update and select then replace it
                if (tableLineHolder.Count > 1 && splitPosition == 1) 
                {
                    tableLineHolder[splitPosition] = tableName;
                }

                // if there is no table name at Insert and Delete, Add a nerw one
                if (tableLineHolder.Count <= 2 && splitPosition == 2) 
                {
                    tableLineHolder.Add(tableName);
                }

                // if there is a table name in Delete or Insert then replace it
                if (tableLineHolder.Count > 2 && splitPosition == 2 && !tableLineHolder[splitPosition].Contains("(")) 
                {
                    tableLineHolder[splitPosition] = tableName;
                }

                // if there is not a table name in Insert but there is already columns then add a new table name
                if (tableLineHolder.Count > 2 && splitPosition == 2 && tableLineHolder[splitPosition].Contains("(")) 
                {
                    tableLineHolder.Add(tableLineHolder[splitPosition]);
                    tableLineHolder[splitPosition] = tableName;
                }

                // convert the list back to a string and store it in the sql builder
                sqlBuilderLIst[counter] = ListToStringSpaceses(tableLineHolder);
            }
            catch (Exception)
            {

                // if one of the table stuff is not found then the counter will be bigger then the list
                // in this case when the counter is used again, it will throw a error to be catched

                // most probably a option is not selected so the counter will run thourh the program and error out because of index out of bounds

                // create a custom exception for the user saying index out of bounds, please select(insert, update ...)
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
                if ((sqlBuilderLIst[2])[0] == 'C' && (sqlBuilderLIst[2])[7] == 'P')               // checks to see if procedure already exists
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
        public List<string> ProcedureAddVaribles(string varible,string length = null)
        {
            if(sqlBuilderLIst[3][1] == ')')
            {
                sqlBuilderLIst[3] = "("+varible ;
            }
            else
            {
                sqlBuilderLIst[3] = sqlBuilderLIst[3].Substring(0, sqlBuilderLIst[3].Count() - 1) + "," + varible ;
            }

            if (length == null)
            {
                sqlBuilderLIst[3] += ")";
            }
            else
            {
                sqlBuilderLIst[3] += "(" + length + "))";
            }


            return sqlBuilderLIst;
        }

        // Remove a Varible From Procedure
        public List<string> ProcedureRemoveVarible(string varible)
        {
            List<string> theList = sqlBuilderLIst[3].Substring(1,sqlBuilderLIst[3].Length - 2).Split(',').ToList();   // replaces the brackets with colons then splited on the colons
            theList.Remove(varible);                                                                                 // if there is somthing to remove, the first sighting of the will be removed
            sqlBuilderLIst[3] = "(" + ListToString(theList) + ")";                                                  // adds whats left back to sql
            return sqlBuilderLIst;
        }

        // Adds or changes the procedureName
        public List<String> ProcedureNameBuilder(string procName)
        {
            List<string> tempProcedureLineHolder = sqlBuilderLIst[2].Split(' ').ToList();
            if (tempProcedureLineHolder.Count <= 2)
            {
                tempProcedureLineHolder.Add(procName);
            }
            else
            {
                tempProcedureLineHolder[2] = procName;
            }

            sqlBuilderLIst[2] = ListToStringSpaceses(tempProcedureLineHolder);


            return sqlBuilderLIst; 
        }
        #endregion

        #region Views
        // view base add and remove
        public List<string> ViewBaseBuilder(string tableName = "")
        {

            try
            {
                if ((sqlBuilderLIst[2])[0] == 'C' && (sqlBuilderLIst[2])[7] == 'V')
                {
                    sqlBuilderLIst.RemoveAt(2);
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
                sqlBuilderLIst.Add("CREATE VIEW >Enter_Name< AS");
                sqlBuilderLIst.Add("SELECT");
                sqlBuilderLIst.Add("FROM ");
                if (tableName != "")
                    sqlBuilderLIst[sqlBuilderLIst.Count - 1] += tableName;

            }

            return sqlBuilderLIst;
        }

        public List<string> ViewNameBuilder(string viewName)
        {
            int index = 2;
            while (index < sqlBuilderLIst.Count)
            {
                if ((sqlBuilderLIst[index])[0] == 'C' && (sqlBuilderLIst[index])[7] == 'V')
                {
                    List<string> tempViewLineHolder = sqlBuilderLIst[index].Split(' ').ToList();
                    if (tempViewLineHolder.Count <= 3)
                    {
                        tempViewLineHolder[2] = viewName;
                        tempViewLineHolder.Add("AS");
                    }
                    else
                    {
                        tempViewLineHolder[2] = viewName;
                    }

                    sqlBuilderLIst[index] = ListToStringSpaceses(tempViewLineHolder);
                    break;
                }
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

                    sqlBuilderLIst.Add("SELECT");
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

                sqlBuilderLIst.Add("SELECT");
                sqlBuilderLIst.Add("FROM ");
                if (tableName != "")
                    sqlBuilderLIst[sqlBuilderLIst.Count - 1] += tableName;

            }

            return sqlBuilderLIst;
        }

        // adds just the columns
        public List<string> SelectAddColumns(string columnName)
        {
                int index = 2;
                while (sqlBuilderLIst.Count > index)
                {
                    if ((sqlBuilderLIst[index])[0] == 'S' && (sqlBuilderLIst[index])[1] == 'E' && (sqlBuilderLIst[index])[2] == 'L')
                    {
                    string[] lines = sqlBuilderLIst[index].Split(' ');
                    try
                    {
                        if (lines.Count() < 2 )
                        {
                            sqlBuilderLIst[index] += " "+ columnName;
                        }
                        else
                        {
                            sqlBuilderLIst[index] +=  ","+columnName ;
                        }
                    }
                    catch (Exception)
                    {
                    }
                        break;
                    }
                index++;
                }
            
            return sqlBuilderLIst;
           
        }
        // removes the columns
        public List<string> SelectRemoveColumn(string columnName)
        {
            int index = 2;
            while (sqlBuilderLIst.Count > index)
            {
                if ((sqlBuilderLIst[index])[0] == 'S' && (sqlBuilderLIst[index])[1] == 'E' && (sqlBuilderLIst[index])[2] == 'L')
                {
                    try
                    {
                        char[] splitTemp = new char[1] { ' ' };
                        List<String> theList = (sqlBuilderLIst[index].Split(splitTemp,2))[1].Split(',').ToList();
                        theList.Remove(columnName);
                        sqlBuilderLIst[index] = "SELECT " + ListToString(theList);
                    }
                    catch (Exception)
                    {
                        sqlBuilderLIst[index] = "SELECT";


                    }
                    break;
                }
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

            ReOrderClauses();

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

            ReOrderClauses();
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

            ReOrderClauses();

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

            ReOrderClauses();

            return sqlBuilderLIst;
        }
        #endregion

        #region Order By

        public List<string> OrderByClauseBuilder(string orderByClause)
        {
            // Checks to see if there is a Order by already
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

            ReOrderClauses();

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

                            ReOrderClauses();

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

            ReOrderClauses();

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

            ReOrderClauses();

            return sqlBuilderLIst;
        }

        #endregion

        // finish
        #region Joins

        #endregion

        // Nice to have for the query test
        #region Transactions

        #endregion

        #region Query Execute
        public bool ExecuteQuery()
        {
            SqlConnectionStringBuilder connStringBuilder = new SqlConnectionStringBuilder();
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");

            string[] lines = connectionStringsSection.ConnectionStrings["default"].ConnectionString.Split(';');

            connStringBuilder.DataSource = (lines[0].Split('='))[1];
            connStringBuilder.InitialCatalog = (sqlBuilderLIst[0].Split(' '))[1];
            if((lines[2].Split('='))[1] == "True")
            {
                connStringBuilder.IntegratedSecurity = true;
            }
            else
            {
                connStringBuilder.IntegratedSecurity = false;
                connStringBuilder.UserID = (lines[3].Split('='))[1];
                connStringBuilder.Password = (lines[4].Split('='))[1];
            }

            connectionStringsSection.ConnectionStrings["ExecuteQuery"].ConnectionString = connStringBuilder.ToString();

            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
            DBConnection dataLayer = new DBConnection("ExecuteQuery");

            string queryBuilder = "";
            foreach (string item in sqlBuilderLIst)
            {
                if (item == "GO" || (item.Split(' '))[0] == "USE") { } else { queryBuilder += item + " "; }
                
            }

           
            return dataLayer.QueryExecution(queryBuilder.ToString());
            

        }

        public DataTable GetSelectDataExecute()
        {
            DataTable table = new DataTable();
            DBConnection dataLayer = new DBConnection("ExecuteQuery");

            string queryBuilder = "";
            foreach (string item in sqlBuilderLIst)
            {
                if (item == "GO" || (item.Split(' '))[0] == "USE") { } else { queryBuilder += item + " "; }
            }

            return dataLayer.GetSelectData(queryBuilder);
        }
        #endregion

        #region Support Methods
        // still to finish
        private List<String> SplitValuesOrColumns(string input)
        {

            return sqlBuilderLIst;
        }

        // converts a list to a string with comma's between the entities
        private string ListToString(List<string> theList)
        {
            string line = "";

            foreach (string item in theList)
            {
                line += item + ",";
            }

            try
            {
                return line.Substring(0, line.LastIndexOf(','));
            }
            catch (Exception)
            {

                return "";
            }
        }

        // converts a list to a string with spaces between the entities
        private string ListToStringSpaceses(List<string> theList)
        {
            string line = "";

            foreach (string item in theList)
            {
                line += item + " ";
            }

            return line.Substring(0, line.LastIndexOf(' '));
        }

        private void ReOrderClauses()
        {
            for (int i = 3; i < sqlBuilderLIst.Count; i++)
            {

            }
        }

        #endregion

        #endregion
    }

}

// Still to do
// - finish joins methods   ## Not for Project

// - in the table combobox add a search function for table    ## Nice to Have

// - finish comments and orginize all classes

// - Data menu strip needs to lead to a form where you can view what is inside each tables

// - Re- order query structure from where
// order
// 
// Where
// Group by
// Having
// Order by






 