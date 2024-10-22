using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SGDBclient
{
    public partial class FormCheckAvailability : Form
    {
        private MySql.Data.MySqlClient.MySqlConnection SQLconnection;
        FormSelectProject formSelectedProject;
        private bool countSucessfull = false;

        public FormCheckAvailability(MySql.Data.MySqlClient.MySqlConnection connection)
        {
            this.SQLconnection = connection;
            InitializeComponent();
        }

        private void FormCheckAvailability_Shown(object sender, EventArgs e)
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
                    dataGridView1.Rows[i].Cells["selectBtn"].Value = "Select";
                }
                for (int i = 0; i < pn.Length; i++)
                {
                    dataGridView1.Rows[i].Cells["scanBtn"].Value = "Scan";
                }
                for (int i = 0; i < pn.Length; i++)
                {
                    dataGridView1.Rows[i].Cells["addAlternativeBtn"].Value = "Add alternative";
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

            if ((senderGrid.Columns[e.ColumnIndex].Name == "chbCountOnce")) return;

            if ((senderGrid.Columns[e.ColumnIndex].Name == "selectBtn") && (e.RowIndex >= 0)) //pressed select button
            {
                FormSelectItem fsi = new FormSelectItem(this.SQLconnection,(string)senderGrid.Rows[e.RowIndex].Cells[0].Value);
                fsi.ShowDialog();
                senderGrid.Rows[e.RowIndex].Cells["idItem"].Value = fsi.selectedItemID;
                senderGrid.Rows[e.RowIndex].Cells["selectedItem"].Value = fsi.selectedItemName;
                senderGrid.Rows[e.RowIndex].Cells["selectedItemDescription"].Value = fsi.selectedItemDescription;
                senderGrid.Rows[e.RowIndex].Cells["availableQ"].Value = fsi.selectedItemQ;
                senderGrid.Rows[e.RowIndex].Cells["selectBtn"].Value = "Change";
                fsi.Close();
            }
            if ((senderGrid.Columns[e.ColumnIndex].Name == "scanBtn") && (e.RowIndex >= 0)) //pressed scan button
            {
                FormScan fs = new FormScan();
                fs.StartPosition = FormStartPosition.CenterParent;
                fs.ShowDialog();
                if (fs.idText != "")
                {
                    try
                    {
                        int id;
                        if (!int.TryParse(fs.idText, out id))
                        {
                            MessageBox.Show("Code in wrong format!");
                            return;
                        }
                        MySqlDataReader reader;
                        string sql_querry = "SELECT PartNumber, Description, Quantity FROM full_item " +
                            "WHERE full_item.idItem = " + fs.idText;
                        MySqlCommand command = new MySqlCommand(sql_querry, SQLconnection);
                        reader = command.ExecuteReader();
                        reader.Read();
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Wrong Code or item does not exist");
                            return;
                        }
                        senderGrid.Rows[e.RowIndex].Cells["selectedItem"].Value = reader[0].ToString();
                        senderGrid.Rows[e.RowIndex].Cells["selectedItemDescription"].Value = reader[1].ToString();
                        senderGrid.Rows[e.RowIndex].Cells["availableQ"].Value = reader[2].ToString();
                        reader.Close();
                        senderGrid.Rows[e.RowIndex].Cells["idItem"].Value = id;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            if ((senderGrid.Columns[e.ColumnIndex].Name == "addAlternativeBtn") && (e.RowIndex >= 0) && (!dataGridView1.Rows[e.RowIndex].Cells["pn"].Value.ToString().Equals("")))
            {
                int index = e.RowIndex + 1;
                senderGrid.Rows.Insert(index, 1);
                dataGridView1.Rows[index].Cells["pn"].Value = "";
                dataGridView1.Rows[index].Cells["selectBtn"].Value = "Select";
                dataGridView1.Rows[index].Cells["scanBtn"].Value = "Scan";

            }

            //check selected item and use colors: green - ok, yellow and orange - need visual check
            string strInitial = senderGrid.Rows[e.RowIndex].Cells["pn"].Value.ToString();
            int offset = 0;
            while (strInitial.Equals(""))
            {
                offset++;
                if (e.RowIndex - offset < 0) break;
                strInitial = senderGrid.Rows[e.RowIndex-offset].Cells["pn"].Value.ToString();
            }
            var val = senderGrid.Rows[e.RowIndex].Cells["selectedItem"].Value;
            string strSelect;
            if (val != null)
                strSelect = val.ToString();
            else
                return;
            //if strSelect is not null => item was selected and further cells are not null
            string strDescription = senderGrid.Rows[e.RowIndex].Cells["selectedItemDescription"].Value.ToString();
            if (strInitial.Equals(strSelect))
            {
                senderGrid.Rows[e.RowIndex].Cells["selectedItem"].Style.BackColor = Color.Green;
            }else if (strInitial.Equals(strDescription))
            {
                senderGrid.Rows[e.RowIndex].Cells["selectedItemDescription"].Style.BackColor = Color.Green;
            }
            else
            {
                if (strSelect.Contains(strInitial) || strInitial.Contains(strSelect))
                {
                    senderGrid.Rows[e.RowIndex].Cells["selectedItem"].Style.BackColor = Color.Yellow;
                }else
                if (strDescription.Contains(strInitial) || strInitial.Contains(strDescription))
                {
                    senderGrid.Rows[e.RowIndex].Cells["selectedItemDescription"].Style.BackColor = Color.Yellow;
                }else
                {
                    senderGrid.Rows[e.RowIndex].Cells["selectedItem"].Style.BackColor = Color.Orange;
                    senderGrid.Rows[e.RowIndex].Cells["selectedItemDescription"].Style.BackColor = Color.Orange;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCountAvailable_Click(object sender, EventArgs e)
        {
            countSucessfull = false;
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
            int min_pcbs = int.MaxValue;
            int min_pcbs_index = 1;
            int j = 0, current_parent_index = 0, current_available_count = 0;
			int neededQ;

			try
            {
                while (j < dataGridView1.Rows.Count)
                {
                    if (!((string)dataGridView1.Rows[j].Cells["pn"].Value).Equals("")) //this is a new item
                    {
                        if (j > 0) //finish processing previous item
                        {
							neededQ = int.Parse(dataGridView1.Rows[current_parent_index].Cells["q"].Value.ToString());
							if (neededQ > 0)
							{
								int pcbs = current_available_count / neededQ;
								dataGridView1.Rows[current_parent_index].Cells["suitableFor"].Value = pcbs;
								if (pcbs < min_pcbs)
								{
									min_pcbs = pcbs;
									min_pcbs_index = current_parent_index;
								}
							}
                        }
                        current_parent_index = j;
                        current_available_count = int.Parse(dataGridView1.Rows[j].Cells["AvailableQ"].Value.ToString());
                    }
                    else //this is a next line of an older item
                    {
						current_available_count += int.Parse(dataGridView1.Rows[j].Cells["AvailableQ"].Value.ToString());
					}
                    j++;
                    
                }
				//finish the last item
				neededQ = int.Parse(dataGridView1.Rows[current_parent_index].Cells["q"].Value.ToString());
				if (neededQ > 0)
				{
					int pcbs = current_available_count / neededQ;
					dataGridView1.Rows[current_parent_index].Cells["suitableFor"].Value = pcbs;
					if (pcbs < min_pcbs)
					{
						min_pcbs = pcbs;
						min_pcbs_index = current_parent_index;
					}
				}
				//highlight the bottleneck
				dataGridView1.Rows[min_pcbs_index].Cells["AvailableQ"].Style.BackColor = Color.Orange;
				dataGridView1.Rows[min_pcbs_index].Cells["suitableFor"].Style.BackColor = Color.Orange;
				labelAvailableCount.Text = "Max PCBs: " + min_pcbs;
			}
			catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                return;
            }

            /*
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int q;
                if (dataGridView1.Rows[i].Cells["q"].Value.GetType() == typeof(int))
                    q = (int)dataGridView1.Rows[i].Cells["q"].Value;
                else
                    q = int.Parse((string)dataGridView1.Rows[i].Cells["q"].Value);
                if (!((bool)dataGridView1.Rows[i].Cells["chbCountOnce"].Value))
                    q *= board_count;
                if (get_q_by_itemid((int)dataGridView1.Rows[i].Cells["idItem"].Value) < q)
                {
                    all_errors += "Item " + dataGridView1.Rows[i].Cells[0].Value + " is not enough for this BOM\n";
                }
            }*/
            //check if project was selected

            if (all_errors.Length > 0)
            {
                MessageBox.Show(all_errors);
                return;
            }
            countSucessfull = true;
        }

        private void btn_project_Click(object sender, EventArgs e)
        {
            formSelectedProject = new FormSelectProject(this.SQLconnection);
            formSelectedProject.ShowDialog();
        }

        private void btn_addRow_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["selectBtn"].Value = "Select";
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["scanBtn"].Value = "Scan";
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["addAlternative"].Value = "Add alternative";
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            btnCountAvailable_Click(sender, e);
            if (!countSucessfull) return;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files(*.csv)|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string result = "PartNumber;Quantity;SelectedItem;idItem;SelectedItemDescription;AvailableQ;SuitableFor\r\n";
                try
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        result += dataGridView1.Rows[i].Cells["pn"].Value + ";";
                        result += dataGridView1.Rows[i].Cells["q"].Value + ";";
                        result += dataGridView1.Rows[i].Cells["selectedItem"].Value + ";";
                        result += dataGridView1.Rows[i].Cells["idItem"].Value + ";";
                        result += dataGridView1.Rows[i].Cells["SelectedItemDescription"].Value + ";";
                        result += dataGridView1.Rows[i].Cells["availableQ"].Value + ";";
                        result += dataGridView1.Rows[i].Cells["suitableFor"].Value + "\r\n";
                    }
                    System.IO.File.WriteAllText(sfd.FileName, result);
                    MessageBox.Show("Successfully written file");
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
