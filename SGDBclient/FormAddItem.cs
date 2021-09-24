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

		public FormAddItem(MySql.Data.MySqlClient.MySqlConnection con) {
			InitializeComponent();
			SQLconnection = con;
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

		private void btnAdd_Click(object sender, EventArgs e) {
			//
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
	}
}
