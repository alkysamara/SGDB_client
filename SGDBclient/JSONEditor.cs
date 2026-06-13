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
		private string[] paramDescriptions;

        public JSONEditor() {
			InitializeComponent();
			JSON = "'{}'";
        }

		public void setList(string[] paramNames)
		{
            cb_param_name.Items.Clear();
			cb_param_name.Items.AddRange(paramNames);
			paramDescriptions = new string[paramNames.Length];
		}
		public void setList(string[] paramNames, string[] paramDescriptions)
		{
			cb_param_name.Items.Clear();
			cb_param_name.Items.AddRange(paramNames);
			this.paramDescriptions = paramDescriptions;
		}

		private void button1_Click(object sender, EventArgs e) {
			if (tb_JSON.Text == "") tb_JSON.Text = "{}";
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

        private void button2_Click(object sender, EventArgs e)
        {
			param_values.Clear();
			tb_JSON.Text = "";
        }

		private void cb_param_name_SelectedIndexChanged(object sender, EventArgs e)
		{
			label3.Text = paramDescriptions[cb_param_name.SelectedIndex];
			string val = "";
			if (param_values.TryGetValue(cb_param_name.Text, out val))
			{
				tb_param_value.Text = val;
			}
			else{
				tb_param_value.Text = "";
			}
		}
	}
}
