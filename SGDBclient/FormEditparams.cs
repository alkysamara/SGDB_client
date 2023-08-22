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
        public FormEditParams(MySql.Data.MySqlClient.MySqlConnection con)
        {
            InitializeComponent();
            Sqlconnection = con;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {





            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }


    }
}
