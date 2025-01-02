using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Sage.MMS.SAA.Client;
using Sage.Accounting.SalesLedger;
using Sage.Accounting;
using Sage.ObjectStore.Builder;
using System.Data.SqlClient;
using System.Configuration;

namespace WebService1
{
    //#region StartSample
	/// <summary>
	/// Summary description for Service1
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class Service1 : System.Web.Services.WebService
	{
        [WebMethod]
        public string OpenSession(string user, string password, string company)
		{
			// Session ID doesn't seem to do bugger all.. subsequent calls indicate the user is not connected to Sage...
			return Sage200Context.OpenSession(user, password, company);			
        }

        [WebMethod]
        public void CloseSession(string sessionID, bool bForce)
		{
			// Sage does not clear entry from tblSessionInfo in config database, why? who knows...bug?
			// Updated to clear via SQL based on the current session ID that was returned on connecting to Sage
			if (bForce == true)
			{
				UpdateSessionSQL(sessionID);
			}
			else
			{
                Sage200Context.CloseSession(sessionID);
            }			
		}

        private void UpdateSessionSQL(string sessionID)
        {
            using (SqlConnection oSqlConnection = new SqlConnection(ConfigurationManager.AppSettings["WebConfigDBString"]))
            {
				if (oSqlConnection.State == System.Data.ConnectionState.Closed) { oSqlConnection.Open(); };

				SqlCommand oSqlCommand = new SqlCommand("UPDATE tblSessionInfo SET SessionState = 'Closed' WHERE (SessionIdentifier = @SessionID)", oSqlConnection);
				oSqlCommand.Parameters.AddWithValue("@SessionID", sessionID);
				oSqlCommand.ExecuteNonQuery();

                if (oSqlConnection.State == System.Data.ConnectionState.Open) { oSqlConnection.Close(); };
            }
        }

        private protected string ConnectSage(string user, string password, string company) 
		{
            // Having to 'reconnect' to sage since for some reason the connection is not persisting after opening and fetching a session ID
            // Not sure what the problem is, the session ID does not even dispose / disconnect properly either
            // Issue with internal sage mechanisms??
            if (SAAClientAPI.IsConnected == false)
            {
               return OpenSession(user, password, company);
            };

			return "";
        }

		[WebMethod]
		public string FetchCustomer(string sessionID, string reference, string user, string password, string company)
		{
			string value = "";
			string cachedID = sessionID;

			SAAClientAPI.SetSessionContext(cachedID);

			// Having to 'reconnect' to sage since for some reason the connection is not persisting after opening and fetching a session ID
			// Not sure what the problem is, the session ID does not even dispose / disconnect properly either
			// Issue with internal sage mechanisms??
			if (SAAClientAPI.IsConnected == false)
			{
                cachedID = ConnectSage(user, password, company);
			};

			Customer customer = CustomerFactory.Factory.Fetch(reference);

			value = "Ref=" + customer.Reference + ", name=" + customer.Name;

            // Close / logoff sage before returning
            CloseSession(cachedID, true);

            return value;
		}
	}
    //#endregion StartSample
}