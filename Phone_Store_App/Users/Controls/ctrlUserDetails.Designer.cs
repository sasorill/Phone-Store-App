namespace Phone_Store_App
{
	partial class ctrlUserDetails
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
			this.label1 = new System.Windows.Forms.Label();
			this.laUserID = new System.Windows.Forms.Label();
			this.laUserName = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.laIsActive = new System.Windows.Forms.Label();
			this.r = new System.Windows.Forms.Label();
			this.ctrlPersonDetails1 = new Phone_Store_App.ctrlPersonDetails();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Brown;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(19, 455);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "User ID";
			// 
			// laUserID
			// 
			this.laUserID.AutoSize = true;
			this.laUserID.BackColor = System.Drawing.Color.Brown;
			this.laUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.laUserID.ForeColor = System.Drawing.Color.White;
			this.laUserID.Location = new System.Drawing.Point(205, 455);
			this.laUserID.Name = "laUserID";
			this.laUserID.Size = new System.Drawing.Size(59, 31);
			this.laUserID.TabIndex = 2;
			this.laUserID.Text = "???";
			// 
			// laUserName
			// 
			this.laUserName.AutoSize = true;
			this.laUserName.BackColor = System.Drawing.Color.Brown;
			this.laUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.laUserName.ForeColor = System.Drawing.Color.White;
			this.laUserName.Location = new System.Drawing.Point(571, 455);
			this.laUserName.Name = "laUserName";
			this.laUserName.Size = new System.Drawing.Size(59, 31);
			this.laUserName.TabIndex = 3;
			this.laUserName.Text = "???";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Brown;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(382, 455);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(151, 31);
			this.label4.TabIndex = 4;
			this.label4.Text = "User Name";
			// 
			// laIsActive
			// 
			this.laIsActive.AutoSize = true;
			this.laIsActive.BackColor = System.Drawing.Color.Brown;
			this.laIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.laIsActive.ForeColor = System.Drawing.Color.White;
			this.laIsActive.Location = new System.Drawing.Point(931, 455);
			this.laIsActive.Name = "laIsActive";
			this.laIsActive.Size = new System.Drawing.Size(59, 31);
			this.laIsActive.TabIndex = 5;
			this.laIsActive.Text = "???";
			// 
			// r
			// 
			this.r.AutoSize = true;
			this.r.BackColor = System.Drawing.Color.Brown;
			this.r.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.r.ForeColor = System.Drawing.Color.White;
			this.r.Location = new System.Drawing.Point(777, 455);
			this.r.Name = "r";
			this.r.Size = new System.Drawing.Size(126, 31);
			this.r.TabIndex = 6;
			this.r.Text = "IsActive?";
			// 
			// ctrlPersonDetails1
			// 
			this.ctrlPersonDetails1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ctrlPersonDetails1.BackColor = System.Drawing.Color.Brown;
			this.ctrlPersonDetails1.Location = new System.Drawing.Point(3, 3);
			this.ctrlPersonDetails1.MaximumSize = new System.Drawing.Size(998, 433);
			this.ctrlPersonDetails1.MinimumSize = new System.Drawing.Size(998, 433);
			this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
			this.ctrlPersonDetails1.PersonID = -1;
			this.ctrlPersonDetails1.Size = new System.Drawing.Size(998, 433);
			this.ctrlPersonDetails1.TabIndex = 7;
			// 
			// ctrlUserDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Brown;
			this.Controls.Add(this.ctrlPersonDetails1);
			this.Controls.Add(this.r);
			this.Controls.Add(this.laIsActive);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.laUserName);
			this.Controls.Add(this.laUserID);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(997, 501);
			this.MinimumSize = new System.Drawing.Size(997, 501);
			this.Name = "ctrlUserDetails";
			this.Size = new System.Drawing.Size(997, 501);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label laUserID;
		private System.Windows.Forms.Label laUserName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label laIsActive;
		private System.Windows.Forms.Label r;
		private ctrlPersonDetails ctrlPersonDetails1;
	}
}
