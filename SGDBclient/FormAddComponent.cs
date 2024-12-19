using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //use in pm console: Install-Package MySql.Data

namespace SGDBclient {
	public partial class FormAddComponent : Form {
		private MySql.Data.MySqlClient.MySqlConnection SQLconnection;
		private JSONEditor jsonEditorParameters, jsonEditorLinks;
		private FormSelectComponentType formSelectComponentType;
		private FormSelectPackage formSelectPackage;
		public FormAddComponent(MySql.Data.MySqlClient.MySqlConnection con) {
			InitializeComponent();
			SQLconnection = con;
			jsonEditorParameters = new JSONEditor();
			jsonEditorLinks = new JSONEditor();
			formSelectComponentType = new FormSelectComponentType(SQLconnection);
			formSelectPackage = new FormSelectPackage(SQLconnection);
		}
        public string[] get_params_from_componentType(int id)
        {
            string[] results;
            string json;
            try
            {
                MySqlDataReader reader;
                MySqlCommand command = new MySqlCommand("SELECT TypeParameters FROM ComponentTypes WHERE ComponentTypes.idComponentType = " + id, SQLconnection);
                command.ExecuteNonQuery();
                reader = command.ExecuteReader();
                reader.Read();
                json = reader[0].ToString();
                reader.Close();
                Dictionary<string, string>  results_dict = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
                results = results_dict.Keys.ToArray<string>();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                return new string[] { "" };
            }
            return results;
        }

        public static bool addSingleComponent(MySql.Data.MySqlClient.MySqlConnection SQLconnection, string PartNumber, string Parameters, string Links, 
			string ComponentType_idComponentType, string Packages_idPackage, string Description)
		{
            try
            {
                if (Links == "{}") Links = "\"{}\"";
                if (Parameters == "{}") Parameters = "\"{}\"";
                MySqlCommand command = new MySqlCommand("INSERT INTO `SGitemsDB`.`Components` (`PartNumber`, `Parameters`, " +
                    "`Links`, `ComponentType_idComponentType`, `Packages_idPackage`, `Description`) VALUES(\'" +
                    PartNumber + "\'," +
                    Parameters + "," +
                    Links + ",\'" +
                    ComponentType_idComponentType + "\',\'" +
                    Packages_idPackage + "\',\'" +
                    Description + "\'" +
                    ")", SQLconnection);
                command.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
				return false;
            }
			return true;
        }

		private void btnAdd_Click(object sender, EventArgs e) {
			if (formSelectComponentType.selectedComponentTypeID == 0) {
				MessageBox.Show("You should specify Component type");
				return;
			}
			if (formSelectPackage.selectedPackageID == 0) {
				MessageBox.Show("You should specify Package");
				return;
			}
			
			try {
                if (addSingleComponent(this.SQLconnection, textBoxPartNumber.Text, jsonEditorParameters.JSON, jsonEditorLinks.JSON,
					formSelectComponentType.selectedComponentTypeID.ToString(), formSelectPackage.selectedPackageID.ToString(), textBoxDescription.Text))
				    this.Close();
			} catch (Exception ee) {
				MessageBox.Show(ee.Message);
			}
		}

		private void buttonEditParameters_Click(object sender, EventArgs e)
        {
            jsonEditorParameters.StartPosition = FormStartPosition.CenterParent;
            jsonEditorParameters.ShowDialog();
		}

		private void buttonEditLinks_Click(object sender, EventArgs e) {
            jsonEditorLinks.setList(new string[] { "Datasheet" });
            jsonEditorLinks.StartPosition = FormStartPosition.CenterParent;
            jsonEditorLinks.ShowDialog();
		}

		private void buttonEditComponentType_Click(object sender, EventArgs e)
        {
            formSelectComponentType.StartPosition = FormStartPosition.CenterParent;
            formSelectComponentType.ShowDialog();
			labelSelectedComponentType.Text = formSelectComponentType.selectedComponentTypeName;
            jsonEditorParameters.setList(get_params_from_componentType(formSelectComponentType.selectedComponentTypeID));
        }

		private void buttonEditPackage_Click(object sender, EventArgs e)
        {
            formSelectPackage.StartPosition = FormStartPosition.CenterParent;
            formSelectPackage.ShowDialog();
			labelSelectedPackage.Text = formSelectPackage.selectedPackageName;
		}

        private void btn_addFromCSV_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("File format: PartNumber, Parameters, Links, ComponentType, Package, Description");
            int posPartNumber = 0, posParameters = 1, posLinks = 2, posComponentTypes = 3, posPackage = 4, posDescription = 5;
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
                if (matrix[0].Length != 6)
                {
                    MessageBox.Show("Input file was in wrong format");
                    return;
                }
                //check all lines for errors
                for (int i = 1; i < lines.Length; i++)
                {
                    if (matrix[i][posPartNumber] == "") all_error_messages += "Partnumber" + i + " is empty\n";
                    //check if pn exist
                    MySqlDataReader reader;
                    try
                    {
                        MySqlCommand command = new MySqlCommand("SELECT idComponent FROM Components " +
                            "WHERE Components.PartNumber LIKE \'" + matrix[i][posPartNumber] + "\'", SQLconnection);
                        reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            all_error_messages += "Component " + matrix[i][posPartNumber] + " already exist in the database\n";
                        }
                        reader.Close();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                        return;
                    }

                    if (matrix[i][posParameters] == "") matrix[i][posParameters] = "\"{}\"";
                    if (matrix[i][posLinks] == "") matrix[i][posLinks] = "\"{}\"";
                    if (matrix[i][posComponentTypes] == "") all_error_messages += "Component type" + i + " is empty\n";
                    //check if ct exist
                    try
                    {
                        MySqlCommand command = new MySqlCommand("SELECT idComponentType FROM ComponentTypes " +
                            "WHERE ComponentTypes.TypeName LIKE \'" + matrix[i][posComponentTypes] + "\'", SQLconnection);
                        reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            all_error_messages += "ComponentType " + matrix[i][posComponentTypes] + " does not exist in the database\n";
                        }
                        else
                        {
                            matrix[i][posComponentTypes] = reader[0].ToString();
                        }
                        reader.Close();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                        return;
                    }

                    if (matrix[i][posPackage] == "") all_error_messages += "Package" + i + " is empty\n";
                    //check if package exist
                    try
                    {
                        MySqlCommand command = new MySqlCommand("SELECT idPackage FROM Packages " +
                            "WHERE Packages.PackageName LIKE \'" + matrix[i][posPackage] + "\'", SQLconnection);
                        reader = command.ExecuteReader();
                        if (!reader.Read())
                        {
                            all_error_messages += "Package " + matrix[i][posPackage] + " does not exist in the database\n";
                        }
                        else
                        {
                            matrix[i][posPackage] = reader[0].ToString();
                        }
                        reader.Close();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                        return;
                    }

                    if (matrix[i][posDescription] == "") all_error_messages += "Description" + i + " is empty\n";
                }
                //apply changes if no errors
                if (all_error_messages != "")
                {
                    MessageBox.Show(all_error_messages);
                    return;
                }
                //apply changes
                int addcnt = 0;
                try
                {
                    for (int i = 1; i < lines.Length; i++)
                        if (FormAddComponent.addSingleComponent(this.SQLconnection, matrix[i][posPartNumber], matrix[i][posParameters], matrix[i][posLinks], matrix[i][posComponentTypes], matrix[i][posPackage], matrix[i][posDescription]))
                            addcnt++;

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                    return;
                }
                MessageBox.Show("Added " + addcnt + " new components");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClick_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
