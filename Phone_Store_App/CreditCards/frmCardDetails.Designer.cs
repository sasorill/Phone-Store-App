namespace Phone_Store_App
{
	partial class frmCardDetails
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
			this.ctrlCardDetails1 = new Phone_Store_App.ctrlCardDetails();
			this.SuspendLayout();
			// 
			// ctrlCardDetails1
			// 
			this.ctrlCardDetails1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ctrlCardDetails1.BackColor = System.Drawing.Color.Brown;
			this.ctrlCardDetails1.CardID = 0;
			this.ctrlCardDetails1.Location = new System.Drawing.Point(-5, 3);
			this.ctrlCardDetails1.MaximumSize = new System.Drawing.Size(713, 415);
			this.ctrlCardDetails1.MinimumSize = new System.Drawing.Size(713, 415);
			this.ctrlCardDetails1.Name = "ctrlCardDetails1";
			this.ctrlCardDetails1.Size = new System.Drawing.Size(713, 415);
			this.ctrlCardDetails1.TabIndex = 0;
			// 
			// frmCardDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.Color.Brown;
			this.ClientSize = new System.Drawing.Size(702, 417);
			this.Controls.Add(this.ctrlCardDetails1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(728, 488);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(728, 488);
			this.Name = "frmCardDetails";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Card Details";
			this.Load += new System.EventHandler(this.frmCardDetails_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private ctrlCardDetails ctrlCardDetails1;
	}
}