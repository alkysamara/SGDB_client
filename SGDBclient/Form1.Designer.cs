namespace SGDBclient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnAddNewItem = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnWriteoffBOM = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// btnAddNewItem
			// 
			this.btnAddNewItem.Location = new System.Drawing.Point(13, 12);
			this.btnAddNewItem.Name = "btnAddNewItem";
			this.btnAddNewItem.Size = new System.Drawing.Size(134, 23);
			this.btnAddNewItem.TabIndex = 0;
			this.btnAddNewItem.Text = "Add new item";
			this.btnAddNewItem.UseVisualStyleBackColor = true;
			this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(89, 216);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(131, 23);
			this.btnConnect.TabIndex = 1;
			this.btnConnect.Text = "Run JSON editor";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 41);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(135, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Select Item";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnWriteoffBOM
			// 
			this.btnWriteoffBOM.Location = new System.Drawing.Point(165, 12);
			this.btnWriteoffBOM.Margin = new System.Windows.Forms.Padding(2);
			this.btnWriteoffBOM.Name = "btnWriteoffBOM";
			this.btnWriteoffBOM.Size = new System.Drawing.Size(142, 23);
			this.btnWriteoffBOM.TabIndex = 5;
			this.btnWriteoffBOM.Text = "WriteoffBOM";
			this.btnWriteoffBOM.UseVisualStyleBackColor = true;
			this.btnWriteoffBOM.Click += new System.EventHandler(this.selectPackage_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(165, 40);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(142, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "CheckAvailability";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 70);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(294, 254);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 335);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnWriteoffBOM);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.btnAddNewItem);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "SGDB client";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnWriteoffBOM;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}

