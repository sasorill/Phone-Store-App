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
	public partial class frmLoginScreen : Form
	{
		public frmLoginScreen()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			
			string U = ClsUtilizationLogin.HashingPasswordToSHA1(txtPassword.Text);
			
			ClsPeople Person = ClsPeople.FindPersonByEmailAndPassword(txtEmail.Text, U);
			
			if (Person != null) 
			{

				if(llRememberMe.Checked)
				{
					ClsUtilizationLogin.RememberEmailAndPassword(txtEmail.Text, txtPassword.Text);
				}
				else
				{
					ClsUtilizationLogin.RememberEmailAndPassword("", "");
				}

				ClsUtilizationLogin.Person = Person;
				this.Hide();
				frmShowProductToPerson Products = new frmShowProductToPerson();
				Products.ShowDialog();
			}
			else
			{
				MessageBox.Show("No Email With This Person","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void llNeedAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmAddUpdatePerson Person = new frmAddUpdatePerson();
			Person.ShowDialog();
		}

		private void llLoginAsVisitor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ClsUtilizationLogin Person = new ClsUtilizationLogin();
			if (Person != null) 
			{
				this.Hide();
				frmShowProductToPerson Product = new frmShowProductToPerson();
				Product.ShowDialog();
			}
			else
			{

			}
			
			
		}

		private void llLoginByUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			frmLoginByUser User = new frmLoginByUser();
			User.ShowDialog();
			
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void llRememberMe_Click(object sender, EventArgs e)
		{
	
		}

		private void frmLoginScreen_Load(object sender, EventArgs e)
		{
			string Email = txtEmail.Text;
			string Password = txtPassword.Text;

			if (ClsUtilizationLogin.GetStoredCredentialEmail(ref Email, ref Password))
			{
				txtEmail.Text = Email;
				txtPassword.Text = Password;
				llRememberMe.Checked = true;
			}
			else
				llRememberMe.Checked = false;
		}

		private void llRememberMe_CheckedChanged(object sender, EventArgs e)
		{
			ClsUtilizationLogin.RememberEmailAndPassword(txtEmail.Text, txtPassword.Text);
		}
	}
}
