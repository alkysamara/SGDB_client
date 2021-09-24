using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //use in pm console: Install-Package MySql.Data

namespace SGDBclient {
	public partial class FormAddOwner : Form {
		private MySql.Data.MySqlClient.MySqlConnection SQLconnection;
		public FormAddOwner(MySql.Data.MySqlClient.MySqlConnection con) {
			InitializeComponent();
			SQLconnection = con;
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			try {
				MySqlCommand command = new MySqlCommand("INSERT INTO sgitemsdb.owners (`LastName`, `FirstName`, `AdditionalInfo`, `Rank`) VALUES(\'" +
					textBoxLastName.Text + "\',\'" +
					textBoxFirstName.Text + "\',\'" +
					textBoxAdditionalInfo.Text + "\',\'" +
					textBoxRank.Text + "\')", SQLconnection);
				command.ExecuteNonQuery();
				this.Close();
			} catch (Exception ee) {
				MessageBox.Show(ee.Message);
			}
		}

		private void btnClick_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
