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
		private JSONEditor jsonEditorParameters, jsonEditorLinks;
		private FormSelectComponentType formSelectComponentType;
		//private FormSelectPackage formSelectPackage;
		public FormAddComponent(MySql.Data.MySqlClient.MySqlConnection con) {
			InitializeComponent();
			SQLconnection = con;
			jsonEditorParameters = new JSONEditor();
			jsonEditorLinks = new JSONEditor();
			formSelectComponentType = new FormSelectComponentType(SQLconnection);
			//formSelectPackage = new FormSelectPackage(SQLconnection);
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			try {
				MySqlCommand command = new MySqlCommand("INSERT INTO sgitemsdb.components (`PartNumber`, `Parameters`, `LCSCpart`, `Links`, `ComponentType_idComponentType`, `Package_idPackage`) VALUES(\'" +
					textBoxPartNumber.Text + "\',\'" +
					jsonEditorParameters.JSON + ",\'" +
					textBoxLCSC.Text + "\',\'" +
					jsonEditorLinks.JSON + ",\'" +
					
					
					")", SQLconnection);
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
