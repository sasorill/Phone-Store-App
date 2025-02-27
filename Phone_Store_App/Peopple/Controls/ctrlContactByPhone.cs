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
	public partial class ctrlContactByPhone : UserControl
	{
		public ctrlContactByPhone()
		{
			InitializeComponent();
		}

		ClsPeople Person;

		private void _FillData()
		{
			laFullName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.LastName;
			laPhone.Text = Person.Phone;
		}

		public void LoadPersonPhoneByID(int PersonID)
		{
			Person = ClsPeople.FindID(PersonID);

			if(Person == null)
			{
				MessageBox.Show("No Phone With PersonID [" + PersonID.ToString() + "]", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				_FillData();
			}
		}

		private void ctrlCall_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This Feature Is Not Ready Yet", "UnAvailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ctrlCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(Person.Phone);
			
		}
	}
}
