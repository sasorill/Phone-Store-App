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
	public partial class frmAddUpdateUser : Form
	{
		public enum enMode { AddNew=0, Update=1};

		private enMode _Mode = enMode.AddNew;

		private int _UserID = -1;

		private ClsUsers _Users;

		public frmAddUpdateUser()
		{
			InitializeComponent();
			_Mode = enMode.AddNew;
		}

		public frmAddUpdateUser(int UserID)
		{
			InitializeComponent();
			_Mode = enMode.Update;
			this._UserID = UserID;
		}

		private void _DefaultView()
		{
			if (_Mode == enMode.AddNew) 
			{
				this.Text = "Add New User";
				_Users = new ClsUsers();
				ctrlFindPerson1.FilterFocus();
				laPersonID.Text = ctrlFindPerson1.PersonID.ToString();
			}
			else
			{
				this.Text = "Update User";
			}
		}

		private void _FillUserInfo()
		{
			_UserID = _Users.UserID;
			txtUserName.Text = _Users.UserName;
			txtPassword.Text = _Users.Password;
			chkIsActive.Checked = _Users.IsActive;
			laPersonID.Text = _Users.PersonID.ToString();
			laUserID.Text = _Users.UserID.ToString();
			ctrlFindPerson1.LoadPersonInfo(_Users.PersonID);
		}

		private void _LoadUserInfo()
		{
			_Users = ClsUsers.FindID(_UserID);

			if(_Users == null)
			{
				MessageBox.Show("No UserID With ["+_UserID.ToString()+"] This","Not Found",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			_FillUserInfo();
		}

		private void frmAddUpdateUser_Load(object sender, EventArgs e)
		{
			_DefaultView();
			if (_Mode == enMode.Update)
				_LoadUserInfo();
		}	

		private void btnSave_Click(object sender, EventArgs e)
		{
			if(!this.ValidateChildren())
			{
				MessageBox.Show("Some Of Children Are Not Correct", "False", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_Users.UserName = txtUserName.Text;
			_Users.Password = ClsValidate.HashingPassword(txtPassword.Text);
			_Users.PersonID = ctrlFindPerson1.PersonID;
			if(chkIsActive.Checked)
			{
				_Users.IsActive = true;
			}
			else
			{
				_Users.IsActive = false;
			}

			if(_Users.Save())
			{
				_Mode = enMode.Update;
				this.Text = "Update";
				laUserID.Text = _Users.UserID.ToString();
				MessageBox.Show("Save Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
				MessageBox.Show("Save Failure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void frmAddUpdateUser_Activated(object sender, EventArgs e)
		{
			ctrlFindPerson1.FilterFocus();
		}

		private void ctrlFindPerson1_OnFindComplete(int obj)
		{
			

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ctrlFindPerson1_OnFindComplete_1(int obj)
		{
			laPersonID.Text = obj.ToString();

			_Users = ClsUsers.FindByPerson(obj);

			if (_Users != null)
			{
				panel1.Enabled = false;
				MessageBox.Show("This Person Is Use To Another User", "Property", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				panel1.Enabled = true;
			}
		}
	}
}
