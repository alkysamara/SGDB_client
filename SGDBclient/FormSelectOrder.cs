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
	public partial class FormSelectOrder : Form {
		public int selectedOrderID = 0;
		public string selectedOrderName = "";
		private MySql.Data.MySqlClient.MySqlConnection SQLconnection;
		private void updateTable() {
			MySqlDataReader reader;
			try {
				MySqlCommand command = new MySqlCommand("SELECT * FROM Orders " +
				"WHERE Orders.Comment LIKE \'%" + textBoxSearchString.Text + "%\'", SQLconnection);
				reader = command.ExecuteReader();
			} catch (Exception e) {
				MessageBox.Show(e.Message);
				return;
			}
			dataGridView1.Rows.Clear();
			dataGridView1.Columns.Clear();
			for (int i = 0; i < reader.FieldCount; i++) {
				dataGridView1.Columns.Add(reader.GetName(i), reader.GetName(i));
			}
			while (reader.Read()) {
				dataGridView1.Rows.Add();
				for (int j = 0; j < reader.FieldCount; j++)
					dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[j].Value = reader[j];
			}
			reader.Close();
		}
		public FormSelectOrder(MySql.Data.MySqlClient.MySqlConnection con) {
			InitializeComponent();
			SQLconnection = con;
			updateTable();
		}

		private void button1_Click(object sender, EventArgs e) {
			try {
				selectedOrderID = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
				selectedOrderName = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value;
			} catch (Exception) {
				selectedOrderID = 0;
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
			FormAddOrder form = new FormAddOrder(SQLconnection);
			form.Show();
		}
	}
}
