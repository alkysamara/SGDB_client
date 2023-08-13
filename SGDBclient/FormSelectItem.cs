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
			MySqlDataReader reader;
			try {
				string sql_querry = "SELECT * FROM full_item " +
					"WHERE full_item.PartNumber LIKE \'%" + textBoxSearchString.Text + "%\'";
				if (chb_Component_filter.Checked)
				{
					sql_querry += "AND (idComponent = " + ComponentListForm.selectedComponentID + ")";
                }
				if (chb_ctype_filter.Checked)
				{
                    sql_querry += "AND (idComponentType = " + CTypetListForm.selectedComponentTypeID + ")";
                }
				if (chb_package_filter.Checked)
				{
                    sql_querry += "AND (idPackage = " + PackageListForm.selectedPackageID + ")";
                }
				if (chb_storage_filter.Checked)
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
			}
			while (reader.Read()) {
				dataGridView1.Rows.Add();
				for (int j = 0; j < reader.FieldCount; j++)
					dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[j].Value = reader[j];
			}
			reader.Close();
		}
		public FormSelectItem(MySql.Data.MySqlClient.MySqlConnection con) {
			InitializeComponent();
			SQLconnection = con;
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
			form.ShowDialog();
			updateTable();
		}

        private void btn_storage_filter_Click(object sender, EventArgs e)
        {
            if (StorageListForm == null)
            {
                StorageListForm = new FormSelectStorage(SQLconnection);
            }
            StorageListForm.ShowDialog();
            textBoxStorage.Text = StorageListForm.selectedStorageName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CTypetListForm == null)
            {
                CTypetListForm = new FormSelectComponentType(SQLconnection);
            }
            CTypetListForm.ShowDialog();
            textBoxCType.Text = CTypetListForm.selectedComponentTypeName;
        }

        private void btn_package_filter_Click(object sender, EventArgs e)
        {
            if (PackageListForm == null)
            {
                PackageListForm = new FormSelectPackage(SQLconnection);
            }
            PackageListForm.ShowDialog();
            textBoxPackage.Text = PackageListForm.selectedPackageName;
        }

        private void btn_component_filter_Click(object sender, EventArgs e)
        {
            if (ComponentListForm == null)
            {
                ComponentListForm = new FormSelectComponent(SQLconnection);
            }
            ComponentListForm.ShowDialog();
            textBoxComponent.Text = ComponentListForm.selectedComponentName;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
			int id = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
            FormCHangeQ formChangeQ = new FormCHangeQ(SQLconnection, id);
			formChangeQ.ShowDialog();
			updateTable();
        }
    }
}
