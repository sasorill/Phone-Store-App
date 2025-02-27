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
	public partial class frmUsers : Form
	{
		public frmUsers()
		{
			InitializeComponent();
		}

		private static DataTable _dtAllUsers = ClsUsers.GetAllUsers();

		private static DataTable _Users = _dtAllUsers.DefaultView.ToTable(false, "UserID", "PersonID", "UserName", "IsActive");

		ClsUsers Users;

		private void _RefreshAllUsers()
		{
			dgvUsers.DataSource = _Users;
			laCountUsers.Text = dgvUsers.Rows.Count.ToString();
		}

		private void frmUsers_Load(object sender, EventArgs e)
		{
			_RefreshAllUsers();
			dgvUsers.Columns[0].HeaderText = "User ID";
			dgvUsers.Columns[0].Width = 100;

			dgvUsers.Columns[1].HeaderText = "Person ID";
			dgvUsers.Columns[1].Width = 100;

			dgvUsers.Columns[2].HeaderText = "User Name";
			dgvUsers.Columns[2].Width = 100;

			dgvUsers.Columns[3].HeaderText = "Is Active";
			dgvUsers.Columns[3].Width = 100;
		}

		private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;

			Users = ClsUsers.FindID(UserID);

			if(Users == null)
			{
				MessageBox.Show("There Is Not Any User Yet", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			frmUserDetails frmUser = new frmUserDetails(UserID);
			frmUser.ShowDialog();
			_RefreshAllUsers();

		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Are You Sure Yo Wanna Delete This Cell?","Confirm To Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
			{
				if(this.Users.Delete())
				{
					MessageBox.Show("Delete Cell Succeeded", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
					_RefreshAllUsers();
				}
				else
				{
					MessageBox.Show("Delete Cell Failure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void activeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int UserID = (int)dgvUsers.CurrentRow.Cells [0].Value;

			Users = ClsUsers.FindID(UserID);

			if (Users != null) 
			{
				if(Users.IsActive)
				{
					MessageBox.Show("The User Is Already Activated", "Active", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					if(MessageBox.Show("Are You Sure You Want To Active This Cell?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
					{
						if(ClsUsers.ActivateUser(UserID))
						{
							MessageBox.Show("Activate User Succeeded", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
							_RefreshAllUsers();
						}
						else
						{
							MessageBox.Show("An Error Occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
		}

		private void unActiveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;

			Users = ClsUsers.FindID(UserID);

			if (Users != null)
			{
				if (!Users.IsActive)
				{
					MessageBox.Show("The User Is Already UnActivated", "UnActive", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					if (MessageBox.Show("Are You Sure You Want To UnActive This Cell?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						if (ClsUsers.UnActiveUser(UserID))
						{
							MessageBox.Show("UnActivate User Succeeded", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
							_RefreshAllUsers();
						}
						else
						{
							MessageBox.Show("An Error Occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
		}

		private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAddUpdateUser frmUser = new frmAddUpdateUser();
			frmUser.ShowDialog();
			_RefreshAllUsers();
		}

		private void updateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAddUpdateUser frmUser = new frmAddUpdateUser((int)dgvUsers.CurrentRow.Cells[0].Value);
			frmUser.ShowDialog();
			_RefreshAllUsers();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			string ColumnRow = "";

			switch(cbFilterBy.Text)
			{
				case "User ID":
					ColumnRow = "UserID";
					break;

				case "Person ID":
					ColumnRow = "PersonID";
					break;
			}

			_Users.DefaultView.RowFilter = string.Format("[{0}] = {1}", ColumnRow, txtFilterBy.Text.Trim());
			
		}

		private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbFilterBy.Focus();
			cbFilterBy.SelectedIndex = 0;
			
		}

		private void findUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmFindUser frmFindUser = new frmFindUser();
			frmFindUser.ShowDialog();
			_RefreshAllUsers();
		}
	}
}
