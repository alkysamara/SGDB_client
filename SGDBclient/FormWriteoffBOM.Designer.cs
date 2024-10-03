namespace SGDBclient
{
    partial class FormWriteoffBOM
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnWriteOff = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btn_project = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_pcb_count = new System.Windows.Forms.TextBox();
            this.btn_addRow = new System.Windows.Forms.Button();
            this.pn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.q = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.scanBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.chbCountOnce = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.selectBtn,
            this.scanBtn,
            this.chbCountOnce});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(686, 425);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnWriteOff
            // 
            this.btnWriteOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWriteOff.Location = new System.Drawing.Point(704, 70);
            this.btnWriteOff.Name = "btnWriteOff";
            this.btnWriteOff.Size = new System.Drawing.Size(75, 23);
            this.btnWriteOff.TabIndex = 1;
            this.btnWriteOff.Text = "WriteOff";
            this.btnWriteOff.UseVisualStyleBackColor = true;
            this.btnWriteOff.Click += new System.EventHandler(this.btnWriteOff_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(704, 99);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btn_project
            // 
            this.btn_project.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_project.Location = new System.Drawing.Point(704, 12);
            this.btn_project.Name = "btn_project";
            this.btn_project.Size = new System.Drawing.Size(75, 23);
            this.btn_project.TabIndex = 3;
            this.btn_project.Text = "Set project";
            this.btn_project.UseVisualStyleBackColor = true;
            this.btn_project.Click += new System.EventHandler(this.btn_project_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(705, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PCBs:";
            // 
            // tb_pcb_count
            // 
            this.tb_pcb_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pcb_count.Location = new System.Drawing.Point(747, 126);
            this.tb_pcb_count.Name = "tb_pcb_count";
            this.tb_pcb_count.Size = new System.Drawing.Size(32, 20);
            this.tb_pcb_count.TabIndex = 5;
            this.tb_pcb_count.Text = "1";
            // 
            // btn_addRow
            // 
            this.btn_addRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addRow.Location = new System.Drawing.Point(704, 41);
            this.btn_addRow.Name = "btn_addRow";
            this.btn_addRow.Size = new System.Drawing.Size(75, 23);
            this.btn_addRow.TabIndex = 6;
            this.btn_addRow.Text = "Add Row";
            this.btn_addRow.UseVisualStyleBackColor = true;
            this.btn_addRow.Click += new System.EventHandler(this.btn_addRow_Click);
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
            // chbCountOnce
            // 
            this.chbCountOnce.HeaderText = "Count Once";
            this.chbCountOnce.Name = "chbCountOnce";
            this.chbCountOnce.Width = 40;
            // 
            // FormWriteoffBOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 449);
            this.Controls.Add(this.btn_addRow);
            this.Controls.Add(this.tb_pcb_count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_project);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnWriteOff);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormWriteoffBOM";
            this.Text = "FormWriteoffBOM";
            this.Shown += new System.EventHandler(this.FormWriteoffBOM_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnWriteOff;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btn_project;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pcb_count;
        private System.Windows.Forms.Button btn_addRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn pn;
        private System.Windows.Forms.DataGridViewTextBoxColumn q;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedItemDescription;
        private System.Windows.Forms.DataGridViewButtonColumn selectBtn;
        private System.Windows.Forms.DataGridViewButtonColumn scanBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chbCountOnce;
    }
}