namespace SGDBclient {
	partial class FormCHangeQ {
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
            this.labelCurQ = new System.Windows.Forms.Label();
            this.textBoxNeedQ = new System.Windows.Forms.TextBox();
            this.labelNeedQ = new System.Windows.Forms.Label();
            this.labelProj = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddProj = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonWriteOff = new System.Windows.Forms.Button();
            this.labelCom = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDat = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.textBoxCurQ = new System.Windows.Forms.TextBox();
            this.comboBoxProj = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCurQ
            // 
            this.labelCurQ.AutoSize = true;
            this.labelCurQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCurQ.Location = new System.Drawing.Point(3, 0);
            this.labelCurQ.Name = "labelCurQ";
            this.labelCurQ.Size = new System.Drawing.Size(94, 22);
            this.labelCurQ.TabIndex = 0;
            this.labelCurQ.Text = "Curent Quantity";
            this.labelCurQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNeedQ
            // 
            this.textBoxNeedQ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNeedQ.Location = new System.Drawing.Point(103, 3);
            this.textBoxNeedQ.MaxLength = 45;
            this.textBoxNeedQ.Name = "textBoxNeedQ";
            this.textBoxNeedQ.ReadOnly = true;
            this.textBoxNeedQ.Size = new System.Drawing.Size(178, 20);
            this.textBoxNeedQ.TabIndex = 1;
            // 
            // labelNeedQ
            // 
            this.labelNeedQ.AutoSize = true;
            this.labelNeedQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNeedQ.Location = new System.Drawing.Point(3, 22);
            this.labelNeedQ.Name = "labelNeedQ";
            this.labelNeedQ.Size = new System.Drawing.Size(94, 22);
            this.labelNeedQ.TabIndex = 2;
            this.labelNeedQ.Text = "Needable quantity";
            this.labelNeedQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNeedQ.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelProj
            // 
            this.labelProj.AutoSize = true;
            this.labelProj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProj.Location = new System.Drawing.Point(3, 44);
            this.labelProj.Name = "labelProj";
            this.labelProj.Size = new System.Drawing.Size(94, 20);
            this.labelProj.TabIndex = 4;
            this.labelProj.Text = "Project";
            this.labelProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Location = new System.Drawing.Point(103, 67);
            this.textBoxComment.MaxLength = 45;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(178, 20);
            this.textBoxComment.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddProj);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonWriteOff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 30);
            this.panel1.TabIndex = 6;
            // 
            // btnAddProj
            // 
            this.btnAddProj.Location = new System.Drawing.Point(103, 4);
            this.btnAddProj.Name = "btnAddProj";
            this.btnAddProj.Size = new System.Drawing.Size(75, 23);
            this.btnAddProj.TabIndex = 2;
            this.btnAddProj.Text = "Add project";
            this.btnAddProj.UseVisualStyleBackColor = true;
            this.btnAddProj.Click += new System.EventHandler(this.btnAddProj_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(206, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // buttonWriteOff
            // 
            this.buttonWriteOff.Location = new System.Drawing.Point(6, 4);
            this.buttonWriteOff.Name = "buttonWriteOff";
            this.buttonWriteOff.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteOff.TabIndex = 0;
            this.buttonWriteOff.Text = "Write off";
            this.buttonWriteOff.UseVisualStyleBackColor = true;
            this.buttonWriteOff.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCom.Location = new System.Drawing.Point(3, 64);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(94, 20);
            this.labelCom.TabIndex = 8;
            this.labelCom.Text = "Comment";
            this.labelCom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelCom, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxComment, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelCurQ, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNeedQ, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelProj, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelDat, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxData, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCurQ, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNeedQ, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxProj, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 105);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // labelDat
            // 
            this.labelDat.AutoSize = true;
            this.labelDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDat.Location = new System.Drawing.Point(3, 84);
            this.labelDat.Name = "labelDat";
            this.labelDat.Size = new System.Drawing.Size(94, 21);
            this.labelDat.TabIndex = 11;
            this.labelDat.Text = "Data";
            this.labelDat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDat.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxData
            // 
            this.textBoxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxData.Location = new System.Drawing.Point(103, 87);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ReadOnly = true;
            this.textBoxData.Size = new System.Drawing.Size(178, 20);
            this.textBoxData.TabIndex = 12;
            // 
            // textBoxCurQ
            // 
            this.textBoxCurQ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurQ.Location = new System.Drawing.Point(103, 25);
            this.textBoxCurQ.MaxLength = 45;
            this.textBoxCurQ.Name = "textBoxCurQ";
            this.textBoxCurQ.Size = new System.Drawing.Size(178, 20);
            this.textBoxCurQ.TabIndex = 10;
            this.textBoxCurQ.TextChanged += new System.EventHandler(this.textBoxCurQ_TextChanged);
            // 
            // comboBoxProj
            // 
            this.comboBoxProj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxProj.FormattingEnabled = true;
            this.comboBoxProj.Location = new System.Drawing.Point(103, 47);
            this.comboBoxProj.Name = "comboBoxProj";
            this.comboBoxProj.Size = new System.Drawing.Size(178, 21);
            this.comboBoxProj.TabIndex = 13;
            this.comboBoxProj.SelectedIndexChanged += new System.EventHandler(this.comboBoxProj_SelectedIndexChanged);
            // 
            // FormCHangeQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1000, 180);
            this.MinimumSize = new System.Drawing.Size(300, 160);
            this.Name = "FormCHangeQ";
            this.Text = "Add order";
            this.Load += new System.EventHandler(this.FormCHangeQ_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelCurQ;
		private System.Windows.Forms.TextBox textBoxNeedQ;
		private System.Windows.Forms.Label labelNeedQ;
		private System.Windows.Forms.Label labelProj;
		private System.Windows.Forms.TextBox textBoxComment;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonWriteOff;
		private System.Windows.Forms.Label labelCom;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox textBoxCurQ;
        private System.Windows.Forms.Label labelDat;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Button btnAddProj;
        private System.Windows.Forms.ComboBox comboBoxProj;
    }
}