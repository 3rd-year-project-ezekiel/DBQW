using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Collections;

public class Accounts
{
    #region Fields
    private string userName;
    private string password;
    private string connectionType;
    #endregion

    #region Constructors
    public Accounts(string userName, string password, string connectionType)
    {
        this.userName = userName;
        this.password = password;
        this.connectionType = connectionType;
    }

    public Accounts()
    {
        
    }

    #endregion

    #region properties
    public string UserName { get => userName; set => userName = value; }
    public string Password { get => password; set => password = value; }
    public string ConnectionType { get => connectionType; set => connectionType = value; }

    #endregion

    #region override


    #endregion

    #region Methods
    public bool LoginAccount(string serverName)
    {
        bool validUser = true;
        
        var connStrBldr = new System.Data.SqlClient.SqlConnectionStringBuilder();
        connStrBldr.DataSource = serverName;
        connStrBldr.InitialCatalog = "";

        if (this.ConnectionType == "SQL Server Authentication")
        {
            connStrBldr.IntegratedSecurity = true;
        }
        else
        {
            connStrBldr.IntegratedSecurity = false;
            connStrBldr.UserID = this.UserName;
            connStrBldr.Password = this.Password;
        }

        DBConnection handler = new DBConnection();

        return validUser;
    }

    #endregion
}
