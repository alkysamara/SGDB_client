using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGDBclient
{
    public partial class FormAddProject : Form
    {
        private MySql.Data.MySqlClient.MySqlConnection SQLconnection;
        public FormAddProject(MySql.Data.MySqlClient.MySqlConnection con)
        {
            InitializeComponent();
            SQLconnection = con;
        }

        private void btnAddProj_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO SGitemsDB.Projects (ProjectName)"+
                    "VALUES(\""+
                    textBoxAddProj.Text+"\")",SQLconnection);
                command.ExecuteNonQuery();
                this.Close();
            }
            catch( Exception ee ) 
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
