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
	public partial class FormAddComponentType : Form {
		private MySql.Data.MySqlClient.MySqlConnection SQLconnection;
		private FormSelectComponentType ComponentTypeListForm;
		public FormAddComponentType(MySql.Data.MySqlClient.MySqlConnection con) {
			InitializeComponent();
			SQLconnection = con;
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			if (textBoxParameters.Text == "{}") {//special case in sql query
				textBoxParameters.Text = "\'{}\'";
			}
			string parentID;
			
			try {
				//parent can be either an ID of another component type or "NULL" if not used
				MySqlCommand command;
				if (ComponentTypeListForm == null) {
					command = new MySqlCommand("INSERT INTO `sgitemsdb`.`componenttypes` (`TypeName`, `Parameters`) VALUES (\'" +
					textBoxName.Text + "\',\'" +
					textBoxParameters.Text.Replace("\"","\\\"") + "\')", SQLconnection);
				} else {
					command = new MySqlCommand("INSERT INTO `sgitemsdb`.`componenttypes` (`TypeName`, `Parameters`, `TypeParent`) VALUES (\'" +
					textBoxName.Text + "\',\'" +
					textBoxParameters.Text + "\',\'" +
					ComponentTypeListForm.selectedComponentTypeID + "\')", SQLconnection);
				}
				MessageBox.Show("Note that only single-line JSON is supported here for now");
				command.ExecuteNonQuery();
				this.Close();
			} catch (Exception ee) {
				MessageBox.Show(ee.Message);
			}
		}

		private void btnClick_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void btnSelect_Click(object sender, EventArgs e) {
			if (ComponentTypeListForm == null) {
				ComponentTypeListForm = new FormSelectComponentType(SQLconnection);
			}
			ComponentTypeListForm.ShowDialog();
			labelSelectedParent.Text = ComponentTypeListForm.selectedComponentTypeName;
		}
	}
}
