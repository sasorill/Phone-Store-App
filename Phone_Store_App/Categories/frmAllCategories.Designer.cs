namespace Phone_Store_App
{
	partial class frmAllCategories
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
			this.label1 = new System.Windows.Forms.Label();
			this.dgvAllCategories = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvAllCategories)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(35, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(554, 61);
			this.label1.TabIndex = 0;
			this.label1.Text = "All Categories Screen";
			// 
			// dgvAllCategories
			// 
			this.dgvAllCategories.AllowUserToAddRows = false;
			this.dgvAllCategories.AllowUserToDeleteRows = false;
			this.dgvAllCategories.AllowUserToOrderColumns = true;
			this.dgvAllCategories.BackgroundColor = System.Drawing.Color.Brown;
			this.dgvAllCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAllCategories.GridColor = System.Drawing.Color.Brown;
			this.dgvAllCategories.Location = new System.Drawing.Point(0, 395);
			this.dgvAllCategories.Name = "dgvAllCategories";
			this.dgvAllCategories.ReadOnly = true;
			this.dgvAllCategories.RowHeadersWidth = 82;
			this.dgvAllCategories.RowTemplate.Height = 33;
			this.dgvAllCategories.Size = new System.Drawing.Size(653, 434);
			this.dgvAllCategories.TabIndex = 1;
			// 
			// frmAllCategories
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ClientSize = new System.Drawing.Size(651, 777);
			this.Controls.Add(this.dgvAllCategories);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(677, 848);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(677, 848);
			this.Name = "frmAllCategories";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "All Categories";
			this.Load += new System.EventHandler(this.frmAllCategories_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAllCategories)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvAllCategories;
	}
}