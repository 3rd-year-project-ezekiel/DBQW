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
    private string userName;
    private string password;
    private string connectionType;

    // work

    public string UserName { get => userName; set => userName = value; }
    public string Password { get => password; set => password = value; }
    public string ConnectionType { get => connectionType; set => connectionType = value; }

    public List<Accounts> SelectAllAccounts()
    {
        
    }

    public void InsertAccount()
    {
        
    }
}
