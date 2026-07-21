using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient; //use in pm console: Install-Package MySql.Data

namespace SGDBclient {
	public partial class Form1 : Form {
		private MySql.Data.MySqlClient.MySqlConnection SQLconnection;
		private string cString = "";
		private static string _currentUsername = "";

		public static string currentUsername
		{
			get
			{
				return _currentUsername;
            }
		}


        public Form1() {
			InitializeComponent();
			string text;
			string pas = "";
			if (System.IO.File.Exists("settings.ini"))
			{
				text = System.IO.File.ReadAllText("settings.ini");
				string[] fields = text.Split(new string[]{"\r\n"}, StringSplitOptions.RemoveEmptyEntries);
				string port = "";
				string server = "";
				string uid = "";
				string databaseName = "";

				foreach (string field in fields)
				{
					if (field.StartsWith("#")) //comments
						continue;
					if (field.Contains("server="))
					{
						server = field.Replace("server=", "");
					}
					if (field.Contains("uid="))
					{
						uid = field.Replace("uid=", "");
					}
					if (field.Contains("port="))
					{
						port = field.Replace("port=", "");
					}
					if (field.Contains("pwd="))
					{
						pas = field.Replace("pwd=", "");
					}
					if (field.Contains("database="))
					{
						databaseName = field.Replace("database=", "");
					}
				}
				if (server.Equals(""))
				{
					richTextBox1.Text += "No \"server=\" settings found in settings file\n";
					richTextBox1.ForeColor = Color.Red;
					return;
				}
				if (uid.Equals(""))
				{
					richTextBox1.Text += "No \"uid=\" settings found in settings file\n";
					richTextBox1.ForeColor = Color.Red;
					return;
				}
				if (port.Equals(""))
				{
					richTextBox1.Text += "No \"port=\" settings found in settings file\n";
					richTextBox1.ForeColor = Color.Red;
					return;
				}
				if (databaseName.Equals(""))
				{
					richTextBox1.Text += "No \"database=\" settings found in settings file\n";
					richTextBox1.ForeColor = Color.Red;
					return;
				}
				if (pas.Equals(""))
				{
                    if (System.IO.File.Exists("pwd.ini"))
                    {
                        pas = System.IO.File.ReadAllText("pwd.ini");
                    }
                    else
                    {
                        FormEnterPassword formEnterPassord = new FormEnterPassword();
                        formEnterPassord.ShowDialog();
                        pas = formEnterPassord.password;
                    }
                }
				cString = "server=" + server + ";port=" + port + ";uid=" + uid + ";pwd=" + pas + ";database=" + databaseName;
            }
			else
			{
				richTextBox1.Text += "No base settings file found" + "\n";
				richTextBox1.ForeColor = Color.Red;
				return;
			}

			SQLconnection = new MySql.Data.MySqlClient.MySqlConnection(cString);
			try {
				SQLconnection.Open();
				if (!System.IO.File.Exists("pwd.ini")) {
					System.IO.File.WriteAllText("pwd.ini", pas);
				}
			}catch (Exception e) {
				richTextBox1.Text += e.Message+"\n";
				richTextBox1.ForeColor = Color.Red;
			}
			FormChangeText fct = new FormChangeText("","Enter user name");
			while (currentUsername.Equals(""))
			{
                fct.ShowDialog();
                _currentUsername = fct.text;
            }
		}

		private void btnAddNewItem_Click(object sender, EventArgs e) {
			FormAddItem addItemForm = new FormAddItem(SQLconnection);
            addItemForm.StartPosition = FormStartPosition.CenterParent;
			addItemForm.ShowDialog(this);
		}

		private void btnConnect_Click(object sender, EventArgs e) {
			JSONEditor jse = new JSONEditor();
			jse.StartPosition = FormStartPosition.CenterParent;
            jse.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e) {
			FormSelectItem formSelectItem = new FormSelectItem(SQLconnection);
			formSelectItem.supressEnterAndDoubleClick();
			formSelectItem.StartPosition = FormStartPosition.CenterParent;
            formSelectItem.Show();
			formSelectItem.Top = this.Top;
			formSelectItem.Left = this.Left;
			//richTextBox1.Text += "Selected component type: "+ formSelectItem.selectedItemName+"\n";
		}

        private void selectPackage_Click(object sender, EventArgs e)
        {
			FormWriteoffBOM fwoffbom = new FormWriteoffBOM(SQLconnection);
			fwoffbom.StartPosition = FormStartPosition.CenterParent;
			fwoffbom.ShowDialog();
		}

        private void button2_Click(object sender, EventArgs e)
        {
            FormCheckAvailability fwobom = new FormCheckAvailability(SQLconnection);
			fwobom.StartPosition = FormStartPosition.CenterParent;
			fwobom.ShowDialog();
            /*FormWriteoffBOM fwobom = new FormWriteoffBOM(SQLconnection);
			fwobom.StartPosition = FormStartPosition.CenterParent;
			fwobom.ShowDialog();*/
        }

		private void btn_reconnect_Click(object sender, EventArgs e)
		{
			try
			{
				SQLconnection.Close();
				SQLconnection = new MySql.Data.MySqlClient.MySqlConnection(cString);
				SQLconnection.Open();
				richTextBox1.ForeColor = Color.White;
			}
			catch (Exception ex)
			{
				richTextBox1.Text += ex.Message + "\n";
				richTextBox1.ForeColor = Color.Red;
			}
		}

		private async void timer1_Tick(object sender, EventArgs e)
		{
			if (SQLconnection.State != ConnectionState.Open)
			{
				connection_reconnect();
				return;
			}
			/*MySqlCommand command = new MySqlCommand("SELECT 1", SQLconnection);
			try
			{
				command.CommandTimeout = 1; // Set a short timeout for the health check
											//command.ExecuteScalar(); //simple lightweiht command to test connection
				var reader = await command.ExecuteReaderAsync();
				object res = await reader.ReadAsync();
				reader.Close();
			}
			catch (Exception ee) //try reconnect if not sucessfull
			{
				connection_reconnect();
			}*/
		}

		private void connection_reconnect()
		{
			try
			{
				SQLconnection.Close();
				SQLconnection.Open();
				richTextBox1.ForeColor = Color.White;
			}
			catch (Exception ex)
			{
				richTextBox1.Text += ex.Message + "\n";
				richTextBox1.ForeColor = Color.Red;
			}
		}
	}
}
