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
	public partial class JSONEditor : Form {
		public string JSON;
		public JSONEditor() {
			InitializeComponent();
			JSON = "\'{}\'";
		}

		private void button1_Click(object sender, EventArgs e) {
			if (textBox1.Text == "") textBox1.Text = "\'{}\'";
			JSON = textBox1.Text;
			this.Close();
		}
	}
}
