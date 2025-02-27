namespace Phone_Store_App
{
	partial class frmFindCard
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
			this.ctrlFindCard1 = new Phone_Store_App.ctrlFindCard();
			this.SuspendLayout();
			// 
			// ctrlFindCard1
			// 
			this.ctrlFindCard1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ctrlFindCard1.BackColor = System.Drawing.Color.Brown;
			this.ctrlFindCard1.Location = new System.Drawing.Point(-3, -4);
			this.ctrlFindCard1.MaximumSize = new System.Drawing.Size(883, 514);
			this.ctrlFindCard1.MinimumSize = new System.Drawing.Size(883, 514);
			this.ctrlFindCard1.Name = "ctrlFindCard1";
			this.ctrlFindCard1.Size = new System.Drawing.Size(883, 514);
			this.ctrlFindCard1.TabIndex = 0;
			// 
			// frmFindCard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.Color.Brown;
			this.ClientSize = new System.Drawing.Size(904, 504);
			this.Controls.Add(this.ctrlFindCard1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(930, 575);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(930, 575);
			this.Name = "frmFindCard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmFindCard";
			this.ResumeLayout(false);

		}

		#endregion

		private ctrlFindCard ctrlFindCard1;
	}
}