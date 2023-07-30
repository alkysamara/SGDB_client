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
	public partial class FormSelectComponent : Form {
		public int selectedComponentID = 1;
		public string selectedComponentName = "";
		private MySql.Data.MySqlClient.MySqlConnection SQLconnection;
		private void updateTable() {
			MySqlDataReader reader;
			try {
				MySqlCommand command = new MySqlCommand("SELECT * FROM full_component " +
					"WHERE full_component.PartNumber LIKE \'%" + textBoxSearchString.Text + "%\'", SQLconnection);
				reader = command.ExecuteReader();
			} catch (Exception e) {
				MessageBox.Show(e.Message);
				return;
			}
			dataGridView1.Rows.Clear();
			dataGridView1.Columns.Clear();
			for (int i = 0; i < reader.FieldCount; i++) {
				dataGridView1.Columns.Add(reader.GetName(i), reader.GetName(i));
				if (reader.GetName(i).StartsWith("id") || reader.GetName(i).Contains("_id")) { //this is an id field, hide it
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
		public FormSelectComponent(MySql.Data.MySqlClient.MySqlConnection con) {
			InitializeComponent();
			SQLconnection = con;
			updateTable();
		}

		private void buttonSelect_Click(object sender, EventArgs e) {
			try {
				selectedComponentID = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
				selectedComponentName = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value;
			} catch (Exception) {
				selectedComponentID = 0;
			}
			this.Close();
		}

		private void buttonRefresh_Click(object sender, EventArgs e) {
			updateTable();
		}

		private void dataGridView1_KeyDown(object sender, KeyEventArgs e) {
			e.SuppressKeyPress = true;
			if (e.KeyCode == Keys.Enter) {
				buttonSelect_Click(sender, e);
			}
		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e) {
			buttonSelect_Click(sender, e);
		}

		private void btnAddComponent_Click(object sender, EventArgs e) {
			FormAddComponent form = new FormAddComponent(SQLconnection);
			form.ShowDialog();
			updateTable();
		}

        private void btn_add_from_csv_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File format: PartNumber, Parameters, LCSCpart, Links, ComponentType, Package, Description");
            OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "CSV files(*.csv)|*.csv";
            if(ofd.ShowDialog() == DialogResult.OK)
			{
				string all_error_messages = "";
                string path = ofd.FileName;
				string[] lines;

                try
				{
					lines = System.IO.File.ReadAllLines(path);
				}catch(Exception ee)
				{
                    MessageBox.Show(ee.Message);
					return;
                }
				string[][] matrix = new string[lines.Length][];
				//get a matrix
                for (int i=0; i < lines.Length; i++)
                {
					matrix[i] = lines[i].Split(';');
                }
                if (matrix[0].Length != 7)
                {
                    MessageBox.Show("Input file was in wrong format");
                    return;
                }
                //check all lines for errors
                for (int i = 1; i < lines.Length; i++)
				{
					if (matrix[i][0] == "") all_error_messages += "Partnumber" + i + " is empty\n";
                    //check if pn exist
                    MySqlDataReader reader;
                    try
                    {
                        MySqlCommand command = new MySqlCommand("SELECT idComponent FROM Components " +
                            "WHERE Components.PartNumber LIKE \'" + matrix[i][0] + "\'", SQLconnection);
                        reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            all_error_messages += "Component " + matrix[i][0] + " already exist in the database\n";
                        }
                        reader.Close();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                        return;
					}

                    if (matrix[i][1] == "") matrix[i][1] = "\"{}\"";
					if (matrix[i][3] == "") matrix[i][3] = "\"{}\"";
                    if (matrix[i][4] == "") all_error_messages += "Component type" + i + " is empty\n";
                    //check if ct exist
                    try
                    {
                        MySqlCommand command = new MySqlCommand("SELECT idComponentType FROM ComponentTypes " +
                            "WHERE ComponentTypes.TypeName LIKE \'" + matrix[i][4] + "\'", SQLconnection);
                        reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            all_error_messages += "ComponentType " + matrix[i][4] + " does not exist in the database\n";
						}else
						{
							matrix[i][4] = reader[0].ToString();
                        }
                        reader.Close();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                        return;
                    }

                    if (matrix[i][5] == "") all_error_messages += "Package" + i + " is empty\n";
                    //check if package exist
                    try
                    {
                        MySqlCommand command = new MySqlCommand("SELECT idPackage FROM Packages " +
                            "WHERE Packages.PackageName LIKE \'" + matrix[i][5] + "\'", SQLconnection);
                        reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            all_error_messages += "Package " + matrix[i][5] + " does not exist in the database\n";
                        }
                        else
                        {
                            matrix[i][5] = reader[0].ToString();
                        }
                        reader.Close();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                        return;
                    }

                    if (matrix[i][6] == "") all_error_messages += "Description" + i + " is empty\n";
                }
				//apply changes if no errors
				if (all_error_messages != "")
				{
					MessageBox.Show(all_error_messages);
					return;
				}
                //apply changes
                int addcnt = 0;
                try {
					for (int i = 1; i < lines.Length; i++)
                        if(FormAddComponent.addSingleComponent(this.SQLconnection, matrix[i][0], matrix[i][1], matrix[i][2], matrix[i][3], matrix[i][4], matrix[i][5], matrix[i][6]))
                            addcnt++;

				} catch (Exception ee)
				{
					MessageBox.Show(ee.Message);
					return;
				}
                MessageBox.Show("Added "+ addcnt + " new components");
				updateTable();
            }
        }
    }
}
