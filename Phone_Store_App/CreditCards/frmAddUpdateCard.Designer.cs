namespace Phone_Store_App
{
	partial class frmAddUpdateCard
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tcFindPerson = new System.Windows.Forms.TabPage();
			this.ctrlFindPerson1 = new Phone_Store_App.ctrlFindPerson();
			this.tcAddCardInfo = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
			this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cbCardClassics = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.chIsActive = new System.Windows.Forms.CheckBox();
			this.txtCarcCVC = new System.Windows.Forms.TextBox();
			this.txtCardNumber = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.laPersonID = new System.Windows.Forms.Label();
			this.laCardID = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tcFindPerson.SuspendLayout();
			this.tcAddCardInfo.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tabControl1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1632, 725);
			this.panel1.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tcFindPerson);
			this.tabControl1.Controls.Add(this.tcAddCardInfo);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1632, 725);
			this.tabControl1.TabIndex = 0;
			// 
			// tcFindPerson
			// 
			this.tcFindPerson.BackColor = System.Drawing.Color.Brown;
			this.tcFindPerson.Controls.Add(this.ctrlFindPerson1);
			this.tcFindPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tcFindPerson.Location = new System.Drawing.Point(8, 47);
			this.tcFindPerson.Name = "tcFindPerson";
			this.tcFindPerson.Padding = new System.Windows.Forms.Padding(3);
			this.tcFindPerson.Size = new System.Drawing.Size(1616, 670);
			this.tcFindPerson.TabIndex = 0;
			this.tcFindPerson.Text = "Find Person";
			// 
			// ctrlFindPerson1
			// 
			this.ctrlFindPerson1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ctrlFindPerson1.BackColor = System.Drawing.Color.Brown;
			this.ctrlFindPerson1.Location = new System.Drawing.Point(7, 4);
			this.ctrlFindPerson1.Margin = new System.Windows.Forms.Padding(4);
			this.ctrlFindPerson1.MaximumSize = new System.Drawing.Size(1597, 651);
			this.ctrlFindPerson1.MinimumSize = new System.Drawing.Size(1597, 651);
			this.ctrlFindPerson1.Name = "ctrlFindPerson1";
			this.ctrlFindPerson1.PersonID = -1;
			this.ctrlFindPerson1.Size = new System.Drawing.Size(1597, 651);
			this.ctrlFindPerson1.TabIndex = 0;
			this.ctrlFindPerson1.OnFindComplete += new System.Action<int>(this.ctrlFindPerson1_OnFindComplete_1);
			// 
			// tcAddCardInfo
			// 
			this.tcAddCardInfo.Controls.Add(this.panel2);
			this.tcAddCardInfo.Location = new System.Drawing.Point(8, 47);
			this.tcAddCardInfo.Name = "tcAddCardInfo";
			this.tcAddCardInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tcAddCardInfo.Size = new System.Drawing.Size(1616, 670);
			this.tcAddCardInfo.TabIndex = 1;
			this.tcAddCardInfo.Text = "Add Card Info";
			this.tcAddCardInfo.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Brown;
			this.panel2.Controls.Add(this.dtpEndDate);
			this.panel2.Controls.Add(this.dtpStartDate);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.cbCardClassics);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Controls.Add(this.btnClose);
			this.panel2.Controls.Add(this.chIsActive);
			this.panel2.Controls.Add(this.txtCarcCVC);
			this.panel2.Controls.Add(this.txtCardNumber);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.laPersonID);
			this.panel2.Controls.Add(this.laCardID);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Enabled = false;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1610, 664);
			this.panel2.TabIndex = 0;
			// 
			// dtpEndDate
			// 
			this.dtpEndDate.Location = new System.Drawing.Point(1089, 282);
			this.dtpEndDate.MaxDate = new System.DateTime(2028, 12, 31, 0, 0, 0, 0);
			this.dtpEndDate.MinDate = new System.DateTime(2024, 8, 17, 0, 0, 0, 0);
			this.dtpEndDate.Name = "dtpEndDate";
			this.dtpEndDate.Size = new System.Drawing.Size(500, 40);
			this.dtpEndDate.TabIndex = 17;
			// 
			// dtpStartDate
			// 
			this.dtpStartDate.Location = new System.Drawing.Point(1089, 182);
			this.dtpStartDate.MaxDate = new System.DateTime(2028, 12, 31, 0, 0, 0, 0);
			this.dtpStartDate.MinDate = new System.DateTime(2024, 8, 17, 0, 0, 0, 0);
			this.dtpStartDate.Name = "dtpStartDate";
			this.dtpStartDate.Size = new System.Drawing.Size(500, 40);
			this.dtpStartDate.TabIndex = 16;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(882, 281);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(148, 37);
			this.label8.TabIndex = 15;
			this.label8.Text = "EndDate";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(882, 186);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(171, 37);
			this.label7.TabIndex = 14;
			this.label7.Text = "Start Date";
			// 
			// cbCardClassics
			// 
			this.cbCardClassics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbCardClassics.FormattingEnabled = true;
			this.cbCardClassics.Location = new System.Drawing.Point(310, 386);
			this.cbCardClassics.Name = "cbCardClassics";
			this.cbCardClassics.Size = new System.Drawing.Size(507, 45);
			this.cbCardClassics.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(16, 386);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(186, 37);
			this.label6.TabIndex = 12;
			this.label6.Text = "Card Class";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Brown;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(785, 558);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(242, 77);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Brown;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(442, 558);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(242, 77);
			this.btnClose.TabIndex = 10;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// chIsActive
			// 
			this.chIsActive.AutoSize = true;
			this.chIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chIsActive.ForeColor = System.Drawing.Color.White;
			this.chIsActive.Location = new System.Drawing.Point(1193, 388);
			this.chIsActive.Name = "chIsActive";
			this.chIsActive.Size = new System.Drawing.Size(159, 41);
			this.chIsActive.TabIndex = 9;
			this.chIsActive.Text = "Active?";
			this.chIsActive.UseVisualStyleBackColor = true;
			// 
			// txtCarcCVC
			// 
			this.txtCarcCVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCarcCVC.Location = new System.Drawing.Point(310, 282);
			this.txtCarcCVC.MaxLength = 3;
			this.txtCarcCVC.Multiline = true;
			this.txtCarcCVC.Name = "txtCarcCVC";
			this.txtCarcCVC.Size = new System.Drawing.Size(507, 50);
			this.txtCarcCVC.TabIndex = 8;
			// 
			// txtCardNumber
			// 
			this.txtCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCardNumber.Location = new System.Drawing.Point(310, 187);
			this.txtCardNumber.MaxLength = 19;
			this.txtCardNumber.Multiline = true;
			this.txtCardNumber.Name = "txtCardNumber";
			this.txtCardNumber.Size = new System.Drawing.Size(507, 50);
			this.txtCardNumber.TabIndex = 7;
			this.txtCardNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtCardNumber_Validating);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(882, 388);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(145, 37);
			this.label5.TabIndex = 6;
			this.label5.Text = "Is Active";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(16, 295);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(172, 37);
			this.label3.TabIndex = 5;
			this.label3.Text = "Card CVC";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(16, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(222, 37);
			this.label2.TabIndex = 4;
			this.label2.Text = "Card Number";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(16, 97);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(167, 37);
			this.label4.TabIndex = 3;
			this.label4.Text = "Person ID";
			// 
			// laPersonID
			// 
			this.laPersonID.AutoSize = true;
			this.laPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.laPersonID.ForeColor = System.Drawing.Color.White;
			this.laPersonID.Location = new System.Drawing.Point(303, 97);
			this.laPersonID.Name = "laPersonID";
			this.laPersonID.Size = new System.Drawing.Size(71, 37);
			this.laPersonID.TabIndex = 2;
			this.laPersonID.Text = "???";
			// 
			// laCardID
			// 
			this.laCardID.AutoSize = true;
			this.laCardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.laCardID.ForeColor = System.Drawing.Color.White;
			this.laCardID.Location = new System.Drawing.Point(303, 8);
			this.laCardID.Name = "laCardID";
			this.laCardID.Size = new System.Drawing.Size(71, 37);
			this.laCardID.TabIndex = 1;
			this.laCardID.Text = "???";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Card ID";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// frmAddUpdateCard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ClientSize = new System.Drawing.Size(1632, 725);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1658, 796);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1658, 796);
			this.Name = "frmAddUpdateCard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Add Update Card";
			this.Load += new System.EventHandler(this.frmAddUpdateCard_Load);
			this.panel1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tcFindPerson.ResumeLayout(false);
			this.tcAddCardInfo.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tcFindPerson;
		private System.Windows.Forms.TabPage tcAddCardInfo;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label laPersonID;
		private System.Windows.Forms.Label laCardID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chIsActive;
		private System.Windows.Forms.TextBox txtCarcCVC;
		private System.Windows.Forms.TextBox txtCardNumber;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
		private ctrlFindPerson ctrlFindPerson1;
		private System.Windows.Forms.DateTimePicker dtpEndDate;
		private System.Windows.Forms.DateTimePicker dtpStartDate;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbCardClassics;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}