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
	public partial class frmPeople : Form
	{
		public frmPeople()
		{
			InitializeComponent();
		}

		ClsPeople Person;

		private int _PersonID = -1;

		private static DataTable _AllPeople = ClsPeople.GetAllPeople();

		private static DataTable _People = _AllPeople.DefaultView.ToTable(false, "PersonID", "FirstName", "SecondName", "LastName", "DateOfBirth", "Name", "City", "Email", "Phone");

		private void _RefreshAllPeople()
		{
			dgvAllPeople.DataSource = _People;
			laPeopleCount.Text = dgvAllPeople.Rows.Count.ToString();
	       
		}

		private void frmPeople_Load(object sender, EventArgs e)
		{
			cbFilterBy.SelectedIndex = 0;
			cbFilterBy.Focus();
			dgvAllPeople.DataSource = _People;
			laPeopleCount.Text = dgvAllPeople.Rows.Count.ToString();
			

			if(dgvAllPeople.Rows.Count>0)
			{
				dgvAllPeople.Columns[0].HeaderText = "Person ID";
				dgvAllPeople.Columns[0].Width = 100;

				dgvAllPeople.Columns[1].HeaderText = "First Name";
				dgvAllPeople.Columns[1].Width = 100;

				dgvAllPeople.Columns[2].HeaderText = "Second Name";
				dgvAllPeople.Columns[2].Width = 100;

				dgvAllPeople.Columns[3].HeaderText = "Last Name";
				dgvAllPeople.Columns[3].Width = 100;

				dgvAllPeople.Columns[4].HeaderText = "Date";
				dgvAllPeople.Columns[4].Width = 100;

				dgvAllPeople.Columns[5].HeaderText = "Country";
				dgvAllPeople.Columns[5].Width = 100;

				dgvAllPeople.Columns[6].HeaderText = "City";
				dgvAllPeople.Columns[6].Width = 100;

				dgvAllPeople.Columns[7].HeaderText = "Email";
				dgvAllPeople.Columns[7].Width = 100;

				dgvAllPeople.Columns[8].HeaderText = "Phone";
				dgvAllPeople.Columns[8].Width = 100;
			}
		}

		private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmPersonDetails frm = new frmPersonDetails((int)dgvAllPeople.CurrentRow.Cells[0].Value);
			frm.ShowDialog();
		}

		private void findPersonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmFindPerson Person = new frmFindPerson();
			Person.ShowDialog();
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Are You Sure You Want To Delete Cell?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if(this.Person.Delete())
				{
					MessageBox.Show("Delete Succeeded","Successful",MessageBoxButtons.OK,MessageBoxIcon.Question);
				}
				else
				{
					MessageBox.Show("Delete Failure", "False", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
		}

		private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAddUpdatePerson Person = new frmAddUpdatePerson();
			Person.ShowDialog();
			_RefreshAllPeople();
		}

		private void updateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int PersonID =(int) dgvAllPeople.CurrentRow.Cells[0].Value;
			frmAddUpdatePerson Person = new frmAddUpdatePerson(PersonID);
			Person.ShowDialog();
			_RefreshAllPeople();
		}

		private void txtFilterBy_TextChanged(object sender, EventArgs e)
		{
			string Rows = "";
			switch(cbFilterBy.Text)
			{
				case "Person ID":
					Rows = "PersonID";
					break;

				case "Email":
					Rows = "Email";
					break;

				case "Phone":
					Rows = "Phone";
					break;

				case "First Name":
					Rows = "FirstName";
					break;

			}

			if (Rows == "PersonID")
			{
				_People.DefaultView.RowFilter = string.Format("[{0}] = {1}", Rows, txtFilterBy.Text.Trim());

			}
			else
				_People.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", Rows, txtFilterBy.Text.Trim());
		}

		private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void contactsInfoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmPersonPhoneContact Phone = new frmPersonPhoneContact((int)dgvAllPeople.CurrentRow.Cells[0].Value);
			Phone.ShowDialog();
		}

		private void contactByEmailToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int PersonID = (int)dgvAllPeople.CurrentRow.Cells[0].Value;

			Person = ClsPeople.FindID(PersonID);

			if (Person != null) 
			{

				frmSendMessageViaEmail Email = new frmSendMessageViaEmail(Person.PersonID, Person.Email);
				Email.ShowDialog();
            }
			
		}
	}
}
