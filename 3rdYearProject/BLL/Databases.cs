using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

public class Databases
{
    private string nameOfDatbase;
    private string filePath;
    private int initialSize;
    private string logName;

    public Databases()
    {

    }

    public Databases(string dbNameParam,string filePathParam,int initSizeParam,string logNameParam)
    {
        NameOfDatabase = dbNameParam;
        FilePath = filePathParam;
        InitialSize = initSizeParam;
        LogName = logNameParam;
    }

    public Databases(string dbNameParam)
    {
        NameOfDatabase = dbNameParam;
    }

    public string LogName
    {
        get { return logName; }
        set { logName = value; }
    }

    public int InitialSize
    {
        get { return initialSize; }
        set { initialSize = value; }
    }


    public string FilePath
    {
        get { return filePath; }
        set { filePath = value; }
    }


    public string NameOfDatabase
    {
        get { return nameOfDatbase; }
        set { nameOfDatbase = value; }
    }

    public void CreateDatabase(List<String> creationDetails)
    {
        DBConnection handler = new DBConnection();
        handler.CreateDatabase(creationDetails);

    }

    public List<Databases> GetDatabases()
    {
        List<Databases> databases = new List<Databases>();
        List<string> raw = new List<string>();
        DBConnection handler = new DBConnection();
        raw = handler.GetDatabases();

        foreach(string dbItem in raw)
        {
            databases.Add(new Databases(dbItem.ToString()));
        }

        return databases;
    }

}



