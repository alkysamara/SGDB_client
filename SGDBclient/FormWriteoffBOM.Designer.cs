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
            this.pn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.q = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectBtn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pn,
            this.q,
            this.selectedItem,
            this.selectBtn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 433);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnWriteOff
            // 
            this.btnWriteOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWriteOff.Location = new System.Drawing.Point(555, 12);
            this.btnWriteOff.Name = "btnWriteOff";
            this.btnWriteOff.Size = new System.Drawing.Size(75, 23);
            this.btnWriteOff.TabIndex = 1;
            this.btnWriteOff.Text = "WriteOff";
            this.btnWriteOff.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(555, 41);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            // 
            // selectBtn
            // 
            this.selectBtn.HeaderText = "Select Item";
            this.selectBtn.Name = "selectBtn";
            // 
            // FormWriteoffBOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 457);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnWriteOff);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormWriteoffBOM";
            this.Text = "FormWriteoffBOM";
            this.Shown += new System.EventHandler(this.FormWriteoffBOM_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnWriteOff;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn pn;
        private System.Windows.Forms.DataGridViewTextBoxColumn q;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectBtn;
    }
}