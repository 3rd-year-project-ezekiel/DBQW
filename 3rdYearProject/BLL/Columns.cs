using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Columns
{
    private string columnName;
	public Columns(string columnNameParam)
	{
        this.ColumnName = columnNameParam;
	}

    public Columns()
    {

    }

    public string ColumnName { get => columnName; set => columnName = value; }

    public List<Columns> GetColumns(string databaseName, string tableName)
    {
        List<Columns> columns = new List<Columns>();
        List<string> raw = new List<string>();
        DBConnection handler = new DBConnection();
        raw = handler.GetColumns(databaseName, tableName);

        foreach (string dbItem in raw)
        {
            columns.Add(new Columns(dbItem.ToString()));
        }

        return columns;
    }
}
