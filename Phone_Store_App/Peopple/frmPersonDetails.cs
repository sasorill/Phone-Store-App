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
	public partial class frmPersonDetails : Form
	{
		
		public frmPersonDetails(int personID)
		{
			InitializeComponent();
			ctrlPersonDetails1.LoadPersonInfoByID(personID);
		}

		private void frmPersonDetails_Load(object sender, EventArgs e)
		{
			
		}
	}
}
