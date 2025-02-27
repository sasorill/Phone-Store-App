namespace Phone_Store_App
{
	partial class ctrlFindCard
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtFilterBy = new System.Windows.Forms.TextBox();
			this.cbFilterBy = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnFind = new System.Windows.Forms.Button();
			this.ctrlCardDetails1 = new Phone_Store_App.ctrlCardDetails();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.txtFilterBy);
			this.panel1.Controls.Add(this.btnFind);
			this.panel1.Controls.Add(this.cbFilterBy);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(880, 85);
			this.panel1.TabIndex = 0;
			// 
			// txtFilterBy
			// 
			this.txtFilterBy.Location = new System.Drawing.Point(433, 22);
			this.txtFilterBy.Name = "txtFilterBy";
			this.txtFilterBy.Size = new System.Drawing.Size(246, 31);
			this.txtFilterBy.TabIndex = 2;
			// 
			// cbFilterBy
			// 
			this.cbFilterBy.FormattingEnabled = true;
			this.cbFilterBy.Items.AddRange(new object[] {
            "Card ID",
            "Card Number",
            "Person ID"});
			this.cbFilterBy.Location = new System.Drawing.Point(162, 22);
			this.cbFilterBy.Name = "cbFilterBy";
			this.cbFilterBy.Size = new System.Drawing.Size(240, 33);
			this.cbFilterBy.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(14, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Filter By";
			// 
			// btnFind
			// 
			this.btnFind.BackColor = System.Drawing.Color.Brown;
			this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFind.ForeColor = System.Drawing.Color.White;
			this.btnFind.Location = new System.Drawing.Point(700, 9);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(162, 57);
			this.btnFind.TabIndex = 3;
			this.btnFind.Text = "Find";
			this.btnFind.UseVisualStyleBackColor = false;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// ctrlCardDetails1
			// 
			this.ctrlCardDetails1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ctrlCardDetails1.BackColor = System.Drawing.Color.Brown;
			this.ctrlCardDetails1.CardID = 0;
			this.ctrlCardDetails1.Location = new System.Drawing.Point(3, 94);
			this.ctrlCardDetails1.MaximumSize = new System.Drawing.Size(713, 415);
			this.ctrlCardDetails1.MinimumSize = new System.Drawing.Size(713, 415);
			this.ctrlCardDetails1.Name = "ctrlCardDetails1";
			this.ctrlCardDetails1.Size = new System.Drawing.Size(713, 415);
			this.ctrlCardDetails1.TabIndex = 4;
			// 
			// ctrlFindCard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.Color.Brown;
			this.Controls.Add(this.ctrlCardDetails1);
			this.Controls.Add(this.panel1);
			this.MaximumSize = new System.Drawing.Size(883, 514);
			this.MinimumSize = new System.Drawing.Size(883, 514);
			this.Name = "ctrlFindCard";
			this.Size = new System.Drawing.Size(883, 514);
			this.Load += new System.EventHandler(this.ctrlFindCard_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.TextBox txtFilterBy;
		private System.Windows.Forms.ComboBox cbFilterBy;
		private ctrlCardDetails ctrlCardDetails1;
	}
}
