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
	public partial class ctrlFindCard : UserControl
	{
		public ctrlFindCard()
		{
			InitializeComponent();
		}

		private void _FilterBy()
		{
			switch(cbFilterBy.Text)
			{
				case "Card ID":
					ctrlCardDetails1.LoadCardInfo(int.Parse(txtFilterBy.Text));
					break;
				case "Card Number":
					ctrlCardDetails1.LoadCardInfo(txtFilterBy.Text);
					break;
				case "Person ID":
					ctrlCardDetails1.LoadCardInfoPerson(int.Parse(txtFilterBy.Text));
					break;
				default:
					break;
			}
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			_FilterBy();
			cbFilterBy.Focus();
		}

		private void ctrlFindCard_Load(object sender, EventArgs e)
		{
			cbFilterBy.SelectedIndex = 0;
			cbFilterBy.Focus();
		}
	}
}
