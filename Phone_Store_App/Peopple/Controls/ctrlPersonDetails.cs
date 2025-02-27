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
	public partial class ctrlPersonDetails : UserControl
	{
		public ctrlPersonDetails()
		{
			InitializeComponent();
		}

		private int _PersonID = -1;

		public int PersonID
		{
			get { return _PersonID; }
			set { _PersonID = value; }
		}

		private ClsPeople _Person;

		private void _DefaultView()
		{
			laPersonID.Text = "???";
			laFullName.Text = "???";
			laBirthOfDate.Text = "???";
			laCountry.Text = "???";
			laCity.Text = "???";
			laEmail.Text = "???";
			laPhone.Text = "???";
			pbPerson.ImageLocation = null;
		}

		private void _FillNew()
		{
			_PersonID = _Person.PersonID;
			laPersonID.Text = _Person.PersonID.ToString();
			laFullName.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.LastName;
			laBirthOfDate.Text = _Person.DateOfBirth.ToString();
			laCountry.Text = _Person.Country.CountryName;
			laCity.Text = _Person.City;
			laEmail.Text = _Person.Email;
			laPhone.Text = _Person.Phone;
			if (_Person.Image != "") 
			{
				pbPerson.ImageLocation = _Person.Image;
			}
			else
			{
				pbPerson = null;
			}
		}

		public void LoadPersonInfoByID(int PersonID)
		{
			_Person = ClsPeople.FindID(PersonID);

			if (_Person == null)
			{
				_DefaultView();
				MessageBox.Show("No PersonID With ["+PersonID.ToString()+"]","Not Found",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_FillNew();
		}

		public void LoadPersonInfoByEmail(string Email)
		{
			_Person = ClsPeople.FindEmail(Email);

			if (_Person == null)
			{
				MessageBox.Show("No PersonID With [" + Email + "]", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_FillNew();
		}

		public void LoadPersonInfoByPhone(string Phone)
		{
			_Person = ClsPeople.FindPhone(Phone);

			if (_Person == null)
			{
				MessageBox.Show("No PersonID With [" + Phone + "]", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_FillNew();
		}

		public void LoadPersonInfoByFirstName(string FirstName)
		{
			_Person = ClsPeople.FindFirstName(FirstName);

			if (_Person == null)
			{
				MessageBox.Show("No PersonID With [" + FirstName + "]", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_FillNew();
		}
	}
}
