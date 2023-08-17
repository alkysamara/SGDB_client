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
		
		
		public FormCHangeQ(MySql.Data.MySqlClient.MySqlConnection con, int idItem, int Qty) {
			InitializeComponent();
			SQLconnection = con;
			this.idItem = idItem;
			textBoxData.Text = DateTime.Today.ToShortDateString();
			textBoxCurQ.Text = Qty.ToString();
			

        }

		private void btnChange_Click(object sender, EventArgs e) {
			try {
				MySqlCommand command = new MySqlCommand("CALL writeOff("+
					textBoxNeedQ.Text+','+
					DateTime.Today.ToString()+','+
                    idItem.ToString()+'+'+
					comboBoxProj.Text+','+
					textBoxComment.Text+
                    ")", SQLconnection); 
				command.ExecuteNonQuery();
				this.Close();
			} catch (Exception ee) {
				MessageBox.Show(ee.Message);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			this.Close();
		}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormCHangeQ_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxProj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCurQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProj_Click(object sender, EventArgs e)
        {
            FormAddProject fromAddProj = new FormAddProject(SQLconnection);
            fromAddProj.ShowDialog();

        }
    }
}
