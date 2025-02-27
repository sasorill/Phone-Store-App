namespace Phone_Store_App
{
	partial class ctrlFindProduct
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.btnFind = new System.Windows.Forms.Button();
			this.txtFind = new System.Windows.Forms.TextBox();
			this.cbFilterBy = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ctrlProductItem1 = new Phone_Store_App.ctrlProductItem();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.btnAddNew);
			this.panel1.Controls.Add(this.btnFind);
			this.panel1.Controls.Add(this.txtFind);
			this.panel1.Controls.Add(this.cbFilterBy);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1194, 84);
			this.panel1.TabIndex = 0;
			// 
			// btnAddNew
			// 
			this.btnAddNew.BackColor = System.Drawing.Color.Brown;
			this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddNew.ForeColor = System.Drawing.Color.White;
			this.btnAddNew.Location = new System.Drawing.Point(948, 11);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(224, 55);
			this.btnAddNew.TabIndex = 3;
			this.btnAddNew.Text = "Add New";
			this.btnAddNew.UseVisualStyleBackColor = false;
			this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
			// 
			// btnFind
			// 
			this.btnFind.BackColor = System.Drawing.Color.Brown;
			this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFind.ForeColor = System.Drawing.Color.White;
			this.btnFind.Location = new System.Drawing.Point(706, 11);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(216, 55);
			this.btnFind.TabIndex = 2;
			this.btnFind.Text = "Find";
			this.btnFind.UseVisualStyleBackColor = false;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// txtFind
			// 
			this.txtFind.Location = new System.Drawing.Point(415, 25);
			this.txtFind.Name = "txtFind";
			this.txtFind.Size = new System.Drawing.Size(261, 31);
			this.txtFind.TabIndex = 1;
			// 
			// cbFilterBy
			// 
			this.cbFilterBy.FormattingEnabled = true;
			this.cbFilterBy.Items.AddRange(new object[] {
            "Product ID",
            "Product Name",
            "Category ID"});
			this.cbFilterBy.Location = new System.Drawing.Point(127, 23);
			this.cbFilterBy.Name = "cbFilterBy";
			this.cbFilterBy.Size = new System.Drawing.Size(262, 33);
			this.cbFilterBy.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(27, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Filter";
			// 
			// ctrlProductItem1
			// 
			this.ctrlProductItem1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ctrlProductItem1.BackColor = System.Drawing.Color.Brown;
			this.ctrlProductItem1.Location = new System.Drawing.Point(12, 103);
			this.ctrlProductItem1.MaximumSize = new System.Drawing.Size(1194, 647);
			this.ctrlProductItem1.MinimumSize = new System.Drawing.Size(1194, 647);
			this.ctrlProductItem1.Name = "ctrlProductItem1";
			this.ctrlProductItem1.Products = null;
			this.ctrlProductItem1.Size = new System.Drawing.Size(1194, 647);
			this.ctrlProductItem1.TabIndex = 1;
			// 
			// ctrlFindProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.Color.Brown;
			this.Controls.Add(this.ctrlProductItem1);
			this.Controls.Add(this.panel1);
			this.MaximumSize = new System.Drawing.Size(1228, 769);
			this.MinimumSize = new System.Drawing.Size(1228, 769);
			this.Name = "ctrlFindProduct";
			this.Size = new System.Drawing.Size(1228, 769);
			this.Load += new System.EventHandler(this.ctrlFindProduct_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cbFilterBy;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFind;
		private System.Windows.Forms.Button btnAddNew;
		private System.Windows.Forms.Button btnFind;
		private ctrlProductItem ctrlProductItem1;
	}
}
