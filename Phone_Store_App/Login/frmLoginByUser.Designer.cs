namespace Phone_Store_App
{
	partial class frmLoginByUser
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
			this.frmLogin = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.llLoginByPerson = new System.Windows.Forms.LinkLabel();
			this.llRememberMe = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// frmLogin
			// 
			this.frmLogin.BackColor = System.Drawing.Color.Brown;
			this.frmLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.frmLogin.ForeColor = System.Drawing.Color.White;
			this.frmLogin.Location = new System.Drawing.Point(1059, 501);
			this.frmLogin.Name = "frmLogin";
			this.frmLogin.Size = new System.Drawing.Size(246, 60);
			this.frmLogin.TabIndex = 0;
			this.frmLogin.Text = "Login";
			this.frmLogin.UseVisualStyleBackColor = false;
			this.frmLogin.Click += new System.EventHandler(this.frmLogin_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Brown;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(197, 153);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(188, 37);
			this.label1.TabIndex = 1;
			this.label1.Text = "User Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Brown;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(219, 251);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(166, 37);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password";
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserName.Location = new System.Drawing.Point(473, 150);
			this.txtUserName.Multiline = true;
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(511, 50);
			this.txtUserName.TabIndex = 3;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(473, 251);
			this.txtPassword.Multiline = true;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = 'x';
			this.txtPassword.Size = new System.Drawing.Size(511, 50);
			this.txtPassword.TabIndex = 4;
			// 
			// llLoginByPerson
			// 
			this.llLoginByPerson.AutoSize = true;
			this.llLoginByPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llLoginByPerson.LinkColor = System.Drawing.Color.White;
			this.llLoginByPerson.Location = new System.Drawing.Point(468, 406);
			this.llLoginByPerson.Name = "llLoginByPerson";
			this.llLoginByPerson.Size = new System.Drawing.Size(244, 37);
			this.llLoginByPerson.TabIndex = 5;
			this.llLoginByPerson.TabStop = true;
			this.llLoginByPerson.Text = "Login By Email";
			this.llLoginByPerson.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLoginByPerson_LinkClicked);
			// 
			// llRememberMe
			// 
			this.llRememberMe.AutoSize = true;
			this.llRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llRememberMe.ForeColor = System.Drawing.Color.White;
			this.llRememberMe.Location = new System.Drawing.Point(473, 327);
			this.llRememberMe.Name = "llRememberMe";
			this.llRememberMe.Size = new System.Drawing.Size(286, 41);
			this.llRememberMe.TabIndex = 6;
			this.llRememberMe.Text = "Remember Me?";
			this.llRememberMe.UseVisualStyleBackColor = true;
			this.llRememberMe.CheckedChanged += new System.EventHandler(this.llRememberMe_CheckedChanged);
			// 
			// frmLoginByUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.Color.Brown;
			this.ClientSize = new System.Drawing.Size(1317, 573);
			this.Controls.Add(this.llRememberMe);
			this.Controls.Add(this.llLoginByPerson);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.frmLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximumSize = new System.Drawing.Size(1343, 644);
			this.MinimumSize = new System.Drawing.Size(1343, 644);
			this.Name = "frmLoginByUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmLoginByUser";
			this.Load += new System.EventHandler(this.frmLoginByUser_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button frmLogin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.LinkLabel llLoginByPerson;
		private System.Windows.Forms.CheckBox llRememberMe;
	}
}