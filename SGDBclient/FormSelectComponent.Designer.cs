namespace SGDBclient
{
    partial class FormSelectComponent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectComponent));
            this.buttonSelect = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonRefreshTable = new System.Windows.Forms.Button();
            this.buttonAddComponent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditParams = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSearchString = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSelect
            // 
            this.buttonSelect.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSelect.Location = new System.Drawing.Point(0, 0);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 34);
            this.buttonSelect.TabIndex = 0;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(675, 218);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // buttonRefreshTable
            // 
            this.buttonRefreshTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRefreshTable.Location = new System.Drawing.Point(581, 0);
            this.buttonRefreshTable.Name = "buttonRefreshTable";
            this.buttonRefreshTable.Size = new System.Drawing.Size(94, 34);
            this.buttonRefreshTable.TabIndex = 2;
            this.buttonRefreshTable.Text = "Refresh table";
            this.buttonRefreshTable.UseVisualStyleBackColor = true;
            this.buttonRefreshTable.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonAddComponent
            // 
            this.buttonAddComponent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddComponent.Location = new System.Drawing.Point(174, 0);
            this.buttonAddComponent.Name = "buttonAddComponent";
            this.buttonAddComponent.Size = new System.Drawing.Size(100, 34);
            this.buttonAddComponent.TabIndex = 3;
            this.buttonAddComponent.Text = "Add component";
            this.buttonAddComponent.UseVisualStyleBackColor = true;
            this.buttonAddComponent.Click += new System.EventHandler(this.btnAddComponent_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditParams);
            this.panel1.Controls.Add(this.buttonSelect);
            this.panel1.Controls.Add(this.buttonRefreshTable);
            this.panel1.Controls.Add(this.buttonAddComponent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 34);
            this.panel1.TabIndex = 4;
            // 
            // btnEditParams
            // 
            this.btnEditParams.Location = new System.Drawing.Point(380, 0);
            this.btnEditParams.Name = "btnEditParams";
            this.btnEditParams.Size = new System.Drawing.Size(138, 34);
            this.btnEditParams.TabIndex = 4;
            this.btnEditParams.Text = "Edit parameters";
            this.btnEditParams.UseVisualStyleBackColor = true;
            this.btnEditParams.Click += new System.EventHandler(this.btnEditParams_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxSearchString);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 44);
            this.panel2.TabIndex = 5;
            // 
            // textBoxSearchString
            // 
            this.textBoxSearchString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchString.Location = new System.Drawing.Point(12, 12);
            this.textBoxSearchString.Name = "textBoxSearchString";
            this.textBoxSearchString.Size = new System.Drawing.Size(651, 20);
            this.textBoxSearchString.TabIndex = 0;
            this.textBoxSearchString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchString_KeyDown);
            // 
            // FormSelectComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 296);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSelectComponent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select component";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRefreshTable;
		private System.Windows.Forms.Button buttonAddComponent;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBoxSearchString;
        private System.Windows.Forms.Button btnEditParams;
    }
}