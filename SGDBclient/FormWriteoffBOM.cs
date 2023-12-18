using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGDBclient
{
    public partial class FormWriteoffBOM : Form
    {
        public FormWriteoffBOM()
        {
            InitializeComponent();
        }

        private void FormWriteoffBOM_Shown(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files(*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string all_error_messages = "";
                string path = ofd.FileName;
                string[] lines;
                try
                {
                    lines = System.IO.File.ReadAllLines(path, Encoding.GetEncoding(1251));//windows encoding to allow cyrilic letters
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                    return;
                }
                string[][] matrix = new string[lines.Length][];
                //get a matrix
                for (int i = 0; i < lines.Length; i++)
                {
                    matrix[i] = lines[i].Split(';');
                }
                string[] pn = new string[lines.Length-1];
                int[] qs = new int[lines.Length-1];
                for (int i = 1; i < lines.Length; i++)
                {
                    if (matrix[i][0] == "") all_error_messages += "Partnumber" + i + " is empty\n";
                    if (!int.TryParse(matrix[i][1], out qs[i-1])) all_error_messages += i + " quantity is bad\n";
                    pn[i-1] = matrix[i][0];
                }
                if (all_error_messages != "")
                {
                    MessageBox.Show(all_error_messages);
                    this.Close();
                    return;
                }
                //nothing bad in CSV, build a table
                dataGridView1.Rows.Add(pn.Length-1);
                for (int i = 0; i < pn.Length; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = pn[i];
                    dataGridView1.Rows[i].Cells[1].Value = qs[i];
                }

            }
            else
            {
                this.Close();
                return;
            }
        }
    }
}
