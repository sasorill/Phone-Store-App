namespace Phone_Store_App
{
	partial class frmOrders
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
			this.dgvOrders = new System.Windows.Forms.DataGridView();
			this.cmsOrders = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.viewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setAsCompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.laCountOrders = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
			this.cmsOrders.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvOrders
			// 
			this.dgvOrders.AllowUserToAddRows = false;
			this.dgvOrders.AllowUserToDeleteRows = false;
			this.dgvOrders.AllowUserToOrderColumns = true;
			this.dgvOrders.BackgroundColor = System.Drawing.Color.Brown;
			this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrders.ContextMenuStrip = this.cmsOrders;
			this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvOrders.Location = new System.Drawing.Point(0, 429);
			this.dgvOrders.Name = "dgvOrders";
			this.dgvOrders.ReadOnly = true;
			this.dgvOrders.RowHeadersWidth = 82;
			this.dgvOrders.RowTemplate.Height = 33;
			this.dgvOrders.Size = new System.Drawing.Size(1704, 332);
			this.dgvOrders.TabIndex = 0;
			// 
			// cmsOrders
			// 
			this.cmsOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmsOrders.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.cmsOrders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPersonToolStripMenuItem,
            this.viewCardToolStripMenuItem,
            this.viewProductToolStripMenuItem,
            this.setAsCompleteToolStripMenuItem});
			this.cmsOrders.Name = "cmsOrders";
			this.cmsOrders.Size = new System.Drawing.Size(338, 212);
			// 
			// viewPersonToolStripMenuItem
			// 
			this.viewPersonToolStripMenuItem.Name = "viewPersonToolStripMenuItem";
			this.viewPersonToolStripMenuItem.Size = new System.Drawing.Size(337, 52);
			this.viewPersonToolStripMenuItem.Text = "View Person";
			this.viewPersonToolStripMenuItem.Click += new System.EventHandler(this.viewPersonToolStripMenuItem_Click);
			// 
			// viewCardToolStripMenuItem
			// 
			this.viewCardToolStripMenuItem.Name = "viewCardToolStripMenuItem";
			this.viewCardToolStripMenuItem.Size = new System.Drawing.Size(337, 52);
			this.viewCardToolStripMenuItem.Text = "View Card";
			this.viewCardToolStripMenuItem.Click += new System.EventHandler(this.viewCardToolStripMenuItem_Click);
			// 
			// viewProductToolStripMenuItem
			// 
			this.viewProductToolStripMenuItem.Name = "viewProductToolStripMenuItem";
			this.viewProductToolStripMenuItem.Size = new System.Drawing.Size(337, 52);
			this.viewProductToolStripMenuItem.Text = "View Product";
			this.viewProductToolStripMenuItem.Click += new System.EventHandler(this.viewProductToolStripMenuItem_Click);
			// 
			// setAsCompleteToolStripMenuItem
			// 
			this.setAsCompleteToolStripMenuItem.Name = "setAsCompleteToolStripMenuItem";
			this.setAsCompleteToolStripMenuItem.Size = new System.Drawing.Size(337, 52);
			this.setAsCompleteToolStripMenuItem.Text = "Set As Complete";
			this.setAsCompleteToolStripMenuItem.Click += new System.EventHandler(this.setAsCompleteToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 383);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "All Orders";
			// 
			// laCountOrders
			// 
			this.laCountOrders.AutoSize = true;
			this.laCountOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.laCountOrders.Location = new System.Drawing.Point(191, 383);
			this.laCountOrders.Name = "laCountOrders";
			this.laCountOrders.Size = new System.Drawing.Size(62, 31);
			this.laCountOrders.TabIndex = 2;
			this.laCountOrders.Text = "???";
			// 
			// frmOrders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ClientSize = new System.Drawing.Size(1704, 761);
			this.Controls.Add(this.laCountOrders);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvOrders);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1730, 832);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1730, 832);
			this.Name = "frmOrders";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Orders";
			this.Load += new System.EventHandler(this.frmOrders_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
			this.cmsOrders.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvOrders;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label laCountOrders;
		private System.Windows.Forms.ContextMenuStrip cmsOrders;
		private System.Windows.Forms.ToolStripMenuItem viewPersonToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewCardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewProductToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem setAsCompleteToolStripMenuItem;
	}
}