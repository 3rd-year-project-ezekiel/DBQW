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

    public void CreateDatabase(List<String> creationDetails,string connectionstring)
    {
        DBConnection handler = new DBConnection(connectionstring);
        handler.CreateDatabase(creationDetails);

    }

}



