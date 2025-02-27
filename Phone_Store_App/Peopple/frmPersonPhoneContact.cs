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
	public partial class frmPersonPhoneContact : Form
	{
		public frmPersonPhoneContact(int PersonID)
		{
			InitializeComponent();
			ctrlContactByPhone1.LoadPersonPhoneByID(PersonID);
		}

		private void ctrlContactByPhone1_Load(object sender, EventArgs e)
		{

		}
	}
}
