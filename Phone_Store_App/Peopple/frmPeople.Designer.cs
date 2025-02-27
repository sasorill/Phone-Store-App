namespace Phone_Store_App
{
	partial class frmPeople
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
			this.dgvAllPeople = new System.Windows.Forms.DataGridView();
			this.cmsPeople = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contactsInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contactByEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.laPeopleCount = new System.Windows.Forms.Label();
			this.cbFilterBy = new System.Windows.Forms.ComboBox();
			this.txtFilterBy = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvAllPeople)).BeginInit();
			this.cmsPeople.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvAllPeople
			// 
			this.dgvAllPeople.AllowUserToAddRows = false;
			this.dgvAllPeople.AllowUserToDeleteRows = false;
			this.dgvAllPeople.AllowUserToOrderColumns = true;
			this.dgvAllPeople.BackgroundColor = System.Drawing.Color.Brown;
			this.dgvAllPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAllPeople.ContextMenuStrip = this.cmsPeople;
			this.dgvAllPeople.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvAllPeople.Location = new System.Drawing.Point(0, 583);
			this.dgvAllPeople.Name = "dgvAllPeople";
			this.dgvAllPeople.ReadOnly = true;
			this.dgvAllPeople.RowHeadersWidth = 82;
			this.dgvAllPeople.RowTemplate.Height = 33;
			this.dgvAllPeople.Size = new System.Drawing.Size(2306, 318);
			this.dgvAllPeople.TabIndex = 0;
			// 
			// cmsPeople
			// 
			this.cmsPeople.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmsPeople.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.cmsPeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.addNewPersonToolStripMenuItem,
            this.findPersonToolStripMenuItem,
            this.contactsInfoToolStripMenuItem,
            this.contactByEmailToolStripMenuItem});
			this.cmsPeople.Name = "cmsPeople";
			this.cmsPeople.Size = new System.Drawing.Size(321, 370);
			// 
			// showDetailsToolStripMenuItem
			// 
			this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
			this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(320, 46);
			this.showDetailsToolStripMenuItem.Text = "Show Details";
			this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.Size = new System.Drawing.Size(320, 46);
			this.updateToolStripMenuItem.Text = "Update";
			this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(320, 46);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// addNewPersonToolStripMenuItem
			// 
			this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
			this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(320, 46);
			this.addNewPersonToolStripMenuItem.Text = "Add New Person";
			this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
			// 
			// findPersonToolStripMenuItem
			// 
			this.findPersonToolStripMenuItem.Name = "findPersonToolStripMenuItem";
			this.findPersonToolStripMenuItem.Size = new System.Drawing.Size(320, 46);
			this.findPersonToolStripMenuItem.Text = "Find Person";
			this.findPersonToolStripMenuItem.Click += new System.EventHandler(this.findPersonToolStripMenuItem_Click);
			// 
			// contactsInfoToolStripMenuItem
			// 
			this.contactsInfoToolStripMenuItem.Name = "contactsInfoToolStripMenuItem";
			this.contactsInfoToolStripMenuItem.Size = new System.Drawing.Size(320, 46);
			this.contactsInfoToolStripMenuItem.Text = "Contact By Phone";
			this.contactsInfoToolStripMenuItem.Click += new System.EventHandler(this.contactsInfoToolStripMenuItem_Click);
			// 
			// contactByEmailToolStripMenuItem
			// 
			this.contactByEmailToolStripMenuItem.Name = "contactByEmailToolStripMenuItem";
			this.contactByEmailToolStripMenuItem.Size = new System.Drawing.Size(320, 46);
			this.contactByEmailToolStripMenuItem.Text = "Contact By Email";
			this.contactByEmailToolStripMenuItem.Click += new System.EventHandler(this.contactByEmailToolStripMenuItem_Click);
			// 
			// laPeopleCount
			// 
			this.laPeopleCount.AutoSize = true;
			this.laPeopleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.laPeopleCount.Location = new System.Drawing.Point(238, 522);
			this.laPeopleCount.Name = "laPeopleCount";
			this.laPeopleCount.Size = new System.Drawing.Size(62, 31);
			this.laPeopleCount.TabIndex = 2;
			this.laPeopleCount.Text = "???";
			// 
			// cbFilterBy
			// 
			this.cbFilterBy.AccessibleDescription = "";
			this.cbFilterBy.AccessibleName = "";
			this.cbFilterBy.FormattingEnabled = true;
			this.cbFilterBy.Items.AddRange(new object[] {
            "Person ID",
            "Email",
            "Phone",
            "First Name"});
			this.cbFilterBy.Location = new System.Drawing.Point(1486, 507);
			this.cbFilterBy.Name = "cbFilterBy";
			this.cbFilterBy.Size = new System.Drawing.Size(367, 33);
			this.cbFilterBy.TabIndex = 3;
			this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
			// 
			// txtFilterBy
			// 
			this.txtFilterBy.Location = new System.Drawing.Point(1891, 509);
			this.txtFilterBy.Name = "txtFilterBy";
			this.txtFilterBy.Size = new System.Drawing.Size(374, 31);
			this.txtFilterBy.TabIndex = 4;
			this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(1308, 507);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 31);
			this.label3.TabIndex = 5;
			this.label3.Text = "Filter By";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 516);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 31);
			this.label1.TabIndex = 6;
			this.label1.Text = "All People";
			// 
			// frmPeople
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ClientSize = new System.Drawing.Size(2306, 901);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtFilterBy);
			this.Controls.Add(this.cbFilterBy);
			this.Controls.Add(this.laPeopleCount);
			this.Controls.Add(this.dgvAllPeople);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(2332, 972);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(2332, 972);
			this.Name = "frmPeople";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "People";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmPeople_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAllPeople)).EndInit();
			this.cmsPeople.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvAllPeople;
		private System.Windows.Forms.Label laPeopleCount;
		private System.Windows.Forms.ComboBox cbFilterBy;
		private System.Windows.Forms.TextBox txtFilterBy;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ContextMenuStrip cmsPeople;
		private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem findPersonToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contactsInfoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contactByEmailToolStripMenuItem;
	}
}