using Phone_Store_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Store_App
{
	public partial class frmAddUpdatePerson : Form
	{
		public delegate void DataBackHandler(object sender, int PersonID);

		public event DataBackHandler DataBack;

		private int _PersonID = -1;

		private ClsPeople _Person;

		public enum enMode {AddNew = 0, Update = 1};

		private enMode _Mode = enMode.AddNew;

		public frmAddUpdatePerson(int PersonID)
		{
			InitializeComponent();
			_Mode = enMode.Update;
			this._PersonID = PersonID;
		}

		public frmAddUpdatePerson()
		{
			InitializeComponent();
			_Mode= enMode.AddNew;
		}

		private void _DefaultView()
		{
			_FillCountryInComboBox();
			if (_Mode == enMode.AddNew) 
			{
				this.Text = "Add New Person";
				_Person = new ClsPeople();
				
			}
			else
			{
				this.Text = "Update Person";
			}
		}

		private void _FillCountryInComboBox()
		{
			DataTable dtCounty = ClsCountries.GetAllCountry();

			foreach(DataRow Row in dtCounty.Rows)
			{
				cbCountry.Items.Add(Row["Name"]);
			}
		}

		private void _FillPersonInfo()
		{
			laPersonID.Text = _Person.PersonID.ToString();
			txtFirstName.Text = _Person.FirstName;
			txtSecondName.Text = _Person.SecondName;
			txtLastName.Text = _Person.LastName;
			dtpDateOfBirth.Value = _Person.DateOfBirth;
			cbCountry.SelectedIndex = cbCountry.FindString(_Person.Country.CountryName);
			txtCity.Text = _Person.City;
			txtEmail.Text = _Person.Email;
			txtPassword.Text = _Person.Password;
			txtPhone.Text = _Person.Phone;
			if (_Person.Image != "") 
			{
				pbPerson.ImageLocation = _Person.Image;
			}
			else
			{
				pbPerson.ImageLocation = "";
			}

		}

		private void _LoadPersonInfo()
		{
			_Person = ClsPeople.FindID(_PersonID);

			if (_Person == null)
			{
				MessageBox.Show("No PersonID With [" + _PersonID.ToString() + "] ID","Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				_FillPersonInfo();
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if(!this.ValidateChildren())
			{
				MessageBox.Show("Some Of Field Are Not Correct","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_Person.FirstName = txtFirstName.Text.Trim();
			_Person.SecondName = txtSecondName.Text.Trim();
			_Person.LastName = txtLastName.Text.Trim();
			_Person.DateOfBirth = dtpDateOfBirth.Value;
			_Person.CountryID = ClsCountries.Find(cbCountry.Text).CountryID;
			_Person.City = txtCity.Text.Trim();
			_Person.Email = txtEmail.Text.Trim();
			_Person.Password = ClsUtilizationLogin.HashingPasswordToSHA1(txtPassword.Text);
			_Person.Phone = txtPhone.Text.Trim();
			if (pbPerson.ImageLocation != "") 
			{
				_Person.Image = pbPerson.ImageLocation;
			}
			else
			{
				_Person.Image = "";
			}

			if(_Person.Save())
			{
				_Mode = enMode.Update;
				this.Text = "Update Person";
				laPersonID.Text = _Person.PersonID.ToString();
				MessageBox.Show("Save Succeeded","Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
				MessageBox.Show("Save Failure", "False", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}

		private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
			openFileDialog1.FilterIndex = 0;
			openFileDialog1.RestoreDirectory = true;
			
			DialogResult Result = openFileDialog1.ShowDialog();

			if (Result == DialogResult.OK)
			{
				string FileName = openFileDialog1.FileName;
				pbPerson.Load(FileName);
				llRemoveImage.Visible = true;
			}
		}

		private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			pbPerson.ImageLocation= null;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmAddUpdatePerson_Load(object sender, EventArgs e)
		{
			_DefaultView();
			if (_Mode == enMode.Update)
				_LoadPersonInfo();
		}

		private void txtEmail_Validating(object sender, CancelEventArgs e)
		{
			ErrorProvider errorProvider = new ErrorProvider();
			if(!ClsValidate.EmailValidate(txtEmail.Text))
			{
				e.Cancel = true;
				errorProvider.SetError(txtEmail, "Invalid Email Address");
			}
			else
			{
				errorProvider.SetError(txtEmail, null);
			}
		}
	}
}
