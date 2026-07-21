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
	public partial class FormChangeText : Form {
		public string text = "";
		public FormChangeText(string initialText, string prompt) {
			InitializeComponent();
			textBoxText.Text = initialText;
			this.Text = prompt;
        }

		private void buttonOk_Click(object sender, EventArgs e) {
            text = textBoxText.Text;
			this.Close();
		}

		private void textBoxText_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				e.SuppressKeyPress = true;
				buttonOk_Click(sender, e);
			}
		}
	}
}
