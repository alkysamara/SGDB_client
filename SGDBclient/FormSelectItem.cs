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
	public partial class FormSelectItem : Form {
		public int selectedItemID = 1;
		public string selectedItemName = "";
		private MySql.Data.MySqlClient.MySqlConnection SQLconnection;

        private FormSelectStorage StorageListForm;
        //private FormSelectOwner OwnerListForm;
        //private FormSelectOrder OrderListForm;
        private FormSelectComponent ComponentListForm;
        private FormSelectComponentType CTypetListForm;
		private FormSelectPackage PackageListForm;

        private void updateTable() {
            if ((textBoxSearchString.Text == "")&&!chb_Component_filter.Checked&&!chb_ctype_filter.Checked&&!chb_package_filter.Checked&&!chb_storage_filter.Checked)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
            }
            else {
                MySqlDataReader reader;
                try {
                    string sql_querry;
                    if (chb_id.Checked)//use id as search param
                    {
                        sql_querry = "SELECT * FROM full_item " +
                        "WHERE full_item.idItem = " + textBoxSearchString.Text;
                    }
                    else //use partnumber or description to search
                    {
                        sql_querry = "SELECT * FROM full_item " +
                        "WHERE (full_item.Quantity > 0) and (full_item.PartNumber LIKE \'%" + textBoxSearchString.Text + "%\' or " +
                        "full_item.Description LIKE \'%" + textBoxSearchString.Text + "%\')";
                    }
                    if (chb_Component_filter.Checked && (ComponentListForm != null))
                    {
                        sql_querry += "AND (idComponent = " + ComponentListForm.selectedComponentID + ")";
                    }
                    if (chb_ctype_filter.Checked && (CTypetListForm != null))
                    {
                        sql_querry += "AND (idComponentType = " + CTypetListForm.selectedComponentTypeID + ")";
                    }
                    if (chb_package_filter.Checked && (PackageListForm != null))
                    {
                        sql_querry += "AND (idPackage = " + PackageListForm.selectedPackageID + ")";
                    }
                    if (chb_storage_filter.Checked && (StorageListForm != null))
                    {
                        sql_querry += "AND (idStorage = " + StorageListForm.selectedStorageID + ")";
                    }

                    MySqlCommand command = new MySqlCommand(sql_querry, SQLconnection);
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
                    if (reader.GetName(i).Contains("Parameters"))
                    { //this is a wery long field
                        dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None; //switch off autosize
                        dataGridView1.Columns[i].Width = 100; //small width
                    }
                }
                while (reader.Read()) {
                    dataGridView1.Rows.Add();
                    for (int j = 0; j < reader.FieldCount; j++)
                        dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[j].Value = reader[j];
                }
                reader.Close();
            }
		}
		public FormSelectItem(MySql.Data.MySqlClient.MySqlConnection con) {
			InitializeComponent();
			SQLconnection = con;
			updateTable();
		}

        public FormSelectItem(MySql.Data.MySqlClient.MySqlConnection con, string search)
        {
            InitializeComponent();
            SQLconnection = con;
            textBoxSearchString.Text = search;
            updateTable();
        }

        private void buttonSelect_Click(object sender, EventArgs e) {
			try {
                selectedItemID = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
                selectedItemName = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value;
			} catch (Exception) {
                selectedItemID = 0;
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
			FormAddComponent form = new FormAddComponent(SQLconnection);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
			updateTable();
		}

        private void btn_storage_filter_Click(object sender, EventArgs e)
        {
            if (StorageListForm == null)
            {
                StorageListForm = new FormSelectStorage(SQLconnection);
            }
            StorageListForm.StartPosition = FormStartPosition.CenterParent;
            StorageListForm.ShowDialog();
            textBoxStorage.Text = StorageListForm.selectedStorageName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CTypetListForm == null)
            {
                CTypetListForm = new FormSelectComponentType(SQLconnection);
            }
            CTypetListForm.StartPosition = FormStartPosition.CenterParent;
            CTypetListForm.ShowDialog();
            textBoxCType.Text = CTypetListForm.selectedComponentTypeName;
        }

        private void btn_package_filter_Click(object sender, EventArgs e)
        {
            if (PackageListForm == null)
            {
                PackageListForm = new FormSelectPackage(SQLconnection);
            }
            PackageListForm.StartPosition = FormStartPosition.CenterParent;
            PackageListForm.ShowDialog();
            textBoxPackage.Text = PackageListForm.selectedPackageName;
        }

        private void btn_component_filter_Click(object sender, EventArgs e)
        {
            if (ComponentListForm == null)
            {
                ComponentListForm = new FormSelectComponent(SQLconnection);
            }
            ComponentListForm.StartPosition = FormStartPosition.CenterParent;
            ComponentListForm.ShowDialog();
            textBoxComponent.Text = ComponentListForm.selectedComponentName;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
			int id = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
            int qty = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["Quantity"].Value;
            FormCHangeQ formChangeQ = new FormCHangeQ(SQLconnection, id,qty);
            formChangeQ.StartPosition = FormStartPosition.CenterParent;
            formChangeQ.ShowDialog();
			updateTable();
        }


        public static int getComponentIdByName(MySql.Data.MySqlClient.MySqlConnection SQLconnection, string componentName)
        {
            MySqlDataReader reader;
                MySqlCommand command = new MySqlCommand("SELECT idComponent FROM Components " +
                    "WHERE Components.PartNumber LIKE \'" + componentName + "\'", SQLconnection);
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                int result = (int)reader[0];
                reader.Close();
                return result;
            }
            else
            {
                reader.Close();
                throw new Exception("No component " + componentName + " found in database");
            }
            
        }
        public static int getAllItemsQuantities(MySql.Data.MySqlClient.MySqlConnection SQLconnection, string componentName)
        {
            int id = 0;
            try
            {
                id = getComponentIdByName(SQLconnection, componentName);
            }
            catch (Exception ex)
            {
                return 0;
            }
            try { 
                MySqlDataReader reader;
                MySqlCommand command = new MySqlCommand("SELECT Quantity FROM Items " +
                    "WHERE Items.Component_idComponent = \'" + id + "\'", SQLconnection);
                reader = command.ExecuteReader();
                int totalQ = 0;
                while (reader.Read()) { totalQ += (int)reader[0]; }
                reader.Close();
                return totalQ;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void btn_check_availability_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files(*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string all_error_messages = "";
                string path = ofd.FileName;
                string[] lines;
                try
                {
                    lines = System.IO.File.ReadAllLines(path);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                    return;
                }
                string[][] matrix = new string[lines.Length][];
                //get a matrix
                for (int i = 0; i < lines.Length; i++)
                {
                    matrix[i] = lines[i].Split(';');
                }

                //find Partnumber column
                int pnColumnIndex = -1;
                for (int i = 0; i < matrix[0].Length; i++)
                {
                    if ("partnumber pn p/n заказ order".Contains(matrix[0][i].ToLower()))
                    {
                        pnColumnIndex = i;
                        break;
                    }
                }
                if (pnColumnIndex == -1)
                    all_error_messages += "Partnumber column not found in file\n";
                else { //process the partnumber list
                    string[][] results = new string[lines.Length-1][];
                    for (int i = 1; i < lines.Length; i++)
                    {
                        if (matrix[i][pnColumnIndex] == "") all_error_messages += "Partnumber" + i + " is empty\n";
                        else
                        {
                            results[i - 1] = new string[2];
                            results[i - 1][0] = matrix[i][pnColumnIndex];
                            try
                            {
                                results[i - 1][1] = getAllItemsQuantities(this.SQLconnection, matrix[i][pnColumnIndex]).ToString();
                            }catch (Exception ex)
                            {
                                all_error_messages += ex.Message;
                            }
                        }
                    }
                    //return results if no errors
                    if (all_error_messages != "")
                    {
                        MessageBox.Show(all_error_messages);
                        return;
                    }
                    //show results
                    FormTableResult table = new FormTableResult(new string[] { "Order", "TotalQ" }, results);
                    table.StartPosition = FormStartPosition.CenterParent;
                    table.ShowDialog();
                }
            }
        }

        private void textBoxSearchString_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                updateTable();
            }
        }

        private void button1_Click_2(object sender, EventArgs e) //move component
        {
            FormSelectStorage fss = new FormSelectStorage(SQLconnection);
            fss.ShowDialog();
            if (fss.selectedStorageID > 1)
            {
                try
                {
                    int id = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;

                    MySqlCommand command = new MySqlCommand("UPDATE Items SET Storage_idStorage = " + fss.selectedStorageID + 
                        " WHERE idItem = " + id, SQLconnection);
                    int q = command.ExecuteNonQuery();
                    MessageBox.Show("Squccessfully updated rows: " + q);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem moving component: " + ex.Message);
                    return;
                }

            }
        }
    }
}
