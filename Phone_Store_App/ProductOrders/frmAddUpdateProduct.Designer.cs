namespace Phone_Store_App
{
	partial class frmAddUpdateProduct
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
			this.pbProduct = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.laProducID = new System.Windows.Forms.Label();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.cbCategories = new System.Windows.Forms.ComboBox();
			this.cbCountry = new System.Windows.Forms.ComboBox();
			this.cbColor = new System.Windows.Forms.ComboBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.dtpMakeDate = new System.Windows.Forms.DateTimePicker();
			this.rtxtDescription = new System.Windows.Forms.RichTextBox();
			this.llSetImage = new System.Windows.Forms.LinkLabel();
			this.llRemoveImage = new System.Windows.Forms.LinkLabel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
			this.SuspendLayout();
			// 
			// pbProduct
			// 
			this.pbProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbProduct.Location = new System.Drawing.Point(639, 12);
			this.pbProduct.Name = "pbProduct";
			this.pbProduct.Size = new System.Drawing.Size(435, 628);
			this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbProduct.TabIndex = 0;
			this.pbProduct.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(1, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "Product ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(1, 609);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 31);
			this.label2.TabIndex = 2;
			this.label2.Text = "Description";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(1, 540);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 31);
			this.label3.TabIndex = 3;
			this.label3.Text = "Price";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(1, 452);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 31);
			this.label4.TabIndex = 4;
			this.label4.Text = "Color";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(1, 364);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(125, 31);
			this.label5.TabIndex = 5;
			this.label5.Text = "Maide In";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(1, 276);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(211, 31);
			this.label6.TabIndex = 6;
			this.label6.Text = "Date Of Create";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(1, 188);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(133, 31);
			this.label7.TabIndex = 7;
			this.label7.Text = "Category";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(1, 100);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(199, 31);
			this.label8.TabIndex = 8;
			this.label8.Text = "Product Name";
			// 
			// laProducID
			// 
			this.laProducID.AutoSize = true;
			this.laProducID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.laProducID.ForeColor = System.Drawing.Color.White;
			this.laProducID.Location = new System.Drawing.Point(234, 12);
			this.laProducID.Name = "laProducID";
			this.laProducID.Size = new System.Drawing.Size(62, 31);
			this.laProducID.TabIndex = 9;
			this.laProducID.Text = "???";
			// 
			// txtProductName
			// 
			this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductName.Location = new System.Drawing.Point(224, 101);
			this.txtProductName.Multiline = true;
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(368, 38);
			this.txtProductName.TabIndex = 10;
			// 
			// cbCategories
			// 
			this.cbCategories.FormattingEnabled = true;
			this.cbCategories.Location = new System.Drawing.Point(224, 192);
			this.cbCategories.Name = "cbCategories";
			this.cbCategories.Size = new System.Drawing.Size(368, 33);
			this.cbCategories.TabIndex = 11;
			// 
			// cbCountry
			// 
			this.cbCountry.FormattingEnabled = true;
			this.cbCountry.Location = new System.Drawing.Point(224, 367);
			this.cbCountry.Name = "cbCountry";
			this.cbCountry.Size = new System.Drawing.Size(368, 33);
			this.cbCountry.TabIndex = 12;
			// 
			// cbColor
			// 
			this.cbColor.FormattingEnabled = true;
			this.cbColor.Location = new System.Drawing.Point(223, 455);
			this.cbColor.Name = "cbColor";
			this.cbColor.Size = new System.Drawing.Size(368, 33);
			this.cbColor.TabIndex = 13;
			// 
			// txtPrice
			// 
			this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrice.Location = new System.Drawing.Point(223, 532);
			this.txtPrice.Multiline = true;
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(368, 39);
			this.txtPrice.TabIndex = 14;
			// 
			// dtpMakeDate
			// 
			this.dtpMakeDate.Location = new System.Drawing.Point(224, 277);
			this.dtpMakeDate.Name = "dtpMakeDate";
			this.dtpMakeDate.Size = new System.Drawing.Size(367, 31);
			this.dtpMakeDate.TabIndex = 15;
			// 
			// rtxtDescription
			// 
			this.rtxtDescription.Location = new System.Drawing.Point(7, 669);
			this.rtxtDescription.Name = "rtxtDescription";
			this.rtxtDescription.Size = new System.Drawing.Size(585, 154);
			this.rtxtDescription.TabIndex = 16;
			this.rtxtDescription.Text = "";
			// 
			// llSetImage
			// 
			this.llSetImage.AutoSize = true;
			this.llSetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llSetImage.LinkColor = System.Drawing.Color.White;
			this.llSetImage.Location = new System.Drawing.Point(633, 666);
			this.llSetImage.Name = "llSetImage";
			this.llSetImage.Size = new System.Drawing.Size(137, 31);
			this.llSetImage.TabIndex = 17;
			this.llSetImage.TabStop = true;
			this.llSetImage.Text = "Set Image";
			this.llSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImage_LinkClicked);
			// 
			// llRemoveImage
			// 
			this.llRemoveImage.AutoSize = true;
			this.llRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llRemoveImage.LinkColor = System.Drawing.Color.White;
			this.llRemoveImage.Location = new System.Drawing.Point(854, 666);
			this.llRemoveImage.Name = "llRemoveImage";
			this.llRemoveImage.Size = new System.Drawing.Size(197, 31);
			this.llRemoveImage.TabIndex = 18;
			this.llRemoveImage.TabStop = true;
			this.llRemoveImage.Text = "Remove Image";
			this.llRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemoveImage_LinkClicked);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Brown;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(623, 751);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(209, 55);
			this.btnCancel.TabIndex = 19;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Brown;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(860, 751);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(209, 55);
			this.btnSave.TabIndex = 20;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// frmAddUpdateProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.Color.Brown;
			this.ClientSize = new System.Drawing.Size(1091, 835);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.llRemoveImage);
			this.Controls.Add(this.llSetImage);
			this.Controls.Add(this.rtxtDescription);
			this.Controls.Add(this.dtpMakeDate);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.cbColor);
			this.Controls.Add(this.cbCountry);
			this.Controls.Add(this.cbCategories);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.laProducID);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pbProduct);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1117, 906);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1117, 906);
			this.Name = "frmAddUpdateProduct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Add Update Product";
			this.Load += new System.EventHandler(this.frmAddUpdateProduct_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbProduct;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label laProducID;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.ComboBox cbCategories;
		private System.Windows.Forms.ComboBox cbCountry;
		private System.Windows.Forms.ComboBox cbColor;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.DateTimePicker dtpMakeDate;
		private System.Windows.Forms.RichTextBox rtxtDescription;
		private System.Windows.Forms.LinkLabel llSetImage;
		private System.Windows.Forms.LinkLabel llRemoveImage;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}