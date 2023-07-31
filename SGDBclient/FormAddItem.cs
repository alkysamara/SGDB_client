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

        }
    }
}
