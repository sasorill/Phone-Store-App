namespace Phone_Store_App
{
	partial class frmPhoneStore
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhoneStore));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.allGategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.creditCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.allOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.currentUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allGategoriesToolStripMenuItem,
            this.creditCardToolStripMenuItem,
            this.allOrdersToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.currentUserToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(2319, 58);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// allGategoriesToolStripMenuItem
			// 
			this.allGategoriesToolStripMenuItem.Name = "allGategoriesToolStripMenuItem";
			this.allGategoriesToolStripMenuItem.Size = new System.Drawing.Size(271, 54);
			this.allGategoriesToolStripMenuItem.Text = "All Gategories";
			this.allGategoriesToolStripMenuItem.Click += new System.EventHandler(this.allGategoriesToolStripMenuItem_Click);
			// 
			// creditCardToolStripMenuItem
			// 
			this.creditCardToolStripMenuItem.Name = "creditCardToolStripMenuItem";
			this.creditCardToolStripMenuItem.Size = new System.Drawing.Size(228, 54);
			this.creditCardToolStripMenuItem.Text = "Credit Card";
			this.creditCardToolStripMenuItem.Click += new System.EventHandler(this.creditCardToolStripMenuItem_Click);
			// 
			// allOrdersToolStripMenuItem
			// 
			this.allOrdersToolStripMenuItem.Name = "allOrdersToolStripMenuItem";
			this.allOrdersToolStripMenuItem.Size = new System.Drawing.Size(205, 54);
			this.allOrdersToolStripMenuItem.Text = "All Orders";
			this.allOrdersToolStripMenuItem.Click += new System.EventHandler(this.allOrdersToolStripMenuItem_Click);
			// 
			// peopleToolStripMenuItem
			// 
			this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
			this.peopleToolStripMenuItem.Size = new System.Drawing.Size(153, 54);
			this.peopleToolStripMenuItem.Text = "People";
			this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
			// 
			// usersToolStripMenuItem
			// 
			this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
			this.usersToolStripMenuItem.Size = new System.Drawing.Size(131, 54);
			this.usersToolStripMenuItem.Text = "Users";
			this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
			// 
			// productsToolStripMenuItem
			// 
			this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
			this.productsToolStripMenuItem.Size = new System.Drawing.Size(187, 54);
			this.productsToolStripMenuItem.Text = "Products";
			this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 58);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(2319, 909);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// currentUserToolStripMenuItem
			// 
			this.currentUserToolStripMenuItem.Name = "currentUserToolStripMenuItem";
			this.currentUserToolStripMenuItem.Size = new System.Drawing.Size(248, 54);
			this.currentUserToolStripMenuItem.Text = "Current User";
			this.currentUserToolStripMenuItem.Click += new System.EventHandler(this.currentUserToolStripMenuItem_Click);
			// 
			// frmPhoneStore
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ClientSize = new System.Drawing.Size(2319, 967);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(2345, 1038);
			this.Name = "frmPhoneStore";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Phone Store";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem allGategoriesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem creditCardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem allOrdersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem currentUserToolStripMenuItem;
	}
}