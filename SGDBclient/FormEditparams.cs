using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGDBclient
{
    public partial class FormEditParams : Form
    {
        private MySql.Data.MySqlClient.MySqlConnection Sqlconnection;
        private int idComponent;
        private string PartNumb;
        private string Descrip;
        public FormEditParams(MySql.Data.MySqlClient.MySqlConnection con, int id)
        {
            InitializeComponent();
            Sqlconnection = con;
            idComponent = id;

            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand("Select PartNumber, Description FROM SGitemsDB.Components WHERE idComponent = " +id,Sqlconnection);
            command.ExecuteNonQuery();
            reader = command.ExecuteReader();
            reader.Read();
            PartNumb = reader[0].ToString();
            Descrip = reader[1].ToString(); 
            reader.Close();
            textBoxPartNumb.Text = PartNumb;
            textBoxDescrip.Text = Descrip;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("Update SGitemsDB.Components " +
                   " SET " + " PartNumber = \"" + textBoxPartNumb.Text + "\"," +
                   " Description = \"" + textBoxDescrip.Text + "\""+
                   " WHERE idComponent = " +idComponent.ToString()+";",Sqlconnection);
                command.ExecuteNonQuery();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FormEditParams_Load(object sender, EventArgs e)
        {

        }
    }
}
