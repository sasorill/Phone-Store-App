namespace Phone_Store_App
{
	partial class frmFindProduct
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
			this.ctrlFindProduct1 = new Phone_Store_App.ctrlFindProduct();
			this.SuspendLayout();
			// 
			// ctrlFindProduct1
			// 
			this.ctrlFindProduct1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ctrlFindProduct1.BackColor = System.Drawing.Color.Brown;
			this.ctrlFindProduct1.Location = new System.Drawing.Point(12, 8);
			this.ctrlFindProduct1.MaximumSize = new System.Drawing.Size(1228, 769);
			this.ctrlFindProduct1.MinimumSize = new System.Drawing.Size(1228, 769);
			this.ctrlFindProduct1.Name = "ctrlFindProduct1";
			this.ctrlFindProduct1.Size = new System.Drawing.Size(1228, 769);
			this.ctrlFindProduct1.TabIndex = 0;
			// 
			// frmFindProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.Color.Brown;
			this.ClientSize = new System.Drawing.Size(1236, 789);
			this.Controls.Add(this.ctrlFindProduct1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1262, 860);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1262, 860);
			this.Name = "frmFindProduct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "frmFindProduct";
			this.ResumeLayout(false);

		}

		#endregion

		private ctrlFindProduct ctrlFindProduct1;
	}
}