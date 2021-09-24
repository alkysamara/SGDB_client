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
	public partial class FormAddComponent : Form {
		private MySql.Data.MySqlClient.MySqlConnection SQLconnection;
		public FormAddComponent(MySql.Data.MySqlClient.MySqlConnection con) {
			InitializeComponent();
			SQLconnection = con;
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "yyyy-MM-dd";
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			if (textBoxTotalCost.Text == "") {
				textBoxTotalCost.Text = "0";
			}
			try {
				MySqlCommand command = new MySqlCommand("INSERT INTO sgitemsdb.orders (`Date`, `Comment`, `TotalCost`, `PaySource`) VALUES(\'" +
					dateTimePicker1.Text + "\',\'" +
					textBoxComment.Text + "\',\'" +
					textBoxTotalCost.Text + "\',\'" +
					textBoxPaySource.Text + "\')", SQLconnection);
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
