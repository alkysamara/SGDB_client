using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGDBclient {
	public partial class FormEnterPassword : Form {
		public string password = "";
		public FormEnterPassword() {
			InitializeComponent();
		}

		private void textBoxPassword_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				e.SuppressKeyPress = true;
				buttonOk_Click(null, null);
			}
		}

		private void buttonOk_Click(object sender, EventArgs e) {
			password = textBoxPassword.Text;
			this.Close();
		}
	}
}
