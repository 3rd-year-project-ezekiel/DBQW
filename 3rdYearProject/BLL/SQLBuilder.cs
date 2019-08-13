using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class SQLBuilder
    {
        #region fields
        private List<string> sqlBuilderLIst;
        #endregion

        #region constructor
        public SQLBuilder()
        { sqlBuilderLIst = new List<string>(); }

        #endregion

        #region Algorithm
        // Database add + change
        public List<string> DatabaseBaseBuilder(string dataBaseName)
        {
            if (sqlBuilderLIst.Count == 0)
            { sqlBuilderLIst.Add("USE " + dataBaseName); sqlBuilderLIst.Add("GO"); }
            else
            if (sqlBuilderLIst.Count > 0)
            {
                    sqlBuilderLIst.Clear();
                    sqlBuilderLIst.Add("USE " + dataBaseName);
                    sqlBuilderLIst.Add("GO");
            }
            return sqlBuilderLIst;
        }

        #region programmability
        // programmability base add and remove
        public List<string> programmabilityBaseBuilder()
        {

            try
            {
                if ((sqlBuilderLIst[2])[0] == 'C')
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
                    sqlBuilderLIst.Add("CREATE PROCEDURE ");
                    sqlBuilderLIst.Add("()");
                    sqlBuilderLIst.Add("AS");
                    sqlBuilderLIst.Add("BEGIN");
                    sqlBuilderLIst.AddRange(tempList);
                    
                }
                catch (Exception)
                {
                    sqlBuilderLIst.Add("CREATE PROCEDURE ");
                    sqlBuilderLIst.Add("()");
                    sqlBuilderLIst.Add("AS");
                    sqlBuilderLIst.Add("BEGIN");
                }
                sqlBuilderLIst.Add("END");

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
                if ((sqlBuilderLIst[2])[0] == 'C')
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
            try
            {
                if ((sqlBuilderLIst[2])[0] == 'C')
                {
                     
                }
            }
            catch (Exception)
            {

                throw;
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
                if ((sqlBuilderLIst[2])[0] == 'C')
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
                if ((sqlBuilderLIst[2])[0] == 'C')
                {
                    sqlBuilderLIst.RemoveAt(sqlBuilderLIst.Count - 1);
                    if (sqlBuilderLIst.Count > 5)
                        sqlBuilderLIst.RemoveRange(6, (sqlBuilderLIst.Count - 6));

                    sqlBuilderLIst.Add("UPDATE ");
                    if (tableName != "")
                        sqlBuilderLIst[sqlBuilderLIst.Count - 1] += tableName;
                    sqlBuilderLIst.Add("SET ");
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
                sqlBuilderLIst.Add("SET ");

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
                if ((sqlBuilderLIst[2])[0] == 'C')
                {
                    sqlBuilderLIst.RemoveAt(sqlBuilderLIst.Count - 1);
                    if (sqlBuilderLIst.Count > 5)
                        sqlBuilderLIst.RemoveRange(6, (sqlBuilderLIst.Count - 6));

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

                sqlBuilderLIst.Add("SELECT ");
                sqlBuilderLIst.Add("FROM ");
                if (tableName != "")
                    sqlBuilderLIst[sqlBuilderLIst.Count - 1] += tableName;

            }

            return sqlBuilderLIst;
        }

        #endregion

        #region Support Methods

        private List<String> SplitValuesOrColumns(string input)
        {

            return sqlBuilderLIst;
        }

        public List<string> WhereClauseBuilder(string whereClause)
        {
            int index = 0;
            // Checks to see if there is a where already
            for (index = 3; index < sqlBuilderLIst.Count; index++)
            {
                if ((sqlBuilderLIst[index])[0] == 'W')
                {
                    string tempHolder = sqlBuilderLIst[index];
                    sqlBuilderLIst[index] = tempHolder + "AND" + whereClause;
                    return sqlBuilderLIst;
                }
            }

            if ((sqlBuilderLIst[2])[0] == 'C')
            {
                sqlBuilderLIst[sqlBuilderLIst.Count - 1] = "WHERE" + whereClause;
                sqlBuilderLIst.Add("END");
            }
            else
            {
                sqlBuilderLIst.Add("WHERE" + whereClause);
            }

            
            return sqlBuilderLIst;

            

            return sqlBuilderLIst;
        }

        #endregion

        #endregion
    }


}
