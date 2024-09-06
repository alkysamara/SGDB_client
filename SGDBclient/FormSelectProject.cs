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
	public partial class FormSelectProject : Form {
		public int selectedProjectID = 1;
		public string selectedProjectName = "";
		private MySql.Data.MySqlClient.MySqlConnection SQLconnection;
		private void updateTable() {
			MySqlDataReader reader;
			try {
				MySqlCommand command = new MySqlCommand("SELECT * FROM Projects " +
				"WHERE Projects.ProjectName LIKE \'%" + textBoxSearchString.Text + "%\'", SQLconnection);
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
		public FormSelectProject(MySql.Data.MySqlClient.MySqlConnection con) {
			InitializeComponent();
			SQLconnection = con;
			updateTable();
		}

		private void button1_Click(object sender, EventArgs e) {
			try {
                selectedProjectID = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
                selectedProjectName = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value;
			} catch (Exception) {
                selectedProjectID = 1;
			}
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e) {
			updateTable();
		}

		private void dataGridView1_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                button1_Click(sender, e);
			}
		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e) {
			button1_Click(sender, e);
		}

		private void btnAddProject_Click(object sender, EventArgs e) {
			FormAddProject form = new FormAddProject(SQLconnection);
			form.ShowDialog();
			updateTable();
		}

        private void textBoxSearchString_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                updateTable();
            }
        }

        private void FormSelectProject_Shown(object sender, EventArgs e)
        {
            textBoxSearchString.Focus();
        }
    }
}
