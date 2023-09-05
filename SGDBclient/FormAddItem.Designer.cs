
namespace SGDBclient
{
    partial class FormAddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddItem));
            this.btnSelectStorage = new System.Windows.Forms.Button();
            this.textBoxStorage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.textBoxComponent = new System.Windows.Forms.TextBox();
            this.textBoxOrder = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSelectOwner = new System.Windows.Forms.Button();
            this.btnSelectComponent = new System.Windows.Forms.Button();
            this.btnSelectOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btn_add_from_csv = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectStorage
            // 
            this.btnSelectStorage.Location = new System.Drawing.Point(3, 61);
            this.btnSelectStorage.Name = "btnSelectStorage";
            this.btnSelectStorage.Size = new System.Drawing.Size(101, 23);
            this.btnSelectStorage.TabIndex = 3;
            this.btnSelectStorage.Text = "Select storage";
            this.btnSelectStorage.UseVisualStyleBackColor = true;
            this.btnSelectStorage.Click += new System.EventHandler(this.btnSelectStorage_Click);
            // 
            // textBoxStorage
            // 
            this.textBoxStorage.Enabled = false;
            this.textBoxStorage.Location = new System.Drawing.Point(5, 62);
            this.textBoxStorage.Name = "textBoxStorage";
            this.textBoxStorage.Size = new System.Drawing.Size(122, 20);
            this.textBoxStorage.TabIndex = 1;
            this.textBoxStorage.Text = "<click select>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Storage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Component";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Owner";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(25, 202);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQuantity.Location = new System.Drawing.Point(5, 4);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(124, 20);
            this.textBoxQuantity.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 186);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxOwner);
            this.panel2.Controls.Add(this.textBoxComponent);
            this.panel2.Controls.Add(this.textBoxOrder);
            this.panel2.Controls.Add(this.textBoxPrice);
            this.panel2.Controls.Add(this.textBoxQuantity);
            this.panel2.Controls.Add(this.textBoxStorage);
            this.panel2.Location = new System.Drawing.Point(112, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 186);
            this.panel2.TabIndex = 11;
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Enabled = false;
            this.textBoxOwner.Location = new System.Drawing.Point(3, 152);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(122, 20);
            this.textBoxOwner.TabIndex = 13;
            this.textBoxOwner.Text = "<click select>";
            // 
            // textBoxComponent
            // 
            this.textBoxComponent.Enabled = false;
            this.textBoxComponent.Location = new System.Drawing.Point(3, 122);
            this.textBoxComponent.Name = "textBoxComponent";
            this.textBoxComponent.Size = new System.Drawing.Size(122, 20);
            this.textBoxComponent.TabIndex = 12;
            this.textBoxComponent.Text = "<click select>";
            // 
            // textBoxOrder
            // 
            this.textBoxOrder.Enabled = false;
            this.textBoxOrder.Location = new System.Drawing.Point(5, 92);
            this.textBoxOrder.Name = "textBoxOrder";
            this.textBoxOrder.Size = new System.Drawing.Size(122, 20);
            this.textBoxOrder.TabIndex = 11;
            this.textBoxOrder.Text = "<click select>";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrice.Location = new System.Drawing.Point(5, 34);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(124, 20);
            this.textBoxPrice.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnSelectOwner);
            this.panel3.Controls.Add(this.btnSelectComponent);
            this.panel3.Controls.Add(this.btnSelectOrder);
            this.panel3.Controls.Add(this.btnSelectStorage);
            this.panel3.Location = new System.Drawing.Point(248, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(112, 186);
            this.panel3.TabIndex = 12;
            // 
            // btnSelectOwner
            // 
            this.btnSelectOwner.Location = new System.Drawing.Point(3, 151);
            this.btnSelectOwner.Name = "btnSelectOwner";
            this.btnSelectOwner.Size = new System.Drawing.Size(101, 23);
            this.btnSelectOwner.TabIndex = 5;
            this.btnSelectOwner.Text = "Select owner";
            this.btnSelectOwner.UseVisualStyleBackColor = true;
            this.btnSelectOwner.Click += new System.EventHandler(this.btnSelectOwner_Click);
            // 
            // btnSelectComponent
            // 
            this.btnSelectComponent.Location = new System.Drawing.Point(3, 121);
            this.btnSelectComponent.Name = "btnSelectComponent";
            this.btnSelectComponent.Size = new System.Drawing.Size(101, 23);
            this.btnSelectComponent.TabIndex = 5;
            this.btnSelectComponent.Text = "Select component";
            this.btnSelectComponent.UseVisualStyleBackColor = true;
            this.btnSelectComponent.Click += new System.EventHandler(this.btnSelectComponent_Click);
            // 
            // btnSelectOrder
            // 
            this.btnSelectOrder.Location = new System.Drawing.Point(3, 91);
            this.btnSelectOrder.Name = "btnSelectOrder";
            this.btnSelectOrder.Size = new System.Drawing.Size(101, 23);
            this.btnSelectOrder.TabIndex = 4;
            this.btnSelectOrder.Text = "Select order";
            this.btnSelectOrder.UseVisualStyleBackColor = true;
            this.btnSelectOrder.Click += new System.EventHandler(this.btnSelectOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(265, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btn_add_from_csv
            // 
            this.btn_add_from_csv.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add_from_csv.Location = new System.Drawing.Point(128, 202);
            this.btn_add_from_csv.Name = "btn_add_from_csv";
            this.btn_add_from_csv.Size = new System.Drawing.Size(97, 23);
            this.btn_add_from_csv.TabIndex = 7;
            this.btn_add_from_csv.Text = "Add from CSV";
            this.btn_add_from_csv.UseVisualStyleBackColor = true;
            this.btn_add_from_csv.Click += new System.EventHandler(this.btn_add_from_csv_Click);
            // 
            // FormAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 234);
            this.Controls.Add(this.btn_add_from_csv);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddItem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectStorage;
        private System.Windows.Forms.TextBox textBoxStorage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox textBoxQuantity;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBoxOwner;
		private System.Windows.Forms.TextBox textBoxComponent;
		private System.Windows.Forms.TextBox textBoxOrder;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnSelectOwner;
		private System.Windows.Forms.Button btnSelectComponent;
		private System.Windows.Forms.Button btnSelectOrder;
		private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btn_add_from_csv;
    }
}