namespace Phone_Store_App
{
	partial class frmPersonDetails
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
			this.ctrlPersonDetails1 = new Phone_Store_App.ctrlPersonDetails();
			this.SuspendLayout();
			// 
			// ctrlPersonDetails1
			// 
			this.ctrlPersonDetails1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ctrlPersonDetails1.BackColor = System.Drawing.Color.Brown;
			this.ctrlPersonDetails1.Location = new System.Drawing.Point(2, 1);
			this.ctrlPersonDetails1.MaximumSize = new System.Drawing.Size(998, 433);
			this.ctrlPersonDetails1.MinimumSize = new System.Drawing.Size(998, 433);
			this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
			this.ctrlPersonDetails1.PersonID = -1;
			this.ctrlPersonDetails1.Size = new System.Drawing.Size(998, 433);
			this.ctrlPersonDetails1.TabIndex = 0;
			// 
			// frmPersonDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ClientSize = new System.Drawing.Size(994, 430);
			this.Controls.Add(this.ctrlPersonDetails1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1020, 501);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1020, 501);
			this.Name = "frmPersonDetails";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Person Details";
			this.Load += new System.EventHandler(this.frmPersonDetails_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private ctrlPersonDetails ctrlPersonDetails1;
	}
}