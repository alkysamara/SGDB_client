namespace SGDBclient
{
    partial class FormEditParams
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.textBoxPartNumb = new System.Windows.Forms.TextBox();
            this.textBoxDescrip = new System.Windows.Forms.TextBox();
            this.labelPartNumb = new System.Windows.Forms.Label();
            this.labelDescrip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(266, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Location = new System.Drawing.Point(12, 248);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // textBoxPartNumb
            // 
            this.textBoxPartNumb.Location = new System.Drawing.Point(21, 27);
            this.textBoxPartNumb.Multiline = true;
            this.textBoxPartNumb.Name = "textBoxPartNumb";
            this.textBoxPartNumb.Size = new System.Drawing.Size(157, 20);
            this.textBoxPartNumb.TabIndex = 2;
            // 
            // textBoxDescrip
            // 
            this.textBoxDescrip.Location = new System.Drawing.Point(21, 90);
            this.textBoxDescrip.Multiline = true;
            this.textBoxDescrip.Name = "textBoxDescrip";
            this.textBoxDescrip.Size = new System.Drawing.Size(157, 99);
            this.textBoxDescrip.TabIndex = 3;
            // 
            // labelPartNumb
            // 
            this.labelPartNumb.AutoSize = true;
            this.labelPartNumb.Location = new System.Drawing.Point(37, 9);
            this.labelPartNumb.Name = "labelPartNumb";
            this.labelPartNumb.Size = new System.Drawing.Size(63, 13);
            this.labelPartNumb.TabIndex = 4;
            this.labelPartNumb.Text = "PartNumber";
            // 
            // labelDescrip
            // 
            this.labelDescrip.AutoSize = true;
            this.labelDescrip.Location = new System.Drawing.Point(37, 65);
            this.labelDescrip.Name = "labelDescrip";
            this.labelDescrip.Size = new System.Drawing.Size(60, 13);
            this.labelDescrip.TabIndex = 5;
            this.labelDescrip.Text = "Description";
            // 
            // FormEditParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 283);
            this.Controls.Add(this.labelDescrip);
            this.Controls.Add(this.labelPartNumb);
            this.Controls.Add(this.textBoxDescrip);
            this.Controls.Add(this.textBoxPartNumb);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Name = "FormEditParams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit parameters";
            this.Load += new System.EventHandler(this.FormEditParams_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox textBoxPartNumb;
        private System.Windows.Forms.TextBox textBoxDescrip;
        private System.Windows.Forms.Label labelPartNumb;
        private System.Windows.Forms.Label labelDescrip;
    }
}