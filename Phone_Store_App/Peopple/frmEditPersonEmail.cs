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

namespace Phone_Store_App.EditPerson
{
	public partial class frmEditPersonEmail : Form
	{
		private int _PersonID;

		private ClsPeople _Person;

		public frmEditPersonEmail(int personID)
		{
			InitializeComponent();
			_PersonID = personID;
		}

		private void _FillPersonData()
		{
			txtCurrentEmail.Text = _Person.Email;
			txtConfirmEmail.Text = _Person.Email;
			txtConfirmEmail.Enabled = false;
		}

		private void _Refresh()
		{
			_Person = ClsPeople.FindID(_PersonID);

			if (_Person != null)
			{
				_FillPersonData();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string Password = ClsUtilizationLogin.HashingPasswordToSHA1(txtConfirmPassword.Text);
			if (ClsPeople.EditPersonEmailByEmailAndPassword(txtCurrentEmail.Text, txtConfirmEmail.Text, Password)) 
			{
				MessageBox.Show(" Saved", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Not Saved", "False", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			
		}

		private void frmEditPersonEmail_Load(object sender, EventArgs e)
		{
			_Refresh();
		}
	}
}
