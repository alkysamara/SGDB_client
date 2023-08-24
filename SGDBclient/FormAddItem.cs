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
	public partial class FormAddItem : Form {
		private MySql.Data.MySqlClient.MySqlConnection SQLconnection;
		private FormSelectStorage StorageListForm;
		private FormSelectOwner OwnerListForm;
		private FormSelectOrder OrderListForm;
		private FormSelectComponent ComponentListForm;

		public FormAddItem(MySql.Data.MySqlClient.MySqlConnection con) {
			InitializeComponent();
			SQLconnection = con;
            OwnerListForm = new FormSelectOwner(SQLconnection);
            OrderListForm = new FormSelectOrder(SQLconnection);
            ComponentListForm = new FormSelectComponent(SQLconnection);
            StorageListForm = new FormSelectStorage(SQLconnection);
        }

		private void btnSelectStorage_Click(object sender, EventArgs e) {
			if (StorageListForm == null) {
				StorageListForm = new FormSelectStorage(SQLconnection);
			}
			StorageListForm.ShowDialog();
			textBoxStorage.Text = StorageListForm.selectedStorageName;
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			this.Close();
		}

		public static bool add_single_item(MySql.Data.MySqlClient.MySqlConnection SQLconnection, string Quantity, string Price,
			int idStorage, int idOrder, int idComponent, int idPerson)
		{
            try
            {
                if (Price == "")
                {
                    Price = "0";
                }
                MySqlCommand command = new MySqlCommand("INSERT INTO `SGitemsDB`.`Items` (`Quantity`, `Price`, `Storage_idStorage`, `Order_idOrder`, `Component_idComponent`, `Owner_idPerson`) VALUES(\'" +
                    Quantity + "\',\'" +
                    Price + "\',\'" +
                    idStorage + "\',\'" +
                    idOrder + "\',\'" +
                    idComponent + "\',\'" +
                    idPerson + "\')"
                    , SQLconnection);
                command.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                return false;
            }
            return true;
        }

		private void btnAdd_Click(object sender, EventArgs e) {
            if (add_single_item(this.SQLconnection, textBoxQuantity.Text, textBoxPrice.Text, StorageListForm.selectedStorageID,
                OrderListForm.selectedOrderID, ComponentListForm.selectedComponentID, OwnerListForm.selectedOwnerID))
                this.Close();
        }

		private void btnSelectOwner_Click(object sender, EventArgs e) {
			if (OwnerListForm == null) {
				OwnerListForm = new FormSelectOwner(SQLconnection);
			}
			OwnerListForm.ShowDialog();
			textBoxOwner.Text = OwnerListForm.selectedOwnerName;
		}

		private void btnSelectOrder_Click(object sender, EventArgs e) {
			if (OrderListForm == null) {
				OrderListForm = new FormSelectOrder(SQLconnection);
			}
			OrderListForm.ShowDialog();
			textBoxOrder.Text = OrderListForm.selectedOrderName;
		}

		private void btnSelectComponent_Click(object sender, EventArgs e) {
			if (ComponentListForm == null) {
				ComponentListForm = new FormSelectComponent(SQLconnection);
			}
			ComponentListForm.ShowDialog();
			textBoxComponent.Text = ComponentListForm.selectedComponentName;
		}

        private void btn_add_from_csv_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File format: PartNumber, Quantity, Price, Place, idOrder, Owner");
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files(*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                const int number_of_columns = 6;
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
                if (matrix[0].Length != number_of_columns)
                {
                    MessageBox.Show("Input file was in wrong format");
                    return;
                }
                //check all lines for errors
                for (int i = 1; i < lines.Length; i++)
                {
                    //check for empty input
                    if (matrix[i][0] == "") all_error_messages += "Partnumber" + i + " is empty\n";
                    if (matrix[i][1] == "") all_error_messages += "Quantity" + i + " is empty\n";
                    if (matrix[i][2] == "") matrix[i][2] = "0"; //zero price if empty
                    if (matrix[i][3] == "") all_error_messages += "Place" + i + " is empty\n";
                    if (matrix[i][4] == "") all_error_messages += "idOrder" + i + " is empty\n";
                    if (matrix[i][5] == "") all_error_messages += "Owner" + i + " is empty\n";

                    if (all_error_messages != "")
                    {
                        MessageBox.Show(all_error_messages);
                        return;
                    }

                    //more complex errors
                    //check if pn exist
                    MySqlDataReader reader;
                    try
                    {
                        MySqlCommand command = new MySqlCommand("SELECT idComponent FROM Components " +
                            "WHERE Components.PartNumber LIKE \'" + matrix[i][0] + "\'", SQLconnection);
                        reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            all_error_messages += "Component " + matrix[i][0] + " does not exist in the database\n";
                        }
                        else
                        {
                            matrix[i][0] = reader[0].ToString();
                        }
                        reader.Close();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                        return;
                    }

                    //check if place exist
                    try
                    {
                        MySqlCommand command = new MySqlCommand("SELECT idStorage FROM Storages " +
                            "WHERE Storages.Place LIKE \'" + matrix[i][3] + "\'", SQLconnection);
                        reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            all_error_messages += "Storage " + matrix[i][3] + " does not exist in the database\n";
                        }
                        else
                        {
                            matrix[i][3] = reader[0].ToString();
                        }
                        reader.Close();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                        return;
                    }

                    //check if order exist
                    try
                    {
                        MySqlCommand command = new MySqlCommand("SELECT idOrder FROM Orders " +
                            "WHERE Orders.idOrder = \'" + matrix[i][4] + "\'", SQLconnection);
                        reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            all_error_messages += "Order " + i + " does not exist in the database\n";
                        }
                        reader.Close();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                        return;
                    }

                    //check if owner exist
                    try
                    {
                        MySqlCommand command = new MySqlCommand("SELECT idPerson FROM Owners " +
                            "WHERE Owners.LastName LIKE \'" + matrix[i][5] + "\'", SQLconnection);
                        reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            all_error_messages += "Owner " + matrix[i][5] + " does not exist in the database\n";
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

                }
                //apply changes if no errors
                if (all_error_messages != "")
                {
                    MessageBox.Show(all_error_messages);
                    return;
                }
                //apply changes
                int addcnt = 0;
                try
                {
                    for (int i = 1; i < lines.Length; i++)
                        if (FormAddItem.add_single_item(this.SQLconnection, matrix[i][1], matrix[i][2], int.Parse(matrix[i][3]), int.Parse(matrix[i][4]), int.Parse(matrix[i][0]), int.Parse(matrix[i][5])))
                            addcnt++;

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                    return;
                }
                MessageBox.Show("Added " + addcnt + " new items");
            }
        }
    }
}
