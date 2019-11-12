using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

public class Tables
{
    #region Fields
    private string tableNames;
    #endregion

    #region Constructors
    public Tables(string tableNamesParam)
    {
        this.TableNames = tableNamesParam;
    }

    public Tables()
    {

    }
    #endregion

    #region Properties
    public string TableNames { get => tableNames; set => tableNames = value; }
    #endregion

    #region Override
    public override string ToString()
    {
        return tableNames;
    }
    #endregion

    #region Methods
    public List<Tables> GetTables(string databaseName)
    {
        List<Tables> tables = new List<Tables>();
        List<string> raw = new List<string>();
        DBConnection handler = new DBConnection();
        raw = handler.GetTables(databaseName);

        foreach (string dbItem in raw)
        {
            tables.Add(new Tables(dbItem.ToString()));
        }

        return tables;
    }
    
    public void AddTable(List<string> tableDetails,string databaseName,string tableName)
    {
        DBConnection connection = new DBConnection();

        connection.CreateTable(tableDetails, databaseName, tableName);

    }

    // gets the data in a table for the Data Form
    public DataTable GetTableContents(string databaseName , string tableName)
    {
        DataTable tables = new DataTable();
        DBConnection handler = new DBConnection();
        tables = handler.GetTableContents(databaseName,tableName);

        return tables;
    }
    #endregion
}
