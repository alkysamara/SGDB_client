﻿using System;
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
			}
			string asdf = "33"+"33"+(2+1+8*0); //немнорго обфурскации, чтобы боты не набежали
			string connectionString = "server=www.volgaspace.org;port="+asdf+";uid=client;pwd="+pas+"; database=SGitemsDB";
			SQLconnection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
			try {
				SQLconnection.Open();
				if (!System.IO.File.Exists("pwd.ini")) {
					System.IO.File.WriteAllText("pwd.ini", pas);
				}
			}catch (Exception e) {
				richTextBox1.Text = e.Message;
				richTextBox1.ForeColor = Color.Red;
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
            formSelectItem.StartPosition = FormStartPosition.CenterParent;
            formSelectItem.ShowDialog();
			richTextBox1.Text += "Selected component type: "+ formSelectItem.selectedItemName+"\n";
		}

        private void selectPackage_Click(object sender, EventArgs e)
        {
			FormSelectPackage formSelectPackage = new FormSelectPackage(SQLconnection);
            formSelectPackage.StartPosition = FormStartPosition.CenterParent;
            formSelectPackage.ShowDialog();
		}
    }
}
