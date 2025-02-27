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
	public partial class ctrlUserDetails : UserControl
	{
		public ctrlUserDetails()
		{
			InitializeComponent();
		}

		private int _UserID = -1;

		public int UserID
		{
			get { return _UserID; }
			set { _UserID = value; }
		}

		private ClsUsers _Users;

		public ClsUsers Users
		{
			get { return _Users; }
		}

		private void _FillUserInfo()
		{
			_UserID = _Users.UserID;
			laUserID.Text = _UserID.ToString();
			laUserName.Text = _Users.UserName;
			laIsActive.Text = _Users.IsActive == true ? "Yes" : "No";
			ctrlPersonDetails1.LoadPersonInfoByID(_Users.PersonID);
		}

		public void LoadUsersInfoByID(int UserID)
		{
			_Users = ClsUsers.FindID(UserID);

			if (_Users == null) 
			{
				MessageBox.Show("This PersonID [" + UserID.ToString() + "] Does Not Match Any One", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_FillUserInfo();
		}

		public void LoadUsersInfoByName(string UserName)
		{
			_Users = ClsUsers.Find(UserName);

			if (_Users == null)
			{
				MessageBox.Show("This User Name [" + UserName + "] Does Not Match Any One", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_FillUserInfo();
		}

		public void LoadUsersInfoByPersonID(int PersonID)
		{
			_Users = ClsUsers.FindByPerson(PersonID);

			if (_Users == null)
			{
				MessageBox.Show("This PersonID [" + PersonID.ToString() + "] Does Not Match Any One", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_FillUserInfo();
		}

	}
}
