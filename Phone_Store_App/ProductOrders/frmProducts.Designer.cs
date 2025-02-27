namespace Phone_Store_App
{
	partial class frmProducts
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
			this.components = new System.ComponentModel.Container();
			this.cmsProduct = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dgvProduct = new System.Windows.Forms.DataGridView();
			this.cmsProduct.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
			this.SuspendLayout();
			// 
			// cmsProduct
			// 
			this.cmsProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmsProduct.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.cmsProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.addNewProductToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.findProductToolStripMenuItem});
			this.cmsProduct.Name = "cmsProduct";
			this.cmsProduct.Size = new System.Drawing.Size(353, 212);
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.Size = new System.Drawing.Size(352, 52);
			this.updateToolStripMenuItem.Text = "Update";
			this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
			// 
			// addNewProductToolStripMenuItem
			// 
			this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
			this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(352, 52);
			this.addNewProductToolStripMenuItem.Text = "Add New Product";
			this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewProductToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(352, 52);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// findProductToolStripMenuItem
			// 
			this.findProductToolStripMenuItem.Name = "findProductToolStripMenuItem";
			this.findProductToolStripMenuItem.Size = new System.Drawing.Size(352, 52);
			this.findProductToolStripMenuItem.Text = "Find Product";
			this.findProductToolStripMenuItem.Click += new System.EventHandler(this.findProductToolStripMenuItem_Click);
			// 
			// dgvProduct
			// 
			this.dgvProduct.AllowUserToAddRows = false;
			this.dgvProduct.AllowUserToDeleteRows = false;
			this.dgvProduct.AllowUserToOrderColumns = true;
			this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduct.ContextMenuStrip = this.cmsProduct;
			this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvProduct.Location = new System.Drawing.Point(0, 0);
			this.dgvProduct.Name = "dgvProduct";
			this.dgvProduct.ReadOnly = true;
			this.dgvProduct.RowHeadersWidth = 82;
			this.dgvProduct.RowTemplate.Height = 33;
			this.dgvProduct.Size = new System.Drawing.Size(2328, 885);
			this.dgvProduct.TabIndex = 1;
			this.dgvProduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvProduct_MouseClick);
			// 
			// frmProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Brown;
			this.ClientSize = new System.Drawing.Size(2328, 885);
			this.Controls.Add(this.dgvProduct);
			this.MinimizeBox = false;
			this.Name = "frmProducts";
			this.Text = "Products";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmProducts_Load);
			this.cmsProduct.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ContextMenuStrip cmsProduct;
		private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem findProductToolStripMenuItem;
		private System.Windows.Forms.DataGridView dgvProduct;
	}
}