using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    //#region StartSample
	public partial class Form1 : Form
	{
		private string _sessionID;

		public Form1()
		{
			InitializeComponent();
		}


		private void openSessionButton_Click(object sender, EventArgs e)
		{
			try
			{
				string user = @"REALITY\markwilson";
				string password = @"Glass$Door4399";
				
				ServiceReference1.Service1SoapClient client = new ServiceReference1.Service1SoapClient();
                string value = client.OpenSession(user, password, "Demo Company");
				_sessionID = value;
				textBox1.Text = value;
			}
			catch(Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
		}


		private void closeSessionButton_Click(object sender, EventArgs e)
		{
			try
			{
				ServiceReference1.Service1SoapClient client = new ServiceReference1.Service1SoapClient();
				client.CloseSession(_sessionID, false);
				_sessionID = string.Empty;
				textBox1.Text = _sessionID;
			}
			catch(Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
		}


		private void fetchCustomerButton_Click(object sender, EventArgs e)
		{
			try
			{
                string user = @"REALITY\markwilson";
                string password = @"Glass$Door4399";

                ServiceReference1.Service1SoapClient client = new ServiceReference1.Service1SoapClient();
				string value = client.FetchCustomer(_sessionID, "BET001", user, password, "Demo Company");
				textBox1.Text = value;
			}
			catch(Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
		}
	}
    //#endregion StartSample
}