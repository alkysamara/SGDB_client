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
		public FormChangeText(String initialText) {
			InitializeComponent();
			textBoxText.Text = initialText;
        }

		private void buttonOk_Click(object sender, EventArgs e) {
            text = textBoxText.Text;
			this.Close();
		}
	}
}
