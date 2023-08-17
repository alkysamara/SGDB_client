using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGDBclient {
	public partial class JSONEditor : Form {
		public string JSON;
		Dictionary<string, string> param_values = new Dictionary<string, string>();

        public JSONEditor() {
			InitializeComponent();
			JSON = "\'{}\'";
        }

		public void setList(string[] param_names)
		{
            cb_param_name.Items.Clear();
			cb_param_name.Items.AddRange(param_names);
        }

		private void button1_Click(object sender, EventArgs e) {
			if (tb_JSON.Text == "") tb_JSON.Text = "\'{}\'";
			JSON = "\'"+tb_JSON.Text+"\'";
			this.Close();
		}

        private void btn_add_Click(object sender, EventArgs e)
        {
			if (!param_values.TryGetValue(cb_param_name.Text, out _))
			{
				param_values.Add(cb_param_name.Text, tb_param_value.Text);
			}
            JSON = JsonSerializer.Serialize(param_values);
			tb_JSON.Text = JSON;
        }
    }
}
