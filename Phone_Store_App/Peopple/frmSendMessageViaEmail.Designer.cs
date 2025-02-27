namespace Phone_Store_App
{
	partial class frmSendMessageViaEmail
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
			this.ctrlPersonEmailContact1 = new Phone_Store_App.ctrlPersonEmailContact();
			this.SuspendLayout();
			// 
			// ctrlPersonEmailContact1
			// 
			this.ctrlPersonEmailContact1.BackColor = System.Drawing.Color.Brown;
			this.ctrlPersonEmailContact1.Location = new System.Drawing.Point(-3, 0);
			this.ctrlPersonEmailContact1.MaximumSize = new System.Drawing.Size(1008, 719);
			this.ctrlPersonEmailContact1.MinimumSize = new System.Drawing.Size(1008, 719);
			this.ctrlPersonEmailContact1.Name = "ctrlPersonEmailContact1";
			this.ctrlPersonEmailContact1.Size = new System.Drawing.Size(1008, 719);
			this.ctrlPersonEmailContact1.TabIndex = 0;
			// 
			// frmSendMessageViaEmail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1006, 718);
			this.Controls.Add(this.ctrlPersonEmailContact1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximumSize = new System.Drawing.Size(1032, 789);
			this.MinimumSize = new System.Drawing.Size(1032, 789);
			this.Name = "frmSendMessageViaEmail";
			this.Text = "Send Message Via Email";
			this.ResumeLayout(false);

		}

		#endregion

		private ctrlPersonEmailContact ctrlPersonEmailContact1;
	}
}