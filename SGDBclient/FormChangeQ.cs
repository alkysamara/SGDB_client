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
	public partial class FormCHangeQ : Form {
		private MySql.Data.MySqlClient.MySqlConnection SQLconnection;
		private int idItem;
		public FormCHangeQ(MySql.Data.MySqlClient.MySqlConnection con, int idItem) {
			InitializeComponent();
			SQLconnection = con;
			this.idItem = idItem;

        }

		private void btnChange_Click(object sender, EventArgs e) {
			try {
				MySqlCommand command = new MySqlCommand("UPDATE `SGitemsDB`.`Items` SET `Quantity` = \'"+
					textBoxNewQ.Text +
					"\' WHERE (`idItem` = \'"+
                    idItem.ToString()+
                    "\')", SQLconnection); 
				command.ExecuteNonQuery();
				this.Close();
			} catch (Exception ee) {
				MessageBox.Show(ee.Message);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
