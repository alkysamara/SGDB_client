using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SGDBclient
{
    public partial class FormWriteoffBOM : Form
    {
        private MySql.Data.MySqlClient.MySqlConnection SQLconnection;
        FormSelectProject formSelectedProject;


        public FormWriteoffBOM(MySql.Data.MySqlClient.MySqlConnection connection)
        {
            this.SQLconnection = connection;
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
                if (pn.Length > 0)
                    dataGridView1.Rows.Add(pn.Length);
                for (int i = 0; i < pn.Length; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = pn[i];
                    dataGridView1.Rows[i].Cells[1].Value = qs[i];
                }
                for (int i = 0; i < pn.Length; i++)
                {
                    dataGridView1.Rows[i].Cells[4].Value = "Select";
                }
            }
            else
            {
                this.Close();
                return;
            }
        }

        private int get_q_by_itemid(int id)
        {
            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand("SELECT Quantity FROM Items " +
                "WHERE idItem = \'" + id + "\'", SQLconnection);
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                int result = (int)reader[0];
                reader.Close();
                return result;
            }
            else
            {
                reader.Close();
                throw new Exception("No component with id = " + id + " found in database");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                FormSelectItem fsi = new FormSelectItem(this.SQLconnection,(string)senderGrid.Rows[e.RowIndex].Cells[0].Value);
                fsi.ShowDialog();
                senderGrid.Rows[e.RowIndex].Cells["idItem"].Value = fsi.selectedItemID;
                senderGrid.Rows[e.RowIndex].Cells["selectedItem"].Value = fsi.selectedItemName;
                senderGrid.Rows[e.RowIndex].Cells["selectBtn"].Value = "Change";
                fsi.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWriteOff_Click(object sender, EventArgs e)
        {
            string all_errors = "";
            //check, that everything is selected
            for (int i = 0; i< dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["idItem"].Value == null)
                {
                    all_errors += "Item " + dataGridView1.Rows[i].Cells[0].Value + " is not set\n";
                }
            }
            if (all_errors.Length > 0)
            {
                MessageBox.Show(all_errors);
                return;
            }
            //check quantities
            int board_count = 1;
            if ((!int.TryParse(tb_pcb_count.Text, out board_count)) || (board_count<1))
            {
                MessageBox.Show("Board count incorrect!");
                return;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int q;
                if (dataGridView1.Rows[i].Cells["q"].Value.GetType() == typeof(int))
                    q = (int)dataGridView1.Rows[i].Cells["q"].Value;
                else
                    q = int.Parse((string)dataGridView1.Rows[i].Cells["q"].Value);
                if (get_q_by_itemid((int)dataGridView1.Rows[i].Cells["idItem"].Value) < q*board_count)
                {
                    all_errors += "Item " + dataGridView1.Rows[i].Cells[0].Value + " is not enough for this BOM\n";
                }
            }
            //check if project was selected
            if (formSelectedProject == null) 
            {
                all_errors += "Project was not set\n";
                MessageBox.Show(all_errors);
                return;
            }
            //writeoff components
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int q;
                if (dataGridView1.Rows[i].Cells["q"].Value.GetType() == typeof(int))
                    q = (int)dataGridView1.Rows[i].Cells["q"].Value;
                else
                    q = int.Parse((string)dataGridView1.Rows[i].Cells["q"].Value);
                try
                {
                    MySqlCommand command = new MySqlCommand("CALL writeOff(" +
                        q + ",\"" +
                        DateTime.Today.ToString("yyyy-MM-dd") + "\"," +
                        dataGridView1.Rows[i].Cells["idItem"].Value.ToString() + ",\"" +
                        formSelectedProject.selectedProjectName + "\",\"" +
                        "Used writeoff BOM" +
                        "\",\""+ System.Environment.MachineName+ "\")", SQLconnection);
                    command.ExecuteNonQuery();
                }
                catch (Exception ee)
                {
                    all_errors += "Trying writeoff " + dataGridView1.Rows[i].Cells[0].Value.ToString() + " failed with exception: " + ee.Message + "\n";
                }
            }
            if (all_errors.Length > 0)
            {
                MessageBox.Show(all_errors);
                return;
            }
            else
            {
                MessageBox.Show("Successfully written off all components");
                this.Close();
            }
        }

        private void btn_project_Click(object sender, EventArgs e)
        {
            formSelectedProject = new FormSelectProject(this.SQLconnection);
            formSelectedProject.ShowDialog();
        }
    }
}
