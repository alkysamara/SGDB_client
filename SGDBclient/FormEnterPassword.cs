using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SGDBclient {
	public partial class FormEnterPassword : Form {
		private MySql.Data.MySqlClient.MySqlConnection SQLconnection;
		public bool Validated = false;
		public string ValidatedUser = "";
		public FormEnterPassword(MySql.Data.MySqlClient.MySqlConnection SQLconnection) {
			InitializeComponent();
			this.SQLconnection = SQLconnection;
			labelError.Text = "";
		}

		private void textBoxPassword_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				e.SuppressKeyPress = true;
				buttonOk_Click(null, null);
			}
		}

		private void buttonOk_Click(object sender, EventArgs e) {
			if (textBoxUsername.Text.Length > 0)
			{
				MySqlDataReader reader;
				SHA256Managed mySHA256 = new SHA256Managed();
				string passwd = textBoxPassword.Text;
				string passwdHash = BitConverter.ToString(mySHA256.ComputeHash(Encoding.UTF8.GetBytes(passwd))).Replace("-", "").ToLower();
				MySqlCommand command = new MySqlCommand("Select SGitemsDB.validate_user(\'" + textBoxUsername.Text + "\', \'"+ passwdHash + "\')", SQLconnection);
				command.ExecuteNonQuery();
				reader = command.ExecuteReader();
				reader.Read();
				if ((int)reader[0] == 1)
				{
					Validated = true;
					ValidatedUser = textBoxUsername.Text;
					this.Close();
				}
				else labelError.Text = "Autentification failed, try again";
				reader.Close();
			}
		}
	}
}
