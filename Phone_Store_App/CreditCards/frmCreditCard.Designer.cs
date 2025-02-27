namespace Phone_Store_App
{
	partial class frmCreditCard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreditCard));
			this.dgvCreditCard = new System.Windows.Forms.DataGridView();
			this.cmsCreditCard = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.activeCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.unActiveCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.laCountCards = new System.Windows.Forms.Label();
			this.txtFilterBy = new System.Windows.Forms.TextBox();
			this.cbFilterBy = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvCreditCard)).BeginInit();
			this.cmsCreditCard.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCreditCard
			// 
			this.dgvCreditCard.AllowUserToAddRows = false;
			this.dgvCreditCard.AllowUserToDeleteRows = false;
			this.dgvCreditCard.AllowUserToOrderColumns = true;
			this.dgvCreditCard.BackgroundColor = System.Drawing.Color.Brown;
			this.dgvCreditCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCreditCard.ContextMenuStrip = this.cmsCreditCard;
			this.dgvCreditCard.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvCreditCard.Location = new System.Drawing.Point(0, 621);
			this.dgvCreditCard.Name = "dgvCreditCard";
			this.dgvCreditCard.ReadOnly = true;
			this.dgvCreditCard.RowHeadersWidth = 82;
			this.dgvCreditCard.RowTemplate.Height = 33;
			this.dgvCreditCard.Size = new System.Drawing.Size(1641, 257);
			this.dgvCreditCard.TabIndex = 0;
			// 
			// cmsCreditCard
			// 
			this.cmsCreditCard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmsCreditCard.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.cmsCreditCard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.addNewCardToolStripMenuItem,
            this.findCardToolStripMenuItem,
            this.activeCardToolStripMenuItem,
            this.unActiveCardToolStripMenuItem});
			this.cmsCreditCard.Name = "cmsCreditCard";
			this.cmsCreditCard.Size = new System.Drawing.Size(308, 368);
			// 
			// showDetailsToolStripMenuItem
			// 
			this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
			this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(307, 52);
			this.showDetailsToolStripMenuItem.Text = "Show Details";
			this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.Size = new System.Drawing.Size(307, 52);
			this.updateToolStripMenuItem.Text = "Update";
			this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(307, 52);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// addNewCardToolStripMenuItem
			// 
			this.addNewCardToolStripMenuItem.Name = "addNewCardToolStripMenuItem";
			this.addNewCardToolStripMenuItem.Size = new System.Drawing.Size(307, 52);
			this.addNewCardToolStripMenuItem.Text = "Add New Card";
			this.addNewCardToolStripMenuItem.Click += new System.EventHandler(this.addNewCardToolStripMenuItem_Click);
			// 
			// findCardToolStripMenuItem
			// 
			this.findCardToolStripMenuItem.Name = "findCardToolStripMenuItem";
			this.findCardToolStripMenuItem.Size = new System.Drawing.Size(307, 52);
			this.findCardToolStripMenuItem.Text = "Find Card";
			this.findCardToolStripMenuItem.Click += new System.EventHandler(this.findCardToolStripMenuItem_Click);
			// 
			// activeCardToolStripMenuItem
			// 
			this.activeCardToolStripMenuItem.Name = "activeCardToolStripMenuItem";
			this.activeCardToolStripMenuItem.Size = new System.Drawing.Size(307, 52);
			this.activeCardToolStripMenuItem.Text = "Active Card";
			this.activeCardToolStripMenuItem.Click += new System.EventHandler(this.activeCardToolStripMenuItem_Click);
			// 
			// unActiveCardToolStripMenuItem
			// 
			this.unActiveCardToolStripMenuItem.Name = "unActiveCardToolStripMenuItem";
			this.unActiveCardToolStripMenuItem.Size = new System.Drawing.Size(307, 52);
			this.unActiveCardToolStripMenuItem.Text = "UnActive Card";
			this.unActiveCardToolStripMenuItem.Click += new System.EventHandler(this.unActiveCardToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(34, 565);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "Cards";
			// 
			// laCountCards
			// 
			this.laCountCards.AutoSize = true;
			this.laCountCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.laCountCards.Location = new System.Drawing.Point(206, 565);
			this.laCountCards.Name = "laCountCards";
			this.laCountCards.Size = new System.Drawing.Size(59, 31);
			this.laCountCards.TabIndex = 2;
			this.laCountCards.Text = "???";
			// 
			// txtFilterBy
			// 
			this.txtFilterBy.Location = new System.Drawing.Point(1365, 568);
			this.txtFilterBy.Name = "txtFilterBy";
			this.txtFilterBy.Size = new System.Drawing.Size(264, 31);
			this.txtFilterBy.TabIndex = 4;
			// 
			// cbFilterBy
			// 
			this.cbFilterBy.FormattingEnabled = true;
			this.cbFilterBy.Items.AddRange(new object[] {
            "Card ID",
            "Person ID",
            "All Cative Cards",
            "All UnActive Cards"});
			this.cbFilterBy.Location = new System.Drawing.Point(1082, 566);
			this.cbFilterBy.Name = "cbFilterBy";
			this.cbFilterBy.Size = new System.Drawing.Size(261, 33);
			this.cbFilterBy.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(933, 566);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 31);
			this.label2.TabIndex = 6;
			this.label2.Text = "Filter By";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(348, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(670, 416);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// frmCreditCard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ClientSize = new System.Drawing.Size(1641, 878);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbFilterBy);
			this.Controls.Add(this.txtFilterBy);
			this.Controls.Add(this.laCountCards);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvCreditCard);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1667, 949);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1667, 949);
			this.Name = "frmCreditCard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Credit Card";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmCreditCard_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCreditCard)).EndInit();
			this.cmsCreditCard.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvCreditCard;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label laCountCards;
		private System.Windows.Forms.ContextMenuStrip cmsCreditCard;
		private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewCardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem findCardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem activeCardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem unActiveCardToolStripMenuItem;
		private System.Windows.Forms.TextBox txtFilterBy;
		private System.Windows.Forms.ComboBox cbFilterBy;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}