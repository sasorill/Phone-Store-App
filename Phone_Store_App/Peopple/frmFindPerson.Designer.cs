namespace Phone_Store_App
{
	partial class frmFindPerson
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
			this.ctrlFindPerson1 = new Phone_Store_App.ctrlFindPerson();
			this.SuspendLayout();
			// 
			// ctrlFindPerson1
			// 
			this.ctrlFindPerson1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ctrlFindPerson1.BackColor = System.Drawing.Color.Brown;
			this.ctrlFindPerson1.Location = new System.Drawing.Point(-2, -3);
			this.ctrlFindPerson1.MaximumSize = new System.Drawing.Size(1198, 525);
			this.ctrlFindPerson1.MinimumSize = new System.Drawing.Size(1198, 525);
			this.ctrlFindPerson1.Name = "ctrlFindPerson1";
			this.ctrlFindPerson1.PersonID = -1;
			this.ctrlFindPerson1.Size = new System.Drawing.Size(1198, 525);
			this.ctrlFindPerson1.TabIndex = 0;
			// 
			// frmFindPerson
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.Color.Brown;
			this.ClientSize = new System.Drawing.Size(1189, 525);
			this.Controls.Add(this.ctrlFindPerson1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1215, 596);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1215, 596);
			this.Name = "frmFindPerson";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Find Person";
			this.ResumeLayout(false);

		}

		#endregion

		private ctrlFindPerson ctrlFindPerson1;
	}
}