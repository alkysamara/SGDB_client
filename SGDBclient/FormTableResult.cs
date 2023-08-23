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
    public partial class FormTableResult : Form
    {
        public FormTableResult(string[] headers, object[][] data)
        {
            InitializeComponent();
            try
            {
                for (int i = 0; i < headers.Length; i++)
                {
                    dataGridView1.Columns.Add("c" + i, headers[i]);
                }
                for (int j=0;j< data.Length;j++)
                {
                    dataGridView1.Rows.Add(data[j]);
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Error while printing table results");
            }
        }
    }
}
