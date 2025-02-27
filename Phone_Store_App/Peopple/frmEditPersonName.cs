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
	public partial class frmEditPersonName : Form
	{

		public frmEditPersonName(int personID)
		{
			InitializeComponent();
			_PersonID = personID;
		}

		private int _PersonID;

		private ClsPeople _Person;

		private void _FillPersonData()
		{
			txtFirstName.Text = _Person.FirstName;
			txtSecondName.Text = _Person.SecondName;
			txtLastName.Text = _Person.LastName;
			txtEmail.Text = _Person.Email;
		}

		private void _Refresh()
		{
			_Person = ClsPeople.FindID(_PersonID);

			if(_Person != null)
			{
				_FillPersonData();
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmEditPersonName_Load(object sender, EventArgs e)
		{
			_Refresh();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string U = ClsUtilizationLogin.HashingPasswordToSHA1(txtPassword.Text);

			if (ClsPeople.EditPersonNameByEmailAndPassword(txtFirstName.Text, txtSecondName.Text, txtLastName.Text, txtEmail.Text, U)) 
			{
				MessageBox.Show("Saved", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Not Saved", "InCorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
