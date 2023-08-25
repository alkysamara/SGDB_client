namespace SGDBclient {
	partial class FormAddPackage {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPackageName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPackageType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownPinCount = new System.Windows.Forms.NumericUpDown();
            this.buttonJSONEditor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPinCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Package Name";
            // 
            // textBoxPackageName
            // 
            this.textBoxPackageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPackageName.Location = new System.Drawing.Point(122, 6);
            this.textBoxPackageName.MaxLength = 45;
            this.textBoxPackageName.Name = "textBoxPackageName";
            this.textBoxPackageName.Size = new System.Drawing.Size(150, 20);
            this.textBoxPackageName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Package Type";
            // 
            // textBoxPackageType
            // 
            this.textBoxPackageType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPackageType.Location = new System.Drawing.Point(122, 35);
            this.textBoxPackageType.MaxLength = 45;
            this.textBoxPackageType.Name = "textBoxPackageType";
            this.textBoxPackageType.Size = new System.Drawing.Size(150, 20);
            this.textBoxPackageType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Other parametres";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 30);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(206, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pins Count";
            // 
            // numericUpDownPinCount
            // 
            this.numericUpDownPinCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownPinCount.Location = new System.Drawing.Point(122, 66);
            this.numericUpDownPinCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownPinCount.Name = "numericUpDownPinCount";
            this.numericUpDownPinCount.Size = new System.Drawing.Size(149, 20);
            this.numericUpDownPinCount.TabIndex = 8;
            // 
            // buttonJSONEditor
            // 
            this.buttonJSONEditor.Location = new System.Drawing.Point(122, 99);
            this.buttonJSONEditor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonJSONEditor.Name = "buttonJSONEditor";
            this.buttonJSONEditor.Size = new System.Drawing.Size(149, 19);
            this.buttonJSONEditor.TabIndex = 9;
            this.buttonJSONEditor.Text = "Edit JSON";
            this.buttonJSONEditor.UseVisualStyleBackColor = true;
            this.buttonJSONEditor.Click += new System.EventHandler(this.buttonJSONEditor_Click);
            // 
            // FormAddPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 160);
            this.Controls.Add(this.buttonJSONEditor);
            this.Controls.Add(this.numericUpDownPinCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPackageType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPackageName);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(200, 45);
            this.Name = "FormAddPackage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddPackage";
            this.Load += new System.EventHandler(this.FormAddPackage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPinCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxPackageName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPackageType;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownPinCount;
        private System.Windows.Forms.Button buttonJSONEditor;
    }
}