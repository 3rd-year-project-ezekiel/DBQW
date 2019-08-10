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

        #region Methods
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

        // Insert base + table + changes to them
        public List<string> InsertBaseBuilder(string tableName = "")
        {

            try
            {
                if (sqlBuilderLIst[2][0] == 'P')
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

        // Delete base + table + changes to them
        public List<string> DeleteBaseBuilder(string tableName = "")
        {

            try
            {
                if (sqlBuilderLIst[2][0] == 'P')
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

        // Update base + table + changes to them
        public List<string> UpdateBaseBuilder(string tableName = "")
        {

            try
            {
                if (sqlBuilderLIst[2][0] == 'P')
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

        // Select base + table + changes to them
        public List<string> SelectBaseBuilder(string tableName = "")
        {

            try
            {
                if (sqlBuilderLIst[2][0] == 'P')
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
    }


}
