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
	public partial class frmEditPersonPassword : Form
	{
		private int _PersonID;

		private ClsPeople _Person;

		public frmEditPersonPassword(int personID)
		{
			InitializeComponent();
			_PersonID = personID;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			ErrorProvider Error = new ErrorProvider();

			string NewPassword = ClsUtilizationLogin.HashingPasswordToSHA1(txtNewPassword.Text);
			string OldPassword = ClsUtilizationLogin.HashingPasswordToSHA1(txtOldPassword.Text);
			string ConfirmPassword = ClsUtilizationLogin.HashingPasswordToSHA1(txtConfirmPassword.Text);

			_Person = ClsPeople.FindID(_PersonID);

			if (_Person != null)
			{
				if(ClsPeople.EditPersonPasswordByEmailAndPassword(NewPassword,_Person.Email,OldPassword))
				{
					if (txtConfirmPassword.Text != txtOldPassword.Text) 
					{
						
						Error.SetError(txtConfirmPassword, "Old Password Doesn't Equal Confirm Password");
					}
					else
					{
						Error.SetError(txtConfirmPassword, null);
						MessageBox.Show("Saved", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
					MessageBox.Show("Saved", "False", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
