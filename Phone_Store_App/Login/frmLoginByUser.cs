using Phone_Store_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Store_App
{
	public partial class frmLoginByUser : Form
	{
		public frmLoginByUser()
		{
			InitializeComponent();
		}

		private void frmLogin_Click(object sender, EventArgs e)
		{
			string U = ClsUtilizationLogin.HashingPasswordToSHA1(txtPassword.Text);
			ClsUsers User = ClsUsers.FindUserNamePassword(txtUserName.Text, U);

			if (User != null)
			{

				if(llRememberMe.Checked)
				{
					ClsUtilizationLogin.RememberUsernameAndPassword(txtUserName.Text, txtPassword.Text);
				}
				else
				{
					ClsUtilizationLogin.RememberUsernameAndPassword("", "");
				}

				if(!User.IsActive)
				{
					MessageBox.Show("The User Is Not Active Contact To Your Manager","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				ClsUtilizationLogin.Users = User;
				this.Hide();
				frmPhoneStore frmPhone = new frmPhoneStore();
				frmPhone.ShowDialog();
			}
			else
			{
				MessageBox.Show("No User Account With This","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);	
			}
		}

		private void llLoginByPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			frmLoginScreen frmLogin = new frmLoginScreen();
			frmLogin.ShowDialog();
			
		}

		private void llRememberMe_CheckedChanged(object sender, EventArgs e)
		{
			if(llRememberMe.Checked)
			{
				ClsUtilizationLogin.RememberUsernameAndPassword(txtUserName.Text, txtPassword.Text);
			}
		}

		private void frmLoginByUser_Load(object sender, EventArgs e)
		{
			string UserName = txtUserName.Text;
			string Password = txtPassword.Text;
			if (ClsUtilizationLogin.GetStoredCredential(ref UserName, ref Password))
			{
				txtUserName.Text = UserName;
				txtPassword.Text = Password;
				llRememberMe.Checked = true;
			}
			else
				llRememberMe.Checked = false;
		}
	}
}
