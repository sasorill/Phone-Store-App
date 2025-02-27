namespace Phone_Store_App
{
	partial class frmShowProductToPerson
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
			this.tpProfile = new System.Windows.Forms.TabPage();
			this.ctrlCardDetails1 = new Phone_Store_App.ctrlCardDetails();
			this.ctrlPersonDetails1 = new Phone_Store_App.ctrlPersonDetails();
			this.msProfile = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.editNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.activeCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.unActiveCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewCardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tpProduct = new System.Windows.Forms.TabPage();
			this.flpProduct = new System.Windows.Forms.FlowLayoutPanel();
			this.tcProduct = new System.Windows.Forms.TabControl();
			this.tpFind = new System.Windows.Forms.TabPage();
			this.ctrlFindProduct1 = new Phone_Store_App.ctrlFindProduct();
			this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tpProfile.SuspendLayout();
			this.msProfile.SuspendLayout();
			this.tpProduct.SuspendLayout();
			this.tcProduct.SuspendLayout();
			this.tpFind.SuspendLayout();
			this.SuspendLayout();
			// 
			// tpProfile
			// 
			this.tpProfile.BackColor = System.Drawing.Color.Brown;
			this.tpProfile.Controls.Add(this.ctrlCardDetails1);
			this.tpProfile.Controls.Add(this.ctrlPersonDetails1);
			this.tpProfile.Controls.Add(this.msProfile);
			this.tpProfile.Location = new System.Drawing.Point(8, 8);
			this.tpProfile.Name = "tpProfile";
			this.tpProfile.Padding = new System.Windows.Forms.Padding(3);
			this.tpProfile.Size = new System.Drawing.Size(2287, 1076);
			this.tpProfile.TabIndex = 1;
			this.tpProfile.Text = "Profile";
			// 
			// ctrlCardDetails1
			// 
			this.ctrlCardDetails1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ctrlCardDetails1.BackColor = System.Drawing.Color.Brown;
			this.ctrlCardDetails1.CardID = 0;
			this.ctrlCardDetails1.Location = new System.Drawing.Point(17, 637);
			this.ctrlCardDetails1.Margin = new System.Windows.Forms.Padding(4);
			this.ctrlCardDetails1.MaximumSize = new System.Drawing.Size(1010, 548);
			this.ctrlCardDetails1.MinimumSize = new System.Drawing.Size(1010, 548);
			this.ctrlCardDetails1.Name = "ctrlCardDetails1";
			this.ctrlCardDetails1.Size = new System.Drawing.Size(1010, 548);
			this.ctrlCardDetails1.TabIndex = 3;
			// 
			// ctrlPersonDetails1
			// 
			this.ctrlPersonDetails1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ctrlPersonDetails1.BackColor = System.Drawing.Color.Brown;
			this.ctrlPersonDetails1.Location = new System.Drawing.Point(7, 57);
			this.ctrlPersonDetails1.Margin = new System.Windows.Forms.Padding(4);
			this.ctrlPersonDetails1.MaximumSize = new System.Drawing.Size(1414, 572);
			this.ctrlPersonDetails1.MinimumSize = new System.Drawing.Size(1414, 572);
			this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
			this.ctrlPersonDetails1.PersonID = -1;
			this.ctrlPersonDetails1.Size = new System.Drawing.Size(1414, 572);
			this.ctrlPersonDetails1.TabIndex = 0;
			// 
			// msProfile
			// 
			this.msProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.msProfile.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.msProfile.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.msProfile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.addNewCardToolStripMenuItem,
            this.settingToolStripMenuItem});
			this.msProfile.Location = new System.Drawing.Point(3, 3);
			this.msProfile.Name = "msProfile";
			this.msProfile.Size = new System.Drawing.Size(2281, 53);
			this.msProfile.TabIndex = 2;
			this.msProfile.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editNameToolStripMenuItem,
            this.editEmailToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.editPictureToolStripMenuItem,
            this.editPhoneToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(131, 49);
			this.toolStripMenuItem1.Text = "Profile";
			// 
			// editNameToolStripMenuItem
			// 
			this.editNameToolStripMenuItem.Name = "editNameToolStripMenuItem";
			this.editNameToolStripMenuItem.Size = new System.Drawing.Size(355, 54);
			this.editNameToolStripMenuItem.Text = "Edit Name";
			this.editNameToolStripMenuItem.Click += new System.EventHandler(this.editNameToolStripMenuItem_Click);
			// 
			// editEmailToolStripMenuItem
			// 
			this.editEmailToolStripMenuItem.Name = "editEmailToolStripMenuItem";
			this.editEmailToolStripMenuItem.Size = new System.Drawing.Size(355, 54);
			this.editEmailToolStripMenuItem.Text = "Edit Email";
			this.editEmailToolStripMenuItem.Click += new System.EventHandler(this.editEmailToolStripMenuItem_Click);
			// 
			// changePasswordToolStripMenuItem
			// 
			this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
			this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(355, 54);
			this.changePasswordToolStripMenuItem.Text = "Edit Password";
			this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
			// 
			// editPictureToolStripMenuItem
			// 
			this.editPictureToolStripMenuItem.Name = "editPictureToolStripMenuItem";
			this.editPictureToolStripMenuItem.Size = new System.Drawing.Size(355, 54);
			this.editPictureToolStripMenuItem.Text = "Edit Picture";
			// 
			// editPhoneToolStripMenuItem
			// 
			this.editPhoneToolStripMenuItem.Name = "editPhoneToolStripMenuItem";
			this.editPhoneToolStripMenuItem.Size = new System.Drawing.Size(355, 54);
			this.editPhoneToolStripMenuItem.Text = "Edit Phone";
			// 
			// addNewCardToolStripMenuItem
			// 
			this.addNewCardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateCardToolStripMenuItem,
            this.deleteCardToolStripMenuItem,
            this.activeCardToolStripMenuItem,
            this.unActiveCardToolStripMenuItem,
            this.addNewCardToolStripMenuItem1});
			this.addNewCardToolStripMenuItem.Name = "addNewCardToolStripMenuItem";
			this.addNewCardToolStripMenuItem.Size = new System.Drawing.Size(244, 49);
			this.addNewCardToolStripMenuItem.Text = "Manage Cards";
			// 
			// updateCardToolStripMenuItem
			// 
			this.updateCardToolStripMenuItem.Name = "updateCardToolStripMenuItem";
			this.updateCardToolStripMenuItem.Size = new System.Drawing.Size(366, 54);
			this.updateCardToolStripMenuItem.Text = "Update Card";
			this.updateCardToolStripMenuItem.Click += new System.EventHandler(this.updateCardToolStripMenuItem_Click);
			// 
			// deleteCardToolStripMenuItem
			// 
			this.deleteCardToolStripMenuItem.Name = "deleteCardToolStripMenuItem";
			this.deleteCardToolStripMenuItem.Size = new System.Drawing.Size(366, 54);
			this.deleteCardToolStripMenuItem.Text = "Delete Card";
			this.deleteCardToolStripMenuItem.Click += new System.EventHandler(this.deleteCardToolStripMenuItem_Click);
			// 
			// activeCardToolStripMenuItem
			// 
			this.activeCardToolStripMenuItem.Name = "activeCardToolStripMenuItem";
			this.activeCardToolStripMenuItem.Size = new System.Drawing.Size(366, 54);
			this.activeCardToolStripMenuItem.Text = "Active Card";
			this.activeCardToolStripMenuItem.Click += new System.EventHandler(this.activeCardToolStripMenuItem_Click);
			// 
			// unActiveCardToolStripMenuItem
			// 
			this.unActiveCardToolStripMenuItem.Name = "unActiveCardToolStripMenuItem";
			this.unActiveCardToolStripMenuItem.Size = new System.Drawing.Size(366, 54);
			this.unActiveCardToolStripMenuItem.Text = "UnActive Card";
			this.unActiveCardToolStripMenuItem.Click += new System.EventHandler(this.unActiveCardToolStripMenuItem_Click);
			// 
			// addNewCardToolStripMenuItem1
			// 
			this.addNewCardToolStripMenuItem1.Name = "addNewCardToolStripMenuItem1";
			this.addNewCardToolStripMenuItem1.Size = new System.Drawing.Size(366, 54);
			this.addNewCardToolStripMenuItem1.Text = "Add New Card";
			this.addNewCardToolStripMenuItem1.Click += new System.EventHandler(this.addNewCardToolStripMenuItem1_Click);
			// 
			// tpProduct
			// 
			this.tpProduct.Controls.Add(this.flpProduct);
			this.tpProduct.Location = new System.Drawing.Point(8, 8);
			this.tpProduct.Name = "tpProduct";
			this.tpProduct.Padding = new System.Windows.Forms.Padding(3);
			this.tpProduct.Size = new System.Drawing.Size(2287, 1076);
			this.tpProduct.TabIndex = 0;
			this.tpProduct.Text = "Product";
			this.tpProduct.UseVisualStyleBackColor = true;
			// 
			// flpProduct
			// 
			this.flpProduct.AutoScroll = true;
			this.flpProduct.BackColor = System.Drawing.Color.Transparent;
			this.flpProduct.Dock = System.Windows.Forms.DockStyle.Right;
			this.flpProduct.Location = new System.Drawing.Point(676, 3);
			this.flpProduct.Name = "flpProduct";
			this.flpProduct.Size = new System.Drawing.Size(1608, 1070);
			this.flpProduct.TabIndex = 0;
			// 
			// tcProduct
			// 
			this.tcProduct.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tcProduct.Controls.Add(this.tpProduct);
			this.tcProduct.Controls.Add(this.tpProfile);
			this.tcProduct.Controls.Add(this.tpFind);
			this.tcProduct.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tcProduct.Location = new System.Drawing.Point(0, 0);
			this.tcProduct.Multiline = true;
			this.tcProduct.Name = "tcProduct";
			this.tcProduct.SelectedIndex = 0;
			this.tcProduct.Size = new System.Drawing.Size(2303, 1131);
			this.tcProduct.TabIndex = 1;
			// 
			// tpFind
			// 
			this.tpFind.BackColor = System.Drawing.Color.Brown;
			this.tpFind.Controls.Add(this.ctrlFindProduct1);
			this.tpFind.Location = new System.Drawing.Point(8, 8);
			this.tpFind.Name = "tpFind";
			this.tpFind.Size = new System.Drawing.Size(2287, 1076);
			this.tpFind.TabIndex = 2;
			this.tpFind.Text = "Find";
			// 
			// ctrlFindProduct1
			// 
			this.ctrlFindProduct1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ctrlFindProduct1.BackColor = System.Drawing.Color.Brown;
			this.ctrlFindProduct1.Location = new System.Drawing.Point(0, 5);
			this.ctrlFindProduct1.Margin = new System.Windows.Forms.Padding(4);
			this.ctrlFindProduct1.MaximumSize = new System.Drawing.Size(1740, 1015);
			this.ctrlFindProduct1.MinimumSize = new System.Drawing.Size(1740, 1015);
			this.ctrlFindProduct1.Name = "ctrlFindProduct1";
			this.ctrlFindProduct1.Size = new System.Drawing.Size(1740, 1015);
			this.ctrlFindProduct1.TabIndex = 0;
			// 
			// settingToolStripMenuItem
			// 
			this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.editAccountToolStripMenuItem});
			this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
			this.settingToolStripMenuItem.Size = new System.Drawing.Size(141, 49);
			this.settingToolStripMenuItem.Text = "Setting";
			// 
			// logOutToolStripMenuItem
			// 
			this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
			this.logOutToolStripMenuItem.Size = new System.Drawing.Size(359, 54);
			this.logOutToolStripMenuItem.Text = "Log Out";
			this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
			// 
			// editAccountToolStripMenuItem
			// 
			this.editAccountToolStripMenuItem.Name = "editAccountToolStripMenuItem";
			this.editAccountToolStripMenuItem.Size = new System.Drawing.Size(359, 54);
			this.editAccountToolStripMenuItem.Text = "Edit Account";
			// 
			// frmShowProductToPerson
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2303, 1131);
			this.Controls.Add(this.tcProduct);
			this.MainMenuStrip = this.msProfile;
			this.MinimumSize = new System.Drawing.Size(2329, 1021);
			this.Name = "frmShowProductToPerson";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Product";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmShowProductToPerson_Load);
			this.tpProfile.ResumeLayout(false);
			this.tpProfile.PerformLayout();
			this.msProfile.ResumeLayout(false);
			this.msProfile.PerformLayout();
			this.tpProduct.ResumeLayout(false);
			this.tcProduct.ResumeLayout(false);
			this.tpFind.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabPage tpProfile;
		private System.Windows.Forms.TabPage tpProduct;
		private System.Windows.Forms.TabControl tcProduct;
		private System.Windows.Forms.FlowLayoutPanel flpProduct;
		private System.Windows.Forms.TabPage tpFind;
		private ctrlPersonDetails ctrlPersonDetails1;
		private System.Windows.Forms.MenuStrip msProfile;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editNameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editEmailToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editPictureToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editPhoneToolStripMenuItem;
		private ctrlFindProduct ctrlFindProduct1;
		private ctrlCardDetails ctrlCardDetails1;
		private System.Windows.Forms.ToolStripMenuItem addNewCardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateCardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteCardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem activeCardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem unActiveCardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewCardToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editAccountToolStripMenuItem;
	}
}