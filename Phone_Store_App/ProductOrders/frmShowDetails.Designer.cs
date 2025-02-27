namespace Phone_Store_App
{
	partial class frmShowDetails
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
			this.ctrlProductItem1 = new Phone_Store_App.ctrlProductItem();
			this.SuspendLayout();
			// 
			// ctrlProductItem1
			// 
			this.ctrlProductItem1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ctrlProductItem1.BackColor = System.Drawing.Color.Brown;
			this.ctrlProductItem1.Location = new System.Drawing.Point(-13, 1);
			this.ctrlProductItem1.MaximumSize = new System.Drawing.Size(1194, 647);
			this.ctrlProductItem1.MinimumSize = new System.Drawing.Size(1194, 647);
			this.ctrlProductItem1.Name = "ctrlProductItem1";
			this.ctrlProductItem1.Products = null;
			this.ctrlProductItem1.Size = new System.Drawing.Size(1194, 647);
			this.ctrlProductItem1.TabIndex = 0;
			// 
			// frmShowDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1183, 642);
			this.Controls.Add(this.ctrlProductItem1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1209, 713);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1209, 713);
			this.Name = "frmShowDetails";
			this.Text = "frmShowDetails";
			this.ResumeLayout(false);

		}

		#endregion

		private ctrlProductItem ctrlProductItem1;
	}
}