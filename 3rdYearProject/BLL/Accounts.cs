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

    #endregion

    #region properties
    public string UserName { get => userName; set => userName = value; }
    public string Password { get => password; set => password = value; }
    public string ConnectionType { get => connectionType; set => connectionType = value; }

    #endregion

    #region override


    #endregion

    #region Methods
    public bool SelectAllAccounts(Accounts UserInput)
    {
       
        DBConnection handler = new DBConnection();
        DataTable dataRaw = handler.AllUsers();

        foreach(DataRow dataItem in dataRaw.Rows)
        {

            if ((dataItem["TableUserName"].ToString() == UserInput.UserName) && (dataItem["TablePassword"].ToString() == UserInput.Password))
            {
                return true;
            }

        }

        return false;
    }

    public void InsertAccount()
    {
        
    }

    #endregion
}
