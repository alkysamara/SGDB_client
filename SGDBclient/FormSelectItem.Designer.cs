namespace SGDBclient
{
    partial class FormSelectItem
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
            this.buttonSelect = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonRefreshTable = new System.Windows.Forms.Button();
            this.buttonAddComponent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_check_availability = new System.Windows.Forms.Button();
            this.btn_change_q = new System.Windows.Forms.Button();
            this.btn_component_filter = new System.Windows.Forms.Button();
            this.btn_package_filter = new System.Windows.Forms.Button();
            this.chb_Component_filter = new System.Windows.Forms.CheckBox();
            this.chb_package_filter = new System.Windows.Forms.CheckBox();
            this.textBoxComponent = new System.Windows.Forms.TextBox();
            this.textBoxPackage = new System.Windows.Forms.TextBox();
            this.btn_component_type_filter = new System.Windows.Forms.Button();
            this.chb_ctype_filter = new System.Windows.Forms.CheckBox();
            this.textBoxCType = new System.Windows.Forms.TextBox();
            this.chb_storage_filter = new System.Windows.Forms.CheckBox();
            this.btn_storage_filter = new System.Windows.Forms.Button();
            this.textBoxStorage = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(843, 450);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // buttonRefreshTable
            // 
            this.buttonRefreshTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRefreshTable.Location = new System.Drawing.Point(749, 0);
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
            this.buttonAddComponent.Location = new System.Drawing.Point(377, 0);
            this.buttonAddComponent.Name = "buttonAddComponent";
            this.buttonAddComponent.Size = new System.Drawing.Size(75, 34);
            this.buttonAddComponent.TabIndex = 3;
            this.buttonAddComponent.Text = "Add component";
            this.buttonAddComponent.UseVisualStyleBackColor = true;
            this.buttonAddComponent.Click += new System.EventHandler(this.btnAddComponent_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSelect);
            this.panel1.Controls.Add(this.buttonRefreshTable);
            this.panel1.Controls.Add(this.buttonAddComponent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 576);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 34);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_check_availability);
            this.panel2.Controls.Add(this.btn_change_q);
            this.panel2.Controls.Add(this.btn_component_filter);
            this.panel2.Controls.Add(this.btn_package_filter);
            this.panel2.Controls.Add(this.chb_Component_filter);
            this.panel2.Controls.Add(this.chb_package_filter);
            this.panel2.Controls.Add(this.textBoxComponent);
            this.panel2.Controls.Add(this.textBoxPackage);
            this.panel2.Controls.Add(this.btn_component_type_filter);
            this.panel2.Controls.Add(this.chb_ctype_filter);
            this.panel2.Controls.Add(this.textBoxCType);
            this.panel2.Controls.Add(this.chb_storage_filter);
            this.panel2.Controls.Add(this.btn_storage_filter);
            this.panel2.Controls.Add(this.textBoxStorage);
            this.panel2.Controls.Add(this.textBoxSearchString);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 126);
            this.panel2.TabIndex = 5;
            // 
            // btn_check_availability
            // 
            this.btn_check_availability.Location = new System.Drawing.Point(690, 35);
            this.btn_check_availability.Name = "btn_check_availability";
            this.btn_check_availability.Size = new System.Drawing.Size(141, 23);
            this.btn_check_availability.TabIndex = 32;
            this.btn_check_availability.Text = "Check BOM availability";
            this.btn_check_availability.UseVisualStyleBackColor = true;
            this.btn_check_availability.Click += new System.EventHandler(this.btn_check_availability_Click);
            // 
            // btn_change_q
            // 
            this.btn_change_q.Location = new System.Drawing.Point(453, 88);
            this.btn_change_q.Name = "btn_change_q";
            this.btn_change_q.Size = new System.Drawing.Size(141, 23);
            this.btn_change_q.TabIndex = 31;
            this.btn_change_q.Text = "Change Quantity";
            this.btn_change_q.UseVisualStyleBackColor = true;
            this.btn_change_q.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_component_filter
            // 
            this.btn_component_filter.Location = new System.Drawing.Point(453, 37);
            this.btn_component_filter.Name = "btn_component_filter";
            this.btn_component_filter.Size = new System.Drawing.Size(141, 23);
            this.btn_component_filter.TabIndex = 30;
            this.btn_component_filter.Text = "Select component";
            this.btn_component_filter.UseVisualStyleBackColor = true;
            this.btn_component_filter.Click += new System.EventHandler(this.btn_component_filter_Click);
            // 
            // btn_package_filter
            // 
            this.btn_package_filter.Location = new System.Drawing.Point(157, 88);
            this.btn_package_filter.Name = "btn_package_filter";
            this.btn_package_filter.Size = new System.Drawing.Size(141, 23);
            this.btn_package_filter.TabIndex = 27;
            this.btn_package_filter.Text = "Select package";
            this.btn_package_filter.UseVisualStyleBackColor = true;
            this.btn_package_filter.Click += new System.EventHandler(this.btn_package_filter_Click);
            // 
            // chb_Component_filter
            // 
            this.chb_Component_filter.AutoSize = true;
            this.chb_Component_filter.Location = new System.Drawing.Point(308, 42);
            this.chb_Component_filter.Name = "chb_Component_filter";
            this.chb_Component_filter.Size = new System.Drawing.Size(15, 14);
            this.chb_Component_filter.TabIndex = 29;
            this.chb_Component_filter.UseVisualStyleBackColor = true;
            // 
            // chb_package_filter
            // 
            this.chb_package_filter.AutoSize = true;
            this.chb_package_filter.Location = new System.Drawing.Point(12, 93);
            this.chb_package_filter.Name = "chb_package_filter";
            this.chb_package_filter.Size = new System.Drawing.Size(15, 14);
            this.chb_package_filter.TabIndex = 26;
            this.chb_package_filter.UseVisualStyleBackColor = true;
            // 
            // textBoxComponent
            // 
            this.textBoxComponent.Enabled = false;
            this.textBoxComponent.Location = new System.Drawing.Point(325, 39);
            this.textBoxComponent.Name = "textBoxComponent";
            this.textBoxComponent.Size = new System.Drawing.Size(122, 20);
            this.textBoxComponent.TabIndex = 28;
            this.textBoxComponent.Text = "<click select>";
            // 
            // textBoxPackage
            // 
            this.textBoxPackage.Enabled = false;
            this.textBoxPackage.Location = new System.Drawing.Point(29, 90);
            this.textBoxPackage.Name = "textBoxPackage";
            this.textBoxPackage.Size = new System.Drawing.Size(122, 20);
            this.textBoxPackage.TabIndex = 25;
            this.textBoxPackage.Text = "<click select>";
            // 
            // btn_component_type_filter
            // 
            this.btn_component_type_filter.Location = new System.Drawing.Point(157, 62);
            this.btn_component_type_filter.Name = "btn_component_type_filter";
            this.btn_component_type_filter.Size = new System.Drawing.Size(141, 23);
            this.btn_component_type_filter.TabIndex = 24;
            this.btn_component_type_filter.Text = "Select Component Type";
            this.btn_component_type_filter.UseVisualStyleBackColor = true;
            this.btn_component_type_filter.Click += new System.EventHandler(this.button1_Click);
            // 
            // chb_ctype_filter
            // 
            this.chb_ctype_filter.AutoSize = true;
            this.chb_ctype_filter.Location = new System.Drawing.Point(12, 67);
            this.chb_ctype_filter.Name = "chb_ctype_filter";
            this.chb_ctype_filter.Size = new System.Drawing.Size(15, 14);
            this.chb_ctype_filter.TabIndex = 23;
            this.chb_ctype_filter.UseVisualStyleBackColor = true;
            // 
            // textBoxCType
            // 
            this.textBoxCType.Enabled = false;
            this.textBoxCType.Location = new System.Drawing.Point(29, 64);
            this.textBoxCType.Name = "textBoxCType";
            this.textBoxCType.Size = new System.Drawing.Size(122, 20);
            this.textBoxCType.TabIndex = 22;
            this.textBoxCType.Text = "<click select>";
            // 
            // chb_storage_filter
            // 
            this.chb_storage_filter.AutoSize = true;
            this.chb_storage_filter.Location = new System.Drawing.Point(12, 41);
            this.chb_storage_filter.Name = "chb_storage_filter";
            this.chb_storage_filter.Size = new System.Drawing.Size(15, 14);
            this.chb_storage_filter.TabIndex = 9;
            this.chb_storage_filter.UseVisualStyleBackColor = true;
            // 
            // btn_storage_filter
            // 
            this.btn_storage_filter.Location = new System.Drawing.Point(157, 36);
            this.btn_storage_filter.Name = "btn_storage_filter";
            this.btn_storage_filter.Size = new System.Drawing.Size(141, 23);
            this.btn_storage_filter.TabIndex = 8;
            this.btn_storage_filter.Text = "Select storage";
            this.btn_storage_filter.UseVisualStyleBackColor = true;
            this.btn_storage_filter.Click += new System.EventHandler(this.btn_storage_filter_Click);
            // 
            // textBoxStorage
            // 
            this.textBoxStorage.Enabled = false;
            this.textBoxStorage.Location = new System.Drawing.Point(29, 38);
            this.textBoxStorage.Name = "textBoxStorage";
            this.textBoxStorage.Size = new System.Drawing.Size(122, 20);
            this.textBoxStorage.TabIndex = 7;
            this.textBoxStorage.Text = "<click select>";
            // 
            // textBoxSearchString
            // 
            this.textBoxSearchString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchString.Location = new System.Drawing.Point(12, 12);
            this.textBoxSearchString.Name = "textBoxSearchString";
            this.textBoxSearchString.Size = new System.Drawing.Size(819, 20);
            this.textBoxSearchString.TabIndex = 0;
            this.textBoxSearchString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchString_KeyDown);
            // 
            // FormSelectItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 610);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormSelectItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select item";
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
        private System.Windows.Forms.TextBox textBoxStorage;
        private System.Windows.Forms.Button btn_storage_filter;
        private System.Windows.Forms.CheckBox chb_storage_filter;
        private System.Windows.Forms.Button btn_package_filter;
        private System.Windows.Forms.CheckBox chb_package_filter;
        private System.Windows.Forms.TextBox textBoxPackage;
        private System.Windows.Forms.Button btn_component_type_filter;
        private System.Windows.Forms.CheckBox chb_ctype_filter;
        private System.Windows.Forms.TextBox textBoxCType;
        private System.Windows.Forms.Button btn_component_filter;
        private System.Windows.Forms.CheckBox chb_Component_filter;
        private System.Windows.Forms.TextBox textBoxComponent;
        private System.Windows.Forms.Button btn_change_q;
        private System.Windows.Forms.Button btn_check_availability;
    }
}