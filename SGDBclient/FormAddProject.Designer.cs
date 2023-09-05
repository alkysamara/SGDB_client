namespace SGDBclient
{
    partial class FormAddProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProject));
            this.btnAddProj = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxAddProj = new System.Windows.Forms.TextBox();
            this.labelAddProj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddProj
            // 
            this.btnAddProj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddProj.Location = new System.Drawing.Point(12, 72);
            this.btnAddProj.Name = "btnAddProj";
            this.btnAddProj.Size = new System.Drawing.Size(75, 23);
            this.btnAddProj.TabIndex = 0;
            this.btnAddProj.Text = "Add";
            this.btnAddProj.UseVisualStyleBackColor = true;
            this.btnAddProj.Click += new System.EventHandler(this.btnAddProj_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(155, 72);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBoxAddProj
            // 
            this.textBoxAddProj.Location = new System.Drawing.Point(37, 40);
            this.textBoxAddProj.Name = "textBoxAddProj";
            this.textBoxAddProj.Size = new System.Drawing.Size(162, 20);
            this.textBoxAddProj.TabIndex = 2;
            // 
            // labelAddProj
            // 
            this.labelAddProj.AutoSize = true;
            this.labelAddProj.Location = new System.Drawing.Point(86, 17);
            this.labelAddProj.Name = "labelAddProj";
            this.labelAddProj.Size = new System.Drawing.Size(69, 13);
            this.labelAddProj.TabIndex = 3;
            this.labelAddProj.Text = "Project name";
            this.labelAddProj.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormAddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 107);
            this.Controls.Add(this.labelAddProj);
            this.Controls.Add(this.textBoxAddProj);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddProj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 200);
            this.Name = "FormAddProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProj;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBoxAddProj;
        private System.Windows.Forms.Label labelAddProj;
    }
}