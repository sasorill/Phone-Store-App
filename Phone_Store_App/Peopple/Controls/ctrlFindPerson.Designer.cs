namespace Phone_Store_App
{
	partial class ctrlFindPerson
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.btnFind = new System.Windows.Forms.Button();
			this.txtFilterBy = new System.Windows.Forms.TextBox();
			this.cbFilterBy = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.ctrlPersonDetails1 = new Phone_Store_App.ctrlPersonDetails();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.btnAddNew);
			this.panel1.Controls.Add(this.btnFind);
			this.panel1.Controls.Add(this.txtFilterBy);
			this.panel1.Controls.Add(this.cbFilterBy);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1172, 81);
			this.panel1.TabIndex = 0;
			// 
			// btnAddNew
			// 
			this.btnAddNew.BackColor = System.Drawing.Color.Brown;
			this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddNew.ForeColor = System.Drawing.Color.White;
			this.btnAddNew.Location = new System.Drawing.Point(959, 3);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(190, 74);
			this.btnAddNew.TabIndex = 2;
			this.btnAddNew.Text = "Add New";
			this.btnAddNew.UseVisualStyleBackColor = false;
			this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
			// 
			// btnFind
			// 
			this.btnFind.BackColor = System.Drawing.Color.Brown;
			this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFind.ForeColor = System.Drawing.Color.White;
			this.btnFind.Location = new System.Drawing.Point(773, 4);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(180, 73);
			this.btnFind.TabIndex = 3;
			this.btnFind.Text = "Find";
			this.btnFind.UseVisualStyleBackColor = false;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// txtFilterBy
			// 
			this.txtFilterBy.Location = new System.Drawing.Point(458, 23);
			this.txtFilterBy.Name = "txtFilterBy";
			this.txtFilterBy.Size = new System.Drawing.Size(292, 31);
			this.txtFilterBy.TabIndex = 2;
			// 
			// cbFilterBy
			// 
			this.cbFilterBy.FormattingEnabled = true;
			this.cbFilterBy.Items.AddRange(new object[] {
            "Person ID",
            "Email",
            "Phone",
            "First Name"});
			this.cbFilterBy.Location = new System.Drawing.Point(146, 21);
			this.cbFilterBy.Name = "cbFilterBy";
			this.cbFilterBy.Size = new System.Drawing.Size(292, 33);
			this.cbFilterBy.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Filter By";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// ctrlPersonDetails1
			// 
			this.ctrlPersonDetails1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ctrlPersonDetails1.BackColor = System.Drawing.Color.Brown;
			this.ctrlPersonDetails1.Location = new System.Drawing.Point(3, 90);
			this.ctrlPersonDetails1.MaximumSize = new System.Drawing.Size(1186, 433);
			this.ctrlPersonDetails1.MinimumSize = new System.Drawing.Size(1186, 433);
			this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
			this.ctrlPersonDetails1.PersonID = -1;
			this.ctrlPersonDetails1.Size = new System.Drawing.Size(1186, 433);
			this.ctrlPersonDetails1.TabIndex = 1;
			// 
			// ctrlFindPerson
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.Color.Brown;
			this.Controls.Add(this.ctrlPersonDetails1);
			this.Controls.Add(this.panel1);
			this.MaximumSize = new System.Drawing.Size(1198, 525);
			this.MinimumSize = new System.Drawing.Size(1198, 525);
			this.Name = "ctrlFindPerson";
			this.Size = new System.Drawing.Size(1198, 525);
			this.Load += new System.EventHandler(this.ctrlFindPerson_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.TextBox txtFilterBy;
		private System.Windows.Forms.ComboBox cbFilterBy;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button btnAddNew;
		private ctrlPersonDetails ctrlPersonDetails1;
	}
}
