namespace Phone_Store_App
{
	partial class frmAddUpdateUser
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tcFindPerson = new System.Windows.Forms.TabPage();
			this.ctrlFindPerson1 = new Phone_Store_App.ctrlFindPerson();
			this.tcUserLogin = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.laUserID = new System.Windows.Forms.Label();
			this.laPersonID = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.chkIsActive = new System.Windows.Forms.CheckBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tcFindPerson.SuspendLayout();
			this.tcUserLogin.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tcFindPerson);
			this.tabControl1.Controls.Add(this.tcUserLogin);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1608, 725);
			this.tabControl1.TabIndex = 0;
			// 
			// tcFindPerson
			// 
			this.tcFindPerson.BackColor = System.Drawing.Color.Brown;
			this.tcFindPerson.Controls.Add(this.ctrlFindPerson1);
			this.tcFindPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tcFindPerson.Location = new System.Drawing.Point(8, 39);
			this.tcFindPerson.Name = "tcFindPerson";
			this.tcFindPerson.Padding = new System.Windows.Forms.Padding(3);
			this.tcFindPerson.Size = new System.Drawing.Size(1592, 678);
			this.tcFindPerson.TabIndex = 0;
			this.tcFindPerson.Text = "Find Person";
			// 
			// ctrlFindPerson1
			// 
			this.ctrlFindPerson1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ctrlFindPerson1.BackColor = System.Drawing.Color.Brown;
			this.ctrlFindPerson1.Location = new System.Drawing.Point(-5, 4);
			this.ctrlFindPerson1.Margin = new System.Windows.Forms.Padding(4);
			this.ctrlFindPerson1.MaximumSize = new System.Drawing.Size(1597, 651);
			this.ctrlFindPerson1.MinimumSize = new System.Drawing.Size(1597, 651);
			this.ctrlFindPerson1.Name = "ctrlFindPerson1";
			this.ctrlFindPerson1.PersonID = -1;
			this.ctrlFindPerson1.Size = new System.Drawing.Size(1597, 651);
			this.ctrlFindPerson1.TabIndex = 0;
			this.ctrlFindPerson1.OnFindComplete += new System.Action<int>(this.ctrlFindPerson1_OnFindComplete_1);
			// 
			// tcUserLogin
			// 
			this.tcUserLogin.Controls.Add(this.panel1);
			this.tcUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tcUserLogin.Location = new System.Drawing.Point(8, 39);
			this.tcUserLogin.Name = "tcUserLogin";
			this.tcUserLogin.Padding = new System.Windows.Forms.Padding(3);
			this.tcUserLogin.Size = new System.Drawing.Size(1592, 678);
			this.tcUserLogin.TabIndex = 1;
			this.tcUserLogin.Text = "Login User";
			this.tcUserLogin.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Brown;
			this.panel1.Controls.Add(this.laUserID);
			this.panel1.Controls.Add(this.laPersonID);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.chkIsActive);
			this.panel1.Controls.Add(this.txtPassword);
			this.panel1.Controls.Add(this.txtUserName);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1586, 672);
			this.panel1.TabIndex = 0;
			// 
			// laUserID
			// 
			this.laUserID.AutoSize = true;
			this.laUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.laUserID.ForeColor = System.Drawing.Color.White;
			this.laUserID.Location = new System.Drawing.Point(467, 59);
			this.laUserID.Name = "laUserID";
			this.laUserID.Size = new System.Drawing.Size(63, 33);
			this.laUserID.TabIndex = 11;
			this.laUserID.Text = "???";
			// 
			// laPersonID
			// 
			this.laPersonID.AutoSize = true;
			this.laPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.laPersonID.ForeColor = System.Drawing.Color.White;
			this.laPersonID.Location = new System.Drawing.Point(467, 153);
			this.laPersonID.Name = "laPersonID";
			this.laPersonID.Size = new System.Drawing.Size(63, 33);
			this.laPersonID.TabIndex = 10;
			this.laPersonID.Text = "???";
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Brown;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(454, 573);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(280, 81);
			this.btnClose.TabIndex = 9;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Brown;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(800, 573);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(280, 81);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// chkIsActive
			// 
			this.chkIsActive.AutoSize = true;
			this.chkIsActive.ForeColor = System.Drawing.Color.White;
			this.chkIsActive.Location = new System.Drawing.Point(473, 451);
			this.chkIsActive.Name = "chkIsActive";
			this.chkIsActive.Size = new System.Drawing.Size(136, 35);
			this.chkIsActive.TabIndex = 7;
			this.chkIsActive.Text = "Active?";
			this.chkIsActive.UseVisualStyleBackColor = true;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(480, 354);
			this.txtPassword.Multiline = true;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(600, 53);
			this.txtPassword.TabIndex = 6;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(480, 248);
			this.txtUserName.Multiline = true;
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(600, 53);
			this.txtUserName.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(234, 444);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(118, 33);
			this.label5.TabIndex = 4;
			this.label5.Text = "IsActive";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(234, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 33);
			this.label4.TabIndex = 3;
			this.label4.Text = "Person ID";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(234, 250);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(163, 33);
			this.label3.TabIndex = 2;
			this.label3.Text = "User Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(234, 354);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(234, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "User ID";
			// 
			// frmAddUpdateUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.Color.Brown;
			this.ClientSize = new System.Drawing.Size(1608, 725);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximumSize = new System.Drawing.Size(1634, 796);
			this.MinimumSize = new System.Drawing.Size(1634, 796);
			this.Name = "frmAddUpdateUser";
			this.Text = "Add Update User";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Activated += new System.EventHandler(this.frmAddUpdateUser_Activated);
			this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
			this.tabControl1.ResumeLayout(false);
			this.tcFindPerson.ResumeLayout(false);
			this.tcUserLogin.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tcFindPerson;
		private System.Windows.Forms.TabPage tcUserLogin;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox chkIsActive;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label laUserID;
		private System.Windows.Forms.Label laPersonID;
		private ctrlFindPerson ctrlFindPerson1;
	}
}