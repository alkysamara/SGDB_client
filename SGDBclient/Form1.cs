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
		public Form1() {
			InitializeComponent();
			string pas;
			if (System.IO.File.Exists("pwd.ini")) {
				pas = System.IO.File.ReadAllText("pwd.ini");
			} else {
				FormEnterPassword formEnterPassord = new FormEnterPassword();
				formEnterPassord.ShowDialog();
				pas = formEnterPassord.password;
				System.IO.File.WriteAllText("pwd.ini", pas);
			}
			string asdf = "33"+"33"+(2+1+8*0); //немнорго обфурскации, чтобы боты не набежали
			string connectionString = "server=www.volgaspace.org;port="+asdf+";uid=client;pwd="+pas+"; database=SGitemsDB";
			SQLconnection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
			try {
				SQLconnection.Open();
			}catch (Exception e) {
				richTextBox1.Text = e.Message;
				richTextBox1.ForeColor = Color.Red;
			}
		}

		private void btnAddNewItem_Click(object sender, EventArgs e) {
			FormAddItem addItemForm = new FormAddItem(SQLconnection);
			addItemForm.Show();
		}

		private void btnConnect_Click(object sender, EventArgs e) {

		}

		private void button1_Click(object sender, EventArgs e) {
			FormSelectComponentType formSelectComponentType = new FormSelectComponentType(SQLconnection);
			formSelectComponentType.ShowDialog();
			richTextBox1.Text += "Selected component type: "+formSelectComponentType.selectedComponentTypeName+"\n";
		}

        private void selectPackage_Click(object sender, EventArgs e)
        {
			FormSelectPackage formSelectPackage = new FormSelectPackage(SQLconnection);
			formSelectPackage.ShowDialog();
		}
    }
}
