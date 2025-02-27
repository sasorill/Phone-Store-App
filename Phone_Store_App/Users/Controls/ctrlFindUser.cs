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
	public partial class ctrlFindUser : UserControl
	{
		public ctrlFindUser()
		{
			InitializeComponent();
		}

		public int UserID
		{
			get { return ctrlUserDetails1.UserID; }
		}

		private void FilterBy()
		{
			switch(cbFilterBy.Text)
			{
				case "User ID":
					ctrlUserDetails1.LoadUsersInfoByID(int.Parse(txtFilterBy.Text));
					break;

				case "Person ID":
					ctrlUserDetails1.LoadUsersInfoByPersonID(int.Parse(txtFilterBy.Text));
					break;

				case "User Name":
					ctrlUserDetails1.LoadUsersInfoByName(txtFilterBy.Text);
					break;
			}
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			//cbFilterBy.SelectedIndex = 0;
			FilterBy();
	
			cbFilterBy.Focus();
		}

		private void btnAddNew_Click(object sender, EventArgs e)
		{
			frmAddUpdateUser frmAdd = new frmAddUpdateUser();
			frmAdd.ShowDialog();
		}
	}
}
