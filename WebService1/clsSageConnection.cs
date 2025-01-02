using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

public class SageSQLConnection
{
    private const string POOLING_FALSE = "Pooling=False";


    public static SqlConnection CreateConnection(bool bolOpenConnection = true)
    {
        string strCurrentConnection = CreateConnectionString();

        if (strCurrentConnection.Contains(POOLING_FALSE) == false)
            strCurrentConnection = string.Format("{0};{1}", strCurrentConnection, POOLING_FALSE);


        SqlConnection sqlConn = new SqlConnection(strCurrentConnection);

        if (bolOpenConnection == true)
        {
            if (sqlConn.State != System.Data.ConnectionState.Open)
                sqlConn.Open();
        }

        return sqlConn;
    }

    public static string CreateConnectionString()
    {
        string strConnectionStringWithoutCreds = Sage.Accounting.Application.StaticActiveCompany.ConnectString;

        if (strConnectionStringWithoutCreds.Contains("SSPI"))
            return strConnectionStringWithoutCreds;


        System.Data.Common.DbConnectionStringBuilder oBuilder = new System.Data.Common.DbConnectionStringBuilder() { ConnectionString = strConnectionStringWithoutCreds };
        Sage.Common.Credentials.DatabaseCredentialManager oManager = new Sage.Common.Credentials.DatabaseCredentialManager();

        Sage.Common.Credentials.DatabaseLabel oLabelForUser = Sage.Common.Credentials.DatabaseLabel.GetLabelForUser(oBuilder["Database"] as string, "MMSUser");
        Sage.Common.Credentials.DatabaseCredential oCredentialByLabel = oManager.GetCredentialByLabel(oLabelForUser);

        if (oCredentialByLabel != null)
        {
            oBuilder["UID"] = oCredentialByLabel.UserName;
            oBuilder["PWD"] = oCredentialByLabel.Password;
        }
        else
            throw new Exception("Unable to find the database credentials for MMSUser for the current database.");


        return oBuilder.ConnectionString;
    }
}
