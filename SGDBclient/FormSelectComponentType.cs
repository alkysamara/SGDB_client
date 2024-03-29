﻿using System;
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
	public partial class FormSelectComponentType : Form {
		public int selectedComponentTypeID = 1;
		public string selectedComponentTypeName = "";
		private MySql.Data.MySqlClient.MySqlConnection SQLconnection;
		private void updateTable() {
			MySqlDataReader reader;
			try {
				MySqlCommand command = new MySqlCommand("SELECT * FROM ComponentTypes " +
					"WHERE ComponentTypes.TypeName LIKE \'%" + textBoxSearchString.Text + "%\'", SQLconnection);
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
				for (int j = 0; j < reader.FieldCount; j++) {
					dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[j].Value = reader[j];
				}
			}
			reader.Close();
			for (int i = 0; i < dataGridView1.Columns.Count; i++) {
				if (dataGridView1.Columns[i].Name == "TypeParent") {
					for (int j = 0; j < dataGridView1.Rows.Count; j++) {
						if (dataGridView1.Rows[j].Cells[i].Value.ToString() != "") {
							MySqlDataReader readerParent;
							try {
								MySqlCommand commandParent = new MySqlCommand("SELECT ComponentTypes.TypeName FROM ComponentTypes " +
									"WHERE ComponentTypes.idComponentType = " + dataGridView1.Rows[j].Cells[i].Value, SQLconnection);
								readerParent = commandParent.ExecuteReader();
								readerParent.Read();
								dataGridView1.Rows[j].Cells[i].Value = readerParent[0];
								readerParent.Close();
							} catch (Exception e) {
								MessageBox.Show(e.Message);
								return;
							}
						}
					}
					break;
				}
			}
		}
		public FormSelectComponentType(MySql.Data.MySqlClient.MySqlConnection con) {
			InitializeComponent();
			SQLconnection = con;
			updateTable();
		}

		private void buttonSelect_Click(object sender, EventArgs e) {
			try {
				selectedComponentTypeID = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
				selectedComponentTypeName = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value;
			} catch (Exception) {
				selectedComponentTypeID = 0;
			}
			this.Close();
		}

		private void buttonRefresh_Click(object sender, EventArgs e) {
			updateTable();
		}

		private void dataGridView1_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                buttonSelect_Click(sender, e);
			}
		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e) {
			buttonSelect_Click(sender, e);
		}

		private void btnAddComponent_Click(object sender, EventArgs e) {
			FormAddComponentType form = new FormAddComponentType(SQLconnection);
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
    }
}
