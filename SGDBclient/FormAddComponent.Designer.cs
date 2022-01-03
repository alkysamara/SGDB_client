﻿namespace SGDBclient {
	partial class FormAddComponent {
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
			this.textBoxComment = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxPaySource = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.labelSelectedPackage = new System.Windows.Forms.Label();
			this.labelSelectedComponentType = new System.Windows.Forms.Label();
			this.buttonEditComponentType = new System.Windows.Forms.Button();
			this.buttonEditParameters = new System.Windows.Forms.Button();
			this.buttonEditLinks = new System.Windows.Forms.Button();
			this.buttonEditPackage = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "PartNumber";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxComment
			// 
			this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxComment.Location = new System.Drawing.Point(103, 53);
			this.textBoxComment.MaxLength = 255;
			this.textBoxComment.Name = "textBoxComment";
			this.textBoxComment.Size = new System.Drawing.Size(125, 20);
			this.textBoxComment.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Parameters";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "LCSC#";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxPaySource
			// 
			this.textBoxPaySource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPaySource.Location = new System.Drawing.Point(103, 3);
			this.textBoxPaySource.MaxLength = 45;
			this.textBoxPaySource.Name = "textBoxPaySource";
			this.textBoxPaySource.Size = new System.Drawing.Size(125, 20);
			this.textBoxPaySource.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.buttonAdd);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 161);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(284, 30);
			this.panel1.TabIndex = 6;
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
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(6, 4);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(3, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 25);
			this.label4.TabIndex = 8;
			this.label4.Text = "Links";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.Controls.Add(this.labelSelectedComponentType, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBoxComment, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBoxPaySource, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelSelectedPackage, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.buttonEditParameters, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.buttonEditPackage, 2, 5);
			this.tableLayoutPanel1.Controls.Add(this.buttonEditLinks, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.buttonEditComponentType, 2, 4);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(281, 159);
			this.tableLayoutPanel1.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Location = new System.Drawing.Point(3, 125);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 34);
			this.label6.TabIndex = 10;
			this.label6.Text = "Package";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(3, 100);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 25);
			this.label5.TabIndex = 11;
			this.label5.Text = "Component Type";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelSelectedPackage
			// 
			this.labelSelectedPackage.AutoSize = true;
			this.labelSelectedPackage.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelSelectedPackage.Location = new System.Drawing.Point(103, 125);
			this.labelSelectedPackage.Name = "labelSelectedPackage";
			this.labelSelectedPackage.Size = new System.Drawing.Size(78, 34);
			this.labelSelectedPackage.TabIndex = 12;
			this.labelSelectedPackage.Text = "None Selected";
			this.labelSelectedPackage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelSelectedComponentType
			// 
			this.labelSelectedComponentType.AutoSize = true;
			this.labelSelectedComponentType.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelSelectedComponentType.Location = new System.Drawing.Point(103, 100);
			this.labelSelectedComponentType.Name = "labelSelectedComponentType";
			this.labelSelectedComponentType.Size = new System.Drawing.Size(78, 25);
			this.labelSelectedComponentType.TabIndex = 13;
			this.labelSelectedComponentType.Text = "None Selected";
			this.labelSelectedComponentType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonEditComponentType
			// 
			this.buttonEditComponentType.Location = new System.Drawing.Point(234, 103);
			this.buttonEditComponentType.Name = "buttonEditComponentType";
			this.buttonEditComponentType.Size = new System.Drawing.Size(44, 19);
			this.buttonEditComponentType.TabIndex = 14;
			this.buttonEditComponentType.Text = "Edit";
			this.buttonEditComponentType.UseVisualStyleBackColor = true;
			// 
			// buttonEditParameters
			// 
			this.buttonEditParameters.Location = new System.Drawing.Point(234, 28);
			this.buttonEditParameters.Name = "buttonEditParameters";
			this.buttonEditParameters.Size = new System.Drawing.Size(44, 19);
			this.buttonEditParameters.TabIndex = 15;
			this.buttonEditParameters.Text = "Edit";
			this.buttonEditParameters.UseVisualStyleBackColor = true;
			// 
			// buttonEditLinks
			// 
			this.buttonEditLinks.Location = new System.Drawing.Point(234, 78);
			this.buttonEditLinks.Name = "buttonEditLinks";
			this.buttonEditLinks.Size = new System.Drawing.Size(44, 19);
			this.buttonEditLinks.TabIndex = 16;
			this.buttonEditLinks.Text = "Edit";
			this.buttonEditLinks.UseVisualStyleBackColor = true;
			// 
			// buttonEditPackage
			// 
			this.buttonEditPackage.Location = new System.Drawing.Point(234, 128);
			this.buttonEditPackage.Name = "buttonEditPackage";
			this.buttonEditPackage.Size = new System.Drawing.Size(44, 19);
			this.buttonEditPackage.TabIndex = 17;
			this.buttonEditPackage.Text = "Edit";
			this.buttonEditPackage.UseVisualStyleBackColor = true;
			// 
			// FormAddComponent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 191);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.panel1);
			this.MaximumSize = new System.Drawing.Size(1000, 230);
			this.MinimumSize = new System.Drawing.Size(300, 230);
			this.Name = "FormAddComponent";
			this.Text = "Add component";
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxComment;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxPaySource;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label labelSelectedComponentType;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelSelectedPackage;
		private System.Windows.Forms.Button buttonEditParameters;
		private System.Windows.Forms.Button buttonEditPackage;
		private System.Windows.Forms.Button buttonEditLinks;
		private System.Windows.Forms.Button buttonEditComponentType;
	}
}