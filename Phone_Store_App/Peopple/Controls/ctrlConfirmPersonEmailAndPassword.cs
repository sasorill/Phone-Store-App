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
	public partial class ctrlConfirmPersonEmailAndPassword : UserControl
	{
		public ctrlConfirmPersonEmailAndPassword()
		{
			InitializeComponent();
		}

		ClsPeople Person;

		public string Email
		{
			get { return Person.Email; }
		}

		public void LoadData()
		{
			txtEmail.Text = Person.Email;
		}

		public bool LoadConfirmEmailAndPassword(string Email, string Password)
		{
			string U = ClsUtilizationLogin.HashingPasswordToSHA1(Password);
			 Person = ClsPeople.FindPersonByEmailAndPassword(Email, U);

			ErrorProvider Error = new ErrorProvider();

			if(txtRePassword.Text != txtPassword.Text)
			{
				
				Error.SetError(txtRePassword, "It's Not Equal Password 1");
			}
			else
			{
				Error.SetError(txtRePassword, null);
			}

			if(Person != null )
			{
				//LoadData();
				return true;
			}
			else
			{
				MessageBox.Show("Email And Password Both Of Them Are Not Correct", "Not done", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
	}
}
