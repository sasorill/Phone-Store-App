namespace Phone_Store_App
{
	partial class frmUserDetails
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
			this.ctrlUserDetails1 = new Phone_Store_App.ctrlUserDetails();
			this.SuspendLayout();
			// 
			// ctrlUserDetails1
			// 
			this.ctrlUserDetails1.BackColor = System.Drawing.Color.Brown;
			this.ctrlUserDetails1.Location = new System.Drawing.Point(1, -2);
			this.ctrlUserDetails1.MaximumSize = new System.Drawing.Size(997, 501);
			this.ctrlUserDetails1.MinimumSize = new System.Drawing.Size(997, 501);
			this.ctrlUserDetails1.Name = "ctrlUserDetails1";
			this.ctrlUserDetails1.Size = new System.Drawing.Size(997, 501);
			this.ctrlUserDetails1.TabIndex = 0;
			this.ctrlUserDetails1.UserID = -1;
			// 
			// frmUserDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.Color.Brown;
			this.ClientSize = new System.Drawing.Size(1010, 502);
			this.Controls.Add(this.ctrlUserDetails1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmUserDetails";
			this.Text = "User Details";
			this.ResumeLayout(false);

		}

		#endregion

		private ctrlUserDetails ctrlUserDetails1;
	}
}