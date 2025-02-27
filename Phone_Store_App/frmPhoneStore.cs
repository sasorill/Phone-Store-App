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
	public partial class frmPhoneStore : Form
	{
		public frmPhoneStore()
		{
			InitializeComponent();
		}

		private void allGategoriesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAllCategories frmAllCategories1 = new frmAllCategories();
			frmAllCategories1.ShowDialog();
		}

		private void creditCardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (frmCreditCard frmCreditCard1 = new frmCreditCard())
			{
				frmCreditCard1.ShowDialog();
			}
				
		}

		private void allOrdersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmOrders Orders = new frmOrders();
			Orders.ShowDialog();
		}

		private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmPeople frmPeople1 = new frmPeople();
			frmPeople1.ShowDialog();
		}

		private void usersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmUsers User = new frmUsers();
			User.ShowDialog();
		}

		private void productItemsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void productsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmProducts frm = new frmProducts();
			frm.ShowDialog();
			
		}

		private void currentUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmUserDetails User = new frmUserDetails(ClsUtilizationLogin.Users.UserID);
			User.ShowDialog();
		}
	}
}
