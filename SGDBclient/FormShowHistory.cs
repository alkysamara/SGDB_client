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
    public partial class FormShowHistory : Form
    {
        private MySql.Data.MySqlClient.MySqlConnection SQLconnection;
        private string idItem;

        private void updateTable()
        {
            MySqlDataReader reader;
            try
            {
                string sql_querry = "SELECT * FROM Usages " +
                        "WHERE Item_idItem = " + idItem;

                MySqlCommand command = new MySqlCommand(sql_querry, SQLconnection);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                dataGridView1.Columns.Add(reader.GetName(i), reader.GetName(i));
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                if (reader.GetName(i).StartsWith("id") || reader.GetName(i).Contains("_id"))
                { //this is an id field, hide it
                    dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None; //switch off autosize
                    dataGridView1.Columns[i].Width = 1; //minimal width to 'hide' it
                }
                if (reader.GetName(i).Equals("Date"))
                {
                    dataGridView1.Columns[i].DefaultCellStyle.Format = "yyyy.MM.dd";
                }
            }
            while (reader.Read())
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < reader.FieldCount; j++)
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[j].Value = reader[j];
            }
            reader.Close();
        }
        public FormShowHistory(MySql.Data.MySqlClient.MySqlConnection con, string idItem)
        {
            InitializeComponent();
            SQLconnection = con;
            this.idItem = idItem;
            updateTable();
        }
    }
}
