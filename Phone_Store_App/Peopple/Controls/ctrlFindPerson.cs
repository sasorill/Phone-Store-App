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
	public partial class ctrlFindPerson : UserControl
	{
		public ctrlFindPerson()
		{
			InitializeComponent();
		}

		public event Action<int> OnFindComplete;
		
		protected virtual void PersonSelected(int PersonID)
		{
			Action<int> Handler = OnFindComplete;

			if( Handler != null )
			{
				Handler(PersonID);
			}
		}

		public int PersonID
		{
			get { return ctrlPersonDetails1.PersonID; }
			set { ctrlPersonDetails1.PersonID = value; }
		}

		private void FilterBy()
		{
			switch(cbFilterBy.Text)
			{
				case "Person ID":
					
					ctrlPersonDetails1.LoadPersonInfoByID(int.Parse(txtFilterBy.Text));
					break;

				case "Email":
					ctrlPersonDetails1.LoadPersonInfoByEmail(txtFilterBy.Text);
					break;

				case "Phone":
					ctrlPersonDetails1.LoadPersonInfoByPhone(txtFilterBy.Text);
					break;

				case "First Name":
					ctrlPersonDetails1.LoadPersonInfoByFirstName(txtFilterBy.Text);
					break;
				default:
					break;
			}
			if(OnFindComplete!=null)
			{
				OnFindComplete(ctrlPersonDetails1.PersonID);
			}
		}

		public void LoadPersonInfo(int PersonID)
		{
			cbFilterBy.SelectedIndex = 0;
			txtFilterBy.Text = PersonID.ToString();
			FilterBy();
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			FilterBy();
			cbFilterBy.SelectedIndex = 0;
			cbFilterBy.Focus();
			if (string.IsNullOrEmpty(txtFilterBy.Text))
			{
				errorProvider1.SetError(txtFilterBy, "The Text Must Assign Value");
			}
			else
			{
				errorProvider1.SetError(txtFilterBy, "");
			}
		}

		private void ctrlFindPerson_Load(object sender, EventArgs e)
		{
			cbFilterBy.Focus();
			var Person = ClsUtilizationLogin.Person;

			if(Person != null)
			{
				panel1.Visible = false;
				//btnAddNew.Visible = false;
				//panel1.Height = 81;
				//panel1.Width = 960;
			}
			else
			{
				panel1.Visible = true;
				//btnAddNew.Visible = true;
				//panel1.Height = 81;
				//panel1.Width = 1172;
			}
		}

		private void btnAddNew_Click(object sender, EventArgs e)
		{
			frmAddUpdatePerson frm = new frmAddUpdatePerson();
			frm.DataBack += DataBack;
			frm.ShowDialog();
		}

		public void DataBack(object sender, int PersonID)
		{
			cbFilterBy.SelectedIndex = 0;
			txtFilterBy.Text += PersonID.ToString();
			ctrlPersonDetails1.LoadPersonInfoByID(PersonID);
		}

		public void FilterFocus()
		{
			txtFilterBy.Focus();
		}
	}
}
