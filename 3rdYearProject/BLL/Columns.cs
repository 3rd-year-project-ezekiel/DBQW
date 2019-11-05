using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Columns
{
    #region Fields
    private string columnName;
    private string dataType;
    #endregion

    #region Contructors
    public Columns(string columnNameParam)
	{
        this.ColumnName = columnNameParam;
	}

    public Columns(string columnNameParam,string columnTypeParam)
    {
        this.ColumnName = columnNameParam;
        this.DataType = columnTypeParam;
    }

    public Columns()
    {

    }
    #endregion

    #region Properties
    public string ColumnName { get => columnName; set => columnName = value; }
    public string DataType { get => dataType; set => dataType = value; }
    #endregion

    #region Override    
    #endregion

    #region Methods
    public List<Columns> GetColumns(string databaseName, string tableName)
    {
        List<Columns> columns = new List<Columns>();
        DataTable raw = new DataTable();
        DBConnection handler = new DBConnection();
        raw = handler.GetColumns(databaseName, tableName);

        foreach (DataRow dbItem in raw.Rows)
        {
            columns.Add(new Columns(dbItem["Column Name"].ToString(), dbItem["Data Type"].ToString()));
        }

        return columns;
    }
    #endregion
}
