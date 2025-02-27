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
	public partial class frmCardDetails : Form
	{
		private int _CardID;
		public frmCardDetails(int CardID)
		{
			InitializeComponent();
			_CardID = CardID;
		}

		private void frmCardDetails_Load(object sender, EventArgs e)
		{
			ctrlCardDetails1.LoadCardInfo(_CardID);
		}
	}
}
