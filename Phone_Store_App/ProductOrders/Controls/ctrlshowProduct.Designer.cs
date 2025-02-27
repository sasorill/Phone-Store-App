namespace Phone_Store_App
{
	partial class ctrlshowProduct
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
			this.pbProduct = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.laProductName = new System.Windows.Forms.Label();
			this.tt = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.laPrice = new System.Windows.Forms.Label();
			this.laCategory = new System.Windows.Forms.Label();
			this.btnView = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
			this.SuspendLayout();
			// 
			// pbProduct
			// 
			this.pbProduct.Location = new System.Drawing.Point(0, 0);
			this.pbProduct.Name = "pbProduct";
			this.pbProduct.Size = new System.Drawing.Size(559, 544);
			this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbProduct.TabIndex = 0;
			this.pbProduct.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(3, 564);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name";
			// 
			// laProductName
			// 
			this.laProductName.AutoSize = true;
			this.laProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.laProductName.ForeColor = System.Drawing.Color.Black;
			this.laProductName.Location = new System.Drawing.Point(228, 564);
			this.laProductName.Name = "laProductName";
			this.laProductName.Size = new System.Drawing.Size(62, 31);
			this.laProductName.TabIndex = 2;
			this.laProductName.Text = "???";
			// 
			// tt
			// 
			this.tt.AutoSize = true;
			this.tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tt.ForeColor = System.Drawing.Color.Black;
			this.tt.Location = new System.Drawing.Point(3, 630);
			this.tt.Name = "tt";
			this.tt.Size = new System.Drawing.Size(133, 31);
			this.tt.TabIndex = 3;
			this.tt.Text = "Category";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(3, 693);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 31);
			this.label3.TabIndex = 4;
			this.label3.Text = "Price";
			// 
			// laPrice
			// 
			this.laPrice.AutoSize = true;
			this.laPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.laPrice.ForeColor = System.Drawing.Color.Black;
			this.laPrice.Location = new System.Drawing.Point(228, 693);
			this.laPrice.Name = "laPrice";
			this.laPrice.Size = new System.Drawing.Size(62, 31);
			this.laPrice.TabIndex = 5;
			this.laPrice.Text = "???";
			// 
			// laCategory
			// 
			this.laCategory.AutoSize = true;
			this.laCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.laCategory.ForeColor = System.Drawing.Color.Black;
			this.laCategory.Location = new System.Drawing.Point(228, 630);
			this.laCategory.Name = "laCategory";
			this.laCategory.Size = new System.Drawing.Size(62, 31);
			this.laCategory.TabIndex = 6;
			this.laCategory.Text = "???";
			// 
			// btnView
			// 
			this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnView.Location = new System.Drawing.Point(263, 751);
			this.btnView.Name = "btnView";
			this.btnView.Size = new System.Drawing.Size(286, 46);
			this.btnView.TabIndex = 7;
			this.btnView.Text = "View";
			this.btnView.UseVisualStyleBackColor = true;
			this.btnView.Click += new System.EventHandler(this.btnView_Click);
			// 
			// ctrlshowProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.btnView);
			this.Controls.Add(this.laCategory);
			this.Controls.Add(this.laPrice);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tt);
			this.Controls.Add(this.laProductName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pbProduct);
			this.MaximumSize = new System.Drawing.Size(565, 809);
			this.MinimumSize = new System.Drawing.Size(565, 809);
			this.Name = "ctrlshowProduct";
			this.Size = new System.Drawing.Size(565, 809);
			((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbProduct;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label laProductName;
		private System.Windows.Forms.Label tt;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label laPrice;
		private System.Windows.Forms.Label laCategory;
		private System.Windows.Forms.Button btnView;
	}
}
