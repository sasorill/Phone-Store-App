namespace Phone_Store_App
{
	partial class frmPersonPhoneContact
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
			this.ctrlContactByPhone1 = new Phone_Store_App.ctrlContactByPhone();
			this.SuspendLayout();
			// 
			// ctrlContactByPhone1
			// 
			this.ctrlContactByPhone1.BackColor = System.Drawing.Color.Brown;
			this.ctrlContactByPhone1.Location = new System.Drawing.Point(-1, 0);
			this.ctrlContactByPhone1.MaximumSize = new System.Drawing.Size(613, 346);
			this.ctrlContactByPhone1.MinimumSize = new System.Drawing.Size(613, 346);
			this.ctrlContactByPhone1.Name = "ctrlContactByPhone1";
			this.ctrlContactByPhone1.Size = new System.Drawing.Size(613, 346);
			this.ctrlContactByPhone1.TabIndex = 0;
			this.ctrlContactByPhone1.Load += new System.EventHandler(this.ctrlContactByPhone1_Load);
			// 
			// frmPersonPhoneContact
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(613, 344);
			this.Controls.Add(this.ctrlContactByPhone1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximumSize = new System.Drawing.Size(639, 415);
			this.MinimumSize = new System.Drawing.Size(639, 415);
			this.Name = "frmPersonPhoneContact";
			this.Text = "Person Phone Contact";
			this.ResumeLayout(false);

		}

		#endregion

		private ctrlContactByPhone ctrlContactByPhone1;
	}
}