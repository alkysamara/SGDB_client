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
	public partial class FormAddPackage : Form {

		private MySql.Data.MySqlClient.MySqlConnection SQLconnection;
		public String json = "'{}'";
		public FormAddPackage(MySql.Data.MySqlClient.MySqlConnection con) {
			InitializeComponent();
			SQLconnection = con;
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			if (textBoxPackageName.Text == "") {
				MessageBox.Show("Name cannot be empty!");
				return;
			}
			try {
				MySqlCommand command = new MySqlCommand("INSERT INTO sgitemsdb.packages (`PackageName`, `Type`, `Pins`, `PackageParameters`) VALUES(\'" +
					textBoxPackageName.Text + "\',\'" +
					textBoxPackageType.Text + "\',\'" +
					numericUpDownPinCount.Text + "\'," +
					json + ")", SQLconnection);
				command.ExecuteNonQuery();
				this.Close();
			} catch (Exception ee) {
				MessageBox.Show(ee.Message);
			}
		}

		private void btnClick_Click(object sender, EventArgs e) {
			this.Close();
		}

        private void FormAddPackage_Load(object sender, EventArgs e)
        {

        }

        private void buttonJSONEditor_Click(object sender, EventArgs e)
        {
			JSONEditor jsonEditor = new JSONEditor();
			jsonEditor.ShowDialog();
			json = jsonEditor.JSON;
		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
