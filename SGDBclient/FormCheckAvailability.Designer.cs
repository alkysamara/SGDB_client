namespace SGDBclient
{
    partial class FormCheckAvailability
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckAvailability));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.q = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suitableFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.scanBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addAlternativeBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCountAvailable = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btn_addRow = new System.Windows.Forms.Button();
            this.labelAvailableCount = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pn,
            this.q,
            this.selectedItem,
            this.idItem,
            this.SelectedItemDescription,
            this.availableQ,
            this.suitableFor,
            this.selectBtn,
            this.scanBtn,
            this.addAlternativeBtn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(941, 425);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pn
            // 
            this.pn.HeaderText = "PartNumber";
            this.pn.Name = "pn";
            // 
            // q
            // 
            this.q.HeaderText = "Quantity";
            this.q.Name = "q";
            // 
            // selectedItem
            // 
            this.selectedItem.HeaderText = "Selected Item";
            this.selectedItem.Name = "selectedItem";
            this.selectedItem.ReadOnly = true;
            // 
            // idItem
            // 
            this.idItem.HeaderText = "idItem";
            this.idItem.Name = "idItem";
            this.idItem.ReadOnly = true;
            this.idItem.Visible = false;
            // 
            // SelectedItemDescription
            // 
            this.SelectedItemDescription.HeaderText = "Selected Item Description";
            this.SelectedItemDescription.Name = "SelectedItemDescription";
            this.SelectedItemDescription.ReadOnly = true;
            // 
            // availableQ
            // 
            this.availableQ.HeaderText = "Available Q";
            this.availableQ.Name = "availableQ";
            this.availableQ.ReadOnly = true;
            // 
            // suitableFor
            // 
            this.suitableFor.HeaderText = "Suitable for";
            this.suitableFor.Name = "suitableFor";
            this.suitableFor.ReadOnly = true;
            // 
            // selectBtn
            // 
            this.selectBtn.HeaderText = "Select Item";
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.selectBtn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // scanBtn
            // 
            this.scanBtn.HeaderText = "Scan";
            this.scanBtn.Name = "scanBtn";
            this.scanBtn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.scanBtn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // addAlternativeBtn
            // 
            this.addAlternativeBtn.HeaderText = "Add alternative";
            this.addAlternativeBtn.Name = "addAlternativeBtn";
            // 
            // btnCountAvailable
            // 
            this.btnCountAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCountAvailable.Location = new System.Drawing.Point(959, 41);
            this.btnCountAvailable.Name = "btnCountAvailable";
            this.btnCountAvailable.Size = new System.Drawing.Size(75, 23);
            this.btnCountAvailable.TabIndex = 1;
            this.btnCountAvailable.Text = "Count availabe";
            this.btnCountAvailable.UseVisualStyleBackColor = true;
            this.btnCountAvailable.Click += new System.EventHandler(this.btnCountAvailable_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(959, 113);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btn_addRow
            // 
            this.btn_addRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addRow.Location = new System.Drawing.Point(959, 12);
            this.btn_addRow.Name = "btn_addRow";
            this.btn_addRow.Size = new System.Drawing.Size(75, 23);
            this.btn_addRow.TabIndex = 6;
            this.btn_addRow.Text = "Add Row";
            this.btn_addRow.UseVisualStyleBackColor = true;
            this.btn_addRow.Click += new System.EventHandler(this.btn_addRow_Click);
            // 
            // labelAvailableCount
            // 
            this.labelAvailableCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAvailableCount.AutoSize = true;
            this.labelAvailableCount.Location = new System.Drawing.Point(959, 139);
            this.labelAvailableCount.Name = "labelAvailableCount";
            this.labelAvailableCount.Size = new System.Drawing.Size(59, 13);
            this.labelAvailableCount.TabIndex = 7;
            this.labelAvailableCount.Text = "Max PCBs:";
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.Location = new System.Drawing.Point(959, 70);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 37);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // FormCheckAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 449);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.labelAvailableCount);
            this.Controls.Add(this.btn_addRow);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCountAvailable);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCheckAvailability";
            this.Text = "FormCheckAvailability";
            this.Shown += new System.EventHandler(this.FormCheckAvailability_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCountAvailable;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btn_addRow;
        private System.Windows.Forms.Label labelAvailableCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn pn;
		private System.Windows.Forms.DataGridViewTextBoxColumn q;
		private System.Windows.Forms.DataGridViewTextBoxColumn selectedItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn idItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn SelectedItemDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn availableQ;
		private System.Windows.Forms.DataGridViewTextBoxColumn suitableFor;
		private System.Windows.Forms.DataGridViewButtonColumn selectBtn;
		private System.Windows.Forms.DataGridViewButtonColumn scanBtn;
		private System.Windows.Forms.DataGridViewButtonColumn addAlternativeBtn;
        private System.Windows.Forms.Button btnReport;
    }
}