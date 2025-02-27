namespace Phone_Store_App
{
	partial class ctrlFindUser
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
			this.txtFilterBy = new System.Windows.Forms.TextBox();
			this.cbFilterBy = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ctrlUserDetails1 = new Phone_Store_App.ctrlUserDetails();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnAddNew);
			this.panel1.Controls.Add(this.btnFind);
			this.panel1.Controls.Add(this.txtFilterBy);
			this.panel1.Controls.Add(this.cbFilterBy);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(2, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1164, 76);
			this.panel1.TabIndex = 1;
			// 
			// btnAddNew
			// 
			this.btnAddNew.BackColor = System.Drawing.Color.Brown;
			this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddNew.ForeColor = System.Drawing.Color.White;
			this.btnAddNew.Location = new System.Drawing.Point(962, 3);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(199, 65);
			this.btnAddNew.TabIndex = 4;
			this.btnAddNew.Text = "Add New";
			this.btnAddNew.UseVisualStyleBackColor = false;
			this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
			// 
			// btnFind
			// 
			this.btnFind.BackColor = System.Drawing.Color.Brown;
			this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFind.ForeColor = System.Drawing.Color.White;
			this.btnFind.Location = new System.Drawing.Point(758, 3);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(199, 65);
			this.btnFind.TabIndex = 3;
			this.btnFind.Text = "Find";
			this.btnFind.UseVisualStyleBackColor = false;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// txtFilterBy
			// 
			this.txtFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFilterBy.Location = new System.Drawing.Point(445, 24);
			this.txtFilterBy.Name = "txtFilterBy";
			this.txtFilterBy.Size = new System.Drawing.Size(288, 38);
			this.txtFilterBy.TabIndex = 2;
			// 
			// cbFilterBy
			// 
			this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbFilterBy.FormattingEnabled = true;
			this.cbFilterBy.Items.AddRange(new object[] {
            "User ID",
            "Person ID",
            "User Name"});
			this.cbFilterBy.Location = new System.Drawing.Point(138, 24);
			this.cbFilterBy.Name = "cbFilterBy";
			this.cbFilterBy.Size = new System.Drawing.Size(288, 39);
			this.cbFilterBy.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "FilterBy";
			// 
			// ctrlUserDetails1
			// 
			this.ctrlUserDetails1.BackColor = System.Drawing.Color.Brown;
			this.ctrlUserDetails1.Location = new System.Drawing.Point(11, 85);
			this.ctrlUserDetails1.MaximumSize = new System.Drawing.Size(997, 501);
			this.ctrlUserDetails1.MinimumSize = new System.Drawing.Size(997, 501);
			this.ctrlUserDetails1.Name = "ctrlUserDetails1";
			this.ctrlUserDetails1.Size = new System.Drawing.Size(997, 501);
			this.ctrlUserDetails1.TabIndex = 2;
			this.ctrlUserDetails1.UserID = -1;
			// 
			// ctrlFindUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.Color.Brown;
			this.Controls.Add(this.ctrlUserDetails1);
			this.Controls.Add(this.panel1);
			this.MaximumSize = new System.Drawing.Size(1181, 600);
			this.MinimumSize = new System.Drawing.Size(1181, 600);
			this.Name = "ctrlFindUser";
			this.Size = new System.Drawing.Size(1181, 600);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnAddNew;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.TextBox txtFilterBy;
		private System.Windows.Forms.ComboBox cbFilterBy;
		private System.Windows.Forms.Label label1;
		private ctrlUserDetails ctrlUserDetails1;
	}
}
