using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient; //use in pm console: Install-Package MySql.Data

namespace SGDBclient {
	public partial class FormSelectPackage : Form {
		public int selectedPackageID = 1;
		public string selectedPackageName = "";
		private MySql.Data.MySqlClient.MySqlConnection SQLconnection;
		private void updateTable() {
			MySqlDataReader reader;
			try {
				MySqlCommand command = new MySqlCommand("SELECT * FROM Packages " +
					"WHERE Packages.PackageName LIKE \'%" + textBoxSearchString.Text + "%\'", SQLconnection);
				reader = command.ExecuteReader();
			} catch (Exception e) {
				MessageBox.Show(e.Message);
				return;
			}
			dataGridView1.Rows.Clear();
			dataGridView1.Columns.Clear();
			for (int i = 0; i < reader.FieldCount; i++) {
				dataGridView1.Columns.Add(reader.GetName(i), reader.GetName(i));
				if (reader.GetName(i).StartsWith("id")) { //this is an id field, hide it
					dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None; //switch off autosize
					dataGridView1.Columns[i].Width = 1; //minimal width to 'hide' it
				}
			}
			while (reader.Read()) {
				dataGridView1.Rows.Add();
				for (int j = 0; j < reader.FieldCount; j++)
					dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[j].Value = reader[j];
			}
			reader.Close();
		}
		public FormSelectPackage(MySql.Data.MySqlClient.MySqlConnection con) {
			InitializeComponent();
			SQLconnection = con;
			updateTable();
		}

		private void button1_Click(object sender, EventArgs e) {
			try {
				//selectedPackageID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
				selectedPackageID = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
				selectedPackageName = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value;
			} catch (Exception) {
				selectedPackageID = 0;
			}
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e) {
			updateTable();
		}

		private void dataGridView1_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                button1_Click(sender, e);
			}
		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e) {
			button1_Click(sender, e);
		}

		private void btnAddPackage_Click(object sender, EventArgs e) {
			FormAddPackage form = new FormAddPackage(SQLconnection);
			form.ShowDialog();
			updateTable();
		}

        private void textBoxSearchString_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                updateTable();
            }
        }

        private void FormSelectPackage_Shown(object sender, EventArgs e)
        {
            textBoxSearchString.Focus();
        }

		private void btn_fromClipboard_Click(object sender, EventArgs e) {
			try {
				const int max_image_size_package = 300;
				Image img = Clipboard.GetImage();
				int sizex = img.Width;
				int sizey = img.Height;
				int m = Math.Max(sizex, sizey);
				if (m > max_image_size_package) {
					int newsizex = sizex * max_image_size_package / m;
					int newsizey = sizey * max_image_size_package / m;
					Image newImage = new Bitmap(newsizex, newsizey);
					Graphics.FromImage(newImage).DrawImage(img, 0, 0, newsizex, newsizey);
					pictureBox1.Image = newImage;
				} else {
					pictureBox1.Image = img;
				}
				pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

				img = pictureBox1.Image;

				var ms = new MemoryStream();
				img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
				byte[] b = ms.ToArray();

				int currentSelectedItemID = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["idPackage"].Value;

				MySqlCommand command = new MySqlCommand("", SQLconnection);

				command.CommandText = "UPDATE Packages SET Img = @userImage WHERE idPackage = " + currentSelectedItemID;

				MySqlParameter paramUserImage = new MySqlParameter("@userImage", MySqlDbType.Blob, b.Length);

				paramUserImage.Value = b;

				command.Parameters.Add(paramUserImage);

				command.ExecuteNonQuery();
			} catch (Exception ex) {
				MessageBox.Show("There was a problem when creating new image: " + ex.Message);
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
			MySqlDataReader reader;
			try {
				int currentSelectedPackageID = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["idPackage"].Value;
				MySqlCommand command = new MySqlCommand("SELECT Img FROM Packages WHERE idPackage = " + currentSelectedPackageID, SQLconnection);
				reader = command.ExecuteReader();
				reader.Read();
				if (!reader[0].GetType().Equals(typeof(DBNull))) {
					byte[] imageBytes = (byte[])reader[0];
					reader.Close();
					pictureBox1.Image = Image.FromStream(new MemoryStream(imageBytes));
					pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
				} else {
					pictureBox1.Image = null;
					reader.Close();
				}
			} catch (Exception ex) {
				MessageBox.Show("There was a problem when loading image from database: " + ex.Message);
			}
		}
	}
}
