namespace Phone_Store_App
{
	partial class frmLoginScreen
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
			this.laEmail = new System.Windows.Forms.Label();
			this.laLoginBy = new System.Windows.Forms.Label();
			this.laPassword = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.llRememberMe = new System.Windows.Forms.CheckBox();
			this.llNeedAnAccount = new System.Windows.Forms.LinkLabel();
			this.llLoginAsVisitor = new System.Windows.Forms.LinkLabel();
			this.llLoginByUser = new System.Windows.Forms.LinkLabel();
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.linkLabel5 = new System.Windows.Forms.LinkLabel();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// laEmail
			// 
			this.laEmail.AutoSize = true;
			this.laEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.laEmail.ForeColor = System.Drawing.Color.White;
			this.laEmail.Location = new System.Drawing.Point(94, 213);
			this.laEmail.Name = "laEmail";
			this.laEmail.Size = new System.Drawing.Size(102, 37);
			this.laEmail.TabIndex = 0;
			this.laEmail.Text = "Email";
			// 
			// laLoginBy
			// 
			this.laLoginBy.AutoSize = true;
			this.laLoginBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.laLoginBy.ForeColor = System.Drawing.Color.White;
			this.laLoginBy.Location = new System.Drawing.Point(523, 39);
			this.laLoginBy.Name = "laLoginBy";
			this.laLoginBy.Size = new System.Drawing.Size(244, 37);
			this.laLoginBy.TabIndex = 1;
			this.laLoginBy.Text = "Login By Email";
			// 
			// laPassword
			// 
			this.laPassword.AutoSize = true;
			this.laPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.laPassword.ForeColor = System.Drawing.Color.White;
			this.laPassword.Location = new System.Drawing.Point(94, 314);
			this.laPassword.Name = "laPassword";
			this.laPassword.Size = new System.Drawing.Size(166, 37);
			this.laPassword.TabIndex = 2;
			this.laPassword.Text = "Password";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(311, 210);
			this.txtEmail.Multiline = true;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(604, 46);
			this.txtEmail.TabIndex = 3;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(311, 305);
			this.txtPassword.Multiline = true;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(604, 46);
			this.txtPassword.TabIndex = 4;
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.Brown;
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(973, 200);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(239, 55);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// llRememberMe
			// 
			this.llRememberMe.AutoSize = true;
			this.llRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llRememberMe.ForeColor = System.Drawing.Color.White;
			this.llRememberMe.Location = new System.Drawing.Point(973, 305);
			this.llRememberMe.Name = "llRememberMe";
			this.llRememberMe.Size = new System.Drawing.Size(286, 41);
			this.llRememberMe.TabIndex = 6;
			this.llRememberMe.Text = "Remember Me?";
			this.llRememberMe.UseVisualStyleBackColor = true;
			this.llRememberMe.CheckedChanged += new System.EventHandler(this.llRememberMe_CheckedChanged);
			this.llRememberMe.Click += new System.EventHandler(this.llRememberMe_Click);
			// 
			// llNeedAnAccount
			// 
			this.llNeedAnAccount.AutoSize = true;
			this.llNeedAnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llNeedAnAccount.LinkColor = System.Drawing.Color.White;
			this.llNeedAnAccount.Location = new System.Drawing.Point(256, 436);
			this.llNeedAnAccount.Name = "llNeedAnAccount";
			this.llNeedAnAccount.Size = new System.Drawing.Size(301, 37);
			this.llNeedAnAccount.TabIndex = 7;
			this.llNeedAnAccount.TabStop = true;
			this.llNeedAnAccount.Text = "Need An Account?";
			this.llNeedAnAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llNeedAnAccount_LinkClicked);
			// 
			// llLoginAsVisitor
			// 
			this.llLoginAsVisitor.AutoSize = true;
			this.llLoginAsVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llLoginAsVisitor.LinkColor = System.Drawing.Color.White;
			this.llLoginAsVisitor.Location = new System.Drawing.Point(583, 436);
			this.llLoginAsVisitor.Name = "llLoginAsVisitor";
			this.llLoginAsVisitor.Size = new System.Drawing.Size(258, 37);
			this.llLoginAsVisitor.TabIndex = 8;
			this.llLoginAsVisitor.TabStop = true;
			this.llLoginAsVisitor.Text = "Login As Visitor";
			this.llLoginAsVisitor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLoginAsVisitor_LinkClicked);
			// 
			// llLoginByUser
			// 
			this.llLoginByUser.AutoSize = true;
			this.llLoginByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llLoginByUser.LinkColor = System.Drawing.Color.White;
			this.llLoginByUser.Location = new System.Drawing.Point(889, 436);
			this.llLoginByUser.Name = "llLoginByUser";
			this.llLoginByUser.Size = new System.Drawing.Size(230, 37);
			this.llLoginByUser.TabIndex = 9;
			this.llLoginByUser.TabStop = true;
			this.llLoginByUser.Text = "Login By User";
			this.llLoginByUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLoginByUser_LinkClicked);
			// 
			// linkLabel4
			// 
			this.linkLabel4.AutoSize = true;
			this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel4.LinkColor = System.Drawing.Color.White;
			this.linkLabel4.Location = new System.Drawing.Point(256, 537);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(183, 37);
			this.linkLabel4.TabIndex = 10;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "Our Privicy";
			// 
			// linkLabel5
			// 
			this.linkLabel5.AutoSize = true;
			this.linkLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel5.LinkColor = System.Drawing.Color.White;
			this.linkLabel5.Location = new System.Drawing.Point(566, 537);
			this.linkLabel5.Name = "linkLabel5";
			this.linkLabel5.Size = new System.Drawing.Size(370, 37);
			this.linkLabel5.TabIndex = 11;
			this.linkLabel5.TabStop = true;
			this.linkLabel5.Text = "Politice And Conditions";
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Brown;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(1213, 12);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(104, 52);
			this.btnClose.TabIndex = 12;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmLoginScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Brown;
			this.ClientSize = new System.Drawing.Size(1343, 644);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.linkLabel5);
			this.Controls.Add(this.linkLabel4);
			this.Controls.Add(this.llLoginByUser);
			this.Controls.Add(this.llLoginAsVisitor);
			this.Controls.Add(this.llNeedAnAccount);
			this.Controls.Add(this.llRememberMe);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.laPassword);
			this.Controls.Add(this.laLoginBy);
			this.Controls.Add(this.laEmail);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(1343, 644);
			this.MinimumSize = new System.Drawing.Size(1343, 644);
			this.Name = "frmLoginScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login Screen";
			this.Load += new System.EventHandler(this.frmLoginScreen_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label laEmail;
		private System.Windows.Forms.Label laLoginBy;
		private System.Windows.Forms.Label laPassword;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.CheckBox llRememberMe;
		private System.Windows.Forms.LinkLabel llNeedAnAccount;
		private System.Windows.Forms.LinkLabel llLoginAsVisitor;
		private System.Windows.Forms.LinkLabel llLoginByUser;
		private System.Windows.Forms.LinkLabel linkLabel4;
		private System.Windows.Forms.LinkLabel linkLabel5;
		private System.Windows.Forms.Button btnClose;
	}
}