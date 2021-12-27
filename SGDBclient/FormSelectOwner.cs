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
	public partial class FormSelectOwner : Form {
		public int selectedOwnerID = 0;
		public string selectedOwnerName = "";
		private MySql.Data.MySqlClient.MySqlConnection SQLconnection;
		private void updateTable() {
			MySqlDataReader reader;
			try {
				MySqlCommand command = new MySqlCommand("SELECT * FROM Owners " +
				"WHERE Owners.LastName LIKE \'%" + textBoxSearchString.Text + "%\'", SQLconnection);
				reader = command.ExecuteReader();
			} catch (Exception e) {
				MessageBox.Show(e.Message);
				return;
			}
			dataGridView1.Rows.Clear();
			dataGridView1.Columns.Clear();
			for (int i = 0; i < reader.FieldCount; i++) {
				dataGridView1.Columns.Add(reader.GetName(i), reader.GetName(i));
				if (reader.GetName(i).StartsWith("id")) { //this is an id field, hide it
					dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None; //switch off autosize
					dataGridView1.Columns[i].Width = 1; //minimal width to 'hide' it
				}
			}
			while (reader.Read()) {
				dataGridView1.Rows.Add();
				for (int j = 0; j < reader.FieldCount; j++)
					dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[j].Value = reader[j];
			}
			reader.Close();
		}
		public FormSelectOwner(MySql.Data.MySqlClient.MySqlConnection con) {
			InitializeComponent();
			SQLconnection = con;
			updateTable();
		}

		private void button1_Click(object sender, EventArgs e) {
			try {
				//selectedStorageID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
				selectedOwnerID = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
				selectedOwnerName = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value;
			} catch (Exception) {
				selectedOwnerID = 0;
			}
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e) {
			updateTable();
		}

		private void button1_KeyDown(object sender, KeyEventArgs e) {

		}

		private void dataGridView1_KeyDown(object sender, KeyEventArgs e) {
			e.SuppressKeyPress = true;
			if (e.KeyCode == Keys.Enter) {
				button1_Click(sender, e);
			}
		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e) {
			button1_Click(sender, e);
		}

		private void btnAddStorage_Click(object sender, EventArgs e) {
			FormAddOwner form = new FormAddOwner(SQLconnection);
			form.Show();
		}
	}
}
