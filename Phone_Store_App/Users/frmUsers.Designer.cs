namespace Phone_Store_App
{
	partial class frmUsers
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
			this.dgvUsers = new System.Windows.Forms.DataGridView();
			this.cmsUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.activeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.unActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtFilterBy = new System.Windows.Forms.TextBox();
			this.cbFilterBy = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.laCountUsers = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
			this.cmsUsers.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvUsers
			// 
			this.dgvUsers.AllowUserToAddRows = false;
			this.dgvUsers.AllowUserToDeleteRows = false;
			this.dgvUsers.AllowUserToOrderColumns = true;
			this.dgvUsers.BackgroundColor = System.Drawing.Color.Brown;
			this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsers.ContextMenuStrip = this.cmsUsers;
			this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvUsers.Location = new System.Drawing.Point(0, 618);
			this.dgvUsers.Name = "dgvUsers";
			this.dgvUsers.ReadOnly = true;
			this.dgvUsers.RowHeadersWidth = 82;
			this.dgvUsers.RowTemplate.Height = 33;
			this.dgvUsers.Size = new System.Drawing.Size(2337, 266);
			this.dgvUsers.TabIndex = 0;
			// 
			// cmsUsers
			// 
			this.cmsUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmsUsers.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.cmsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.activeToolStripMenuItem,
            this.unActiveToolStripMenuItem,
            this.addNewUserToolStripMenuItem,
            this.findUserToolStripMenuItem});
			this.cmsUsers.Name = "cmsUsers";
			this.cmsUsers.Size = new System.Drawing.Size(306, 412);
			// 
			// showDetailsToolStripMenuItem
			// 
			this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
			this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(305, 52);
			this.showDetailsToolStripMenuItem.Text = "Show Details";
			this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.Size = new System.Drawing.Size(305, 52);
			this.updateToolStripMenuItem.Text = "Update";
			this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(305, 52);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// activeToolStripMenuItem
			// 
			this.activeToolStripMenuItem.Name = "activeToolStripMenuItem";
			this.activeToolStripMenuItem.Size = new System.Drawing.Size(305, 52);
			this.activeToolStripMenuItem.Text = "Active";
			this.activeToolStripMenuItem.Click += new System.EventHandler(this.activeToolStripMenuItem_Click);
			// 
			// unActiveToolStripMenuItem
			// 
			this.unActiveToolStripMenuItem.Name = "unActiveToolStripMenuItem";
			this.unActiveToolStripMenuItem.Size = new System.Drawing.Size(305, 52);
			this.unActiveToolStripMenuItem.Text = "UnActive";
			this.unActiveToolStripMenuItem.Click += new System.EventHandler(this.unActiveToolStripMenuItem_Click);
			// 
			// addNewUserToolStripMenuItem
			// 
			this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
			this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(305, 52);
			this.addNewUserToolStripMenuItem.Text = "Add New User";
			this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
			// 
			// findUserToolStripMenuItem
			// 
			this.findUserToolStripMenuItem.Name = "findUserToolStripMenuItem";
			this.findUserToolStripMenuItem.Size = new System.Drawing.Size(305, 52);
			this.findUserToolStripMenuItem.Text = "Find User";
			this.findUserToolStripMenuItem.Click += new System.EventHandler(this.findUserToolStripMenuItem_Click);
			// 
			// txtFilterBy
			// 
			this.txtFilterBy.Location = new System.Drawing.Point(1930, 568);
			this.txtFilterBy.Name = "txtFilterBy";
			this.txtFilterBy.Size = new System.Drawing.Size(386, 31);
			this.txtFilterBy.TabIndex = 1;
			this.txtFilterBy.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// cbFilterBy
			// 
			this.cbFilterBy.FormattingEnabled = true;
			this.cbFilterBy.Items.AddRange(new object[] {
            "User ID",
            "Person ID"});
			this.cbFilterBy.Location = new System.Drawing.Point(1507, 566);
			this.cbFilterBy.Name = "cbFilterBy";
			this.cbFilterBy.Size = new System.Drawing.Size(386, 33);
			this.cbFilterBy.TabIndex = 2;
			this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(31, 566);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 31);
			this.label1.TabIndex = 3;
			this.label1.Text = "All Users";
			// 
			// laCountUsers
			// 
			this.laCountUsers.AutoSize = true;
			this.laCountUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.laCountUsers.Location = new System.Drawing.Point(204, 568);
			this.laCountUsers.Name = "laCountUsers";
			this.laCountUsers.Size = new System.Drawing.Size(59, 31);
			this.laCountUsers.TabIndex = 4;
			this.laCountUsers.Text = "???";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(1342, 568);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 31);
			this.label2.TabIndex = 6;
			this.label2.Text = "Filter By";
			// 
			// frmUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ClientSize = new System.Drawing.Size(2337, 884);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.laCountUsers);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbFilterBy);
			this.Controls.Add(this.txtFilterBy);
			this.Controls.Add(this.dgvUsers);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(2363, 955);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(2363, 955);
			this.Name = "frmUsers";
			this.Text = "Users";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmUsers_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
			this.cmsUsers.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvUsers;
		private System.Windows.Forms.TextBox txtFilterBy;
		private System.Windows.Forms.ComboBox cbFilterBy;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label laCountUsers;
		private System.Windows.Forms.ContextMenuStrip cmsUsers;
		private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem activeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem unActiveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem findUserToolStripMenuItem;
		private System.Windows.Forms.Label label2;
	}
}