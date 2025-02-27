namespace Phone_Store_App
{
	partial class frmFindUser
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
			this.ctrlFindUser1 = new Phone_Store_App.ctrlFindUser();
			this.SuspendLayout();
			// 
			// ctrlFindUser1
			// 
			this.ctrlFindUser1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ctrlFindUser1.BackColor = System.Drawing.Color.Brown;
			this.ctrlFindUser1.Location = new System.Drawing.Point(12, 2);
			this.ctrlFindUser1.MaximumSize = new System.Drawing.Size(1181, 600);
			this.ctrlFindUser1.MinimumSize = new System.Drawing.Size(1181, 600);
			this.ctrlFindUser1.Name = "ctrlFindUser1";
			this.ctrlFindUser1.Size = new System.Drawing.Size(1181, 600);
			this.ctrlFindUser1.TabIndex = 0;
			// 
			// frmFindUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.Color.Brown;
			this.ClientSize = new System.Drawing.Size(1213, 603);
			this.Controls.Add(this.ctrlFindUser1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmFindUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Find User";
			this.ResumeLayout(false);

		}

		#endregion

		private ctrlFindUser ctrlFindUser1;
	}
}