using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

public class Tables
{
    private string tableNames;

    public Tables(string tableNamesParam)
    {
        this.TableNames = tableNamesParam;
    }

    public Tables()
    {

    }

    public string TableNames { get => tableNames; set => tableNames = value; }

    public override string ToString()
    {
        return tableNames;
    }

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
}
