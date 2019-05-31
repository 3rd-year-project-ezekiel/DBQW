using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Collections;
using System.IO;
using System.Xml;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;

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

        if (this.ConnectionType == "Windows Authentication")
        {
            connStrBldr.IntegratedSecurity = true;
        }
        else
        {
            connStrBldr.IntegratedSecurity = false;
            connStrBldr.UserID = this.UserName;
            connStrBldr.Password = this.Password;
        }
        /*
        string ApplicationPath = System.IO.Directory.GetCurrentDirectory();
        string YourPath = Path.GetDirectoryName(ApplicationPath);

        string path = Path.GetDirectoryName(YourPath) + "\\App.config";
        XmlDocument doc = new XmlDocument();
        doc.Load(path);
        doc.RemoveChild(doc.DocumentElement.SelectSingleNode("connectionStrings/add[@name='default']"));
        
        XmlNode node;

        node = doc.CreateNode(XmlNodeType.Element, "add", null);
        XmlAttribute attribute = doc.CreateAttribute("name");
        attribute.Value = "default";
        node.Attributes.Append(attribute);

        attribute = doc.CreateAttribute("connectionString");
        attribute.Value = connStrBldr.ConnectionString;
        node.Attributes.Append(attribute);

        attribute = doc.CreateAttribute("providerName");
        attribute.Value = "System.Data.SqlClient";
        node.Attributes.Append(attribute);
        doc.Save(path);

        */

        DBConnection handler = new DBConnection();
        validUser = handler.UserLogin();

        return validUser;
    }

    #endregion
}
